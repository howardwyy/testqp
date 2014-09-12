using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.FG.Operation
{
    /// <summary>
    /// 成品销毁
    /// </summary>
    public class DestoryFGModel : BaseSearchModel
    {
        public string Remark { get; set; }
        public string[] Barcodes { get; set; }



        public override BaseSearchModel Insert()
        {

            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待销毁的条码标签");
            using (TransactionScope ts = new TransactionScope())
            {

                ModelAdo<FGBarcodeModel> adoRW = new ModelAdo<FGBarcodeModel>();
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
	  
    insert into FG02(FG02002,FG02003,FG02004,FG02005,FG02011)
    select FG01001,getdate(),@userid,@username,@Remark from FG01 where FG01001 IN ([BIDS]) 
	
    update FG01 set FG01024=@userid,FG01025=@username,FG01032=5 where FG01001 IN ([BIDS])	
end
select @result MSG
";
                sql = sql.Replace("[BIDS]", sb.ToString());
                DataSet ds = adoRW.GetDataSet(sql, new SqlParameter("@Remark", this.Remark), new SqlParameter("@userid", this.LoginUserID), new SqlParameter("@username", this.LoginUserName));
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
