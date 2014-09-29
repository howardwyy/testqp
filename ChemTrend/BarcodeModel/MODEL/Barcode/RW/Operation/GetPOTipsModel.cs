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
    /// 获取PO数据
    /// </summary>
    public class GetPOTipsModel : BaseSearchModel
    {
        //提示效果，返回值
        public string[] POS { get; set; }
        public string company { set; get; }
        public string tips { set; get; }

        /// <summary>
        ///  通过录入数据，获取提示PO订单号码
        /// </summary>
        /// <returns></returns>
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            ModelAdo<POLineModel> modelAdo = new ModelAdo<POLineModel>();
            List<string> pos = new List<string>();
            string strSql = "select top  10  T.PC01001 as PO   from (select distinct(PC01001) from view_poline where Company=@company and  charindex(@tips,PC01001)>0) T";
            DataSet ds = modelAdo.GetDataSet(strSql, new SqlParameter("@company", company), new SqlParameter("@tips", tips));
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string[] rs = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < rs.Length; i++)
                {
                    rs[i] = ds.Tables[0].Rows[i][0] + "";
                }
                this.POS = rs;
            }
            return this;
        }

    }
}
