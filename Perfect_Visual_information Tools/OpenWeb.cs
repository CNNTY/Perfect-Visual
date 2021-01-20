using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Windows.Forms;
using System.Diagnostics;

namespace Perfect_Visual_神龙信息经理辅助
{
    public class OpenWeb
    {
        [DllImport("shell32.dll")]
        private static extern int ShellExecute(IntPtr hwnd, StringBuilder lpszOp, StringBuilder lpszFile, StringBuilder lpszParams, StringBuilder lpszDir, int FsShowCmd);
        public static void Common(string url) //电脑默认浏览器
        {
            ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder(url), new StringBuilder(""), new StringBuilder(""), 1);
        }
        public static void CommonIE(string url) //指定IE浏览器
        {
            ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder("IEXPLORE.exe"), new StringBuilder(url), new StringBuilder(""), 1);
        }
        public static void firefox(string url)//指定浏览器为火狐
        {
            bool flag = false;
            RegistryKey registryKey3 = Registry.LocalMachine.OpenSubKey("SOFTWARE\\Microsoft\\Windows\\CurrentVersion\\App Paths\\firefox.exe");


            if (registryKey3 == null)
            {
                flag = false;
            }
            else
            {
                string[] subKeyNames = registryKey3.GetValueNames();
                for (int i = 0; i < subKeyNames.Length; i++)
                {
                    string name = subKeyNames[i];
                    Microsoft.Win32.RegistryKey registryKey2 = registryKey3.OpenSubKey(name);
                    object value = registryKey2.GetValue("Path");
                    if (value != null)
                    {
                        if (value.ToString().Contains("Mozilla Firefox"))
                        {
                            flag = true;
                            ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder("firefox.exe"), new StringBuilder(url), new StringBuilder(""), 1);

                        }
                    }
                }
            }

            if (!flag)
            {
                LinkMessageBox lmb = new LinkMessageBox();
                lmb.ShowDialog();
             //MessageBox.Show("当前系统未安装火狐浏览器，清先安装火狐浏览器,下载地址：http://www.firefox.com.cn/", "提示信息");

            }
            else
            {
                ShellExecute(IntPtr.Zero, new StringBuilder("Open"), new StringBuilder("firefox.exe"), new StringBuilder(url), new StringBuilder(""), 1);
            }
        }


    }
}
