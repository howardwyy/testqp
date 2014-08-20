namespace ChemTrend.Moblie
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btn_Login = new System.Windows.Forms.Button();
            this.tbox_Name = new System.Windows.Forms.TextBox();
            this.tbox_Pwd = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(38, 21);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(160, 86);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(19, 149);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 20);
            this.label1.Text = "用户名：";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(31, 190);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 20);
            this.label2.Text = "密码：";
            // 
            // btn_Login
            // 
            this.btn_Login.BackColor = System.Drawing.Color.OrangeRed;
            this.btn_Login.ForeColor = System.Drawing.Color.White;
            this.btn_Login.Location = new System.Drawing.Point(130, 229);
            this.btn_Login.Name = "btn_Login";
            this.btn_Login.Size = new System.Drawing.Size(72, 25);
            this.btn_Login.TabIndex = 3;
            this.btn_Login.Text = "登 录";
            this.btn_Login.Click += new System.EventHandler(this.btn_Login_Click);
            // 
            // tbox_Name
            // 
            this.tbox_Name.Location = new System.Drawing.Point(89, 148);
            this.tbox_Name.Name = "tbox_Name";
            this.tbox_Name.Size = new System.Drawing.Size(100, 21);
            this.tbox_Name.TabIndex = 4;
            this.tbox_Name.Text = "IPHONE";
            // 
            // tbox_Pwd
            // 
            this.tbox_Pwd.Location = new System.Drawing.Point(89, 189);
            this.tbox_Pwd.Name = "tbox_Pwd";
            this.tbox_Pwd.Size = new System.Drawing.Size(100, 21);
            this.tbox_Pwd.TabIndex = 5;
            this.tbox_Pwd.Text = "1";
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.tbox_Pwd);
            this.Controls.Add(this.tbox_Name);
            this.Controls.Add(this.btn_Login);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmLogin";
            this.Text = "用户登录";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.frmLogin_KeyPress);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_Login;
        private System.Windows.Forms.TextBox tbox_Name;
        private System.Windows.Forms.TextBox tbox_Pwd;
    }
}