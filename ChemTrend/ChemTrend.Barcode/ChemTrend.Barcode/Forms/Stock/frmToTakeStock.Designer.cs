namespace ChemTrend.Barcode.Forms.Stock
{
    partial class frmToTakeStock
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmToTakeStock));
            this.xtraScrollableControl2 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.panelControl2 = new DevExpress.XtraEditors.PanelControl();
            this.gc_check = new DevExpress.XtraGrid.GridControl();
            this.gv_check = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.col_id = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_checktime = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_username = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_remark = new DevExpress.XtraGrid.Columns.GridColumn();
            this.col_barcodeid = new DevExpress.XtraGrid.Columns.GridColumn();
            this.panelControl1 = new DevExpress.XtraEditors.PanelControl();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sbtn_reset = new DevExpress.XtraEditors.SimpleButton();
            this.dateEdit2 = new DevExpress.XtraEditors.DateEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.dateEdit1 = new DevExpress.XtraEditors.DateEdit();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_print = new DevExpress.XtraEditors.SimpleButton();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.sbtn_warehousecode = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.xtraScrollableControl1 = new DevExpress.XtraEditors.XtraScrollableControl();
            this.xtraScrollableControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).BeginInit();
            this.panelControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gc_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_check)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).BeginInit();
            this.panelControl1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).BeginInit();
            this.xtraScrollableControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // xtraScrollableControl2
            // 
            this.xtraScrollableControl2.Controls.Add(this.panelControl2);
            this.xtraScrollableControl2.Controls.Add(this.panelControl1);
            this.xtraScrollableControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl2.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl2.Name = "xtraScrollableControl2";
            this.xtraScrollableControl2.Size = new System.Drawing.Size(691, 513);
            this.xtraScrollableControl2.TabIndex = 0;
            // 
            // panelControl2
            // 
            this.panelControl2.Controls.Add(this.gc_check);
            this.panelControl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panelControl2.Location = new System.Drawing.Point(0, 127);
            this.panelControl2.Name = "panelControl2";
            this.panelControl2.Size = new System.Drawing.Size(691, 386);
            this.panelControl2.TabIndex = 4;
            // 
            // gc_check
            // 
            this.gc_check.Cursor = System.Windows.Forms.Cursors.Default;
            this.gc_check.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gc_check.Location = new System.Drawing.Point(2, 2);
            this.gc_check.MainView = this.gv_check;
            this.gc_check.Name = "gc_check";
            this.gc_check.Size = new System.Drawing.Size(687, 382);
            this.gc_check.TabIndex = 3;
            this.gc_check.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gv_check});
            // 
            // gv_check
            // 
            this.gv_check.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.col_id,
            this.col_checktime,
            this.col_username,
            this.col_remark,
            this.col_barcodeid});
            this.gv_check.GridControl = this.gc_check;
            this.gv_check.Name = "gv_check";
            this.gv_check.OptionsView.ShowGroupPanel = false;
            // 
            // col_id
            // 
            this.col_id.Caption = "序号";
            this.col_id.FieldName = "ID";
            this.col_id.Name = "col_id";
            this.col_id.Visible = true;
            this.col_id.VisibleIndex = 0;
            // 
            // col_checktime
            // 
            this.col_checktime.Caption = "盘点时间";
            this.col_checktime.DisplayFormat.FormatString = "yyyy-MM-dd HH:mm:ss";
            this.col_checktime.DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            this.col_checktime.FieldName = "CreateTime";
            this.col_checktime.Name = "col_checktime";
            this.col_checktime.Visible = true;
            this.col_checktime.VisibleIndex = 1;
            // 
            // col_username
            // 
            this.col_username.Caption = "操作人";
            this.col_username.FieldName = "UserName";
            this.col_username.Name = "col_username";
            this.col_username.Visible = true;
            this.col_username.VisibleIndex = 2;
            // 
            // col_remark
            // 
            this.col_remark.Caption = "备注";
            this.col_remark.FieldName = "Remark";
            this.col_remark.Name = "col_remark";
            this.col_remark.Visible = true;
            this.col_remark.VisibleIndex = 4;
            // 
            // col_barcodeid
            // 
            this.col_barcodeid.Caption = "条码号";
            this.col_barcodeid.FieldName = "BarcodeID";
            this.col_barcodeid.Name = "col_barcodeid";
            this.col_barcodeid.Visible = true;
            this.col_barcodeid.VisibleIndex = 3;
            // 
            // panelControl1
            // 
            this.panelControl1.Controls.Add(this.groupBox1);
            this.panelControl1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panelControl1.Location = new System.Drawing.Point(0, 0);
            this.panelControl1.Name = "panelControl1";
            this.panelControl1.Size = new System.Drawing.Size(691, 127);
            this.panelControl1.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox1.Controls.Add(this.sbtn_reset);
            this.groupBox1.Controls.Add(this.dateEdit2);
            this.groupBox1.Controls.Add(this.labelControl7);
            this.groupBox1.Controls.Add(this.dateEdit1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.labelControl6);
            this.groupBox1.Controls.Add(this.textBox5);
            this.groupBox1.Controls.Add(this.labelControl5);
            this.groupBox1.Controls.Add(this.sbtn_print);
            this.groupBox1.Controls.Add(this.textBox4);
            this.groupBox1.Controls.Add(this.labelControl4);
            this.groupBox1.Controls.Add(this.labelControl3);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.labelControl2);
            this.groupBox1.Controls.Add(this.sbtn_warehousecode);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.labelControl1);
            this.groupBox1.Location = new System.Drawing.Point(12, 6);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(667, 115);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "条码信息";
            // 
            // sbtn_reset
            // 
            this.sbtn_reset.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_reset.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_reset.Image")));
            this.sbtn_reset.Location = new System.Drawing.Point(576, 83);
            this.sbtn_reset.Name = "sbtn_reset";
            this.sbtn_reset.Size = new System.Drawing.Size(75, 23);
            this.sbtn_reset.TabIndex = 26;
            this.sbtn_reset.Text = "重置";
            this.sbtn_reset.Click += new System.EventHandler(this.sbtn_reset_Click);
            // 
            // dateEdit2
            // 
            this.dateEdit2.EditValue = null;
            this.dateEdit2.Location = new System.Drawing.Point(495, 20);
            this.dateEdit2.Name = "dateEdit2";
            this.dateEdit2.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit2.Size = new System.Drawing.Size(100, 20);
            this.dateEdit2.TabIndex = 25;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(485, 23);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(4, 14);
            this.labelControl7.TabIndex = 24;
            this.labelControl7.Text = "-";
            // 
            // dateEdit1
            // 
            this.dateEdit1.EditValue = null;
            this.dateEdit1.Location = new System.Drawing.Point(379, 20);
            this.dateEdit1.Name = "dateEdit1";
            this.dateEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateEdit1.Size = new System.Drawing.Size(100, 20);
            this.dateEdit1.TabIndex = 23;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(187, 84);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(76, 22);
            this.textBox6.TabIndex = 22;
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(177, 87);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(4, 14);
            this.labelControl6.TabIndex = 21;
            this.labelControl6.Text = "-";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(187, 51);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(76, 22);
            this.textBox5.TabIndex = 20;
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(177, 54);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(4, 14);
            this.labelControl5.TabIndex = 19;
            this.labelControl5.Text = "-";
            // 
            // sbtn_print
            // 
            this.sbtn_print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.sbtn_print.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_print.Image")));
            this.sbtn_print.Location = new System.Drawing.Point(485, 83);
            this.sbtn_print.Name = "sbtn_print";
            this.sbtn_print.Size = new System.Drawing.Size(75, 23);
            this.sbtn_print.TabIndex = 18;
            this.sbtn_print.Text = "查询";
            this.sbtn_print.Click += new System.EventHandler(this.sbtn_print_Click);
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(95, 84);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(76, 22);
            this.textBox4.TabIndex = 17;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(16, 87);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(36, 14);
            this.labelControl4.TabIndex = 16;
            this.labelControl4.Text = "库位：";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(300, 24);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(36, 14);
            this.labelControl3.TabIndex = 14;
            this.labelControl3.Text = "日期：";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(95, 51);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(76, 22);
            this.textBox2.TabIndex = 13;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(16, 54);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(36, 14);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "物料：";
            // 
            // sbtn_warehousecode
            // 
            this.sbtn_warehousecode.Image = ((System.Drawing.Image)(resources.GetObject("sbtn_warehousecode.Image")));
            this.sbtn_warehousecode.Location = new System.Drawing.Point(230, 20);
            this.sbtn_warehousecode.Name = "sbtn_warehousecode";
            this.sbtn_warehousecode.Size = new System.Drawing.Size(26, 23);
            this.sbtn_warehousecode.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(95, 21);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(129, 22);
            this.textBox1.TabIndex = 10;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(16, 24);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(36, 14);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "仓库：";
            // 
            // xtraScrollableControl1
            // 
            this.xtraScrollableControl1.Controls.Add(this.xtraScrollableControl2);
            this.xtraScrollableControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.xtraScrollableControl1.Location = new System.Drawing.Point(0, 0);
            this.xtraScrollableControl1.Name = "xtraScrollableControl1";
            this.xtraScrollableControl1.Size = new System.Drawing.Size(691, 513);
            this.xtraScrollableControl1.TabIndex = 1;
            // 
            // frmToTakeStock
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(691, 513);
            this.Controls.Add(this.xtraScrollableControl1);
            this.Name = "frmToTakeStock";
            this.Text = "盘点对比";
            this.Load += new System.EventHandler(this.frmToTakeStock_Load);
            this.xtraScrollableControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelControl2)).EndInit();
            this.panelControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gc_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gv_check)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.panelControl1)).EndInit();
            this.panelControl1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit2.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateEdit1.Properties)).EndInit();
            this.xtraScrollableControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl2;
        private DevExpress.XtraEditors.XtraScrollableControl xtraScrollableControl1;
        private DevExpress.XtraEditors.PanelControl panelControl1;
        private System.Windows.Forms.GroupBox groupBox1;
        private DevExpress.XtraEditors.SimpleButton sbtn_reset;
        private DevExpress.XtraEditors.DateEdit dateEdit2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.DateEdit dateEdit1;
        private System.Windows.Forms.TextBox textBox6;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private System.Windows.Forms.TextBox textBox5;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.SimpleButton sbtn_print;
        private System.Windows.Forms.TextBox textBox4;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private System.Windows.Forms.TextBox textBox2;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton sbtn_warehousecode;
        private System.Windows.Forms.TextBox textBox1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.PanelControl panelControl2;
        private DevExpress.XtraGrid.GridControl gc_check;
        private DevExpress.XtraGrid.Views.Grid.GridView gv_check;
        private DevExpress.XtraGrid.Columns.GridColumn col_id;
        private DevExpress.XtraGrid.Columns.GridColumn col_checktime;
        private DevExpress.XtraGrid.Columns.GridColumn col_username;
        private DevExpress.XtraGrid.Columns.GridColumn col_remark;
        private DevExpress.XtraGrid.Columns.GridColumn col_barcodeid;
    }
}