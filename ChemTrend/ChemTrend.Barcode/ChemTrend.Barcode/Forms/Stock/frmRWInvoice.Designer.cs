namespace ChemTrend.Barcode.Forms.Stock
{
    partial class frmRWInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRWInvoice));
            this.gridView2 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_customername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_isUrgent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hopetime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_userid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_creattime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_invoice = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_invoice = new DevExpress.XtraGrid.GridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtn_invoice_create = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_query = new DevExpress.XtraEditors.SimpleButton();
            this.de_end = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.de_begin = new DevExpress.XtraEditors.DateEdit();
            this.sbtn_print = new DevExpress.XtraEditors.SimpleButton();
            this.tbox_barcode = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_invoice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begin.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begin.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // gridView2
            // 
            this.gridView2.Name = "gridView2";
            // 
            // col_customername
            // 
            this.col_customername.Caption = "客户名称";
            this.col_customername.FieldName = "CustomerName";
            this.col_customername.Name = "col_customername";
            this.col_customername.Visible = true;
            this.col_customername.VisibleIndex = 7;
            // 
            // col_status
            // 
            this.col_status.Caption = "状态";
            this.col_status.FieldName = "Status";
            this.col_status.Name = "col_status";
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 9;
            this.col_status.Width = 54;
            // 
            // col_remark
            // 
            this.col_remark.Caption = "备注";
            this.col_remark.FieldName = "Remark";
            this.col_remark.Name = "col_remark";
            this.col_remark.Visible = true;
            this.col_remark.VisibleIndex = 8;
            this.col_remark.Width = 54;
            // 
            // col_isUrgent
            // 
            this.col_isUrgent.Caption = "是否紧急";
            this.col_isUrgent.FieldName = "isUrgent";
            this.col_isUrgent.Name = "col_isUrgent";
            this.col_isUrgent.Visible = true;
            this.col_isUrgent.VisibleIndex = 6;
            this.col_isUrgent.Width = 54;
            // 
            // col_hopetime
            // 
            this.col_hopetime.Caption = "发货日期";
            this.col_hopetime.FieldName = "HopeTime";
            this.col_hopetime.Name = "col_hopetime";
            this.col_hopetime.Visible = true;
            this.col_hopetime.VisibleIndex = 5;
            this.col_hopetime.Width = 54;
            // 
            // col_userid
            // 
            this.col_userid.Caption = "操作人编号";
            this.col_userid.FieldName = "UserID";
            this.col_userid.Name = "col_userid";
            this.col_userid.Visible = true;
            this.col_userid.VisibleIndex = 4;
            this.col_userid.Width = 54;
            // 
            // col_username
            // 
            this.col_username.Caption = "操作人";
            this.col_username.FieldName = "UserName";
            this.col_username.Name = "col_username";
            this.col_username.Visible = true;
            this.col_username.VisibleIndex = 3;
            this.col_username.Width = 54;
            // 
            // col_creattime
            // 
            this.col_creattime.Caption = "创建日期";
            this.col_creattime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.col_creattime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.col_creattime.FieldName = "CreateTime";
            this.col_creattime.Name = "col_creattime";
            this.col_creattime.Visible = true;
            this.col_creattime.VisibleIndex = 2;
            this.col_creattime.Width = 54;
            // 
            // col_id
            // 
            this.col_id.Caption = "发货单";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            this.col_id.Visible = true;
            this.col_id.VisibleIndex = 1;
            this.col_id.Width = 54;
            // 
            // gv_invoice
            // 
            this.gv_invoice.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_creattime,
            this.col_username,
            this.col_userid,
            this.col_hopetime,
            this.col_isUrgent,
            this.col_remark,
            this.col_status,
            this.col_customername});
            this.gv_invoice.GridControl = this.gc_invoice;
            this.gv_invoice.Name = "gv_invoice";
            this.gv_invoice.OptionsBehavior.Editable = false;
            this.gv_invoice.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_invoice.OptionsSelection.MultiSelect = true;
            this.gv_invoice.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_invoice.OptionsView.ShowGroupPanel = false;
            this.gv_invoice.DoubleClick += new System.EventHandler(this.gv_invoice_DoubleClick);
            // 
            // gc_invoice
            // 
            this.gc_invoice.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_invoice.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_invoice.Location = new System.Drawing.Point(2, 2);
            this.gc_invoice.MainView = this.gv_invoice;
            this.gc_invoice.Name = "gc_invoice";
            this.gc_invoice.Size = new System.Drawing.Size(629, 358);
            this.gc_invoice.TabIndex = 1;
            this.gc_invoice.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_invoice});
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_invoice);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 100);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(633, 362);
            this.panelControl2.TabIndex = 1;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl2);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(633, 462);
            this.xtraScrollableControl1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(633, 100);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sbtn_invoice_create);
            this.groupBox1.Controls.Add(this.sbtn_query);
            this.groupBox1.Controls.Add(this.de_end);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.de_begin);
            this.groupBox1.Controls.Add(this.sbtn_print);
            this.groupBox1.Controls.Add(this.tbox_barcode);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(609, 89);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "发货单查询";
            // 
            // sbtn_invoice_create
            // 
            this.sbtn_invoice_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_invoice_create.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_invoice_create.Image")));
            this.sbtn_invoice_create.Location = new System.Drawing.Point(491, 55);
            this.sbtn_invoice_create.Name = "sbtn_invoice_create";
            this.sbtn_invoice_create.Size = new System.Drawing.Size(103, 23);
            this.sbtn_invoice_create.TabIndex = 24;
            this.sbtn_invoice_create.Text = "创建发货单";
            this.sbtn_invoice_create.Click += new System.EventHandler(this.sbtn_create_Click);
            // 
            // sbtn_query
            // 
            this.sbtn_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_query.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_query.Image")));
            this.sbtn_query.Location = new System.Drawing.Point(283, 55);
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
            // de_begin
            // 
            this.de_begin.EditValue = null;
            this.de_begin.Location = new System.Drawing.Point(95, 21);
            this.de_begin.Name = "de_begin";
            this.de_begin.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_begin.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_begin.Size = new System.Drawing.Size(100, 20);
            this.de_begin.TabIndex = 19;
            // 
            // sbtn_print
            // 
            this.sbtn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_print.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_print.Image")));
            this.sbtn_print.Location = new System.Drawing.Point(372, 55);
            this.sbtn_print.Name = "sbtn_print";
            this.sbtn_print.Size = new System.Drawing.Size(103, 23);
            this.sbtn_print.TabIndex = 18;
            this.sbtn_print.Text = "打印领料单";
            this.sbtn_print.Click += new System.EventHandler(this.sbtn_print_Click);
            // 
            // tbox_barcode
            // 
            this.tbox_barcode.Location = new System.Drawing.Point(95, 53);
            this.tbox_barcode.Name = "tbox_barcode";
            this.tbox_barcode.Size = new System.Drawing.Size(129, 22);
            this.tbox_barcode.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 56);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "发货单号：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "发货日期：";
            // 
            // gridView1
            // 
            this.gridView1.Name = "gridView1";
            // 
            // frmRWInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(633, 462);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmRWInvoice";
            this.ShowIcon = false;
            this.Text = "原材料发货单";
            this.Load += new System.EventHandler(this.frmRWInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.gridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_invoice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_end.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begin.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_begin.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraGrid.Views.Grid.GridView gridView2;
        private DevExpress.XtraGrid.Columns.GridColumn col_customername;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraGrid.Columns.GridColumn col_remark;
        private DevExpress.XtraGrid.Columns.GridColumn col_isUrgent;
        private DevExpress.XtraGrid.Columns.GridColumn col_hopetime;
        private DevExpress.XtraGrid.Columns.GridColumn col_userid;
        private DevExpress.XtraGrid.Columns.GridColumn col_username;
        private DevExpress.XtraGrid.Columns.GridColumn col_creattime;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_invoice;
        private DevExpress.XtraGrid.GridControl gc_invoice;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton sbtn_invoice_create;
        private DevExpress.XtraEditors.SimpleButton sbtn_query;
        private DevExpress.XtraEditors.DateEdit de_end;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit de_begin;
        private DevExpress.XtraEditors.SimpleButton sbtn_print;
        private System.Windows.Forms.TextBox tbox_barcode;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
    }
}