using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;

namespace BarcodeModel
{
    public class SysConfig
    {
        //public static string DBConnection { get { return ConfigurationManager.AppSettings["DBConnection"]; } }
        //public static string CompanyCode { get { return ConfigurationManager.AppSettings["CompanyCode"]; } }
        //public static string APIDomain { get { return ConfigurationManager.AppSettings["APIDomain"]; } }
        //public static string PageSize { get { return ConfigurationManager.AppSettings["PageSize"]; } }


        public static string DBConnection { get { return ""; } }
        public static string CompanyCode { get { return ""; } }
        public static string APIDomain { get { return "http://192.168.1.119/"; } }
        public static string PageSize { get { return ""; } }
        public string[] Companys { get { return new string[] { "02", "03" }; } }

    }
}
