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
    /// <summary>
    /// 发货单，发货动作
    /// </summary>
    public class InvoicingRWModel : BaseSearchModel
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

            //①：修改成品发货单单RW18状态 ：RW18008	int		状态(1已申请 2部分发货 3关闭)
            //②：修改成品发货单单ITEMRW19已领和剩余数量
            //③：插入RW20	成品发货单单BARCODE	中间表

            //④：修改条码信息表：
            //⑤：插入RW03成品单据表
            //⑥：插入RW04成品单据明细表
            //⑦：插入RW02	成品历史记录
            using (TransactionScope ts = new TransactionScope())
            {
                ModelAdo<RWBarcodeModel> adoRW = new ModelAdo<RWBarcodeModel>();
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
select @RC=count(RW01001) from RW01 where RW01001 IN ([BIDS]) and RW01032 <> 2
if @RC>0
begin
	set @result=N'存在不能做发货操作的信息，不能进行发货操作'
end

if @result='YES'
begin


    Update RW19 set RW19005=@userid,RW19006=@username,RW19011=@InvoicedCount, RW19012=@InvoiceSurplusCount where RW19001=@InvoiceLine

    declare @calcstatus int
    set @calcstatus=2
    select @calcstatus=SUM(RW19012) from RW19 where RW19003=@InvoiceID
    if @calcstatus>0
    begin
	    set @InvoiceStatus=2
    end
    else
    begin
	    set @InvoiceStatus=3
    end
    Update RW18 set RW18008=@InvoiceStatus where RW18001=@InvoiceID

    insert into RW20(RW20002,RW20003,RW20004,RW20005,RW20006,RW20007)
    select getdate(),@userid,@username,@InvoiceID,@InvoiceLine,RW01001 from RW01 where RW01001 IN ([BIDS])

    exec PROC_GETID 'RW03',@dj output
	
    insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
    values(@dj,getdate(),@userid,@username,'','',@InvoiceID,@Remark)

    insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
    select RW01001,getdate(),@userid,@username,@dj,N'发货单['+ @InvoiceID +']' from RW01 where RW01001 IN ([BIDS])

    insert into RW04(RW04002,RW04003,RW04004,RW04005)
    select getdate(),@dj,RW01001,N'发货单['+ @InvoiceID +']' from RW01 where RW01001 IN ([BIDS])
	
    update RW01 set RW01016 =RW01008 ,RW01017 = RW01009,RW01024=@userid,RW01025=@username,RW01027=@dj,RW01032=3 where RW01001 IN ([BIDS])	

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
                DataSet ds = adoRW.GetDataSet(sql, parameters.ToArray());
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
