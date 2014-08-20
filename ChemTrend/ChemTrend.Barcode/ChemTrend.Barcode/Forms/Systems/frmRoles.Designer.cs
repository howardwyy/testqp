namespace ChemTrend.Barcode.Forms.Systems
{
    partial class frmRoles
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmRoles));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.tl_rights = new DevExpress.XtraTreeList.TreeList();
            this.treeListColumn1 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn2 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.treeListColumn3 = new DevExpress.XtraTreeList.Columns.TreeListColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.te_code = new DevExpress.XtraEditors.TextEdit();
            this.sbtn_update = new DevExpress.XtraEditors.SimpleButton();
            this.sbtn_delete = new DevExpress.XtraEditors.SimpleButton();
            this.te_remark = new System.Windows.Forms.TextBox();
            this.sbtn_create = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.te_rolename = new DevExpress.XtraEditors.TextEdit();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.gc_roles = new DevExpress.XtraGrid.GridControl();
            this.gv_roles = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.cID = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cRoleName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.cRemark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.dxvp_rolename = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.dxvp_code = new DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider(this.components);
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.tl_rights)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_code.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_rolename.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_roles)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_rolename)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_code)).BeginInit();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl2);
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(737, 462);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.groupBox3);
            this.panelControl2.Controls.Add(this.groupBox2);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(182, 0);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(555, 462);
            this.panelControl2.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.tl_rights);
            this.groupBox3.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox3.Location = new System.Drawing.Point(2, 2);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(551, 282);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "可操作功能";
            // 
            // tl_rights
            // 
            this.tl_rights.Columns.AddRange(new DevExpress.XtraTreeList.Columns.TreeListColumn[] {
            this.treeListColumn1,
            this.treeListColumn2,
            this.treeListColumn3});
            this.tl_rights.CustomizationFormBounds = new System.Drawing.Rectangle(518, 351, 216, 217);
            this.tl_rights.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tl_rights.Location = new System.Drawing.Point(3, 18);
            this.tl_rights.Name = "tl_rights";
            this.tl_rights.OptionsBehavior.PopulateServiceColumns = true;
            this.tl_rights.OptionsView.ShowCheckBoxes = true;
            this.tl_rights.Size = new System.Drawing.Size(545, 261);
            this.tl_rights.TabIndex = 0;
            this.tl_rights.BeforeCheckNode += new DevExpress.XtraTreeList.CheckNodeEventHandler(this.tl_rights_BeforeCheckNode);
            this.tl_rights.AfterCheckNode += new DevExpress.XtraTreeList.NodeEventHandler(this.tl_rights_AfterCheckNode);
            // 
            // treeListColumn1
            // 
            this.treeListColumn1.Caption = "节点ID";
            this.treeListColumn1.FieldName = "ID";
            this.treeListColumn1.Name = "treeListColumn1";
            this.treeListColumn1.Width = 124;
            // 
            // treeListColumn2
            // 
            this.treeListColumn2.Caption = "名称";
            this.treeListColumn2.FieldName = "RightsDesc";
            this.treeListColumn2.MinWidth = 32;
            this.treeListColumn2.Name = "treeListColumn2";
            this.treeListColumn2.Visible = true;
            this.treeListColumn2.VisibleIndex = 0;
            this.treeListColumn2.Width = 181;
            // 
            // treeListColumn3
            // 
            this.treeListColumn3.Caption = "操作";
            this.treeListColumn3.FieldName = "ActionName";
            this.treeListColumn3.Name = "treeListColumn3";
            this.treeListColumn3.SortOrder = System.Windows.Forms.SortOrder.Ascending;
            this.treeListColumn3.Width = 239;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.te_code);
            this.groupBox2.Controls.Add(this.sbtn_update);
            this.groupBox2.Controls.Add(this.sbtn_delete);
            this.groupBox2.Controls.Add(this.te_remark);
            this.groupBox2.Controls.Add(this.sbtn_create);
            this.groupBox2.Controls.Add(this.labelControl2);
            this.groupBox2.Controls.Add(this.labelControl1);
            this.groupBox2.Controls.Add(this.te_rolename);
            this.groupBox2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupBox2.Location = new System.Drawing.Point(2, 284);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(551, 176);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "角色详细信息";
            // 
            // te_code
            // 
            this.te_code.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.te_code.Enabled = false;
            this.te_code.Location = new System.Drawing.Point(103, 146);
            this.te_code.Name = "te_code";
            this.te_code.Size = new System.Drawing.Size(108, 20);
            this.te_code.TabIndex = 9;
            // 
            // sbtn_update
            // 
            this.sbtn_update.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_update.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_update.Image")));
            this.sbtn_update.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_update.Location = new System.Drawing.Point(406, 146);
            this.sbtn_update.Name = "sbtn_update";
            this.sbtn_update.Size = new System.Drawing.Size(60, 26);
            this.sbtn_update.TabIndex = 4;
            this.sbtn_update.Text = "修改";
            this.sbtn_update.Click += new System.EventHandler(this.sbtn_update_Click);
            // 
            // sbtn_delete
            // 
            this.sbtn_delete.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_delete.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_delete.Image")));
            this.sbtn_delete.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_delete.Location = new System.Drawing.Point(480, 146);
            this.sbtn_delete.Name = "sbtn_delete";
            this.sbtn_delete.Size = new System.Drawing.Size(60, 26);
            this.sbtn_delete.TabIndex = 8;
            this.sbtn_delete.Text = "删除";
            this.sbtn_delete.Click += new System.EventHandler(this.sbtn_delete_Click);
            // 
            // te_remark
            // 
            this.te_remark.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.te_remark.Location = new System.Drawing.Point(103, 63);
            this.te_remark.Multiline = true;
            this.te_remark.Name = "te_remark";
            this.te_remark.Size = new System.Drawing.Size(428, 76);
            this.te_remark.TabIndex = 2;
            // 
            // sbtn_create
            // 
            this.sbtn_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_create.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_create.Image")));
            this.sbtn_create.ImageLocation = DevExpress.XtraEditors.ImageLocation.MiddleLeft;
            this.sbtn_create.Location = new System.Drawing.Point(332, 147);
            this.sbtn_create.Name = "sbtn_create";
            this.sbtn_create.Size = new System.Drawing.Size(60, 26);
            this.sbtn_create.TabIndex = 7;
            this.sbtn_create.Text = "创建";
            this.sbtn_create.Click += new System.EventHandler(this.sbtn_create_Click);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(42, 66);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "描述：";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(25, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(53, 14);
            this.labelControl1.TabIndex = 1;
            this.labelControl1.Text = "名称(*)：";
            // 
            // te_rolename
            // 
            this.te_rolename.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.te_rolename.Location = new System.Drawing.Point(103, 21);
            this.te_rolename.Name = "te_rolename";
            this.te_rolename.Size = new System.Drawing.Size(428, 20);
            this.te_rolename.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(182, 462);
            this.panelControl1.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.gc_roles);
            this.groupBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox1.Location = new System.Drawing.Point(2, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(178, 458);
            this.groupBox1.TabIndex = 9;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "角色列表";
            // 
            // gc_roles
            // 
            this.gc_roles.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_roles.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_roles.Location = new System.Drawing.Point(3, 18);
            this.gc_roles.MainView = this.gv_roles;
            this.gc_roles.Name = "gc_roles";
            this.gc_roles.Size = new System.Drawing.Size(172, 437);
            this.gc_roles.TabIndex = 0;
            this.gc_roles.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_roles});
            // 
            // gv_roles
            // 
            this.gv_roles.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.cID,
            this.cRoleName,
            this.cRemark});
            this.gv_roles.GridControl = this.gc_roles;
            this.gv_roles.Name = "gv_roles";
            this.gv_roles.OptionsView.ShowGroupPanel = false;
            this.gv_roles.FocusedRowChanged += new DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventHandler(this.gv_roles_FocusedRowChanged);
            // 
            // cID
            // 
            this.cID.Caption = "ID";
            this.cID.FieldName = "ID";
            this.cID.Name = "cID";
            // 
            // cRoleName
            // 
            this.cRoleName.Caption = "角色名称";
            this.cRoleName.FieldName = "RoleName";
            this.cRoleName.Name = "cRoleName";
            this.cRoleName.Visible = true;
            this.cRoleName.VisibleIndex = 0;
            // 
            // cRemark
            // 
            this.cRemark.Caption = "备注";
            this.cRemark.FieldName = "Remark";
            this.cRemark.Name = "cRemark";
            this.cRemark.Visible = true;
            this.cRemark.VisibleIndex = 1;
            // 
            // frmRoles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 462);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmRoles";
            this.Text = "用户角色管理";
            this.Load += new System.EventHandler(this.frmRoles_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.tl_rights)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.te_code.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.te_rolename.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_roles)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_rolename)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dxvp_code)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraEditors.SimpleButton sbtn_delete;
        private DevExpress.XtraEditors.SimpleButton sbtn_create;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox te_remark;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit te_rolename;
        private DevExpress.XtraEditors.SimpleButton sbtn_update;
        private DevExpress.XtraTreeList.TreeList tl_rights;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn1;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn2;
        private DevExpress.XtraGrid.GridControl gc_roles;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_roles;
        private DevExpress.XtraGrid.Columns.GridColumn cRoleName;
        private DevExpress.XtraGrid.Columns.GridColumn cRemark;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_rolename;
        private DevExpress.XtraGrid.Columns.GridColumn cID;
        private DevExpress.XtraEditors.DXErrorProvider.DXValidationProvider dxvp_code;
        private DevExpress.XtraEditors.TextEdit te_code;
        private DevExpress.XtraTreeList.Columns.TreeListColumn treeListColumn3;
    }
}