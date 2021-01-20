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
    public partial class FrmSetup : Form
    {
        public FrmSetup()
        {
            InitializeComponent();
           
        }
        private void FrmSetup_Load(object sender, EventArgs e)
        {
            try
            {
                axAcroPDF1.Dock = DockStyle.Fill;
                axAcroPDF1.LoadFile("Themes\\CwebSetup.PDF");
            }
            catch (Exception ex)
            {
                MessageBox.Show("数据读取失败"+ex);
            }
           
        }             

        private void IEset_Click(object sender, EventArgs e)
        {
            FrMain Fman = new FrMain();
            Fman.IESetting_Click(null, null);
        }

        private void cwebsetup_Click(object sender, EventArgs e)
        {
            FrMain Fman = new FrMain();
            Fman.KeySetup_Click(null, null);
        }

        private void cwebkey_Click(object sender, EventArgs e)
        {
            FrMain Fman = new FrMain();
            Fman.cwebkey_Click(null, null);
        }
    }
}
