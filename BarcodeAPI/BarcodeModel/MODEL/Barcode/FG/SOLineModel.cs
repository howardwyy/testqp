using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.FG
{
    /// <summary>
    /// 发货单中SOLine
    /// </summary>
    [Tablename(TableName = "view_SOLine", PrimaryKey = "OR01001", ViewName = "view_SOLine", IsScalaDB = true)]
    public class SOLineModel : BaseSearchModel
    {
        [Columname(Name = "OR01001")]
        public string OrderNumber { get; set; }

        [Columname(Name = "OR03002")]
        public string LineNumber { get; set; }

        [Columname(Name = "OR03005")]
        public string StockCode { get; set; }

        [Columname(Name = "OR03006")]
        public string StockName { get; set; }

        [Columname(Name = "OR03007")]
        public string StockSpec { get; set; }

        [Columname(Name = "SC01035")]
        public string StockType { get; set; }

        [Columname(Name = "UNIT")]
        public string Unit { get; set; }

        [Columname(Name = "OR03011")]
        public decimal OrderQty { get; set; }

        [Columname(Name = "OR01003")]
        public string CustomerCode { get; set; }

        [Columname(Name = "SL01002")]
        public string CustomerName { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }

        [Columname(Name = "OR01015")]
        public DateTime OrderDate { get; set; }

        [Columname(Name = "OR03008")]
        public decimal Price { get; set; }

        [Columname(Name = "OR03046")]
        public string Warehouse { get; set; }

        public string Batch { get; set; }

        public string DeliveryNumber { get; set; }

        public bool IsCenterWarehouse { get; set; }

        public string[] ReturnDeliveryNumbers { get; set; }
        public override BaseSearchModel GetModelByID(string id)
        {
            string sql = "select distinct(OR19012) OR19012 from view_SODeliveryLine where Company=@com and OR19001=@so";
            DataSet ds = this.GetADO().GetDataSet(sql, new SqlParameter("@com", this.Company), new SqlParameter("@so", this.OrderNumber));
            this.ReturnDeliveryNumbers = new string[ds.Tables[0].Rows.Count];
            int i = 0;
            foreach (DataRow item in ds.Tables[0].Rows)
            {
                this.ReturnDeliveryNumbers[i++] = item[0] + "";
            }
            return this;
        }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            if (this.IsCenterWarehouse)
            {
                string sql = @"select * from view_SODeliveryLine where Company=@com and OR19012=@dn";
                DataSet ds = this.GetADO().GetDataSet(sql, new SqlParameter("@com", this.Company), new SqlParameter("@dn", this.DeliveryNumber));
                List<SOLineModel> list = new List<SOLineModel>();
                foreach (DataRow item in ds.Tables[0].Rows)
                {
                    SOLineModel sm = new SOLineModel()
                    {
                        Company = item["Company"] + "",
                        CustomerCode = item["OR01003"] + "",
                        CustomerName = item["SL01002"] + "",
                        DeliveryNumber = item["OR19012"] + "",
                        IsCenterWarehouse = true,
                        LineNumber = item["OR19002"] + "",
                        OrderDate = DateTime.Parse(item["OR01015"] + ""),
                        OrderNumber = item["OR19001"] + "",
                        OrderQty = decimal.Parse(item["OR19007"] + ""),
                        StockCode = item["OR03005"] + "",
                        StockName = item["OR03006"] + "",
                        StockSpec = item["OR03007"] + "",
                        StockType = item["SC01035"] + "",
                        Unit = item["UNIT"] + "",
                        Warehouse = item["OR03046"] + "",
                        Batch = item["SC33022"] + ""
                    };
                    list.Add(sm);
                }
                return list.ConvertAll<BaseSearchModel>(m => m as SOLineModel);
            }
            else
                return base.GetALL(enableSearch);
        }
    }
}
