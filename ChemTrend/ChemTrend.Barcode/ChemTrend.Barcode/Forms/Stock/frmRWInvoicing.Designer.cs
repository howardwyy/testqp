namespace ChemTrend.Barcode.Forms.Stock
{
    partial class frmRWInvoicing
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
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRWInvoicing));
            this.gv_barcode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn7 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_count = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn10 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn11 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn12 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_barcode = new DevExpress.XtraGrid.GridControl();
            this.te_qty_cur = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.te_qty_surplus = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.te_unit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.te_qtyed = new DevExpress.XtraEditors.TextEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.te_qty = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.te_stockname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.te_stockcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.te_wo = new DevExpress.XtraEditors.TextEdit();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_create = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gv_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qty_cur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qty_surplus.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_unit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qtyed.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qty.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stockname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stockcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_wo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // gv_barcode
            // 
            this.gv_barcode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn5,
            this.gridColumn7,
            this.gridColumn6,
            this.col_count,
            this.gridColumn9,
            this.gridColumn10,
            this.gridColumn11,
            this.gridColumn12});
            this.gv_barcode.GridControl = this.gc_barcode;
            this.gv_barcode.Name = "gv_barcode";
            this.gv_barcode.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_barcode.OptionsSelection.MultiSelect = true;
            this.gv_barcode.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_barcode.OptionsView.ShowGroupPanel = false;
            this.gv_barcode.SelectionChanged += new DevExpress.Data.SelectionChangedEventHandler(this.gv_barcode_SelectionChanged);
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "条码";
            this.gridColumn5.FieldName = "ID";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            this.gridColumn5.Width = 100;
            // 
            // gridColumn7
            // 
            this.gridColumn7.Caption = "物料编号";
            this.gridColumn7.FieldName = "StockCode";
            this.gridColumn7.Name = "gridColumn7";
            this.gridColumn7.OptionsColumn.AllowEdit = false;
            this.gridColumn7.Visible = true;
            this.gridColumn7.VisibleIndex = 3;
            this.gridColumn7.Width = 79;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "物料名称";
            this.gridColumn6.FieldName = "StockName";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 2;
            this.gridColumn6.Width = 93;
            // 
            // col_count
            // 
            this.col_count.Caption = "数量";
            this.col_count.FieldName = "StockUnitQty";
            this.col_count.Name = "col_count";
            this.col_count.OptionsColumn.AllowEdit = false;
            this.col_count.Visible = true;
            this.col_count.VisibleIndex = 4;
            this.col_count.Width = 49;
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "单位";
            this.gridColumn9.FieldName = "Unit";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.OptionsColumn.AllowEdit = false;
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 5;
            this.gridColumn9.Width = 70;
            // 
            // gridColumn10
            // 
            this.gridColumn10.Caption = "批次";
            this.gridColumn10.FieldName = "StockBatch";
            this.gridColumn10.Name = "gridColumn10";
            this.gridColumn10.OptionsColumn.AllowEdit = false;
            this.gridColumn10.Visible = true;
            this.gridColumn10.VisibleIndex = 6;
            this.gridColumn10.Width = 42;
            // 
            // gridColumn11
            // 
            this.gridColumn11.Caption = "仓库";
            this.gridColumn11.FieldName = "Warehouse";
            this.gridColumn11.Name = "gridColumn11";
            this.gridColumn11.OptionsColumn.AllowEdit = false;
            this.gridColumn11.Visible = true;
            this.gridColumn11.VisibleIndex = 7;
            this.gridColumn11.Width = 42;
            // 
            // gridColumn12
            // 
            this.gridColumn12.Caption = "库位";
            this.gridColumn12.FieldName = "Location";
            this.gridColumn12.Name = "gridColumn12";
            this.gridColumn12.OptionsColumn.AllowEdit = false;
            this.gridColumn12.Visible = true;
            this.gridColumn12.VisibleIndex = 8;
            this.gridColumn12.Width = 41;
            // 
            // gc_barcode
            // 
            this.gc_barcode.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gc_barcode.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_barcode.Location = new System.Drawing.Point(2, 2);
            this.gc_barcode.MainView = this.gv_barcode;
            this.gc_barcode.Name = "gc_barcode";
            this.gc_barcode.Size = new System.Drawing.Size(624, 301);
            this.gc_barcode.TabIndex = 2;
            this.gc_barcode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_barcode});
            // 
            // te_qty_cur
            // 
            this.te_qty_cur.Location = new System.Drawing.Point(306, 106);
            this.te_qty_cur.Name = "te_qty_cur";
            this.te_qty_cur.Size = new System.Drawing.Size(100, 20);
            this.te_qty_cur.TabIndex = 40;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(228, 109);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(60, 14);
            this.labelControl8.TabIndex = 39;
            this.labelControl8.Text = "当前数量：";
            // 
            // te_qty_surplus
            // 
            this.te_qty_surplus.Location = new System.Drawing.Point(94, 106);
            this.te_qty_surplus.Name = "te_qty_surplus";
            this.te_qty_surplus.Size = new System.Drawing.Size(100, 20);
            this.te_qty_surplus.TabIndex = 38;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(16, 109);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(60, 14);
            this.labelControl7.TabIndex = 37;
            this.labelControl7.Text = "剩余数量：";
            // 
            // te_unit
            // 
            this.te_unit.Location = new System.Drawing.Point(94, 48);
            this.te_unit.Name = "te_unit";
            this.te_unit.Size = new System.Drawing.Size(100, 20);
            this.te_unit.TabIndex = 36;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(16, 51);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(60, 14);
            this.labelControl6.TabIndex = 35;
            this.labelControl6.Text = "发货单位：";
            // 
            // te_qtyed
            // 
            this.te_qtyed.Location = new System.Drawing.Point(306, 78);
            this.te_qtyed.Name = "te_qtyed";
            this.te_qtyed.Size = new System.Drawing.Size(100, 20);
            this.te_qtyed.TabIndex = 34;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(228, 81);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 33;
            this.labelControl5.Text = "已发数量：";
            // 
            // te_qty
            // 
            this.te_qty.Location = new System.Drawing.Point(94, 78);
            this.te_qty.Name = "te_qty";
            this.te_qty.Size = new System.Drawing.Size(100, 20);
            this.te_qty.TabIndex = 32;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 81);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 14);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "发货数量：";
            // 
            // te_stockname
            // 
            this.te_stockname.Location = new System.Drawing.Point(306, 48);
            this.te_stockname.Name = "te_stockname";
            this.te_stockname.Size = new System.Drawing.Size(278, 20);
            this.te_stockname.TabIndex = 30;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(228, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(60, 14);
            this.labelControl3.TabIndex = 29;
            this.labelControl3.Text = "物料名称：";
            // 
            // te_stockcode
            // 
            this.te_stockcode.Location = new System.Drawing.Point(306, 21);
            this.te_stockcode.Name = "te_stockcode";
            this.te_stockcode.Size = new System.Drawing.Size(278, 20);
            this.te_stockcode.TabIndex = 28;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(228, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 27;
            this.labelControl1.Text = "物料号：";
            // 
            // te_wo
            // 
            this.te_wo.Location = new System.Drawing.Point(94, 21);
            this.te_wo.Name = "te_wo";
            this.te_wo.Size = new System.Drawing.Size(100, 20);
            this.te_wo.TabIndex = 26;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_barcode);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 136);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(628, 305);
            this.panelControl2.TabIndex = 1;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl2);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(628, 441);
            this.xtraScrollableControl1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(628, 136);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.te_qty_cur);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.te_qty_surplus);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.te_unit);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.te_qtyed);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.te_qty);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.te_stockname);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.te_stockcode);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.te_wo);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.sbtn_create);
            this.groupBox1.Controls.Add(this.sbtn_close);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(624, 132);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "当前发货单信息";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 24);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "发货单号：";
            // 
            // sbtn_create
            // 
            this.sbtn_create.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sbtn_create.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_create.Image")));
            this.sbtn_create.Location = new System.Drawing.Point(446, 100);
            this.sbtn_create.Name = "sbtn_create";
            this.sbtn_create.Size = new System.Drawing.Size(75, 23);
            this.sbtn_create.TabIndex = 23;
            this.sbtn_create.Text = "确认发货";
            this.sbtn_create.Click += new System.EventHandler(this.sbtn_create_Click);
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.Location = new System.Drawing.Point(539, 100);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(75, 23);
            this.sbtn_close.TabIndex = 24;
            this.sbtn_close.Text = "取消";
            this.sbtn_close.Click += new System.EventHandler(this.sbtn_close_Click);
            // 
            // frmRWInvoicing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(628, 441);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmRWInvoicing";
            this.ShowIcon = false;
            this.Text = "原材料发货单";
            this.Load += new System.EventHandler(this.frmRWInvoicing_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gv_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qty_cur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qty_surplus.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_unit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qtyed.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_qty.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stockname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stockcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_wo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gv_barcode;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn7;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
        private DevExpress.XtraGrid.Columns.GridColumn col_count;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn10;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn11;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn12;
        private DevExpress.XtraGrid.GridControl gc_barcode;
        private DevExpress.XtraEditors.TextEdit te_qty_cur;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.TextEdit te_qty_surplus;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit te_unit;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit te_qtyed;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit te_qty;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit te_stockname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit te_stockcode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit te_wo;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbtn_create;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
    }
}