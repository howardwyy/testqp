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
    /// 原材料单据表
    /// </summary>
    [Tablename(TableName = "RW03", PrimaryKey = "RW03001")]
    public class BillModel : BaseSearchModel
    {
        // RW03001	varchar(30)	主键	主键
        [Columname(Name = "RW03001")]
        public string ID { get; set; }
        //RW03002	datetime		操作时间
        [Columname(Name = "RW03002")]
        public DateTime CreateTime { get; set; }
        //RW03003	varchar(50)		操作人id
        [Columname(Name = "RW03003")]
        public string UserId { get; set; }
        //RW03004	nvarchar(50)		操作人name
        [Columname(Name = "RW03004")]
        public string UserName { get; set; }
        //RW03005	varchar(50)		flowkey
        [Columname(Name = "RW03005")]
        public string Flowkey { get; set; }
        //RW03006	varchar(50)		flowdesc
        [Columname(Name = "RW03006")]
        public string FlowName { get; set; }
        //RW03007	varchar(50)		领料单id
        [Columname(Name = "RW03007")]
        public string RequisitionId { get; set; }
        //RW03008	varchar(50)		操作备注
        [Columname(Name = "RW03008")]
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
                sbWhere.Append(" AND RW03002 BETWEEN  @BeginTime AND @EndTime ");
                listParam.Add(new SqlParameter("@BeginTime", BeginTime));
                listParam.Add(new SqlParameter("@EndTime", EndTime));
            }
            if (!string.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND RW03001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (!string.IsNullOrEmpty(this.UserName))
            {
                sbWhere.Append(" AND RW03004=@UserName");
                listParam.Add(new SqlParameter("@UserName", UserName));
            }

            if (!string.IsNullOrEmpty(this.Remark))
            {
                sbWhere.Append(" AND RW03008=@Remark");
                listParam.Add(new SqlParameter("@Remark", Remark));
            }

            return adoBill.GetList(sbWhere.ToString(), " RW03002 DESC ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
        }
    }
}
