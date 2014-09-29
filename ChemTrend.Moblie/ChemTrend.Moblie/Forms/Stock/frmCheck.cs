using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW;
using ChemTrend.Moblie.Data;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmCheck : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        private DataTable dt = new DataTable();

        public frmCheck()
        {
            InitializeComponent();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            mTitle.Text = "盘点";
            base.ucAction.Visible = false;
            base.ucAction.initString("提交");


            this.tbox_barcode.Focus();

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

        private void pbox_search_Click(object sender, EventArgs e)
        {
            findBarcod();
        }

        private void findBarcod()
        {
            if (tbox_barcode.Text.Length >= 1)
            {

                try
                {
                    ModelAPI<CheckModel> apiCheck = new ModelAPI<CheckModel>();
                    CheckModel searchCheckModel = new CheckModel()
                    {
                        BarcodeID = tbox_barcode.Text
                    };

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
                            Barcodes = BarcodeInfo.GetBarcodes(barcode).ConvertAll<RWBarcodeModel>(m => m as RWBarcodeModel); ;
                            foreach (RWBarcodeModel item in Barcodes)
                            {
                                if (string.IsNullOrEmpty(item.Warehouse))
                                {
                                    MessageBox.Show(tbox_barcode.Text + "\n该条码已经尚未入库！");
                                }
                                else
                                {
                                    CheckModel checkModel = null;
                                    try
                                    {
                                        checkModel = apiCheck.GetModel(searchCheckModel);
                                    }
                                    catch (Exception)
                                    {
                                        checkModel = null;
                                    }
                                    if (checkModel != null)
                                    {
                                        MessageBox.Show(this.tbox_barcode.Text + "\n该条码已经盘点过了！");
                                        this.tbox_barcode.Text = "";
                                        this.tbox_barcode.Focus();
                                    }
                                    else
                                    {
                                        List<RWBarcodeModel> RWBarcodes = BarcodeInfo.GetBarcodes(tbox_barcode.Text).ConvertAll<RWBarcodeModel>(m => m as RWBarcodeModel);
                                        foreach (RWBarcodeModel model in RWBarcodes)
                                        {
                                            if (model != null)
                                            {
                                                addItem(model);
                                            }
                                            searchCheckModel.PlanID = "";
                                            searchCheckModel.BarcodeID = tbox_barcode.Text;
                                            searchCheckModel.CreateTime = System.DateTime.Now;
                                            apiCheck.Insert(searchCheckModel);
                                        }

                                        this.tbox_barcode.Text = "";
                                        this.tbox_barcode.Focus();
                                    }

                                }
                            }
                            break;
                        default:
                            MessageBox.Show("录入或扫描数据有误！");
                            break;
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
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

        }

        private void tbox_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findBarcod();
            }
        }

        private void frmCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void dg_list_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = ((DataGrid)sender).CurrentCell.RowNumber;

            MessageBox.Show("你选中的行号为：" + Convert.ToInt32(index));
        }

    }
}

