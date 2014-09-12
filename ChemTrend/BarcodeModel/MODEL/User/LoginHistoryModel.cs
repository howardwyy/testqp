using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BarcodeModel.ADO;

namespace BarcodeModel.MODEL.User
{
    [Tablename(TableName = "UR05", PrimaryKey = "UR05001", ViewName = "viewLoginHistory")]
    public class LoginHistoryModel : BaseSearchModel
    {
        [Columname(Name = "UR05001")]
        public string ID { get; set; }

        [Columname(Name = "UR05003")]
        public DateTime LoginTime { get; set; }

        [Columname(Name = "UR05002")]
        public string UserID { get; set; }

        [Columname(Name = "UR01003", canInsert = false, canUpdate = false)]
        public string UserLoginName { get; set; }

        [Columname(Name = "UR01005", canUpdate = false, canInsert = false)]
        public string UserName { get; set; }

        [Columname(Name = "UR01002", canUpdate = false, canInsert = false)]
        public string UserCode { get; set; }

        [Columname(Name = "UR05004")]
        public DateTime LogoutTime { get; set; }

        [Columname(Name = "UR05005")]
        public int LoginStatus { get; set; }

        [Columname(Name = "UR05006")]
        public string ComputerName { get; set; }

        [Columname(Name = "UR05007")]
        public string IP { get; set; }

        [Columname(Name = "UR05008")]
        public string LoginType { get; set; }

        public override int Delete(string id)
        {
            ModelAdo<LoginHistoryModel> adoLHM = new ModelAdo<LoginHistoryModel>();
            LoginHistoryModel lhm = adoLHM.GetModelByID(id);
            if (lhm != null)
            {
                lhm.LoginStatus = 0;
                lhm.LogoutTime = DateTime.Now;
                return adoLHM.Update(lhm);
            }
            else
                return 0;
        }
       

    }
}
