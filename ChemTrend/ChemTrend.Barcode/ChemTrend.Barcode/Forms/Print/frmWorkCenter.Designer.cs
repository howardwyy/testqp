namespace ChemTrend.Barcode.Forms.Print
{
    partial class frmWorkCenter
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkCenter));
            this.lue_company = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_print = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_query = new DevExpress.XtraEditors.SimpleButton();
            this.te_wcname = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.te_wccode = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gv_workcenter = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gc_workcenter = new DevExpress.XtraGrid.GridControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.col_WorkcenterCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.loc_WorkcenterName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_Company = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.lue_company.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_wcname.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_wccode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gv_workcenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_workcenter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.xtraScrollableControl2.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
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
            this.sbtn_close.Location = new System.Drawing.Point(363, 77);
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
            this.sbtn_print.Location = new System.Drawing.Point(271, 77);
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
            this.sbtn_query.Location = new System.Drawing.Point(179, 77);
            this.sbtn_query.Name = "sbtn_query";
            this.sbtn_query.Size = new System.Drawing.Size(75, 23);
            this.sbtn_query.TabIndex = 6;
            this.sbtn_query.Text = "查询";
            this.sbtn_query.Click += new System.EventHandler(this.sbtn_query_Click);
            // 
            // te_wcname
            // 
            this.te_wcname.Location = new System.Drawing.Point(61, 48);
            this.te_wcname.Name = "te_wcname";
            this.te_wcname.Size = new System.Drawing.Size(100, 20);
            this.te_wcname.TabIndex = 5;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(7, 51);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(42, 14);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Name：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(223, 20);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(39, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Code：";
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
            this.groupBox1.Controls.Add(this.te_wcname);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.te_wccode);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(453, 106);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "查询";
            // 
            // te_wccode
            // 
            this.te_wccode.Location = new System.Drawing.Point(277, 17);
            this.te_wccode.Name = "te_wccode";
            this.te_wccode.Size = new System.Drawing.Size(100, 20);
            this.te_wccode.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(477, 117);
            this.panelControl1.TabIndex = 0;
            // 
            // gv_workcenter
            // 
            this.gv_workcenter.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_WorkcenterCode,
            this.loc_WorkcenterName,
            this.col_Company});
            this.gv_workcenter.GridControl = this.gc_workcenter;
            this.gv_workcenter.Name = "gv_workcenter";
            this.gv_workcenter.OptionsBehavior.Editable = false;
            this.gv_workcenter.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_workcenter.OptionsSelection.MultiSelect = true;
            this.gv_workcenter.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_workcenter.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gv_workcenter.OptionsSelection.ShowCheckBoxSelectorInGroupRow = DevExpress.Utils.DefaultBoolean.True;
            this.gv_workcenter.OptionsView.ShowGroupPanel = false;
            // 
            // gc_workcenter
            // 
            this.gc_workcenter.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_workcenter.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_workcenter.Location = new System.Drawing.Point(2, 2);
            this.gc_workcenter.MainView = this.gv_workcenter;
            this.gc_workcenter.Name = "gc_workcenter";
            this.gc_workcenter.Size = new System.Drawing.Size(473, 313);
            this.gc_workcenter.TabIndex = 0;
            this.gc_workcenter.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_workcenter});
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_workcenter);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 117);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(477, 317);
            this.panelControl2.TabIndex = 1;
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.panelControl2);
            this.xtraScrollableControl2.Controls.Add(this.panelControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(477, 434);
            this.xtraScrollableControl2.TabIndex = 0;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.xtraScrollableControl2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(477, 434);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // col_WorkcenterCode
            // 
            this.col_WorkcenterCode.Caption = "Code";
            this.col_WorkcenterCode.FieldName = "WorkcenterCode";
            this.col_WorkcenterCode.Name = "col_WorkcenterCode";
            this.col_WorkcenterCode.Visible = true;
            this.col_WorkcenterCode.VisibleIndex = 1;
            // 
            // loc_WorkcenterName
            // 
            this.loc_WorkcenterName.Caption = "Name";
            this.loc_WorkcenterName.FieldName = "WorkcenterName";
            this.loc_WorkcenterName.Name = "loc_WorkcenterName";
            this.loc_WorkcenterName.Visible = true;
            this.loc_WorkcenterName.VisibleIndex = 2;
            // 
            // col_Company
            // 
            this.col_Company.Caption = "公司";
            this.col_Company.FieldName = "Company";
            this.col_Company.Name = "col_Company";
            this.col_Company.Visible = true;
            this.col_Company.VisibleIndex = 3;
            // 
            // frmWorkCenter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 434);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmWorkCenter";
            this.ShowIcon = false;
            this.Text = "WorkCenter";
            this.Load += new System.EventHandler(this.frmWorkCenter_Load);
            ((System.ComponentModel.ISupportInitialize)(this.lue_company.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_wcname.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_wccode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gv_workcenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_workcenter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.xtraScrollableControl2.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit lue_company;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private DevExpress.XtraEditors.SimpleButton sbtn_print;
        private DevExpress.XtraEditors.SimpleButton sbtn_query;
        private DevExpress.XtraEditors.TextEdit te_wcname;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.TextEdit te_wccode;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.Columns.GridColumn col_Company;
        private DevExpress.XtraGrid.Columns.GridColumn loc_WorkcenterName;
        private DevExpress.XtraGrid.Columns.GridColumn col_WorkcenterCode;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_workcenter;
        private DevExpress.XtraGrid.GridControl gc_workcenter;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
    }
}