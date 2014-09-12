﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.API;
using BarcodeModel.MODEL.Barcode.RW;

namespace ChemTrend.Moblie.Forms.Stock
{
    public partial class frmCheck : ChemTrend.Moblie.Forms.Base.BaseTForm
    {
        private DataTable dt = new DataTable();

        public frmCheck()
        {
            InitializeComponent();
        }

        private void frmCheck_Load(object sender, EventArgs e)
        {
            mTitle.Text = "盘点";
            base.ucAction.Visible = false;
            base.ucAction.initString("提交");


            this.tbox_barcode.Focus();
            
            InitData();
        }

        private void InitData()
        {

            dg_list.DataSource = dt;

            dt.Columns.Add("条码", typeof(string));
            dt.Columns.Add("物料", typeof(string));
            dt.Columns.Add("负责人", typeof(string));
            DataGridTableStyle ts = new DataGridTableStyle();
            ts.MappingName = dt.TableName;

            //分别对列进行渲染，其中前三列用for循环实现，对列宽进行设定，值为75
            int numColumns = dt.Columns.Count;
            for (int i = 0; i < numColumns - 1; i++)
            {
                DataGridColumnStyle aColumnTextColumnStyle = new DataGridTextBoxColumn();//定义该列用textbox来进行渲染
                aColumnTextColumnStyle.HeaderText = dt.Columns[i].ColumnName; ;  //列头
                aColumnTextColumnStyle.MappingName = dt.Columns[i].ColumnName; //映射数据源的列名，很重要，否则无数据显示
                aColumnTextColumnStyle.Width = 85; //在这里就可以对列宽进行设置了
                ts.GridColumnStyles.Add(aColumnTextColumnStyle);
                this.dg_list.TableStyles.Add(ts);
            }
            //第四列进行列宽设定，这一列为单独设置，定义列宽为200
            DataGridColumnStyle newStyle = new DataGridTextBoxColumn();
            newStyle.HeaderText = dt.Columns[2].ColumnName; ;  //列头
            newStyle.MappingName = dt.Columns[2].ColumnName;
            newStyle.Width = 160;
            ts.GridColumnStyles.Add(newStyle);
            this.dg_list.TableStyles.Add(ts);

        }

        private void pbox_search_Click(object sender, EventArgs e)
        {
            findBarcod();
        }

        private void findBarcod()
        {
            if (tbox_barcode.Text.Length >= 1)
            {
                ModelAPI<CheckModel> apiCheck = new ModelAPI<CheckModel>();
                CheckModel searchCheckModel = new CheckModel()
                {
                    BarcodeID = tbox_barcode.Text
                };

                CheckModel checkModel = null;
                try
                {
                    checkModel = apiCheck.GetModel(searchCheckModel);
                }
                catch (Exception)
                {
                    checkModel = null;
                }
                if (checkModel != null)
                {
                    MessageBox.Show(this.tbox_barcode.Text + "\n该条码已经盘点过了！");
                    this.tbox_barcode.Text = "";
                    this.tbox_barcode.Focus();
                }
                else
                {
                    try
                    {
                        ModelAPI<RWBarcodeModel> apiBarcode = new ModelAPI<RWBarcodeModel>();
                        RWBarcodeModel searchModel = new RWBarcodeModel()
                        {
                            ID = tbox_barcode.Text
                        };
                        RWBarcodeModel model = apiBarcode.GetModel(searchModel);
                        if (model != null)
                        {
                            addItem(model);
                        }
                        searchCheckModel.PlanID = "";
                        searchCheckModel.BarcodeID = tbox_barcode.Text;
                        searchCheckModel.CreateTime = System.DateTime.Now;
                        apiCheck.Insert(searchCheckModel);

                        this.tbox_barcode.Text = "";
                        this.tbox_barcode.Focus();
                    }

                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                }
            }
        }


        private void addItem(RWBarcodeModel model)
        {

            //在做完了这些之后，我们对新建的datatable中的列分别加入数据，例如我们在项目中所添加的：
            DataRow newRow = dt.NewRow();
            newRow["条码"] = model.ID;
            newRow["物料"] = model.StockCode;
            newRow["负责人"] = model.LastUserName;
            dt.Rows.Add(newRow);

        }

        private void tbox_barcode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                findBarcod();
            }
        }

        private void frmCheck_KeyDown(object sender, KeyEventArgs e)
        {
            if ((e.KeyCode == System.Windows.Forms.Keys.Up))
            {
                // Up
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Down))
            {
                // Down
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Left))
            {
                // Left
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Right))
            {
                // Right
            }
            if ((e.KeyCode == System.Windows.Forms.Keys.Enter))
            {
                // Enter
            }

        }

        private void dg_list_KeyPress(object sender, KeyPressEventArgs e)
        {
            int index = ((DataGrid)sender).CurrentCell.RowNumber;

            MessageBox.Show("你选中的行号为：" + Convert.ToInt32(index));
        }

    }
}

