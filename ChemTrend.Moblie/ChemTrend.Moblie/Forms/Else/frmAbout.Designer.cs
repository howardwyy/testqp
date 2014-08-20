namespace ChemTrend.Moblie.Forms.Else
{
    partial class frmAbout
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
            this.lbl_about = new System.Windows.Forms.Label();
            this.lbl_copyright = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_about
            // 
            this.lbl_about.Location = new System.Drawing.Point(28, 77);
            this.lbl_about.Name = "lbl_about";
            this.lbl_about.Size = new System.Drawing.Size(180, 120);
            this.lbl_about.Text = "   肯天开发的产品旨在帮助客户提高零部件质量、改进生产效率、减少材料浪费、降低总体生产成本。此外，肯天驰骋业界50多年，全心服务全球制造业客户，所生产的加工助剂" +
                "品质一流。";
            // 
            // lbl_copyright
            // 
            this.lbl_copyright.Location = new System.Drawing.Point(28, 270);
            this.lbl_copyright.Name = "lbl_copyright";
            this.lbl_copyright.Size = new System.Drawing.Size(180, 46);
            this.lbl_copyright.Text = "CopyRight © 2004-2015 shinfomelody, All Rights Reserved.";
            this.lbl_copyright.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.lbl_copyright.ParentChanged += new System.EventHandler(this.lbl_copyright_ParentChanged);
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.lbl_about);
            this.Controls.Add(this.lbl_copyright);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmAbout";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAbout_Load);
            this.Controls.SetChildIndex(this.lbl_copyright, 0);
            this.Controls.SetChildIndex(this.lbl_about, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_about;
        private System.Windows.Forms.Label lbl_copyright;
    }
}
