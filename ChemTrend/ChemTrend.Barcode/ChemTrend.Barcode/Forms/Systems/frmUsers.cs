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
using ChemTrend.Barcode.Data;
using BarcodeModel.API;
using BarcodeModel.MODEL;
using BarcodeModel.MODEL.User;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using ChemTrend.Barcode.Utils;

namespace ChemTrend.Barcode.Forms.Systems
{
    public partial class frmUsers : DevExpress.XtraEditors.XtraForm
    {

        ModelAPI<UserModel> apiUser = new ModelAPI<UserModel>();
        List<UserModel> listUser = null;
        UserModel searchModel = null;
        UserModel selectUserModel = null;
        private int pageSize = 10;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            InitData();
            gv_users.CloseEditor();
        }

        private void InitData()
        {
            searchModel = new UserModel()
            {
                SearchOrderBy = "UR01001 DESC",
                PageIndex = ucPager.PageCurrent,
                PageSize = pageSize
            };

            InitValidationRules();
        }

        private void InitValidationRules()
        {
            //ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            //notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            //notEmptyValidationRule.ErrorText = "请输入过滤条件！";
            //dxvp_query.SetValidationRule(this.te_query, notEmptyValidationRule);//两个参数表示验name值为BulidName的TextEdit控件为notEmptyValidationRule验证

            ucPager.EventPaging += ucPager_EventPaging;
            ucPager.PageSize = pageSize;
            ucPager.Bind();

        }




        private void simpleButton_role_Click(object sender, EventArgs e)
        {
            frmMain f = (frmMain)this.ParentForm;
            f.OpenWindow(typeof(frmRoles).ToString());
        }

        int ucPager_EventPaging(Controls.EventPagingArg e)
        {
            try
            {
                searchModel.PageIndex = ucPager.PageCurrent;
                searchModel.PageSize = ucPager.PageSize;
                listUser = apiUser.GetList(searchModel);
                gc_users.DataSource = listUser;
                 

                //this.gv_users.FocusedRowHandle = 0;
                if (listUser != null && listUser.Count >= 1)
                {
                    return listUser[0].totalCount;
                }
                else
                    return 0;
            }
            catch (ApiException ex)
            {
                MessageBox.Show(ex.ApiExceptionMessage.ExceptionMessage);

                return 0;
            }
        }

 

        private void sbtn_create_Click(object sender, EventArgs e)
        {
            frmUser frmUser = new Systems.frmUser();
            frmUser.actionType = (int)AppConfig.ActionType.Insert;
            frmUser.StartPosition = FormStartPosition.CenterParent;
            frmUser.ShowDialog();
            if (frmUser.DialogResult == DialogResult.Yes)
            {
                ucPager.Bind();
            }
        }

        private void sbtn_select_Click(object sender, EventArgs e)
        {
            if (te_query.Text.Length >= 1)
            {
                searchModel = new UserModel()
                {
                    LoginName = te_query.Text.Trim()
                };
            }
            else
            {
                InitData();
            }
            ucPager.Bind();
        }

        private void gv_users_CustomColumnDisplayText(object sender, DevExpress.XtraGrid.Views.Base.CustomColumnDisplayTextEventArgs e)
        {
            if (e.Column.FieldName.Equals("Enable"))
            {
                switch (e.DisplayText)
                {
                    case "Unchecked":
                        e.DisplayText = "禁用";
                        break;
                    default:
                        e.DisplayText = "启用";
                        break;
                }
            }
        }

        private void sbtn_update_Click(object sender, EventArgs e)
        {
            int rowId = gv_users.GetFocusedDataSourceRowIndex();

            if (listUser != null)
            {
                selectUserModel = listUser[rowId];
            }

            if (selectUserModel != null)
            {
                selectUserModel = listUser[rowId];
                ShowUser((int)AppConfig.ActionType.Update, selectUserModel);
            }
        }

        private void gv_users_DoubleClick(object sender, EventArgs e)
        {
            int rowId = gv_users.GetFocusedDataSourceRowIndex();

            if (listUser != null && rowId >= 0)
            {
                selectUserModel = listUser[rowId];
                ShowUser((int)AppConfig.ActionType.Update, selectUserModel);
            }
        }


        private void ShowUser(int actionType, UserModel userModel)
        {
            frmUser frmUser = new Systems.frmUser();
            frmUser.actionType = actionType;
            frmUser.userModel = userModel;
            frmUser.StartPosition = FormStartPosition.CenterParent;
            frmUser.ShowDialog();
            if (frmUser.DialogResult == DialogResult.Yes)
            {
                ucPager.Bind();
            }
        }

        private void sbtn_delete_Click(object sender, EventArgs e)
        {
            if (DevExpress.XtraEditors.XtraMessageBox.Show("是否确认删除用户信息？", "取消", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                int[] selectRows = gv_users.GetSelectedRows();
                if (selectRows.Length >= 1)
                {
                    List<string> ids = new List<string>();
                    foreach (int row in selectRows)
                    {
                        ids.Add(listUser[gv_users.GetDataSourceRowIndex(row)].ID);
                    }
                    apiUser.Delete(ids.ToArray());
                    InitData();
                }
                else
                {

                    DevExpress.XtraEditors.XtraMessageBox.Show("请选中需要删除的用户信息!", "确认", MessageBoxButtons.OK);
                }
            }
        }

    }
}