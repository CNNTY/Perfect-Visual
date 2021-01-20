
using System;
using System.Collections.Generic;
using System.Text;
using System.Data.SqlClient;
using System.Data;
using System.Collections;
using System.Configuration;
using System.Data.Common;

namespace Perfect_Visual_神龙信息经理辅助
{
    public class DBHelperSql
    {
        private static string strConn = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        //System.Configuration.ma
        private SqlConnection conn = null;
        private SqlCommand cmd = null;
        #region 事务
        [ThreadStatic]
        public static SqlConnection TransactionSqlConnection = null;
        [ThreadStatic]
        public static SqlTransaction Transaction = null;
        [ThreadStatic]
        public static int CurrentTransactionCount = 0;
        public static void BiginTransaction(string connStr = null)
        {
            if (TransactionSqlConnection != null && Transaction != null && CurrentTransactionCount > 0)
            {
                CurrentTransactionCount++;
                return;
            }
            StopTransaction();//开始事务前，先全部复原
            if (connStr == null)
                connStr = strConn;
            TransactionSqlConnection = new SqlConnection(connStr);
            if (TransactionSqlConnection.State == ConnectionState.Closed)
            {
                TransactionSqlConnection.Open();
            }
            Transaction = TransactionSqlConnection.BeginTransaction();
            CurrentTransactionCount = 1;
        }
        public static void EndTransaction()
        {
            CurrentTransactionCount--;
            if (CurrentTransactionCount > 0)
                return;
            if (Transaction != null)
            {
                try
                {
                    Transaction.Commit();
                }
                catch
                {
                    Transaction.Rollback();
                }
                finally
                {
                    Transaction.Dispose();
                    Transaction = null;
                }
            }
            if (TransactionSqlConnection != null)
            {
                TransactionSqlConnection.Close();
                TransactionSqlConnection.Dispose();
                TransactionSqlConnection = null;
            }
        }
        public static void StopTransaction()
        {
            CurrentTransactionCount = 0;
            if (Transaction != null)
            {
                Transaction.Rollback();
                Transaction.Dispose();
                Transaction = null;
            }
            if (TransactionSqlConnection != null)
            {
                TransactionSqlConnection.Close();
                TransactionSqlConnection.Dispose();
                TransactionSqlConnection = null;
            }
        }
        #endregion
        public DBHelperSql()
        {
            conn = new SqlConnection(strConn);
        }

        public DBHelperSql(string connStr)
        {
            conn = new SqlConnection(connStr);
        }
        public SqlConnection CurrConnection()
        {
            if (TransactionSqlConnection == null || TransactionSqlConnection.State != ConnectionState.Open)
                return conn;
            else
                return TransactionSqlConnection;
        }
        /// <summary>
        /// 打开数据库连接
        /// </summary>
        public void Open()
        {
            if (TransactionSqlConnection != null && Transaction != null)
                return;
            StopTransaction();
            if (this.conn != null && this.conn.State == ConnectionState.Closed)
            {
                this.conn.Open();
            }
        }

        /// <summary>
        /// 关闭数据库连接
        /// </summary>
        public void Close()
        {
            if (TransactionSqlConnection != null && Transaction != null)
                return;
            StopTransaction();
            if (this.conn != null && this.conn.State == ConnectionState.Open)
            {
                this.conn.Close();
            }
        }

        /// <summary>
        /// 设置参数
        /// </summary>
        /// <param name="cmdText"></param>
        /// <param name="parmas"></param>
        /// <param name="type"></param>
        private void SetParameter(string cmdText, object[] parmas, CommandType type)
        {
            SqlParameter[] parameters = (SqlParameter[])parmas;
            this.cmd = new SqlCommand();
            this.cmd.CommandType = type;
            this.cmd.CommandText = cmdText;
            if (Transaction != null && TransactionSqlConnection != null)
            {
                cmd.Transaction = Transaction;
                this.cmd.Connection = TransactionSqlConnection;
            }
            else
            {
                StopTransaction();
                this.cmd.Connection = this.conn;
            }
            if (this.cmd.Parameters.Count > 0)
            {
                this.cmd.Parameters.Clear();
            }
            if (parameters != null && parameters.Length > 0)
            {
                foreach (SqlParameter p in parameters)
                {
                    this.cmd.Parameters.Add(p);
                }
            }
        }

