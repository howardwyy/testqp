using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.RW;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmDetails : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        public RWBarcodeModel barcode { set; get; }
        public frmDetails()
        {
            InitializeComponent();
        }

        private void frmDetails_Load(object sender, EventArgs e)
        {
            mTitle.Text = "条码详情";

            if (barcode != null) {
                lbl_barcode.Text = barcode.ID;
                lbl_bin.Text = barcode.Warehouse + " " + barcode.LastLocation;
                lbl_batch.Text = barcode.StockBatch;
                lbl_stockcode.Text = barcode.StockCode;
                lbl_count.Text = barcode.StockUnitQty +" "+barcode.StockUnit ;

                lbl_supplier.Text = barcode.SupplierName;
                lbl_remark.Text = barcode.Remark1;
            }
        }
    }
}

