namespace ChemTrend.Barcode.Forms.Report
{
    partial class repStock
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

        #region Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            DevExpress.XtraPrinting.BarCode.Code128Generator code128Generator1 = new DevExpress.XtraPrinting.BarCode.Code128Generator();
            this.Detail = new DevExpress.XtraReports.UI.DetailBand();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xlbl_suppliername = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbl_orderno = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel7 = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbl_supplier = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbl_count = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbl_unit = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel5 = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbl_batchno = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbl_stockname = new DevExpress.XtraReports.UI.XRLabel();
            this.xlbl_stockno = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel4 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine2 = new DevExpress.XtraReports.UI.XRLine();
            this.xbarcode = new DevExpress.XtraReports.UI.XRBarCode();
            this.xrLabel2 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLabel1 = new DevExpress.XtraReports.UI.XRLabel();
            this.xrLine1 = new DevExpress.XtraReports.UI.XRLine();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.HeightF = 315.625F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlbl_suppliername,
            this.xlbl_orderno,
            this.xrLabel7,
            this.xlbl_supplier,
            this.xlbl_count,
            this.xlbl_unit,
            this.xrLabel5,
            this.xlbl_batchno,
            this.xlbl_stockname,
            this.xlbl_stockno,
            this.xrLabel4,
            this.xrLine2,
            this.xbarcode,
            this.xrLabel2,
            this.xrLabel1,
            this.xrLine1});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(26.66664F, 10.00001F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(601.0416F, 266.6667F);
            // 
            // xlbl_suppliername
            // 
            this.xlbl_suppliername.LocationFloat = new DevExpress.Utils.PointFloat(46.25002F, 215.125F);
            this.xlbl_suppliername.Name = "xlbl_suppliername";
            this.xlbl_suppliername.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_suppliername.SizeF = new System.Drawing.SizeF(381.25F, 23F);
            this.xlbl_suppliername.Text = "xlbl_suppliername";
            // 
            // xlbl_orderno
            // 
            this.xlbl_orderno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_orderno.LocationFloat = new DevExpress.Utils.PointFloat(365F, 192.125F);
            this.xlbl_orderno.Name = "xlbl_orderno";
            this.xlbl_orderno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_orderno.SizeF = new System.Drawing.SizeF(115.625F, 23F);
            this.xlbl_orderno.StylePriority.UseFont = false;
            this.xlbl_orderno.Text = "xlbl_orderno";
            // 
            // xrLabel7
            // 
            this.xrLabel7.LocationFloat = new DevExpress.Utils.PointFloat(303.5417F, 192.125F);
            this.xrLabel7.Name = "xrLabel7";
            this.xrLabel7.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel7.SizeF = new System.Drawing.SizeF(61.45831F, 23F);
            this.xrLabel7.Text = "订单：";
            // 
            // xlbl_supplier
            // 
            this.xlbl_supplier.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_supplier.LocationFloat = new DevExpress.Utils.PointFloat(122.2917F, 192.125F);
            this.xlbl_supplier.Name = "xlbl_supplier";
            this.xlbl_supplier.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_supplier.SizeF = new System.Drawing.SizeF(165.625F, 23F);
            this.xlbl_supplier.StylePriority.UseFont = false;
            this.xlbl_supplier.Text = "xlbl_supplier";
            // 
            // xlbl_count
            // 
            this.xlbl_count.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_count.LocationFloat = new DevExpress.Utils.PointFloat(380.625F, 157.5833F);
            this.xlbl_count.Name = "xlbl_count";
            this.xlbl_count.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_count.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xlbl_count.StylePriority.UseFont = false;
            this.xlbl_count.Text = "xlbl_count";
            // 
            // xlbl_unit
            // 
            this.xlbl_unit.LocationFloat = new DevExpress.Utils.PointFloat(380.625F, 133.4167F);
            this.xlbl_unit.Name = "xlbl_unit";
            this.xlbl_unit.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_unit.SizeF = new System.Drawing.SizeF(99.99994F, 23F);
            this.xlbl_unit.Text = "数量：";
            // 
            // xrLabel5
            // 
            this.xrLabel5.LocationFloat = new DevExpress.Utils.PointFloat(380.625F, 87.41671F);
            this.xrLabel5.Name = "xrLabel5";
            this.xrLabel5.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel5.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xrLabel5.Text = "批次：";
            // 
            // xlbl_batchno
            // 
            this.xlbl_batchno.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_batchno.LocationFloat = new DevExpress.Utils.PointFloat(380.625F, 110.4167F);
            this.xlbl_batchno.Name = "xlbl_batchno";
            this.xlbl_batchno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_batchno.SizeF = new System.Drawing.SizeF(100F, 23F);
            this.xlbl_batchno.StylePriority.UseFont = false;
            this.xlbl_batchno.Text = "xlbl_batchno";
            // 
            // xlbl_stockname
            // 
            this.xlbl_stockname.LocationFloat = new DevExpress.Utils.PointFloat(122.2917F, 56.00001F);
            this.xlbl_stockname.Name = "xlbl_stockname";
            this.xlbl_stockname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_stockname.SizeF = new System.Drawing.SizeF(165.625F, 23F);
            this.xlbl_stockname.StylePriority.UseTextAlignment = false;
            this.xlbl_stockname.Text = "xlbl_stockname";
            this.xlbl_stockname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xlbl_stockno
            // 
            this.xlbl_stockno.Font = new System.Drawing.Font("Times New Roman", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_stockno.LocationFloat = new DevExpress.Utils.PointFloat(122.2917F, 21.54169F);
            this.xlbl_stockno.Name = "xlbl_stockno";
            this.xlbl_stockno.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_stockno.SizeF = new System.Drawing.SizeF(165.625F, 34.45834F);
            this.xlbl_stockno.StylePriority.UseFont = false;
            this.xlbl_stockno.StylePriority.UseTextAlignment = false;
            this.xlbl_stockno.Text = "xlbl_stockno";
            this.xlbl_stockno.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel4
            // 
            this.xrLabel4.LocationFloat = new DevExpress.Utils.PointFloat(46.25002F, 192.125F);
            this.xrLabel4.Name = "xrLabel4";
            this.xrLabel4.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel4.SizeF = new System.Drawing.SizeF(76.04165F, 23F);
            this.xrLabel4.Text = "供应商：";
            // 
            // xrLine2
            // 
            this.xrLine2.LocationFloat = new DevExpress.Utils.PointFloat(46.25002F, 180.5833F);
            this.xrLine2.Name = "xrLine2";
            this.xrLine2.SizeF = new System.Drawing.SizeF(473.9583F, 11.54167F);
            // 
            // xbarcode
            // 
            this.xbarcode.AutoModule = true;
            this.xbarcode.LocationFloat = new DevExpress.Utils.PointFloat(46.25002F, 87.41671F);
            this.xbarcode.Name = "xbarcode";
            this.xbarcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xbarcode.SizeF = new System.Drawing.SizeF(318.75F, 78.20834F);
            this.xbarcode.StylePriority.UseTextAlignment = false;
            this.xbarcode.Symbology = code128Generator1;
            this.xbarcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrLabel2
            // 
            this.xrLabel2.LocationFloat = new DevExpress.Utils.PointFloat(46.25002F, 56.00004F);
            this.xrLabel2.Name = "xrLabel2";
            this.xrLabel2.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel2.SizeF = new System.Drawing.SizeF(76.04166F, 23.00001F);
            this.xrLabel2.StylePriority.UseTextAlignment = false;
            this.xrLabel2.Text = "物料号：";
            this.xrLabel2.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLabel1
            // 
            this.xrLabel1.LocationFloat = new DevExpress.Utils.PointFloat(46.25002F, 33.00002F);
            this.xrLabel1.Name = "xrLabel1";
            this.xrLabel1.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xrLabel1.SizeF = new System.Drawing.SizeF(76.04166F, 23F);
            this.xrLabel1.StylePriority.UseTextAlignment = false;
            this.xrLabel1.Text = "物料：";
            this.xrLabel1.TextAlignment = DevExpress.XtraPrinting.TextAlignment.BottomLeft;
            // 
            // xrLine1
            // 
            this.xrLine1.LocationFloat = new DevExpress.Utils.PointFloat(46.25002F, 79.00002F);
            this.xrLine1.Name = "xrLine1";
            this.xrLine1.SizeF = new System.Drawing.SizeF(473.9583F, 8.416679F);
            // 
            // TopMargin
            // 
            this.TopMargin.HeightF = 100F;
            this.TopMargin.Name = "TopMargin";
            this.TopMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.TopMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // BottomMargin
            // 
            this.BottomMargin.HeightF = 100F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // repStock
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLine xrLine1;
        private DevExpress.XtraReports.UI.XRLabel xrLabel2;
        private DevExpress.XtraReports.UI.XRLabel xrLabel1;
        private DevExpress.XtraReports.UI.XRLine xrLine2;
        private DevExpress.XtraReports.UI.XRBarCode xbarcode;
        private DevExpress.XtraReports.UI.XRLabel xrLabel4;
        private DevExpress.XtraReports.UI.XRLabel xlbl_stockno;
        private DevExpress.XtraReports.UI.XRLabel xlbl_stockname;
        private DevExpress.XtraReports.UI.XRLabel xlbl_batchno;
        private DevExpress.XtraReports.UI.XRLabel xrLabel5;
        private DevExpress.XtraReports.UI.XRLabel xlbl_count;
        private DevExpress.XtraReports.UI.XRLabel xlbl_unit;
        private DevExpress.XtraReports.UI.XRLabel xlbl_supplier;
        private DevExpress.XtraReports.UI.XRLabel xlbl_orderno;
        private DevExpress.XtraReports.UI.XRLabel xrLabel7;
        private DevExpress.XtraReports.UI.XRLabel xlbl_suppliername;
    }
}
