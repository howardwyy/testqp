namespace ChemTrend.Barcode.Forms.Work
{
    partial class frmWorkMappings
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkMappings));
            this.dxvp_query = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.col_end_bom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_begin_bom_index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_begin_bom = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_workcenter = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fgname = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_fgcode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_no = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gv_mapping = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_end_bom_index = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_type = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_hours = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gc_mapping = new DevExpress.XtraGrid.GridControl();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.ucPager = new ChemTrend.Barcode.Controls.ucPager();
            this.bindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_update = new DevExpress.XtraEditors.SimpleButton();
            this.te_query = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_create = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_select = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_query)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_mapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_mapping)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            this.ucPager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_query.Properties)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Caption = "Check";
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // col_end_bom
            // 
            this.col_end_bom.Caption = "END BOM OP";
            this.col_end_bom.FieldName = "EndBom";
            this.col_end_bom.Name = "col_end_bom";
            this.col_end_bom.Visible = true;
            this.col_end_bom.VisibleIndex = 8;
            // 
            // col_begin_bom_index
            // 
            this.col_begin_bom_index.Caption = "BEGIN BOM OP INDEX";
            this.col_begin_bom_index.FieldName = "BeginBomIndex";
            this.col_begin_bom_index.Name = "col_begin_bom_index";
            this.col_begin_bom_index.OptionsColumn.AllowEdit = false;
            this.col_begin_bom_index.Visible = true;
            this.col_begin_bom_index.VisibleIndex = 6;
            this.col_begin_bom_index.Width = 98;
            // 
            // col_begin_bom
            // 
            this.col_begin_bom.Caption = "BEGIN BOM OP";
            this.col_begin_bom.FieldName = "BeginBom";
            this.col_begin_bom.Name = "col_begin_bom";
            this.col_begin_bom.OptionsColumn.AllowEdit = false;
            this.col_begin_bom.Visible = true;
            this.col_begin_bom.VisibleIndex = 5;
            this.col_begin_bom.Width = 98;
            // 
            // col_workcenter
            // 
            this.col_workcenter.Caption = "WorkCenter";
            this.col_workcenter.FieldName = "WorkCenter";
            this.col_workcenter.Name = "col_workcenter";
            this.col_workcenter.OptionsColumn.AllowEdit = false;
            this.col_workcenter.Visible = true;
            this.col_workcenter.VisibleIndex = 4;
            this.col_workcenter.Width = 98;
            // 
            // col_fgname
            // 
            this.col_fgname.Caption = "成品名称";
            this.col_fgname.FieldName = "FGName";
            this.col_fgname.Name = "col_fgname";
            this.col_fgname.OptionsColumn.AllowEdit = false;
            this.col_fgname.Visible = true;
            this.col_fgname.VisibleIndex = 3;
            this.col_fgname.Width = 98;
            // 
            // col_fgcode
            // 
            this.col_fgcode.Caption = "成品料号";
            this.col_fgcode.FieldName = "FGCode";
            this.col_fgcode.Name = "col_fgcode";
            this.col_fgcode.OptionsColumn.AllowEdit = false;
            this.col_fgcode.Visible = true;
            this.col_fgcode.VisibleIndex = 2;
            this.col_fgcode.Width = 98;
            // 
            // col_no
            // 
            this.col_no.Caption = "编号";
            this.col_no.FieldName = "ID";
            this.col_no.Name = "col_no";
            this.col_no.Visible = true;
            this.col_no.VisibleIndex = 1;
            // 
            // gv_mapping
            // 
            this.gv_mapping.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_no,
            this.col_fgcode,
            this.col_fgname,
            this.col_workcenter,
            this.col_begin_bom,
            this.col_begin_bom_index,
            this.col_end_bom,
            this.col_end_bom_index,
            this.col_type,
            this.col_hours});
            this.gv_mapping.GridControl = this.gc_mapping;
            this.gv_mapping.Name = "gv_mapping";
            this.gv_mapping.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_mapping.OptionsSelection.MultiSelect = true;
            this.gv_mapping.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_mapping.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gv_mapping.OptionsView.ShowGroupPanel = false;
            this.gv_mapping.DoubleClick += new System.EventHandler(this.gv_mapping_DoubleClick);
            // 
            // col_end_bom_index
            // 
            this.col_end_bom_index.Caption = "END BOM OP INDEX";
            this.col_end_bom_index.FieldName = "EndBomIndex";
            this.col_end_bom_index.Name = "col_end_bom_index";
            this.col_end_bom_index.Visible = true;
            this.col_end_bom_index.VisibleIndex = 7;
            // 
            // col_type
            // 
            this.col_type.Caption = "计算类型";
            this.col_type.FieldName = "Type";
            this.col_type.Name = "col_type";
            this.col_type.Visible = true;
            this.col_type.VisibleIndex = 9;
            // 
            // col_hours
            // 
            this.col_hours.Caption = "固定时间";
            this.col_hours.FieldName = "Hours";
            this.col_hours.Name = "col_hours";
            this.col_hours.Visible = true;
            this.col_hours.VisibleIndex = 10;
            // 
            // gc_mapping
            // 
            this.gc_mapping.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_mapping.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_mapping.Location = new System.Drawing.Point(3, 95);
            this.gc_mapping.MainView = this.gv_mapping;
            this.gc_mapping.Name = "gc_mapping";
            this.gc_mapping.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4});
            this.gc_mapping.Size = new System.Drawing.Size(830, 375);
            this.gc_mapping.TabIndex = 5;
            this.gc_mapping.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_mapping});
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Caption = "Check";
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // ucPager
            // 
            this.ucPager.Controls.Add(this.bindingNavigator);
            this.ucPager.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucPager.Location = new System.Drawing.Point(294, 2);
            this.ucPager.Name = "ucPager";
            this.ucPager.NMax = 0;
            this.ucPager.PageCount = 0;
            this.ucPager.PageCurrent = 0;
            this.ucPager.PageSize = 20;
            this.ucPager.Size = new System.Drawing.Size(540, 29);
            this.ucPager.TabIndex = 0;
            // 
            // bindingNavigator
            // 
            this.bindingNavigator.AddNewItem = null;
            this.bindingNavigator.CountItem = null;
            this.bindingNavigator.DeleteItem = null;
            this.bindingNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.bindingNavigator.MoveFirstItem = null;
            this.bindingNavigator.MoveLastItem = null;
            this.bindingNavigator.MoveNextItem = null;
            this.bindingNavigator.MovePreviousItem = null;
            this.bindingNavigator.Name = "bindingNavigator";
            this.bindingNavigator.PositionItem = null;
            this.bindingNavigator.RenderMode = System.Windows.Forms.ToolStripRenderMode.Professional;
            this.bindingNavigator.Size = new System.Drawing.Size(540, 29);
            this.bindingNavigator.TabIndex = 0;
            this.bindingNavigator.Text = "bindingNavigator1";
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucPager);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 476);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(836, 33);
            this.panelControl1.TabIndex = 6;
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(27, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(60, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "成品料号：";
            this.labelControl1.UseMnemonic = false;
            // 
            // sbtn_delete
            // 
            this.sbtn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_delete.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_delete.Image")));
            this.sbtn_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_delete.Location = new System.Drawing.Point(750, 54);
            this.sbtn_delete.Name = "sbtn_delete";
            this.sbtn_delete.Size = new System.Drawing.Size(60, 26);
            this.sbtn_delete.TabIndex = 10;
            this.sbtn_delete.Text = "删除";
            // 
            // sbtn_update
            // 
            this.sbtn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_update.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_update.Image")));
            this.sbtn_update.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_update.Location = new System.Drawing.Point(675, 54);
            this.sbtn_update.Name = "sbtn_update";
            this.sbtn_update.Size = new System.Drawing.Size(60, 26);
            this.sbtn_update.TabIndex = 9;
            this.sbtn_update.Text = "修改";
            this.sbtn_update.Click += new System.EventHandler(this.sbtn_update_Click);
            // 
            // te_query
            // 
            this.te_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.te_query.Location = new System.Drawing.Point(93, 22);
            this.te_query.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.te_query.Name = "te_query";
            this.te_query.Size = new System.Drawing.Size(100, 20);
            this.te_query.TabIndex = 8;
            // 
            // sbtn_create
            // 
            this.sbtn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_create.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_create.Image")));
            this.sbtn_create.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_create.Location = new System.Drawing.Point(600, 54);
            this.sbtn_create.Name = "sbtn_create";
            this.sbtn_create.Size = new System.Drawing.Size(60, 24);
            this.sbtn_create.TabIndex = 8;
            this.sbtn_create.Text = "创建";
            this.sbtn_create.Click += new System.EventHandler(this.sbtn_create_Click);
            // 
            // sbtn_select
            // 
            this.sbtn_select.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_select.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_select.Image")));
            this.sbtn_select.Location = new System.Drawing.Point(525, 54);
            this.sbtn_select.Name = "sbtn_select";
            this.sbtn_select.Size = new System.Drawing.Size(60, 23);
            this.sbtn_select.TabIndex = 23;
            this.sbtn_select.Text = "查询";
            this.sbtn_select.Click += new System.EventHandler(this.sbtn_select_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Controls.Add(this.sbtn_delete);
            this.groupBox1.Controls.Add(this.sbtn_update);
            this.groupBox1.Controls.Add(this.te_query);
            this.groupBox1.Controls.Add(this.sbtn_create);
            this.groupBox1.Controls.Add(this.sbtn_select);
            this.groupBox1.Location = new System.Drawing.Point(5, 3);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(822, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户列表信息";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupBox1);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.gc_mapping);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(836, 509);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            // 
            // frmWorkMappings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(836, 509);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmWorkMappings";
            this.Text = "工序Mapping管理";
            this.Load += new System.EventHandler(this.frmWorkMappings_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_query)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_mapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gc_mapping)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            this.ucPager.ResumeLayout(false);
            this.ucPager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.te_query.Properties)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_query;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        private DevExpress.XtraGrid.Columns.GridColumn col_end_bom;
        private DevExpress.XtraGrid.Columns.GridColumn col_begin_bom_index;
        private DevExpress.XtraGrid.Columns.GridColumn col_begin_bom;
        private DevExpress.XtraGrid.Columns.GridColumn col_workcenter;
        private DevExpress.XtraGrid.Columns.GridColumn col_fgname;
        private DevExpress.XtraGrid.Columns.GridColumn col_fgcode;
        private DevExpress.XtraGrid.Columns.GridColumn col_no;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_mapping;
        private DevExpress.XtraGrid.GridControl gc_mapping;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private Controls.ucPager ucPager;
        private System.Windows.Forms.BindingNavigator bindingNavigator;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtn_delete;
        private DevExpress.XtraEditors.SimpleButton sbtn_update;
        private DevExpress.XtraEditors.TextEdit te_query;
        private DevExpress.XtraEditors.SimpleButton sbtn_create;
        private DevExpress.XtraEditors.SimpleButton sbtn_select;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraGrid.Columns.GridColumn col_end_bom_index;
        private DevExpress.XtraGrid.Columns.GridColumn col_type;
        private DevExpress.XtraGrid.Columns.GridColumn col_hours;
    }
}