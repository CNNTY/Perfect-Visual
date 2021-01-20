using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace Perfect_Visual_神龙信息经理辅助
{
    public partial class FrmPadd : Form
    {
        public FrmPadd()
        {
            InitializeComponent();
            
            err.Text = "错误代码不能一样，否则会报错\n ";
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtcode.TextLength == 0)
            {
                MessageBox.Show("请输入错误代码！！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtcode.Focus();
                return;
            }
            else if (txtinfo.TextLength == 0)
            {
                MessageBox.Show("请输入错误提示信息！！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtinfo.Focus();
                return;
            }
            else if (txtanswer.TextLength == 0)
            {
                MessageBox.Show("请输入解决方法！！", "错误提示", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.txtanswer.Focus();
                return;
            }
            
            List<Pinfo_class> info = new List<Pinfo_class>();
         
            Pinfo_class objinfo = new Pinfo_class()
            {
                P_Code = txtcode.Text.Trim(),
                P_Info = txtinfo.Text.Trim(),
                P_Answer = txtanswer.Text.Trim()
            };
            info.Add(objinfo);
            string sql="";
           try
            {
                foreach (Pinfo_class item in info)
            {
                sql = string.Format("insert into Pinfo VALUES(newID(),'{0}','{1}','{2}')", item.P_Code, item.P_Info, item.P_Answer);
                int result = SqlHelper.Update(sql);
            }          
            
                this.dataGridView1.DataSource = info;
            }
            catch (Exception ex)
            {
                MessageBox.Show("未能完成该操作" + ex, "错误信息");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
