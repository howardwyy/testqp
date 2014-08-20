namespace ChemTrend.Barcode.Forms.Systems
{
    partial class frmChangePwd
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChangePwd));
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.te_username = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.te_password = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_cancel = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_update = new DevExpress.XtraEditors.SimpleButton();
            this.te_passwordnew = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.te_passwordnew_sure = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.dxvp_username = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxvp_password = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxvp_password_new = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxvp_password_sure = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_password.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_passwordnew.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_passwordnew_sure.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_username)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_password)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_password_new)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_password_sure)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(38, 39);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "用户名：";
            // 
            // te_username
            // 
            this.te_username.Location = new System.Drawing.Point(107, 36);
            this.te_username.Name = "te_username";
            this.te_username.Size = new System.Drawing.Size(190, 20);
            this.te_username.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(38, 75);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 11;
            this.labelControl2.Text = "密码：";
            // 
            // te_password
            // 
            this.te_password.Location = new System.Drawing.Point(107, 73);
            this.te_password.Name = "te_password";
            this.te_password.Size = new System.Drawing.Size(190, 20);
            this.te_password.TabIndex = 2;
            // 
            // sbtn_cancel
            // 
            this.sbtn_cancel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_cancel.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_cancel.Image")));
            this.sbtn_cancel.Location = new System.Drawing.Point(600, 146);
            this.sbtn_cancel.Name = "sbtn_cancel";
            this.sbtn_cancel.Size = new System.Drawing.Size(60, 23);
            this.sbtn_cancel.TabIndex = 5;
            this.sbtn_cancel.Text = "取消";
            this.sbtn_cancel.Click += new System.EventHandler(this.sbtn_cancel_Click);
            // 
            // sbtn_update
            // 
            this.sbtn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_update.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_update.Image")));
            this.sbtn_update.Location = new System.Drawing.Point(504, 146);
            this.sbtn_update.Name = "sbtn_update";
            this.sbtn_update.Size = new System.Drawing.Size(60, 23);
            this.sbtn_update.TabIndex = 4;
            this.sbtn_update.Text = "确认";
            this.sbtn_update.Click += new System.EventHandler(this.sbtn_update_Click);
            // 
            // te_passwordnew
            // 
            this.te_passwordnew.Location = new System.Drawing.Point(107, 110);
            this.te_passwordnew.Name = "te_passwordnew";
            this.te_passwordnew.Size = new System.Drawing.Size(190, 20);
            this.te_passwordnew.TabIndex = 3;
            this.te_passwordnew.TextChanged += new System.EventHandler(this.te_passwordnew_TextChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(38, 111);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 16;
            this.labelControl3.Text = "新密码：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.te_passwordnew_sure);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.sbtn_cancel);
            this.groupBox1.Controls.Add(this.te_passwordnew);
            this.groupBox1.Controls.Add(this.sbtn_update);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.te_username);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.te_password);
            this.groupBox1.Location = new System.Drawing.Point(12, 22);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(691, 192);
            this.groupBox1.TabIndex = 18;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "密码修改";
            // 
            // te_passwordnew_sure
            // 
            this.te_passwordnew_sure.Location = new System.Drawing.Point(107, 149);
            this.te_passwordnew_sure.Name = "te_passwordnew_sure";
            this.te_passwordnew_sure.Size = new System.Drawing.Size(190, 20);
            this.te_passwordnew_sure.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(38, 150);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 18;
            this.labelControl4.Text = "确认密码：";
            // 
            // frmChangePwd
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(715, 336);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmChangePwd";
            this.Text = "密码修改";
            this.Load += new System.EventHandler(this.frmChangePwd_Load);
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_password.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_passwordnew.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_passwordnew_sure.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_username)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_password)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_password_new)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_password_sure)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit te_username;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.TextEdit te_password;
        private DevExpress.XtraEditors.SimpleButton sbtn_cancel;
        private DevExpress.XtraEditors.SimpleButton sbtn_update;
        private DevExpress.XtraEditors.TextEdit te_passwordnew;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit te_passwordnew_sure;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_username;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_password;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_password_new;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_password_sure;

    }
}