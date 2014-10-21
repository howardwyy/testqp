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
        public string[] Companys { get { return new string[] { "32", "31" }; } }
        public static string[] GetXMLExportPath(string company)
        {
            if (company == "32")
            {
                string[] s = { "c:\\xml32\\", "c:\\xml32\\" };
                return s;
            }
            if (company == "31")
            {
                string[] s = { "c:\\xml32\\", "c:\\xml32\\" };
                return s;
            }
            else
                throw new Exception("未设置文件目录");
        }
    }
}
