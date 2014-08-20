using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Json;

namespace BarcodeModel.MODEL.Barcode.RW
{
    public class RWBarcodeModel:BaseSearchModel
    {
        public string ID { get; set; }

        public string StockCode { get; set; }

        public string StockName { get; set; }

        public string StockSpec { get; set; }

        public string StockUnit { get; set; }

        public decimal StockUnitQty { get; set; }

        public string StockBatch { get; set; }

        public string Warehouse { get; set; }

        public string Location { get; set; }

        public DateTime WarehouseInTime { get; set; }

        public DateTime WarehouseOutTime { get; set; }

        public string SupplierCode { get; set; }

        public string SupplierName { get; set; }

        public string PO { get; set; }

        public string POLine { get; set; }

        public string LastWarehouse { get; set; }

        public string LastLocation { get; set; }

        public string Remark1 { get; set; }

        public string Remark2 { get; set; }

        public string FlowKey { get; set; }

        public string FlowName { get; set; }

        public string RAWCode { get; set; }

        public string RAWName { get; set; }

        public string LastUser { get; set; }

        public string LastUserName { get; set; }

        public string LastHistoryID { get; set; }

        public string Bill { get; set; }

        public string CustomerCode { get; set; }

        public string CustomerName { get; set; }

        public string SO { get; set; }

        public string BoxID { get; set; }

        public int Status { get; set; }

        public string WO { get; set; }

        public string CompanyCode { get; set; }

        

    }
}
