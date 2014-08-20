using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemTrend.Barcode.Utils
{


    public class DateTimeUtil
    {
        /// <summary>
        /// 获取当前月份的第一天
        /// </summary>
        /// <returns></returns>
        public static string GetFirstDayOfMonth()
        {
            return DateTime.Now.Year.ToString() + "/" + DateTime.Now.Month.ToString() + "/1";
        }

        /// <summary>
        /// 获取当天+1
        /// </summary>
        /// <returns></returns>
        public static string GetLastDayOfMonth()
        {
            DateTime dt = DateTime.Now.AddDays(1);
            return dt.Year.ToString() + "/" + dt.Month.ToString() + "/" + dt.Day.ToString();
        }
    }
}
