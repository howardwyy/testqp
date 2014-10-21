using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    public class RWStockTakenModel:BaseSearchModel
    {
        public RWStockReportModel[] reportModels { get; set; }
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            if (reportModels.Length == 0)
                throw new Exception("无taken数据");
            List<Hashtable> list = new List<Hashtable>();
            foreach (RWStockReportModel item in reportModels)
            {
                Hashtable h = new Hashtable();
                h["Qty"] = item.BarcodeQty - item.ScalaQty;
                h["StockCode"] = item.Stock;
                h["Warehouse"] = item.Warehouse;
                h["Bin"] = item.Bin;
                h["Company"] = item.Company;
                h["SupplierBatch"] = item.SupplierBatch;
                list.Add(h);
            }
            StockTransactionXml.ExportStockTakenXML(list);
            return this;
        }
    }
}
