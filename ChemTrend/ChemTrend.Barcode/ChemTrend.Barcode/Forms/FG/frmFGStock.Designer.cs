namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGStock));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.gc_stock = new DevExpress.XtraGrid.GridControl();
            this.gv_stock = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_stockcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_stockname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.col_customer = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_yxq = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_dsc = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_decstr = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_dept = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ck_hfg = new DevExpress.XtraEditors.CheckEdit();
            this.ck_fg = new DevExpress.XtraEditors.CheckEdit();
            this.te_stock = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_create = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_query = new DevExpress.XtraEditors.SimpleButton();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stock)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_hfg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_fg.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stock.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.gc_stock);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(832, 491);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // gc_stock
            // 
            this.gc_stock.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_stock.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_stock.Location = new System.Drawing.Point(0, 116);
            this.gc_stock.MainView = this.gv_stock;
            this.gc_stock.Name = "gc_stock";
            this.gc_stock.Size = new System.Drawing.Size(832, 375);
            this.gc_stock.TabIndex = 1;
            this.gc_stock.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_stock});
            // 
            // gv_stock
            // 
            this.gv_stock.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_stockcode,
            this.col_stockname,
            this.col_num,
            this.col_unit,
            this.col_customer,
            this.col_yxq,
            this.col_dsc,
            this.col_decstr,
            this.col_type,
            this.col_dept});
            this.gv_stock.GridControl = this.gc_stock;
            this.gv_stock.Name = "gv_stock";
            this.gv_stock.OptionsBehavior.Editable = false;
            this.gv_stock.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_stock.OptionsSelection.MultiSelect = true;
            this.gv_stock.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_stock.OptionsView.ColumnAutoWidth = false;
            this.gv_stock.OptionsView.ShowGroupPanel = false;
            // 
            // col_stockcode
            // 
            this.col_stockcode.Caption = "物料";
            this.col_stockcode.FieldName = "ID";
            this.col_stockcode.Name = "col_stockcode";
            this.col_stockcode.Visible = true;
            this.col_stockcode.VisibleIndex = 1;
            this.col_stockcode.Width = 130;
            // 
            // col_stockname
            // 
            this.col_stockname.Caption = "物料名称";
            this.col_stockname.DisplayFormat.FormatString = "d";
            this.col_stockname.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_stockname.FieldName = "CreateTime";
            this.col_stockname.Name = "col_stockname";
            this.col_stockname.Visible = true;
            this.col_stockname.VisibleIndex = 10;
            this.col_stockname.Width = 69;
            // 
            // col_num
            // 
            this.col_num.Caption = "包装数量";
            this.col_num.FieldName = "Status";
            this.col_num.Name = "col_num";
            this.col_num.Visible = true;
            this.col_num.VisibleIndex = 2;
            this.col_num.Width = 51;
            // 
            // col_unit
            // 
            this.col_unit.Caption = "单位";
            this.col_unit.Name = "col_unit";
            this.col_unit.Visible = true;
            this.col_unit.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(832, 116);
            this.panelControl1.TabIndex = 0;
            // 
            // col_customer
            // 
            this.col_customer.Caption = "归属客户";
            this.col_customer.Name = "col_customer";
            this.col_customer.Visible = true;
            this.col_customer.VisibleIndex = 4;
            // 
            // col_yxq
            // 
            this.col_yxq.Caption = "YXQ";
            this.col_yxq.Name = "col_yxq";
            this.col_yxq.Visible = true;
            this.col_yxq.VisibleIndex = 5;
            // 
            // col_dsc
            // 
            this.col_dsc.Caption = "DSC";
            this.col_dsc.Name = "col_dsc";
            this.col_dsc.Visible = true;
            this.col_dsc.VisibleIndex = 6;
            // 
            // col_decstr
            // 
            this.col_decstr.Caption = "DSCSTR";
            this.col_decstr.Name = "col_decstr";
            this.col_decstr.Visible = true;
            this.col_decstr.VisibleIndex = 7;
            // 
            // col_type
            // 
            this.col_type.Caption = "类型";
            this.col_type.Name = "col_type";
            this.col_type.Visible = true;
            this.col_type.VisibleIndex = 8;
            // 
            // col_dept
            // 
            this.col_dept.Caption = "归属部门";
            this.col_dept.Name = "col_dept";
            this.col_dept.Visible = true;
            this.col_dept.VisibleIndex = 9;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sbtn_query);
            this.groupBox1.Controls.Add(this.simpleButton1);
            this.groupBox1.Controls.Add(this.ck_hfg);
            this.groupBox1.Controls.Add(this.ck_fg);
            this.groupBox1.Controls.Add(this.te_stock);
            this.groupBox1.Controls.Add(this.sbtn_create);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(808, 81);
            this.groupBox1.TabIndex = 4;
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
            this.sbtn_create.Location = new System.Drawing.Point(699, 45);
            this.sbtn_create.Name = "sbtn_create";
            this.sbtn_create.Size = new System.Drawing.Size(75, 23);
            this.sbtn_create.TabIndex = 18;
            this.sbtn_create.Text = "保存设置";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 23);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "物料查询：";
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.simpleButton1.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(603, 45);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(75, 23);
            this.simpleButton1.TabIndex = 27;
            this.simpleButton1.Text = "删除设置";
            // 
            // sbtn_query
            // 
            this.sbtn_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtn_query.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_query.Image")));
            this.sbtn_query.Location = new System.Drawing.Point(495, 45);
            this.sbtn_query.Name = "sbtn_query";
            this.sbtn_query.Size = new System.Drawing.Size(75, 23);
            this.sbtn_query.TabIndex = 28;
            this.sbtn_query.Text = "查询";
            // 
            // frmFGStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(832, 491);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGStock";
            this.Text = "物料管理";
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_stock)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ck_hfg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ck_fg.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_stock.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_stock;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_stock;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockcode;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockname;
        private DevExpress.XtraGrid.Columns.GridColumn col_num;
        private DevExpress.XtraGrid.Columns.GridColumn col_unit;
        private DevExpress.XtraGrid.Columns.GridColumn col_customer;
        private DevExpress.XtraGrid.Columns.GridColumn col_yxq;
        private DevExpress.XtraGrid.Columns.GridColumn col_dsc;
        private DevExpress.XtraGrid.Columns.GridColumn col_decstr;
        private DevExpress.XtraGrid.Columns.GridColumn col_type;
        private DevExpress.XtraGrid.Columns.GridColumn col_dept;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.CheckEdit ck_hfg;
        private DevExpress.XtraEditors.CheckEdit ck_fg;
        private DevExpress.XtraEditors.TextEdit te_stock;
        private DevExpress.XtraEditors.SimpleButton sbtn_create;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbtn_query;
    }
}