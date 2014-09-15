using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    /// <summary>
    /// FG08	成品发货单	
    /// </summary>
    [Tablename(TableName = "FG08", PrimaryKey = "FG08001")]
    public class InvoiceModel : BaseSearchModel
    {
        //FG08001	varchar(30)	主键	主键
        [Columname(Name = "FG08001")]
        public string ID { get; set; }
        //FG08002	datetime		创建时间
        [Columname(Name = "FG08002")]
        public DateTime CreateTime { get; set; }
        //FG08003	varchar(50)		操作人id
        [Columname(Name = "FG08003")]
        public string UserID { get; set; }
        //FG08004	nvarchar(50)		操作人name
        [Columname(Name = "FG08004")]
        public string UserName { get; set; }
        //FG08005	datetime		期望收货日期
        [Columname(Name = "FG08005")]
        public DateTime HopeTime { get; set; }
        //FG08006	int		是否紧急
        [Columname(Name = "FG08006")]
        public int isUrgent { get; set; }
        //FG08007	nvarchar(100)		备注
        [Columname(Name = "FG08007")]
        public string Remark { get; set; }
        //FG08008	int		状态(1已申请 2部分发货 3关闭)
        [Columname(Name = "FG08008")]
        public int Status { get; set; }
        //FG08009	varchar(50)		from warehouse
        [Columname(Name = "FG08009")]
        public string fromWHID { get; set; }
        //FG08010	nvarchar(50)		from warehouse name
        [Columname(Name = "FG08010")]
        public string fromWHName { get; set; }
        //FG08011	varchar(50)		CustomerCode
        [Columname(Name = "FG08011")]
        public string CustomerCode { get; set; }
        //FG08012	nvarchar(50)		CustomerName
        [Columname(Name = "FG08012")]
        public string CustomerName { get; set; }
        
        //应用于查询，搜索功能，领料单，开始时间；
        public DateTime BeginInvoiceTime { get; set; }
        //应用于查询，搜索功能，领料单，结束时间；
        public DateTime EndInvoiceTime { get; set; }
        //是否用分页
        public bool doPager { set; get; }

         public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<InvoiceModel> ado = new ModelAdo<InvoiceModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginInvoiceTime.Equals(DateTime.MinValue) && !EndInvoiceTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND FG08002 BETWEEN  @BeginInvoiceTime AND @EndInvoiceTime ");
                listParam.Add(new SqlParameter("@BeginInvoiceTime", BeginInvoiceTime));
                listParam.Add(new SqlParameter("@EndInvoiceTime", EndInvoiceTime));

            }

            if (!String.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND FG08001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (Status >= 1)
            {
                sbWhere.Append(" AND FG08008 = @Status ");
                listParam.Add(new SqlParameter("@Status", this.Status));
            }
            List<BaseSearchModel> models = null;
            if (this.doPager)
            {
                int count = 0;
                ado.PageSize = this.PageSize;
                models = ado.GetList(this.PageIndex, sbWhere.ToString(), " FG08001 DESC  ", out count, "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                base.totalCount = count;
            }
            else
            {
                models = ado.GetList(sbWhere.ToString(), " FG08001 DESC  ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
            }
            return models;
        }
    }
}
