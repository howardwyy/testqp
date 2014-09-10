namespace ChemTrend.Moblie.Forms.Product
{
    partial class frmDelivery
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmDelivery));
            this.dg_list = new System.Windows.Forms.DataGrid();
            this.panel6 = new System.Windows.Forms.Panel();
            this.pbox_delivery = new System.Windows.Forms.PictureBox();
            this.tbox_delivery = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel_warehouse = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pbox_query = new System.Windows.Forms.PictureBox();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel6.SuspendLayout();
            this.panel_warehouse.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
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
            // pbox_delivery
            // 
            this.pbox_delivery.BackColor = System.Drawing.Color.Transparent;
            this.pbox_delivery.Image = ((System.Drawing.Image)(resources.GetObject("pbox_delivery.Image")));
            this.pbox_delivery.Location = new System.Drawing.Point(208, 3);
            this.pbox_delivery.Name = "pbox_delivery";
            this.pbox_delivery.Size = new System.Drawing.Size(24, 24);
            this.pbox_delivery.Click += new System.EventHandler(this.pbox_delivery_Click);
            // 
            // tbox_delivery
            // 
            this.tbox_delivery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_delivery.Location = new System.Drawing.Point(58, 5);
            this.tbox_delivery.Name = "tbox_delivery";
            this.tbox_delivery.Size = new System.Drawing.Size(120, 21);
            this.tbox_delivery.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 16);
            this.label1.Text = "发货单：";
            // 
            // panel_warehouse
            // 
            this.panel_warehouse.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_warehouse.Controls.Add(this.panel2);
            this.panel_warehouse.Controls.Add(this.pbox_delivery);
            this.panel_warehouse.Controls.Add(this.tbox_delivery);
            this.panel_warehouse.Controls.Add(this.label1);
            this.panel_warehouse.Location = new System.Drawing.Point(0, 36);
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
            // pbox_query
            // 
            this.pbox_query.BackColor = System.Drawing.Color.Transparent;
            this.pbox_query.Image = ((System.Drawing.Image)(resources.GetObject("pbox_query.Image")));
            this.pbox_query.Location = new System.Drawing.Point(208, 3);
            this.pbox_query.Name = "pbox_query";
            this.pbox_query.Size = new System.Drawing.Size(24, 24);
            this.pbox_query.Click += new System.EventHandler(this.pbox_query_Click);
            // 
            // tbox_barcode
            // 
            this.tbox_barcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_barcode.Location = new System.Drawing.Point(58, 5);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(120, 21);
            this.tbox_barcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 16);
            this.label2.Text = "条码：";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.Gainsboro;
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Controls.Add(this.pbox_query);
            this.panel3.Controls.Add(this.tbox_barcode);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Location = new System.Drawing.Point(0, 66);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(240, 30);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gray;
            this.panel4.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel4.Location = new System.Drawing.Point(0, 28);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(240, 2);
            // 
            // frmDelivery
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel_warehouse);
            this.Controls.Add(this.panel6);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmDelivery";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmDelivery_Load);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel_warehouse, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.panel6.ResumeLayout(false);
            this.panel_warehouse.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGrid dg_list;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.PictureBox pbox_delivery;
        private System.Windows.Forms.TextBox tbox_delivery;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel_warehouse;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pbox_query;
        private System.Windows.Forms.TextBox tbox_barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;

    }
}
