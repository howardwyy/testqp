using System;
using System.Drawing;
using System.Collections;
using System.ComponentModel;
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode.RW;

namespace ChemTrend.Barcode.Forms.Report
{
    public partial class repRW : DevExpress.XtraReports.UI.XtraReport
    {
        public RWBarcodeModel model;
        public repRW()
        {
            InitializeComponent();
        }

        private void Detail_BeforePrint(object sender, System.Drawing.Printing.PrintEventArgs e)
        {
            this.xlbl_stockname.Text = model.StockName;
            this.xlbl_stockno.Text = model.StockCode;
            this.xlbl_batchno.Text = model.StockBatch;
            this.xlbl_unit.Text = "数量：(" + model.StockUnit + ")";
            this.xlbl_count.Text = model.StockUnitQty+"";
            this.xlbl_supplier.Text = model.SupplierCode;
            this.xlbl_suppliername.Text = model.SupplierName;
            this.xlbl_orderno.Text = model.SO;
            this.xbarcode.Text = model.ID;
        }

    }
}
