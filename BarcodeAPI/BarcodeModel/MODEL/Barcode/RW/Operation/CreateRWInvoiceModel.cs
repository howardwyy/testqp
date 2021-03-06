﻿using BarcodeModel.ADO;
using BarcodeModel.MODEL.Barcode.FG;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.RW.Operation
{
    /// <summary>
    /// 原材料发货单，创建
    /// </summary>
    public class CreateRWInvoiceModel : BaseSearchModel
    {
        //SOLine数据集合
        public SOLineModel[] SOLines { set; get; }
        //OrderNumber
        public string SONO { set; get; }

        public override BaseSearchModel Insert()
        {
            if (SOLines == null || SOLines.Length == 0)
                throw new Exception("请选择发货单项");
            string sql = @"
declare @id varchar(30)
exec PROC_GETID 'RW18',@id output
insert into RW18(RW18001,RW18002,RW18003,RW18004,RW18005,RW18006,RW18007,RW18008,RW18009)
values(@id,getdate(),@userid,@username,1,@CustomerCode,@CustomerName,@so,@dn)
";
            List<SqlParameter> list = new List<SqlParameter>();
            list.Add(new SqlParameter("@userid", this.LoginUserID));
            list.Add(new SqlParameter("@username", this.LoginUserName));
            list.Add(new SqlParameter("@CustomerCode", SOLines[0].CustomerCode));
            list.Add(new SqlParameter("@CustomerName", SOLines[0].CustomerName));
            list.Add(new SqlParameter("@so", SOLines[0].OrderNumber));
            list.Add(new SqlParameter("@dn", SOLines[0].DeliveryNumber));
            StringBuilder sb = new StringBuilder();
            sb.Append(sql);

            int i = 10;
            foreach (SOLineModel item in this.SOLines)
            {
                sb.Append(string.Format(@"insert into RW19(RW19002,RW19003,RW19004,RW19005,RW19006,RW19007,RW19008,RW19009,RW19010,RW19011,RW19012,RW19013,RW19014)
values(@line{0},@id,getdate(),@userid,@username,@stock{0},@stockname{0},@orderqty{0},@unit{0},0,@orderqty{0},@warehouse{0},@batch{0})
", i));
                list.Add(new SqlParameter("@line" + i, item.LineNumber));
                list.Add(new SqlParameter("@stock" + i, item.StockCode));
                list.Add(new SqlParameter("@stockname" + i, item.StockName));
                list.Add(new SqlParameter("@orderqty" + i, item.OrderQty));
                list.Add(new SqlParameter("@unit" + i, item.Unit));
                list.Add(new SqlParameter("@warehouse" + i, item.Warehouse));
                list.Add(new SqlParameter("@batch" + i, item.Batch));
                i = i + 10;
            }
            sb.Append("select @id SONO");
            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet(sb.ToString(), list.ToArray());
            if (ds != null && ds.Tables[0] != null && ds.Tables[0].Rows.Count >= 1)
                this.SONO = ds.Tables[0].Rows[0][0] + "";
            return this;
        }
    }
}
