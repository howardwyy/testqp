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
using ChemTrend.Barcode.Utils;
using BarcodeModel.MODEL.Barcode.RW;
using BarcodeModel.API;
using ChemTrend.Barcode.Data;
using BarcodeModel.MODEL.Barcode.RW.Operation;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmPackingBarcode : DevExpress.XtraEditors.XtraForm
    {
        public List<string> ids { set; get; }

        ModelAPI<PackingModel> apiPacking = new ModelAPI<PackingModel>();
        List<PackingModel> listPacking = null;
        PackingModel searchModel = null;

        public frmPackingBarcode()
        {
            InitializeComponent();
        }

        private void InitData()
        {
            searchModel = new PackingModel();
            searchModel.Status = 1;
            listPacking = apiPacking.GetList(searchModel);
            gc_packing.DataSource = listPacking;

            gc_packing_status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            BaseFormatter formatBase = new BaseFormatter();
            gc_packing_status.DisplayFormat.Format = formatBase;
            formatBase.EventHandler += new OverideFormat(formatBase_EventHandler);

        }

        //状态（1，未使用；2.使用中；3，使用完）
        private string formatBase_EventHandler(string format, object arg, IFormatProvider formatProvider)
        {
            int state = int.Parse(arg.ToString());
            if (state == 1)
                return "未使用";
            if (state == 2)
                return "使用中";
            if (state == 3)
                return "使用完";
            return "未使用";
        }

        private void frmPackingBarcode_Load(object sender, EventArgs e)
        {
            InitData();

        }

        private void sbtn_sure_Click(object sender, EventArgs e)
        {
            int[] selectRows = gv_packing.GetSelectedRows();
            if (selectRows.Length >= 1)
            {
                PackingModel packingModel = null;
                foreach (int row in selectRows)
                {
                    packingModel = listPacking[gv_packing.GetDataSourceRowIndex(row)];
                }
                if (packingModel.Status == 3)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show("您选择的装箱条码信息有误!", "确认", MessageBoxButtons.OK);
                }
                else
                {
                    ModelAPI<PackingBarcodeModel> apiBPacking = new ModelAPI<PackingBarcodeModel>();
                    PackingBarcodeModel packingWHModel = new PackingBarcodeModel()
                    {
                        Status = (int)AppConfig.Packing.使用中,
                        Barcodes = ids.ToArray(),
                        PackingID= packingModel.ID
                    };
                    apiBPacking.Insert(packingWHModel);


                    this.DialogResult = DialogResult.OK;
                }
            }
            else
            {

                DevExpress.XtraEditors.XtraMessageBox.Show("请选中装箱条码信息!", "确认", MessageBoxButtons.OK);
            }
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}