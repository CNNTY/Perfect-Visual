using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Diagnostics;
using System.IO;
using SkinSharp;
using System.Runtime.InteropServices;
using Microsoft.Win32;

namespace Perfect_Visual_神龙信息经理辅助
{
    public partial class FrMain : Form
    {
        public SkinH_Net skin;
        private FrmPinfo Frmerrinfo = null; //错误查询
        private FrmPadd frmpadd = null;
        private FrmParameter fparm = null;
        private OpenWeb ow = new OpenWeb(); //实例化打开网页类
        public FrMain()
        {
            InitializeComponent();
            skin = new SkinH_Net();
            skin.AttachEx("skinh.she", "");
        }

        private void FrMain_Load(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 故障处理方案
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void Errinfo_Click(object sender, EventArgs e)
        {
            if (Frmerrinfo != null && Frmerrinfo.Created)
            {
                Frmerrinfo.Focus();
                return;
            }
            Frmerrinfo = new FrmPinfo();
            //f2.MdiParent = this; 
            Frmerrinfo.Show();
        }
        /// <summary>
        /// 添加信息
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>

        /// <summary>
        /// 证书相关
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void cwebkey_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("cwebdpca");   //复制文本
            MessageBox.Show("复制成功，请在证书输入密码处粘帖", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        public void KeySetup_Click(object sender, EventArgs e)
        {
            MessageBox.Show("\t现在开始安装证书\n\t如果不会安装请先看安装教程", "温馨提示", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.WorkingDirectory = Application.StartupPath;
            info.FileName = "Themes\\cwebkey.p12";
            info.Arguments = "";

            try
            {
                System.Diagnostics.Process.Start(info);
            }
            catch (System.ComponentModel.Win32Exception we)
            {
                MessageBox.Show(this, we.Message + "安装未完成，请检查证书");
                return;
            }
        }

        public void IESetting_Click(object sender, EventArgs e)
        {
            Process p = new Process();
            p.StartInfo = new ProcessStartInfo("rundll32.exe", "shell32.dll,Control_RunDLL inetcpl.cpl");
            p.Start();
        }

        /// <summary>
        /// 雪铁龙网址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dcadcweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.CommonIE("https://cweb.dpca.com.cn/dcad/");
        }

        private void dcad_DMSNET_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.CommonIE("https://cweb.dpca.com.cn/dmsnetdcad/login.do");
        }

        private void dcadlive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://www1.gnetis.com/event/DPCA/Live/DPCA11/");
        }

        private void salesjob_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://211.157.102.199/Aspx/login.aspx");
        }

