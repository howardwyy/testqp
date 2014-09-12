using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;

namespace ChemTrend.Barcode.Report
{
    public partial class repFGPackage : DevExpress.XtraReports.UI.XtraReport
    {
        public BarcodeModel.MODEL.Barcode.FG.FGPackageModel model { get; set; }
        public repFGPackage()
        {
            InitializeComponent();
        }


    }
}