        /// <summary>
        /// 执行SQL语句，返回操作结果
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="parmas"></param>
        /// <returns></returns>
        public object ExecuteNonQuery(string strSql, DbParameter[] parameters)
        {
            try
            {
                this.Open();
                this.SetParameter(strSql, parameters, CommandType.Text);
                object obj = this.cmd.ExecuteNonQuery();
                this.cmd.Parameters.Clear();
                this.Close();
                return obj;
            }
            catch (SqlException ex)
            {
                this.Close();
                throw ex;
            }
        }

        /// <summary>
        /// 执行SQL语句，返回首行首列值
        /// </summary>
        /// <param name="strSql"></param>
        /// <param name="parmas"></param>
        /// <returns></returns>
        public object ExecuteScalar(string strSql, object[] parmas)
        {
            try
            {
                SqlParameter[] parameters = (SqlParameter[])parmas;
                this.Open();
                this.SetParameter(strSql, parameters, CommandType.Text);
                object obj = this.cmd.ExecuteScalar();
                this.cmd.Parameters.Clear();
                this.Close();
                if (obj != null && obj.Equals(System.DBNull.Value))
                    return null;
                return obj;
            }
            catch (SqlException ex)
            {
                this.Close();
                throw ex;
            }
        }

        /// <summary>
        /// 执行SQL语句，返回结果集
        /// </summary>
        /// <param name="tablename"></param>
        /// <param name="strSql"></param>
        /// <param name="parmas"></param>
        /// <returns></returns>
        public DataSet ExecSqlReturnDataSet(string tablename, string strSql, SqlParameter[] SQLparmas)
        {
            try
            {
                this.Open();
                this.SetParameter(strSql, SQLparmas, CommandType.Text);
                DataSet ds = new DataSet();
                using (SqlDataAdapter da = new SqlDataAdapter())
                {
                    da.SelectCommand = this.cmd;
                    da.Fill(ds, tablename);
                }
                this.cmd.Parameters.Clear();
                this.Close();
                return ds;
            }
            catch (SqlException ex)
            {
                this.Close();
                throw ex;
            }
        }

        public SqlDataReader ExecureReader(string sql, List<SqlParameter> list)
        {
            this.Open();
            this.SetParameter(sql, list.ToArray(), CommandType.Text);
            try
            {
                SqlDataReader rdr;
                if (TransactionSqlConnection != null && Transaction != null)
                {
                    rdr = this.cmd.ExecuteReader();
                }
                else
                {
                    rdr = this.cmd.ExecuteReader(CommandBehavior.CloseConnection);
                }
                this.cmd.Parameters.Clear();
               return rdr;
            }
            catch (Exception ex)
            {
                string sta = CurrConnection().State.ToString();
                this.Close();
                throw new Exception(sta + ex.Message);
            }
        }

        #region 执行分页查询
        /// <summary>
        /// 执行普通SQL分页，目前不支持存储过程，PageIndex从1开始
        /// </summary>
        /// <param name="sql">SQL语句</param>
        /// <param name="sqlpam">查询的参数集合</param>
        /// <param name="pageIndex">页码</param>
        /// <param name="pageSize">页大小</param>
        /// <param name="orderBy">排序依据</param>
        /// <returns>返回查询到的结果集</returns>
        public DataSet ExecGetByPage(string tablename, string sql, SqlParameter[] sqlpam, int pageIndex, int pageSize, string orderBy, out int allCount)
        {
            if (string.IsNullOrWhiteSpace(orderBy))
                orderBy = "(select 0)";
            string sql1 = "select * from (select t.*,row_number() over(order by " + orderBy + ") rownum from (" + sql + ") t ) t0 where rownum>" + ((pageIndex - 1) * pageSize).ToString() + " and rownum<=" + (pageIndex * pageSize).ToString() + "";
            string sqlcount = "SELECT count(*) FROM (" + sql + ") tcount";
            allCount = Convert.ToInt32(ExecuteScalar(sqlcount, null));
            return ExecSqlReturnDataSet(tablename, sql1, sqlpam);
        }
        #endregion

    }
}
