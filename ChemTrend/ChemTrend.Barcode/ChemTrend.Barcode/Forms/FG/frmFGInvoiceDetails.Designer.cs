namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGInvoiceDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGInvoiceDetails));
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtn_invoice = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemButtonEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_select = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_invoicedsurpluscount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_receivedcount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_receiveunit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_receivecount = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_stockname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_userid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_receiveid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_createtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_invoice_detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_stockcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_invoice_detail = new DevExpress.XtraGrid.GridControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_invoice_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_invoice_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.Location = new System.Drawing.Point(763, 16);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(75, 23);
            this.sbtn_close.TabIndex = 9;
            this.sbtn_close.Text = "关闭";
            this.sbtn_close.Click += new System.EventHandler(this.sbtn_close_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtn_invoice);
            this.panel1.Controls.Add(this.sbtn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 341);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(850, 51);
            this.panel1.TabIndex = 0;
            // 
            // sbtn_invoice
            // 
            this.sbtn_invoice.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_invoice.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_invoice.Image")));
            this.sbtn_invoice.Location = new System.Drawing.Point(639, 16);
            this.sbtn_invoice.Name = "sbtn_invoice";
            this.sbtn_invoice.Size = new System.Drawing.Size(97, 23);
            this.sbtn_invoice.TabIndex = 10;
            this.sbtn_invoice.Text = "点击发货";
            this.sbtn_invoice.Click += new System.EventHandler(this.sbtn_invoice_Click);
            // 
            // repositoryItemButtonEdit1
            // 
            this.repositoryItemButtonEdit1.AutoHeight = false;
            this.repositoryItemButtonEdit1.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.repositoryItemButtonEdit1.Name = "repositoryItemButtonEdit1";
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // col_select
            // 
            this.col_select.Caption = "   选中";
            this.col_select.ColumnEdit = this.repositoryItemCheckEdit1;
            this.col_select.MaxWidth = 55;
            this.col_select.MinWidth = 55;
            this.col_select.Name = "col_select";
            this.col_select.Visible = true;
            this.col_select.VisibleIndex = 0;
            this.col_select.Width = 55;
            // 
            // col_invoicedsurpluscount
            // 
            this.col_invoicedsurpluscount.Caption = "剩余数量";
            this.col_invoicedsurpluscount.FieldName = "InvoiceSurplusCount";
            this.col_invoicedsurpluscount.Name = "col_invoicedsurpluscount";
            this.col_invoicedsurpluscount.OptionsColumn.AllowEdit = false;
            this.col_invoicedsurpluscount.Visible = true;
            this.col_invoicedsurpluscount.VisibleIndex = 11;
            this.col_invoicedsurpluscount.Width = 56;
            // 
            // col_receivedcount
            // 
            this.col_receivedcount.Caption = "已发数量";
            this.col_receivedcount.FieldName = "InvoicedCount";
            this.col_receivedcount.Name = "col_receivedcount";
            this.col_receivedcount.OptionsColumn.AllowEdit = false;
            this.col_receivedcount.Visible = true;
            this.col_receivedcount.VisibleIndex = 10;
            this.col_receivedcount.Width = 57;
            // 
            // col_receiveunit
            // 
            this.col_receiveunit.Caption = "发货单位";
            this.col_receiveunit.FieldName = "Unit";
            this.col_receiveunit.Name = "col_receiveunit";
            this.col_receiveunit.OptionsColumn.AllowEdit = false;
            this.col_receiveunit.Visible = true;
            this.col_receiveunit.VisibleIndex = 9;
            this.col_receiveunit.Width = 57;
            // 
            // col_receivecount
            // 
            this.col_receivecount.Caption = "发货数量";
            this.col_receivecount.FieldName = "InvoiceCount";
            this.col_receivecount.Name = "col_receivecount";
            this.col_receivecount.OptionsColumn.AllowEdit = false;
            this.col_receivecount.Visible = true;
            this.col_receivecount.VisibleIndex = 8;
            this.col_receivecount.Width = 57;
            // 
            // col_stockname
            // 
            this.col_stockname.Caption = "物料描述";
            this.col_stockname.FieldName = "StockName";
            this.col_stockname.Name = "col_stockname";
            this.col_stockname.OptionsColumn.AllowEdit = false;
            this.col_stockname.Visible = true;
            this.col_stockname.VisibleIndex = 7;
            this.col_stockname.Width = 57;
            // 
            // col_username
            // 
            this.col_username.Caption = "操作人";
            this.col_username.FieldName = "UserName";
            this.col_username.Name = "col_username";
            this.col_username.OptionsColumn.AllowEdit = false;
            this.col_username.Visible = true;
            this.col_username.VisibleIndex = 4;
            this.col_username.Width = 57;
            // 
            // col_userid
            // 
            this.col_userid.Caption = "操作人ID";
            this.col_userid.FieldName = "UserID";
            this.col_userid.Name = "col_userid";
            this.col_userid.OptionsColumn.AllowEdit = false;
            this.col_userid.Visible = true;
            this.col_userid.VisibleIndex = 5;
            this.col_userid.Width = 57;
            // 
            // col_receiveid
            // 
            this.col_receiveid.Caption = "发货单号";
            this.col_receiveid.FieldName = "InvoiceID";
            this.col_receiveid.Name = "col_receiveid";
            this.col_receiveid.OptionsColumn.AllowEdit = false;
            this.col_receiveid.Visible = true;
            this.col_receiveid.VisibleIndex = 3;
            this.col_receiveid.Width = 57;
            // 
            // col_createtime
            // 
            this.col_createtime.Caption = "操作时间";
            this.col_createtime.FieldName = "CreateTime";
            this.col_createtime.Name = "col_createtime";
            this.col_createtime.OptionsColumn.AllowEdit = false;
            this.col_createtime.Visible = true;
            this.col_createtime.VisibleIndex = 2;
            this.col_createtime.Width = 57;
            // 
            // col_id
            // 
            this.col_id.Caption = "序号";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            this.col_id.Visible = true;
            this.col_id.VisibleIndex = 1;
            this.col_id.Width = 57;
            // 
            // gv_invoice_detail
            // 
            this.gv_invoice_detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_createtime,
            this.col_receiveid,
            this.col_userid,
            this.col_username,
            this.col_stockcode,
            this.col_stockname,
            this.col_receivecount,
            this.col_receiveunit,
            this.col_receivedcount,
            this.col_invoicedsurpluscount,
            this.col_select});
            this.gv_invoice_detail.GridControl = this.gc_invoice_detail;
            this.gv_invoice_detail.Name = "gv_invoice_detail";
            this.gv_invoice_detail.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_invoice_detail.OptionsView.ShowGroupPanel = false;
            // 
            // col_stockcode
            // 
            this.col_stockcode.Caption = "物料号";
            this.col_stockcode.FieldName = "StockID";
            this.col_stockcode.Name = "col_stockcode";
            this.col_stockcode.OptionsColumn.AllowEdit = false;
            this.col_stockcode.Visible = true;
            this.col_stockcode.VisibleIndex = 6;
            this.col_stockcode.Width = 57;
            // 
            // gc_invoice_detail
            // 
            this.gc_invoice_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_invoice_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_invoice_detail.Location = new System.Drawing.Point(2, 2);
            this.gc_invoice_detail.MainView = this.gv_invoice_detail;
            this.gc_invoice_detail.Name = "gc_invoice_detail";
            this.gc_invoice_detail.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemButtonEdit1,
            this.repositoryItemCheckEdit1});
            this.gc_invoice_detail.Size = new System.Drawing.Size(846, 337);
            this.gc_invoice_detail.TabIndex = 2;
            this.gc_invoice_detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_invoice_detail});
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_invoice_detail);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(850, 341);
            this.panelControl1.TabIndex = 1;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.panel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(850, 392);
            this.xtraScrollableControl1.TabIndex = 2;
            // 
            // frmFGInvoiceDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(850, 392);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGInvoiceDetails";
            this.Text = "发货单明细";
            this.Load += new System.EventHandler(this.frmInvoiceDetails_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemButtonEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_invoice_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_invoice_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbtn_invoice;
        private DevExpress.XtraEditors.Repository.RepositoryItemButtonEdit repositoryItemButtonEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_select;
        private DevExpress.XtraGrid.Columns.GridColumn col_invoicedsurpluscount;
        private DevExpress.XtraGrid.Columns.GridColumn col_receivedcount;
        private DevExpress.XtraGrid.Columns.GridColumn col_receiveunit;
        private DevExpress.XtraGrid.Columns.GridColumn col_receivecount;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockname;
        private DevExpress.XtraGrid.Columns.GridColumn col_username;
        private DevExpress.XtraGrid.Columns.GridColumn col_userid;
        private DevExpress.XtraGrid.Columns.GridColumn col_receiveid;
        private DevExpress.XtraGrid.Columns.GridColumn col_createtime;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_invoice_detail;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockcode;
        private DevExpress.XtraGrid.GridControl gc_invoice_detail;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}