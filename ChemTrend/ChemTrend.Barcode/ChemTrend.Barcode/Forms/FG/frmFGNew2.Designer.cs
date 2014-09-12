namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGNew2
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGNew2));
            this.cbox_wo = new DevExpress.XtraEditors.ComboBoxEdit();
            this.sbtn_create = new DevExpress.XtraEditors.SimpleButton();
            this.lue_company = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtn_wo_add = new DevExpress.XtraEditors.SimpleButton();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.gv_wo = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_wo = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_stockcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_planqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_acqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_barcodeqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemTextEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.col_company = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_wo = new DevExpress.XtraGrid.GridControl();
            this.repositoryItemTextEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemTextEdit();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.col_productdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_bill = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_stockname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_stockspec = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_unitqty = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_lifedate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_pagecode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_unit = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cbox_wo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_company.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_wo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_wo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).BeginInit();
            this.xtraScrollableControl2.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // cbox_wo
            // 
            this.cbox_wo.Location = new System.Drawing.Point(349, 20);
            this.cbox_wo.Name = "cbox_wo";
            this.cbox_wo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbox_wo.Size = new System.Drawing.Size(129, 20);
            this.cbox_wo.TabIndex = 28;
            this.cbox_wo.KeyUp += new System.Windows.Forms.KeyEventHandler(this.cbox_wo_KeyUp);
            // 
            // sbtn_create
            // 
            this.sbtn_create.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sbtn_create.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_create.Image")));
            this.sbtn_create.Location = new System.Drawing.Point(690, 20);
            this.sbtn_create.Name = "sbtn_create";
            this.sbtn_create.Size = new System.Drawing.Size(75, 23);
            this.sbtn_create.TabIndex = 18;
            this.sbtn_create.Text = "生成条码";
            this.sbtn_create.Click += new System.EventHandler(this.sbtn_create_Click);
            // 
            // lue_company
            // 
            this.lue_company.Location = new System.Drawing.Point(95, 21);
            this.lue_company.Name = "lue_company";
            this.lue_company.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_company.Size = new System.Drawing.Size(129, 20);
            this.lue_company.TabIndex = 24;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(16, 24);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(60, 14);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "公司代码：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(270, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "工单号：";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.cbox_wo);
            this.groupBox1.Controls.Add(this.sbtn_create);
            this.groupBox1.Controls.Add(this.lue_company);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.sbtn_wo_add);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(782, 61);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条码信息";
            // 
            // sbtn_wo_add
            // 
            this.sbtn_wo_add.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_wo_add.Image")));
            this.sbtn_wo_add.Location = new System.Drawing.Point(484, 20);
            this.sbtn_wo_add.Name = "sbtn_wo_add";
            this.sbtn_wo_add.Size = new System.Drawing.Size(26, 23);
            this.sbtn_wo_add.TabIndex = 11;
            this.sbtn_wo_add.Click += new System.EventHandler(this.sbtn_workno_Click);
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            // 
            // gv_wo
            // 
            this.gv_wo.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_wo,
            this.col_stockname,
            this.col_stockspec,
            this.col_stockcode,
            this.col_unit,
            this.col_unitqty,
            this.col_planqty,
            this.col_acqty,
            this.col_barcodeqty,
            this.col_company,
            this.col_productdate,
            this.col_bill,
            this.col_lifedate,
            this.col_pagecode,
            this.col_remark});
            this.gv_wo.GridControl = this.gc_wo;
            this.gv_wo.Name = "gv_wo";
            this.gv_wo.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_wo.OptionsSelection.MultiSelect = true;
            this.gv_wo.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_wo.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gv_wo.OptionsView.ShowGroupPanel = false;
            // 
            // col_wo
            // 
            this.col_wo.Caption = "工单号";
            this.col_wo.FieldName = "WorkOrder";
            this.col_wo.Name = "col_wo";
            this.col_wo.Visible = true;
            this.col_wo.VisibleIndex = 3;
            // 
            // col_stockcode
            // 
            this.col_stockcode.Caption = "物料编号";
            this.col_stockcode.FieldName = "StockCode";
            this.col_stockcode.Name = "col_stockcode";
            this.col_stockcode.Visible = true;
            this.col_stockcode.VisibleIndex = 6;
            // 
            // col_planqty
            // 
            this.col_planqty.Caption = "计划数量";
            this.col_planqty.FieldName = "PlanQTY";
            this.col_planqty.Name = "col_planqty";
            this.col_planqty.Visible = true;
            this.col_planqty.VisibleIndex = 7;
            // 
            // col_acqty
            // 
            this.col_acqty.Caption = "实际数量";
            this.col_acqty.FieldName = "Acqty";
            this.col_acqty.Name = "col_acqty";
            this.col_acqty.Visible = true;
            this.col_acqty.VisibleIndex = 8;
            // 
            // col_barcodeqty
            // 
            this.col_barcodeqty.Caption = "打印数量";
            this.col_barcodeqty.ColumnEdit = this.repositoryItemTextEdit2;
            this.col_barcodeqty.FieldName = "BarcodeQty";
            this.col_barcodeqty.Name = "col_barcodeqty";
            this.col_barcodeqty.Visible = true;
            this.col_barcodeqty.VisibleIndex = 9;
            // 
            // repositoryItemTextEdit2
            // 
            this.repositoryItemTextEdit2.AutoHeight = false;
            this.repositoryItemTextEdit2.Name = "repositoryItemTextEdit2";
            // 
            // col_company
            // 
            this.col_company.Caption = "公司代码";
            this.col_company.FieldName = "Company";
            this.col_company.Name = "col_company";
            this.col_company.Visible = true;
            this.col_company.VisibleIndex = 10;
            // 
            // col_remark
            // 
            this.col_remark.Caption = "备注";
            this.col_remark.FieldName = "Remark";
            this.col_remark.Name = "col_remark";
            this.col_remark.Visible = true;
            this.col_remark.VisibleIndex = 15;
            // 
            // gc_wo
            // 
            this.gc_wo.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_wo.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_wo.Location = new System.Drawing.Point(12, 88);
            this.gc_wo.MainView = this.gv_wo;
            this.gc_wo.Name = "gc_wo";
            this.gc_wo.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit1,
            this.repositoryItemTextEdit1,
            this.repositoryItemTextEdit2});
            this.gc_wo.Size = new System.Drawing.Size(782, 461);
            this.gc_wo.TabIndex = 3;
            this.gc_wo.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_wo});
            // 
            // repositoryItemTextEdit1
            // 
            this.repositoryItemTextEdit1.AutoHeight = false;
            this.repositoryItemTextEdit1.Name = "repositoryItemTextEdit1";
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.gc_wo);
            this.xtraScrollableControl2.Controls.Add(this.groupBox1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(806, 561);
            this.xtraScrollableControl2.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.xtraScrollableControl2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(806, 561);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // col_productdate
            // 
            this.col_productdate.Caption = "产品日期";
            this.col_productdate.FieldName = "ProductDate";
            this.col_productdate.Name = "col_productdate";
            this.col_productdate.Visible = true;
            this.col_productdate.VisibleIndex = 11;
            // 
            // col_bill
            // 
            this.col_bill.Caption = "单据号";
            this.col_bill.FieldName = "Danju";
            this.col_bill.Name = "col_bill";
            this.col_bill.Visible = true;
            this.col_bill.VisibleIndex = 12;
            // 
            // col_stockname
            // 
            this.col_stockname.Caption = "物料名称";
            this.col_stockname.FieldName = "StockName";
            this.col_stockname.Name = "col_stockname";
            this.col_stockname.Visible = true;
            this.col_stockname.VisibleIndex = 1;
            // 
            // col_stockspec
            // 
            this.col_stockspec.Caption = "物料描述";
            this.col_stockspec.FieldName = "StockSpec";
            this.col_stockspec.Name = "col_stockspec";
            this.col_stockspec.Visible = true;
            this.col_stockspec.VisibleIndex = 2;
            // 
            // col_unitqty
            // 
            this.col_unitqty.Caption = "单位数量";
            this.col_unitqty.FieldName = "UnitQty";
            this.col_unitqty.Name = "col_unitqty";
            this.col_unitqty.Visible = true;
            this.col_unitqty.VisibleIndex = 5;
            // 
            // col_lifedate
            // 
            this.col_lifedate.Caption = "保质期";
            this.col_lifedate.FieldName = "LifeDate";
            this.col_lifedate.Name = "col_lifedate";
            this.col_lifedate.Visible = true;
            this.col_lifedate.VisibleIndex = 13;
            // 
            // col_pagecode
            // 
            this.col_pagecode.Caption = "PageCode";
            this.col_pagecode.FieldName = "PageCode";
            this.col_pagecode.Name = "col_pagecode";
            this.col_pagecode.Visible = true;
            this.col_pagecode.VisibleIndex = 14;
            // 
            // col_unit
            // 
            this.col_unit.Caption = "单位";
            this.col_unit.FieldName = "Unit";
            this.col_unit.Name = "col_unit";
            this.col_unit.Visible = true;
            this.col_unit.VisibleIndex = 4;
            // 
            // frmFGNew2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 561);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGNew2";
            this.Text = "创建成品条码";
            this.Load += new System.EventHandler(this.frmFGNew2_Load);
            ((System.ComponentModel.ISupportInitialize)(this.cbox_wo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lue_company.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_wo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_wo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemTextEdit1)).EndInit();
            this.xtraScrollableControl2.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ComboBoxEdit cbox_wo;
        private DevExpress.XtraEditors.SimpleButton sbtn_create;
        private DevExpress.XtraEditors.LookUpEdit lue_company;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton sbtn_wo_add;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_wo;
        private DevExpress.XtraGrid.GridControl gc_wo;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_wo;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockcode;
        private DevExpress.XtraGrid.Columns.GridColumn col_planqty;
        private DevExpress.XtraGrid.Columns.GridColumn col_acqty;
        private DevExpress.XtraGrid.Columns.GridColumn col_company;
        private DevExpress.XtraGrid.Columns.GridColumn col_remark;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_barcodeqty;
        private DevExpress.XtraEditors.Repository.RepositoryItemTextEdit repositoryItemTextEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn col_productdate;
        private DevExpress.XtraGrid.Columns.GridColumn col_bill;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockname;
        private DevExpress.XtraGrid.Columns.GridColumn col_stockspec;
        private DevExpress.XtraGrid.Columns.GridColumn col_unitqty;
        private DevExpress.XtraGrid.Columns.GridColumn col_unit;
        private DevExpress.XtraGrid.Columns.GridColumn col_lifedate;
        private DevExpress.XtraGrid.Columns.GridColumn col_pagecode;
    }
}