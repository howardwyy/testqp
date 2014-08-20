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
using ChemTrend.Barcode.Data;
using DevExpress.XtraGrid.Views.Grid;

namespace ChemTrend.Barcode.Forms.Print
{
    public partial class frmCustomer : DevExpress.XtraEditors.XtraForm
    {
        DataTable dt = null;
        public frmCustomer()
        {
            InitializeComponent();
            InitView();
            ShowCustomerDetail();
        }

        private void InitView()
        {
            gridView1.OptionsSelection.MultiSelect = true;
            gridView1.OptionsSelection.MultiSelectMode = DevExpress.XtraGrid.Views.Grid.GridMultiSelectMode.RowSelect;
        }

        private void frmCustomer_Load(object sender, EventArgs e)
        {
            frmMain f = (frmMain)this.ParentForm;
            string strStatusBar = "数据总和：" + dt.Rows.Count;
            f.updateStatusBar(strStatusBar);
        }
        private void ShowCustomerDetail()
        {
            IList<Customer> list = new BindingList<Customer>();
            for (int i = 0; i < 10; i++)
            {
                Customer customer = new Customer();
                //customer = false;
                customer.cId = "A1";
                customer.cName = "A2";
                list.Add(customer);
            }
            gridControl1.DataSource = list;

        }

    }
}