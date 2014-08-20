namespace ChemTrend.Moblie.Forms.Stock
{
    partial class frmSInWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSInWarehouse));
            this.panel_barcode = new System.Windows.Forms.Panel();
            this.panel_warehouse = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.pbox_barcode_add = new System.Windows.Forms.PictureBox();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_bcode = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.tbox_bin = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_warehouse = new System.Windows.Forms.TextBox();
            this.panel_order = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbox_search_package = new System.Windows.Forms.PictureBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.lbl_order = new System.Windows.Forms.Label();
            this.panel_barcode.SuspendLayout();
            this.panel_warehouse.SuspendLayout();
            this.panel_bcode.SuspendLayout();
            this.panel_order.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel_barcode
            // 
            this.panel_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.panel_barcode.Controls.Add(this.panel_warehouse);
            this.panel_barcode.Controls.Add(this.panel_bcode);
            this.panel_barcode.Controls.Add(this.panel_order);
            this.panel_barcode.Location = new System.Drawing.Point(0, 36);
            this.panel_barcode.Name = "panel_barcode";
            this.panel_barcode.Size = new System.Drawing.Size(240, 90);
            // 
            // panel_warehouse
            // 
            this.panel_warehouse.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_warehouse.Controls.Add(this.panel3);
            this.panel_warehouse.Controls.Add(this.pbox_barcode_add);
            this.panel_warehouse.Controls.Add(this.tbox_barcode);
            this.panel_warehouse.Controls.Add(this.label1);
            this.panel_warehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_warehouse.Location = new System.Drawing.Point(0, 30);
            this.panel_warehouse.Name = "panel_warehouse";
            this.panel_warehouse.Size = new System.Drawing.Size(240, 30);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gray;
            this.panel3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel3.Location = new System.Drawing.Point(0, 28);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 2);
            // 
            // pbox_barcode_add
            // 
            this.pbox_barcode_add.BackColor = System.Drawing.Color.Transparent;
            this.pbox_barcode_add.Image = ((System.Drawing.Image)(resources.GetObject("pbox_barcode_add.Image")));
            this.pbox_barcode_add.Location = new System.Drawing.Point(208, 2);
            this.pbox_barcode_add.Name = "pbox_barcode_add";
            this.pbox_barcode_add.Size = new System.Drawing.Size(24, 24);
            this.pbox_barcode_add.Click += new System.EventHandler(this.pbox_barcode_add_Click);
            // 
            // tbox_barcode
            // 
            this.tbox_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_barcode.Location = new System.Drawing.Point(58, 4);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(120, 21);
            this.tbox_barcode.TabIndex = 1;
            this.tbox_barcode.Text = "RW0100000097";
            this.tbox_barcode.TextChanged += new System.EventHandler(this.tbox_barcode_TextChanged);
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.Text = "条码：";
            // 
            // panel_bcode
            // 
            this.panel_bcode.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_bcode.Controls.Add(this.panel4);
            this.panel_bcode.Controls.Add(this.label3);
            this.panel_bcode.Controls.Add(this.tbox_bin);
            this.panel_bcode.Controls.Add(this.label2);
            this.panel_bcode.Controls.Add(this.tbox_warehouse);
            this.panel_bcode.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bcode.Location = new System.Drawing.Point(0, 60);
            this.panel_bcode.Name = "panel_bcode";
            this.panel_bcode.Size = new System.Drawing.Size(240, 30);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 2);
            // 
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(122, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.Text = "库位：";
            // 
            // tbox_bin
            // 
            this.tbox_bin.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_bin.Location = new System.Drawing.Point(176, 3);
            this.tbox_bin.Name = "tbox_bin";
            this.tbox_bin.Size = new System.Drawing.Size(60, 21);
            this.tbox_bin.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.BackColor = System.Drawing.Color.Gainsboro;
            this.label2.Location = new System.Drawing.Point(4, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.Text = "仓库：";
            // 
            // tbox_warehouse
            // 
            this.tbox_warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_warehouse.Location = new System.Drawing.Point(52, 3);
            this.tbox_warehouse.Name = "tbox_warehouse";
            this.tbox_warehouse.Size = new System.Drawing.Size(60, 21);
            this.tbox_warehouse.TabIndex = 1;
            this.tbox_warehouse.TextChanged += new System.EventHandler(this.tbox_warehouse_TextChanged);
            // 
            // panel_order
            // 
            this.panel_order.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_order.Controls.Add(this.panel2);
            this.panel_order.Controls.Add(this.pbox_search_package);
            this.panel_order.Controls.Add(this.textBox3);
            this.panel_order.Controls.Add(this.lbl_order);
            this.panel_order.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel_order.Location = new System.Drawing.Point(0, 0);
            this.panel_order.Name = "panel_order";
            this.panel_order.Size = new System.Drawing.Size(240, 30);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gray;
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 28);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(240, 2);
            // 
            // pbox_search_package
            // 
            this.pbox_search_package.BackColor = System.Drawing.Color.Transparent;
            this.pbox_search_package.Image = ((System.Drawing.Image)(resources.GetObject("pbox_search_package.Image")));
            this.pbox_search_package.Location = new System.Drawing.Point(208, 2);
            this.pbox_search_package.Name = "pbox_search_package";
            this.pbox_search_package.Size = new System.Drawing.Size(24, 24);
            // 
            // textBox3
            // 
            this.textBox3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.textBox3.Location = new System.Drawing.Point(58, 4);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(120, 21);
            this.textBox3.TabIndex = 4;
            // 
            // lbl_order
            // 
            this.lbl_order.Location = new System.Drawing.Point(4, 6);
            this.lbl_order.Name = "lbl_order";
            this.lbl_order.Size = new System.Drawing.Size(50, 16);
            this.lbl_order.Text = "订单：";
            // 
            // frmSInWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel_barcode);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmSInWarehouse";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmSInWarehouse_Load);
            this.Controls.SetChildIndex(this.panel_barcode, 0);
            this.panel_barcode.ResumeLayout(false);
            this.panel_warehouse.ResumeLayout(false);
            this.panel_bcode.ResumeLayout(false);
            this.panel_order.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel_barcode;
        private System.Windows.Forms.Panel panel_bcode;
        private System.Windows.Forms.Panel panel_order;
        private System.Windows.Forms.Panel panel_warehouse;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_order;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_barcode;
        private System.Windows.Forms.TextBox tbox_warehouse;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbox_bin;
        private System.Windows.Forms.PictureBox pbox_barcode_add;
        private System.Windows.Forms.PictureBox pbox_search_package;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel2;
    }
}
