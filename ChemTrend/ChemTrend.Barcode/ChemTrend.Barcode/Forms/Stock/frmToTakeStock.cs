using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmToTakeStock : DevExpress.XtraEditors.XtraForm
    {
        public frmToTakeStock()
        {
            InitializeComponent();
        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {
            ModelAPI<CheckModel> apiCheck = new ModelAPI<CheckModel>();
            CheckModel searchCheckModel = new CheckModel()
            {
                BarcodeID = "RW0100000082"
            };

            CheckModel checkModel = apiCheck.GetModel(searchCheckModel);
            if (checkModel != null)
            {
                MessageBox.Show("该条码已经盘点过了！");
            }
            else
            {
                ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
                RWBarcodeModel searchModel = new RWBarcodeModel()
                {
                    ID = "RW0100000082"
                };
                RWBarcodeModel model = apiBarcode.GetModel(searchModel);
                if (model != null)
                {
                    MessageBox.Show(model.ID);
                }
                //searchCheckModel.PlanID = "";
                //searchCheckModel.BarcodeID = tbox_barcode.Text;
                //searchCheckModel.CreateTime = System.DateTime.Now;
                //apiCheck.Insert(searchCheckModel);
                 
            }
        }

        private void sbtn_reset_Click(object sender, EventArgs e)
        {
            ModelAPI<CheckModel> apiCheck = new ModelAPI<CheckModel>();
        }
    }
}