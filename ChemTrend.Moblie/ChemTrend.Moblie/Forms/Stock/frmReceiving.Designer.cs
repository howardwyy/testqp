namespace ChemTrend.Moblie.Forms.Stock
{
    partial class frmReceiving
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmReceiving));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.tbox_bin = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.pbox_search_barcode = new System.Windows.Forms.PictureBox();
            this.tbox_warehouse = new System.Windows.Forms.TextBox();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.panel_bcode = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.dg_list = new System.Windows.Forms.DataGrid();
            this.panel6 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.tbox_surplus = new System.Windows.Forms.TextBox();
            this.tbox_stockcode = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel_bcode.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel6.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
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
            // label3
            // 
            this.label3.BackColor = System.Drawing.Color.Gainsboro;
            this.label3.Location = new System.Drawing.Point(122, 7);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 16);
            this.label3.Text = "库位：";
            // 
            // label4
            // 
            this.label4.BackColor = System.Drawing.Color.Gainsboro;
            this.label4.Location = new System.Drawing.Point(4, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(46, 16);
            this.label4.Text = "仓库：";
            // 
            // pbox_search_barcode
            // 
            this.pbox_search_barcode.BackColor = System.Drawing.Color.Transparent;
            this.pbox_search_barcode.Image = ((System.Drawing.Image)(resources.GetObject("pbox_search_barcode.Image")));
            this.pbox_search_barcode.Location = new System.Drawing.Point(208, 3);
            this.pbox_search_barcode.Name = "pbox_search_barcode";
            this.pbox_search_barcode.Size = new System.Drawing.Size(24, 24);
            this.pbox_search_barcode.Click += new System.EventHandler(this.pbox_search_barcode_Click);
            // 
            // tbox_warehouse
            // 
            this.tbox_warehouse.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_warehouse.Location = new System.Drawing.Point(52, 5);
            this.tbox_warehouse.Name = "tbox_warehouse";
            this.tbox_warehouse.Size = new System.Drawing.Size(60, 21);
            this.tbox_warehouse.TabIndex = 1;
            // 
            // tbox_barcode
            // 
            this.tbox_barcode.Location = new System.Drawing.Point(72, 5);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(120, 21);
            this.tbox_barcode.TabIndex = 1;
            this.tbox_barcode.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbox_barcode_KeyUp);
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 7);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.Text = "条码：";
            // 
            // panel_bcode
            // 
            this.panel_bcode.BackColor = System.Drawing.Color.Gainsboro;
            this.panel_bcode.Controls.Add(this.panel7);
            this.panel_bcode.Controls.Add(this.label3);
            this.panel_bcode.Controls.Add(this.tbox_bin);
            this.panel_bcode.Controls.Add(this.label4);
            this.panel_bcode.Controls.Add(this.tbox_warehouse);
            this.panel_bcode.Location = new System.Drawing.Point(0, 95);
            this.panel_bcode.Name = "panel_bcode";
            this.panel_bcode.Size = new System.Drawing.Size(240, 30);
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.Gray;
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 28);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(240, 2);
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
            this.panel3.Location = new System.Drawing.Point(0, 36);
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
            // dg_list
            // 
            this.dg_list.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.dg_list.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dg_list.Location = new System.Drawing.Point(0, 0);
            this.dg_list.Name = "dg_list";
            this.dg_list.Size = new System.Drawing.Size(240, 190);
            this.dg_list.TabIndex = 1;
            // 
            // panel6
            // 
            this.panel6.Controls.Add(this.dg_list);
            this.panel6.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel6.Location = new System.Drawing.Point(0, 130);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(240, 190);
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.Gainsboro;
            this.label1.Location = new System.Drawing.Point(122, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 16);
            this.label1.Text = "剩余：";
            // 
            // tbox_surplus
            // 
            this.tbox_surplus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_surplus.Location = new System.Drawing.Point(176, 5);
            this.tbox_surplus.Name = "tbox_surplus";
            this.tbox_surplus.Size = new System.Drawing.Size(60, 21);
            this.tbox_surplus.TabIndex = 3;
            // 
            // tbox_stockcode
            // 
            this.tbox_stockcode.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.tbox_stockcode.Location = new System.Drawing.Point(52, 5);
            this.tbox_stockcode.Name = "tbox_stockcode";
            this.tbox_stockcode.Size = new System.Drawing.Size(60, 21);
            this.tbox_stockcode.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.BackColor = System.Drawing.Color.Gainsboro;
            this.label5.Location = new System.Drawing.Point(4, 7);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 16);
            this.label5.Text = "物料：";
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.Gainsboro;
            this.panel2.Controls.Add(this.panel4);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.tbox_surplus);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.tbox_stockcode);
            this.panel2.Location = new System.Drawing.Point(0, 65);
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
            // frmReceiving
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel_bcode);
            this.Controls.Add(this.panel3);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmReceiving";
            this.Text = "frmReceiving";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmReceiving_Load);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel_bcode, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.Controls.SetChildIndex(this.panel2, 0);
            this.panel_bcode.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox tbox_bin;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.PictureBox pbox_search_barcode;
        private System.Windows.Forms.TextBox tbox_warehouse;
        private System.Windows.Forms.TextBox tbox_barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel_bcode;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.DataGrid dg_list;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tbox_surplus;
        private System.Windows.Forms.TextBox tbox_stockcode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
    }
}