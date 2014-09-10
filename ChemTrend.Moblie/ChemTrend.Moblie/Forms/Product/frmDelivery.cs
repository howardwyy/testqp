using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.FG.Operation;

namespace ChemTrend.Moblie.Forms.Product
{
    public partial class frmDelivery : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        private string bin;
        private string warehouse;
        private List<string> barcodes = new List<string>();
        private List<FGBarcodeModel> listBarcode = new List<FGBarcodeModel>();
        private DataTable dt = new DataTable();
        public frmDelivery()
        {
            InitializeComponent();
        }

        private void frmDelivery_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "发往客户";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");

            base.ucAction.Click += new EventHandler(ucAction_Click);


            InitData();

        }
        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbox_delivery.Text) )
            {
                this.tbox_delivery.Text = "";
                MessageBox.Show("发货单不能为空。");
                return;
            }
            else if (listBarcode.Count <= 0)
            {
                this.tbox_delivery.Text = "";
                MessageBox.Show("请扫描或录入条码！");
                return;
            }
            try
            {

                ModelAPI<DeliveryBarcodeModel> apiDelivery = new ModelAPI<DeliveryBarcodeModel>();

                DeliveryBarcodeModel deliveryBarcode = new DeliveryBarcodeModel()
                {
                    Barcodes = barcodes.ToArray(), 
                    DeliveryID = tbox_delivery.Text
                };
                apiDelivery.Insert(deliveryBarcode);
                ResetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ResetData()
        {
            dt.Clear();
            listBarcode.Clear();
            barcodes.Clear();
            tbox_barcode.Text = "";
            tbox_delivery.Text = "";
            tbox_delivery.Focus();
        }

        private void InitData()
        {

            dg_list.DataSource = dt;

            dt.Columns.Add("条码", typeof(string));
            dt.Columns.Add("物料", typeof(string));
            dt.Columns.Add("负责人", typeof(string));
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = dt.TableName;

            //分别对列进行渲染，其中前三列用for循环实现，对列宽进行设定，值为75
            int numColumns = dt.Columns.Count;
            for (int i = 0; i < numColumns - 1; i++)
            {
                DataGridColumnStyle aColumnTextColumnStyle = new DataGridTextBoxColumn();//定义该列用textbox来进行渲染
                aColumnTextColumnStyle.HeaderText = dt.Columns[i].ColumnName; ;  //列头
                aColumnTextColumnStyle.MappingName = dt.Columns[i].ColumnName; //映射数据源的列名，很重要，否则无数据显示
                aColumnTextColumnStyle.Width = 85; //在这里就可以对列宽进行设置了
                ts.GridColumnStyles.Add(aColumnTextColumnStyle);
                this.dg_list.TableStyles.Add(ts);
            }
            //第四列进行列宽设定，这一列为单独设置，定义列宽为200
            DataGridColumnStyle newStyle = new DataGridTextBoxColumn();
            newStyle.HeaderText = dt.Columns[2].ColumnName; ;  //列头
            newStyle.MappingName = dt.Columns[2].ColumnName;
            newStyle.Width = 160;
            ts.GridColumnStyles.Add(newStyle);
            this.dg_list.TableStyles.Add(ts);


        }

        private void pbox_query_Click(object sender, EventArgs e)
        {
            FindBarcod();
        }

        private void FindBarcod()
        {
            if (tbox_delivery.Text.Length >= 1)
            {
                if (barcodes.Contains(tbox_delivery.Text))
                {
                    MessageBox.Show("该条码已经存在于列表中！");

                }
                else
                {
                    ModelAPI<FGBarcodeModel> apiBarcode = new ModelAPI<FGBarcodeModel>();
                    FGBarcodeModel searchModel = new FGBarcodeModel()
                    {
                        ID = tbox_delivery.Text
                    };
                    FGBarcodeModel model = apiBarcode.GetModel(searchModel);
                    if (model != null)
                    {
                        if (string.IsNullOrEmpty(model.Warehouse))
                        {
                            MessageBox.Show("该条码已经尚未入库！");
                        }
                        else
                        {
                            AddItem(model);
                        }
                        tbox_delivery.Text = "";
                        tbox_delivery.Focus();
                    }
                }
            }
        }


        private void AddItem(FGBarcodeModel model)
        {

            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();
            newRow["条码"] = model.ID;
            newRow["物料"] = model.StockCode;
            newRow["负责人"] = model.LastUserName;
            dt.Rows.Add(newRow);

            //加入到条码集合列表
            barcodes.Add(model.ID);
            listBarcode.Add(model);
        }

        private void pbox_delivery_Click(object sender, EventArgs e)
        {

        }
    }
}

