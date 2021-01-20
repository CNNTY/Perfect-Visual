namespace Perfect_Visual_神龙信息经理辅助
{
    partial class FrmServer
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
            this.BtnServer = new System.Windows.Forms.Button();
            this.Btn反交车 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Btn保修 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // BtnServer
            // 
            this.BtnServer.Location = new System.Drawing.Point(26, 12);
            this.BtnServer.Name = "BtnServer";
            this.BtnServer.Size = new System.Drawing.Size(120, 33);
            this.BtnServer.TabIndex = 0;
            this.BtnServer.Text = "服务器重装申请表";
            this.BtnServer.UseVisualStyleBackColor = true;
            this.BtnServer.Click += new System.EventHandler(this.BtnServer_Click);
            // 
            // Btn反交车
            // 
            this.Btn反交车.Location = new System.Drawing.Point(152, 12);
            this.Btn反交车.Name = "Btn反交车";
            this.Btn反交车.Size = new System.Drawing.Size(120, 33);
            this.Btn反交车.TabIndex = 0;
            this.Btn反交车.Text = "反交车申请表";
            this.Btn反交车.UseVisualStyleBackColor = true;
            this.Btn反交车.Click += new System.EventHandler(this.Btn反交车_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.Control;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.label1.Font = new System.Drawing.Font("隶书", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(26, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(58, 18);
            this.label1.TabIndex = 1;
            this.label1.Text = "label1";
            // 
            // Btn保修
            // 
            this.Btn保修.Location = new System.Drawing.Point(26, 51);
            this.Btn保修.Name = "Btn保修";
            this.Btn保修.Size = new System.Drawing.Size(120, 33);
            this.Btn保修.TabIndex = 0;
            this.Btn保修.Text = "保修注意事项";
            this.Btn保修.UseVisualStyleBackColor = true;
            this.Btn保修.Click += new System.EventHandler(this.Btn保修_Click);
            // 
            // FrmServer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 175);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Btn保修);
            this.Controls.Add(this.Btn反交车);
            this.Controls.Add(this.BtnServer);
            this.Name = "FrmServer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "申请表";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button BtnServer;
        private System.Windows.Forms.Button Btn反交车;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button Btn保修;
    }
}