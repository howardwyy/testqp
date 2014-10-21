using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.ADO;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.RW
{
    public class RWStockReportModel : BaseSearchModel
    {
        public string Stock { get; set; }
        public string Warehouse { get; set; }
        public string Bin { get; set; }
        public string SupplierBatch { get; set; }
        public float BarcodeQty { get; set; }
        public float ScalaQty { get; set; }
        public float PDQTY { get; set; }
        public string Company { get; set; }
        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            string wherebarcode = "";
            string wherescala = "";
            List<SqlParameter> list = new List<SqlParameter>();
            if (enableSearch)
            {
                if (!string.IsNullOrEmpty(this.Stock))
                {
                    wherebarcode += "and RW01002=@stock ";
                    wherescala += "and SC33001=@stock ";
                    list.Add(new SqlParameter("@stock", this.Stock));
                }
                if (!string.IsNullOrEmpty(this.SupplierBatch))
                {
                    wherebarcode += "and RW01035=@supbatch ";
                    wherescala += "and SC33022=@supbatch ";
                    list.Add(new SqlParameter("@supbatch", this.SupplierBatch));
                }
                if (!string.IsNullOrEmpty(this.Warehouse))
                {
                    wherebarcode += "and RW01008=@wh ";
                    wherescala += "and SC33002=@wh ";
                    list.Add(new SqlParameter("@wh", this.Warehouse));
                }
                if (!string.IsNullOrEmpty(this.Bin))
                {
                    wherebarcode += "and RW01009=@bin ";
                    wherescala += "and SC33004=@bin ";
                    list.Add(new SqlParameter("@bin", this.Bin));
                }
            }
            BaseAdo ba = new BaseAdo();
            string sqlbarcode = @"
select RW01002,RW01008,RW01009,round(sum(RW01006/RW01040),2) KCQTY,RW01035,RW01034,round(sum(case when RW12001 is null then 0 else RW01006/RW01040 end),2) PDQTY FROM RW01 left join RW12 ON RW01001=RW12006
WHERE RW01032=2 [WHERE] GROUP BY  RW01002,RW01008,RW01009,RW01035,RW01034 order by RW01002,RW01008,RW01009";
            sqlbarcode = sqlbarcode.Replace("[WHERE]", wherebarcode);
            DataSet dsbarcode = ba.GetDataSet(sqlbarcode, list.ToArray());

            string sqlscala = @"
SELECT SC33001,SC33002,SC33004,round(SUM(SC33005),2) SC33005,SC33022,'31' Company FROM SC333100 
WHERE  SC33005<>0  [WHERE]
GROUP BY SC33001,SC33002,SC33004,SC33022
union all 
SELECT SC33001,SC33002,SC33004,round(SUM(SC33005),2) SC33005,SC33022,'32' Company FROM SC333200 
WHERE  SC33005<>0  [WHERE]
GROUP BY SC33001,SC33002,SC33004,SC33022 ORDER BY SC33022";
            sqlscala = sqlscala.Replace("[WHERE]", wherescala);
            ba.ConnectionStr = SysConfig.DBScalaConnection;
            DataSet dsscala = ba.GetDataSet(sqlscala, list.ToArray());
            List<RWStockReportModel> result = new List<RWStockReportModel>();
            foreach (DataRow item in dsbarcode.Tables[0].Rows)
            {
                RWStockReportModel rm = new RWStockReportModel()
                {
                    BarcodeQty = float.Parse(item["KCQTY"] + ""),
                    PDQTY = float.Parse(item["PDQTY"] + ""),
                    Bin = (item["RW01009"] + "").Trim(),
                    Warehouse = (item["RW01008"] + "").Trim(),
                    Stock = (item["RW01002"] + "").Trim(),
                    SupplierBatch = (item["RW01035"] + "").Trim(),
                    Company = (item["RW01034"] + "").Trim()
                };
                result.Add(rm);
            }
            foreach (DataRow item in dsscala.Tables[0].Rows)
            {
                RWStockReportModel rm = new RWStockReportModel()
                {
                    ScalaQty = float.Parse(item["SC33005"] + ""),
                    Bin = (item["SC33004"] + "").Trim(),
                    Warehouse = (item["SC33002"] + "").Trim(),
                    Stock = (item["SC33001"] + "").Trim(),
                    SupplierBatch = (item["SC33022"] + "").Trim(),
                    Company = (item["Company"] + "").Trim(),
                    PDQTY = 0
                };
                if (result.Exists(m => m.Warehouse == rm.Warehouse && m.Bin == rm.Bin && m.Stock == rm.Stock && m.SupplierBatch == rm.SupplierBatch && m.Company == rm.Company))
                {
                    RWStockReportModel rtemp = result.Find(m => m.Warehouse == rm.Warehouse && m.Bin == rm.Bin && m.Stock == rm.Stock && m.SupplierBatch == rm.SupplierBatch && m.Company == rm.Company);
                    rm.BarcodeQty = rtemp.BarcodeQty;
                    rm.PDQTY = rtemp.PDQTY;
                }
                else
                    result.Add(rm);
            }
            return result.ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
        }
    }
}
