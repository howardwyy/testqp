namespace ChemTrend.Moblie.Controls
{
    partial class ucTitle
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
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel_bottom_line = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.BackColor = System.Drawing.Color.White;
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(-1, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(240, 20);
            this.lbl_title.Text = "ChemTrend";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // panel_bottom_line
            // 
            this.panel_bottom_line.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_bottom_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom_line.Location = new System.Drawing.Point(0, 33);
            this.panel_bottom_line.Name = "panel_bottom_line";
            this.panel_bottom_line.Size = new System.Drawing.Size(238, 3);
            // 
            // ucTitle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel_bottom_line);
            this.Controls.Add(this.lbl_title);
            this.ForeColor = System.Drawing.Color.Transparent;
            this.Name = "ucTitle";
            this.Size = new System.Drawing.Size(238, 36);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_bottom_line;
    }
}
