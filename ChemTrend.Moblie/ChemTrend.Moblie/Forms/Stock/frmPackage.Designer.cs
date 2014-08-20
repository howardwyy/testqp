namespace ChemTrend.Moblie.Forms.Stock
{
    partial class frmPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackage));
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.pbox_search_package = new System.Windows.Forms.PictureBox();
            this.tbox_package = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.pbox_search_barcode = new System.Windows.Forms.PictureBox();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.lv_barcode = new System.Windows.Forms.ListView();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.pbox_search_package);
            this.panel2.Controls.Add(this.tbox_package);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Location = new System.Drawing.Point(0, 36);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 30);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 2);
            // 
            // pbox_search_package
            // 
            this.pbox_search_package.BackColor = System.Drawing.Color.Transparent;
            this.pbox_search_package.Image = ((System.Drawing.Image)(resources.GetObject("pbox_search_package.Image")));
            this.pbox_search_package.Location = new System.Drawing.Point(208, 1);
            this.pbox_search_package.Name = "pbox_search_package";
            this.pbox_search_package.Size = new System.Drawing.Size(24, 24);
            this.pbox_search_package.Click += new System.EventHandler(this.pbox_search_package_Click);
            // 
            // tbox_package
            // 
            this.tbox_package.Location = new System.Drawing.Point(72, 3);
            this.tbox_package.Name = "tbox_package";
            this.tbox_package.Size = new System.Drawing.Size(120, 21);
            this.tbox_package.TabIndex = 1;
            this.tbox_package.Text = "RW0700000022";
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.Text = "装箱条码：";
            // 
            // panel3
            // 
            this.panel3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel5);
            this.panel3.Controls.Add(this.pbox_search_barcode);
            this.panel3.Controls.Add(this.tbox_barcode);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 30);
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.Gray;
            this.panel5.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel5.Location = new System.Drawing.Point(0, 28);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(240, 2);
            // 
            // pbox_search_barcode
            // 
            this.pbox_search_barcode.BackColor = System.Drawing.Color.Transparent;
            this.pbox_search_barcode.Image = ((System.Drawing.Image)(resources.GetObject("pbox_search_barcode.Image")));
            this.pbox_search_barcode.Location = new System.Drawing.Point(208, 2);
            this.pbox_search_barcode.Name = "pbox_search_barcode";
            this.pbox_search_barcode.Size = new System.Drawing.Size(24, 24);
            this.pbox_search_barcode.Click += new System.EventHandler(this.pbox_search_barcode_Click);
            // 
            // tbox_barcode
            // 
            this.tbox_barcode.Location = new System.Drawing.Point(72, 4);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(120, 21);
            this.tbox_barcode.TabIndex = 1;
            this.tbox_barcode.Text = "RW0100000086";
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.Text = "条码：";
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.lv_barcode);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 220);
            // 
            // lv_barcode
            // 
            this.lv_barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lv_barcode.Location = new System.Drawing.Point(0, 0);
            this.lv_barcode.Name = "lv_barcode";
            this.lv_barcode.Size = new System.Drawing.Size(240, 220);
            this.lv_barcode.TabIndex = 0;
            this.lv_barcode.ItemActivate += new System.EventHandler(this.lv_barcode_ItemActivate);
            // 
            // frmPackage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmPackage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmPackage_Load);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel2.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_package;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tbox_barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox pbox_search_package;
        private System.Windows.Forms.PictureBox pbox_search_barcode;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.ListView lv_barcode;
    }
}
