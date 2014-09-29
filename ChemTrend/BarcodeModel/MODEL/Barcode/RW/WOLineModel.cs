using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.RW
{
    [Tablename(TableName = "view_WOLine", PrimaryKey = "MP65001", IsScalaDB = true, ViewName = "view_WOLine")]
    public class WOLineModel : BaseSearchModel
    {
        [Columname(Name = "StockCode")]
        public string StockCode { get; set; }

        [Columname(Name = "StockName")]
        public string StockName { get; set; }

        [Columname(Name = "Unit")]
        public string Unit { get; set; }

        [Columname(Name = "PlanQty")]
        public string PlanQTY { get; set; }

        [Columname(Name = "MP65003")]
        public string Number { get; set; }

        [Columname(Name = "MP65042")]
        public string OperationNO { get; set; }


        [Columname(Name = "MP65001")]
        public string WO { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }


        //提示效果，返回值
        public string[] WOS { get; set; }

        /// <summary>
        /// 通过录入数据，获取提示PO订单号码
        /// </summary>
        /// <returns></returns>
        public override BaseSearchModel GetModelByID(string id)
        {
            ModelAdo<WOLineModel> modelAdo = new ModelAdo<WOLineModel>();
            List<string> pos = new List<string>();
            string strSql = "select top  10  T.MP64001 as PO   from (select distinct(MP64001) from view_WO where  charindex(@tips,MP65001)>0) T";
            DataSet ds = modelAdo.GetDataSet(strSql, new SqlParameter("@tips", id));
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string[] rs = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < rs.Length; i++)
                {
                    rs[i] = ds.Tables[0].Rows[i][0] + "";
                }
                this.WOS = rs;
            }
            return this;
        }

    }
}
