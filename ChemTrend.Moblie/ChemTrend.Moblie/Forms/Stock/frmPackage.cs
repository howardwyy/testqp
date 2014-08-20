using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.RW;
using BarcodeModel.API;
using ChemTrend.Moblie.Data;
using BarcodeModel.MODEL.Barcode.RW.Operation;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmPackage : ChemTrend.Moblie.Forms.Base.BaseTForm
    {

        public string PackingID { get; set; }
        public string[] Barcodes { get; set; }
        private List<string> listBarcode { set; get; }
        public frmPackage()
        {
            InitializeComponent();
        }

        private void frmPackage_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "装箱";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
            base.ucAction.Click += new EventHandler(ucAction_Click);

            InitData();

        }
        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(PackingID))
            {
                this.tbox_package.Text = "";
                MessageBox.Show("请扫描或录入装箱条码！");
                return;
            }
            else if (listBarcode.Count <= 0)
            {
                this.tbox_barcode.Text = "";
                MessageBox.Show("请扫描或录入条码！");
                return;
            }
            ModelAPI<PackingBarcodeModel> apiPB = new ModelAPI<PackingBarcodeModel>();
            PackingBarcodeModel pbModel = new PackingBarcodeModel()
            {
                PackingID = this.PackingID,
                Barcodes = listBarcode.ToArray(),
                Status = (int)AppConfig.Packing.使用中
            };
            apiPB.Insert(pbModel);
        }




        private void InitData()
        {
            listBarcode = new List<string>();
            lv_barcode.View = View.Details;
            // Display check boxes.
            lv_barcode.CheckBoxes = false;
            // Select the item and subitems when selection is made.
            lv_barcode.FullRowSelect = true;
            this.lv_barcode.Columns.Add("条码", (int)this.lv_barcode.Width * 3 / 8, HorizontalAlignment.Center);
            this.lv_barcode.Columns.Add("物料", (int)this.lv_barcode.Width * 3 / 8, HorizontalAlignment.Center);
            this.lv_barcode.Columns.Add("负责人", (int)this.lv_barcode.Width * 2 / 8, HorizontalAlignment.Center);

            this.lv_barcode.BeginUpdate();

            this.lv_barcode.EndUpdate();
        }

        private void pbox_search_package_Click(object sender, EventArgs e)
        {
            ModelAPI<PackingModel> apiPacking = new ModelAPI<PackingModel>();
            PackingModel model = apiPacking.GetModelByID(this.tbox_package.Text, null);
            if (model.Status == (int)AppConfig.Packing.使用完)
            {
                MessageBox.Show("该装箱条码已经使用完！");
            }
            else
            {
                this.PackingID = model.ID;
            }
        }

        private void pbox_search_barcode_Click(object sender, EventArgs e)
        {
            ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
            RWBarcodeModel searchModel = new RWBarcodeModel()
            {
                ID = tbox_barcode.Text
            };
            RWBarcodeModel model = apiBarcode.GetModel(searchModel);
            tbox_barcode.Text = model.Bill;
            if (!string.IsNullOrEmpty(model.BoxID))
            {
                MessageBox.Show("该条码已经存在装箱！");
            }
            else
            {
                listBarcode.Add(model.ID);
                addItem(model);
            }
        }


        private void addItem(RWBarcodeModel model)
        {
            this.lv_barcode.BeginUpdate();
            ListViewItem lvi = new ListViewItem("");
            lvi.SubItems.Add(model.ID);
            lvi.SubItems.Add(model.StockCode);
            lvi.SubItems.Add(model.StockName);
            this.lv_barcode.Items.Add(lvi);
            this.lv_barcode.EndUpdate();
        }
        private void lv_barcode_ItemActivate(object sender, EventArgs e)
        {
            if (lv_barcode.SelectedIndices.Count >= 1)
            {
                int index = lv_barcode.SelectedIndices[0];

                ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
                RWBarcodeModel searchModel = new RWBarcodeModel()
                {
                    ID = listBarcode[index]
                };
                RWBarcodeModel model = apiBarcode.GetModel(searchModel);
                tbox_barcode.Text = model.Bill;

                frmDetails details = new frmDetails();
                details.barcode = model;
                details.Show();
            }

        }
    }
}

