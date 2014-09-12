namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGPackageChoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGPackageChoice));
            this.gc_packing = new DevExpress.XtraGrid.GridControl();
            this.gv_packing = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_packing_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_sure = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_packing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_packing)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gc_packing
            // 
            this.gc_packing.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_packing.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_packing.Location = new System.Drawing.Point(2, 2);
            this.gc_packing.MainView = this.gv_packing;
            this.gc_packing.Name = "gc_packing";
            this.gc_packing.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gc_packing.Size = new System.Drawing.Size(492, 380);
            this.gc_packing.TabIndex = 1;
            this.gc_packing.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_packing});
            // 
            // gv_packing
            // 
            this.gv_packing.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn3,
            this.gridColumn1,
            this.gridColumn2,
            this.gc_packing_status});
            this.gv_packing.GridControl = this.gc_packing;
            this.gv_packing.Name = "gv_packing";
            this.gv_packing.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_packing.OptionsView.ColumnAutoWidth = false;
            this.gv_packing.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "选择";
            this.gridColumn3.ColumnEdit = this.repositoryItemCheckEdit1;
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 0;
            this.gridColumn3.Width = 41;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "装箱条码";
            this.gridColumn1.FieldName = "ID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            this.gridColumn1.Width = 165;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "创建日期";
            this.gridColumn2.DisplayFormat.FormatString = "d";
            this.gridColumn2.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn2.FieldName = "CreateTime";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 131;
            // 
            // gc_packing_status
            // 
            this.gc_packing_status.Caption = "状态";
            this.gc_packing_status.FieldName = "Status";
            this.gc_packing_status.Name = "gc_packing_status";
            this.gc_packing_status.OptionsColumn.AllowEdit = false;
            this.gc_packing_status.Visible = true;
            this.gc_packing_status.VisibleIndex = 2;
            this.gc_packing_status.Width = 137;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.panel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(496, 431);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_packing);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(496, 384);
            this.panelControl1.TabIndex = 2;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtn_close);
            this.panel1.Controls.Add(this.sbtn_sure);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 384);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(496, 47);
            this.panel1.TabIndex = 1;
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_close.Location = new System.Drawing.Point(424, 9);
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
            this.sbtn_sure.Location = new System.Drawing.Point(346, 9);
            this.sbtn_sure.Name = "sbtn_sure";
            this.sbtn_sure.Size = new System.Drawing.Size(60, 26);
            this.sbtn_sure.TabIndex = 10;
            this.sbtn_sure.Text = "确认";
            this.sbtn_sure.Click += new System.EventHandler(this.sbtn_sure_Click);
            // 
            // frmFGPackageChoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(496, 431);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGPackageChoice";
            this.Text = "成品装箱条码选择";
            this.Load += new System.EventHandler(this.frmFGPackageChoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gc_packing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_packing)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gc_packing;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_packing;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gc_packing_status;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private DevExpress.XtraEditors.SimpleButton sbtn_sure;
    }
}