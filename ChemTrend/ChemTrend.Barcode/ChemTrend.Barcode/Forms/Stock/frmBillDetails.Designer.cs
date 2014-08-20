namespace ChemTrend.Barcode.Forms.Stock
{
    partial class frmBillDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmBillDetails));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_bill_detail = new DevExpress.XtraGrid.GridControl();
            this.gv_bill_detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.序号 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn17 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn18 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill_detail)).BeginInit();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.panelControl1);
            this.xtraScrollableControl1.Controls.Add(this.panel1);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(526, 320);
            this.xtraScrollableControl1.TabIndex = 0;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_bill_detail);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(526, 269);
            this.panelControl1.TabIndex = 1;
            // 
            // gc_bill_detail
            // 
            this.gc_bill_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_bill_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_bill_detail.Location = new System.Drawing.Point(2, 2);
            this.gc_bill_detail.MainView = this.gv_bill_detail;
            this.gc_bill_detail.Name = "gc_bill_detail";
            this.gc_bill_detail.Size = new System.Drawing.Size(522, 265);
            this.gc_bill_detail.TabIndex = 2;
            this.gc_bill_detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_bill_detail});
            // 
            // gv_bill_detail
            // 
            this.gv_bill_detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.序号,
            this.gridColumn5,
            this.gridColumn17,
            this.gridColumn18,
            this.gridColumn4});
            this.gv_bill_detail.GridControl = this.gc_bill_detail;
            this.gv_bill_detail.Name = "gv_bill_detail";
            this.gv_bill_detail.OptionsView.ShowGroupPanel = false;
            // 
            // 序号
            // 
            this.序号.Caption = "序号";
            this.序号.FieldName = "ID";
            this.序号.Name = "序号";
            this.序号.Visible = true;
            this.序号.VisibleIndex = 0;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "操作时间";
            this.gridColumn5.FieldName = "CreateTime";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 1;
            // 
            // gridColumn17
            // 
            this.gridColumn17.Caption = "单据号";
            this.gridColumn17.FieldName = "BillId";
            this.gridColumn17.Name = "gridColumn17";
            this.gridColumn17.Visible = true;
            this.gridColumn17.VisibleIndex = 2;
            // 
            // gridColumn18
            // 
            this.gridColumn18.Caption = "备注";
            this.gridColumn18.FieldName = "Remark";
            this.gridColumn18.Name = "gridColumn18";
            this.gridColumn18.Visible = true;
            this.gridColumn18.VisibleIndex = 4;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "条码号";
            this.gridColumn4.FieldName = "BarcodeId";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 269);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(526, 51);
            this.panel1.TabIndex = 0;
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.Location = new System.Drawing.Point(439, 16);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(75, 23);
            this.sbtn_close.TabIndex = 9;
            this.sbtn_close.Text = "关闭";
            this.sbtn_close.Click += new System.EventHandler(this.sbtn_close_Click);
            // 
            // frmBillDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 320);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmBillDetails";
            this.Text = "单据详情";
            this.Load += new System.EventHandler(this.frmBillDetails_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_bill_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_bill_detail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_bill_detail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_bill_detail;
        private DevExpress.XtraGrid.Columns.GridColumn 序号;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn17;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn18;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
    }
}