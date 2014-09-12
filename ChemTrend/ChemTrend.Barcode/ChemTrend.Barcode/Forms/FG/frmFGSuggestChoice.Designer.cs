namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGSuggestChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGSuggestChoice));
            this.gc_customer = new DevExpress.XtraGrid.GridControl();
            this.gv_customer = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_code = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_sure = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_customer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_customer
            // 
            this.gc_customer.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_customer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_customer.Location = new System.Drawing.Point(2, 2);
            this.gc_customer.MainView = this.gv_customer;
            this.gc_customer.Name = "gc_customer";
            this.gc_customer.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gc_customer.Size = new System.Drawing.Size(503, 362);
            this.gc_customer.TabIndex = 1;
            this.gc_customer.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_customer});
            // 
            // gv_customer
            // 
            this.gv_customer.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_check,
            this.col_no,
            this.col_code,
            this.col_name});
            this.gv_customer.GridControl = this.gc_customer;
            this.gv_customer.Name = "gv_customer";
            this.gv_customer.OptionsView.ShowGroupPanel = false;
            // 
            // gc_check
            // 
            this.gc_check.Caption = "选择";
            this.gc_check.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gc_check.Name = "gc_check";
            this.gc_check.Visible = true;
            this.gc_check.VisibleIndex = 0;
            this.gc_check.Width = 39;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // col_no
            // 
            this.col_no.Caption = "建议单号";
            this.col_no.Name = "col_no";
            this.col_no.Visible = true;
            this.col_no.VisibleIndex = 1;
            this.col_no.Width = 134;
            // 
            // col_code
            // 
            this.col_code.Caption = "客户代码";
            this.col_code.FieldName = "Warehouse";
            this.col_code.Name = "col_code";
            this.col_code.Visible = true;
            this.col_code.VisibleIndex = 2;
            this.col_code.Width = 173;
            // 
            // col_name
            // 
            this.col_name.Caption = "客户名称";
            this.col_name.Name = "col_name";
            this.col_name.Visible = true;
            this.col_name.VisibleIndex = 3;
            this.col_name.Width = 139;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.panel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(507, 413);
            this.xtraScrollableControl1.TabIndex = 4;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_customer);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(507, 366);
            this.panelControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtn_close);
            this.panel1.Controls.Add(this.sbtn_sure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 366);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 47);
            this.panel1.TabIndex = 1;
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_close.Location = new System.Drawing.Point(435, 9);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(60, 26);
            this.sbtn_close.TabIndex = 11;
            this.sbtn_close.Text = "关闭";
            this.sbtn_close.Click += new System.EventHandler(this.sbtn_close_Click);
            // 
            // sbtn_sure
            // 
            this.sbtn_sure.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_sure.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_sure.Image")));
            this.sbtn_sure.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_sure.Location = new System.Drawing.Point(357, 9);
            this.sbtn_sure.Name = "sbtn_sure";
            this.sbtn_sure.Size = new System.Drawing.Size(60, 26);
            this.sbtn_sure.TabIndex = 10;
            this.sbtn_sure.Text = "确认";
            this.sbtn_sure.Click += new System.EventHandler(this.sbtn_sure_Click);
            // 
            // frmFGSuggestChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(507, 413);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGSuggestChoice";
            this.Text = "单号选择";
            this.Load += new System.EventHandler(this.frmFGSuggestChoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_customer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_customer;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_customer;
        private DevExpress.XtraGrid.Columns.GridColumn gc_check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_code;
        private DevExpress.XtraGrid.Columns.GridColumn col_name;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private DevExpress.XtraEditors.SimpleButton sbtn_sure;
        private DevExpress.XtraGrid.Columns.GridColumn col_no;
    }
}