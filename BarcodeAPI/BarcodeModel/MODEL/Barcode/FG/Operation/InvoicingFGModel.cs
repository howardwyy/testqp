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
    /// 发货单，发货动作
    /// </summary>
    public class InvoicingFGModel : BaseSearchModel
    {
        //单据号备注
        public string Remark { get; set; }
        //发货单ID
        public string InvoiceID { get; set; }
        //发货单状态
        public string InvoiceStatus { get; set; }
        //发货单行ID
        public string InvoiceLine { get; set; }
        //发货单行已领数量
        public decimal InvoicedCount { set; get; }
        //发货单行剩余数量
        public decimal InvoiceSurplusCount { set; get; }
        //发货单行关联条码信息
        public string[] Barcodes { get; set; }

        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待入库的条码标签");

            //①：修改成品发货单单FG08状态 ：FG08008	int		状态(1已申请 2部分发货 3关闭)
            //②：修改成品发货单单ITEMFG09已领和剩余数量
            //③：插入FG10	成品发货单单BARCODE	中间表

            //④：修改条码信息表：
            //⑤：插入FG03成品单据表
            //⑥：插入FG04成品单据明细表
            //⑦：插入FG02	成品历史记录
            using (TransactionScope ts = new TransactionScope())
            {
                ModelAdo<FGBarcodeModel> adoFG = new ModelAdo<FGBarcodeModel>();
                List<SqlParameter> parameters = new List<SqlParameter>();
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
select @RC=count(FG01001) from FG01 where FG01001 IN ([BIDS]) and FG01032 <> 2
if @RC>0
begin
	set @result=N'存在不能做发货操作的信息，不能进行发货操作'
end

if @result='YES'
begin


    Update FG09 set FG09005=@userid,FG09006=@username,FG09011=@InvoicedCount, FG09012=@InvoiceSurplusCount where FG09001=@InvoiceLine

    declare @calcstatus int
    set @calcstatus=2
    select @calcstatus=SUM(FG09012) from FG09 where FG09003=@InvoiceID
    if @calcstatus>0
    begin
	    set @InvoiceStatus=2
    end
    else
    begin
	    set @InvoiceStatus=3
    end
    Update FG08 set FG08008=@InvoiceStatus where FG08001=@InvoiceID

    insert into FG10(FG10002,FG10003,FG10004,FG10005,FG10006,FG10007)
    select getdate(),@userid,@username,@InvoiceID,@InvoiceLine,FG01001 from FG01 where FG01001 IN ([BIDS])

    exec PROC_GETID 'FG03',@dj output
	
    insert into FG03(FG03001,FG03002,FG03003,FG03004,FG03005,FG03006,FG03007,FG03008)
    values(@dj,getdate(),@userid,@username,'','',@InvoiceID,@Remark)

    insert into FG02(FG02002,FG02003,FG02004,FG02005,FG02010,FG02011)
    select FG01001,getdate(),@userid,@username,@dj,N'发货单['+ @InvoiceID +']' from FG01 where FG01001 IN ([BIDS])

    insert into FG04(FG04002,FG04003,FG04004,FG04005)
    select getdate(),@dj,FG01001,N'发货单['+ @InvoiceID +']' from FG01 where FG01001 IN ([BIDS])
	
    update FG01 set FG01016 =FG01008 ,FG01017 = FG01009,FG01024=@userid,FG01025=@username,FG01027=@dj,FG01032=3 where FG01001 IN ([BIDS])	

end
select @result MSG
";

                parameters.Add(new SqlParameter("@userid", this.LoginUserID));
                parameters.Add(new SqlParameter("@username", this.LoginUserName));
                parameters.Add(new SqlParameter("@Remark", this.Remark));
                parameters.Add(new SqlParameter("@InvoiceID", this.InvoiceID));
                parameters.Add(new SqlParameter("@InvoiceStatus", this.InvoiceStatus));
                parameters.Add(new SqlParameter("@InvoiceLine", this.InvoiceLine));
                parameters.Add(new SqlParameter("@InvoicedCount", this.InvoicedCount));
                parameters.Add(new SqlParameter("@InvoiceSurplusCount", this.InvoiceSurplusCount));



                sql = sql.Replace("[BIDS]", sb.ToString());
                DataSet ds = adoFG.GetDataSet(sql, parameters.ToArray());
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
