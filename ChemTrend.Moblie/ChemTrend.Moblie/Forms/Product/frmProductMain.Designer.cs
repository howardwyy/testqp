namespace ChemTrend.Moblie.Forms.Product
{
    partial class frmProductMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmProductMain));
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.pbox_delivery = new System.Windows.Forms.PictureBox();
            this.pbox_check = new System.Windows.Forms.PictureBox();
            this.pbox_package = new System.Windows.Forms.PictureBox();
            this.pbox_move = new System.Windows.Forms.PictureBox();
            this.pbox_inwarehouse = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label4
            // 
            this.label4.Location = new System.Drawing.Point(90, 186);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 16);
            this.label4.Text = "装箱";
            this.label4.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label5
            // 
            this.label5.Location = new System.Drawing.Point(9, 186);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 16);
            this.label5.Text = "发往客户";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.Location = new System.Drawing.Point(170, 99);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 16);
            this.label3.Text = "移库";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.Location = new System.Drawing.Point(89, 99);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 16);
            this.label2.Text = "盘点";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(8, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.Text = "入库";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbox_delivery
            // 
            this.pbox_delivery.BackColor = System.Drawing.Color.Transparent;
            this.pbox_delivery.Image = ((System.Drawing.Image)(resources.GetObject("pbox_delivery.Image")));
            this.pbox_delivery.Location = new System.Drawing.Point(18, 143);
            this.pbox_delivery.Name = "pbox_delivery";
            this.pbox_delivery.Size = new System.Drawing.Size(40, 40);
            this.pbox_delivery.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_delivery.Click += new System.EventHandler(this.pbox_delivery_Click);
            // 
            // pbox_check
            // 
            this.pbox_check.BackColor = System.Drawing.Color.Transparent;
            this.pbox_check.Image = ((System.Drawing.Image)(resources.GetObject("pbox_check.Image")));
            this.pbox_check.Location = new System.Drawing.Point(102, 56);
            this.pbox_check.Name = "pbox_check";
            this.pbox_check.Size = new System.Drawing.Size(40, 40);
            this.pbox_check.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_check.Click += new System.EventHandler(this.pbox_check_Click);
            // 
            // pbox_package
            // 
            this.pbox_package.BackColor = System.Drawing.Color.Transparent;
            this.pbox_package.Image = ((System.Drawing.Image)(resources.GetObject("pbox_package.Image")));
            this.pbox_package.Location = new System.Drawing.Point(102, 143);
            this.pbox_package.Name = "pbox_package";
            this.pbox_package.Size = new System.Drawing.Size(40, 40);
            this.pbox_package.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_package.Click += new System.EventHandler(this.pbox_package_Click);
            // 
            // pbox_move
            // 
            this.pbox_move.BackColor = System.Drawing.Color.Transparent;
            this.pbox_move.Image = ((System.Drawing.Image)(resources.GetObject("pbox_move.Image")));
            this.pbox_move.Location = new System.Drawing.Point(181, 56);
            this.pbox_move.Name = "pbox_move";
            this.pbox_move.Size = new System.Drawing.Size(40, 40);
            this.pbox_move.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_move.Click += new System.EventHandler(this.pbox_move_Click);
            // 
            // pbox_inwarehouse
            // 
            this.pbox_inwarehouse.BackColor = System.Drawing.Color.Transparent;
            this.pbox_inwarehouse.Image = ((System.Drawing.Image)(resources.GetObject("pbox_inwarehouse.Image")));
            this.pbox_inwarehouse.Location = new System.Drawing.Point(18, 56);
            this.pbox_inwarehouse.Name = "pbox_inwarehouse";
            this.pbox_inwarehouse.Size = new System.Drawing.Size(40, 40);
            this.pbox_inwarehouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbox_inwarehouse.Click += new System.EventHandler(this.pbox_inwarehouse_Click);
            // 
            // frmProductMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbox_delivery);
            this.Controls.Add(this.pbox_check);
            this.Controls.Add(this.pbox_package);
            this.Controls.Add(this.pbox_move);
            this.Controls.Add(this.pbox_inwarehouse);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmProductMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmProductMain_Load);
            this.Controls.SetChildIndex(this.pbox_inwarehouse, 0);
            this.Controls.SetChildIndex(this.pbox_move, 0);
            this.Controls.SetChildIndex(this.pbox_package, 0);
            this.Controls.SetChildIndex(this.pbox_check, 0);
            this.Controls.SetChildIndex(this.pbox_delivery, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.Controls.SetChildIndex(this.label2, 0);
            this.Controls.SetChildIndex(this.label3, 0);
            this.Controls.SetChildIndex(this.label5, 0);
            this.Controls.SetChildIndex(this.label4, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbox_delivery;
        private System.Windows.Forms.PictureBox pbox_check;
        private System.Windows.Forms.PictureBox pbox_package;
        private System.Windows.Forms.PictureBox pbox_move;
        private System.Windows.Forms.PictureBox pbox_inwarehouse;
    }
}
