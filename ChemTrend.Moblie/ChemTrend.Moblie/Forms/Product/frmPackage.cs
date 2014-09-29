using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.MODEL.Barcode.FG.Operation;
using BarcodeModel.API;
using ChemTrend.Moblie.Data;

namespace ChemTrend.Moblie.Forms.Product
{
    public partial class frmPackage : ChemTrend.Moblie.Forms.Base.BaseTForm
    {

        public string PackingID { get; set; }
        public string[] Barcodes { get; set; }
        private List<FGBarcodeModel> listBarcode = new List<FGBarcodeModel>();

        //应用于保存，条码信息
        private DataTable dt = new DataTable();

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

            this.tbox_package.Focus();

            InitData();

        }
        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbox_package.Text))
            {
                this.tbox_package.Text = "";
                this.tbox_package.Focus();
                MessageBox.Show("请扫描或录入装箱条码！");
                return;
            }
            else if (listBarcode.Count <= 0)
            {
                this.tbox_barcode.Text = "";
                this.tbox_barcode.Focus();
                MessageBox.Show("请扫描或录入条码！");
                return;
            }
            List<string> barcodeList = new List<string>();
            foreach (FGBarcodeModel rw in listBarcode)
            {
                barcodeList.Add(rw.ID);
            }
            try
            {
                ModelAPI<PackingFGModel> apiPB = new ModelAPI<PackingFGModel>();
                PackingFGModel pbModel = new PackingFGModel()
                {
                    PackingID = this.tbox_package.Text,
                    Barcodes = barcodeList.ToArray(),
                    Status = (int)AppConfig.Packing.使用中
                };
                apiPB.Insert(pbModel);
                ResetData();
                MessageBox.Show("装箱成功！");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ResetData()
        {

            this.tbox_package.Focus();
            this.tbox_package.Text = "";
            this.tbox_barcode.Text = "";
            this.dt.Clear();
            this.tbox_package.Focus();
        }


        private void InitData()
        {

            dg_list.DataSource = dt;

            dt.Columns.Add("条码号", typeof(string));
            dt.Columns.Add("物料号", typeof(string));
            dt.Columns.Add("数量", typeof(string));
            dt.Columns.Add("批次", typeof(string));
            dt.Columns.Add("仓库库位", typeof(string));
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = dt.TableName;

            //分别对列进行渲染，其中前三列用for循环实现，对列宽进行设定，值为75
            int numColumns = dt.Columns.Count;
            for (int i = 0; i < numColumns; i++)
            {
                DataGridColumnStyle aColumnTextColumnStyle = new DataGridTextBoxColumn();//定义该列用textbox来进行渲染
                aColumnTextColumnStyle.HeaderText = dt.Columns[i].ColumnName; ;  //列头
                aColumnTextColumnStyle.MappingName = dt.Columns[i].ColumnName; //映射数据源的列名，很重要，否则无数据显示
                aColumnTextColumnStyle.Width = 85; //在这里就可以对列宽进行设置了
                ts.GridColumnStyles.Add(aColumnTextColumnStyle);
                this.dg_list.TableStyles.Add(ts);
            }



        }

        private void FindBarcod()
        {
            if (tbox_barcode.Text.Length >= 1)
            {
                try
                {
                ModelAPI<FGBarcodeModel> apiBarcode = new ModelAPI<FGBarcodeModel>();
                FGBarcodeModel searchModel = new FGBarcodeModel()
                {
                    ID = tbox_barcode.Text
                };
                FGBarcodeModel model = apiBarcode.GetModel(searchModel);
                if (model != null)
                {
                    tbox_barcode.Text = model.Bill;
                    if (!string.IsNullOrEmpty(model.BoxID))
                    {
                        MessageBox.Show("该条码已经存在装箱！");
                    }
                    else
                    {
                        AddItem(model);
                    }
                    tbox_barcode.Text = "";
                    tbox_barcode.Focus();
                }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }


        private void AddItem(FGBarcodeModel model)
        {

            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();


            newRow["条码号"] = model.ID;
            newRow["物料号"] = model.StockCode;
            newRow["数量"] = model.UnitQty + "";
            newRow["批次"] = model.StockBatch;
            newRow["仓库库位"] = model.Warehouse + "--" + model.Bin;
            dt.Rows.Add(newRow);

            //加入到条码集合列表
            listBarcode.Add(model);
        }

        /// <summary>
        /// 核查装箱条码
        /// </summary>
        private void CheckPackage()
        {
            try
            {
                ModelAPI<FGPackageModel> apiPackage = new ModelAPI<FGPackageModel>();
                FGPackageModel model = apiPackage.GetModelByID(this.tbox_package.Text, null);
                if (model.Status == (int)AppConfig.Packing.使用完)
                {
                    MessageBox.Show("该装箱条码已经使用完！");
                    this.tbox_package.Text = "";
                    this.tbox_package.Focus();
                }
                else
                {
                    this.PackingID = model.ID;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void pbox_search_barcode_Click(object sender, EventArgs e)
        {
            FindBarcod();
        }

        private void pbox_search_package_Click(object sender, EventArgs e)
        {
            CheckPackage();
        }

        private void tbox_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindBarcod();
            }
        }

        private void tbox_package_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                CheckPackage();
            }
        }

    }
}