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
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.API;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGSuggestChoice : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<SuggestModel> apiSuggest = new ModelAPI<SuggestModel>();
        List<SuggestModel> suggestModels = new List<SuggestModel>();
        SuggestModel searchModel = null;
        public frmFGSuggestChoice()
        {
            InitializeComponent();
        }

        private void frmFGSuggestChoice_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            try
            {
                suggestModels = apiSuggest.GetList(searchModel);
                this.gc_customer.DataSource = suggestModels;
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