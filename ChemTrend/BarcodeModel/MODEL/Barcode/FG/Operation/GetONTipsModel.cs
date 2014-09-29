using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 获取OrderNumber数据
    /// </summary>
    public class GetONTipsModel : BaseSearchModel
    {
        //提示效果，返回值
        public string[] ONS { get; set; }
        public string company { set; get; }
        public string tips;
        /// <summary>
        /// 通过录入数据，获取提示WO订单号码
        /// </summary>
        /// <returns></returns>
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            ModelAdo<SOLineModel> ba = new ModelAdo<SOLineModel>();
            List<string> ons = new List<string>();
            string strSql = "select top  10  T.OR01001 as PO   from (select distinct(OR01001) from view_SOLine where Company=@company and  charindex(@tips,OR01001)>0) T";

            DataSet ds = ba.GetDataSet(strSql, new SqlParameter("@company", company), new SqlParameter("@tips", tips));
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string[] rs = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < rs.Length; i++)
                {
                    rs[i] = ds.Tables[0].Rows[i][0] + "";
                }
                this.ONS = rs;
            }
            return this;
        }
    }
}
