using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode.RW;

namespace ChemTrend.Barcode.Report
{
    public partial class repPacking : DevExpress.XtraReports.UI.XtraReport
    {
        public PackingModel model;
        public repPacking()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            if(model !=null){
            this.xbarcode.Text = model.ID ;
            }
        }

    }
}
