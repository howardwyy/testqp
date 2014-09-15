namespace ChemTrend.Barcode.Forms.Report
{
    partial class repWarehouse
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
            this.xlbl_locationName = new DevExpress.XtraReports.UI.XRLabel();
            this.xbarcode = new DevExpress.XtraReports.UI.XRBarCode();
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.HeightF = 296.875F;
            this.Detail.KeepTogether = true;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlbl_locationName,
            this.xbarcode});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(130.8333F, 10.00001F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(378.125F, 234.7916F);
            // 
            // xlbl_locationName
            // 
            this.xlbl_locationName.BookmarkParent = this.xrPanel1;
            this.xlbl_locationName.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_locationName.LocationFloat = new DevExpress.Utils.PointFloat(35.83323F, 34.91666F);
            this.xlbl_locationName.Name = "xlbl_locationName";
            this.xlbl_locationName.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_locationName.SizeF = new System.Drawing.SizeF(321.8751F, 30.29166F);
            this.xlbl_locationName.StylePriority.UseFont = false;
            this.xlbl_locationName.StylePriority.UseTextAlignment = false;
            this.xlbl_locationName.Text = "xlbl_locationName";
            this.xlbl_locationName.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xbarcode
            // 
            this.xbarcode.AutoModule = true;
            this.xbarcode.LocationFloat = new DevExpress.Utils.PointFloat(35.83323F, 76.66667F);
            this.xbarcode.Name = "xbarcode";
            this.xbarcode.Padding = new DevExpress.XtraPrinting.PaddingInfo(10, 10, 0, 0, 100F);
            this.xbarcode.SizeF = new System.Drawing.SizeF(320F, 80F);
            this.xbarcode.StylePriority.UseTextAlignment = false;
            this.xbarcode.Symbology = code128Generator1;
            this.xbarcode.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
            this.BottomMargin.HeightF = 101.0417F;
            this.BottomMargin.Name = "BottomMargin";
            this.BottomMargin.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.BottomMargin.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            // 
            // repWarehouse
            // 
            this.Bands.AddRange(new DevExpress.XtraReports.UI.Band[] {
            this.Detail,
            this.TopMargin,
            this.BottomMargin});
            this.Margins = new System.Drawing.Printing.Margins(100, 100, 100, 101);
            this.Version = "14.1";
            ((System.ComponentModel.ISupportInitialize)(this)).EndInit();

        }

        #endregion

        private DevExpress.XtraReports.UI.DetailBand Detail;
        private DevExpress.XtraReports.UI.TopMarginBand TopMargin;
        private DevExpress.XtraReports.UI.BottomMarginBand BottomMargin;
        private DevExpress.XtraReports.UI.XRBarCode xbarcode;
        private DevExpress.XtraReports.UI.XRPanel xrPanel1;
        private DevExpress.XtraReports.UI.XRLabel xlbl_locationName;
    }
}
