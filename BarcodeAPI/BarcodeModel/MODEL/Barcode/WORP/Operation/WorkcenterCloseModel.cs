using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;

namespace BarcodeModel.MODEL.Barcode.WORP.Operation
{
    public class WorkcenterCloseModel : BaseSearchModel
    {
        public string WorkOrder { get; set; }
        public string WorkCenter { get; set; }
        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            string sql = @"
update WK04 set WK04004=getdate() where WK04001=@wo and WK04002=@wc and WK04004 is null
";
            BaseAdo ba = new BaseAdo();
            ba.ExecuteSql(sql,
                new SqlParameter("@wo", this.WorkOrder),
                new SqlParameter("@wc", this.WorkCenter));
            return this;
        }
    }
}
