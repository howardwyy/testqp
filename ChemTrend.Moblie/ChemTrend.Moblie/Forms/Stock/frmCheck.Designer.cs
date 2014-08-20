namespace ChemTrend.Moblie.Forms.Stock
{
    partial class frmCheck
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCheck));
            this.pbox_search = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_search
            // 
            this.pbox_search.BackColor = System.Drawing.Color.Transparent;
            this.pbox_search.Image = ((System.Drawing.Image)(resources.GetObject("pbox_search.Image")));
            this.pbox_search.Location = new System.Drawing.Point(208, 1);
            this.pbox_search.Name = "pbox_search";
            this.pbox_search.Size = new System.Drawing.Size(24, 24);
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel2);
            this.panel3.Controls.Add(this.pbox_search);
            this.panel3.Controls.Add(this.tbox_barcode);
            this.panel3.Controls.Add(this.lbl_barcode);
            this.panel3.Location = new System.Drawing.Point(0, 36);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 30);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 2);
            // 
            // tbox_barcode
            // 
            this.tbox_barcode.Location = new System.Drawing.Point(60, 3);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(120, 21);
            this.tbox_barcode.TabIndex = 1;
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.Location = new System.Drawing.Point(5, 7);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(58, 16);
            this.lbl_barcode.Text = "条码：";
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCheck";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCheck_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbox_barcode;
        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.Panel panel2;

    }
}
