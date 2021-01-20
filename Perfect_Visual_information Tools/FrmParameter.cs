using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Perfect_Visual_神龙信息经理辅助
{
    public partial class FrmParameter : Form
    {
        public FrmParameter()
        {
            InitializeComponent();
            label5.ForeColor = Color.Red;
            label5.Text = "在生成注册表文件时,路径必须以双斜杠\\\\结束,\n\n\t例:D:\\\\深圳联友科技有限公司\\\\神龙经销商信息管理系统\\\\";
        }

        private void btncmddpad_Click(object sender, EventArgs e)
        {
            if(dpadtxt.Text.Length==0)
            {
                MessageBox.Show("请输入DMS的安装路径！！！","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Error);
            }
            else 
            { 
            Encoding encode=Encoding.GetEncoding("GB2312");
            string info;
            info = (Application.StartupPath);
            FileStream fs = new FileStream(info+"\\Themes\\dpad.cmd", FileMode.OpenOrCreate);
            StreamWriter sw = new StreamWriter(fs, encode);
           // sw.WriteLine("@echo off\nTITLE 标致雪铁龙DMS运行辅助\ncolor 0a\nregedit /s 标致DMS系统注册表项.reg\nstart \"\"\"{0}\"",dpadtxt.Text);
            sw.WriteLine("@echo off", encode);
            sw.WriteLine("TITLE 标致雪铁龙DMS运行辅助", encode);
            sw.WriteLine("regedit /s 标致DMS系统注册表项.reg", encode);
            sw.WriteLine("start \"\" \"{0}\"", dpadtxt.Text + "Lanyou.DMS.exe", encode);
            sw.Close();
            MessageBox.Show("执行文件生成成功","提示信息",MessageBoxButtons.OK,MessageBoxIcon.Information);
            }
        }

        private void btncmddcad_Click(object sender, EventArgs e)
        {
            if (dcadtxt.Text.Length == 0)
            {
                MessageBox.Show("请输入DMS的安装路径！！！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Encoding encode = Encoding.GetEncoding("GB2312");
                string info;
                info = (Application.StartupPath);
                FileStream fs = new FileStream(info + "\\Themes\\dcad.cmd", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs, encode);
                sw.WriteLine("@echo off", encode);
                sw.WriteLine("TITLE 标致雪铁龙DMS运行辅助", encode);
                sw.WriteLine("regedit /s 东风雪铁龙.reg", encode);
                sw.WriteLine("start \"\" \"{0}\"" + "Lanyou.DMS.exe", dcadtxt.Text, encode);
                sw.Close();
                MessageBox.Show("执行文件生成成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnregdpad_Click(object sender, EventArgs e)
        {
            if (dpadtxt.Text.Length == 0)
            {
                MessageBox.Show("请输入DMS的安装路径！！！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Encoding encode = Encoding.GetEncoding("GB2312");
                string info;
                info = (Application.StartupPath);
                FileStream fs = new FileStream(info + "\\Themes\\标致DMS系统注册表项.reg", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                // sw.WriteLine("@echo off\nTITLE 标致雪铁龙DMS运行辅助\ncolor 0a\nregedit /s 标致DMS系统注册表项.reg\nstart \"\"\"{0}\"",dpadtxt.Text);
                sw.WriteLine("Windows Registry Editor Version 5.00", encode);
                sw.WriteLine("[HKEY_LOCAL_MACHINE\\SOFTWARE\\深圳联友科技有限公司]", encode);
                sw.WriteLine("@=\"\"", encode);
                sw.WriteLine("\"ver\"=\"1.0.0.1073\"", encode);
                sw.WriteLine("\"pid\"=\"SD_WSE\"", encode);
                sw.WriteLine("[HKEY_LOCAL_MACHINE\\SOFTWARE\\深圳联友科技有限公司\\神龙经销商信息管理系统]", encode);
                sw.WriteLine("[HKEY_LOCAL_MACHINE\\SOFTWARE\\深圳联友科技有限公司\\神龙经销商信息管理系统\\1.00.0000]", encode);
                sw.WriteLine("\"Install Path\"=\"{0}\"", dpadtxt.Text, encode);
                sw.WriteLine("\"Main Program\"=\"yes\"", encode);
                sw.WriteLine("\"Program Type\"=\"Client\"", encode);
                sw.Close();
                MessageBox.Show("注册表信息生成成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        private void btnregdcad_Click(object sender, EventArgs e)
        {
            if (dcadtxt.Text.Length == 0)
            {
                MessageBox.Show("请输入DMS的安装路径！！！", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                Encoding encode = Encoding.GetEncoding("GB2312");
                string info;
                info = (Application.StartupPath);
                FileStream fs = new FileStream(info + "\\Themes\\雪铁龙DMS系统注册表项.reg", FileMode.OpenOrCreate);
                StreamWriter sw = new StreamWriter(fs);
                // sw.WriteLine("@echo off\nTITLE 标致雪铁龙DMS运行辅助\ncolor 0a\nregedit /s 标致DMS系统注册表项.reg\nstart \"\"\"{0}\"",dpadtxt.Text);
                sw.WriteLine("Windows Registry Editor Version 5.00",encode);
                sw.WriteLine("[HKEY_LOCAL_MACHINE\\SOFTWARE\\深圳联友科技有限公司]",encode);
                sw.WriteLine("@=\"\"", encode);
                sw.WriteLine("\"ver\"=\"1.0.0.1073\"", encode);
                sw.WriteLine("\"pid\"=\"SD_WSE\"", encode);
                sw.WriteLine("[HKEY_LOCAL_MACHINE\\SOFTWARE\\深圳联友科技有限公司\\神龙经销商信息管理系统]", encode);
                sw.WriteLine("[HKEY_LOCAL_MACHINE\\SOFTWARE\\深圳联友科技有限公司\\神龙经销商信息管理系统\\1.00.0000]", encode);
                sw.WriteLine("\"Install Path\"=\"{0}\"", dpadtxt.Text, encode);
                sw.WriteLine("\"Main Program\"=\"yes\"", encode);
                sw.WriteLine("\"Program Type\"=\"Client\"", encode);
                sw.Close();
                MessageBox.Show("注册表信息生成成功", "提示信息", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

    }
}
