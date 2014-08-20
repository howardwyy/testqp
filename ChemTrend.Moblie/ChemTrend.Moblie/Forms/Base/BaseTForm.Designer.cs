namespace ChemTrend.Moblie.Forms.Base
{
    partial class BaseTForm
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.ucBtn_Action = new ChemTrend.Moblie.Controls.ucButton();
            this.ucBtn_back = new ChemTrend.Moblie.Controls.ucButton();
            this.panel_bottom_line = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.ucBtn_Action);
            this.panel1.Controls.Add(this.ucBtn_back);
            this.panel1.Controls.Add(this.panel_bottom_line);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 36);
            // 
            // ucBtn_Action
            // 
            this.ucBtn_Action.BackColor = System.Drawing.Color.Transparent;
            this.ucBtn_Action.Location = new System.Drawing.Point(186, 0);
            this.ucBtn_Action.Name = "ucBtn_Action";
            this.ucBtn_Action.Size = new System.Drawing.Size(62, 32);
            this.ucBtn_Action.TabIndex = 8;
            this.ucBtn_Action.Visible = false;
            // 
            // ucBtn_back
            // 
            this.ucBtn_back.BackColor = System.Drawing.Color.Transparent;
            this.ucBtn_back.Location = new System.Drawing.Point(-10, 1);
            this.ucBtn_back.Name = "ucBtn_back";
            this.ucBtn_back.Size = new System.Drawing.Size(60, 32);
            this.ucBtn_back.TabIndex = 4;
            this.ucBtn_back.Click += new System.EventHandler(this.ucBtn_back_Click);
            // 
            // panel_bottom_line
            // 
            this.panel_bottom_line.BackColor = System.Drawing.Color.OrangeRed;
            this.panel_bottom_line.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel_bottom_line.Location = new System.Drawing.Point(0, 33);
            this.panel_bottom_line.Name = "panel_bottom_line";
            this.panel_bottom_line.Size = new System.Drawing.Size(240, 3);
            // 
            // lbl_title
            // 
            this.lbl_title.Font = new System.Drawing.Font("Tahoma", 9F, System.Drawing.FontStyle.Bold);
            this.lbl_title.Location = new System.Drawing.Point(69, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(100, 20);
            this.lbl_title.Text = "ChemTrend";
            this.lbl_title.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // BaseTForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel1);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "BaseTForm";
            this.Text = "BaseTForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseTForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.Panel panel_bottom_line;
        private ChemTrend.Moblie.Controls.ucButton ucBtn_back;
        private ChemTrend.Moblie.Controls.ucButton ucBtn_Action;

    }
}