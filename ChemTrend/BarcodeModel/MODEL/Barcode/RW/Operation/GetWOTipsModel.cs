using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 获取WO数据
    /// </summary>
    public class GetWOTipsModel : BaseSearchModel
    {
        //提示效果，返回值
        public string[] WOS { get; set; }

        /// <summary>
        /// 通过录入数据，获取提示WO订单号码
        /// </summary>
        /// <returns></returns>
        public override BaseSearchModel GetModelByID(string id)
        {
            ModelAdo<WOLineModel> ba = new ModelAdo<WOLineModel>();
            List<string> pos = new List<string>();
            string strSql = "select top  10  T.MP64001 as PO   from (select distinct(MP64001) from view_WO where  charindex(@tips,MP64001)>0) T";
            DataSet ds = ba.GetDataSet(strSql, new SqlParameter("@tips", id));
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
