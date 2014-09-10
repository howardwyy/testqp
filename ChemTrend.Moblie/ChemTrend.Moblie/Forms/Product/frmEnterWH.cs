using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.API;

namespace ChemTrend.Moblie.Forms.Product
{
    public partial class frmEnterWH :   ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        private ModelAPI<FGBarcodeModel> apiBarcode = new ModelAPI<FGBarcodeModel>();
        private FGBarcodeModel searchModel;
        private DataTable dt = new DataTable();
        private List<string> barcodes = new List<string>();
        public frmEnterWH()
        {
            InitializeComponent();
        }


        private void frmEnterWH_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "成品入库";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
        }

        private void pbox_barcode_add_Click(object sender, EventArgs e)
        {

        }

        private void tbox_barcode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbox_warehouse_KeyDown(object sender, KeyEventArgs e)
        {

        }
    }
}