using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using BarcodeModel.ADO;

namespace BarcodeModel.MODEL.User
{
    [Tablename(TableName = "UR03", PrimaryKey = "UR03001")]
    public class RightsModel : BaseSearchModel
    {
        [Columname(Name = "UR03001")]
        public int ID { get; set; }

        [Columname(Name = "UR03002")]
        public string RightsDesc { get; set; }

        [Columname(Name = "UR03003")]
        public string ModelSpace { get; set; }

        [Columname(Name = "UR03004")]
        public string ActionName { get; set; }

        [Columname(Name = "UR03005")]
        public int ParentID { get; set; }
    }
}
