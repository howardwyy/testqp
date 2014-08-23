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
        // GF03001	varchar(30)	主键	主键
        [Columname(Name = "GF03001")]
        public string ID { get; set; }
        //GF03002	datetime		操作时间
        [Columname(Name = "GF03002")]
        public DateTime CreateTime { get; set; }
        //GF03003	varchar(50)		操作人id
        [Columname(Name = "GF03003")]
        public string UserId { get; set; }
        //GF03004	nvarchar(50)		操作人name
        [Columname(Name = "GF03004")]
        public string UserName { get; set; }
        //GF03005	varchar(50)		flowkey
        [Columname(Name = "GF03005")]
        public string Flowkey { get; set; }
        //GF03006	varchar(50)		flowdesc
        [Columname(Name = "GF03006")]
        public string FlowName { get; set; }
        //GF03007	varchar(50)		领料单id
        [Columname(Name = "GF03007")]
        public string RequisitionId { get; set; }
        //GF03008	varchar(50)		操作备注
        [Columname(Name = "GF03008")]
        public string Remark { get; set; }

        //应用于查询，搜索功能，开始时间；
        public DateTime BeginTime { get; set; }
        //应用于查询，搜索功能，结束时间；
        public DateTime EndTime { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<BillModel> adoBill = new ModelAdo<BillModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginTime.Equals(DateTime.MinValue) && !EndTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND GF03002 BETWEEN  @BeginTime AND @EndTime ");
                listParam.Add(new SqlParameter("@BeginTime", BeginTime));
                listParam.Add(new SqlParameter("@EndTime", EndTime));
            }
            if (!string.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND GF03001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (!string.IsNullOrEmpty(this.UserName))
            {
                sbWhere.Append(" AND GF03004=@UserName");
                listParam.Add(new SqlParameter("@UserName", UserName));
            }

            if (!string.IsNullOrEmpty(this.Remark))
            {
                sbWhere.Append(" AND GF03008=@Remark");
                listParam.Add(new SqlParameter("@Remark", Remark));
            }

            return adoBill.GetList(sbWhere.ToString(), " GF03002 DESC ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
        }
    }
}
