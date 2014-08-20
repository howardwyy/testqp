namespace ChemTrend.Barcode.Forms.Systems
{
    partial class frmUsers
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUsers));
            this.repositoryItemCheckEdit1 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_update = new DevExpress.XtraEditors.SimpleButton();
            this.te_query = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_create = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_select = new DevExpress.XtraEditors.SimpleButton();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.ucPager = new ChemTrend.Barcode.Controls.ucPager();
            this.gc_users = new DevExpress.XtraGrid.GridControl();
            this.gv_users = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn9 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemCheckEdit2 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit3 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.repositoryItemCheckEdit4 = new DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit();
            this.dxvp_query = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_query.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_users)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_query)).BeginInit();
            this.SuspendLayout();
            // 
            // repositoryItemCheckEdit1
            // 
            this.repositoryItemCheckEdit1.AutoHeight = false;
            this.repositoryItemCheckEdit1.Caption = "Check";
            this.repositoryItemCheckEdit1.CheckStyle = DevExpress.XtraEditors.Controls.CheckStyles.Radio;
            this.repositoryItemCheckEdit1.Name = "repositoryItemCheckEdit1";
            this.repositoryItemCheckEdit1.NullStyle = DevExpress.XtraEditors.Controls.StyleIndeterminate.Inactive;
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.groupBox1);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.gc_users);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(712, 475);
            this.xtraScrollableControl1.TabIndex = 0;
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
            this.groupBox1.Size = new System.Drawing.Size(698, 84);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "用户列表信息";
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.labelControl1.LineLocation = DevExpress.XtraEditors.LineLocation.Center;
            this.labelControl1.Location = new System.Drawing.Point(27, 28);
            this.labelControl1.Margin = new System.Windows.Forms.Padding(3, 10, 3, 3);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 14);
            this.labelControl1.TabIndex = 9;
            this.labelControl1.Text = "用户名：";
            this.labelControl1.UseMnemonic = false;
            // 
            // sbtn_delete
            // 
            this.sbtn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_delete.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_delete.Image")));
            this.sbtn_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_delete.Location = new System.Drawing.Point(626, 54);
            this.sbtn_delete.Name = "sbtn_delete";
            this.sbtn_delete.Size = new System.Drawing.Size(60, 26);
            this.sbtn_delete.TabIndex = 10;
            this.sbtn_delete.Text = "删除";
            this.sbtn_delete.Click += new System.EventHandler(this.sbtn_delete_Click);
            // 
            // sbtn_update
            // 
            this.sbtn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_update.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_update.Image")));
            this.sbtn_update.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_update.Location = new System.Drawing.Point(551, 54);
            this.sbtn_update.Name = "sbtn_update";
            this.sbtn_update.Size = new System.Drawing.Size(60, 26);
            this.sbtn_update.TabIndex = 9;
            this.sbtn_update.Text = "修改";
            this.sbtn_update.Click += new System.EventHandler(this.sbtn_update_Click);
            // 
            // te_query
            // 
            this.te_query.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.te_query.Location = new System.Drawing.Point(81, 25);
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
            this.sbtn_create.Location = new System.Drawing.Point(476, 54);
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
            this.sbtn_select.Location = new System.Drawing.Point(401, 54);
            this.sbtn_select.Name = "sbtn_select";
            this.sbtn_select.Size = new System.Drawing.Size(60, 23);
            this.sbtn_select.TabIndex = 23;
            this.sbtn_select.Text = "查询";
            this.sbtn_select.Click += new System.EventHandler(this.sbtn_select_Click);
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.ucPager);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panelControl1.Location = new System.Drawing.Point(0, 442);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(712, 33);
            this.panelControl1.TabIndex = 6;
            // 
            // ucPager
            // 
            this.ucPager.Dock = System.Windows.Forms.DockStyle.Right;
            this.ucPager.Location = new System.Drawing.Point(170, 2);
            this.ucPager.Name = "ucPager";
            this.ucPager.NMax = 0;
            this.ucPager.PageCount = 0;
            this.ucPager.PageCurrent = 0;
            this.ucPager.PageSize = 20;
            this.ucPager.Size = new System.Drawing.Size(540, 29);
            this.ucPager.TabIndex = 0;
            // 
            // gc_users
            // 
            this.gc_users.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.gc_users.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_users.Location = new System.Drawing.Point(3, 95);
            this.gc_users.MainView = this.gv_users;
            this.gc_users.Name = "gc_users";
            this.gc_users.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemCheckEdit2,
            this.repositoryItemCheckEdit3,
            this.repositoryItemCheckEdit4});
            this.gc_users.Size = new System.Drawing.Size(706, 341);
            this.gc_users.TabIndex = 5;
            this.gc_users.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_users});
            // 
            // gv_users
            // 
            this.gv_users.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn9,
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn4,
            this.gridColumn3,
            this.gridColumn5,
            this.gridColumn6});
            this.gv_users.GridControl = this.gc_users;
            this.gv_users.Name = "gv_users";
            this.gv_users.OptionsSelection.CheckBoxSelectorColumnWidth = 35;
            this.gv_users.OptionsSelection.MultiSelect = true;
            this.gv_users.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.CheckBoxRowSelect;
            this.gv_users.OptionsSelection.ShowCheckBoxSelectorInColumnHeader = DevExpress.Utils.DefaultBoolean.True;
            this.gv_users.OptionsView.ShowGroupPanel = false;
            this.gv_users.CustomColumnDisplayText += new DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventHandler(this.gv_users_CustomColumnDisplayText);
            this.gv_users.DoubleClick += new System.EventHandler(this.gv_users_DoubleClick);
            // 
            // gridColumn9
            // 
            this.gridColumn9.Caption = "编号";
            this.gridColumn9.FieldName = "ID";
            this.gridColumn9.Name = "gridColumn9";
            this.gridColumn9.Visible = true;
            this.gridColumn9.VisibleIndex = 1;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "用户代码";
            this.gridColumn1.FieldName = "UserCode";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 2;
            this.gridColumn1.Width = 98;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "登录名";
            this.gridColumn2.FieldName = "LoginName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 3;
            this.gridColumn2.Width = 98;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "用户姓名";
            this.gridColumn4.FieldName = "UserName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 5;
            this.gridColumn4.Width = 98;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "用户角色";
            this.gridColumn3.FieldName = "RoleName";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 98;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "创建日期";
            this.gridColumn5.DisplayFormat.FormatString = "d";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.gridColumn5.FieldName = "CreateTime";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.OptionsColumn.AllowEdit = false;
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 6;
            this.gridColumn5.Width = 98;
            // 
            // repositoryItemCheckEdit2
            // 
            this.repositoryItemCheckEdit2.AutoHeight = false;
            this.repositoryItemCheckEdit2.Caption = "Check";
            this.repositoryItemCheckEdit2.Name = "repositoryItemCheckEdit2";
            // 
            // repositoryItemCheckEdit3
            // 
            this.repositoryItemCheckEdit3.AutoHeight = false;
            this.repositoryItemCheckEdit3.Caption = "Check";
            this.repositoryItemCheckEdit3.Name = "repositoryItemCheckEdit3";
            // 
            // repositoryItemCheckEdit4
            // 
            this.repositoryItemCheckEdit4.AutoHeight = false;
            this.repositoryItemCheckEdit4.Caption = "Check";
            this.repositoryItemCheckEdit4.Name = "repositoryItemCheckEdit4";
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "状态";
            this.gridColumn6.FieldName = "Enable";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 7;
            // 
            // frmUsers
            // 
            this.ClientSize = new System.Drawing.Size(712, 475);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmUsers";
            this.Text = "用户管理";
            this.Load += new System.EventHandler(this.frmUsers_Load);
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit1)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_query.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_users)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemCheckEdit4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_query)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraGrid.GridControl gc_users;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_users;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private Controls.ucPager ucPager;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtn_delete;
        private DevExpress.XtraEditors.SimpleButton sbtn_update;
        private DevExpress.XtraEditors.TextEdit te_query;
        private DevExpress.XtraEditors.SimpleButton sbtn_create;
        private DevExpress.XtraEditors.SimpleButton sbtn_select;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn9;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_query;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit2;
        public DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit1;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit3;
        private DevExpress.XtraEditors.Repository.RepositoryItemCheckEdit repositoryItemCheckEdit4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}