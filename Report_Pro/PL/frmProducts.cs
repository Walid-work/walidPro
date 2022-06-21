using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmProducts : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmProducts()
        {
            InitializeComponent();


            txtDimCategory.DataSource = dal.getDataTabl_1(@"select * FROM dbo.Wh_Unit_dim");
            txtDimCategory.DisplayMember = "Wh_Unit_dim";
            txtDimCategory.ValueMember = "Wh_Unit_dim";
            txtDimCategory.SelectedIndex = -1;

            txtWeightUnit.DataSource = dal.getDataTabl_1(@"SELECT Wh_Unit_Weight FROM Wh_Unit_Weight");
            txtWeightUnit.DisplayMember = "Wh_Unit_Weight";
            txtWeightUnit.ValueMember = "Wh_Unit_Weight";
            txtWeightUnit.SelectedIndex = -1;

            txtSalesUnit.DataSource = dal.getDataTabl_1(@"SELECT Wh_Unit  FROM Wh_Unit");
            txtSalesUnit.DisplayMember = "Wh_Unit";
            txtSalesUnit.ValueMember = "Wh_Unit";
            txtSalesUnit.SelectedIndex = -1;


        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void Get_Data(string itemNo)
        {
            DataTable dt_Item = new DataTable();
            dt_Item = dal.getDataTabl_1(@"SELECT  item_no,Company_code,Second_Company_code,factory_no,descr,Descr_eng,Memo_field,local_cost,last_local_cost,Oiner_Cost
            ,last_forign_cost,last_forign_curancy,sale_price,penfit_ratio,wsale_price,group_code,new_group_code,MSize,UnitSize,UnitLenth
            ,UnitWidth,UnitDepth,Weight,WeightUnit,Voltage,Unit,Color,Supplier_Unit,Backege,BALANCE,MOVMENT_REMARK,STATUS_OF_DESC,USER_ID
            ,MAX_STOCK,Min_Stock,REORDER_STOCK,BonasStock,Temp1,temp2,G_DATE,Last_user_id,Last_g_date,Holding_balance,Min_sale_price
            ,Min_wsale_price,Editing_Ser,NonStockItem,P1,P2,item_no2,Open_Items,Discontinue,Avareg_Monthely_Sales_qty
            ,Interval_For_Purchasing_by_month,Econmical_Purchasing_qty,Target_monthely_sales,Brand,Opsit_Backege,F_Sales_Disc_Ratio
            ,S_Sales_Disc_Ratio,T_Sales_Disc_Ratio,FO_Sales_Disc_Ratio,FI_Sales_Disc_Ratio,Expire_date_warning_perioud,o_balance
            ,Main_location,DEVISE_TYPE,modular_code,Heat_No,Area,Category,ITEM_NO_Componnet,Componnet_Base_qty,old_item_no,Oiner_Cost_p_y
            ,Dim_category,A,E,X_Y_DIM,No_Invintory,Class_Code,C01,C02,C03,C04,C05,C06,C07,C08,C09,C10,C11,C12,P01,P02,P03,P04,P05,P06,P07
            ,P08,P09,P10,P11,P12,PRINTING_ITEM_NO,ITEM_NO_01,ITEM_NO_02,ITEM_NO_03,ITEM_NO_04,ITEM_NO_05,ITEM_NO_01S,ITEM_NO_02S,ITEM_NO_03S
            ,ITEM_NO_04S,ITEM_NO_05S,ITEM_NO_06S,SALES_PRICE_RATIO,MIN_SALES_PRICE_RATIO,new_cost,ITEM_NO_06,ITEM_NO_07,ITEM_NO_08,ITEM_NO_09
            ,ITEM_NO_10,ITEM_NO_11,ITEM_NO_12,ITEM_NO_13,ITEM_NO_14,ITEM_NO_15,ITEM_NO_16,NON_DISC_ITEM,KIT_ITEM,KIT_PRICE,LOCAL_COST_PREV
            ,LAST_INVINTORY,MAIN_Machin_No,SOURCE_ITEM_NO,UNIT3,Package3,sale_price2,sale_price3,KM_CODE
            FROM wh_main_master  where item_no='"+itemNo+"'");
            if (dt_Item.Rows.Count > 0)
            {
                txtCode.Text = dt_Item.Rows[0]["item_no"].ToString();
                txtCompany.ID.Text = dt_Item.Rows[0]["Company_code"].ToString();
                txtFactoryNo.Text = dt_Item.Rows[0]["factory_no"].ToString();
                txtDescrption.Text = dt_Item.Rows[0]["descr"].ToString();
                txtDescrption_E.Text = dt_Item.Rows[0]["Descr_eng"].ToString();
                txtgroup.ID.Text = dt_Item.Rows[0]["group_code"].ToString();
                txtCategory.ID.Text = dt_Item.Rows[0]["Category"].ToString();
                txtType.ID.Text = dt_Item.Rows[0]["Class_Code"].ToString();
                txtSalesGroup.ID.Text = dt_Item.Rows[0]["A"].ToString();
                txtDimCategory.SelectedValue = dt_Item.Rows[0]["Dim_category"].ToString();
                txtKM_Item.ID.Text = dt_Item.Rows[0]["KM_CODE"].ToString();
                txtBrand.Text = dt_Item.Rows[0]["Brand"].ToString();
                txtColor.Text = dt_Item.Rows[0]["Color"].ToString();
                txtWeight.Text = dt_Item.Rows[0]["Weight"].ToString().ToDecimal().ToString("N3");
                txtLength.Text = dt_Item.Rows[0]["UnitLenth"].ToString().ToDecimal().ToString("N0");
                txtWidth.Text = dt_Item.Rows[0]["UnitWidth"].ToString().ToDecimal().ToString("N0");
                txtThickness.Text = dt_Item.Rows[0]["UnitDepth"].ToString().ToDecimal().ToString("N2");
                txtWeightUnit.SelectedValue = dt_Item.Rows[0]["WeightUnit"].ToString();
                txtSalesUnit.SelectedValue = dt_Item.Rows[0]["Unit"].ToString();
                txtSalesPrice.Text= dt_Item.Rows[0]["sale_price"].ToString();
                txtCost.Text = dt_Item.Rows[0]["local_cost"].ToString().ToDecimal().ToString("N3");
                txtLastCost.Text = dt_Item.Rows[0]["last_local_cost"].ToString().ToDecimal().ToString("N3");
                txtLastCost_F.Text = dt_Item.Rows[0]["last_forign_cost"].ToString().ToDecimal().ToString("N3");
                txtlastCurrency.Text = dt_Item.Rows[0]["last_forign_curancy"].ToString();
                txtCost_S.Text = dt_Item.Rows[0]["Oiner_Cost"].ToString().ToDecimal().ToString("N3");
                txtCostLastYear.Text = dt_Item.Rows[0]["Oiner_Cost_p_y"].ToString().ToDecimal().ToString("N3");
                txtLocation.Text = dt_Item.Rows[0]["Main_location"].ToString();

                
                if (Convert.ToBoolean(dt_Item.Rows[0]["Discontinue"].ToString()) == true)
                {
                    chStoped.Checked = true;
                }
                else
                {
                    chStoped.Checked = false;
                }
                if (Convert.ToBoolean(dt_Item.Rows[0]["NonStockItem"].ToString()) == true)
                {
                    rdoService.Checked = true;
                }
                else
                {
                    rdoStock.Checked = true;
                }

                GetModels(txtCode.Text);
               createbarcode(itemNo,P1);
                createbarcode(txtFactoryNo.Text, p2);

            }
        }


        private void GetModels(string itemNo)
        {
            DataTable dtModel = dal.getDataTabl_1(@"Select model,item_no,MAIN_TYPE,First_model,Descr from wh_model where item_no='" + itemNo + "'");
            int rowscount = dtModel.Rows.Count;
            dgvModel.Rows.Clear();
            if (rowscount > 0)
            {

                dgvModel.Rows.Add(rowscount);
                for (int i = 0; i <= (rowscount - 1); i++)
                {

                    dgvModel.Rows[i].Cells[0].Value = dtModel.Rows[i]["model"];
                    dgvModel.Rows[i].Cells[1].Value = dtModel.Rows[i]["item_no"];
                    dgvModel.Rows[i].Cells[2].Value = dtModel.Rows[i]["MAIN_TYPE"];
                    dgvModel.Rows[i].Cells[3].Value = dtModel.Rows[i]["First_model"];
                    dgvModel.Rows[i].Cells[4].Value = dtModel.Rows[i]["Descr"];
                }
            }
        }



        private void txtCode_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void doubleInput8_ValueChanged(object sender, EventArgs e)
        {

        }

        private void doubleInput7_ValueChanged(object sender, EventArgs e)
        {

        }

        private void doubleInput6_ValueChanged(object sender, EventArgs e)
        {

        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void frmProducts_Load(object sender, EventArgs e)
        {
            txtSalesGroup.txtFinal.Text = "1";
        }

        private void txtCode_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCode.Text != string.Empty)
            {
                Get_Data(txtCode.Text);
            }
        }


        //private void getBarCode(string itemCode)
        //{
        //    string barcode = itemCode;
        //    Bitmap bitmap = new Bitmap(barcode.Length * 15 + 20, 60);
        //    using (Graphics graphics = Graphics.FromImage(bitmap))
        //    {
        //        Font offont = new System.Drawing.Font("IDAHC39M Code 39 Barcode", 11);
        //        PointF point = new PointF(8f, 4f);
        //        SolidBrush black = new SolidBrush(Color.Black);
        //        SolidBrush White = new SolidBrush(Color.White);
        //        graphics.FillRectangle(White, 0, 0, bitmap.Width, bitmap.Height);
        //        graphics.DrawString(barcode, offont, black, point);
        //    }

        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        bitmap.Save(ms, ImageFormat.Png);
        //        p2.Image = bitmap;
        //        p2.Height = bitmap.Height;
        //        p2.Width = bitmap.Width;
        //    }

        //}



        private void BSave_Click(object sender, EventArgs e)
        {
            DataTable dt_check = dal.getDataTabl_1(@"select * from wh_main_master where item_no ='" + txtCode.Text + "'");
            if (dt_check.Rows.Count > 0)
            {
                dal.Execute_1(@"Update wh_main_master  set item_no = '" + txtCode.Text
                    + "',Company_code = '" + txtCompany.ID.Text
                    + "',factory_no = '" + txtFactoryNo.Text
                    + "',descr = '" + txtDescrption.Text
                    + "',Descr_eng = '" + txtDescrption_E.Text
                    + "',group_code = '" + txtgroup.ID.Text
                    + "',Category = '" + txtCategory.ID.Text
                    + "',Class_Code = '" + txtType.ID.Text
                    + "',A = '" + txtSalesGroup.ID.Text
                    + "',Dim_category = '" +Convert .ToString(txtDimCategory.SelectedValue)
                    + "',KM_CODE = '" + txtKM_Item.ID.Text
                    + "',Brand = '" + txtBrand.Text
                    + "',Color = '" + txtColor.Text
                    + "',Weight = '" + txtWeight.Text
                    + "',UnitLenth = '" + txtLength.Text
                    + "',UnitWidth = '" + txtWidth.Text
                    + "',UnitDepth = '" + txtThickness.Text
                    + "',WeightUnit = '" + Convert.ToString(txtWeightUnit.SelectedValue)
                    + "',Unit = '" + Convert.ToString(txtSalesUnit.SelectedValue)
                    + "',sale_price = '" + txtSalesPrice.Text
                    + "',local_cost = '" + txtCost.Text
                    + "',last_local_cost = '" + txtLastCost.Text
                    + "',last_forign_cost = '" + txtLastCost_F.Text
                    + "',last_forign_curancy = '" + txtlastCurrency.Text
                    + "',Oiner_Cost = '" + txtCost_S.Text
                    + "',Discontinue='"+ (chStoped.Checked ? "1" : "0")
                    + "',NonStockItem='" + (rdoService.Checked ? "1" : "0")
                    + "',Main_location='" + txtLocation.Text
                    + "' where item_no = '" + txtCode.Text+ "' and Company_code = '" + txtCompany.ID.Text+"' ");


            }
            else
            {

            }
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chStoped_CheckedChanged(object sender, EventArgs e)
        {
            if (chStoped.Checked == true)
            {
                chStoped.TextVisible = true;
            }
            else
            {
                chStoped.TextVisible = false;

            }
        }


      

        public byte[] imgToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }



        private void createbarcode(string barcode, PictureBox img)
        {
            if (barcode.Length>=1)
            {

            BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, barcode);

            // set resolution
            generator.Parameters.Resolution = 400;

            // generate barcode
            generator.Save("generate-barcode.png");
            img.Image = generator.GenerateBarCodeImage();
          byte[]  byteImage = imgToByteArray(img.Image);
             
             
              
            }
            else
            {
                img.Image = null;
            }
        }





        private void txtCode_TextChanged_1(object sender, EventArgs e)
        {
            createbarcode(txtCode.Text, P1);

        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtFactoryNo_TextChanged(object sender, EventArgs e)
        {
            createbarcode(txtFactoryNo.Text, p2);
        }


    



        private void print_sand_Click(object sender, EventArgs e)
        {

            PL.frm_pritBracode frm = new frm_pritBracode();
            frm.item_.ID.Text = txtCode.Text;
            frm.ShowDialog();


            //DataSet ds = new DataSet();
            //RPT.rpt_PrintBarcode rpt = new RPT.rpt_PrintBarcode();
            //DataTable dtBarcode = dal.getDataTabl_1(@"select item_no,factory_no,descr from wh_main_master where item_no ='"+txtCode.Text+"'");
            //if (dtBarcode.Rows.Count > 0)
            //{
            //    DataTable dQR = new DataTable();

            //    PictureBox img = new PictureBox();
            //    PictureBox img_f = new PictureBox();
            //    createbarcode(dtBarcode.Rows[0]["item_no"].ToString(), img);
            //    createbarcode(dtBarcode.Rows[0]["factory_no"].ToString(), img_f);
            //    byte[] byteImage;
            //    byte[] byteImage_f;

            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        img.Image.Save(ms, ImageFormat.Bmp);
            //        byteImage = ms.ToArray();
            //    }

            //    using (MemoryStream ms_f = new MemoryStream())
            //    {
            //        img_f.Image.Save(ms_f, ImageFormat.Bmp);
            //        byteImage_f = ms_f.ToArray();
            //    }

            //    dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
            //    dQR.Columns.Add(new DataColumn("Barcode_f", typeof(byte[])));
            //    dQR.Rows.Add(byteImage,byteImage_f);

            //    ds.Tables.Add(dtBarcode);
            //    ds.Tables.Add(dQR);
            //    //ds.WriteXmlSchema("schema_rpt.xml");
            //    rpt.SetDataSource(ds);
            //    for (int i = 1; i <= 3; i++)
            //    {
            //        rpt.PrintOptions.PrinterName = Properties.Settings.Default.Barcode_P;
            //        rpt.PrintToPrinter(1, false, 0, 15);
            //    }
            //}
        }

        private void tabControlPanel3_Click(object sender, EventArgs e)
        {

        }

        private void btnM_Save_Click(object sender, EventArgs e)
        {
            dal.Execute_1(@"INSERT INTO wh_model (model,item_no,MAIN_TYPE,First_model,Descr) VALUES ('" + txt_Model.Text+"','"+txtCode.Text+"','1','0','"+txtM_description.Text+"')");
            txt_Model.Clear();
            txtM_description.Clear();
            GetModels(txtCode.Text);
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            frm_search_items frm = new frm_search_items();
            frm.ShowDialog();
            
        }
    }
}
