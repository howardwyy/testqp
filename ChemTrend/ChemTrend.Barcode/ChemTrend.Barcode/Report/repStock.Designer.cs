﻿namespace ChemTrend.Barcode.Report
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
            this.TopMargin = new DevExpress.XtraReports.UI.TopMarginBand();
            this.BottomMargin = new DevExpress.XtraReports.UI.BottomMarginBand();
            this.xlbl_stockname = new DevExpress.XtraReports.UI.XRLabel();
            this.xrPanel1 = new DevExpress.XtraReports.UI.XRPanel();
            this.xlbl_stocktitle = new DevExpress.XtraReports.UI.XRLabel();
            this.xbarcode = new DevExpress.XtraReports.UI.XRBarCode();
            ((System.ComponentModel.ISupportInitialize)(this)).BeginInit();
            // 
            // Detail
            // 
            this.Detail.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xrPanel1});
            this.Detail.HeightF = 234.7916F;
            this.Detail.Name = "Detail";
            this.Detail.Padding = new DevExpress.XtraPrinting.PaddingInfo(0, 0, 0, 0, 100F);
            this.Detail.TextAlignment = DevExpress.XtraPrinting.TextAlignment.TopLeft;
            this.Detail.BeforePrint += new System.Drawing.Printing.PrintEventHandler(this.Detail_BeforePrint);
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
            // xlbl_stockname
            // 
            this.xlbl_stockname.BookmarkParent = this.xrPanel1;
            this.xlbl_stockname.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_stockname.LocationFloat = new DevExpress.Utils.PointFloat(35.83323F, 173.6666F);
            this.xlbl_stockname.Name = "xlbl_stockname";
            this.xlbl_stockname.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_stockname.SizeF = new System.Drawing.SizeF(321.8751F, 30.29166F);
            this.xlbl_stockname.StylePriority.UseFont = false;
            this.xlbl_stockname.StylePriority.UseTextAlignment = false;
            this.xlbl_stockname.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
            // 
            // xrPanel1
            // 
            this.xrPanel1.Controls.AddRange(new DevExpress.XtraReports.UI.XRControl[] {
            this.xlbl_stockname,
            this.xlbl_stocktitle,
            this.xbarcode});
            this.xrPanel1.LocationFloat = new DevExpress.Utils.PointFloat(137.5F, 0F);
            this.xrPanel1.Name = "xrPanel1";
            this.xrPanel1.SizeF = new System.Drawing.SizeF(378.125F, 234.7916F);
            // 
            // xlbl_stocktitle
            // 
            this.xlbl_stocktitle.BookmarkParent = this.xrPanel1;
            this.xlbl_stocktitle.Font = new System.Drawing.Font("Times New Roman", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.xlbl_stocktitle.LocationFloat = new DevExpress.Utils.PointFloat(35.83323F, 34.91666F);
            this.xlbl_stocktitle.Name = "xlbl_stocktitle";
            this.xlbl_stocktitle.Padding = new DevExpress.XtraPrinting.PaddingInfo(2, 2, 0, 0, 100F);
            this.xlbl_stocktitle.SizeF = new System.Drawing.SizeF(321.8751F, 30.29166F);
            this.xlbl_stocktitle.StylePriority.UseFont = false;
            this.xlbl_stocktitle.StylePriority.UseTextAlignment = false;
            this.xlbl_stocktitle.Text = "Stock";
            this.xlbl_stocktitle.TextAlignment = DevExpress.XtraPrinting.TextAlignment.MiddleCenter;
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
        private DevExpress.XtraReports.UI.XRLabel xlbl_stockname;
        private DevExpress.XtraReports.UI.XRLabel xlbl_stocktitle;
        private DevExpress.XtraReports.UI.XRBarCode xbarcode;
    }
}
