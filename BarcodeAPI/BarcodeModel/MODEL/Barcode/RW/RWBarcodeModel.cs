using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.RW
{
    [Tablename(TableName = "RW01", PrimaryKey = "RW01001")]
    public class RWBarcodeModel : BaseSearchModel
    {
        [Columname(Name = "RW01001")]
        public string ID { get; set; }

        [Columname(Name = "RW01002")]
        public string StockCode { get; set; }

        [Columname(Name = "RW01003")]
        public string StockName { get; set; }

        [Columname(Name = "RW01004")]
        public string StockSpec { get; set; }

        [Columname(Name = "RW01005")]
        public string StockUnit { get; set; }

        [Columname(Name = "RW01006")]
        public decimal StockUnitQty { get; set; }

        [Columname(Name = "RW01007")]
        public string StockBatch { get; set; }

        [Columname(Name = "RW01008")]
        public string Warehouse { get; set; }

        [Columname(Name = "RW01009")]
        public string Location { get; set; }

        [Columname(Name = "RW01010")]
        public DateTime WarehouseInTime { get; set; }

        [Columname(Name = "RW01011")]
        public DateTime WarehouseOutTime { get; set; }

        [Columname(Name = "RW01012")]
        public string SupplierCode { get; set; }

        [Columname(Name = "RW01013")]
        public string SupplierName { get; set; }

        [Columname(Name = "RW01014")]
        public string PO { get; set; }

        [Columname(Name = "RW01015")]
        public string POLine { get; set; }

        [Columname(Name = "RW01016")]
        public string LastWarehouse { get; set; }

        [Columname(Name = "RW01017")]
        public string LastLocation { get; set; }

        [Columname(Name = "RW01018")]
        public string Remark1 { get; set; }

        [Columname(Name = "RW01019")]
        public string Remark2 { get; set; }

        [Columname(Name = "RW01020")]
        public string FlowKey { get; set; }

        [Columname(Name = "RW01021")]
        public string FlowName { get; set; }

        [Columname(Name = "RW01022")]
        public string RAWCode { get; set; }

        [Columname(Name = "RW01023")]
        public string RAWName { get; set; }

        [Columname(Name = "RW01024")]
        public string LastUser { get; set; }

        [Columname(Name = "RW01025")]
        public string LastUserName { get; set; }

        [Columname(Name = "RW01026")]
        public string LastHistoryID { get; set; }

        [Columname(Name = "RW01027")]
        public string Bill { get; set; }

        [Columname(Name = "RW01028")]
        public string CustomerCode { get; set; }

        [Columname(Name = "RW01029")]
        public string CustomerName { get; set; }

        [Columname(Name = "RW01030")]
        public string SO { get; set; }

        [Columname(Name = "RW01031")]
        public string BoxID { get; set; }

        [Columname(Name = "RW01032")]
        public int Status { get; set; }

        [Columname(Name = "RW01033")]
        public string WO { get; set; }

        [Columname(Name = "RW01034")]
        public string CompanyCode { get; set; }

        //供应商的batch
        [Columname(Name = "RW01035")]
        public string SupplierBatch { get; set; }

        //batch ID
        [Columname(Name = "RW01036")]
        public string BatchID { get; set; }

        //应用于查询，搜索功能，入库，开始时间；
        public DateTime BeginTimeInWH { get; set; }
        //应用于查询，搜索功能，入库，结束时间；
        public DateTime EndTimeInWH { get; set; }

        //应用于查询，搜索功能，出库，开始时间；
        public DateTime BeginTimeOutWH { get; set; }
        //应用于查询，搜索功能，出库，结束时间；
        public DateTime EndTimeOutWH { get; set; }
        //是否用分页
        public bool doPager { set; get; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<RWBarcodeModel> adoBarcode = new ModelAdo<RWBarcodeModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");
            if (!BeginTimeInWH.Equals(DateTime.MinValue) && !EndTimeInWH.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND RW01010 BETWEEN  @BeginTimeInWH AND @EndTimeInWH ");
                listParam.Add(new SqlParameter("@BeginTimeInWH", BeginTimeInWH));
                listParam.Add(new SqlParameter("@EndTimeInWH", EndTimeInWH));

            }
            if (!BeginTimeOutWH.Equals(DateTime.MinValue) && !EndTimeOutWH.Equals(DateTime.MinValue))
            {
                sbWhere.Append(" AND RW01011 BETWEEN  @BeginTimeOutWH AND @EndTimeOutWH ");
                listParam.Add(new SqlParameter("@BeginTimeOutWH", BeginTimeOutWH));
                listParam.Add(new SqlParameter("@EndTimeOutWH", EndTimeOutWH));

            }
            if (!String.IsNullOrEmpty(this.ID))
            {
                sbWhere.Append(" AND RW01001 = @ID");
                listParam.Add(new SqlParameter("@ID", ID));
            }
            if (!String.IsNullOrEmpty(this.StockCode))
            {
                sbWhere.Append(" AND RW01002 = @StockCode");
                listParam.Add(new SqlParameter("@StockCode", StockCode));
            }
            if (!String.IsNullOrEmpty(this.StockName)) {
                sbWhere.Append(" AND RW01003 = @StockName");
                listParam.Add(new SqlParameter("@StockName", StockName));
            }
            if (!String.IsNullOrEmpty(this.BoxID))
            {
                sbWhere.Append(" AND RW01031 = @BoxID ");
                listParam.Add(new SqlParameter("@BoxID", this.BoxID));
            }
            if (!String.IsNullOrEmpty(this.SupplierBatch)) 
            {
                sbWhere.Append(" AND RW01035 = @SupplierBatch ");
                listParam.Add(new SqlParameter("@SupplierBatch", this.SupplierBatch));    
            }
            if (!String.IsNullOrEmpty(this.BatchID))
            {
                sbWhere.Append(" AND RW01036 = @BatchID ");
                listParam.Add(new SqlParameter("@BatchID", this.BatchID));
            }
            if (!String.IsNullOrEmpty(this.PO))
            {
                sbWhere.Append(" AND RW01014 = @PO ");
                listParam.Add(new SqlParameter("@PO", this.PO));
            }
            if (Status >= 1)
            {
                sbWhere.Append(" AND RW01032 = @Status ");
                listParam.Add(new SqlParameter("@Status", this.Status));
            }
            List<BaseSearchModel> models = null;
            if (this.doPager)
            {
                int count = 0;
                adoBarcode.PageSize = this.PageSize;
                models = adoBarcode.GetList(this.PageIndex, sbWhere.ToString(),SearchOrderBy , out count, "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
                base.totalCount = count;
            }
            else
            {
                models = adoBarcode.GetList(sbWhere.ToString(), SearchOrderBy , "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);
            }
            return models;
        }


    }


}
