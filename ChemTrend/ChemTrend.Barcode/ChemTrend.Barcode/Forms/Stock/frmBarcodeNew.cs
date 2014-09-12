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
using BarcodeModel.MODEL.Barcode.RW.Operation;
using BarcodeModel.MODEL.Sys;
using ChemTrend.Barcode.Data;
using ChemTrend.Barcode.Forms.Print;
using ChemTrend.Barcode.Forms.Report;
using DevExpress.XtraReports.UI;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmBarcodeNew : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<POLineModel> apiPOLine = new ModelAPI<POLineModel>();
        List<POLineModel> listPOLine = null;
        public frmBarcodeNew()
        {
            InitializeComponent();
        }

        private void sbtn_warehousecode_Click(object sender, EventArgs e)
        {
            GetTips();
        }

        private void GetTips()
        {
            if (!String.IsNullOrEmpty(cbox_orderno.Text))
            {
                try
                {

                    cbox_orderno.Properties.Items.Clear();
                    string tips = cbox_orderno.Text;
                    POLineModel returnModel = apiPOLine.GetModelByID(tips);
                    if (returnModel != null && returnModel.POS != null)
                    {
                        for (int i = 0; i < returnModel.POS.Count(); i++)
                        {
                            cbox_orderno.Properties.Items.Add(returnModel.POS[i]);
                        }
                    }
                    cbox_orderno.ShowPopup();
                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
                }
            }
        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {
            POLineModel po = new POLineModel();
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            try
            {
                POLineModel searchModel = new POLineModel();
                if (lue_company.ItemIndex != -1)
                {
                    searchModel.Company = lue_company.Text;
                }
                if (!String.IsNullOrEmpty(cbox_orderno.Text))
                {
                    searchModel.PO = cbox_orderno.Text;
                }

                listPOLine = apiPOLine.GetList(searchModel);
                gc_poline.DataSource = listPOLine;
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
            this.te_po.Text = "";
            this.te_suppliername.Text = "";
            this.te_supplier.Text = "";
        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {
            try
            {
                int[] selectRows = gv_poline.GetSelectedRows();
                if (selectRows.Length >= 1)
                {

                    ModelAPI<BarcodeCreateModel> apiBarcode = new ModelAPI<BarcodeCreateModel>();
                    BarcodeCreateModel createModel = new BarcodeCreateModel();
                    List<POLineModel> selectedPOLines = new List<POLineModel>();
                    foreach (int row in selectRows)
                    {
                        POLineModel item = listPOLine[gv_poline.GetDataSourceRowIndex(row)];
                        if (item.UNITQTY <= 0 || item.BarcodeQTY <= 0)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show("请核实您的选中行数据！", "确认", MessageBoxButtons.OK);
                            return;
                        }
                        selectedPOLines.Add(item);
                    }
                    createModel.POLineModels = selectedPOLines.ToArray();
                    createModel.BillRemark = AppConfig.BarcodeRemark.创建条码.ToString();
                    BarcodeCreateModel returnModel = apiBarcode.Insert(createModel);
                    string[] ReturnIDS = returnModel.ReturnIDS;
                    if (ReturnIDS.Length >= 1)
                    {
                        this.DialogResult = DialogResult.OK;
                        if (DevExpress.XtraEditors.XtraMessageBox.Show("是否打印生成的条码信息？", "打印", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                        {

                            ModelAPI<RWBarcodeModel> apiRW = new ModelAPI<RWBarcodeModel>();
                            List<RWBarcodeModel> RWBarcodeModels = apiRW.GetList(ReturnIDS);
                            List<XtraReport> reports = new List<XtraReport>();
                            foreach (RWBarcodeModel model in RWBarcodeModels)
                            {
                                repStock report = new repStock();
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

        private void frmBarcodeNew_Load(object sender, EventArgs e)
        {
            ModelAPI<CompanyModel> apiCompany = new ModelAPI<CompanyModel>();
            CompanyModel companyModel = apiCompany.GetModelByID("Companys"); ;
            lue_company.Properties.DataSource = companyModel.Companys;
            lue_company.ItemIndex = 0;



        }

        private void cbox_orderno_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                GetTips();
            }
        }

        private void gv_poline_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            POLineModel focusedModel = gv_poline.GetFocusedRow() as POLineModel;
            this.te_po.Text = focusedModel.PO;
            this.te_supplier.Text = focusedModel.SupplierCode;
            this.te_suppliername.Text = focusedModel.SupplierName;
        }
    }
}