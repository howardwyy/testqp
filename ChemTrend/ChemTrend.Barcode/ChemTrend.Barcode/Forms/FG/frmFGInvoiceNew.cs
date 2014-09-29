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
using BarcodeModel.MODEL.Sys;
using BarcodeModel.MODEL.Barcode.FG.Operation;
using BarcodeModel.MODEL.Barcode.FG;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Forms.Print;
using ChemTrend.Barcode.Report;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGInvoiceNew : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<SOLineModel> apiSOLineModel = new ModelAPI<SOLineModel>();
        List<SOLineModel> listSOLineModel = new List<SOLineModel>();
        SOLineModel searchModel = new SOLineModel();
        public frmFGInvoiceNew()
        {
            InitializeComponent();
        }

        private void frmFGInvoiceNew_Load(object sender, EventArgs e)
        {
            InitView();
        }

        private void InitView()
        {
            de_hopetime.DateTime = System.DateTime.Now;
            try
            {
                ModelAPI<CompanyModel> apiCompany = new ModelAPI<CompanyModel>();
                CompanyModel companyModel = apiCompany.GetModelByID("Companys"); ;
                lue_company.Properties.DataSource = companyModel.Companys;
                lue_company.ItemIndex = 0;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void sbtn_create_print_Click(object sender, EventArgs e)
        {
            int[] selectRows = gv_woline.GetSelectedRows();
            if (selectRows.Length >= 1)
            {
                List<SOLineModel> selectedSOLines = new List<SOLineModel>();
                foreach (int row in selectRows)
                {
                    SOLineModel item = listSOLineModel[gv_woline.GetDataSourceRowIndex(row)];
                    selectedSOLines.Add(item);
                }

                ModelAPI<CreateInvoiceModel> apiICreate = new ModelAPI<CreateInvoiceModel>();
                CreateInvoiceModel createModel = new CreateInvoiceModel()
                {
                    SOLines = selectedSOLines.ToArray(),
                    SONO = this.cbox_wo.Text,
                    Remark = this.te_remark.Text,
                    isUrgent = this.cke_isurgent.Checked ? 1 : 0,
                    HopeTime = de_hopetime.DateTime
                };
                CreateInvoiceModel ICreateModel = apiICreate.Insert(createModel);

                this.DialogResult = DialogResult.OK;
                if (DevExpress.XtraEditors.XtraMessageBox.Show("是否打印生成的条码信息？", "打印", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {

                    ModelAPI<InvoiceModel> apiInvoice = new ModelAPI<InvoiceModel>();
                    InvoiceModel invoiceModel = apiInvoice.GetModelByID(ICreateModel.SONO);

                    ModelAPI<InvoiceDetailModel> apiInvoiceDetails = new ModelAPI<InvoiceDetailModel>();
                    InvoiceDetailModel searchInvoiceDetail = new InvoiceDetailModel();
                    searchInvoiceDetail.InvoiceID = ICreateModel.SONO;
                    List<InvoiceDetailModel> listIDetails = apiInvoiceDetails.GetList(searchInvoiceDetail);
                    List<XtraReport> reports = new List<XtraReport>();


                    repFGInvoice report = new repFGInvoice(listIDetails, invoiceModel);
                    report.CreateDocument();
                    reports.Add(report);

                    frmMutiPrint mutiPrint = new frmMutiPrint();
                    mutiPrint.reports = reports;
                    mutiPrint.Show();


                }
            }
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            try
            {
                if (lue_company.ItemIndex != -1)
                {
                    searchModel.Company = lue_company.Text;
                }
                if (!String.IsNullOrEmpty(cbox_wo.Text))
                {
                    searchModel.OrderNumber = cbox_wo.Text;
                }
                listSOLineModel = apiSOLineModel.GetList(searchModel);
                gc_woline.DataSource = listSOLineModel;
                gc_woline.RefreshDataSource();

            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void sbtn_wo_Click(object sender, EventArgs e)
        {
            GetTips();
        }

        private void cbox_wo_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetTips();
            }
        }

        private void GetTips()
        {

            if (!String.IsNullOrEmpty(cbox_wo.Text))
            {
                try
                {

                    cbox_wo.Properties.Items.Clear();
                    string tips = cbox_wo.Text;
                    string company = this.lue_company.Text;
                    ModelAPI<GetONTipsModel> apiTips = new ModelAPI<GetONTipsModel>();
                    GetONTipsModel searchModel = new GetONTipsModel() {
                        company = company,
                        tips = tips

                    };
                    GetONTipsModel returnModel = apiTips.Insert(searchModel);
                    if (returnModel != null && returnModel.ONS != null)
                    {
                        for (int i = 0; i < returnModel.ONS.Count(); i++)
                        {
                            cbox_wo.Properties.Items.Add(returnModel.ONS[i]);
                        }
                    }
                    cbox_wo.ShowPopup();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
                }
            }
        }

    }
}