using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BarcodeModel.ADO;
using System.Transactions;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 分包/重命名
    /// </summary>
    public class RWSandRModel : BaseSearchModel
    {
        //条码标签
        public string[] IssueBarcodes { get; set; }
        public string[] ReceiveBarcodes { get; set; }
        //分包=1；重命名=2
        public int Action { get; set; }
        //流水号，用户返回
        public string Remark { set; get; }

        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            //RW01中加入流水号字段。
            //①：生成流水号字段
            //--------------分包：
            //RP+YY+MM+0000
            //--------------重命名：
            //RN+YY+MM+0000
            //依据月份来计算流水号。
            //②：修改RW01流水号字段。
            //③：创建connectivity 文件
            using (TransactionScope ts = new TransactionScope())
            {
                string sql = @"
declare @pr varchar(30)
exec PROC_GETID @type,@pr output

select  @pr PR,RW01008,RW01009 from RW01 where RW01001=@bid
";
                BaseAdo ba = new BaseAdo();
                DataSet ds = ba.GetDataSet(sql, new SqlParameter("@bid", this.IssueBarcodes[0]), new SqlParameter("@type", this.Action == 1 ? "PR" : "RN"));
                EnterWarehouseModel ewm = new EnterWarehouseModel();
                ewm.Barcodes = this.ReceiveBarcodes;
                ewm.Bin = ds.Tables[0].Rows[0]["RW01009"] + "";
                ewm.Warehouse = ds.Tables[0].Rows[0]["RW01008"] + "";
                ewm.FRNumber = ds.Tables[0].Rows[0]["PR"] + "";
                ewm.Insert();

                DestroyBarcodeModel dbm = new DestroyBarcodeModel();
                dbm.Barcodes = this.IssueBarcodes;
                dbm.isExportFile = true;
                dbm.FRNumber = ds.Tables[0].Rows[0]["PR"] + "";
                dbm.Insert();
                ts.Complete();
            }
            return this;
        }



    }
}
