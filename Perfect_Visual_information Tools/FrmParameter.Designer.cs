namespace Perfect_Visual_神龙信息经理辅助
{
    partial class FrmParameter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmParameter));
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btncmddcad = new System.Windows.Forms.Button();
            this.dcadtxt = new System.Windows.Forms.TextBox();
            this.btnregdcad = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.dpadtxt = new System.Windows.Forms.TextBox();
            this.btncmddpad = new System.Windows.Forms.Button();
            this.btnregdpad = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 12);
            this.label1.TabIndex = 0;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.PaleGreen;
            this.textBox1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.InfoText;
            this.textBox1.Location = new System.Drawing.Point(18, 4);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(18, 28);
            this.textBox1.TabIndex = 1;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            this.textBox1.Visible = false;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label2.Font = new System.Drawing.Font("华文中宋", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(57, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(262, 23);
            this.label2.TabIndex = 2;
            this.label2.Text = "双品牌使用DMS设置方法";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btncmddcad
            // 
            this.btncmddcad.Location = new System.Drawing.Point(61, 56);
            this.btncmddcad.Name = "btncmddcad";
            this.btncmddcad.Size = new System.Drawing.Size(91, 30);
            this.btncmddcad.TabIndex = 3;
            this.btncmddcad.Text = "制作启动程序";
            this.toolTip1.SetToolTip(this.btncmddcad, "生成雪铁龙DMS的执行文件\r\n范例：D:\\深圳联友科技有限公司\\神龙经销商信息管理系统\\");
            this.btncmddcad.UseVisualStyleBackColor = true;
            this.btncmddcad.Click += new System.EventHandler(this.btncmddcad_Click);
            // 
            // dcadtxt
            // 
            this.dcadtxt.Location = new System.Drawing.Point(61, 29);
            this.dcadtxt.Name = "dcadtxt";
            this.dcadtxt.Size = new System.Drawing.Size(256, 21);
            this.dcadtxt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dcadtxt, "填写DMS所在的路径\r\n例如：E:\\深圳联友科技有限公司\\神龙经销商信息管理系统\\\r\n");
            // 
            // btnregdcad
            // 
            this.btnregdcad.Location = new System.Drawing.Point(226, 56);
            this.btnregdcad.Name = "btnregdcad";
            this.btnregdcad.Size = new System.Drawing.Size(91, 30);
            this.btnregdcad.TabIndex = 3;
            this.btnregdcad.Text = "制作注册表";
            this.toolTip1.SetToolTip(this.btnregdcad, "生成雪铁龙DMS的注册表\r\n范例：D:\\\\深圳联友科技有限公司\\\\神龙经销商信息管理系统\\\\");
            this.btnregdcad.UseVisualStyleBackColor = true;
            this.btnregdcad.Click += new System.EventHandler(this.btnregdcad_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dcadtxt);
            this.groupBox1.Controls.Add(this.btncmddcad);
            this.groupBox1.Controls.Add(this.btnregdcad);
            this.groupBox1.Location = new System.Drawing.Point(14, 150);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(333, 92);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "雪铁龙DMS配置";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(8, 32);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(47, 12);
            this.label3.TabIndex = 5;
            this.label3.Text = "DMS路径";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.dpadtxt);
            this.groupBox2.Controls.Add(this.btncmddpad);
            this.groupBox2.Controls.Add(this.btnregdpad);
            this.groupBox2.Location = new System.Drawing.Point(14, 46);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(333, 98);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "标致DMS配置";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(8, 32);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(47, 12);
            this.label4.TabIndex = 5;
            this.label4.Text = "DMS路径";
            // 
            // dpadtxt
            // 
            this.dpadtxt.Location = new System.Drawing.Point(61, 29);
            this.dpadtxt.Name = "dpadtxt";
            this.dpadtxt.Size = new System.Drawing.Size(256, 21);
            this.dpadtxt.TabIndex = 4;
            this.toolTip1.SetToolTip(this.dpadtxt, "填写DMS所在的路径\r\n例如：D:\\深圳联友科技有限公司\\神龙经销商信息管理系统\\");
            // 
            // btncmddpad
            // 
            this.btncmddpad.Location = new System.Drawing.Point(61, 56);
            this.btncmddpad.Name = "btncmddpad";
            this.btncmddpad.Size = new System.Drawing.Size(91, 30);
            this.btncmddpad.TabIndex = 3;
            this.btncmddpad.Text = "制作启动程序";
            this.toolTip1.SetToolTip(this.btncmddpad, "生成标致DMS的执行文件\r\n范例：D:\\深圳联友科技有限公司\\神龙经销商信息管理系统\\");
            this.btncmddpad.UseVisualStyleBackColor = true;
            this.btncmddpad.Click += new System.EventHandler(this.btncmddpad_Click);
            // 
            // btnregdpad
            // 
            this.btnregdpad.Location = new System.Drawing.Point(226, 56);
            this.btnregdpad.Name = "btnregdpad";
            this.btnregdpad.Size = new System.Drawing.Size(91, 30);
            this.btnregdpad.TabIndex = 3;
            this.btnregdpad.Text = "制作注册表";
            this.toolTip1.SetToolTip(this.btnregdpad, "生成标致DMS的注册表文件\r\n范例：D:\\\\深圳联友科技有限公司\\\\神龙经销商信息管理系统\\\\");
            this.btnregdpad.UseVisualStyleBackColor = true;
            this.btnregdpad.Click += new System.EventHandler(this.btnregdpad_Click);
            // 
            // label5
            // 
            this.label5.AutoEllipsis = true;
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 245);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(41, 12);
            this.label5.TabIndex = 6;
            this.label5.Text = "label5";
            // 
            // frmSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(359, 293);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "双品牌使用DMS参数配置";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btncmddcad;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox dcadtxt;
        private System.Windows.Forms.Button btnregdcad;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox dpadtxt;
        private System.Windows.Forms.Button btncmddpad;
        private System.Windows.Forms.Button btnregdpad;
        private System.Windows.Forms.Label label5;
    }
}