using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.WORP
{
    /// <summary>
    /// 工作中心运行时间
    /// </summary>
    [Tablename(TableName = "Bar_WC_Runtime", PrimaryKey = "WorkOrderNO", ViewName = "Bar_WC_Runtime", IsScalaDB = true)]
    public class WCTimeModel : BaseSearchModel
    {
        [Columname(Name = "WorkOrderNO")]
        public string WorkOrderNO { set; get; }

        [Columname(Name = "StockCode")]
        public string StockCode { set; get; }

        [Columname(Name = "DueDate")]
        public DateTime DueDate { set; get; }

        [Columname(Name = "WorkCenter")]
        public string WorkCenter { set; get; }

        [Columname(Name = "WC_Des")]
        public string WC_Des { set; get; }

        [Columname(Name = "OperationNO")]
        public string OperationNO { get; set; }

        [Columname(Name = "Family")]
        public string Family { get; set; }

        [Columname(Name = "BeginTime")]
        public DateTime BeginTime { set; get; }

        [Columname(Name = "EndTime")]
        public DateTime EndTime { set; get; }

        public DateTime QueryBeginTime { get; set; }
        public DateTime QueryEndTime { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<WCTimeModel> adoWCTime = new ModelAdo<WCTimeModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!QueryBeginTime.Equals(DateTime.MinValue) && !QueryEndTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND DueDate BETWEEN  @QueryBeginTime AND @QueryEndTime ");
                listParam.Add(new SqlParameter("@QueryBeginTime", QueryBeginTime));
                listParam.Add(new SqlParameter("@QueryEndTime", QueryEndTime));

            } 
            List<BaseSearchModel> models = null;
            models = adoWCTime.GetList(sbWhere.ToString(), SearchOrderBy, "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);

            return models;
        }
    }
}
