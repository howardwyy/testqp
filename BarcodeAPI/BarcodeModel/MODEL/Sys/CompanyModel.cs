﻿using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Sys
{
    
    public class CompanyModel : BaseSearchModel
    { 
        public  string[] Companys{ set; get; }

        public override BaseSearchModel GetModelByID(string id)
        {
            SysConfig sysConfig = new SysConfig();
            Companys = sysConfig.Companys;
            return this;
        }
    }
}
