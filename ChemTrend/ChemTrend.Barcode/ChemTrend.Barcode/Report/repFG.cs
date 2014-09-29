using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode.FG;

namespace ChemTrend.Barcode.Report
{
    public partial class repFG : DevExpress.XtraReports.UI.XtraReport
    {
        public FGBarcodeModel model { set; get; }
        public repFG()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.xlbl_stockname.Text = model.StockName;
            this.xlbl_stockcode.Text = model.StockCode;
            this.xlbl_batch.Text = model.StockBatch;
            this.xlbl_unitqty.Text = "数量：(" + model.UnitQty + ")";
            this.xlbl_checktime.Text = "";
            this.xlbl_time1.Text = model.EXPTime.ToString("yyyy-MM-dd");
            this.xlbl_remark.Text = model.Remark1;
            this.xrBarCode1.Text = model.ID;
            this.xlbl_orderno.Text = model.WO;
        }

    }
}
