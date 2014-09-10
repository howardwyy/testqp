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
    /// 成品历史记录
    /// </summary>
    [Tablename(TableName = "FG02", PrimaryKey = "FG02001")]
    public class FGHistoryModel : BaseSearchModel
    {
        //FG02001	int	主键	主键
        [Columname(Name = "FG02001")]
        public int ID { get; set; }
        //FG02002	varchar(50)		条码ID
        [Columname(Name = "FG02002")]
        public string BarcodeID { get; set; }
        //FG02003	datetime		操作时间
        [Columname(Name = "FG02003")]
        public DateTime CreateTime { get; set; }
        //FG02004	varchar(50)		操作人id
        [Columname(Name = "FG02004")]
        public string UserID { get; set; }
        //FG02005	nvarchar(50)		操作人name
        [Columname(Name = "FG02005")]
        public string UserName { get; set; }
        //FG02006	varchar(50)		flowkey
        [Columname(Name = "FG02006")]
        public string flowkey { get; set; }
        //FG02007	nvarchar(50)		flowkey DESC
        [Columname(Name = "FG02007")]
        public string flowkeyDesc { get; set; }
        //FG02008	varchar(50)		RAW
        [Columname(Name = "FG02008")]
        public string RAW { get; set; }
        //FG02009	nvarchar(50)		RAW DESC
        [Columname(Name = "FG02009")]
        public string RAWDesc { get; set; }
        //FG02010	varchar(50)		单据号
        [Columname(Name = "FG02010")]
        public string BillID { get; set; }
        //FG02011	nvarchar(100)		操作备注
        [Columname(Name = "FG02011")]
        public string Remark { get; set; }

        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            ModelAdo<FGHistoryModel> adoRW = new ModelAdo<FGHistoryModel>();
            List<SqlParameter> listParam = new List<SqlParameter>();
            StringBuilder sbWhere = new StringBuilder();
            sbWhere.Append(" 1=1 ");

            if (!string.IsNullOrEmpty(this.BarcodeID))
            {
                sbWhere.Append(" AND FG02002 = @BarcodeID");
                listParam.Add(new SqlParameter("@BarcodeID", this.BarcodeID));
            }

            return adoRW.GetList(sbWhere.ToString(), " FG02001 DESC ", "*", listParam.ToArray()).ConvertAll<BaseSearchModel>(m => m as BaseSearchModel);

        }
    }
}
