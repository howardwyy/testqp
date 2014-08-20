namespace ChemTrend.Moblie.Forms.Else
{
    partial class frmElseMain
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmElseMain));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_logout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_help = new System.Windows.Forms.Button();
            this.btn_about = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(46, 42);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 86);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // btn_logout
            // 
            this.btn_logout.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_logout.ForeColor = System.Drawing.Color.White;
            this.btn_logout.Location = new System.Drawing.Point(33, 236);
            this.btn_logout.Name = "btn_logout";
            this.btn_logout.Size = new System.Drawing.Size(184, 27);
            this.btn_logout.TabIndex = 3;
            this.btn_logout.Text = "退出登录";
            this.btn_logout.Click += new System.EventHandler(this.btn_logout_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btn_help);
            this.panel1.Controls.Add(this.btn_about);
            this.panel1.Location = new System.Drawing.Point(33, 134);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(184, 95);
            // 
            // btn_help
            // 
            this.btn_help.Location = new System.Drawing.Point(0, 38);
            this.btn_help.Name = "btn_help";
            this.btn_help.Size = new System.Drawing.Size(184, 30);
            this.btn_help.TabIndex = 1;
            this.btn_help.Text = "帮助";
            this.btn_help.Click += new System.EventHandler(this.btn_help_Click);
            // 
            // btn_about
            // 
            this.btn_about.Location = new System.Drawing.Point(0, 3);
            this.btn_about.Name = "btn_about";
            this.btn_about.Size = new System.Drawing.Size(184, 30);
            this.btn_about.TabIndex = 0;
            this.btn_about.Text = "关于";
            this.btn_about.Click += new System.EventHandler(this.btn_about_Click);
            // 
            // frmElseMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_logout);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmElseMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmElseMain_Load);
            this.Controls.SetChildIndex(this.btn_logout, 0);
            this.Controls.SetChildIndex(this.pictureBox1, 0);
            this.Controls.SetChildIndex(this.panel1, 0);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_logout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_help;
        private System.Windows.Forms.Button btn_about;
    }
}
