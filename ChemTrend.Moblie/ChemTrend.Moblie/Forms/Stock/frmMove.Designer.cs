namespace ChemTrend.Moblie.Forms.Stock
{
    partial class frmMove
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMove));
            this.pbox_query = new System.Windows.Forms.PictureBox();
            this.panel_warehouse = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_list = new System.Windows.Forms.DataGrid();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_bin = new System.Windows.Forms.TextBox();
            this.tbox_warehouse = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_bcode = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_warehouse.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel_bcode.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_query
            // 
            this.pbox_query.BackColor = System.Drawing.Color.Transparent;
            this.pbox_query.Image = ((System.Drawing.Image)(resources.GetObject("pbox_query.Image")));
            this.pbox_query.Location = new System.Drawing.Point(208, 3);
            this.pbox_query.Name = "pbox_query";
            this.pbox_query.Size = new System.Drawing.Size(24, 24);
            this.pbox_query.Click += new System.EventHandler(this.pbox_query_Click);
            // 
            // panel_warehouse
            // 
            this.panel_warehouse.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_warehouse.Controls.Add(this.panel2);
            this.panel_warehouse.Controls.Add(this.pbox_query);
            this.panel_warehouse.Controls.Add(this.tbox_barcode);
            this.panel_warehouse.Controls.Add(this.label1);
            this.panel_warehouse.Location = new System.Drawing.Point(0, 37);
            this.panel_warehouse.Name = "panel_warehouse";
            this.panel_warehouse.Size = new System.Drawing.Size(240, 30);
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
            this.tbox_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_barcode.Location = new System.Drawing.Point(52, 5);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(120, 21);
            this.tbox_barcode.TabIndex = 1;
            this.tbox_barcode.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tbox_barcode_KeyDown);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.Text = "条码：";
            // 
            // dg_list
            // 
            this.dg_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dg_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_list.Location = new System.Drawing.Point(0, 0);
            this.dg_list.Name = "dg_list";
            this.dg_list.Size = new System.Drawing.Size(240, 220);
            this.dg_list.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dg_list);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 100);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 220);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(122, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.Text = "库位：";
            // 
            // tbox_bin
            // 
            this.tbox_bin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_bin.Location = new System.Drawing.Point(176, 5);
            this.tbox_bin.Name = "tbox_bin";
            this.tbox_bin.Size = new System.Drawing.Size(60, 21);
            this.tbox_bin.TabIndex = 3;
            // 
            // tbox_warehouse
            // 
            this.tbox_warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_warehouse.Location = new System.Drawing.Point(52, 5);
            this.tbox_warehouse.Name = "tbox_warehouse";
            this.tbox_warehouse.Size = new System.Drawing.Size(60, 21);
            this.tbox_warehouse.TabIndex = 1;
            this.tbox_warehouse.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_warehouse_KeyUp);
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.Text = "仓库：";
            // 
            // panel_bcode
            // 
            this.panel_bcode.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_bcode.Controls.Add(this.panel3);
            this.panel_bcode.Controls.Add(this.label3);
            this.panel_bcode.Controls.Add(this.tbox_bin);
            this.panel_bcode.Controls.Add(this.label2);
            this.panel_bcode.Controls.Add(this.tbox_warehouse);
            this.panel_bcode.Location = new System.Drawing.Point(0, 67);
            this.panel_bcode.Name = "panel_bcode";
            this.panel_bcode.Size = new System.Drawing.Size(240, 30);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 2);
            // 
            // frmMove
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel_bcode);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel_warehouse);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmMove";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmMove_Load);
            this.Controls.SetChildIndex(this.panel_warehouse, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel_bcode, 0);
            this.panel_warehouse.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel_bcode.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_query;
        private System.Windows.Forms.Panel panel_warehouse;
        private System.Windows.Forms.TextBox tbox_barcode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.DataGrid dg_list;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_bin;
        private System.Windows.Forms.TextBox tbox_warehouse;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_bcode;
        private System.Windows.Forms.Panel panel3;
    }
}
