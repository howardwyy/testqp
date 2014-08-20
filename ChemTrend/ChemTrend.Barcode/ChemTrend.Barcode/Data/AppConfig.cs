using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChemTrend.Barcode.Data
{
    public class AppConfig
    {
        public enum IsCheck
        {
            是 = 1,
            否 = 2
        }
        //枚举类型
        public enum ActionType
        {
            Insert,
            Update,
            Select,
            Delete
        }
        //条码状态值
        public enum Barcode
        {
            未扫描 = 1,
            已入库 = 2,
            已出库 = 3,
            移库中 = 4,
            报废 = 5
        }

        //历史记录中条码状态值
        public enum BarcodeRemark
        {
            创建条码 = 1,
            条码移库 = 2,
            条码出库 = 3,
            条码入库 = 4,
            条码销毁 = 5,
            条码装箱 = 6
        }
        //构建条码状态信息
        public static List<ComboBoxEditData> GetBarcodeStatus()
        {
            List<ComboBoxEditData> list = new List<ComboBoxEditData>();
            Type enumType = typeof(Barcode);
            foreach (string str in Enum.GetNames(enumType))
            {
                ComboBoxEditData item = new ComboBoxEditData()
                {
                    Value = Enum.Format(enumType, Enum.Parse(enumType, str), "d"),
                    Text = str
                };
                list.Add(item);

            }
            return list;
        }

        //装箱条码使用状态值
        public enum Packing //1.未使用；2.使用中；3，使用完
        {
            未使用 = 1,
            使用中 = 2,
            使用完 = 3
        }
        //构建条码状态信息
        public static List<ComboBoxEditData> GetPackingStatus()
        {
            List<ComboBoxEditData> list = new List<ComboBoxEditData>();
            Type enumType = typeof(Packing);
            foreach (string str in Enum.GetNames(enumType))
            {
                ComboBoxEditData item = new ComboBoxEditData()
                {
                    Value = Enum.Format(enumType, Enum.Parse(enumType, str), "d"),
                    Text = str
                };
                list.Add(item);
            }
            return list;
        }

        //领料单状态(1已申请 2部分发货 3关闭)
        public enum Receive
        {
            已申请 = 1,
            部分发货 = 2,
            关闭 = 3
        }


        public static string IniFilePath { get { return ConfigurationManager.AppSettings["IniFilePath"]; } }
        public enum Section
        {
            Login,
            System
        }
        public enum Ident
        {
            UserName,
            Password,
            HisID,
            ID
        }



    }
}
