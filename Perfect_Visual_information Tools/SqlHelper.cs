using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Data.OleDb;
using System.Data.SqlClient;
using System.Configuration;
using System.IO;

namespace Perfect_Visual_神龙信息经理辅助
{
    public class SqlHelper
    {
        private static string strConn = ConfigurationManager.ConnectionStrings["connStr"].ConnectionString;
        #region  格式化SQL语句相关方法
        #region 增删改查操作
        /// <summary>
        /// 执行增删查改操作
        /// </summary>
        /// <param name="sql">sql字符串</param>
        /// <returns>返回受影响的行数</returns>
        public static int Update(string sql)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                //错误写入系统日志
                string info = "调用 public int Update(string sql)方法错误" + ex.Message;
                WriteLog(info);
                throw new Exception(info);
            }
            finally
            { conn.Close(); }
        }
        #endregion

        #region  单一结果查询
         //<summary>
         //执行单一结果查询，可以同时执行增删查改操作
         //</summary>
         //<param name="sql">SQL参数</param>
         //<returns>返回第一行第一列</returns>
        public static object GetSingleResult(string sql)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //错误写入系统日志
                string info = "public static object SingleResult(string sql)方法错误" + ex.Message;
                WriteLog(info);
                throw new Exception(info);
            }
            finally
            { conn.Close(); }
        }
        #endregion

        #region 执行返回一个结果集
        /// <summary>
        /// 执行返回一个结果集
        /// </summary>
        /// <param name="sql"></param>
        /// <returns>返回结果集</returns>
        public static SqlDataReader GetReader(string sql)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                //SqlDataReader objReader = cmd.ExecuteReader();
                //return objReader;
                return cmd.ExecuteReader(CommandBehavior.CloseConnection);
                //CommandBehavior.CloseConnection 保证从调用者那里关闭datareader对象时同时关闭 connection连接
            }
            catch (Exception ex)
            {
                string info = "public static SqlDataReader GetReader (string sql)方法错误" + ex.Message;
                WriteLog(info);
                throw new Exception(info);
            }
        }
        #endregion
        #endregion

        #region 编写带参数的SQL语句相关方法
        #region 带参数的更新方法
        /// <summary>
        /// 执行带参数SQL的更新方法（增 删 改 操作）
        /// </summary>
        /// <param name="sql">带参数的SQL语句</param>
        /// <param name="param">参数的数组</param>
        /// <returns>返回受影响的行数</returns>
        //public static int Update(string sql, SqlParameter[] param)
        //{
        //    SqlConnection conn = new SqlConnection(strConn);
        //    SqlCommand cmd = new SqlCommand(sql, conn);
        //    try
        //    {
        //        conn.Open();
        //        cmd.Parameters.AddRange(param); //给command对象添加参数
        //        return cmd.ExecuteNonQuery();
        //    }
        //    catch (Exception ex)
        //    {
        //        //错误写入系统日志
        //        string info = "调用 public int Update(string sql)方法错误" + ex.Message;
        //        WriteLog(info);
        //        throw new Exception(info);
        //    }
        //    finally
        //    { conn.Close(); }
        //}
        #endregion

        #region  带参数的单一结果查询
        /// <summary>
        /// 带参数的单一结果查询
        /// </summary>
        /// <param name="sql">带参数的SQL语句</param>
        /// <param name="param">参数的数组</param>
        /// <returns>返回第一行第一列</returns>
        public static object GetSingleResult(string sql,SqlParameter[]param)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //错误写入系统日志
                string info = "public static object SingleResult(string sql)方法错误" + ex.Message;
                WriteLog(info);
                throw new Exception(info);
            }
            finally
            { conn.Close(); }
        }
        #endregion

        #region 带参数的结果集查询
        /// <summary>
        /// 带参数的结果集查询
        /// </summary>
        /// <param name="sql">带参数的SQL语句</param>
        /// <param name="param">参数的数组</param>
        /// <returns>返回查询结果集</returns>
        public static object GetResult1(string sql,SqlParameter[]param)
        {
            SqlConnection conn = new SqlConnection(strConn);
            SqlCommand cmd = new SqlCommand(sql, conn);
            try
            {
                conn.Open();
                cmd.Parameters.AddRange(param);
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                //错误写入系统日志
                string info = "public static object SingleResult(string sql)方法错误" + ex.Message;
                WriteLog(info);
                throw new Exception(info);
            }
            finally
            { conn.Close(); }
        }
        #endregion

        #endregion


        #region  日志写入方法
        /// <summary>
        /// 错误信息写入日志
        /// </summary>
        /// <param name="log"></param>
        public static void WriteLog(string log)
        {
            FileStream fs = new FileStream("sqlhelper.log", FileMode.Append);
            StreamWriter sw = new StreamWriter(fs);
            sw.WriteLine(DateTime.Now.ToString() + "错误信息：" + log);
            sw.Close();
            fs.Close();
        }
        #endregion
    }
}
