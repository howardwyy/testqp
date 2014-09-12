namespace ChemTrend.Moblie.Forms.Task
{
    partial class frmTaskMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTaskMain));
            this.label1 = new System.Windows.Forms.Label();
            this.pbox_inwarehouse = new System.Windows.Forms.PictureBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.Location = new System.Drawing.Point(6, 99);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 16);
            this.label1.Text = "工序记录";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // pbox_inwarehouse
            // 
            this.pbox_inwarehouse.BackColor = System.Drawing.Color.Transparent;
            this.pbox_inwarehouse.Image = ((System.Drawing.Image)(resources.GetObject("pbox_inwarehouse.Image")));
            this.pbox_inwarehouse.Location = new System.Drawing.Point(18, 56);
            this.pbox_inwarehouse.Name = "pbox_inwarehouse";
            this.pbox_inwarehouse.Size = new System.Drawing.Size(40, 40);
            this.pbox_inwarehouse.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            // 
            // frmTaskMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbox_inwarehouse);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "frmTaskMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmTaskMain_Load);
            this.Controls.SetChildIndex(this.pbox_inwarehouse, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pbox_inwarehouse;
    }
}
