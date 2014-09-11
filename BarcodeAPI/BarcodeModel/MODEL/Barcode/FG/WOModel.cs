using BarcodeModel.ADO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BarcodeModel.MODEL.Barcode.FG
{
    [Tablename(TableName = "view_WO", PrimaryKey = "MP64001", ViewName = "view_WO", IsScalaDB = true)]
    public class WOModel : BaseSearchModel
    {
        [Columname(Name = "MP64001")]
        public string WorkOrder { get; set; }

        [Columname(Name = "MP64002")]
        public string StockCode { get; set; }

        [Columname(Name = "SC01002")]
        public string StockName { get; set; }

        [Columname(Name = "SC01003")]
        public string StockSpec { get; set; }

        [Columname(Name = "UNIT")]
        public string Unit { get; set; }

        [Columname(Name = "SC01072")]
        public decimal UnitQty { get; set; }

        [Columname(Name = "MP64004")]
        public decimal PlanQTY { get; set; }

        [Columname(Name = "MP64005")]
        public decimal AcQty { get; set; }

        [Columname(Name = "Company")]
        public string Company { get; set; }

        public int BarcodeQty { get; set; }
        public DateTime ProductDate { get; set; }
        public int LifeDate { get; set; }//保质期天数，ProductDate+LifeDate等于实际保质期
        public string PageCode { get; set; }
        public string Remark { get; set; }
        public string Danju { get; set; }//创建时的统一单据号


        public override BarcodeModel.MODEL.BaseSearchModel Insert()
        {
            string sql = @"
declare @bid varchar(30)
declare @hid int
declare @i int
	
insert into RW03(FG03001,FG03002,FG03003,FG03004,FG03005,FG03006,FG03007,FG03008)
values(@dj,getdate(),@userid,@username,'','','',N'创建条码')

set @i=0
while @i<@printcount
begin
exec PROC_GETID 'FG01',@bid output
insert into FG02(FG02002,FG02003,FG02004,FG02005,FG02010,FG02011)
values(@bid,getdate(),@userid,@username,@dj,N'创建条码标签')

insert into FG01(FG01001,FG01002,FG01003,FG01004,FG01005,FG01006,FG01012,FG01013,FG01014,FG01015,FG01018,FG01024,FG01025,FG01027,FG01032,FG01037,FG01033,FG01034,FG01035,FG01036)
values(@bid,@stock,@stockname,@stockspec,@unit,@qty,'','','','',@remark,@userid,@username,@dj,1,@company,'',@productdate,@lifedate,@pagecode)

insert into FG04(FG04002,FG04003,FG04004,FG04005) values(getdate(),@dj,@bid,N'创建条码')

set @i=@i+1
end
";
            BaseAdo ba = new BaseAdo();
            ba.ExecuteSql(sql, new SqlParameter("@userid", this.LoginUserID),
                new SqlParameter("@username", this.LoginUserName),
                new SqlParameter("@stock", this.StockCode),
                new SqlParameter("@stockname", this.StockName),
                new SqlParameter("@stockspec", this.StockSpec),
                new SqlParameter("@unit", this.Unit),
                new SqlParameter("@qty", this.UnitQty),
                new SqlParameter("@remark", this.Remark),
                new SqlParameter("@company", this.Company),
                new SqlParameter("@printcount", this.BarcodeQty),
                new SqlParameter("@productdate", this.ProductDate.ToString("yyyy-MM-dd")),
                new SqlParameter("@lifedate", this.LifeDate.ToString("yyyy-MM-dd")),
                new SqlParameter("@pagecode", this.PageCode));
            return this;
        }
    }
}
