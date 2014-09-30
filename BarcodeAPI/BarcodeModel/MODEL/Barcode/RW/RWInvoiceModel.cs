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
    /// RW18	原材料发货单	
    /// </summary>
    [Tablename(TableName = "RW18", PrimaryKey = "RW18001")]
    public class RWInvoiceModel : BaseSearchModel
    {
        //RW18001	varchar(30)	主键	主键
        [Columname(Name = "RW18001")]
        public string ID { get; set; }
        //RW18002	datetime		创建时间
        [Columname(Name = "RW18002")]
        public DateTime CreateTime { get; set; }
        //RW18003	varchar(50)		操作人id
        [Columname(Name = "RW18003")]
        public string UserID { get; set; }
        //RW18004	nvarchar(50)		操作人name
        [Columname(Name = "RW18004")]
        public string UserName { get; set; }
        //RW18005	datetime		期望收货日期
        [Columname(Name = "RW18005")]
        public DateTime HopeTime { get; set; }
        //RW18006	int		是否紧急
        [Columname(Name = "RW18006")]
        public int isUrgent { get; set; }
        //RW18007	nvarchar(100)		备注
        [Columname(Name = "RW18007")]
        public string Remark { get; set; }
        //RW18008	int		状态(1已申请 2部分发货 3关闭)
        [Columname(Name = "RW18008")]
        public int Status { get; set; }
        //RW18009	varchar(50)		from warehouse
        [Columname(Name = "RW18009")]
        public string fromWHID { get; set; }
        //RW18010	nvarchar(50)		from warehouse name
        [Columname(Name = "RW18010")]
        public string fromWHName { get; set; }
        //RW18011	varchar(50)		CustomerCode
        [Columname(Name = "RW18011")]
        public string CustomerCode { get; set; }
        //RW18012	nvarchar(50)		CustomerName
        [Columname(Name = "RW18012")]
        public string CustomerName { get; set; }
        
        //应用于查询，搜索功能，领料单，开始时间；
        public DateTime BeginInvoiceTime { get; set; }
        //应用于查询，搜索功能，领料单，结束时间；
        public DateTime EndInvoiceTime { get; set; }
        //是否用分页
        public bool doPager { set; get; }

         public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<RWInvoiceModel> ado = new ModelAdo<RWInvoiceModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginInvoiceTime.Equals(DateTime.MinValue) && !EndInvoiceTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND RW18002 BETWEEN  @BeginInvoiceTime AND @EndInvoiceTime ");
                listParam.Add(new SqlParameter("@BeginInvoiceTime", BeginInvoiceTime));
                listParam.Add(new SqlParameter("@EndInvoiceTime", EndInvoiceTime));

            }

            if (!String.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND RW18001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (Status >= 1)
            {
                sbWhere.Append(" AND RW18008 = @Status ");
                listParam.Add(new SqlParameter("@Status", this.Status));
            }
            List<BaseSearchModel> models = null;
            if (this.doPager)
            {
                int count = 0;
                ado.PageSize = this.PageSize;
                models = ado.GetList(this.PageIndex, sbWhere.ToString(), " RW18001 DESC  ", out count, "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                base.totalCount = count;
            }
            else
            {
                models = ado.GetList(sbWhere.ToString(), " RW18001 DESC  ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
            }
            return models;
        }
    }
}
