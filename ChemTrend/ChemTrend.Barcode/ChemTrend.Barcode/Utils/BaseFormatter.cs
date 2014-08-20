using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemTrend.Barcode.Utils
{
    public delegate string OverideFormat(string format, object arg, IFormatProvider formatProvider);
    /// <summary>
    /// BaseFormatter 的摘要说明。
    /// </summary>
    public class BaseFormatter : IFormatProvider, ICustomFormatter
    {
        public event OverideFormat EventHandler;
        public BaseFormatter()
        {
            //
            // TODO: 在此处添加构造函数逻辑
            //
        }
        #region ICustomFormatter 成员

        public string Format(string format, object arg, IFormatProvider formatProvider)
        {
            // TODO:  添加 BaseFormatter.Format 实现
            if (EventHandler != null)
                return EventHandler(format, arg, formatProvider);
            return arg.ToString();
        }


        #endregion

        #region IFormatProvider 成员

        public object GetFormat(Type formatType)
        {
            // TODO:  添加 BaseFormatter.GetFormat 实现
            if (formatType == typeof(ICustomFormatter)) return this;
            else return null;
        }

        #endregion
    }
}