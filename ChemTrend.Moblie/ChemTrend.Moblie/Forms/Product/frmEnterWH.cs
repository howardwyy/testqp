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
using BarcodeModel.MODEL.Barcode.FG.Operation;
using ChemTrend.Moblie.Data;

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
            base.ucAction.Click += new EventHandler(ucAction_Click);
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

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
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

        private void ResetData()
        {
            dt.Clear();
            barcodes.Clear();
            tbox_bin.Text = "";
            tbox_warehouse.Text = "";
            tbox_barcode.Text = "";
            tbox_barcode.Focus();
        }

        private void AddItem(FGBarcodeModel model)
        {

            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();
            newRow["条码"] = model.ID;
            newRow["物料"] = model.StockCode;
            newRow["负责人"] = model.LastUserName;
            dt.Rows.Add(newRow);

        }

        private void FindBarcode()
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
                    searchModel = new FGBarcodeModel()
                    {
                        ID = tbox_barcode.Text
                    };
                    FGBarcodeModel model = apiBarcode.GetModel(searchModel);
                    if (model != null)
                    {
                        AddItem(model);
                        barcodes.Add(tbox_barcode.Text);
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }
        }
        private void pbox_barcode_add_Click(object sender, EventArgs e)
        {
            FindBarcode();
        }

        private void tbox_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindBarcode();
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

                    this.tbox_warehouse.Focus();
                    this.tbox_warehouse.SelectionStart = this.tbox_warehouse.Text.Length;
                }
            }
        }
    }
}