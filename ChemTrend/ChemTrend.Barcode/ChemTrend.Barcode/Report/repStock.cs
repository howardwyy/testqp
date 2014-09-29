using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Data;

namespace ChemTrend.Barcode.Report
{
    public partial class repStock : DevExpress.XtraReports.UI.XtraReport
    {
        public string StockName { set; get; }
        public string StockCode { set; get; }


        public repStock()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            InitRep();
        }

        private void InitRep()
        {
            this.xbarcode.Text = AppConfig.BarcodeType.ST.ToString() + StockCode;
            this.xlbl_stockname.Text = StockName;
        }

    }
}
