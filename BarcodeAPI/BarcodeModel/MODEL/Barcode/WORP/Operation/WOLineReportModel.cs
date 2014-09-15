using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;
using System.Data.SqlClient;

namespace BarcodeModel.MODEL.Barcode.WORP.Operation
{
    public class WOLineReportModel : BaseSearchModel
    {
        public int ReportLineID { get; set; }
        public string RWID { get; set; }
        public float DeQTY { get; set; }
        public string WorkOrder { get; set; }
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            string sql = @"
update RW01 set RW01006=RW01006-@deqty where RW01001=@bid

insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
select RW01001,getdate(),@userid,@username,@dj,N'扣料 工单号'+@wo+' 数量'+convert(varchar(10),@deqty) from RW01 where RW01001=@bid

update WK02 set WK02009=WK02009+@deqty where WK02001=@rlid
if not exists(select * from WK02 where WK02002=@wo and WK02009<WK02005)
update WK01 set WK01008=3 where WK01001=@wo
else
update WK01 set WK01008=2 where WK01001=@wo
";
            BaseAdo ba = new BaseAdo();
            ba.ExecuteSql(sql, new SqlParameter("@wo", this.WorkOrder), new SqlParameter("@bid", this.RWID), new SqlParameter("@deqty", this.DeQTY), new SqlParameter("@rlid", this.ReportLineID));
            return this;
        }
    }
}
