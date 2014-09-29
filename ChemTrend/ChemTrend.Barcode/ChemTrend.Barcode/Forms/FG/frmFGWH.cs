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
using ChemTrend.Barcode.Data;
using BarcodeModel.MODEL.Barcode.FG.Operation;
using BarcodeModel.MODEL.Barcode.FG;

namespace ChemTrend.Barcode.Forms.FG
{
    public partial class frmFGWH : DevExpress.XtraEditors.XtraForm
    {

        public string wCode { get; set; }
        public int Action { get; set; }
        ModelAPI<FGBarcodeModel> apiBarcode = new ModelAPI<FGBarcodeModel>();
        public List<string> ids { get; set; }



        ModelAPI<LocationModel> apiWarehouse = new ModelAPI<LocationModel>();
        List<LocationModel> listWarehouse;
        LocationModel searchModel;
      
        public frmFGWH()
        {
            InitializeComponent();
        }
        private void sbtn_sure_Click(object sender, EventArgs e)
        {
          
             
            int[] selectRows = gv_warehouse.GetSelectedRows();
            if (selectRows.Length >= 1)
            {
                LocationModel model = null;
                foreach (int row in selectRows)
                {
                    model = listWarehouse[gv_warehouse.GetDataSourceRowIndex(row)];
                }
                switch (Action)
                {
                    case (int)AppConfig.BarcodeRemark.条码移库:
                        try
                        {
                            ModelAPI<MoveWarehouseFGModel> apiWarehouse = new ModelAPI<MoveWarehouseFGModel>();

                            MoveWarehouseFGModel moveWarehouse = new MoveWarehouseFGModel()
                            {
                                Barcodes = ids.ToArray(),
                                Warehouse = model.Warehouse,
                                Remark = AppConfig.BarcodeRemark.条码移库.ToString(),
                                Bin = model.Location
                            };
                            apiWarehouse.Insert(moveWarehouse);

                        }
                        catch (Exception ex)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
                        }
                       
                        break;
                    default:
                        try
                        {
                            ModelAPI<InWarehouseFGModel> apiInWarehouse = new ModelAPI<InWarehouseFGModel>();

                            InWarehouseFGModel enterWarehouse = new InWarehouseFGModel()
                            {
                                Barcodes = ids.ToArray(),
                                Warehouse = model.Warehouse,
                                Remark = AppConfig.BarcodeRemark.条码入库.ToString(),
                                Bin = model.Location
                            };
                            apiInWarehouse.Insert(enterWarehouse);
                        }

                        catch (Exception ex)
                        {
                            DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
                        }
                        
                        break;
                }


                this.DialogResult = DialogResult.OK;
            }
            else
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请选中行信息？", "确认", MessageBoxButtons.OK);
            }
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
        }

        private void frmWarehouseBarcode_Load(object sender, EventArgs e)
        {
        }

        private void InitData()
        {
            if (wCode != null && wCode.Length >= 1)
            {
                searchModel = new LocationModel()
                {
                    Warehouse = wCode
                };
            }
            listWarehouse = apiWarehouse.GetList(searchModel);
            gc_warehouse.DataSource = listWarehouse;
            this.gv_warehouse.FocusedRowHandle = 0;

        }


        private void frmFGWH_Load(object sender, EventArgs e)
        {
            InitData();

        }
    }
}