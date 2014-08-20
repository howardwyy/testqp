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
using BarcodeModel.MODEL;
using BarcodeModel.MODEL.User;
using DevExpress.XtraEditors.DXErrorProvider;
using DevExpress.XtraGrid.Views.Grid;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using DevExpress.XtraTreeList.Nodes;
using DevExpress.XtraTreeList;

namespace ChemTrend.Barcode.Forms.Systems
{
    public partial class frmRoles : DevExpress.XtraEditors.XtraForm
    {
        ModelAPI<RoleModel> apiRole = new ModelAPI<RoleModel>();
        List<RoleModel> listRole = null;

        ModelAPI<RightsModel> apiRights = new ModelAPI<RightsModel>();
        List<RightsModel> listRights = null;

        ModelAPI<RoleRightsModel> apiRR = new ModelAPI<RoleRightsModel>();

        //创建新的权限
        List<string> rights = new List<string>();

        RoleModel searchModel;
        RightsModel searchRightsModel;

        public frmRoles()
        {
            InitializeComponent();


        }
        private void frmRoles_Load(object sender, EventArgs e)
        {
            InitValidationRules();
            InitData();
        }


        private void InitValidationRules()
        {
            ConditionValidationRule notEmptyValidationRule = new ConditionValidationRule();
            notEmptyValidationRule.ConditionOperator = ConditionOperator.IsNotBlank;
            notEmptyValidationRule.ErrorText = "请输入名称！";
            dxvp_rolename.SetValidationRule(this.te_rolename, notEmptyValidationRule);//两个参数表示验name值为BulidName的TextEdit控件为notEmptyValidationRule验证


            notEmptyValidationRule.ErrorText = "请选中行！";
            dxvp_code.SetValidationRule(this.te_code, notEmptyValidationRule);


        }

        private void InitData()
        {
            listRole = apiRole.GetList(searchModel);
            gc_roles.DataSource = listRole;
            this.gv_roles.FocusedRowHandle = 0;

            listRights = apiRights.GetList(searchRightsModel);
            tl_rights.DataSource = listRights;
            tl_rights.ExpandAll();

        }

        private void resetView()
        {
            this.tl_rights.UncheckAll();
            this.te_code.Text = "";
            this.te_remark.Text = "";
            this.te_rolename.Text = "";
        }

        private void sbtn_create_Click(object sender, EventArgs e)
        {
            if (te_code.Text.Trim().Length >= 1)
            {
                resetView();
            }
            else
            {
                if (dxvp_rolename.Validate())
                {

                    //创建新的角色
                    apiRole = new ModelAPI<RoleModel>();
                    try
                    {
                        RoleModel roleModel = apiRole.Insert(new RoleModel()
                        {
                            RoleName = this.te_rolename.Text.Trim(),
                            Remark = this.te_remark.Text.Trim()
                        });

                        this.rights.Clear();


                        if (tl_rights.Selection.Count > 0)
                        {
                            GetCheckedID();

                            apiRR = new ModelAPI<RoleRightsModel>();
                            RoleRightsModel rrModel = new RoleRightsModel()
                            {
                                RoleID = roleModel.ID,
                                Rights = rights.ToArray()
                            };
                            apiRR.Insert(rrModel);
                        }
                        InitData();
                        resetView();
                    }
                    catch (Exception ex)
                    {

                    }
                }
            }

        }

        private void sbtn_delete_Click(object sender, EventArgs e)
        {
            if (dxvp_code.Validate())
            {
                if (DevExpress.XtraEditors.XtraMessageBox.Show("是否确认删除该角色？", "删除", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                {
                    apiRole.Delete(this.te_code.Text);
                    InitData();
                    resetView();
                }
            }
        }

        private void sbtn_update_Click(object sender, EventArgs e)
        {
            if (dxvp_rolename.Validate() && dxvp_code.Validate())
            {
                this.rights.Clear();


                if (tl_rights.Selection.Count > 0)
                {
                    GetCheckedID();

                    apiRR = new ModelAPI<RoleRightsModel>();
                    RoleRightsModel rrModel = new RoleRightsModel()
                    {
                        RoleID = this.te_code.Text.Trim(),
                        Rights = rights.ToArray()
                    };
                    apiRR.Insert(rrModel);
                }

                apiRole.Update(new RoleModel()
                {
                    ID = this.te_code.Text.Trim(),
                    RoleName = this.te_rolename.Text.Trim(),
                    Remark = this.te_remark.Text.Trim()
                });
                InitData();
            }

        }

        private void gv_roles_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            try
            {

                RoleModel selectRoleModel = listRole[gv_roles.GetFocusedDataSourceRowIndex()];

                if (selectRoleModel != null)
                {

                    SetCheckedNodes(selectRoleModel);
                    this.te_code.Text = selectRoleModel.ID;
                    this.te_rolename.Text = selectRoleModel.RoleName;
                    this.te_remark.Text = selectRoleModel.Remark;
                }
            }
            catch (Exception)
            {

            }
        }


        private void tl_rights_BeforeCheckNode(object sender, DevExpress.XtraTreeList.CheckNodeEventArgs e)
        {
            e.State = (e.PrevState == CheckState.Checked ? CheckState.Unchecked : CheckState.Checked);
        }

        private void tl_rights_AfterCheckNode(object sender, DevExpress.XtraTreeList.NodeEventArgs e)
        {
            SetCheckedChildNodes(e.Node, e.Node.CheckState);
            SetCheckedParentNodes(e.Node, e.Node.CheckState);
        }

        private void SetCheckedChildNodes(TreeListNode node, CheckState check)
        {
            for (int i = 0; i < node.Nodes.Count; i++)
            {
                node.Nodes[i].CheckState = check;
                SetCheckedChildNodes(node.Nodes[i], check);
            }
        }
        private void SetCheckedParentNodes(TreeListNode node, CheckState check)
        {
            if (node.ParentNode != null)
            {
                bool b = false;
                CheckState state;
                for (int i = 0; i < node.ParentNode.Nodes.Count; i++)
                {
                    state = (CheckState)node.ParentNode.Nodes[i].CheckState;
                    if (!check.Equals(state))
                    {
                        b = !b;
                        break;
                    }
                }
                node.ParentNode.CheckState = b ? CheckState.Indeterminate : check;
                SetCheckedParentNodes(node.ParentNode, check);
            }
        }

        private void SetCheckedNodes(RoleModel selectRoleModel)
        {
            this.tl_rights.UncheckAll();
            apiRR = new ModelAPI<RoleRightsModel>();
            RoleRightsModel rrModel = new RoleRightsModel()
            {
                RoleID = selectRoleModel.ID
            };

            rrModel = apiRR.GetModel(rrModel);
            foreach (TreeListNode treeListNode in tl_rights.GetNodeList())
            {
                if (rrModel.Rights != null)
                {
                    foreach (string right in rrModel.Rights)
                    {
                        if ((treeListNode["ID"] + "").Equals(right))
                        {
                            treeListNode.Checked = true;
                            break;
                        }
                    }
                }
            }
        }

        private void GetCheckedID()
        {
            foreach (TreeListNode treeListNode in tl_rights.GetAllCheckedNodes())
            {
                if (treeListNode.Checked)
                {
                    rights.Add(treeListNode["ID"] + "");
                }
            }
        }
    }
}