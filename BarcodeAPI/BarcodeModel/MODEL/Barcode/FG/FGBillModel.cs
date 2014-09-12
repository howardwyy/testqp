using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW
{
    /// <summary>
    /// 成品单据表
    /// </summary>
    [Tablename(TableName = "FG03", PrimaryKey = "FG03001")]
    public class FGBillModel : BaseSearchModel
    {
        // FG03001	varchar(30)	主键	主键
        [Columname(Name = "FG03001")]
        public string ID { get; set; }
        //FG03002	datetime		操作时间
        [Columname(Name = "FG03002")]
        public DateTime CreateTime { get; set; }
        //FG03003	varchar(50)		操作人id
        [Columname(Name = "FG03003")]
        public string UserId { get; set; }
        //FG03004	nvarchar(50)		操作人name
        [Columname(Name = "FG03004")]
        public string UserName { get; set; }
        //FG03005	varchar(50)		flowkey
        [Columname(Name = "FG03005")]
        public string Flowkey { get; set; }
        //FG03006	varchar(50)		flowdesc
        [Columname(Name = "FG03006")]
        public string FlowName { get; set; }
        //FG03007	varchar(50)		领料单id
        [Columname(Name = "FG03007")]
        public string RequisitionId { get; set; }
        //FG03008	varchar(50)		操作备注
        [Columname(Name = "FG03008")]
        public string Remark { get; set; }

        //应用于查询，搜索功能，开始时间；
        public DateTime BeginTime { get; set; }
        //应用于查询，搜索功能，结束时间；
        public DateTime EndTime { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<FGBillModel> adoBill = new ModelAdo<FGBillModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginTime.Equals(DateTime.MinValue) && !EndTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND FG03002 BETWEEN  @BeginTime AND @EndTime ");
                listParam.Add(new SqlParameter("@BeginTime", BeginTime));
                listParam.Add(new SqlParameter("@EndTime", EndTime));
            }
            if (!string.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND FG03001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (!string.IsNullOrEmpty(this.UserName))
            {
                sbWhere.Append(" AND FG03004=@UserName");
                listParam.Add(new SqlParameter("@UserName", UserName));
            }

            if (!string.IsNullOrEmpty(this.Remark))
            {
                sbWhere.Append(" AND FG03008=@Remark");
                listParam.Add(new SqlParameter("@Remark", Remark));
            }

            return adoBill.GetList(sbWhere.ToString(), " FG03002 DESC ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
        }
    }
}
