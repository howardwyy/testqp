namespace ChemTrend.Barcode.Forms.FG
{
    partial class frmFGHistory
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFGHistory));
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_barcode_history = new DevExpress.XtraGrid.GridControl();
            this.gv_barcode_history = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.序号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1.SuspendLayout();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_barcode_history)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_barcode_history)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 317);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(754, 51);
            this.panel1.TabIndex = 0;
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.Location = new System.Drawing.Point(667, 16);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(75, 23);
            this.sbtn_close.TabIndex = 9;
            this.sbtn_close.Text = "关闭";
            this.sbtn_close.Click += new System.EventHandler(this.sbtn_close_Click);
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.panel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(754, 368);
            this.xtraScrollableControl1.TabIndex = 2;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_barcode_history);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(754, 317);
            this.panelControl1.TabIndex = 1;
            // 
            // gc_barcode_history
            // 
            this.gc_barcode_history.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_barcode_history.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_barcode_history.Location = new System.Drawing.Point(2, 2);
            this.gc_barcode_history.MainView = this.gv_barcode_history;
            this.gc_barcode_history.Name = "gc_barcode_history";
            this.gc_barcode_history.Size = new System.Drawing.Size(750, 313);
            this.gc_barcode_history.TabIndex = 2;
            this.gc_barcode_history.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_barcode_history});
            // 
            // gv_barcode_history
            // 
            this.gv_barcode_history.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn5,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn4});
            this.gv_barcode_history.GridControl = this.gc_barcode_history;
            this.gv_barcode_history.Name = "gv_barcode_history";
            this.gv_barcode_history.OptionsBehavior.Editable = false;
            this.gv_barcode_history.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "单据号";
            this.gridColumn1.FieldName = "BillID";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 119;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "操作人员";
            this.gridColumn2.FieldName = "UserName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 4;
            this.gridColumn2.Width = 119;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "操作时间";
            this.gridColumn5.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.gridColumn5.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            this.gridColumn5.FieldName = "CreateTime";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 197;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "编号";
            this.gridColumn17.FieldName = "ID";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 0;
            this.gridColumn17.Width = 59;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "备注";
            this.gridColumn18.FieldName = "Remark";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 1;
            this.gridColumn18.Width = 119;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "条码号";
            this.gridColumn4.FieldName = "BarcodeID";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 119;
            // 
            // 序号
            // 
            this.序号.Caption = "序号";
            this.序号.FieldName = "ID";
            this.序号.Name = "序号";
            // 
            // frmFGHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(754, 368);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmFGHistory";
            this.Text = "成品条码历史记录";
            this.Load += new System.EventHandler(this.frmFGHistory_Load);
            this.panel1.ResumeLayout(false);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_barcode_history)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_barcode_history)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_barcode_history;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_barcode_history;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn 序号;
    }
}