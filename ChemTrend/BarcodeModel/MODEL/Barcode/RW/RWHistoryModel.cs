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
    /// 原材料历史记录
    /// </summary>
    [Tablename(TableName = "RW02", PrimaryKey = "RW02001")]
    public class RWHistoryModel : BaseSearchModel
    {
        //RW02001	int	主键	主键
        [Columname(Name = "RW02001")]
        public int ID { get; set; }
        //RW02002	varchar(50)		条码ID
        [Columname(Name = "RW02002")]
        public string BarcodeID { get; set; }
        //RW02003	datetime		操作时间
        [Columname(Name = "RW02003")]
        public DateTime CreateTime { get; set; }
        //RW02004	varchar(50)		操作人id
        [Columname(Name = "RW02004")]
        public string UserID { get; set; }
        //RW02005	nvarchar(50)		操作人name
        [Columname(Name = "RW02005")]
        public string UserName { get; set; }
        //RW02006	varchar(50)		flowkey
        [Columname(Name = "RW02006")]
        public string flowkey { get; set; }
        //RW02007	nvarchar(50)		flowkey DESC
        [Columname(Name = "RW02007")]
        public string flowkeyDesc { get; set; }
        //RW02008	varchar(50)		RAW
        [Columname(Name = "RW02008")]
        public string RAW { get; set; }
        //RW02009	nvarchar(50)		RAW DESC
        [Columname(Name = "RW02009")]
        public string RAWDesc { get; set; }
        //RW02010	varchar(50)		单据号
        [Columname(Name = "RW02010")]
        public string BillID { get; set; }
        //RW02011	nvarchar(100)		操作备注
        [Columname(Name = "RW02011")]
        public string Remark { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<RWHistoryModel> adoRW = new ModelAdo<RWHistoryModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");

            if (!string.IsNullOrEmpty(this.BarcodeID))
            {
                sbWhere.Append(" AND RW02002 = @BarcodeID");
                listParam.Add(new SqlParameter("@BarcodeID", this.BarcodeID));
            }

            return adoRW.GetList(sbWhere.ToString(), " RW02001 DESC ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);

        }
    }
}