        private void dcad_cs_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            OpenWeb.firefox("https://networkservice.citroen.com/");

        }



        private void dcadReply_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://dcad.diaoyan.pamri.com/");
        }

        private void dcadtest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://223.4.3.173/vip/dfxtl/");
        }

        private void dcadIQS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://isurvey.pamri.com/System/Login.php");
        }

        private void dcadGW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://www.dongfeng-citroen.com.cn/");
        }

        private void DCAD_NetDisk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://dcad.1001m.net/");
        }
        /// <summary>
        /// 标致网址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void dpcacweb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.CommonIE("https://cweb.dpca.com.cn/dpad/");
        }

        private void dpad_DMSNET_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.CommonIE("https://cweb.dpca.com.cn/dmsnetdpad/login.do");
        }

        private void dpadlive_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://www1.gnetis.com/event/DPCA/Live/DPCA01/");
        }

        private void dpadSB_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenWeb.firefox("https://servicebox.peugeot.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统未安装火狐（Firefox）浏览器" + ex);
            }
        }

        private void dpad_Opp_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://yansi.gpssos.cn/root/gpssos/userloginshdz.html");//试乘试驾管理
        }

        private void dpadReply_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://dpad.diaoyan.pamri.com/");
        }

        private void dpadtest_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://223.4.3.173/vip/dfbz/");
        }

        private void dpadIQS_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://isurvey.pamri.com/System/Login.php");
        }

        private void dpadGW_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://www.peugeot.com.cn/");
        }

        private void DPAD_NetDisk_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("https://www.vips100.com/dongfengpeugeotdvnp");
        }
        /// <summary>
        /// 公用网址
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void parts_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.CommonIE("https://cweb.dpca.com.cn/cata/login-input.jspx");
        }

        private void TEST_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://dpcs.21tb.com/");
        }

        private void EnterpriseMail_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://mail.icoremail.net/");
        }

        private void financial_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenWeb.firefox("https://whs.dpcafc.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统未安装火狐（Firefox）浏览器" + ex);
            }
        }

        private void financial_IMG_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://image.dpcafc.com:9080/Imaging/");
        }

        private void UsedCar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.CommonIE("https://cweb.dpca.com.cn/vo/login.jsp");
        }

        private void Importe_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.CommonIE("https://cweb.dpca.com.cn/imp/login.jsp");
        }

        private void Map_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://dpca.navinfo.com/");
        }

        private void WX_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://mp.weixin.qq.com/"); //微信平台
        }


        private void Xcar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://www.autohome.com.cn/"); //汽车之家
        }
        private void Email263_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://www.263.net/"); //263企业邮箱
        }

        private void Car_insurance_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://vfa.dpcavo.com/vfa/baseframe/login/LoginInput.action"); //保险业务
        }

        private void cwebbak_Click(object sender, EventArgs e)
        {
            OpenWeb.CommonIE("https://58.49.108.220/"); //电信备用
        }

        private void CWEBBACK1_Click(object sender, EventArgs e)
        {
            OpenWeb.Common("https://220.249.107.164/"); //网通备用
        }
        /// <summary>
        /// 安装教材
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SetupMethods_Click(object sender, EventArgs e)
        {
            FrmSetup fset = new FrmSetup();
            fset.ShowDialog();
        }

        public void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            this.Visible = true;
            this.WindowState = FormWindowState.Normal;
            this.notifyIcon.Visible = true;
            this.ShowInTaskbar = true;
        }

        private void BtnEadd_Click(object sender, EventArgs e)
        {
            if (frmpadd != null && frmpadd.Created)
            {
                frmpadd.Focus();
                return;
            }
            frmpadd = new FrmPadd();
            //f2.MdiParent = this; 
            frmpadd.Show();
        }


        //运行标致系统
        private void Start1_Click(object sender, EventArgs e)
        {
            try
            {
                Process start1 = new Process();//设置运行的命令行文件问ping.exe文件，这个文件系统会自己找到
                                               //如果是其它exe文件，则有可能需要指定详细路径，如运行winRar.exe
                start1.StartInfo.WorkingDirectory = Application.StartupPath;
                start1.StartInfo.FileName = "Themes\\dpad.cmd";
                start1.StartInfo.CreateNoWindow = true;//不显示dos命令行窗口
                start1.Start();
                start1.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到该文件，请检查配置" + ex);
            }
        }
        //运行雪铁龙系统
        private void Start2_Click(object sender, EventArgs e)
        {
            try
            {
                Process start1 = new Process();//设置运行的命令行文件问ping.exe文件，这个文件系统会自己找到
                                               //如果是其它exe文件，则有可能需要指定详细路径，如运行winRar.exe
                start1.StartInfo.WorkingDirectory = Application.StartupPath;
                start1.StartInfo.FileName = "Themes\\dcad.cmd";
                start1.StartInfo.CreateNoWindow = true;//不显示dos命令行窗口
                start1.Start();
                start1.WaitForExit();
            }
            catch (Exception ex)
            {
                MessageBox.Show("未找到该文件，请检查配置" + ex);
            }
        }

        private void btncopy_Click(object sender, EventArgs e)
        {
            MessageBox.Show("恭喜您成功复制孙伟老师邮箱，赶紧去骚扰他吧！哈哈哈！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Windows.Forms.Clipboard.SetText("sunwei1@dpca.com.cn");
        }

        private void About_Click(object sender, EventArgs e)
        {
            AboutBox ab = new AboutBox();
            ab.ShowDialog();
        }
        //右键退出程序
        private void TSM_Exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void 关于程序_Click(object sender, EventArgs e)
        {
            About_Click(null, null);
        }

        private void Setting_Click(object sender, EventArgs e)
        {
            if (fparm != null && fparm.Created)
            {
                fparm.Focus();
                return;
            }
            fparm = new FrmParameter();
            //f2.MdiParent = this; 
            fparm.ShowDialog();
        }

        private void btnOpne_Click(object sender, EventArgs e)
        {
            string info;
            info = (Application.StartupPath);
            Process.Start("explorer.exe", info + "\\Themes");
        }

        private void btnWIN8_Click(object sender, EventArgs e)
        {
            MessageBox.Show("WIN8系统在安装证书的时候与Windows7和XP证书安装是一样的，\n选择储存证书的时候选择 [当前用户(C)] 不要选择 [本地计算机(L)] ", "Windows8 系统安装证书注意事项");
        }


        private void 关于ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About_Click(null, null);
        }

        private void Lbcopy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            MessageBox.Show("恭喜您成功复制孙伟老师邮箱，赶紧去骚扰他吧！哈哈哈！！！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
            System.Windows.Forms.Clipboard.SetText("sunwei1@dpca.com.cn");
        }

        private void SB_CS_pwd_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                OpenWeb.firefox("https://passweb.mpsa.com/");
            }
            catch (Exception ex)
            {
                MessageBox.Show("系统未安装火狐（Firefox）浏览器" + ex);
            }
        }

        private void btnetkey_Click(object sender, EventArgs e)
        {
            System.Diagnostics.ProcessStartInfo info = new System.Diagnostics.ProcessStartInfo();
            info.WorkingDirectory = Application.StartupPath;
            info.FileName = "Themes\\dmsnet.p12";
            info.Arguments = "";

            try
            {
                System.Diagnostics.Process.Start(info);
            }
            catch (System.ComponentModel.Win32Exception we)
            {
                MessageBox.Show(this, we.Message + "安装未完成，请检查证书");
                return;
            }
        }

        private void btnpwd_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.Clipboard.SetText("dmsnetdpca");   //复制文本
            MessageBox.Show("复制成功，请在证书输入密码处粘帖", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void TSM_Display_Click(object sender, EventArgs e)
        {
            notifyIcon_MouseDoubleClick(null, null);
        }

        private void 更新_Click(object sender, EventArgs e)
        {
            MessageBox.Show("已停止更新");
        }

        private void FrMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.notifyIcon.Visible = false;
        }

        private void btnTools_Click(object sender, EventArgs e)
        {

            System.Diagnostics.Process.Start("Themes\\DMS服务器重装申请表.xls");
            //引用Excel工作簿 

        }

    }
}
