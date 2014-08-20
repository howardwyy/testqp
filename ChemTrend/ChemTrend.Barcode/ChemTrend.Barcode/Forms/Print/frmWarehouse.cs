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
using ChemTrend.Barcode.Forms.Report;
using DevExpress.XtraReports.UI;
using DevExpress.XtraPrinting;
using System.Drawing.Printing;
using BarcodeModel.MODEL.Barcode;
using BarcodeModel.API;
using BarcodeModel.MODEL.Sys;

namespace ChemTrend.Barcode.Forms.Print
{
    public partial class frmWarehouse : DevExpress.XtraEditors.XtraForm
    {
        List<LocationModel> listWarehouse;
        ModelAPI<LocationModel> apiWarehouse = new ModelAPI<LocationModel>();
        LocationModel searchModel;
        public frmWarehouse()
        {
            InitializeComponent();
        }

        private void frmWarehouse_Load(object sender, EventArgs e)
        {
            ModelAPI<CompanyModel> apiCompany = new ModelAPI<CompanyModel>();
            CompanyModel companyModel = apiCompany.GetModelByID("Companys"); ;
            lue_company.Properties.DataSource = companyModel.Companys;
            lue_company.ItemIndex = 0;
            InitData();
        }

        private void InitData()
        {
            searchModel = new LocationModel();
            if (this.te_warehousecode.Text.Trim().Length != 0)
            {
                searchModel.Warehouse = this.te_warehousecode.Text;
            }
            if (this.te_bincode.Text.Trim().Length != 0)
            {
                searchModel.Location = this.te_bincode.Text;
            }
            if (this.te_binname.Text.Trim().Length != 0)
            {
                searchModel.LocationName = this.te_binname.Text;
            }
            if (this.lue_company.Text.Length >= 1) {
                searchModel.Company = this.lue_company.Text;
            }

            listWarehouse = apiWarehouse.GetList(searchModel);
            gc_warehouse.DataSource = listWarehouse;
            this.gv_warehouse.FocusedRowHandle = 0;
        }




        private void sbtn_print_Click(object sender, EventArgs e)
        {

            List<XtraReport> reports = new List<XtraReport>();
            int[] selectRows = gv_warehouse.GetSelectedRows();

            foreach (int row in selectRows)
            {
                LocationModel model = listWarehouse[gv_warehouse.GetDataSourceRowIndex(row)];
                repWarehouse report = new repWarehouse();
                report.warehouse = model;
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

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            InitData();
        }


    }
}