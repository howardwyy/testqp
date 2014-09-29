using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode;
using ChemTrend.Barcode.Data;

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
            if (warehouse != null)
            {
                xlbl_locationName.Text = warehouse.LocationName;
                xbarcode.Text =AppConfig.BarcodeType.WH.ToString() + warehouse.Warehouse + "--" + warehouse.Location;
            }
        }

    }
}
