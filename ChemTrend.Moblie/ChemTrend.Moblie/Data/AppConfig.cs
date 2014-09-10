using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ChemTrend.Moblie.Data
{
    public class AppConfig
    {
        public enum ActionType  //枚举类型
        {
            Insert,
            Update,
            Select,
            Delete
        }

        public enum Barcode  //状态
        {
            UnScan = 1,
            InWarehouse = 2,
            OutWarehouse = 3,
            Moving = 4,
            Destroy = 5
        }

        //装箱条码使用状态值
        public enum Packing //1.未使用；2.使用中；3，使用完
        {
            未使用 = 1,
            使用中 = 2,
            使用完 = 3
        }

        public static string IniFilePath { get { return "/member.ini"; } }
        public enum Section 
        {
            Login,
            System,

            UserName,
            Password,
            HisID,
            ID
        }
        public enum Ident 
        {
            UserName,
            Password,
            HisID,
            ID
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
        public enum Bill 
        {
            创建条码,
            条码移库,
            条码出库,
            条码入库
        }

    }
}
