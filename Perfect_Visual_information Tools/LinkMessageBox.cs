using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Windows.Forms;
using System.Text;
using System.Windows.Forms;

namespace Perfect_Visual_神龙信息经理辅助
{
    public partial class LinkMessageBox : Form
    {
        public LinkMessageBox()
        {
            InitializeComponent();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            OpenWeb.Common("http://www.firefox.com.cn/");
            Close();
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
	
}
