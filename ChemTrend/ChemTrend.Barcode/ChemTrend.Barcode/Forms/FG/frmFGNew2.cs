using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW;
using ChemTrend.Barcode.Data;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Forms.Report;
using ChemTrend.Barcode.Forms.Print;
using BarcodeModel.MODEL.Barcode.FG;
using ChemTrend.Barcode.Report;
using BarcodeModel.MODEL.Sys;
using BarcodeModel.MODEL.Barcode.FG.Operation;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGNew2 : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<WOModel> apiWO = new ModelAPI<WOModel>();
        List<WOModel> listWO = new List<WOModel>();
        public WOModel searchWOModel { get; set; }
        public frmFGNew2()
        {
            InitializeComponent();
        }

        private void frmFGNew2_Load(object sender, EventArgs e)
        {
            InitView();
            InitData();
        }

        private void InitView()
        {
            ModelAPI<CompanyModel> apiCompany = new ModelAPI<CompanyModel>();
            CompanyModel companyModel = apiCompany.GetModelByID("Companys"); ;
            lue_company.Properties.DataSource = companyModel.Companys;
            lue_company.ItemIndex = 0;
        }

        private void InitData()
        {
            this.gc_wo.DataSource = listWO;
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selectRows = gv_wo.GetSelectedRows();
                if (selectRows.Length >= 1)
                {

                    ModelAPI<CreateFGModel> apiBarcode = new ModelAPI<CreateFGModel>();
                    CreateFGModel createModel = new CreateFGModel();
                    List<WOModel> selectedWOModels = new List<WOModel>();
                    foreach (int row in selectRows)
                    {
                        WOModel item = listWO[gv_wo.GetDataSourceRowIndex(row)];
                        if (item.PlanQTY <= 0 || item.PlanQTY <= 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("请核实您的选中行数据！", "确认", MessageBoxButtons.OK);
                            return;
                        }
                        selectedWOModels.Add(item);
                    }
                    createModel.WOModels = selectedWOModels.ToArray();
                    createModel.BillRemark = AppConfig.BarcodeRemark.创建条码.ToString();
                    CreateFGModel returnModel = apiBarcode.Insert(createModel);
                    string[] ReturnIDS = returnModel.ReturnIDS;
                    if (ReturnIDS.Length >= 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        if (DevExpress.XtraEditors.XtraMessageBox.Show("是否打印生成的条码信息？", "打印", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            ModelAPI<FGBarcodeModel> apiFG = new ModelAPI<FGBarcodeModel>();
                            List<FGBarcodeModel> FGBarcodeModels = apiFG.GetList(ReturnIDS);
                            List<XtraReport> reports = new List<XtraReport>();
                            foreach (FGBarcodeModel model in FGBarcodeModels)
                            {
                                repFG report = new repFG();
                                report.model = model;
                                report.CreateDocument();
                                reports.Add(report);
                            }
                            frmMutiPrint mutiPrint = new frmMutiPrint();
                            mutiPrint.reports = reports;
                            mutiPrint.Show();
                        }
                    }
                }
                else
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("请选中需要创建的行信息？", "确认", MessageBoxButtons.OK);
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }

        }

        private void sbtn_workno_Click(object sender, EventArgs e)
        {
            try
            {
                searchWOModel = new WOModel()
                {
                    WorkOrder = this.cbox_wo.Text,
                    Company = this.lue_company.Text
                };
                WOModel woModel = apiWO.GetModel(searchWOModel);
                if (woModel != null)
                {
                    woModel.ProductDate = System.DateTime.Now;
                    listWO.Add(woModel);
                    gc_wo.RefreshDataSource();
                }
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void GetTips()
        {
            if (!String.IsNullOrEmpty(cbox_wo.Text))
            {
                cbox_wo.Properties.Items.Clear();
                string tips = cbox_wo.Text;
                ModelAPI<GetWOTipsModel> apiWOTips = new ModelAPI<GetWOTipsModel>();
                GetWOTipsModel returnModel = apiWOTips.GetModelByID(tips);
                if (returnModel != null)
                {
                    for (int i = 0; i < returnModel.WOS.Count(); i++)
                    {
                        cbox_wo.Properties.Items.Add(returnModel.WOS[i]);
                    }
                    cbox_wo.ShowPopup();
                }
            }
        }

        private void cbox_wo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetTips();
            }
        }

    }
}