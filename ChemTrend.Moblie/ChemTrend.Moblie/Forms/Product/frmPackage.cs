﻿using System;
using System.Linq;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using BarcodeModel.MODEL.Barcode.FG;
using BarcodeModel.MODEL.Barcode.FG.Operation;
using BarcodeModel.API;
using ChemTrend.Moblie.Data;

namespace ChemTrend.Moblie.Forms.Product
{
    public partial class frmPackage : ChemTrend.Moblie.Forms.Base.BaseTForm
    {

        public string PackingID { get; set; }
        public string[] Barcodes { get; set; }
        private List<FGBarcodeModel> listBarcode = new List<FGBarcodeModel>();

        //应用于保存，条码信息
        private DataTable dt = new DataTable();

        public frmPackage()
        {
            InitializeComponent();
        }

        private void frmPackage_Load(object sender, EventArgs e)
        {
            base.mTitle.Text = "装箱";
            base.ucAction.Visible = true;
            base.ucAction.initString("提交");
            base.ucAction.Click += new EventHandler(ucAction_Click);

            InitData();

        }
        private void ucAction_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(this.tbox_package.Text))
            {
                this.tbox_package.Text = "";
                this.tbox_package.Focus();
                MessageBox.Show("请扫描或录入装箱条码！");
                return;
            }
            else if (listBarcode.Count <= 0)
            {
                this.tbox_barcode.Text = "";
                this.tbox_barcode.Focus();
                MessageBox.Show("请扫描或录入条码！");
                return;
            }
            List<string> barcodeList = new List<string>();
            foreach (FGBarcodeModel rw in listBarcode)
            {
                barcodeList.Add(rw.ID);
            }
            try
            {
                ModelAPI<PackingBarcodeModel> apiPB = new ModelAPI<PackingBarcodeModel>();
                PackingBarcodeModel pbModel = new PackingBarcodeModel()
                {
                    PackingID = this.tbox_package.Text,
                    Barcodes = barcodeList.ToArray(),
                    Status = (int)AppConfig.Packing.使用中
                };
                apiPB.Insert(pbModel);
                ResetData();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void ResetData()
        {

            this.tbox_package.Focus();
            this.tbox_package.Text = "";
            this.tbox_barcode.Text = "";
            this.dt.Clear();
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

        private void pbox_search_barcode_Click(object sender, EventArgs e)
        {

        }

        private void pbox_search_package_Click(object sender, EventArgs e)
        {

        }

        private void tbox_barcode_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void tbox_package_KeyDown(object sender, KeyEventArgs e)
        {

        }

    }
}