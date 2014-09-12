using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace BarcodeModel.MODEL.User.Operation
{
    public class ResetUserStatus : BaseSearchModel
    {

        public string[] ids { get; set; }

        public override BaseSearchModel Insert()
        {
            if (ids == null || ids.Length == 0)
            {
                throw new Exception("请输入待重置的用户信息");
            }
            else
            {
                using (TransactionScope ts = new TransactionScope())
                {

                    ModelAdo<LoginHistoryModel> adoUser = new ModelAdo<LoginHistoryModel>();
                    StringBuilder sb = new StringBuilder();
                    foreach (string item in ids)
                    {
                        sb.Append(",'" + item + "'");
                    }
                    sb.Remove(0, 1);

                    string sql = @"update UR05 set UR05005 =0 where UR05002 in( [UIDS] )";
                    sql = sql.Replace("[UIDS]", sb.ToString());
                    adoUser.ExecuteSql(sql, null);
                    ts.Complete();
                    return this;
                }

            }
        }
    }
}
