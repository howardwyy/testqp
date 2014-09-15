using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW;
using ChemTrend.Barcode.Utils;
using ChemTrend.Barcode.Data;
using DevExpress.XtraReports.UI;
using ChemTrend.Barcode.Report;
using ChemTrend.Barcode.Forms.Print;

namespace ChemTrend.Barcode.Forms.Stock
{
    public partial class frmReceive : DevExpress.XtraEditors.XtraForm
    {

        ModelAPI<ReceiveModel> apiReceive = new ModelAPI<ReceiveModel>();
        List<ReceiveModel> listReceive = null;
        public frmReceive()
        {
            InitializeComponent();
        }

        private void sbtn_receiving_create_Click(object sender, EventArgs e)
        {
            frmReceiveNew frmReceiveNew = new frmReceiveNew();
            frmReceiveNew.StartPosition = FormStartPosition.CenterParent;
            DialogResult result = frmReceiveNew.ShowDialog();
            if (result == DialogResult.OK)
            {
                InitData();
            }
        }

        private void InitData()
        {
            try
            {
                ReceiveModel searchModel = new ReceiveModel()
                {
                    BeginTimeReceiveTime = de_begin.DateTime,
                    EndTimeReceiveTime = de_end.DateTime
                };
                if (!string.IsNullOrEmpty(tbox_barcode.Text)) {
                    searchModel.ID = tbox_barcode.Text;
                }
                listReceive = apiReceive.GetList(searchModel);
                this.gc_receive.DataSource = listReceive;
            }

            catch (Exception ex)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
            }
           


            col_status.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            BaseFormatter formatBase = new BaseFormatter();
            col_status.DisplayFormat.Format = formatBase;
            formatBase.EventHandler += new OverideFormat(formatBase_EventHandler);


            col_isUrgent.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Custom;
            BaseFormatter fbIsUrgent = new BaseFormatter();
            col_isUrgent.DisplayFormat.Format = fbIsUrgent;
            fbIsUrgent.EventHandler += new OverideFormat(fbIsUrgent_EventHandler);
        }

        private string fbIsUrgent_EventHandler(string format, object arg, IFormatProvider formatProvider)
        {
            int state = int.Parse(arg.ToString());
            if (state == (int)AppConfig.IsCheck.是)
                return AppConfig.IsCheck.是.ToString();
            return AppConfig.IsCheck.否.ToString();
        }

        private string formatBase_EventHandler(string format, object arg, IFormatProvider formatProvider)
        {
            int state = int.Parse(arg.ToString());
            if (state == (int)AppConfig.Receive.已申请)
                return AppConfig.Receive.已申请.ToString();
            if (state == (int)AppConfig.Receive.部分发货)
                return AppConfig.Receive.部分发货.ToString();
            if (state == (int)AppConfig.Receive.关闭)
                return AppConfig.Receive.关闭.ToString();
            return AppConfig.Receive.已申请.ToString();
        }

        private void sbtn_print_Click(object sender, EventArgs e)
        {
            int[] selectRows = gv_receive.GetSelectedRows();
            if (check_selected(selectRows))
            {
                try
                {
                    List<XtraReport> reports = new List<XtraReport>();
                    foreach (int row in selectRows)
                    {
                        ModelAPI<ReceiveDetailModel> apiReceiveDetails = new ModelAPI<ReceiveDetailModel>();
                        ReceiveDetailModel searchReceiveDetail = new ReceiveDetailModel();
                        ReceiveModel model = listReceive[gv_receive.GetDataSourceRowIndex(row)];
                        searchReceiveDetail.ReceiveID = model.ID;
                        List<ReceiveDetailModel> listRDetails = apiReceiveDetails.GetList(searchReceiveDetail);
                        repReceive report = new repReceive(listRDetails, model);
                        report.CreateDocument();
                        reports.Add(report);
                    }
                    frmMutiPrint mutiPrint = new frmMutiPrint();
                    mutiPrint.reports = reports;
                    mutiPrint.Show();

                }
                catch (Exception ex)
                {
                    DevExpress.XtraEditors.XtraMessageBox.Show(ex.Message, "确认", MessageBoxButtons.OK);
                }


            }
        }

        private void sbtn_query_Click(object sender, EventArgs e)
        {
            InitData();
        }

        private void frmReceive_Load(object sender, EventArgs e)
        {
            de_begin.Text = DateTimeUtil.GetFirstDayOfMonth();
            de_end.Text = DateTimeUtil.GetLastDayOfMonth();
            InitData();
        }

        private void gv_receive_DoubleClick(object sender, EventArgs e)
        {
            ReceiveModel focuseReceive = gv_receive.GetFocusedRow() as ReceiveModel;

            frmReceiveDetails frmRDetails = new frmReceiveDetails();
            frmRDetails.StartPosition = FormStartPosition.CenterParent;
            frmRDetails.focuseReceive = focuseReceive;
            DialogResult result = frmRDetails.ShowDialog();
        }

        private bool check_selected(int[] rows)
        {
            if (rows.Length == 0)
            {
                DevExpress.XtraEditors.XtraMessageBox.Show("请选中行信息？", "确认", MessageBoxButtons.OK);
                return false;
            }
            return true;
        }
    }
}