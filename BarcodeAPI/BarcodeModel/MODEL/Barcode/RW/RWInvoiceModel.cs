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
        [Columname(Name = "RW18001")]
        public string ID { get; set; }

        [Columname(Name = "RW18002")]
        public DateTime CreateTime { get; set; }

        [Columname(Name = "RW18003")]
        public string UserID { get; set; }

        [Columname(Name = "RW18004")]
        public string UserName { get; set; }

        [Columname(Name = "RW18005")]
        public int Status { get; set; }

        [Columname(Name = "RW18009")]
        public string DeliveryNumber { get; set; }

        [Columname(Name = "RW18008")]
        public string SO { get; set; }

        [Columname(Name = "RW18006")]
        public string CustomerCode { get; set; }

        [Columname(Name = "RW18007")]
        public string CustomerName { get; set; }

        public DateTime BeginInvoiceTime { get; set; }

        public DateTime EndInvoiceTime { get; set; }

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
                sbWhere.Append(" AND RW18005 = @Status ");
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
