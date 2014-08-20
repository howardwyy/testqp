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
    /// 原材料领料单
    /// </summary>
    [Tablename(TableName = "RW08", PrimaryKey = "RW08001")]
    public class ReceiveModel : BaseSearchModel
    {
        //RW08001	varchar(30)	主键	主键
        [Columname(Name = "RW08001")]
        public string ID { get; set; }
        //RW08002	datetime		创建时间
        [Columname(Name = "RW08002")]
        public DateTime CreateTime { get; set; }
        //RW08003	varchar(50)		操作人id
        [Columname(Name = "RW08003")]
        public string UserID { get; set; }
        //RW08004	nvarchar(50)		操作人name
        [Columname(Name = "RW08004")]
        public string UserName { get; set; }
        //RW08005	datetime		期望收货日期
        [Columname(Name = "RW08005")]
        public DateTime HopeTime { get; set; }
        //RW08006	int		是否紧急
        [Columname(Name = "RW08006")]
        public int isUrgent { get; set; }
        //RW08007	nvarchar(100)		备注
        [Columname(Name = "RW08007")]
        public string Remark { get; set; }
        //RW08008	int		状态(1已申请 2部分发货 3关闭)
        [Columname(Name = "RW08008")]
        public int Status { get; set; }
        //RW08009	varchar(50)		from warehouse
        [Columname(Name = "RW08009")]
        public string FromWC { get; set; }
        //RW08010	nvarchar(50)		from warehouse name
        [Columname(Name = "RW08010")]
        public string FromWN { get; set; }
        //RW08011	varchar(50)		to warehouse
        [Columname(Name = "RW08011")]
        public string ToWC { get; set; }
        //RW08012	nvarchar(50)		to warehouse name
        [Columname(Name = "RW08012")]
        public string ToWN { get; set; }

        //应用于查询，搜索功能，领料单，开始时间；
        public DateTime BeginTimeReceiveTime { get; set; }
        //应用于查询，搜索功能，领料单，结束时间；
        public DateTime EndTimeReceiveTime { get; set; }
        //是否用分页
        public bool doPager { set; get; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<ReceiveModel> adoPick = new ModelAdo<ReceiveModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginTimeReceiveTime.Equals(DateTime.MinValue) && !EndTimeReceiveTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND RW08002 BETWEEN  @BeginTimePickTime AND @EndTimeInWH ");
                listParam.Add(new SqlParameter("@BeginTimePickTime", BeginTimeReceiveTime));
                listParam.Add(new SqlParameter("@EndTimePickTime", EndTimeReceiveTime));

            }

            if (!String.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND RW08001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (Status >= 1)
            {
                sbWhere.Append(" AND RW08008 = @Status ");
                listParam.Add(new SqlParameter("@Status", this.Status));
            }
            List<BaseSearchModel> models = null;
            if (this.doPager)
            {
                int count = 0;
                adoPick.PageSize = this.PageSize;
                models = adoPick.GetList(this.PageIndex, sbWhere.ToString(), " RW08001 DESC  ", out count, "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                base.totalCount = count;
            }
            else
            {
                models = adoPick.GetList(sbWhere.ToString(), " RW08001 DESC  ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
            }
            return models;
        }
    }
}
