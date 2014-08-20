namespace ChemTrend.Barcode.Forms.Stock
{
    partial class frmWarehouseBarcode
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouseBarcode));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_warehouse = new DevExpress.XtraGrid.GridControl();
            this.gv_warehouse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_check = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_sure = new DevExpress.XtraEditors.SimpleButton();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.panel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(484, 442);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_warehouse);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(484, 395);
            this.panelControl1.TabIndex = 2;
            // 
            // gc_warehouse
            // 
            this.gc_warehouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_warehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_warehouse.Location = new System.Drawing.Point(2, 2);
            this.gc_warehouse.MainView = this.gv_warehouse;
            this.gc_warehouse.Name = "gc_warehouse";
            this.gc_warehouse.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gc_warehouse.Size = new System.Drawing.Size(480, 391);
            this.gc_warehouse.TabIndex = 1;
            this.gc_warehouse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_warehouse});
            // 
            // gv_warehouse
            // 
            this.gv_warehouse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gc_check,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gv_warehouse.GridControl = this.gc_warehouse;
            this.gv_warehouse.Name = "gv_warehouse";
            this.gv_warehouse.OptionsView.ShowGroupPanel = false;
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
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库号";
            this.gridColumn1.FieldName = "Warehouse";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 96;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "库位号";
            this.gridColumn2.FieldName = "Location";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            this.gridColumn2.Width = 96;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "公司";
            this.gridColumn3.FieldName = "Company";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 100;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "库位名称";
            this.gridColumn4.FieldName = "LocationName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            this.gridColumn4.Width = 96;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtn_close);
            this.panel1.Controls.Add(this.sbtn_sure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 395);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(484, 47);
            this.panel1.TabIndex = 1;
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_close.Location = new System.Drawing.Point(412, 9);
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
            this.sbtn_sure.Location = new System.Drawing.Point(334, 9);
            this.sbtn_sure.Name = "sbtn_sure";
            this.sbtn_sure.Size = new System.Drawing.Size(60, 26);
            this.sbtn_sure.TabIndex = 10;
            this.sbtn_sure.Text = "确认";
            this.sbtn_sure.Click += new System.EventHandler(this.sbtn_sure_Click);
            // 
            // frmWarehouseBarcode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 442);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmWarehouseBarcode";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "仓库/库位";
            this.Load += new System.EventHandler(this.frmWarehouseBarcode_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private DevExpress.XtraEditors.SimpleButton sbtn_sure;
        private DevExpress.XtraGrid.GridControl gc_warehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_warehouse;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gc_check;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
    }
}