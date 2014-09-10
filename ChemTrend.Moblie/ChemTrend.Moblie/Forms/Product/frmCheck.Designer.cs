namespace ChemTrend.Moblie.Forms.Product
{
    partial class frmCheck
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;
        private System.Windows.Forms.MainMenu mainMenu1;

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
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbox_search = new System.Windows.Forms.PictureBox();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.lbl_barcode = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.dg_list = new System.Windows.Forms.DataGrid();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
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
            // pbox_search
            // 
            this.pbox_search.BackColor = System.Drawing.Color.Transparent;
            this.pbox_search.Image = ((System.Drawing.Image)(resources.GetObject("pbox_search.Image")));
            this.pbox_search.Location = new System.Drawing.Point(208, 1);
            this.pbox_search.Name = "pbox_search";
            this.pbox_search.Size = new System.Drawing.Size(24, 24);
            this.pbox_search.Click += new System.EventHandler(this.pbox_search_Click);
            // 
            // tbox_barcode
            // 
            this.tbox_barcode.Location = new System.Drawing.Point(60, 3);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(120, 21);
            this.tbox_barcode.TabIndex = 1;
            this.tbox_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_barcode_KeyDown);
            // 
            // lbl_barcode
            // 
            this.lbl_barcode.Location = new System.Drawing.Point(5, 7);
            this.lbl_barcode.Name = "lbl_barcode";
            this.lbl_barcode.Size = new System.Drawing.Size(58, 16);
            this.lbl_barcode.Text = "条码：";
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.dg_list);
            this.panel4.Location = new System.Drawing.Point(0, 70);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 250);
            // 
            // dg_list
            // 
            this.dg_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dg_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_list.Location = new System.Drawing.Point(0, 0);
            this.dg_list.Name = "dg_list";
            this.dg_list.Size = new System.Drawing.Size(240, 250);
            this.dg_list.TabIndex = 0;
            // 
            // frmCheck
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel4);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmCheck";
            this.Text = "frmCheck";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmCheck_Load);
            this.Controls.SetChildIndex(this.panel4, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_search;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox tbox_barcode;
        private System.Windows.Forms.Label lbl_barcode;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.DataGrid dg_list;
    }
}