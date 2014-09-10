using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Configuration;

namespace BarcodeModel
{
    public class SysConfig
    {
        public static string DBConnection { get { return ConfigurationManager.AppSettings["DBConnection"]; } }
        public static string DBScalaConnection { get { return ConfigurationManager.AppSettings["DBScalaConnection"]; } }
        public static string CompanyCode { get { return ConfigurationManager.AppSettings["CompanyCode"]; } }
        public static string APIDomain { get { return ConfigurationManager.AppSettings["APIDomain"]; } }
        public static string PageSize { get { return ConfigurationManager.AppSettings["PageSize"]; } }
        public string[] Companys { get { return new string[] { "31" ,"32"}; } }

    }
}
