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
using DevExpress.XtraReports.UI;
using BarcodeModel.MODEL.Barcode;
using BarcodeModel.API;
using ChemTrend.Barcode.Report;
using BarcodeModel.MODEL.Sys;

namespace ChemTrend.Barcode.Forms.Print
{
    public partial class frmStock : DevExpress.XtraEditors.XtraForm
    {

        List<StockModel> listStock;
        ModelAPI<StockModel> apiStock = new ModelAPI<StockModel>();
        StockModel searchModel;

        public frmStock()
        {
            InitializeComponent();
        }

        private void frmStock_Load(object sender, EventArgs e)
        {
            try
            {
                ModelAPI<CompanyModel> apiCompany = new ModelAPI<CompanyModel>();
                CompanyModel companyModel = apiCompany.GetModelByID("Companys"); ;
                lue_company.Properties.DataSource = companyModel.Companys;
                lue_company.ItemIndex = 0;
                InitData();
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);

            }
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            searchModel = new StockModel();
            if (this.te_wccode.Text.Trim().Length != 0)
            {
                searchModel.StockCode = this.te_wccode.Text;
            }
            if (this.te_wcname.Text.Trim().Length != 0)
            {
                searchModel.StockName = this.te_wcname.Text;
            }
            if (this.lue_company.Text.Length >= 1)
            {
                searchModel.Company = this.lue_company.Text;
            }

            listStock = apiStock.GetList(searchModel);
            gc_workcenter.DataSource = listStock;
            this.gv_stock.FocusedRowHandle = 0;
        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {

            List<XtraReport> reports = new List<XtraReport>();
            int[] selectRows = gv_stock.GetSelectedRows();

            foreach (int row in selectRows)
            {
                StockModel model = listStock[gv_stock.GetDataSourceRowIndex(row)];
                repStock report = new repStock();
                report.StockName = model.StockName;
                report.StockCode = model.StockCode;
                report.CreateDocument();
                reports.Add(report);
            }
            frmMutiPrint mutiPrint = new frmMutiPrint();
            mutiPrint.reports = reports;
            mutiPrint.Show();
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}