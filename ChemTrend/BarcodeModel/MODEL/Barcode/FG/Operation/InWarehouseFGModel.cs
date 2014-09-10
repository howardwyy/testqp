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
    /// 成品入库操作
    /// </summary>
    public class InWarehouseFGModel : BaseSearchModel
    {
        public string Warehouse { get; set; }
        public string Bin { get; set; }
        public string Remark { get; set; }
        public string[] Barcodes { get; set; }

        public override BaseSearchModel Insert()
        {

            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待入库的条码标签");
            ModelAdo<LocationModel> adoLoc = new ModelAdo<LocationModel>();
            List<LocationModel> lm = adoLoc.GetList("SC36001=@wh and SC36002=@bin", "", "", new SqlParameter("@wh", this.Warehouse), new SqlParameter("@bin", this.Bin));

            if (lm.Count == 0)
                throw new Exception("仓库或库位不存在");
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
select @RC=count(FG01001) from FG01 where FG01001 IN ([BIDS]) and FG01032>1
if @RC>0
begin
	set @result=N'存在已入过库的料，不能再入库'
end

if @result='YES'
begin
    exec PROC_GETID 'FG03',@dj output
	
    insert into FG03(FG03001,FG03002,FG03003,FG03004,FG03005,FG03006,FG03007,FG03008)
    values(@dj,getdate(),@userid,@username,'','','',@Remark)

    insert into FG02(FG02002,FG02003,FG02004,FG02005,FG02010,FG02011)
    select FG01001,getdate(),@userid,@username,@dj,N'入库到'+@whstr from FG01 where FG01001 IN ([BIDS])

    insert into FG04(FG04002,FG04003,FG04004,FG04005)
    select getdate(),@dj,FG01001,N'入库到'+@whstr from FG01 where FG01001 IN ([BIDS])
	
    update FG01 set FG01008=@wh,FG01009=@sh,FG01010=getdate(),FG01024=@userid,FG01025=@username,FG01027=@dj,FG01032=2 where FG01001 IN ([BIDS])	
end
select @result MSG
";
                sql = sql.Replace("[BIDS]", sb.ToString());
                DataSet ds = adoRW.GetDataSet(sql, new SqlParameter("@Remark", this.Remark), new SqlParameter("@userid", this.LoginUserID), new SqlParameter("@username", this.LoginUserName),
                    new SqlParameter("@wh", this.Warehouse), new SqlParameter("@sh", this.Bin), new SqlParameter("@whstr", this.Warehouse + "[" + this.Bin + "]"));
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
