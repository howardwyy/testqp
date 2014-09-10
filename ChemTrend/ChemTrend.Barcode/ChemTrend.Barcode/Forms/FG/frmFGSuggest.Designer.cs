namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGSuggest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGSuggest));
            this.col_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_bill = new DevExpress.XtraGrid.GridControl();
            this.gv_stock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_whnum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_wh = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bin = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_deliverynum = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            this.col_details_validity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_detials_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_stockname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_barcode = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_details_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_bill_detail = new DevExpress.XtraGrid.GridControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtn_save = new DevExpress.XtraEditors.SimpleButton();
            this.te_username = new DevExpress.XtraEditors.TextEdit();
            this.te_bill = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_query = new DevExpress.XtraEditors.SimpleButton();
            this.de_start = new DevExpress.XtraEditors.DateEdit();
            this.sbtn_print = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_wo = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_barcode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_bill.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_start.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_start.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // col_stock
            // 
            this.col_stock.Caption = "物料";
            this.col_stock.FieldName = "ID";
            this.col_stock.Name = "col_stock";
            this.col_stock.Visible = true;
            this.col_stock.VisibleIndex = 0;
            this.col_stock.Width = 114;
            // 
            // gc_bill
            // 
            this.gc_bill.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_bill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_bill.Location = new System.Drawing.Point(2, 2);
            this.gc_bill.MainView = this.gv_stock;
            this.gc_bill.Name = "gc_bill";
            this.gc_bill.Size = new System.Drawing.Size(247, 409);
            this.gc_bill.TabIndex = 0;
            this.gc_bill.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_stock});
            // 
            // gv_stock
            // 
            this.gv_stock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_stock,
            this.col_whnum,
            this.col_wh,
            this.col_bin,
            this.col_deliverynum});
            this.gv_stock.GridControl = this.gc_bill;
            this.gv_stock.Name = "gv_stock";
            this.gv_stock.OptionsBehavior.Editable = false;
            this.gv_stock.OptionsView.ColumnAutoWidth = false;
            this.gv_stock.OptionsView.ShowGroupPanel = false;
            // 
            // col_whnum
            // 
            this.col_whnum.Caption = "库存数量";
            this.col_whnum.FieldName = "Remark";
            this.col_whnum.Name = "col_whnum";
            this.col_whnum.Visible = true;
            this.col_whnum.VisibleIndex = 1;
            // 
            // col_wh
            // 
            this.col_wh.Caption = "仓库";
            this.col_wh.FieldName = "RequisitionId";
            this.col_wh.Name = "col_wh";
            this.col_wh.Visible = true;
            this.col_wh.VisibleIndex = 2;
            this.col_wh.Width = 127;
            // 
            // col_bin
            // 
            this.col_bin.Caption = "库位";
            this.col_bin.FieldName = "UserName";
            this.col_bin.Name = "col_bin";
            this.col_bin.Visible = true;
            this.col_bin.VisibleIndex = 3;
            this.col_bin.Width = 101;
            // 
            // col_deliverynum
            // 
            this.col_deliverynum.Caption = "发货数量";
            this.col_deliverynum.FieldName = "CreateTime";
            this.col_deliverynum.Name = "col_deliverynum";
            this.col_deliverynum.Visible = true;
            this.col_deliverynum.VisibleIndex = 4;
            this.col_deliverynum.Width = 108;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gc_bill);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(251, 413);
            this.panelControl3.TabIndex = 0;
            // 
            // col_details_validity
            // 
            this.col_details_validity.Caption = "有效期";
            this.col_details_validity.FieldName = "Remark";
            this.col_details_validity.Name = "col_details_validity";
            this.col_details_validity.Visible = true;
            this.col_details_validity.VisibleIndex = 3;
            // 
            // col_detials_batch
            // 
            this.col_detials_batch.Caption = "批次号";
            this.col_detials_batch.FieldName = "StockUnitQty";
            this.col_detials_batch.Name = "col_detials_batch";
            this.col_detials_batch.Visible = true;
            this.col_detials_batch.VisibleIndex = 2;
            // 
            // col_details_unit
            // 
            this.col_details_unit.Caption = "单位";
            this.col_details_unit.FieldName = "StockUnit";
            this.col_details_unit.Name = "col_details_unit";
            this.col_details_unit.Visible = true;
            this.col_details_unit.VisibleIndex = 1;
            // 
            // col_details_stockname
            // 
            this.col_details_stockname.Caption = "物料名称";
            this.col_details_stockname.FieldName = "StockName";
            this.col_details_stockname.Name = "col_details_stockname";
            this.col_details_stockname.Visible = true;
            this.col_details_stockname.VisibleIndex = 4;
            // 
            // col_details_barcode
            // 
            this.col_details_barcode.Caption = "条码";
            this.col_details_barcode.FieldName = "BarcodeID";
            this.col_details_barcode.Name = "col_details_barcode";
            this.col_details_barcode.Visible = true;
            this.col_details_barcode.VisibleIndex = 0;
            // 
            // gv_barcode
            // 
            this.gv_barcode.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_details_barcode,
            this.col_details_stockname,
            this.col_details_unit,
            this.col_details_num,
            this.col_detials_batch,
            this.col_details_validity});
            this.gv_barcode.GridControl = this.gc_bill_detail;
            this.gv_barcode.Name = "gv_barcode";
            this.gv_barcode.OptionsBehavior.Editable = false;
            this.gv_barcode.OptionsView.ShowGroupPanel = false;
            // 
            // col_details_num
            // 
            this.col_details_num.Caption = "数量";
            this.col_details_num.Name = "col_details_num";
            this.col_details_num.Visible = true;
            this.col_details_num.VisibleIndex = 5;
            // 
            // gc_bill_detail
            // 
            this.gc_bill_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_bill_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_bill_detail.Location = new System.Drawing.Point(2, 2);
            this.gc_bill_detail.MainView = this.gv_barcode;
            this.gc_bill_detail.Name = "gc_bill_detail";
            this.gc_bill_detail.Size = new System.Drawing.Size(584, 409);
            this.gc_bill_detail.TabIndex = 0;
            this.gc_bill_detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_barcode});
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gc_bill_detail);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(253, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(588, 413);
            this.panelControl4.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 104);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(843, 417);
            this.panelControl2.TabIndex = 1;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl2);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(843, 521);
            this.xtraScrollableControl1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(843, 104);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.sbtn_wo);
            this.groupBox1.Controls.Add(this.sbtn_save);
            this.groupBox1.Controls.Add(this.te_username);
            this.groupBox1.Controls.Add(this.te_bill);
            this.groupBox1.Controls.Add(this.sbtn_query);
            this.groupBox1.Controls.Add(this.de_start);
            this.groupBox1.Controls.Add(this.sbtn_print);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(819, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发货建议";
            // 
            // sbtn_save
            // 
            this.sbtn_save.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_save.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_save.Image")));
            this.sbtn_save.Location = new System.Drawing.Point(685, 52);
            this.sbtn_save.Name = "sbtn_save";
            this.sbtn_save.Size = new System.Drawing.Size(75, 23);
            this.sbtn_save.TabIndex = 26;
            this.sbtn_save.Text = "保存";
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
            this.sbtn_query.Location = new System.Drawing.Point(505, 52);
            this.sbtn_query.Name = "sbtn_query";
            this.sbtn_query.Size = new System.Drawing.Size(75, 23);
            this.sbtn_query.TabIndex = 23;
            this.sbtn_query.Text = "查询";
            this.sbtn_query.Click += new System.EventHandler(this.sbtn_query_Click);
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
            this.sbtn_print.Location = new System.Drawing.Point(594, 52);
            this.sbtn_print.Name = "sbtn_print";
            this.sbtn_print.Size = new System.Drawing.Size(75, 23);
            this.sbtn_print.TabIndex = 18;
            this.sbtn_print.Text = "打印";
            this.sbtn_print.Click += new System.EventHandler(this.sbtn_print_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(355, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "客户号：";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "单号：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "发货日期：";
            // 
            // sbtn_wo
            // 
            this.sbtn_wo.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_wo.Image")));
            this.sbtn_wo.Location = new System.Drawing.Point(201, 53);
            this.sbtn_wo.Name = "sbtn_wo";
            this.sbtn_wo.Size = new System.Drawing.Size(26, 23);
            this.sbtn_wo.TabIndex = 30;
            // 
            // simpleButton1
            // 
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(526, 20);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(26, 23);
            this.simpleButton1.TabIndex = 31;
            // 
            // frmFGSuggest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(843, 521);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGSuggest";
            this.Text = "发货建议单";
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_barcode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_username.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_bill.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_start.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_start.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Columns.GridColumn col_stock;
        private DevExpress.XtraGrid.GridControl gc_bill;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_stock;
        private DevExpress.XtraGrid.Columns.GridColumn col_whnum;
        private DevExpress.XtraGrid.Columns.GridColumn col_wh;
        private DevExpress.XtraGrid.Columns.GridColumn col_bin;
        private DevExpress.XtraGrid.Columns.GridColumn col_deliverynum;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_validity;
        private DevExpress.XtraGrid.Columns.GridColumn col_detials_batch;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_unit;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_stockname;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_barcode;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_barcode;
        private DevExpress.XtraGrid.GridControl gc_bill_detail;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit te_username;
        private DevExpress.XtraEditors.TextEdit te_bill;
        private DevExpress.XtraEditors.SimpleButton sbtn_query;
        private DevExpress.XtraEditors.DateEdit de_start;
        private DevExpress.XtraEditors.SimpleButton sbtn_print;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_num;
        private DevExpress.XtraEditors.SimpleButton sbtn_save;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton sbtn_wo;
    }
}