using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
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



        public bool doPager { get; set; }
    }
}
