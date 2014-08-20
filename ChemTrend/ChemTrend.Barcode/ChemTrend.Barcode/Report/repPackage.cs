using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode.RW;

namespace ChemTrend.Barcode.Forms.Report
{
    public partial class repPackage : DevExpress.XtraReports.UI.XtraReport
    {

        public PackingModel packing;
        public repPackage()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xbarcode.Text = packing.ID;
            xlbl_code.Text = packing.ID;
        }
    }
}
