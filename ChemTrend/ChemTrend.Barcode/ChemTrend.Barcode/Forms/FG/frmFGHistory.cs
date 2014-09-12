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
    public partial class frmFGHistory : DevExpress.XtraEditors.XtraForm
    {

        public List<FGHistoryModel> listFGHistory { get; set; }
        //ModelAPI<FGHistoryModel> apiHistory = new ModelAPI<FGHistoryModel>();
        //List<FGHistoryModel> historyModels = new List<FGHistoryModel>();
        //FGHistoryModel searchModel = null;
        public frmFGHistory()
        {
            InitializeComponent();
        }

        private void frmFGHistory_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            try
            {
                //historyModels = apiHistory.GetList(searchModel);
                //this.gc_barcode_history.DataSource = historyModels;
                this.gc_barcode_history.DataSource = listFGHistory;

            }
            catch (Exception ex)
            {

                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}