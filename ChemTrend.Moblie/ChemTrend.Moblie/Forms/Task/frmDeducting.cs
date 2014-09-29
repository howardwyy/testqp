using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.WORP;
using BarcodeModel.MODEL.Barcode.RW;
using BarcodeModel.MODEL.Barcode.WORP.Operation;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.FG;

namespace ChemTrend.Moblie.Forms.Task
{
    public partial class frmDeducting : ChemTrend.Moblie.Forms.Base.BaseTForm
    {

        public ReportModel curReportModel { set; get; }
        public RWBarcodeModel curRWBarcodeModel { set; get; }

        private List<string> Barcodes = new List<string>();
        private List<RWBarcodeModel> listBarcode = new List<RWBarcodeModel>();
        private DataTable dt = new DataTable();

        public frmDeducting()
        {
            InitializeComponent();
        }

        private void frmDeducting_Load(object sender, EventArgs e)
        {

            base.mTitle.Text = "扣料";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
            base.ucAction.Click += new EventHandler(ucAction_Click);

            tbox_stockcode.Text = curReportModel.StockCode;
            tbox_deqty.Text = curReportModel.DeQTY + "";
            tbox_haddeqty.Text = curReportModel.HadDeQTY + "";
            tbox_surplus.Text = (curReportModel.DeQTY - curReportModel.HadDeQTY).ToString();
            tbox_barcode.Focus();


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
            int numColumns = dt.Columns.Count;
            for (int i = 0; i < numColumns; i++)
            {

                DataGridColumnStyle firstStyle = new DataGridTextBoxColumn();//定义该列用textbox来进行渲染
                firstStyle.HeaderText = dt.Columns[i].ColumnName; ;  //列头
                firstStyle.MappingName = dt.Columns[i].ColumnName; //映射数据源的列名，很重要，否则无数据显示
                firstStyle.Width = 85; //在这里就可以对列宽进行设置了
                ts.GridColumnStyles.Add(firstStyle);
            }

        }


        private void AddItem(RWBarcodeModel model)
        {
            dt.Clear();
            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();

            newRow["条码号"] = model.ID;
            newRow["物料号"] = model.StockCode;
            newRow["数量"] = model.StockUnitQty + "";
            newRow["批次"] = model.StockBatch;
            newRow["仓库库位"] = model.Warehouse + "--" + model.Location;
            dt.Rows.Add(newRow);

        }


        private void ucAction_Click(object sender, EventArgs e)
        {

            if (curRWBarcodeModel == null || string.IsNullOrEmpty(tbox_barcode.Text))
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
                    float deqty = 0;

                    deqty = float.Parse(tbox_surplus.Text);
                    if (deqty > 0)
                    {
                        ModelAPI<WOLineReportModel> apiDeducting = new ModelAPI<WOLineReportModel>();


                        WOLineReportModel detuctingModel = new WOLineReportModel();
                        detuctingModel.RWID = tbox_barcode.Text;
                        detuctingModel.WorkOrder = curReportModel.Workorder;
                        detuctingModel.ReportLineID = curReportModel.ID;
                        detuctingModel.DeQTY = deqty;

                        apiDeducting.Insert(detuctingModel);

                        DialogResult = DialogResult.OK;
                    }
                    else
                    {
                        MessageBox.Show("请录入扣量数据！");
                        tbox_surplus.Text = "";
                        tbox_surplus.Focus();
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

        private void tbox_barcode_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindBarcode();
            }
        }

        private void pbox_search_barcode_Click(object sender, EventArgs e)
        {
            FindBarcode();
        }

        private void FindBarcode()
        {
            if (string.IsNullOrEmpty(tbox_barcode.Text))
            {
                MessageBox.Show("条码标签不能为空。");
                tbox_barcode.Focus();
            }
            else
            {
                try
                {
                    ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
                    RWBarcodeModel searchModel;
                    searchModel = new RWBarcodeModel()
                    {
                        ID = tbox_barcode.Text
                    };
                    curRWBarcodeModel = apiBarcode.GetModel(searchModel);
                    if (curRWBarcodeModel != null)
                    {
                        if (curReportModel.StockCode != curRWBarcodeModel.StockCode)
                        {
                            MessageBox.Show("该条码同领料数据不符！");
                            tbox_barcode.Text = "";
                            tbox_barcode.Focus();
                        }
                        else
                        {
                            AddItem(curRWBarcodeModel);
                        }
                    }
                }
                catch (Exception ex)
                {
                    tbox_barcode.Text = "";
                    tbox_barcode.Focus();
                    MessageBox.Show(ex.Message);
                }

            }
        }

    }
}