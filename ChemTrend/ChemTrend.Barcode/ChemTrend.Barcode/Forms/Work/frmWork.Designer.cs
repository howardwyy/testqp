namespace ChemTrend.Barcode.Forms.Work
{
    partial class frmWork
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWork));
            DevExpress.XtraGrid.GridLevelNode gridLevelNode1 = new DevExpress.XtraGrid.GridLevelNode();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.ucPager = new ChemTrend.Barcode.Controls.ucPager();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.te_po = new DevExpress.XtraEditors.TextEdit();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.te_stockname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.te_stockcode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.cbox_status = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_print = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_query = new DevExpress.XtraEditors.SimpleButton();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_workno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_work = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_wh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_barcode = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl3 = new DevExpress.XtraEditors.XtraScrollableControl();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.ucPager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_po.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stockname.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_stockcode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_status.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_work)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            this.xtraScrollableControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(774, 557);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.ucPager);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl3.Location = new System.Drawing.Point(2, 404);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(766, 42);
            this.panelControl3.TabIndex = 0;
            // 
            // ucPager
            // 
            this.ucPager.Controls.Add(this.bindingNavigator);
            this.ucPager.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ucPager.Location = new System.Drawing.Point(2, 2);
            this.ucPager.Name = "ucPager";
            this.ucPager.NMax = 0;
            this.ucPager.PageCount = 0;
            this.ucPager.PageCurrent = 0;
            this.ucPager.PageSize = 20;
            this.ucPager.Size = new System.Drawing.Size(762, 38);
            this.ucPager.TabIndex = 0;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = null;
            this.bindingNavigator.MovePreviousItem = null;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator.Size = new System.Drawing.Size(762, 38);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // te_po
            // 
            this.te_po.Location = new System.Drawing.Point(329, 52);
            this.te_po.Name = "te_po";
            this.te_po.Size = new System.Drawing.Size(135, 20);
            this.te_po.TabIndex = 29;
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(264, 55);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(48, 14);
            this.labelControl11.TabIndex = 28;
            this.labelControl11.Text = "工单号：";
            // 
            // te_stockname
            // 
            this.te_stockname.Location = new System.Drawing.Point(329, 21);
            this.te_stockname.Name = "te_stockname";
            this.te_stockname.Size = new System.Drawing.Size(135, 20);
            this.te_stockname.TabIndex = 27;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(264, 24);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(60, 14);
            this.labelControl10.TabIndex = 26;
            this.labelControl10.Text = "物料名称：";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.groupBox1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(2, 2);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(770, 105);
            this.panel2.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.te_po);
            this.groupBox1.Controls.Add(this.labelControl11);
            this.groupBox1.Controls.Add(this.te_stockname);
            this.groupBox1.Controls.Add(this.labelControl10);
            this.groupBox1.Controls.Add(this.te_stockcode);
            this.groupBox1.Controls.Add(this.labelControl9);
            this.groupBox1.Controls.Add(this.cbox_status);
            this.groupBox1.Controls.Add(this.labelControl8);
            this.groupBox1.Controls.Add(this.sbtn_close);
            this.groupBox1.Controls.Add(this.sbtn_print);
            this.groupBox1.Controls.Add(this.sbtn_query);
            this.groupBox1.Location = new System.Drawing.Point(4, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(763, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // te_stockcode
            // 
            this.te_stockcode.Location = new System.Drawing.Point(74, 21);
            this.te_stockcode.Name = "te_stockcode";
            this.te_stockcode.Size = new System.Drawing.Size(135, 20);
            this.te_stockcode.TabIndex = 25;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(9, 24);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(48, 14);
            this.labelControl9.TabIndex = 24;
            this.labelControl9.Text = "物料号：";
            // 
            // cbox_status
            // 
            this.cbox_status.Location = new System.Drawing.Point(73, 52);
            this.cbox_status.Name = "cbox_status";
            this.cbox_status.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_status.Size = new System.Drawing.Size(135, 20);
            this.cbox_status.TabIndex = 23;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(15, 55);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(36, 14);
            this.labelControl8.TabIndex = 22;
            this.labelControl8.Text = "状态：";
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.Location = new System.Drawing.Point(681, 53);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(75, 23);
            this.sbtn_close.TabIndex = 8;
            this.sbtn_close.Text = "关闭";
            // 
            // sbtn_print
            // 
            this.sbtn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_print.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_print.Image")));
            this.sbtn_print.Location = new System.Drawing.Point(589, 53);
            this.sbtn_print.Name = "sbtn_print";
            this.sbtn_print.Size = new System.Drawing.Size(75, 23);
            this.sbtn_print.TabIndex = 7;
            this.sbtn_print.Text = "打印";
            // 
            // sbtn_query
            // 
            this.sbtn_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_query.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_query.Image")));
            this.sbtn_query.Location = new System.Drawing.Point(497, 53);
            this.sbtn_query.Name = "sbtn_query";
            this.sbtn_query.Size = new System.Drawing.Size(75, 23);
            this.sbtn_query.TabIndex = 6;
            this.sbtn_query.Text = "查询";
            this.sbtn_query.Click += new System.EventHandler(this.sbtn_query_Click);
            // 
            // col_status
            // 
            this.col_status.Caption = "状态";
            this.col_status.FieldName = "Status";
            this.col_status.Name = "col_status";
            this.col_status.OptionsColumn.AllowEdit = false;
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 2;
            this.col_status.Width = 49;
            // 
            // col_workno
            // 
            this.col_workno.Caption = "工单号";
            this.col_workno.FieldName = "ID";
            this.col_workno.Name = "col_workno";
            this.col_workno.OptionsColumn.AllowEdit = false;
            this.col_workno.Visible = true;
            this.col_workno.VisibleIndex = 1;
            this.col_workno.Width = 100;
            // 
            // gv_work
            // 
            this.gv_work.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_workno,
            this.col_status,
            this.col_batch,
            this.col_wh,
            this.col_bin,
            this.col_remark});
            this.gv_work.GridControl = this.gc_barcode;
            this.gv_work.Name = "gv_work";
            this.gv_work.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_work.OptionsSelection.MultiSelect = true;
            this.gv_work.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_work.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gv_work.OptionsView.ShowGroupPanel = false;
            // 
            // col_batch
            // 
            this.col_batch.Caption = "批次";
            this.col_batch.FieldName = "StockBatch";
            this.col_batch.Name = "col_batch";
            this.col_batch.OptionsColumn.AllowEdit = false;
            this.col_batch.Visible = true;
            this.col_batch.VisibleIndex = 3;
            this.col_batch.Width = 42;
            // 
            // col_wh
            // 
            this.col_wh.Caption = "仓库";
            this.col_wh.FieldName = "Warehouse";
            this.col_wh.Name = "col_wh";
            this.col_wh.OptionsColumn.AllowEdit = false;
            this.col_wh.Visible = true;
            this.col_wh.VisibleIndex = 4;
            this.col_wh.Width = 42;
            // 
            // col_bin
            // 
            this.col_bin.Caption = "库位";
            this.col_bin.FieldName = "Location";
            this.col_bin.Name = "col_bin";
            this.col_bin.OptionsColumn.AllowEdit = false;
            this.col_bin.Visible = true;
            this.col_bin.VisibleIndex = 5;
            this.col_bin.Width = 41;
            // 
            // col_remark
            // 
            this.col_remark.Caption = "备注";
            this.col_remark.Name = "col_remark";
            this.col_remark.Visible = true;
            this.col_remark.VisibleIndex = 6;
            this.col_remark.Width = 96;
            // 
            // gc_barcode
            // 
            this.gc_barcode.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_barcode.Dock = System.Windows.Forms.DockStyle.Fill;
            gridLevelNode1.RelationName = "Level1";
            this.gc_barcode.LevelTree.Nodes.AddRange(new DevExpress.XtraGrid.GridLevelNode[] {
            gridLevelNode1});
            this.gc_barcode.Location = new System.Drawing.Point(2, 2);
            this.gc_barcode.MainView = this.gv_work;
            this.gc_barcode.Name = "gc_barcode";
            this.gc_barcode.Size = new System.Drawing.Size(766, 402);
            this.gc_barcode.TabIndex = 1;
            this.gc_barcode.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_work});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.panelControl2);
            this.panelControl1.Controls.Add(this.panel2);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(774, 557);
            this.panelControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_barcode);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(2, 107);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(770, 448);
            this.panelControl2.TabIndex = 1;
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.panelControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(774, 557);
            this.xtraScrollableControl2.TabIndex = 0;
            // 
            // xtraScrollableControl3
            // 
            this.xtraScrollableControl3.Controls.Add(this.xtraScrollableControl2);
            this.xtraScrollableControl3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl3.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl3.Name = "xtraScrollableControl3";
            this.xtraScrollableControl3.Size = new System.Drawing.Size(774, 557);
            this.xtraScrollableControl3.TabIndex = 1;
            // 
            // frmWork
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 557);
            this.Controls.Add(this.xtraScrollableControl3);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmWork";
            this.Text = "工单管理";
            this.Load += new System.EventHandler(this.frmWork_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ucPager.ResumeLayout(false);
            this.ucPager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_po.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stockname.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_stockcode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_status.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_work)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            this.xtraScrollableControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private Controls.ucPager ucPager;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private DevExpress.XtraEditors.TextEdit te_po;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.TextEdit te_stockname;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit te_stockcode;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_status;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private DevExpress.XtraEditors.SimpleButton sbtn_print;
        private DevExpress.XtraEditors.SimpleButton sbtn_query;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraGrid.Columns.GridColumn col_workno;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_work;
        private DevExpress.XtraGrid.Columns.GridColumn col_batch;
        private DevExpress.XtraGrid.Columns.GridColumn col_wh;
        private DevExpress.XtraGrid.Columns.GridColumn col_bin;
        private DevExpress.XtraGrid.Columns.GridColumn col_remark;
        private DevExpress.XtraGrid.GridControl gc_barcode;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl3;
    }
}