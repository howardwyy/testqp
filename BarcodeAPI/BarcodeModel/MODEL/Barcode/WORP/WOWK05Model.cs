using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BarcodeModel.ADO;
using System.Data;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.WORP
{
    /// <summary>
    /// 半成品Issue
    /// </summary>
    [Tablename(TableName = "WK05", PrimaryKey = "WK05001")]
    public class WOWK05Model : BaseSearchModel
    {

        [Columname(Name = "WK05001")]
        public int ID { get; set; }

        [Columname(Name = "WK05003")]
        public string Workorder { get; set; }

        [Columname(Name = "WK05002")]
        public string Workcenter { get; set; }

        [Columname(Name = "WK05004")]
        public string BarcodeID { get; set; }

        [Columname(Name = "WK05005")]
        public string StockCode { get; set; }

        [Columname(Name = "WK05009")]
        public int HasExportXml { get; set; }

        [Columname(Name = "WK05006")]
        public decimal ReportQTY { get; set; }

        [Columname(Name = "WK05008")]
        public DateTime ReportTime { get; set; }

        /// <summary>
        /// 应用于查询，第四位包含字符串
        /// </summary>
        public string CharIndex { set; get; }

        /// <summary>
        /// 应用于查询，开始时间
        /// </summary>
        public DateTime BeginReportTime { get; set; }

        /// <summary>
        /// 应用于查询，结束时间
        /// </summary>
        public DateTime EndReportTime { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<WOWK05Model> adoIssue = new ModelAdo<WOWK05Model>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginReportTime.Equals(DateTime.MinValue) && !EndReportTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND WK05008 BETWEEN  @BeginReportTime AND @EndReportTime ");
                listParam.Add(new SqlParameter("@BeginReportTime", BeginReportTime));
                listParam.Add(new SqlParameter("@EndReportTime", EndReportTime));

            }
            //if (HasExportXml >= 0)
            //{
            //    sbWhere.Append(" AND WK05009 = @HasExportXml ");
            //    listParam.Add(new SqlParameter("@HasExportXml", HasExportXml));

            //}
            if (!string.IsNullOrEmpty(CharIndex))
            {
                sbWhere.Append(" AND SUBSTRING(WK05003,4,1)=@CharIndex ");
                listParam.Add(new SqlParameter("@CharIndex", CharIndex));
            }
            List<BaseSearchModel> models = null;
            models = adoIssue.GetList(sbWhere.ToString(), SearchOrderBy, "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);

            return models;
        }



    }
}
