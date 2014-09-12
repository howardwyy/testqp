namespace ChemTrend.Barcode.Forms.Work
{
    partial class frmWorkDetails
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWorkDetails));
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.gc_work_detail = new DevExpress.XtraGrid.GridControl();
            this.gv_work_detail = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_num = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_createtime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_workno = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_barck = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.sbtn_close = new DevExpress.XtraEditors.SimpleButton();
            this.col_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_status = new DevExpress.XtraGrid.Columns.GridColumn();
            this.xtraScrollableControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_work_detail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_work_detail)).BeginInit();
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
            this.xtraScrollableControl1.Size = new System.Drawing.Size(613, 452);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.gc_work_detail);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(613, 401);
            this.panelControl1.TabIndex = 1;
            // 
            // gc_work_detail
            // 
            this.gc_work_detail.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_work_detail.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_work_detail.Location = new System.Drawing.Point(2, 2);
            this.gc_work_detail.MainView = this.gv_work_detail;
            this.gc_work_detail.Name = "gc_work_detail";
            this.gc_work_detail.Size = new System.Drawing.Size(609, 397);
            this.gc_work_detail.TabIndex = 2;
            this.gc_work_detail.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_work_detail});
            // 
            // gv_work_detail
            // 
            this.gv_work_detail.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_num,
            this.col_createtime,
            this.col_workno,
            this.col_remark,
            this.col_barck,
            this.col_status,
            this.col_username});
            this.gv_work_detail.GridControl = this.gc_work_detail;
            this.gv_work_detail.Name = "gv_work_detail";
            this.gv_work_detail.OptionsView.ShowGroupPanel = false;
            // 
            // col_num
            // 
            this.col_num.Caption = "工序号";
            this.col_num.FieldName = "ID";
            this.col_num.Name = "col_num";
            this.col_num.Visible = true;
            this.col_num.VisibleIndex = 0;
            // 
            // col_createtime
            // 
            this.col_createtime.Caption = "操作时间";
            this.col_createtime.FieldName = "CreateTime";
            this.col_createtime.Name = "col_createtime";
            this.col_createtime.Visible = true;
            this.col_createtime.VisibleIndex = 1;
            // 
            // col_workno
            // 
            this.col_workno.Caption = "单据号";
            this.col_workno.FieldName = "BillId";
            this.col_workno.Name = "col_workno";
            this.col_workno.Visible = true;
            this.col_workno.VisibleIndex = 2;
            // 
            // col_remark
            // 
            this.col_remark.Caption = "备注";
            this.col_remark.FieldName = "Remark";
            this.col_remark.Name = "col_remark";
            this.col_remark.Visible = true;
            this.col_remark.VisibleIndex = 6;
            // 
            // col_barck
            // 
            this.col_barck.Caption = "条码号";
            this.col_barck.FieldName = "BarcodeId";
            this.col_barck.Name = "col_barck";
            this.col_barck.Visible = true;
            this.col_barck.VisibleIndex = 3;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.sbtn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 401);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(613, 51);
            this.panel1.TabIndex = 0;
            // 
            // sbtn_close
            // 
            this.sbtn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_close.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_close.Image")));
            this.sbtn_close.Location = new System.Drawing.Point(526, 16);
            this.sbtn_close.Name = "sbtn_close";
            this.sbtn_close.Size = new System.Drawing.Size(75, 23);
            this.sbtn_close.TabIndex = 9;
            this.sbtn_close.Text = "关闭";
            this.sbtn_close.Click += new System.EventHandler(this.sbtn_close_Click);
            // 
            // col_username
            // 
            this.col_username.Caption = "操作人";
            this.col_username.Name = "col_username";
            this.col_username.Visible = true;
            this.col_username.VisibleIndex = 4;
            // 
            // col_status
            // 
            this.col_status.Caption = "状态";
            this.col_status.Name = "col_status";
            this.col_status.Visible = true;
            this.col_status.VisibleIndex = 5;
            // 
            // frmWorkDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(613, 452);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmWorkDetails";
            this.Text = "工单详情";
            this.Load += new System.EventHandler(this.frmWorkDetails_Load);
            this.xtraScrollableControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_work_detail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_work_detail)).EndInit();
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private DevExpress.XtraGrid.GridControl gc_work_detail;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_work_detail;
        private DevExpress.XtraGrid.Columns.GridColumn col_num;
        private DevExpress.XtraGrid.Columns.GridColumn col_createtime;
        private DevExpress.XtraGrid.Columns.GridColumn col_workno;
        private DevExpress.XtraGrid.Columns.GridColumn col_remark;
        private DevExpress.XtraGrid.Columns.GridColumn col_barck;
        private DevExpress.XtraGrid.Columns.GridColumn col_status;
        private DevExpress.XtraGrid.Columns.GridColumn col_username;
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton sbtn_close;
    }
}