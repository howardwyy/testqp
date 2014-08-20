using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    //装箱
    public class PackingBarcodeModel : BaseSearchModel
    {
        public string PackingID { get; set; }
        public string[] Barcodes { get; set; }
        public int Status { get; set; }

        public override BaseSearchModel Insert()
        {

            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待入库的条码标签");
            using (TransactionScope ts = new TransactionScope())
            {

                ModelAdo<RWBarcodeModel> adoRW = new ModelAdo<RWBarcodeModel>();
                StringBuilder sb = new StringBuilder();
                foreach (string item in Barcodes)
                {
                    sb.Append(",'" + item + "'");
                }
                sb.Remove(0, 1);

                string sql = @"
declare @RC int
declare @result nvarchar(200)
declare @dj varchar(30)
set @RC=0
set @result=N'YES'

if @result='YES'
begin
    exec PROC_GETID 'RW03',@dj output
	
    insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
    select RW01001,getdate(),@userid,@username,@dj,N'装箱到'+@PackingID from RW01 where RW01001 IN ([BIDS])

    update RW01 set RW01024=@userid,RW01025=@username,RW01031=@PackingID where RW01001 IN ([BIDS])	
    update RW07 set RW07008=@Status where RW07001 =@PackingID
end
select @result MSG
";
                sql = sql.Replace("[BIDS]", sb.ToString());
                DataSet ds = adoRW.GetDataSet(sql, new SqlParameter("@PackingID", this.PackingID), new SqlParameter("@userid", this.LoginUserID), new SqlParameter("@username", this.LoginUserName), new SqlParameter("@Status", this.Status));
                if (ds != null && ds.Tables[0].Rows.Count > 0)
                {
                    string msg = ds.Tables[0].Rows[0][0] + "";
                    if (msg != "YES")
                        throw new Exception(msg);
                }
                ts.Complete();
                return this;
            }
        }
    }
}
