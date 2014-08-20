using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode;

namespace ChemTrend.Barcode.Forms.Report
{
    public partial class repWarehouse : DevExpress.XtraReports.UI.XtraReport
    {
        public LocationModel warehouse;
        public repWarehouse()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            xlbl_locationName.Text = warehouse.LocationName;
            xbarcode.Text = warehouse.Warehouse + "--" + warehouse.Location;
            xlbl_code.Text = warehouse.Warehouse + "--" + warehouse.Location;
        }

    }
}
