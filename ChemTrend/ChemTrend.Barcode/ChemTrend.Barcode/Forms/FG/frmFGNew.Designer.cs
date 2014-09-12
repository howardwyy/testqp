namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGNew));
            this.te_stock = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_create = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_hfg = new DevExpress.XtraEditors.CheckEdit();
            this.ck_fg = new DevExpress.XtraEditors.CheckEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.col_createtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_requisitionid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_name = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_stock = new DevExpress.XtraGrid.GridControl();
            this.gv_bill = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_stockcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_bill_detail = new DevExpress.XtraGrid.GridControl();
            this.gv_bill_detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_details_barcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_batch = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_stock = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_stockname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_detials_unitqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_details_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl3 = new DevExpress.XtraEditors.PanelControl();
            ((System.ComponentModel.ISupportInitialize)(this.te_stock.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_hfg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_fg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill_detail)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).BeginInit();
            this.panelControl3.SuspendLayout();
            this.SuspendLayout();
            // 
            // te_stock
            // 
            this.te_stock.Location = new System.Drawing.Point(95, 21);
            this.te_stock.Name = "te_stock";
            this.te_stock.Size = new System.Drawing.Size(100, 20);
            this.te_stock.TabIndex = 24;
            // 
            // sbtn_create
            // 
            this.sbtn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_create.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_create.Image")));
            this.sbtn_create.Location = new System.Drawing.Point(559, 50);
            this.sbtn_create.Name = "sbtn_create";
            this.sbtn_create.Size = new System.Drawing.Size(75, 23);
            this.sbtn_create.TabIndex = 18;
            this.sbtn_create.Text = "创建标签";
            this.sbtn_create.Click += new System.EventHandler(this.sbtn_create_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.ck_hfg);
            this.groupBox1.Controls.Add(this.ck_fg);
            this.groupBox1.Controls.Add(this.te_stock);
            this.groupBox1.Controls.Add(this.sbtn_create);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(668, 86);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条码信息";
            // 
            // ck_hfg
            // 
            this.ck_hfg.Location = new System.Drawing.Point(184, 54);
            this.ck_hfg.Name = "ck_hfg";
            this.ck_hfg.Properties.Caption = "半成品";
            this.ck_hfg.Size = new System.Drawing.Size(75, 19);
            this.ck_hfg.TabIndex = 26;
            // 
            // ck_fg
            // 
            this.ck_fg.Location = new System.Drawing.Point(95, 54);
            this.ck_fg.Name = "ck_fg";
            this.ck_fg.Properties.Caption = "成品";
            this.ck_fg.Size = new System.Drawing.Size(75, 19);
            this.ck_fg.TabIndex = 25;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "物料查询：";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(692, 104);
            this.panelControl1.TabIndex = 0;
            this.panelControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.panelControl1_Paint);
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
            // col_name
            // 
            this.col_name.Caption = "名称";
            this.col_name.FieldName = "Remark";
            this.col_name.Name = "col_name";
            this.col_name.Visible = true;
            this.col_name.VisibleIndex = 1;
            // 
            // gc_stock
            // 
            this.gc_stock.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_stock.Location = new System.Drawing.Point(2, 2);
            this.gc_stock.MainView = this.gv_bill;
            this.gc_stock.Name = "gc_stock";
            this.gc_stock.Size = new System.Drawing.Size(188, 360);
            this.gc_stock.TabIndex = 0;
            this.gc_stock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_bill});
            // 
            // gv_bill
            // 
            this.gv_bill.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_stockcode,
            this.col_name,
            this.col_requisitionid,
            this.col_username,
            this.col_createtime});
            this.gv_bill.GridControl = this.gc_stock;
            this.gv_bill.Name = "gv_bill";
            this.gv_bill.OptionsBehavior.Editable = false;
            this.gv_bill.OptionsView.ColumnAutoWidth = false;
            this.gv_bill.OptionsView.ShowGroupPanel = false;
            // 
            // col_stockcode
            // 
            this.col_stockcode.Caption = "物料";
            this.col_stockcode.FieldName = "ID";
            this.col_stockcode.Name = "col_stockcode";
            this.col_stockcode.Visible = true;
            this.col_stockcode.VisibleIndex = 0;
            this.col_stockcode.Width = 114;
            // 
            // gc_bill_detail
            // 
            this.gc_bill_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_bill_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_bill_detail.Location = new System.Drawing.Point(2, 2);
            this.gc_bill_detail.MainView = this.gv_bill_detail;
            this.gc_bill_detail.Name = "gc_bill_detail";
            this.gc_bill_detail.Size = new System.Drawing.Size(492, 360);
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
            this.col_details_barcode.Caption = "物料";
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
            this.col_details_remark.Caption = "打印数量";
            this.col_details_remark.FieldName = "Remark";
            this.col_details_remark.Name = "col_details_remark";
            this.col_details_remark.Visible = true;
            this.col_details_remark.VisibleIndex = 5;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl2);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(692, 472);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Controls.Add(this.panelControl3);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 104);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(692, 368);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gc_bill_detail);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(194, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(496, 364);
            this.panelControl4.TabIndex = 1;
            // 
            // panelControl3
            // 
            this.panelControl3.Controls.Add(this.gc_stock);
            this.panelControl3.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl3.Location = new System.Drawing.Point(2, 2);
            this.panelControl3.Name = "panelControl3";
            this.panelControl3.Size = new System.Drawing.Size(192, 364);
            this.panelControl3.TabIndex = 0;
            // 
            // frmFGNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 472);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGNew";
            this.Text = "创建成品条码";
            this.Load += new System.EventHandler(this.frmFGNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.te_stock.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_hfg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_fg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill_detail)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl3)).EndInit();
            this.panelControl3.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.TextEdit te_stock;
        private DevExpress.XtraEditors.SimpleButton sbtn_create;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_createtime;
        private DevExpress.XtraGrid.Columns.GridColumn col_username;
        private DevExpress.XtraGrid.Columns.GridColumn col_requisitionid;
        private DevExpress.XtraGrid.Columns.GridColumn col_name;
        private DevExpress.XtraGrid.GridControl gc_stock;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_bill;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockcode;
        private DevExpress.XtraGrid.GridControl gc_bill_detail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_bill_detail;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_barcode;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_batch;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_stock;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_stockname;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_unit;
        private DevExpress.XtraGrid.Columns.GridColumn col_detials_unitqty;
        private DevExpress.XtraGrid.Columns.GridColumn col_details_remark;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraEditors.PanelControl panelControl3;
        private DevExpress.XtraEditors.CheckEdit ck_fg;
        private DevExpress.XtraEditors.CheckEdit ck_hfg;

    }
}