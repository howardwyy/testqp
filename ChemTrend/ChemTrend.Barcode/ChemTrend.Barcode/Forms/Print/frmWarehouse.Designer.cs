namespace ChemTrend.Barcode.Forms.Print
{
    partial class frmWarehouse
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWarehouse));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_warehouse = new DevExpress.XtraGrid.GridControl();
            this.gv_warehouse = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lue_company = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_print = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_query = new DevExpress.XtraEditors.SimpleButton();
            this.te_bincode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.te_binname = new DevExpress.XtraEditors.TextEdit();
            this.lbl_binname = new DevExpress.XtraEditors.LabelControl();
            this.te_warehousecode = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl1.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_warehouse)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_bincode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_binname.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_warehousecode.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.xtraScrollableControl2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(504, 442);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.panelControl2);
            this.xtraScrollableControl2.Controls.Add(this.panelControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(504, 442);
            this.xtraScrollableControl2.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_warehouse);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 117);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(504, 325);
            this.panelControl2.TabIndex = 1;
            // 
            // gc_warehouse
            // 
            this.gc_warehouse.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_warehouse.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_warehouse.Location = new System.Drawing.Point(2, 2);
            this.gc_warehouse.MainView = this.gv_warehouse;
            this.gc_warehouse.Name = "gc_warehouse";
            this.gc_warehouse.Size = new System.Drawing.Size(500, 321);
            this.gc_warehouse.TabIndex = 0;
            this.gc_warehouse.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_warehouse});
            // 
            // gv_warehouse
            // 
            this.gv_warehouse.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gv_warehouse.GridControl = this.gc_warehouse;
            this.gv_warehouse.Name = "gv_warehouse";
            this.gv_warehouse.OptionsBehavior.Editable = false;
            this.gv_warehouse.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_warehouse.OptionsSelection.MultiSelect = true;
            this.gv_warehouse.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_warehouse.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gv_warehouse.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gv_warehouse.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "仓库号";
            this.gridColumn1.FieldName = "Warehouse";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 1;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "仓库号";
            this.gridColumn2.FieldName = "Location";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 2;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "公司";
            this.gridColumn3.FieldName = "Company";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "库位名称";
            this.gridColumn4.FieldName = "LocationName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(504, 117);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.lue_company);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.sbtn_close);
            this.groupBox1.Controls.Add(this.sbtn_print);
            this.groupBox1.Controls.Add(this.sbtn_query);
            this.groupBox1.Controls.Add(this.te_bincode);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.te_binname);
            this.groupBox1.Controls.Add(this.lbl_binname);
            this.groupBox1.Controls.Add(this.te_warehousecode);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(480, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // lue_company
            // 
            this.lue_company.Location = new System.Drawing.Point(61, 17);
            this.lue_company.Name = "lue_company";
            this.lue_company.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lue_company.Size = new System.Drawing.Size(100, 20);
            this.lue_company.TabIndex = 10;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 20);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 9;
            this.labelControl4.Text = "公司：";
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.Location = new System.Drawing.Point(390, 77);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(75, 23);
            this.sbtn_close.TabIndex = 8;
            this.sbtn_close.Text = "关闭";
            this.sbtn_close.Click += new System.EventHandler(this.sbtn_close_Click);
            // 
            // sbtn_print
            // 
            this.sbtn_print.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sbtn_print.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_print.Image")));
            this.sbtn_print.Location = new System.Drawing.Point(298, 77);
            this.sbtn_print.Name = "sbtn_print";
            this.sbtn_print.Size = new System.Drawing.Size(75, 23);
            this.sbtn_print.TabIndex = 7;
            this.sbtn_print.Text = "打印";
            this.sbtn_print.Click += new System.EventHandler(this.sbtn_print_Click);
            // 
            // sbtn_query
            // 
            this.sbtn_query.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.sbtn_query.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_query.Image")));
            this.sbtn_query.Location = new System.Drawing.Point(206, 77);
            this.sbtn_query.Name = "sbtn_query";
            this.sbtn_query.Size = new System.Drawing.Size(75, 23);
            this.sbtn_query.TabIndex = 6;
            this.sbtn_query.Text = "查询";
            this.sbtn_query.Click += new System.EventHandler(this.sbtn_query_Click);
            // 
            // te_bincode
            // 
            this.te_bincode.Location = new System.Drawing.Point(61, 48);
            this.te_bincode.Name = "te_bincode";
            this.te_bincode.Size = new System.Drawing.Size(100, 20);
            this.te_bincode.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "库位号：";
            // 
            // te_binname
            // 
            this.te_binname.Location = new System.Drawing.Point(277, 48);
            this.te_binname.Name = "te_binname";
            this.te_binname.Size = new System.Drawing.Size(100, 20);
            this.te_binname.TabIndex = 3;
            // 
            // lbl_binname
            // 
            this.lbl_binname.Location = new System.Drawing.Point(223, 51);
            this.lbl_binname.Name = "lbl_binname";
            this.lbl_binname.Size = new System.Drawing.Size(36, 14);
            this.lbl_binname.TabIndex = 2;
            this.lbl_binname.Text = "库位：";
            // 
            // te_warehousecode
            // 
            this.te_warehousecode.Location = new System.Drawing.Point(277, 17);
            this.te_warehousecode.Name = "te_warehousecode";
            this.te_warehousecode.Size = new System.Drawing.Size(100, 20);
            this.te_warehousecode.TabIndex = 1;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(223, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "仓库号：";
            // 
            // frmWarehouse
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(504, 442);
            this.Controls.Add(this.xtraScrollableControl1);
            this.MinimumSize = new System.Drawing.Size(520, 480);
            this.Name = "frmWarehouse";
            this.Text = "仓库/库位条码";
            this.Load += new System.EventHandler(this.frmWarehouse_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_warehouse)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lue_company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_bincode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_binname.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_warehousecode.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraGrid.GridControl gc_warehouse;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_warehouse;
        private DevExpress.XtraEditors.TextEdit te_binname;
        private DevExpress.XtraEditors.LabelControl lbl_binname;
        private DevExpress.XtraEditors.TextEdit te_warehousecode;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit te_bincode;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private DevExpress.XtraEditors.SimpleButton sbtn_print;
        private DevExpress.XtraEditors.SimpleButton sbtn_query;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LookUpEdit lue_company;
    }
}