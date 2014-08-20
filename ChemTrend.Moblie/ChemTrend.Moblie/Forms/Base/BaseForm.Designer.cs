namespace ChemTrend.Moblie.Forms.Base
{
    partial class BaseForm
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
            this.ucMB_menu = new ChemTrend.Moblie.Controls.ucMenuBotton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel_bottom_line = new System.Windows.Forms.Panel();
            this.lbl_title = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // ucMB_menu
            // 
            this.ucMB_menu.BackColor = System.Drawing.SystemColors.GrayText;
            this.ucMB_menu.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ucMB_menu.Location = new System.Drawing.Point(0, 270);
            this.ucMB_menu.Name = "ucMB_menu";
            this.ucMB_menu.Size = new System.Drawing.Size(240, 50);
            this.ucMB_menu.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel_bottom_line);
            this.panel1.Controls.Add(this.lbl_title);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(240, 36);
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
            // BaseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.AutoScroll = true;
            this.ClientSize = new System.Drawing.Size(240, 320);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.ucMB_menu);
            this.Location = new System.Drawing.Point(0, 0);
            this.Name = "BaseForm";
            this.Text = "BaseForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.BaseForm_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private ChemTrend.Moblie.Controls.ucMenuBotton ucMB_menu;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel_bottom_line;
        private System.Windows.Forms.Label lbl_title;

    }
}