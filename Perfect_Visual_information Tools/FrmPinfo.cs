using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Perfect_Visual_神龙信息经理辅助
{
    public partial class FrmPinfo : Form
    {
        
        public FrmPinfo()
        {
            InitializeComponent();
            //初始化错误代码下拉框
            this.cbCode.Text = "";
        }

        private void btnquerycode_Click(object sender, EventArgs e)
        {
            
            try
            {
                
                string sql = string.Format("select * from Pinfo where P_CODE like '%{0}%'and P_info like '%{1}%'", cbCode.Text, txtinfo.Text);
                SqlHelper.GetReader(sql);
                 List<Pinfo_class> info = new List<Pinfo_class>();
                 foreach (Pinfo_class item in SqlHelper.GetReader(sql))
                {
                    Pinfo_class pclass = new Pinfo_class() 
                    {
                        P_Code=item.P_Code,
                        P_Info=item.P_Info,
                        P_Answer=item.P_Answer
                    };
                    info.Add(pclass);
                }
                this.dataGridView1.DefaultCellStyle.WrapMode = DataGridViewTriState.True; //自动换行                
                this.dataGridView1.DataSource =  info;
            }
            catch (Exception ex)
            {
                MessageBox.Show("异常抛出\n" + ex, "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Close();
        }

    }
}
