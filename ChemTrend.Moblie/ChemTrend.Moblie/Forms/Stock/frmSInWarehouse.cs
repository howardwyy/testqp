﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW;
using BarcodeModel.MODEL.Barcode.RW.Operation;
using ChemTrend.Moblie.Data;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmSInWarehouse : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        private ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
        private RWBarcodeModel searchModel;
        private DataTable dt = new DataTable();
        private List<string> barcodes = new List<string>();
        public frmSInWarehouse()
        {
            InitializeComponent();
        }

        private void frmSInWarehouse_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "原材料入库";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
            base.ucAction.Click += new EventHandler(ucAction_Click);

            this.tbox_barcode.Focus();
            InitData();
        }


        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbox_bin.Text) || string.IsNullOrEmpty(tbox_warehouse.Text))
            {
                MessageBox.Show("仓库，库位不能为空。");
            }
            else if (barcodes.Count <= 0)
            {
                this.tbox_barcode.Text = "";
                MessageBox.Show("请扫描或录入条码！");
                return;
            }
            try
            {
                ModelAPI<EnterWarehouseModel> apiWarehouse = new ModelAPI<EnterWarehouseModel>();
                EnterWarehouseModel enterWarehouse = new EnterWarehouseModel()
                {
                    Barcodes = barcodes.ToArray(),
                    Warehouse = tbox_warehouse.Text,
                    Remark = AppConfig.BarcodeRemark.条码入库.ToString(),
                    Bin = tbox_bin.Text
                };
                apiWarehouse.Insert(enterWarehouse);
                ResetData();
                MessageBox.Show("入库成功！");

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ResetData()
        {
            dt.Clear();
            barcodes.Clear();
            tbox_bin.Text = "";
            tbox_warehouse.Text = "";
            tbox_barcode.Text = "";
            this.tbox_warehouse.Focus();
        }


        private void pbox_barcode_add_Click(object sender, EventArgs e)
        {
            findBarcode();

        }


        private void InitData()
        {

            dg_list.DataSource = dt;

            dt.Columns.Add("条码号", typeof(string));
            dt.Columns.Add("物料号", typeof(string));
            dt.Columns.Add("数量", typeof(string));
            dt.Columns.Add("批次", typeof(string));

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
            this.dg_list.TableStyles.Add(ts);

        }
        private void addItem(RWBarcodeModel model)
        {

            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();
            newRow["条码号"] = model.ID;
            newRow["物料号"] = model.StockCode;
            newRow["数量"] = model.StockUnitQty + "";
            newRow["批次"] = model.StockBatch;
            dt.Rows.Add(newRow);


            barcodes.Add(tbox_barcode.Text);

            this.tbox_barcode.Text = "";
            this.tbox_barcode.Focus();

        }

        private void findBarcode()
        {
            if (string.IsNullOrEmpty(tbox_barcode.Text))
            {
                MessageBox.Show("条码标签不能为空。");
                tbox_barcode.Focus();
            }
            else if (barcodes.Contains(tbox_barcode.Text))
            {
                MessageBox.Show(tbox_barcode.Text + "\n该条码标签已经存在！");
                tbox_barcode.Text = "";
                tbox_barcode.Focus();
            }
            else
            {
                try
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
                            Barcodes = BarcodeInfo.GetBarcodes(barcode).ConvertAll<RWBarcodeModel>(m => m as RWBarcodeModel); ;
                            foreach (RWBarcodeModel item in Barcodes)
                            {
                                if (string.IsNullOrEmpty(item.Warehouse))
                                {
                                    addItem(item);
                                }
                                else
                                {
                                    MessageBox.Show(tbox_barcode.Text + "\n该条码标签已入库！");
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
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void tbox_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                findBarcode();
            }
        }

        private void tbox_warehouse_KeyDown(object sender, KeyEventArgs e)
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
    }
}

