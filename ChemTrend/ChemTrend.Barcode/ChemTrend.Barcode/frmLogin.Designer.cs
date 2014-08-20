namespace ChemTrend.Barcode
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.te_username = new DevExpress.XtraEditors.TextEdit();
            this.te_password = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.pictureEdit1 = new DevExpress.XtraEditors.PictureEdit();
            this.sbtn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_login = new DevExpress.XtraEditors.SimpleButton();
            this.dxvp_username = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxvp_pwd = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_pwd)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(112, 131);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "用户名：";
            // 
            // te_username
            // 
            this.te_username.Location = new System.Drawing.Point(181, 128);
            this.te_username.Name = "te_username";
            this.te_username.Size = new System.Drawing.Size(190, 20);
            this.te_username.TabIndex = 1;
            // 
            // te_password
            // 
            this.te_password.Location = new System.Drawing.Point(181, 166);
            this.te_password.Name = "te_password";
            this.te_password.Properties.UseSystemPasswordChar = true;
            this.te_password.Size = new System.Drawing.Size(190, 20);
            this.te_password.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(112, 168);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "密码：";
            // 
            // pictureEdit1
            // 
            this.pictureEdit1.Dock = System.Windows.Forms.DockStyle.Top;
            this.pictureEdit1.EditValue = ((object)(resources.GetObject("pictureEdit1.EditValue")));
            this.pictureEdit1.Location = new System.Drawing.Point(0, 0);
            this.pictureEdit1.Name = "pictureEdit1";
            this.pictureEdit1.Properties.Padding = new System.Windows.Forms.Padding(0, 5, 20, 0);
            this.pictureEdit1.Properties.PictureAlignment = System.Drawing.ContentAlignment.TopRight;
            this.pictureEdit1.Size = new System.Drawing.Size(485, 96);
            this.pictureEdit1.TabIndex = 9;
            this.pictureEdit1.EditValueChanged += new System.EventHandler(this.pictureEdit1_EditValueChanged);
            // 
            // sbtn_cancel
            // 
            this.sbtn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_cancel.Image")));
            this.sbtn_cancel.Location = new System.Drawing.Point(389, 225);
            this.sbtn_cancel.Name = "sbtn_cancel";
            this.sbtn_cancel.Size = new System.Drawing.Size(60, 23);
            this.sbtn_cancel.TabIndex = 4;
            this.sbtn_cancel.Text = "取消";
            this.sbtn_cancel.Click += new System.EventHandler(this.sbtn_cancel_Click);
            // 
            // sbtn_login
            // 
            this.sbtn_login.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_login.Image")));
            this.sbtn_login.Location = new System.Drawing.Point(311, 225);
            this.sbtn_login.Name = "sbtn_login";
            this.sbtn_login.Size = new System.Drawing.Size(60, 23);
            this.sbtn_login.TabIndex = 3;
            this.sbtn_login.Text = "登录";
            this.sbtn_login.Click += new System.EventHandler(this.sbtn_login_Click);
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(485, 275);
            this.Controls.Add(this.pictureEdit1);
            this.Controls.Add(this.sbtn_cancel);
            this.Controls.Add(this.sbtn_login);
            this.Controls.Add(this.te_password);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.te_username);
            this.Controls.Add(this.labelControl1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmLogin";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "用户登录";
            this.Load += new System.EventHandler(this.frmLogin_Load);
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureEdit1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_pwd)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit te_username;
        private DevExpress.XtraEditors.TextEdit te_password;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbtn_login;
        private DevExpress.XtraEditors.SimpleButton sbtn_cancel;
        private DevExpress.XtraEditors.PictureEdit pictureEdit1;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_username;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_pwd;
    }
}