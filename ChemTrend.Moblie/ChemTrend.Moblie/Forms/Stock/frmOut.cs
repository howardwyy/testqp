using System;
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
    public partial class frmOut : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        private ModelAPI<ReceiveDetailModel> apiReceiveDetails { set; get; }
        private ReceiveDetailModel searchReceiveDetail { set; get; }
        private List<ReceiveDetailModel> listRDetails { set; get; }

        private DataTable dt = new DataTable();


        private ReceiveDetailModel curReceiveDetailModel { set; get; }
        private ReceiveModel curReceiveModel { set; get; }



        public frmOut()
        {
            InitializeComponent();
        }

        private void frmOut_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "领料单出库";
            base.ucAction.Visible = true;
            base.ucAction.initString("领料");
            base.ucAction.Click += new EventHandler(ucAction_Click);
            this.tbox_bill.Focus();

            InitData();
        }

        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(tbox_warehouse.Text) || string.IsNullOrEmpty(tbox_bin.Text))
            {
                MessageBox.Show("请扫描或录入仓库库位信息！");
                tbox_warehouse.Text = "";
                tbox_bin.Text = "";
                tbox_warehouse.Focus();
            }
            else if (curReceiveModel == null)
            {
                MessageBox.Show("请扫描或录入有效的领料单信息！");
            }
            else
            {

                int index = dg_list.CurrentRowIndex;
                curReceiveDetailModel = listRDetails[index];
                if (curReceiveDetailModel.ReceivedSurplusCount > 0)
                {
                    frmReceiving frmRec = new frmReceiving();
                    frmRec.curWH = tbox_warehouse.Text;
                    frmRec.curBin = tbox_bin.Text;
                    frmRec.curReceiveModel = curReceiveModel;
                    frmRec.curReceiveDetailModel = curReceiveDetailModel;

                    DialogResult result = frmRec.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        dt.Clear();
                        listRDetails.Clear();
                        FindBill();
                    }
                }
                else
                {
                    MessageBox.Show("该领料物料已完成！");
                }
            }
        }


        private void ResetData()
        {
            dt.Clear();
            tbox_bill.Text = "";
        }

        private void InitData()
        {

            dg_list.DataSource = dt;

            dt.Columns.Add("物料", typeof(string));
            dt.Columns.Add("已领数量", typeof(string));
            dt.Columns.Add("剩余数量", typeof(string));
            dt.Columns.Add("领料单位", typeof(string));

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


        }

        private void pbox_search_bill_Click(object sender, EventArgs e)
        {
            FindBill();
        }

        private void pbox_search_barcode_Click(object sender, EventArgs e)
        {
            //FindBarcode();
        }

        private void tbox_bill_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindBill();
            }

        }

        private void tbox_barcode_KeyUp(object sender, KeyEventArgs e)
        {
            //FindBarcode();
        }
        /// <summary>
        /// 查询领料单数据
        /// </summary>
        private void FindBill()
        {
            if (string.IsNullOrEmpty(tbox_bill.Text))
            {
                MessageBox.Show("请扫描或录入领料单信息！");
                tbox_bill.Text = "";
                tbox_bill.Focus();

            }
            else
            {
                try
                {
                    ModelAPI<ReceiveModel> apiReceive = new ModelAPI<ReceiveModel>();
                    ReceiveModel searchModel = new ReceiveModel()
                    {
                        ID = tbox_bill.Text
                    };
                    ReceiveModel model = apiReceive.GetModel(searchModel);
                    if (model != null)
                    {
                        listRDetails = BarcodeInfo.GetBarcodes(model.ID).ConvertAll<ReceiveDetailModel>(m => m as ReceiveDetailModel); ;
                        for (int i = 0; i < listRDetails.Count; i++)
                        {
                            AddDetailsItem(listRDetails[i]);
                        }
                        if (model.Status == 3)
                        {
                            MessageBox.Show("该领料单已关闭！");
                        }
                        else {
                            if (string.IsNullOrEmpty(tbox_warehouse.Text)) {
                                this.tbox_warehouse.Focus();
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("未找到领料单信息！");
                        tbox_bill.Text = "";
                        tbox_bill.Focus();
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
        private void AddDetailsItem(ReceiveDetailModel model)
        {

            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();
            newRow["物料"] = model.StockCode;
            newRow["已领数量"] = model.ReceivedCount + "";
            newRow["剩余数量"] = model.ReceivedSurplusCount + "";
            newRow["领料单位"] = model.ReceiveUnit;
            dt.Rows.Add(newRow);

            //进入
            if (string.IsNullOrEmpty(tbox_warehouse.Text))
            {
                tbox_warehouse.Focus();
            }
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

                    this.tbox_warehouse.Focus();
                    this.tbox_warehouse.SelectionStart = this.tbox_warehouse.Text.Length;
                }
            }
        }
    }
}

