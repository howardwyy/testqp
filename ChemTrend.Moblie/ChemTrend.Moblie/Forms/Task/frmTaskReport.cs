using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.WORP;
using BarcodeModel.MODEL.Barcode.WORP.Operation;
using BarcodeModel.API;

namespace ChemTrend.Moblie.Forms.Task
{
    public partial class frmTaskReport : ChemTrend.Moblie.Forms.Base.BaseTForm
    {

        // 3101001324

        private List<ReportModel> reportModels = new List<ReportModel>();
        private DataTable dt = new DataTable();

        public frmTaskReport()
        {
            InitializeComponent();
        }

        private void frmTaskReport_Load(object sender, EventArgs e)
        {

            base.mTitle.Text = "扣料记录";
            base.ucAction.Visible = true;
            base.ucAction.initString("扣料");

            base.ucAction.Click += new EventHandler(ucAction_Click);
            this.tbox_wo.Focus();

            InitData();

        }

        private void InitData()
        {
            dg_list.DataSource = dt;


            dt.Columns.Add("WO", typeof(string));
            dt.Columns.Add("物料号", typeof(string));
            dt.Columns.Add("所需扣料", typeof(string));
            dt.Columns.Add("实际扣料", typeof(string));

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

        private void AddItem(ReportModel model)
        {
            DataRow newRow = dt.NewRow();
            newRow["WO"] = model.Workorder;
            newRow["物料号"] = model.StockCode + "";
            newRow["所需扣料"] = model.DeQTY + "";
            newRow["实际扣料"] = model.HadDeQTY + "";
            dt.Rows.Add(newRow);

        }


        private void ucAction_Click(object sender, EventArgs e)
        {
            ReportModel curReportModel = null;
            foreach (ReportModel item in reportModels)
            {
                decimal Surplus = item.DeQTY - item.HadDeQTY;
                if (Surplus > 0)
                {
                    curReportModel = item;
                    return;
                }
            }
            if (curReportModel == null)
            {
                MessageBox.Show("未找到需要扣量的行信息！");
            }
            else
            {

                frmDeducting frmDe = new frmDeducting();
                frmDe.curReportModel = curReportModel;
                DialogResult dialogResult = frmDe.ShowDialog();
                if (dialogResult == DialogResult.OK)
                {
                    dt.Clear();
                    reportModels.Clear();
                    FindReport();
                }
            }

        }


        private void tbox_wo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                FindReport();
            }
        }

        private void pbox_wo_Click(object sender, EventArgs e)
        {
            FindReport();
        }

        private void FindReport()
        {
            if (tbox_wo.Text.Length >= 1)
            {
                try
                {
                    ModelAPI<WOReportModel> apiWOReport = new ModelAPI<WOReportModel>();
                    WOReportModel searchModel = new WOReportModel()
                    {
                        Workorder = tbox_wo.Text
                    };
                    WOReportModel model = apiWOReport.Insert(searchModel);
                    if (model != null && model.ReturnReportList != null)
                    {
                        reportModels = model.ReturnReportList;

                        for (int i = 0; i < reportModels.Count; i++)
                        {
                            AddItem(reportModels[i]);
                        }
                    }
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

            }

        }
    }
}