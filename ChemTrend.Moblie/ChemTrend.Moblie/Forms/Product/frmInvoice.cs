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
    public partial class frmInvoice : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        private InvoiceModel curInvoiceModel { set; get; }
        private InvoiceDetailModel curInvoiceDetailModel { set; get; }

        private List<InvoiceDetailModel> invoiceDetailModels = new List<InvoiceDetailModel>();
        private DataTable dt = new DataTable();
        public frmInvoice()
        {
            InitializeComponent();
        }

        private void frmInvoice_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "发往客户";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");

            base.ucAction.Click += new EventHandler(ucAction_Click);


            InitData();

        }

      
        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbox_invoice.Text) )
            {
                this.tbox_invoice.Text = "";
                MessageBox.Show("发货单不能为空。");
                return;
            }
            else if (invoiceDetailModels.Count <= 0)
            {
                this.tbox_invoice.Text = "";
                MessageBox.Show("请选择发货单行信息！");
                return;
            }
            try
            {

                int index = dg_list.CurrentRowIndex;
                curInvoiceDetailModel = invoiceDetailModels[index];
                if (curInvoiceDetailModel.InvoiceSurplusCount > 0)
                {
                    frmInvoicing frmInv = new frmInvoicing();
                    frmInv.curInvoiceDetailModel = curInvoiceDetailModel;
                    frmInv.curInvoiceModel = curInvoiceModel;

                    DialogResult result = frmInv.ShowDialog();
                    if (result == DialogResult.OK)
                    {
                        dt.Clear();
                        invoiceDetailModels.Clear();
                        FindBill();
                    }
                }
                else
                {
                    MessageBox.Show("该领料物料已完成！");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


        private void ResetData()
        {
            dt.Clear();

            tbox_invoice.Text = "";
            tbox_invoice.Focus();
        }

        private void InitData()
        {

            dg_list.DataSource = dt;

            dt.Columns.Add("物料", typeof(string));
            dt.Columns.Add("已发数量", typeof(string));
            dt.Columns.Add("剩余数量", typeof(string));
            dt.Columns.Add("发货单位", typeof(string));

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

        private void pbox_query_Click(object sender, EventArgs e)
        {
            FindBill();
        }

        private void FindBill()
        {
            if (tbox_invoice.Text.Length >= 1)
            {
                try
                {

                    ModelAPI<InvoiceModel> apiInvoice = new ModelAPI<InvoiceModel>();
                    InvoiceModel searchModel = new InvoiceModel()
                    {
                        ID = tbox_invoice.Text
                    };
                    InvoiceModel model = apiInvoice.GetModel(searchModel);
                    if (model != null)
                    {
                        curInvoiceModel = model;
                        ModelAPI<InvoiceDetailModel> apiInvoiceDetails = new ModelAPI<InvoiceDetailModel>();
                        InvoiceDetailModel searchInvoiceDetail = new InvoiceDetailModel();
                        searchInvoiceDetail.InvoiceID = model.ID;
                        invoiceDetailModels = apiInvoiceDetails.GetList(searchInvoiceDetail);
                        for (int i = 0; i < invoiceDetailModels.Count; i++)
                        {
                            AddDetailsItem(invoiceDetailModels[i]);
                        }
                        if (model.Status == 3)
                        {
                            MessageBox.Show("该领料单已关闭！");
                        }
                    }
                }
                catch (Exception)
                {
                    
                    throw;
                }
                
            }
        }


        private void AddDetailsItem(InvoiceDetailModel model)
        {

            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();
            newRow["物料"] = model.StockID;
            newRow["已发数量"] = model.InvoicedCount + "";
            newRow["剩余数量"] = model.InvoiceSurplusCount + "";
            newRow["发货单位"] = model.Unit;
            dt.Rows.Add(newRow);

            
        }

        private void tbox_invoice_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                FindBill();
            }
        }

        private void pbox_invoice_Click(object sender, EventArgs e)
        {
            FindBill();
        }

    }
}

