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
using BarcodeModel.MODEL.Barcode;
using BarcodeModel.MODEL.Barcode.RW;
using ChemTrend.Barcode.Data;
using BarcodeModel;
using BarcodeModel.ADO;
using BarcodeModel.MODEL;
using BarcodeModel.MODEL.Barcode.RW.Operation;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmWarehouseBarcode : DevExpress.XtraEditors.XtraForm
    {
        public string wCode { get; set; }
        public int Action { get; set; }
        ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
        public List<string> ids { get; set; }

        ModelAPI<BillDetailModel> apiBillDetail = new ModelAPI<BillDetailModel>();


        ModelAPI<LocationModel> apiWarehouse = new ModelAPI<LocationModel>();
        List<LocationModel> listWarehouse;
        LocationModel searchModel;
        public frmWarehouseBarcode()
        {
            InitializeComponent();
        }

        private void sbtn_sure_Click(object sender, EventArgs e)
        {
          
                //ModelAPI<BarcodeWarehouseModel> apiBillDetail = new ModelAPI<BarcodeWarehouseModel>();
                //LocationModel model = null;
                //foreach (int row in selectRows)
                //{
                //    model = listWarehouse[gv_warehouse.GetDataSourceRowIndex(row)];
                //}

                //BarcodeWarehouseModel barcodeWarehouse = new BarcodeWarehouseModel()
                //{
                //    RWBarcodeModels = listBarcode.ToArray(),
                //    Warehouse =  model.Warehouse,
                //    Location = model.Location,
                //    Status = (int)AppConfig.Barcode.已入库
                //};
                //if (String.IsNullOrEmpty(wCode))
                //{
                //    //移库
                //    barcodeWarehouse.Remark = AppConfig.BarcodeRemark.条码移库.ToString();
                //    barcodeWarehouse.Status = (int)AppConfig.Barcode.已入库;
                //}
                //else {
                //    //入库
                //    barcodeWarehouse.Remark = AppConfig.BarcodeRemark.条码入库.ToString();
                //    barcodeWarehouse.Status = (int)AppConfig.Barcode.已入库;
                //}
                //apiBillDetail.Insert(barcodeWarehouse);
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
                        ModelAPI<MoveWarehouseModel> apiWarehouse = new ModelAPI<MoveWarehouseModel>();
                        
                        MoveWarehouseModel moveWarehouse = new MoveWarehouseModel()
                        {
                            Barcodes = ids.ToArray(),
                            Warehouse = model.Warehouse,
                            Remark = AppConfig.BarcodeRemark.条码移库.ToString(),
                            Bin = model.Location
                        };
                        apiWarehouse.Insert(moveWarehouse);
                        break;
                    default:
                        ModelAPI<EnterWarehouseModel> apiInWarehouse = new ModelAPI<EnterWarehouseModel>();
                        
                        EnterWarehouseModel enterWarehouse = new EnterWarehouseModel()
                        {
                            Barcodes = ids.ToArray(),
                            Warehouse = model.Warehouse,
                            Remark = AppConfig.BarcodeRemark.条码入库.ToString(),
                            Bin = model.Location
                        };
                        apiInWarehouse.Insert(enterWarehouse);
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
            InitData();
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
    }
}