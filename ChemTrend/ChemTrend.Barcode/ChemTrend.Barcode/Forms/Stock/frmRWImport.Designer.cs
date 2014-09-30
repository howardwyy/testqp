namespace ChemTrend.Barcode.Forms.Stock
{
    partial class frmRWImport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRWImport));
            this.sbtn_import = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // sbtn_import
            // 
            this.sbtn_import.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_import.Image")));
            this.sbtn_import.Location = new System.Drawing.Point(305, 124);
            this.sbtn_import.Name = "sbtn_import";
            this.sbtn_import.Size = new System.Drawing.Size(75, 23);
            this.sbtn_import.TabIndex = 0;
            this.sbtn_import.Text = "导入";
            this.sbtn_import.Click += new System.EventHandler(this.sbtn_import_Click);
            // 
            // frmRWImport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(438, 185);
            this.Controls.Add(this.sbtn_import);
            this.Name = "frmRWImport";
            this.ShowIcon = false;
            this.Text = "原材料导入";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtn_import;
    }
}