using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Data;

namespace ChemTrend.Barcode.Report
{
    public partial class repWorkCenter : DevExpress.XtraReports.UI.XtraReport
    {
        public string WorkCenterCode { set; get; }
        public string WorkCenterName { set; get; }
        public repWorkCenter()
        {
            InitializeComponent();
        }

        private void InitRpt()
        {
            this.xbarcode.Text =AppConfig.BarcodeType.WC.ToString() + WorkCenterCode;
            this.xlbl_wcname.Text = WorkCenterName;
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            InitRpt();
        }

    }
}
