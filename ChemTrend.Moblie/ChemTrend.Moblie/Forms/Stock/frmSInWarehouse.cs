using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmSInWarehouse : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
        RWBarcodeModel searchModel;
        public frmSInWarehouse()
        {
            InitializeComponent();
        }

        private void frmSInWarehouse_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "原材料入库";
            base.ucAction.Visible = true;
            base.ucAction.initString( "提交");
            base.ucAction.Click += new EventHandler(ucAction_Click);

        }

        private void tbox_barcode_TextChanged(object sender, EventArgs e)
        {
            searchModel = new RWBarcodeModel() {
                   ID = tbox_barcode.Text
            };
            RWBarcodeModel model  = apiBarcode.GetModel(searchModel);
        }

        private void tbox_warehouse_TextChanged(object sender, EventArgs e)
        {

        }

        private void ucAction_Click(object sender, EventArgs e)
        {
            
        }

        private void pbox_barcode_add_Click(object sender, EventArgs e)
        {
            searchModel = new RWBarcodeModel()
            {
                ID = tbox_barcode.Text
            };
            RWBarcodeModel model = apiBarcode.GetModel(searchModel);
            tbox_barcode.Text = model.Bill;
            MessageBox.Show(model.Bill);
        }
    }
}

