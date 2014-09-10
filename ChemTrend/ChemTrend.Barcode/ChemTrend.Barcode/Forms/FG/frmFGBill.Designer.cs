namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGBill
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGBill));
            this.cbox_remark = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.te_username = new DevExpress.XtraEditors.TextEdit();
            this.te_bill = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_query = new DevExpress.XtraEditors.SimpleButton();
            this.de_end = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.de_start = new DevExpress.XtraEditors.DateEdit();
            this.sbtn_print = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.col_createtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_requisitionid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gc_bill_detail = new DevExpress.XtraGrid.GridControl();
            this.gv_bill_detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_details_barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_stockname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_detials_unitqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.gc_bill = new DevExpress.XtraGrid.GridControl();
            this.gv_bill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_billid = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_bill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_start.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill)).BeginInit();
            this.SuspendLayout();
            // 
            // cbox_remark
            // 
            this.cbox_remark.Location = new System.Drawing.Point(420, 54);
            this.cbox_remark.Name = "cbox_remark";
            this.cbox_remark.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_remark.Properties.Items.AddRange(new object[] {
            "创建条码",
            "条码移库",
            "条码出库 ",
            "条码入库"});
            this.cbox_remark.Size = new System.Drawing.Size(100, 20);
            this.cbox_remark.TabIndex = 27;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(355, 57);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 26;
            this.labelControl5.Text = "操作说明：";
            // 
            // te_username
            // 
            this.te_username.Location = new System.Drawing.Point(420, 21);
            this.te_username.Name = "te_username";
            this.te_username.Size = new System.Drawing.Size(100, 20);
            this.te_username.TabIndex = 25;
            // 
            // te_bill
            // 
            this.te_bill.Location = new System.Drawing.Point(95, 54);
            this.te_bill.Name = "te_bill";
            this.te_bill.Size = new System.Drawing.Size(100, 20);
            this.te_bill.TabIndex = 24;
            // 
            // sbtn_query
            // 
            this.sbtn_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_query.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_query.Image")));
            this.sbtn_query.Location = new System.Drawing.Point(550, 50);
            this.sbtn_query.Name = "sbtn_query";
            this.sbtn_query.Size = new System.Drawing.Size(75, 23);
            this.sbtn_query.TabIndex = 23;
            this.sbtn_query.Text = "查询";
            this.sbtn_query.Click += new System.EventHandler(this.sbtn_query_Click);
            // 
            // de_end
            // 
            this.de_end.EditValue = null;
            this.de_end.Location = new System.Drawing.Point(211, 21);
            this.de_end.Name = "de_end";
            this.de_end.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_end.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_end.Size = new System.Drawing.Size(100, 20);
            this.de_end.TabIndex = 21;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(201, 24);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(4, 14);
            this.labelControl4.TabIndex = 20;
            this.labelControl4.Text = "-";
            // 
            // de_start
            // 
            this.de_start.EditValue = null;
            this.de_start.Location = new System.Drawing.Point(95, 21);
            this.de_start.Name = "de_start";
            this.de_start.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_start.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_start.Size = new System.Drawing.Size(100, 20);
            this.de_start.TabIndex = 19;
            // 
            // sbtn_print
            // 
            this.sbtn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_print.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_print.Image")));
            this.sbtn_print.Location = new System.Drawing.Point(639, 50);
            this.sbtn_print.Name = "sbtn_print";
            this.sbtn_print.Size = new System.Drawing.Size(75, 23);
            this.sbtn_print.TabIndex = 18;
            this.sbtn_print.Text = "打印统计";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(355, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "操作人：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "单据日期：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbox_remark);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.te_username);
            this.groupBox1.Controls.Add(this.te_bill);
            this.groupBox1.Controls.Add(this.sbtn_query);
            this.groupBox1.Controls.Add(this.de_end);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.de_start);
            this.groupBox1.Controls.Add(this.sbtn_print);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(748, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条码信息";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(48, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "单据号：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(772, 104);
            this.panelControl1.TabIndex = 0;
            // 
            // col_createtime
            // 
            this.col_createtime.Caption = "操作时间";
            this.col_createtime.FieldName = "CreateTime";
            this.col_createtime.Name = "col_createtime";
            this.col_createtime.Visible = true;
            this.col_createtime.VisibleIndex = 4;
            this.col_createtime.Width = 108;
            // 
            // col_username
            // 
            this.col_username.Caption = "操作人";
            this.col_username.FieldName = "UserName";
            this.col_username.Name = "col_username";
            this.col_username.Visible = true;
            this.col_username.VisibleIndex = 3;
            this.col_username.Width = 101;
            // 
            // col_requisitionid
            // 
            this.col_requisitionid.Caption = "领料单";
            this.col_requisitionid.FieldName = "RequisitionId";
            this.col_requisitionid.Name = "col_requisitionid";
            this.col_requisitionid.Visible = true;
            this.col_requisitionid.VisibleIndex = 2;
            this.col_requisitionid.Width = 127;
            // 
            // col_remark
            // 
            this.col_remark.Caption = "操作状态";
            this.col_remark.FieldName = "Remark";
            this.col_remark.Name = "col_remark";
            this.col_remark.Visible = true;
            this.col_remark.VisibleIndex = 1;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl2);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(772, 526);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 104);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(772, 422);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gc_bill_detail);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(253, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(517, 418);
            this.panelControl4.TabIndex = 1;
            // 
            // gc_bill_detail
            // 
            this.gc_bill_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_bill_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_bill_detail.Location = new System.Drawing.Point(2, 2);
            this.gc_bill_detail.MainView = this.gv_bill_detail;
            this.gc_bill_detail.Name = "gc_bill_detail";
            this.gc_bill_detail.Size = new System.Drawing.Size(513, 414);
            this.gc_bill_detail.TabIndex = 0;
            this.gc_bill_detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_bill_detail});
            // 
            // gv_bill_detail
            // 
            this.gv_bill_detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_details_barcode,
            this.col_details_batch,
            this.col_details_stock,
            this.col_details_stockname,
            this.col_details_unit,
            this.col_detials_unitqty,
            this.col_details_remark});
            this.gv_bill_detail.GridControl = this.gc_bill_detail;
            this.gv_bill_detail.Name = "gv_bill_detail";
            this.gv_bill_detail.OptionsBehavior.Editable = false;
            this.gv_bill_detail.OptionsView.ShowGroupPanel = false;
            // 
            // col_details_barcode
            // 
            this.col_details_barcode.Caption = "条码号";
            this.col_details_barcode.FieldName = "BarcodeID";
            this.col_details_barcode.Name = "col_details_barcode";
            this.col_details_barcode.Visible = true;
            this.col_details_barcode.VisibleIndex = 0;
            // 
            // col_details_batch
            // 
            this.col_details_batch.Caption = "批次号";
            this.col_details_batch.FieldName = "StockBatch";
            this.col_details_batch.Name = "col_details_batch";
            this.col_details_batch.Visible = true;
            this.col_details_batch.VisibleIndex = 1;
            // 
            // col_details_stock
            // 
            this.col_details_stock.Caption = "物料号";
            this.col_details_stock.FieldName = "StockCode";
            this.col_details_stock.Name = "col_details_stock";
            this.col_details_stock.Visible = true;
            this.col_details_stock.VisibleIndex = 2;
            // 
            // col_details_stockname
            // 
            this.col_details_stockname.Caption = "物料名称";
            this.col_details_stockname.FieldName = "StockName";
            this.col_details_stockname.Name = "col_details_stockname";
            this.col_details_stockname.Visible = true;
            this.col_details_stockname.VisibleIndex = 6;
            // 
            // col_details_unit
            // 
            this.col_details_unit.Caption = "单位";
            this.col_details_unit.FieldName = "StockUnit";
            this.col_details_unit.Name = "col_details_unit";
            this.col_details_unit.Visible = true;
            this.col_details_unit.VisibleIndex = 3;
            // 
            // col_detials_unitqty
            // 
            this.col_detials_unitqty.Caption = "包装量";
            this.col_detials_unitqty.FieldName = "StockUnitQty";
            this.col_detials_unitqty.Name = "col_detials_unitqty";
            this.col_detials_unitqty.Visible = true;
            this.col_detials_unitqty.VisibleIndex = 4;
            // 
            // col_details_remark
            // 
            this.col_details_remark.Caption = "操作说明";
            this.col_details_remark.FieldName = "Remark";
            this.col_details_remark.Name = "col_details_remark";
            this.col_details_remark.Visible = true;
            this.col_details_remark.VisibleIndex = 5;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gc_bill);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(251, 418);
            this.panelControl3.TabIndex = 0;
            // 
            // gc_bill
            // 
            this.gc_bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_bill.Location = new System.Drawing.Point(2, 2);
            this.gc_bill.MainView = this.gv_bill;
            this.gc_bill.Name = "gc_bill";
            this.gc_bill.Size = new System.Drawing.Size(247, 414);
            this.gc_bill.TabIndex = 0;
            this.gc_bill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_bill});
            // 
            // gv_bill
            // 
            this.gv_bill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_billid,
            this.col_remark,
            this.col_requisitionid,
            this.col_username,
            this.col_createtime});
            this.gv_bill.GridControl = this.gc_bill;
            this.gv_bill.Name = "gv_bill";
            this.gv_bill.OptionsBehavior.Editable = false;
            this.gv_bill.OptionsView.ColumnAutoWidth = false;
            this.gv_bill.OptionsView.ShowGroupPanel = false;
            // 
            // col_billid
            // 
            this.col_billid.Caption = "单据号";
            this.col_billid.FieldName = "ID";
            this.col_billid.Name = "col_billid";
            this.col_billid.Visible = true;
            this.col_billid.VisibleIndex = 0;
            this.col_billid.Width = 114;
            // 
            // frmFGBill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(772, 526);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGBill";
            this.Text = "成品单据号管理";
            ((System.ComponentModel.ISupportInitialize)(this.cbox_remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_bill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_start.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbox_remark;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit te_username;
        private DevExpress.XtraEditors.TextEdit te_bill;
        private DevExpress.XtraEditors.SimpleButton sbtn_query;
        private DevExpress.XtraEditors.DateEdit de_end;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit de_start;
        private DevExpress.XtraEditors.SimpleButton sbtn_print;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_createtime;
        private DevExpress.XtraGrid.Columns.GridColumn col_username;
        private DevExpress.XtraGrid.Columns.GridColumn col_requisitionid;
        private DevExpress.XtraGrid.Columns.GridColumn col_remark;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gc_bill_detail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_bill_detail;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_barcode;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_batch;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_stock;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_stockname;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_unit;
        private DevExpress.XtraGrid.Columns.GridColumn col_detials_unitqty;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_remark;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.GridControl gc_bill;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_bill;
        private DevExpress.XtraGrid.Columns.GridColumn col_billid;
    }
}