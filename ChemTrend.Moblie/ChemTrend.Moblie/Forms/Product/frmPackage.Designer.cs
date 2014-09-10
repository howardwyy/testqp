namespace ChemTrend.Moblie.Forms.Product
{
    partial class frmPackage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmPackage));
            this.mainMenu1 = new System.Windows.Forms.MainMenu();
            this.pbox_search_barcode = new System.Windows.Forms.PictureBox();
            this.pbox_search_package = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tbox_package = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.dg_list = new System.Windows.Forms.DataGrid();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel6.SuspendLayout();
            this.SuspendLayout();
            // 
            // pbox_search_barcode
            // 
            this.pbox_search_barcode.BackColor = System.Drawing.Color.Transparent;
            this.pbox_search_barcode.Image = ((System.Drawing.Image)(resources.GetObject("pbox_search_barcode.Image")));
            this.pbox_search_barcode.Location = new System.Drawing.Point(208, 2);
            this.pbox_search_barcode.Name = "pbox_search_barcode";
            this.pbox_search_barcode.Size = new System.Drawing.Size(24, 24);
            // 
            // pbox_search_package
            // 
            this.pbox_search_package.BackColor = System.Drawing.Color.Transparent;
            this.pbox_search_package.Image = ((System.Drawing.Image)(resources.GetObject("pbox_search_package.Image")));
            this.pbox_search_package.Location = new System.Drawing.Point(208, 1);
            this.pbox_search_package.Name = "pbox_search_package";
            this.pbox_search_package.Size = new System.Drawing.Size(24, 24);
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
            // tbox_barcode
            // 
            this.tbox_barcode.Location = new System.Drawing.Point(72, 4);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(120, 21);
            this.tbox_barcode.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(4, 6);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 16);
            this.label2.Text = "条码：";
            // 
            // tbox_package
            // 
            this.tbox_package.Location = new System.Drawing.Point(72, 3);
            this.tbox_package.Name = "tbox_package";
            this.tbox_package.Size = new System.Drawing.Size(120, 21);
            this.tbox_package.TabIndex = 1;
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
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(4, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.Text = "装箱条码：";
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
            this.Text = "frmPackage";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Controls.SetChildIndex(this.panel2, 0);
            this.Controls.SetChildIndex(this.panel3, 0);
            this.Controls.SetChildIndex(this.panel6, 0);
            this.panel3.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel6.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbox_search_barcode;
        private System.Windows.Forms.PictureBox pbox_search_package;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.TextBox tbox_barcode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbox_package;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGrid dg_list;
        private System.Windows.Forms.Panel panel6;
    }
}