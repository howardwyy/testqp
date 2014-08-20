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
using DevExpress.XtraEditors.Controls;
using ChemTrend.Barcode.Utils;

namespace ChemTrend.Barcode.Forms.Systems
{
    public partial class frmUser : DevExpress.XtraEditors.XtraForm
    {

        ModelAPI<UserModel> apiUser = new ModelAPI<UserModel>();
        public int actionType = 0;
        public UserModel userModel = null;
        public RoleModel searchModel { get; set; }
        public frmUser()
        {
            InitializeComponent();
        }


        private void frmUser_Load(object sender, EventArgs e)
        {
            InitValidationRules();
            InitData();
            InitView();
        }

        private void InitValidationRules()
        {
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "请输入用户名！";
            dxvp_loginname.SetValidationRule(this.te_loginname, notEmptyValidationRule);//两个参数表示验name值为BulidName的TextEdit控件为notEmptyValidationRule验证


            notEmptyValidationRule.ErrorText = "请输入真实姓名！";
            dxvp_username.SetValidationRule(this.te_username, notEmptyValidationRule);


            notEmptyValidationRule.ErrorText = "请选择用户所属角色！";
            dxvp_role.SetValidationRule(this.lue_roles, notEmptyValidationRule);



        }


        private void InitView()
        {
            te_createtime.Text = String.Format("{0:yyyy/MM/dd HH:mm:ss}", DateTime.Now); ;
            switch (actionType)
            {
                case (int)AppConfig.ActionType.Insert:
                    sbtn_create.Visible = true;
                    sbtn_update.Visible = false;
                    lue_roles.Properties.NullText = "请选择用户角色";
                    break;
                case (int)AppConfig.ActionType.Update:
                    sbtn_create.Visible = false;
                    sbtn_update.Visible = Visible;
                    if (userModel != null)
                    {
                        if (userModel.Password != null)
                        {
                            string DecryptPwd = DESEncryptUtil.Decrypt(userModel.Password);
                            this.te_password.Text = DecryptPwd;
                        }
                        this.te_id.Text = userModel.ID;
                        this.te_usercode.Text = userModel.UserCode;
                        this.te_loginname.Text = userModel.LoginName;
                        this.te_username.Text = userModel.UserName;
                        this.te_createtime.Text = String.Format("{0:yyyy/MM/dd HH:mm:ss}", userModel.CreateTime);
                        this.ck_ischeck.Checked = userModel.Enable;
                    }
                    break;
                default:
                    break;
            }
        }

        private void InitData()
        {
            ModelAPI<RoleModel> apiRole = new ModelAPI<RoleModel>();
            List<RoleModel> listRole = apiRole.GetList(searchModel);
            lue_roles.Properties.DataSource = listRole;
            if (actionType.Equals((int)AppConfig.ActionType.Update))
            {
                if (userModel != null)
                {
                    this.lue_roles.ItemIndex = GetItemIndex(listRole, userModel.RoleID);
                }
            }
        }

        private int GetItemIndex(List<RoleModel> list, string id)
        {
            for (int i = 0; i < list.Count; i++)
            {
                if (list[i].ID.Equals(id))
                {
                    return i;
                }
            }
            return -1;
        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {

            if (dxvp_loginname.Validate() && dxvp_username.Validate() && dxvp_role.Validate())
            {
                RoleModel roleModel = lue_roles.GetSelectedDataRow() as RoleModel;

                string EncryptPwd = DESEncryptUtil.Encrypt(this.te_password.Text);

                apiUser.Insert(new UserModel()
                {
                    Password = EncryptPwd,
                    UserCode = this.te_usercode.Text,
                    LoginName = this.te_loginname.Text,
                    UserName = this.te_username.Text,
                    CreateTime = DateTime.Now,
                    Enable = this.ck_ischeck.Checked,
                    RoleID = roleModel.ID,
                    RoleName = roleModel.RoleName
                });
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void sbtn_update_Click(object sender, EventArgs e)
        {

            if (dxvp_loginname.Validate() && dxvp_username.Validate() && dxvp_role.Validate())
            {
                RoleModel roleModel = lue_roles.GetSelectedDataRow() as RoleModel;
                string EncryptPwd = DESEncryptUtil.Encrypt(this.te_password.Text);
                apiUser.Update(new UserModel()
                {
                    ID = userModel.ID,
                    UserCode = this.te_usercode.Text,
                    LoginName = this.te_loginname.Text,
                    Password = EncryptPwd,
                    UserName = this.te_username.Text,
                    Enable = this.ck_ischeck.Checked,
                    RoleID = roleModel.ID,
                    CreateTime = userModel.CreateTime,
                    RoleName = roleModel.RoleName
                });
                this.DialogResult = DialogResult.Yes;
            }
        }

        private void sbtn_close_Click(object sender, EventArgs e)
        {
            this.Close();
        }



    }
}