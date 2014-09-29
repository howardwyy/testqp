using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.RW;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW.Operation;
using System.Threading;
using BarcodeModel;
using ChemTrend.Moblie.Data;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmMove : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        private string bin;
        private string warehouse;
        private List<string> barcodes = new List<string>();
        private List<RWBarcodeModel> listBarcode = new List<RWBarcodeModel>();
        private DataTable dt = new DataTable();

        public frmMove()
        {
            InitializeComponent();
        }

        private void frmMove_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "移库";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
            base.ucAction.Click += new EventHandler(ucAction_Click);

            this.tbox_barcode.Focus();

            InitData();

        }
        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbox_bin.Text) || string.IsNullOrEmpty(this.tbox_warehouse.Text))
            {
                this.tbox_barcode.Text = "";
                MessageBox.Show("仓库，库位不能为空。");
                return;
            }
            else if (listBarcode.Count <= 0)
            {
                this.tbox_barcode.Text = "";
                MessageBox.Show("请扫描或录入条码！");
                return;
            }
            try
            {

                ModelAPI<MoveWarehouseModel> apiWarehouse = new ModelAPI<MoveWarehouseModel>();

                MoveWarehouseModel moveWarehouse = new MoveWarehouseModel()
                {
                    Barcodes = barcodes.ToArray(),
                    Warehouse = tbox_warehouse.Text,
                    Remark = AppConfig.BarcodeRemark.条码移库.ToString(),
                    Bin = tbox_bin.Text
                };
                apiWarehouse.Insert(moveWarehouse);
                ResetData();
                MessageBox.Show("移库成功！");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ResetData() {
            dt.Clear();
            listBarcode.Clear();
            barcodes.Clear();
            tbox_bin.Text = "";
            tbox_warehouse.Text = "";
            tbox_barcode.Text = "";
            this.tbox_warehouse.Focus();
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
            for (int i = 0; i < numColumns ; i++)
            {
                DataGridColumnStyle aColumnTextColumnStyle = new DataGridTextBoxColumn();//定义该列用textbox来进行渲染
                aColumnTextColumnStyle.HeaderText = dt.Columns[i].ColumnName; ;  //列头
                aColumnTextColumnStyle.MappingName = dt.Columns[i].ColumnName; //映射数据源的列名，很重要，否则无数据显示
                aColumnTextColumnStyle.Width = 85; //在这里就可以对列宽进行设置了
                ts.GridColumnStyles.Add(aColumnTextColumnStyle);
                this.dg_list.TableStyles.Add(ts);
            }


        }

        private void pbox_query_Click(object sender, EventArgs e)
        {
            findBarcod();
        }

        private void findBarcod()
        {

            if (tbox_barcode.Text.Length >= 1)
            {
                if (barcodes.Contains(tbox_barcode.Text))
                {
                    MessageBox.Show("该条码已经存在于列表中！");

                }
                else
                {
                    //截取前两个字符  
                    string barcode = tbox_barcode.Text;
                    string Prefix = "";
                    if (barcode.Length >= 2)
                    {
                        Prefix = barcode.Substring(0, 2);

                    }
                    List<RWBarcodeModel> Barcodes = new List<RWBarcodeModel>();
                    switch (Prefix)
                    {
                        case "RB":
                        case "RW":
                            Barcodes = BarcodeInfo.GetBarcodes(barcode).ConvertAll<RWBarcodeModel>(m => m as RWBarcodeModel); 
                            foreach (RWBarcodeModel item in Barcodes)
                            {
                                if (string.IsNullOrEmpty(item.Warehouse))
                                {
                                    MessageBox.Show(tbox_barcode.Text + "\n该条码已经尚未入库！");
                                }
                                else
                                {
                                    addItem(item);
                                }
                            }
                            break;
                        case "WH":
                            string warehouse = barcode.Remove(0, 2);
                            string[] WH = warehouse.Replace("--", "*").Split('*');
                            if (WH.Length == 2)
                            {
                                this.tbox_warehouse.Text = WH[0];
                                this.tbox_bin.Text = WH[1];

                                this.tbox_barcode.Text = "";
                                this.tbox_barcode.Focus();
                            }
                            break;
                        default:
                            MessageBox.Show("录入或扫描数据有误！");
                            break;
                    } 
                }
            }
        }


        private void addItem(RWBarcodeModel model)
        {

            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();

            newRow["条码号"] = model.ID;
            newRow["物料号"] = model.StockCode;
            newRow["数量"] = model.StockUnitQty + "";
            newRow["批次"] = model.StockBatch;
            newRow["仓库库位"] = model.Warehouse + "--" + model.Location;

            dt.Rows.Add(newRow);

            //加入到条码集合列表
            barcodes.Add(model.ID);
            listBarcode.Add(model);

            tbox_barcode.Text = "";
            tbox_barcode.Focus();
        }


        private void tbox_warehouse_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                string warehouse = tbox_warehouse.Text;
                string[] WH = warehouse.Replace("--", "*").Split('*');
                if (WH.Length == 2)
                {
                    this.tbox_warehouse.Text = WH[0];
                    this.tbox_bin.Text = WH[1];
                    this.tbox_barcode.Text = "";
                    this.tbox_barcode.Focus();
                }
            }
        }

        private void tbox_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findBarcod();
            }
        }





    }
}

