using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace BarcodeModel.MODEL.Sys
{
    public class CompanyModel : BaseSearchModel
    { 
        public  string[] Companys{ set; get; }

        public CompanyModel GetCompanys()
        {
            SysConfig sysConfig = new SysConfig();
            Companys = sysConfig.Companys;
            return this;
        }
    }
}
