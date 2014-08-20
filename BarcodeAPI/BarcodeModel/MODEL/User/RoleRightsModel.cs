using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using BarcodeModel.ADO;

namespace BarcodeModel.MODEL.User
{
    public class RoleRightsModel : BaseSearchModel
    {
        public string RoleID { get; set; }
        public string[] Rights { get; set; }
        public override BaseSearchModel Insert()
        {
            BaseAdo ba = new BaseAdo();
            StringBuilder sbRights = new StringBuilder("-1");
            foreach (string item in Rights)
            {
                sbRights.Append("," + item);
            }
            string sql = @"delete from UR04 where UR04002=@roleid
insert into UR04(UR04002,UR04003)
select @roleid,UR03001 from UR03 where UR03001 in (" + sbRights + ")";
            ba.ExecuteSql(sql, new SqlParameter("@roleid", this.RoleID));
            return this;
        }
        public override List<BaseSearchModel> GetALL(bool enableSearch = false)
        {
            List<BaseSearchModel> lst = new List<BaseSearchModel>();
            BaseAdo ba = new BaseAdo();
            DataSet ds = ba.GetDataSet("select UR04003 from UR04 where UR04002=@roleID", new SqlParameter("@roleID", this.RoleID));
            if (ds != null && ds.Tables[0].Rows.Count > 0)
            {
                string[] rs = new string[ds.Tables[0].Rows.Count];
                for (int i = 0; i < rs.Length; i++)
                {
                    rs[i] = ds.Tables[0].Rows[i][0] + "";
                }
                this.Rights = rs;
            }
            lst.Add(this);
            return lst;

        }
    }
}
