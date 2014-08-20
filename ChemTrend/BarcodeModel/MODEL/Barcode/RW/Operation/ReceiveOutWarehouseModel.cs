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
    /// 领料出库
    /// </summary>
   public class ReceiveOutWarehouseModel : BaseSearchModel
    {
        //仓库号
        public string Warehouse { get; set; }
        //库位号
        public string Bin { get; set; }
        //单据号备注
        public string Remark { get; set; }
        //领料单ID
        public string ReceiveID { get; set; }
        //领料单状态
        public string ReceiveStatus { get; set; }
        //领料单行ID
        public string ReceiveLine { get; set; }
        //领料单行已领数量
        public decimal ReceivedCount { set; get; }
        //领料单行剩余数量
        public decimal ReceiveSurplusCount { set; get; }
        //领料单行关联条码信息
        public string[] Barcodes { get; set; }

        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            if (Barcodes == null || Barcodes.Length == 0)
                throw new Exception("请扫描或输入待入库的条码标签");
            ModelAdo<LocationModel> adoLoc = new ModelAdo<LocationModel>();
            List<LocationModel> lm = adoLoc.GetList("SC36001=@wh and SC36002=@bin", "", "", new SqlParameter("@wh", this.Warehouse), new SqlParameter("@bin", this.Bin));

            if (lm.Count == 0)
                throw new Exception("仓库或库位不存在");

            //①：修改原材料领料单RW08状态 ：RW08008	int		状态(1已申请 2部分发货 3关闭)
            //②：修改原材料领料单ITEMRW09已领和剩余数量
            //③：插入RW10	原材料领料单BARCODE	中间表

            //④：修改条码信息表：
            //⑤：插入RW03原材料单据表
            //⑥：插入RW04原材料单据明细表
            //⑦：插入RW02	原材料历史记录
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
	set @result=N'存在不能做领料操作的信息，不能进行领料操作'
end

if @result='YES'
begin
    Update RW08 set RW08008=@ReceiveStatus where RW08001=@ReceiveID

    Update RW09 set RW09005=@userid,RW09006=@username,RW09011=@Count, RW09012=@SurplusCount where RW09001=@ReceiveLine

    insert into RW10(RW10002,RW10003,RW10004,RW10005,RW10006,RW10007)
    select getdate(),@userid,@username,@ReceiveID,@ReceiveLine,RW01001 from RW01 where RW01001 IN ([BIDS])

    exec PROC_GETID 'RW03',@dj output
	
    insert into RW03(RW03001,RW03002,RW03003,RW03004,RW03005,RW03006,RW03007,RW03008)
    values(@dj,getdate(),@userid,@username,'','','',@Remark)

    insert into RW02(RW02002,RW02003,RW02004,RW02005,RW02010,RW02011)
    select RW01001,getdate(),@userid,@username,@dj,N'领料单@ReceiveID 移库到'+@whstr from RW01 where RW01001 IN ([BIDS])

    insert into RW04(RW04002,RW04003,RW04004,RW04005)
    select getdate(),@dj,RW01001,N'领料单@ReceiveID 移库到'+@whstr from RW01 where RW01001 IN ([BIDS])
	
    update RW01 set RW01016 =RW01008 ,RW01017 = RW01009,RW01008=@wh,RW01009=@sh,RW01024=@userid,RW01025=@username,RW01027=@dj,RW01032=3 where RW01001 IN ([BIDS])	

end
select @result MSG
";

                parameters.Add(new SqlParameter("@userid", this.LoginUserID));
                parameters.Add(new SqlParameter("@Remark", this.Remark));
                parameters.Add(new SqlParameter("@ReceiveID", this.ReceiveID));
                parameters.Add(new SqlParameter("@ReceiveStatus", this.ReceiveStatus));
                parameters.Add(new SqlParameter("@ReceiveLine", this.ReceiveLine));
                parameters.Add(new SqlParameter("@ReceivedCount", this.ReceivedCount));
                parameters.Add(new SqlParameter("@ReceiveSurplusCount", this.ReceiveSurplusCount));
                
                parameters.Add(new SqlParameter("@wh", this.Warehouse));
                parameters.Add(new SqlParameter("@sh", this.Bin));
                parameters.Add(new SqlParameter("@whstr", this.Warehouse + "[" + this.Bin + "]"));
                    

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
