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
using BarcodeModel.MODEL.Barcode;
using BarcodeModel.API;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGCustomer : DevExpress.XtraEditors.XtraForm
    { 

        ModelAPI<CustomerModel> apiCustomer = new ModelAPI<CustomerModel>();
        List<CustomerModel> customerModels = new List<CustomerModel>();
        CustomerModel searchModel = null;

        public frmFGCustomer()
        {
            InitializeComponent();
        }

        private void frmFGCustomer_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            try
            {
                customerModels = apiCustomer.GetList(searchModel);
                this.gc_customer.DataSource = customerModels;
            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void sbtn_sure_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}