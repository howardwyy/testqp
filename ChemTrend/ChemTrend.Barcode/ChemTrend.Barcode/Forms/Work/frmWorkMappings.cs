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
using BarcodeModel.MODEL.Barcode.WORP;
using ChemTrend.Barcode.Data;

namespace ChemTrend.Barcode.Forms.Work
{
    public partial class frmWorkMappings : DevExpress.XtraEditors.XtraForm
    {

        ModelAPI<MappingModel> apiMapping = new ModelAPI<MappingModel>();
        List<MappingModel> listMapping = new List<MappingModel>();
        MappingModel searchModel = null;
        MappingModel curMappingModel = null;
        private int pageSize = 10;

        public frmWorkMappings()
        {
            InitializeComponent();
        }

        private void frmWorkMappings_Load(object sender, EventArgs e)
        {
            InitData();
        }

        private void InitData()
        {
            searchModel = new MappingModel()
            {
                SearchOrderBy = "WK03001 DESC",
                PageIndex = ucPager.PageCurrent,
                PageSize = pageSize
            };

            ucPager.EventPaging += ucPager_EventPaging;
            ucPager.PageSize = pageSize;
            ucPager.Bind();
        }

        int ucPager_EventPaging(Controls.EventPagingArg e)
        {
            try
            {
                searchModel.PageIndex = ucPager.PageCurrent;
                searchModel.PageSize = ucPager.PageSize;
                listMapping = apiMapping.GetList(searchModel);
                gc_mapping.DataSource = listMapping;


                //this.gv_users.FocusedRowHandle = 0;
                if (listMapping != null && listMapping.Count >= 1)
                {
                    return listMapping[0].totalCount;
                }
                else
                    return 0;
            }
            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
                return 0;
            }
        }
        private void sbtn_select_Click(object sender, EventArgs e)
        {

        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {
            ShowMapping((int)AppConfig.ActionType.Insert, curMappingModel);
        }

        private void gv_mapping_DoubleClick(object sender, EventArgs e)
        {
            int rowId = gv_mapping.GetFocusedDataSourceRowIndex();

            if (listMapping != null && rowId >= 0)
            {
                curMappingModel = listMapping[rowId];
                ShowMapping((int)AppConfig.ActionType.Update, curMappingModel);
            }
        }
        private void ShowMapping(int actionType, MappingModel userModel)
        {
            frmWorkMapping frmWorkMapping = new frmWorkMapping();
            frmWorkMapping.actionType = (int)AppConfig.ActionType.Insert;
            frmWorkMapping.StartPosition = FormStartPosition.CenterParent;
            frmWorkMapping.ShowDialog();
            if (frmWorkMapping.DialogResult == DialogResult.Yes)
            {
                ucPager.Bind();
            }
        }

        private void sbtn_update_Click(object sender, EventArgs e)
        {
            int rowId = gv_mapping.GetFocusedDataSourceRowIndex();

            if (listMapping != null)
            {
                curMappingModel = listMapping[rowId];
            }

            if (curMappingModel != null)
            {
                curMappingModel = listMapping[rowId];
                ShowMapping((int)AppConfig.ActionType.Update, curMappingModel);
            }
        }

    }
}