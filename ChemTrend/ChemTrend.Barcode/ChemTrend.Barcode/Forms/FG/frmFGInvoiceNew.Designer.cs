namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGInvoiceNew
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGInvoiceNew));
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.panelControl4 = new DevExpress.XtraEditors.PanelControl();
            this.gc_woline = new DevExpress.XtraGrid.GridControl();
            this.gv_woline = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_stockcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_stockname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_planqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_number = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_wo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.lue_company = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbox_wo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sbtn_wo = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.te_remark = new DevExpress.XtraEditors.TextEdit();
            this.cke_isurgent = new DevExpress.XtraEditors.CheckEdit();
            this.de_hopetime = new DevExpress.XtraEditors.DateEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_create_print = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtn_query = new DevExpress.XtraEditors.SimpleButton();
            this.col_customername = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_customercode = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).BeginInit();
            this.panelControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_woline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_woline)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_wo.Properties)).BeginInit();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_remark.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cke_isurgent.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hopetime.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hopetime.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.panelControl4);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 130);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(767, 397);
            this.panelControl2.TabIndex = 1;
            // 
            // panelControl4
            // 
            this.panelControl4.Controls.Add(this.gc_woline);
            this.panelControl4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl4.Location = new System.Drawing.Point(2, 2);
            this.panelControl4.Name = "panelControl4";
            this.panelControl4.Size = new System.Drawing.Size(763, 393);
            this.panelControl4.TabIndex = 1;
            // 
            // gc_woline
            // 
            this.gc_woline.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_woline.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_woline.Location = new System.Drawing.Point(2, 2);
            this.gc_woline.MainView = this.gv_woline;
            this.gc_woline.Name = "gc_woline";
            this.gc_woline.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1});
            this.gc_woline.Size = new System.Drawing.Size(759, 389);
            this.gc_woline.TabIndex = 0;
            this.gc_woline.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_woline});
            // 
            // gv_woline
            // 
            this.gv_woline.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_stockcode,
            this.col_stockname,
            this.col_unit,
            this.col_planqty,
            this.col_number,
            this.col_customercode,
            this.col_customername,
            this.col_wo,
            this.col_company});
            this.gv_woline.GridControl = this.gc_woline;
            this.gv_woline.Name = "gv_woline";
            this.gv_woline.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_woline.OptionsSelection.MultiSelect = true;
            this.gv_woline.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_woline.OptionsView.ShowGroupPanel = false;
            // 
            // col_stockcode
            // 
            this.col_stockcode.Caption = "物料号";
            this.col_stockcode.FieldName = "StockCode";
            this.col_stockcode.Name = "col_stockcode";
            this.col_stockcode.OptionsColumn.AllowEdit = false;
            this.col_stockcode.Visible = true;
            this.col_stockcode.VisibleIndex = 3;
            this.col_stockcode.Width = 83;
            // 
            // col_stockname
            // 
            this.col_stockname.Caption = "物料名称";
            this.col_stockname.FieldName = "StockName";
            this.col_stockname.Name = "col_stockname";
            this.col_stockname.OptionsColumn.AllowEdit = false;
            this.col_stockname.Visible = true;
            this.col_stockname.VisibleIndex = 4;
            this.col_stockname.Width = 88;
            // 
            // col_unit
            // 
            this.col_unit.Caption = "单位";
            this.col_unit.FieldName = "Unit";
            this.col_unit.Name = "col_unit";
            this.col_unit.OptionsColumn.AllowEdit = false;
            this.col_unit.Visible = true;
            this.col_unit.VisibleIndex = 5;
            this.col_unit.Width = 103;
            // 
            // col_planqty
            // 
            this.col_planqty.Caption = "数量";
            this.col_planqty.FieldName = "OrderQty";
            this.col_planqty.Name = "col_planqty";
            this.col_planqty.Visible = true;
            this.col_planqty.VisibleIndex = 6;
            this.col_planqty.Width = 76;
            // 
            // col_number
            // 
            this.col_number.Caption = "行号";
            this.col_number.FieldName = "LineNumber";
            this.col_number.Name = "col_number";
            this.col_number.OptionsColumn.AllowEdit = false;
            this.col_number.Visible = true;
            this.col_number.VisibleIndex = 2;
            this.col_number.Width = 86;
            // 
            // col_wo
            // 
            this.col_wo.Caption = "订单号";
            this.col_wo.FieldName = "OrderNumber";
            this.col_wo.Name = "col_wo";
            this.col_wo.OptionsColumn.AllowEdit = false;
            this.col_wo.Visible = true;
            this.col_wo.VisibleIndex = 1;
            this.col_wo.Width = 110;
            // 
            // col_company
            // 
            this.col_company.Caption = "公司";
            this.col_company.FieldName = "Company";
            this.col_company.Name = "col_company";
            this.col_company.OptionsColumn.AllowEdit = false;
            this.col_company.Visible = true;
            this.col_company.VisibleIndex = 9;
            this.col_company.Width = 118;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // lue_company
            // 
            this.lue_company.Location = new System.Drawing.Point(95, 22);
            this.lue_company.Name = "lue_company";
            this.lue_company.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_company.Size = new System.Drawing.Size(129, 20);
            this.lue_company.TabIndex = 32;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 25);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 31;
            this.labelControl1.Text = "公司代码：";
            // 
            // cbox_wo
            // 
            this.cbox_wo.Location = new System.Drawing.Point(95, 51);
            this.cbox_wo.Name = "cbox_wo";
            this.cbox_wo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_wo.Size = new System.Drawing.Size(129, 20);
            this.cbox_wo.TabIndex = 30;
            this.cbox_wo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbox_wo_KeyUp);
            // 
            // sbtn_wo
            // 
            this.sbtn_wo.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_wo.Image")));
            this.sbtn_wo.Location = new System.Drawing.Point(230, 51);
            this.sbtn_wo.Name = "sbtn_wo";
            this.sbtn_wo.Size = new System.Drawing.Size(26, 23);
            this.sbtn_wo.TabIndex = 29;
            this.sbtn_wo.Click += new System.EventHandler(this.sbtn_wo_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(60, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "发货单号：";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.panelControl2);
            this.xtraScrollableControl2.Controls.Add(this.panelControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(767, 527);
            this.xtraScrollableControl2.TabIndex = 6;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox2);
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(767, 130);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox2.Controls.Add(this.te_remark);
            this.groupBox2.Controls.Add(this.cke_isurgent);
            this.groupBox2.Controls.Add(this.de_hopetime);
            this.groupBox2.Controls.Add(this.labelControl3);
            this.groupBox2.Controls.Add(this.sbtn_create_print);
            this.groupBox2.Controls.Add(this.labelControl5);
            this.groupBox2.Location = new System.Drawing.Point(379, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(330, 111);
            this.groupBox2.TabIndex = 24;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "发货单信息";
            // 
            // te_remark
            // 
            this.te_remark.Location = new System.Drawing.Point(97, 54);
            this.te_remark.Name = "te_remark";
            this.te_remark.Size = new System.Drawing.Size(191, 20);
            this.te_remark.TabIndex = 24;
            // 
            // cke_isurgent
            // 
            this.cke_isurgent.Location = new System.Drawing.Point(204, 22);
            this.cke_isurgent.Name = "cke_isurgent";
            this.cke_isurgent.Properties.Caption = "紧急";
            this.cke_isurgent.Size = new System.Drawing.Size(75, 19);
            this.cke_isurgent.TabIndex = 23;
            // 
            // de_hopetime
            // 
            this.de_hopetime.EditValue = null;
            this.de_hopetime.Location = new System.Drawing.Point(97, 21);
            this.de_hopetime.Name = "de_hopetime";
            this.de_hopetime.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_hopetime.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.de_hopetime.Size = new System.Drawing.Size(100, 20);
            this.de_hopetime.TabIndex = 22;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(18, 54);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 19;
            this.labelControl3.Text = "备注：";
            // 
            // sbtn_create_print
            // 
            this.sbtn_create_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtn_create_print.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_create_print.Image")));
            this.sbtn_create_print.Location = new System.Drawing.Point(173, 84);
            this.sbtn_create_print.Name = "sbtn_create_print";
            this.sbtn_create_print.Size = new System.Drawing.Size(115, 23);
            this.sbtn_create_print.TabIndex = 18;
            this.sbtn_create_print.Text = "创建并打印";
            this.sbtn_create_print.Click += new System.EventHandler(this.sbtn_create_print_Click);
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(18, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 12;
            this.labelControl5.Text = "发货日期：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.lue_company);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.cbox_wo);
            this.groupBox1.Controls.Add(this.sbtn_wo);
            this.groupBox1.Controls.Add(this.sbtn_query);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Location = new System.Drawing.Point(14, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 111);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "物料信息";
            // 
            // sbtn_query
            // 
            this.sbtn_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.sbtn_query.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_query.Image")));
            this.sbtn_query.Location = new System.Drawing.Point(230, 84);
            this.sbtn_query.Name = "sbtn_query";
            this.sbtn_query.Size = new System.Drawing.Size(75, 23);
            this.sbtn_query.TabIndex = 23;
            this.sbtn_query.Text = "查询";
            this.sbtn_query.Click += new System.EventHandler(this.sbtn_query_Click);
            // 
            // col_customername
            // 
            this.col_customername.Caption = "客户名称";
            this.col_customername.FieldName = "CustomerName";
            this.col_customername.Name = "col_customername";
            this.col_customername.Visible = true;
            this.col_customername.VisibleIndex = 8;
            // 
            // col_customercode
            // 
            this.col_customercode.Caption = "客户编号";
            this.col_customercode.FieldName = "CustomerCode";
            this.col_customercode.Name = "col_customercode";
            this.col_customercode.Visible = true;
            this.col_customercode.VisibleIndex = 7;
            // 
            // frmFGInvoiceNew
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(767, 527);
            this.Controls.Add(this.xtraScrollableControl2);
            this.Name = "frmFGInvoiceNew";
            this.ShowIcon = false;
            this.Text = "新建发货清单";
            this.Load += new System.EventHandler(this.frmFGInvoiceNew_Load);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl4)).EndInit();
            this.panelControl4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_woline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_woline)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_wo.Properties)).EndInit();
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_remark.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cke_isurgent.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hopetime.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.de_hopetime.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl4;
        private DevExpress.XtraGrid.GridControl gc_woline;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_woline;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockcode;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockname;
        private DevExpress.XtraGrid.Columns.GridColumn col_unit;
        private DevExpress.XtraGrid.Columns.GridColumn col_planqty;
        private DevExpress.XtraGrid.Columns.GridColumn col_number;
        private DevExpress.XtraGrid.Columns.GridColumn col_wo;
        private DevExpress.XtraGrid.Columns.GridColumn col_company;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.LookUpEdit lue_company;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbox_wo;
        private DevExpress.XtraEditors.SimpleButton sbtn_wo;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox2;
        private DevExpress.XtraEditors.TextEdit te_remark;
        private DevExpress.XtraEditors.CheckEdit cke_isurgent;
        private DevExpress.XtraEditors.DateEdit de_hopetime;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbtn_create_print;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton sbtn_query;
        private DevExpress.XtraGrid.Columns.GridColumn col_customercode;
        private DevExpress.XtraGrid.Columns.GridColumn col_customername;
    }
}