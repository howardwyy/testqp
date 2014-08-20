namespace ChemTrend.Barcode.Forms.Systems
{
    partial class frmDatabase
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDatabase));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.sbtn_scala_test = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.te_scala_pwd = new DevExpress.XtraEditors.TextEdit();
            this.te_scala_ip = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.te_scala_user = new DevExpress.XtraEditors.TextEdit();
            this.te_scala_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_update = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtn_test = new DevExpress.XtraEditors.SimpleButton();
            this.te_barcode_pwd = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.te_barcode_user = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.te_barcode_name = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.te_barcode_ip = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_scala_pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_scala_ip.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_scala_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_scala_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_barcode_pwd.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_barcode_user.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_barcode_name.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_barcode_ip.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupBox2);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.groupBox1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(585, 367);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.sbtn_scala_test);
            this.groupBox2.Controls.Add(this.labelControl8);
            this.groupBox2.Controls.Add(this.te_scala_pwd);
            this.groupBox2.Controls.Add(this.te_scala_ip);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Controls.Add(this.labelControl7);
            this.groupBox2.Controls.Add(this.te_scala_user);
            this.groupBox2.Controls.Add(this.te_scala_name);
            this.groupBox2.Controls.Add(this.labelControl6);
            this.groupBox2.Location = new System.Drawing.Point(13, 161);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(560, 141);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Scala数据库";
            // 
            // sbtn_scala_test
            // 
            this.sbtn_scala_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_scala_test.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_scala_test.Image")));
            this.sbtn_scala_test.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_scala_test.Location = new System.Drawing.Point(483, 105);
            this.sbtn_scala_test.Name = "sbtn_scala_test";
            this.sbtn_scala_test.Size = new System.Drawing.Size(60, 26);
            this.sbtn_scala_test.TabIndex = 10;
            this.sbtn_scala_test.Text = "测试";
            this.sbtn_scala_test.Click += new System.EventHandler(this.sbtn_scala_test_Click);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(18, 21);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(72, 14);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "数据库地址：";
            // 
            // te_scala_pwd
            // 
            this.te_scala_pwd.Location = new System.Drawing.Point(304, 85);
            this.te_scala_pwd.Name = "te_scala_pwd";
            this.te_scala_pwd.Size = new System.Drawing.Size(129, 20);
            this.te_scala_pwd.TabIndex = 9;
            // 
            // te_scala_ip
            // 
            this.te_scala_ip.Location = new System.Drawing.Point(96, 18);
            this.te_scala_ip.Name = "te_scala_ip";
            this.te_scala_ip.Size = new System.Drawing.Size(337, 20);
            this.te_scala_ip.TabIndex = 6;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(249, 88);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(36, 14);
            this.labelControl5.TabIndex = 16;
            this.labelControl5.Text = "密码：";
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(18, 56);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 12;
            this.labelControl7.Text = "数据库名：";
            // 
            // te_scala_user
            // 
            this.te_scala_user.Location = new System.Drawing.Point(87, 85);
            this.te_scala_user.Name = "te_scala_user";
            this.te_scala_user.Size = new System.Drawing.Size(129, 20);
            this.te_scala_user.TabIndex = 8;
            // 
            // te_scala_name
            // 
            this.te_scala_name.Location = new System.Drawing.Point(96, 53);
            this.te_scala_name.Name = "te_scala_name";
            this.te_scala_name.Size = new System.Drawing.Size(337, 20);
            this.te_scala_name.TabIndex = 7;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(18, 88);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(48, 14);
            this.labelControl6.TabIndex = 14;
            this.labelControl6.Text = "用户名：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.sbtn_close);
            this.panelControl1.Controls.Add(this.sbtn_update);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 320);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(585, 47);
            this.panelControl1.TabIndex = 1;
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_close.Location = new System.Drawing.Point(512, 9);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(60, 26);
            this.sbtn_close.TabIndex = 16;
            this.sbtn_close.Text = "关闭";
            this.sbtn_close.Click += new System.EventHandler(this.sbtn_close_Click);
            // 
            // sbtn_update
            // 
            this.sbtn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_update.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_update.Image")));
            this.sbtn_update.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_update.Location = new System.Drawing.Point(434, 9);
            this.sbtn_update.Name = "sbtn_update";
            this.sbtn_update.Size = new System.Drawing.Size(60, 26);
            this.sbtn_update.TabIndex = 15;
            this.sbtn_update.Text = "修改";
            this.sbtn_update.Click += new System.EventHandler(this.sbtn_update_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sbtn_test);
            this.groupBox1.Controls.Add(this.te_barcode_pwd);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.te_barcode_user);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.te_barcode_name);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.te_barcode_ip);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(13, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(560, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条码数据库";
            // 
            // sbtn_test
            // 
            this.sbtn_test.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_test.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_test.Image")));
            this.sbtn_test.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_test.Location = new System.Drawing.Point(483, 97);
            this.sbtn_test.Name = "sbtn_test";
            this.sbtn_test.Size = new System.Drawing.Size(60, 26);
            this.sbtn_test.TabIndex = 5;
            this.sbtn_test.Text = "测试";
            this.sbtn_test.Click += new System.EventHandler(this.sbtn_test_Click);
            // 
            // te_barcode_pwd
            // 
            this.te_barcode_pwd.Location = new System.Drawing.Point(304, 81);
            this.te_barcode_pwd.Name = "te_barcode_pwd";
            this.te_barcode_pwd.Size = new System.Drawing.Size(129, 20);
            this.te_barcode_pwd.TabIndex = 4;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(249, 84);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 6;
            this.labelControl4.Text = "密码：";
            // 
            // te_barcode_user
            // 
            this.te_barcode_user.Location = new System.Drawing.Point(96, 81);
            this.te_barcode_user.Name = "te_barcode_user";
            this.te_barcode_user.Size = new System.Drawing.Size(129, 20);
            this.te_barcode_user.TabIndex = 3;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 84);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "用户名：";
            // 
            // te_barcode_name
            // 
            this.te_barcode_name.Location = new System.Drawing.Point(96, 52);
            this.te_barcode_name.Name = "te_barcode_name";
            this.te_barcode_name.Size = new System.Drawing.Size(337, 20);
            this.te_barcode_name.TabIndex = 2;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(18, 55);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "数据库名：";
            // 
            // te_barcode_ip
            // 
            this.te_barcode_ip.Location = new System.Drawing.Point(96, 19);
            this.te_barcode_ip.Name = "te_barcode_ip";
            this.te_barcode_ip.Size = new System.Drawing.Size(337, 20);
            this.te_barcode_ip.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(18, 22);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(72, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "数据库地址：";
            // 
            // frmDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(585, 367);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmDatabase";
            this.Text = "数据库配置";
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_scala_pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_scala_ip.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_scala_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_scala_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_barcode_pwd.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_barcode_user.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_barcode_name.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_barcode_ip.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private DevExpress.XtraEditors.SimpleButton sbtn_update;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit te_barcode_ip;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtn_test;
        private DevExpress.XtraEditors.TextEdit te_barcode_pwd;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit te_barcode_user;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit te_barcode_name;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbtn_scala_test;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit te_scala_pwd;
        private DevExpress.XtraEditors.TextEdit te_scala_ip;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit te_scala_user;
        private DevExpress.XtraEditors.TextEdit te_scala_name;
        private DevExpress.XtraEditors.LabelControl labelControl6;
    }
}