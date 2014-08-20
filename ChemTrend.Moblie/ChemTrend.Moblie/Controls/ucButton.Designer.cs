namespace ChemTrend.Moblie.Controls
{
    partial class ucButton
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
            this.lbl_str = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lbl_str
            // 
            this.lbl_str.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_str.ForeColor = System.Drawing.Color.OrangeRed;
            this.lbl_str.Location = new System.Drawing.Point(0, 8);
            this.lbl_str.Name = "lbl_str";
            this.lbl_str.Size = new System.Drawing.Size(57, 16);
            this.lbl_str.Text = "《 返回";
            this.lbl_str.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // ucButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.Controls.Add(this.lbl_str);
            this.Name = "ucButton";
            this.Size = new System.Drawing.Size(60, 32);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label lbl_str;
    }
}
