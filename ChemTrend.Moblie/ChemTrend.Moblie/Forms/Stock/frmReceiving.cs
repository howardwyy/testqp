using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.RW;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW.Operation;
using ChemTrend.Moblie.Data;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmReceiving : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        public ReceiveDetailModel curReceiveDetailModel { set; get; }
        public ReceiveModel curReceiveModel { set; get; }
        public string curWH { set; get; }
        public string curBin { set; get; }

        private List<string> Barcodes = new List<string>();
        private List<RWBarcodeModel> listBarcode = new List<RWBarcodeModel>();
        private DataTable dt = new DataTable();

        //已领数量
        private decimal ReceivedCount = 0;
        //剩余数量
        private decimal ReceiveSurplusCount = 0;
        //正在领的数量
        private decimal ReceivingCount = 0;

        public frmReceiving()
        {
            InitializeComponent();
        }

        private void frmReceiving_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "领料";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
            base.ucAction.Click += new EventHandler(ucAction_Click);

            tbox_stockcode.Text = curReceiveDetailModel.StockCode;
            tbox_surplus.Text = curReceiveDetailModel.ReceivedSurplusCount + "";
            tbox_warehouse.Text = curWH;
            tbox_bin.Text = curBin;
            tbox_barcode.Focus();

            ReceiveSurplusCount = curReceiveDetailModel.ReceivedSurplusCount;

            InitData();
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


            DataGridColumnStyle firstStyle = new DataGridTextBoxColumn();//定义该列用textbox来进行渲染
            firstStyle.HeaderText = dt.Columns[0].ColumnName; ;  //列头
            firstStyle.MappingName = dt.Columns[0].ColumnName; //映射数据源的列名，很重要，否则无数据显示
            firstStyle.Width = 85; //在这里就可以对列宽进行设置了
            ts.GridColumnStyles.Add(firstStyle);


            DataGridColumnStyle secondStyle = new DataGridTextBoxColumn();
            secondStyle.HeaderText = dt.Columns[1].ColumnName; ;  //列头
            secondStyle.MappingName = dt.Columns[1].ColumnName;
            secondStyle.Width = 60;
            ts.GridColumnStyles.Add(secondStyle);


            //第四列进行列宽设定，这一列为单独设置，定义列宽为200
            DataGridColumnStyle thirdStyle = new DataGridTextBoxColumn();
            thirdStyle.HeaderText = dt.Columns[2].ColumnName; ;  //列头
            thirdStyle.MappingName = dt.Columns[2].ColumnName;
            thirdStyle.Width = 60;
            ts.GridColumnStyles.Add(thirdStyle);

            DataGridColumnStyle fourStyle = new DataGridTextBoxColumn();
            fourStyle.HeaderText = dt.Columns[3].ColumnName; ;  //列头
            fourStyle.MappingName = dt.Columns[3].ColumnName;
            fourStyle.Width = 40;
            ts.GridColumnStyles.Add(fourStyle);
            this.dg_list.TableStyles.Add(ts);


            DataGridColumnStyle fiveStyle = new DataGridTextBoxColumn();
            fiveStyle.HeaderText = dt.Columns[4].ColumnName; ;  //列头
            fiveStyle.MappingName = dt.Columns[4].ColumnName;
            fiveStyle.Width = 40;
            ts.GridColumnStyles.Add(fiveStyle);
            this.dg_list.TableStyles.Add(ts);

        }


        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.curReceiveModel.ID))
            {
                MessageBox.Show("领料单信息不能为空！");
                return;
            }
            else if (listBarcode.Count <= 0)
            {
                this.tbox_barcode.Text = "";
                this.tbox_barcode.Focus();
                MessageBox.Show("请扫描或录入条码！");
                return;
            }
            try
            {
                try
                {
                    ModelAPI<ReceiveOutWarehouseModel> apiROW = new ModelAPI<ReceiveOutWarehouseModel>();
                    ReceiveOutWarehouseModel rowModel = new ReceiveOutWarehouseModel();
                    rowModel.Remark = AppConfig.BarcodeRemark.领料出库.ToString();
                    rowModel.ReceiveID = curReceiveDetailModel.ReceiveID;
                    rowModel.ReceiveLine = curReceiveDetailModel.ID.ToString();
                    rowModel.ReceivedCount = curReceiveDetailModel.ReceivedCount + ReceivingCount;
                    ReceiveSurplusCount = curReceiveDetailModel.ReceiveCount - curReceiveDetailModel.ReceivedCount - ReceivingCount;
                    rowModel.ReceiveSurplusCount = ReceiveSurplusCount >= 0 ? ReceiveSurplusCount : 0;

                    rowModel.ReceiveStatus = "2";
                    rowModel.Warehouse = curWH;
                    rowModel.Bin = curBin;

                    //条码信息
                    List<string> Barcodes = new List<string>();
                    if (listBarcode.Count >= 1)
                    {
                        foreach (RWBarcodeModel item in listBarcode)
                        {
                            Barcodes.Add(item.ID);
                        }
                        rowModel.Barcodes = Barcodes.ToArray();

                        apiROW.Insert(rowModel);
                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("请扫描或录入条码信息！");
                    }

                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }


            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        /// <summary>
        /// 查询原材料条码
        /// </summary>
        private void FindBarcode()
        {
            if (tbox_barcode.Text.Length >= 1)
            {
                if (Barcodes.Contains(tbox_barcode.Text))
                {
                    MessageBox.Show("该条码已经存在于列表中！");
                    tbox_barcode.Text = "";
                    tbox_barcode.Focus();
                }
                else
                {
                    if (ReceiveSurplusCount > ReceivingCount)
                    {
                        try
                        {
                            ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
                            RWBarcodeModel searchModel = new RWBarcodeModel()
                            {
                                ID = tbox_barcode.Text
                            };
                            RWBarcodeModel model = apiBarcode.GetModel(searchModel);
                            if (model != null)
                            {
                                if (string.IsNullOrEmpty(model.Warehouse))
                                {
                                    MessageBox.Show("该条码已经尚未入库！");
                                }
                                else if (model.Status != 2)
                                {
                                    MessageBox.Show("该条码非入库状态！");
                                }
                                else if (curReceiveDetailModel.StockCode != model.StockCode)
                                {
                                    MessageBox.Show("该条码同领料数据不符！");
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
                            tbox_barcode.Text = "";
                            tbox_barcode.Focus();
                            MessageBox.Show(ex.Message);
                        }


                    }
                    else
                    {
                        MessageBox.Show("领料操作已经完成，不能再次领料！");
                    }


                }
            }
        }


        private void AddItem(RWBarcodeModel model)
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
            Barcodes.Add(model.ID);
            listBarcode.Add(model);
            //计算剩余数量

            ReceivingCount += model.StockUnitQty;
            tbox_surplus.Text = (ReceiveSurplusCount - ReceivingCount).ToString();
        }

        private void pbox_search_bill_Click(object sender, EventArgs e)
        {
        }

        private void tbox_bill_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void pbox_search_barcode_Click(object sender, EventArgs e)
        {
            FindBarcode();
        }

        private void tbox_barcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindBarcode();
            }

        }
    }
}