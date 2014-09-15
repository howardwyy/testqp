using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    //成品条码表
    [Tablename(TableName = "FG01", PrimaryKey = "FG01001")]
    public class FGBarcodeModel : BaseSearchModel
    {
        //FG01001	varchar(30)	主键	主键
        [Columname(Name = "FG01001")]
        public string ID { get; set; }
        //FG01002	varchar(50)		物料stockcode
        [Columname(Name = "FG01002")]
        public string StockCode { get; set; }
        //FG01003	nvarchar(100)		物料name
        [Columname(Name = "FG01003")]
        public string StockName { get; set; }
        //FG01004	nvarchar(100)		物料规格
        [Columname(Name = "FG01004")]
        public string StockSpec { get; set; }
        //FG01005	nvarchar(10)		单位
        [Columname(Name = "FG01005")]
        public string Unit { get; set; }
        //FG01006	numeric(15,3)		包装量
        [Columname(Name = "FG01006")]
        public decimal UnitQty { get; set; }
        //FG01007	varchar(50)		批次
        [Columname(Name = "FG01007")]
        public string StockBatch { get; set; }
        //FG01008	varchar(10)		仓库
        [Columname(Name = "FG01008")]
        public string Warehouse { get; set; }
        //FG01009	varchar(10)		库位
        [Columname(Name = "FG01009")]
        public string Bin { get; set; }
        //FG01010	datetime		入库日期
        [Columname(Name = "FG01010")]
        public DateTime InWarehouseTime { get; set; }
        //FG01011	datetime		出库日期
        [Columname(Name = "FG01011")]
        public string OutWarehouseTime { get; set; }
        //FG01012	varchar(50)		供应商code
        [Columname(Name = "FG01012")]
        public string SupplierCode { get; set; }
        //FG01013	nvarchar(100)		供应商name
        [Columname(Name = "FG01013")]
        public string SupplierName { get; set; }
        //FG01014	varchar(50)		采购单号
        [Columname(Name = "FG01014")]
        public string SOID { get; set; }
        //FG01015	varchar(10)		采购单行号
        [Columname(Name = "FG01015")]
        public string SOLine { get; set; }
        //FG01016	varchar(10)		上一次仓库
        [Columname(Name = "FG01016")]
        public string LastWarehouse { get; set; }
        //FG01017	varchar(10)		上一次库位
        [Columname(Name = "FG01017")]
        public string LastBin { get; set; }
        //FG01018	nvarchar(100)		备注1
        [Columname(Name = "FG01018")]
        public string Remark1 { get; set; }
        //FG01019	nvarchar(100)		备注2
        [Columname(Name = "FG01019")]
        public string Remark2 { get; set; }
        //FG01020	varchar(50)		flowkey
        [Columname(Name = "FG01020")]
        public string FlowKey { get; set; }
        //FG01021	nvarchar(100)		flowkey DESC
        [Columname(Name = "FG01021")]
        public string FlowKeyDesc { get; set; }
        //FG01022	varchar(50)		RAW
        [Columname(Name = "FG01022")]
        public string RAW { get; set; }
        //FG01023	nvarchar(100)		RAW DESC
        [Columname(Name = "FG01023")]
        public string RAWDesc { get; set; }
        //FG01024	varchar(50)		最新的操作人id
        [Columname(Name = "FG01024")]
        public string UserID { get; set; }
        //FG01025	nvarchar(100)		最新的操作人name
        [Columname(Name = "FG01025")]
        public string UserName { get; set; }
        //FG01026	varchar(50)		最新的历史记录ID
        [Columname(Name = "FG01026")]
        public string LastHistoryID { get; set; }
        //FG01027	varchar(50)		单据号(最新)
        [Columname(Name = "FG01027")]
        public string LastBillID { get; set; }
        //FG01028	varchar(50)		客户id
        [Columname(Name = "FG01028")]
        public string CustomerCode { get; set; }
        //FG01029	nvarchar(100)		客户名称
        [Columname(Name = "FG01029")]
        public string CustomerName { get; set; }
        //FG01030	varchar(50)		销售单号
        [Columname(Name = "FG01029")]
        public string SO { get; set; }
        //FG01031	varchar(50)		装箱单ID
        [Columname(Name = "FG01031")]
        public string BoxID { get; set; }
        //FG01032	int		状态
        [Columname(Name = "FG01032")]
        public int Status { get; set; }
        //FG01033	varchar(50)		工单号
        [Columname(Name = "FG01033")]
        public string WO { get; set; }
        //FG01034	datetime		生产日期
        [Columname(Name = "FG01034")]
        public DateTime CreateTime { get; set; }
        //FG01035	datetime		保质期
        [Columname(Name = "FG01035")]
        public DateTime EXPTime { get; set; }
        //FG01036	varchar(30)		PAGECODE
        [Columname(Name = "FG01036")]
        public string PAGECODE { get; set; }
        //FG01037	varchar(3)		公司代码
        [Columname(Name = "FG01037")]
        public string Company { get; set; }
        //FG01038	int		LifeDate
        [Columname(Name = "FG01038")]
        public int LifeDate { get; set; }

        //应用于查询，搜索功能，入库，开始时间；
        public DateTime BeginTimeInWH { get; set; }
        //应用于查询，搜索功能，入库，结束时间；
        public DateTime EndTimeInWH { get; set; }

        //应用于查询，搜索功能，出库，开始时间；
        public DateTime BeginTimeOutWH { get; set; }
        //应用于查询，搜索功能，出库，结束时间；
        public DateTime EndTimeOutWH { get; set; }


        //应用于查询，搜索功能，生产日期，开始时间；
        public DateTime BeginCreateTime { get; set; }
        //应用于查询，搜索功能，生产日期，结束时间；
        public DateTime EndCreateTime { get; set; }


        //是否用分页
        public bool doPager { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<FGBarcodeModel> adoBarcode = new ModelAdo<FGBarcodeModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginTimeInWH.Equals(DateTime.MinValue) && !EndTimeInWH.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND FG01010 BETWEEN  @BeginTimeInWH AND @EndTimeInWH ");
                listParam.Add(new SqlParameter("@BeginTimeInWH", BeginTimeInWH));
                listParam.Add(new SqlParameter("@EndTimeInWH", EndTimeInWH));

            }
            if (!BeginTimeOutWH.Equals(DateTime.MinValue) && !EndTimeOutWH.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND FG01011 BETWEEN  @BeginTimeOutWH AND @EndTimeOutWH ");
                listParam.Add(new SqlParameter("@BeginTimeOutWH", BeginTimeOutWH));
                listParam.Add(new SqlParameter("@EndTimeOutWH", EndTimeOutWH));

            }

            if (!BeginCreateTime.Equals(DateTime.MinValue) && !EndCreateTime.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND FG01034 BETWEEN  @BeginCreateTime AND @EndCreateTime ");
                listParam.Add(new SqlParameter("@BeginCreateTime", BeginCreateTime));
                listParam.Add(new SqlParameter("@EndCreateTime", EndCreateTime));

            }
            if (!String.IsNullOrEmpty(this.WO))
            {
                sbWhere.Append(" AND FG01033 = @WO");
                listParam.Add(new SqlParameter("@WO", WO));
            }
            if (!String.IsNullOrEmpty(this.StockBatch))
            {
                sbWhere.Append(" AND FG01007 = @StockBatch");
                listParam.Add(new SqlParameter("@StockBatch", StockBatch));
            }
            if (!String.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND FG01001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (!String.IsNullOrEmpty(this.BoxID))
            {
                sbWhere.Append(" AND FG01031 = @BoxID ");
                listParam.Add(new SqlParameter("@BoxID", this.BoxID));
            }
            if (Status >= 1)
            {
                sbWhere.Append(" AND FG01032 = @Status ");
                listParam.Add(new SqlParameter("@Status", this.Status));
            }
            List<BaseSearchModel> models = null;
            if (this.doPager)
            {
                int count = 0;
                adoBarcode.PageSize = this.PageSize;
                models = adoBarcode.GetList(this.PageIndex, sbWhere.ToString(), " FG01001 DESC  ", out count, "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                base.totalCount = count;
            }
            else
            {
                models = adoBarcode.GetList(sbWhere.ToString(), " FG01001 DESC  ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
            }
            return models;
        }

    }
}
