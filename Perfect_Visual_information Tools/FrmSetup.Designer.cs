namespace Perfect_Visual_神龙信息经理辅助
{
    partial class FrmSetup
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSetup));
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.IEset = new System.Windows.Forms.Button();
            this.cwebsetup = new System.Windows.Forms.Button();
            this.cwebkey = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.axAcroPDF1 = new AxAcroPDFLib.AxAcroPDF();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Yellow;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("微软雅黑", 14F, System.Drawing.FontStyle.Bold);
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(0, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(677, 32);
            this.label1.TabIndex = 1;
            this.label1.Text = "商务工作网证书安装与设置（包含IE9以上版本的设置方法）";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.axAcroPDF1);
            this.panel1.Location = new System.Drawing.Point(1, 75);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 499);
            this.panel1.TabIndex = 2;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Location = new System.Drawing.Point(0, 577);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(683, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // IEset
            // 
            this.IEset.Location = new System.Drawing.Point(181, 35);
            this.IEset.Name = "IEset";
            this.IEset.Size = new System.Drawing.Size(75, 34);
            this.IEset.TabIndex = 4;
            this.IEset.Text = "IE属性";
            this.toolTip1.SetToolTip(this.IEset, "单击按钮打开IE浏览器属性设置");
            this.IEset.UseVisualStyleBackColor = true;
            this.IEset.Click += new System.EventHandler(this.IEset_Click);
            // 
            // cwebsetup
            // 
            this.cwebsetup.Location = new System.Drawing.Point(306, 35);
            this.cwebsetup.Name = "cwebsetup";
            this.cwebsetup.Size = new System.Drawing.Size(75, 34);
            this.cwebsetup.TabIndex = 4;
            this.cwebsetup.Text = "证书安装";
            this.toolTip1.SetToolTip(this.cwebsetup, "单击此按钮开始安装商务网证书");
            this.cwebsetup.UseVisualStyleBackColor = true;
            this.cwebsetup.Click += new System.EventHandler(this.cwebsetup_Click);
            // 
            // cwebkey
            // 
            this.cwebkey.Location = new System.Drawing.Point(431, 35);
            this.cwebkey.Name = "cwebkey";
            this.cwebkey.Size = new System.Drawing.Size(75, 34);
            this.cwebkey.TabIndex = 4;
            this.cwebkey.Text = "证书密码";
            this.toolTip1.SetToolTip(this.cwebkey, "证书密码，单击即可复制证书密码");
            this.cwebkey.UseVisualStyleBackColor = true;
            this.cwebkey.Click += new System.EventHandler(this.cwebkey_Click);
            // 
            // axAcroPDF1
            // 
            this.axAcroPDF1.Enabled = true;
            this.axAcroPDF1.Location = new System.Drawing.Point(52, 23);
            this.axAcroPDF1.Name = "axAcroPDF1";
            this.axAcroPDF1.OcxState = ((System.Windows.Forms.AxHost.State)(resources.GetObject("axAcroPDF1.OcxState")));
            this.axAcroPDF1.Size = new System.Drawing.Size(561, 343);
            this.axAcroPDF1.TabIndex = 0;
            // 
            // FrmSetup
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 599);
            this.Controls.Add(this.cwebkey);
            this.Controls.Add(this.cwebsetup);
            this.Controls.Add(this.IEset);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FrmSetup";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "商务工作网安装与设置";
            this.Load += new System.EventHandler(this.FrmSetup_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.axAcroPDF1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.Button IEset;
        private System.Windows.Forms.Button cwebsetup;
        private System.Windows.Forms.Button cwebkey;
        private System.Windows.Forms.ToolTip toolTip1;
        private AxAcroPDFLib.AxAcroPDF axAcroPDF1;
    }
}