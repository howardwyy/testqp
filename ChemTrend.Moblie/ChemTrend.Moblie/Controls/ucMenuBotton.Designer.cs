namespace ChemTrend.Moblie.Controls
{
    partial class ucMenuBotton
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

        #region 组件设计器生成的代码

        /// <summary> 
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMenuBotton));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel_else = new System.Windows.Forms.Panel();
            this.lbl_else = new System.Windows.Forms.Label();
            this.pbox_else = new System.Windows.Forms.PictureBox();
            this.panel_task = new System.Windows.Forms.Panel();
            this.lbl_task = new System.Windows.Forms.Label();
            this.pbox_task = new System.Windows.Forms.PictureBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel_product = new System.Windows.Forms.Panel();
            this.lbl_product = new System.Windows.Forms.Label();
            this.pbox_product = new System.Windows.Forms.PictureBox();
            this.panel_stock = new System.Windows.Forms.Panel();
            this.lbl_stock = new System.Windows.Forms.Label();
            this.pbox_stock = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel_else.SuspendLayout();
            this.panel_task.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel_product.SuspendLayout();
            this.panel_stock.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 48);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.panel_else);
            this.panel2.Controls.Add(this.panel_task);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel2.Location = new System.Drawing.Point(120, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(120, 48);
            // 
            // panel_else
            // 
            this.panel_else.BackColor = System.Drawing.Color.White;
            this.panel_else.Controls.Add(this.lbl_else);
            this.panel_else.Controls.Add(this.pbox_else);
            this.panel_else.Location = new System.Drawing.Point(60, 0);
            this.panel_else.Name = "panel_else";
            this.panel_else.Size = new System.Drawing.Size(60, 50);
            this.panel_else.Click += new System.EventHandler(this.panel_else_Click);
            // 
            // lbl_else
            // 
            this.lbl_else.ForeColor = System.Drawing.Color.Black;
            this.lbl_else.Location = new System.Drawing.Point(2, 33);
            this.lbl_else.Name = "lbl_else";
            this.lbl_else.Size = new System.Drawing.Size(58, 15);
            this.lbl_else.Text = "其他";
            this.lbl_else.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbox_else
            // 
            this.pbox_else.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_else.BackColor = System.Drawing.Color.Transparent;
            this.pbox_else.Image = ((System.Drawing.Image)(resources.GetObject("pbox_else.Image")));
            this.pbox_else.Location = new System.Drawing.Point(16, 2);
            this.pbox_else.Name = "pbox_else";
            this.pbox_else.Size = new System.Drawing.Size(32, 32);
            this.pbox_else.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_else.Click += new System.EventHandler(this.panel_else_Click);
            // 
            // panel_task
            // 
            this.panel_task.BackColor = System.Drawing.Color.White;
            this.panel_task.Controls.Add(this.lbl_task);
            this.panel_task.Controls.Add(this.pbox_task);
            this.panel_task.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_task.Location = new System.Drawing.Point(0, 0);
            this.panel_task.Name = "panel_task";
            this.panel_task.Size = new System.Drawing.Size(60, 48);
            this.panel_task.Click += new System.EventHandler(this.panel_task_Click);
            // 
            // lbl_task
            // 
            this.lbl_task.ForeColor = System.Drawing.Color.Black;
            this.lbl_task.Location = new System.Drawing.Point(2, 33);
            this.lbl_task.Name = "lbl_task";
            this.lbl_task.Size = new System.Drawing.Size(58, 15);
            this.lbl_task.Text = "工时汇报";
            this.lbl_task.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbox_task
            // 
            this.pbox_task.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_task.BackColor = System.Drawing.Color.Transparent;
            this.pbox_task.Image = ((System.Drawing.Image)(resources.GetObject("pbox_task.Image")));
            this.pbox_task.Location = new System.Drawing.Point(15, 2);
            this.pbox_task.Name = "pbox_task";
            this.pbox_task.Size = new System.Drawing.Size(30, 30);
            this.pbox_task.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_task.Click += new System.EventHandler(this.panel_task_Click);
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel_product);
            this.panel3.Controls.Add(this.panel_stock);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(120, 48);
            // 
            // panel_product
            // 
            this.panel_product.BackColor = System.Drawing.Color.White;
            this.panel_product.Controls.Add(this.lbl_product);
            this.panel_product.Controls.Add(this.pbox_product);
            this.panel_product.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel_product.Location = new System.Drawing.Point(60, 0);
            this.panel_product.Name = "panel_product";
            this.panel_product.Size = new System.Drawing.Size(60, 48);
            this.panel_product.Click += new System.EventHandler(this.panel_product_Click);
            // 
            // lbl_product
            // 
            this.lbl_product.ForeColor = System.Drawing.Color.Black;
            this.lbl_product.Location = new System.Drawing.Point(0, 33);
            this.lbl_product.Name = "lbl_product";
            this.lbl_product.Size = new System.Drawing.Size(58, 15);
            this.lbl_product.Text = "成品";
            this.lbl_product.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbox_product
            // 
            this.pbox_product.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_product.BackColor = System.Drawing.Color.Transparent;
            this.pbox_product.Image = ((System.Drawing.Image)(resources.GetObject("pbox_product.Image")));
            this.pbox_product.Location = new System.Drawing.Point(15, 2);
            this.pbox_product.Name = "pbox_product";
            this.pbox_product.Size = new System.Drawing.Size(30, 30);
            this.pbox_product.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_product.Click += new System.EventHandler(this.panel_product_Click);
            // 
            // panel_stock
            // 
            this.panel_stock.BackColor = System.Drawing.Color.White;
            this.panel_stock.Controls.Add(this.lbl_stock);
            this.panel_stock.Controls.Add(this.pbox_stock);
            this.panel_stock.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel_stock.Location = new System.Drawing.Point(0, 0);
            this.panel_stock.Name = "panel_stock";
            this.panel_stock.Size = new System.Drawing.Size(60, 48);
            this.panel_stock.Click += new System.EventHandler(this.panel_stock_Click);
            // 
            // lbl_stock
            // 
            this.lbl_stock.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_stock.Location = new System.Drawing.Point(0, 33);
            this.lbl_stock.Name = "lbl_stock";
            this.lbl_stock.Size = new System.Drawing.Size(58, 15);
            this.lbl_stock.Text = "原材料";
            this.lbl_stock.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbox_stock
            // 
            this.pbox_stock.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.pbox_stock.BackColor = System.Drawing.Color.Transparent;
            this.pbox_stock.Image = ((System.Drawing.Image)(resources.GetObject("pbox_stock.Image")));
            this.pbox_stock.Location = new System.Drawing.Point(12, 2);
            this.pbox_stock.Name = "pbox_stock";
            this.pbox_stock.Size = new System.Drawing.Size(30, 30);
            this.pbox_stock.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbox_stock.Click += new System.EventHandler(this.panel_stock_Click);
            // 
            // ucMenuBotton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.DarkOrange;
            this.Controls.Add(this.panel1);
            this.Name = "ucMenuBotton";
            this.Size = new System.Drawing.Size(240, 50);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel_else.ResumeLayout(false);
            this.panel_task.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel_product.ResumeLayout(false);
            this.panel_stock.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel_product;
        private System.Windows.Forms.Label lbl_product;
        private System.Windows.Forms.PictureBox pbox_product;
        private System.Windows.Forms.Panel panel_stock;
        private System.Windows.Forms.Label lbl_stock;
        private System.Windows.Forms.PictureBox pbox_stock;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel_else;
        private System.Windows.Forms.Label lbl_else;
        private System.Windows.Forms.PictureBox pbox_else;
        private System.Windows.Forms.Panel panel_task;
        private System.Windows.Forms.Label lbl_task;
        private System.Windows.Forms.PictureBox pbox_task;




    }
}
