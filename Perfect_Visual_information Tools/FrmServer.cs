using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;


namespace Perfect_Visual_神龙信息经理辅助
{
    public partial class FrmServer : Form
    {
        public FrmServer()
        {
            InitializeComponent();
            释放DMS反交车申请表();
            释放DMS服务器重装申请表();
            释放保修注意事项();
            label1.Text = "申请表填写好以后\n另存为到其它地方\n不要直接点击保存\n否则有可能会找不到";
        }

        private void Btn反交车_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.WorkingDirectory = Application.StartupPath;
            info.FileName = "Resources\\DMS系统反交车申请表.xlsx";
            info.Arguments = "";
            try
            {
                System.Diagnostics.Process.Start(info);
                //引用Excel工作簿
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }

        }
        void 释放DMS反交车申请表()
        {
            byte[] byDll = global::Perfect_Visual_神龙信息经理辅助.Properties.Resources.DMS系统反交车申请表;//获取嵌入dll文件的字节数组
            string strPath = Application.StartupPath + "\\Resources\\DMS系统反交车申请表.xlsx";//设置释放路径
            //创建dll文件（覆盖模式）
            using (FileStream fs = new FileStream(strPath, FileMode.Create))
            {
                fs.Write(byDll, 0, byDll.Length);
            }
        }

        private void BtnServer_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.WorkingDirectory = Application.StartupPath;
            info.FileName = "Resources\\神龙网点DMS服务器重装流程及重装申请表.xls";
            info.Arguments = "";
            try
            {
                System.Diagnostics.Process.Start(info);
                //引用Excel工作簿
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        void 释放DMS服务器重装申请表()
        {
            byte[] byDll = global::Perfect_Visual_神龙信息经理辅助.Properties.Resources.神龙网点DMS服务器重装流程及重装申请表;//获取嵌入dll文件的字节数组
            string strPath = Application.StartupPath + "\\Resources\\神龙网点DMS服务器重装流程及重装申请表.xls";//设置释放路径
            //创建dll文件（覆盖模式）
            using (FileStream fs = new FileStream(strPath, FileMode.Create))
            {
                fs.Write(byDll, 0, byDll.Length);
            }
        }

        private void Btn保修_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.WorkingDirectory = Application.StartupPath;
            info.FileName = "Resources\\保修注意事项.pdf";
            info.Arguments = "";
            try
            {
                System.Diagnostics.Process.Start(info);
                //引用Excel工作簿
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex);
            }
        }
        void 释放保修注意事项()
        {
            byte[] byDll = global::Perfect_Visual_神龙信息经理辅助.Properties.Resources.保修注意事项;//获取嵌入dll文件的字节数组
            string strPath = Application.StartupPath + "\\Resources\\保修注意事项.pdf";//设置释放路径
            //创建dll文件（覆盖模式）
            using (FileStream fs = new FileStream(strPath, FileMode.Create))
            {
                fs.Write(byDll, 0, byDll.Length);
            }
        }
    }
}
