using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using QRCoder;
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
using System.Windows.Forms;
using HScrollBar = System.Windows.Forms.HScrollBar;
using VScrollBar = System.Windows.Forms.VScrollBar;

namespace Report_Pro.PL
{
   
    public partial class frm_check_item_Price_Copy : XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        int days = 1;
        DataTable dt_inv;
        DataTable dt_inv_total;
        int currencyNo = 2;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();

        DataTable dt_;
        DataTable dt_1 =  new DataTable();
        DataTable dt = new DataTable();
        string db1 = Properties.Settings.Default.Database_1;
        public frm_check_item_Price_Copy()
        {
            InitializeComponent();

            txtUnit.DataSource = dal.getDataTabl_1("select wh_unit from wh_unit");
            txtUnit.DisplayMember = "wh_unit";
            txtUnit.ValueMember = "wh_unit";
            txtUnit.SelectedIndex = -1;

        }

      

        void total_()
        {
            days = Convert.ToInt32((ToDate.Value - FromDate.Value).TotalDays);


            txtBalance.Text =
            (from DataGridViewRow row in DGV_b.Rows
            where row.Cells[0].FormattedValue.ToString() != string.Empty
            select (row.Cells[1].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            txtGIT.Text =
            (from DataGridViewRow row in DGV_b.Rows
             where row.Cells[0].FormattedValue.ToString() != string.Empty
             select (row.Cells[2].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            txtTotalBalance.Text =
            (from DataGridViewRow row in DGV_b.Rows
             where row.Cells[0].FormattedValue.ToString() != string.Empty
             select (row.Cells[3].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            txtBalance_weight.Text =
            (from DataGridViewRow row in DGV_b.Rows
            where row.Cells[0].FormattedValue.ToString() != string.Empty
            select (row.Cells[4].FormattedValue).ToString().ToDecimal()).Sum().ToString();


            totalSales.Text =
            (from DataGridViewRow row in DGV_b.Rows
            where row.Cells[0].FormattedValue.ToString() != string.Empty
            select (row.Cells[5].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            totalSales_weight.Text = (totalSales.Text.ToDecimal() * txtWeight.Text.ToDecimal()).ToString("N0");

            if (totalSales.Value > 0)
            {
                Monthely_Sales.Value = Math.Round(totalSales.Value * 30 / days,0);
                balance_period.Value = Math.Round(txtTotalBalance.Value / Monthely_Sales.Value,2);
            }
            else
            {
                Monthely_Sales.Value = 0;
                balance_period.Value = 0;

            }
            if (totalSales_weight.Value > 0)
            {
                Monthely_Sales_weight.Value = Math.Round(totalSales_weight.Value * 30 / days, 0);
            }
            else
            {
                Monthely_Sales_weight.Value = 0;

            }

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void unit_price_KeyUp(object sender, KeyEventArgs e)
        {
            ton_price.Text = (unit_price.Value / txtWeight.Value*1000).ToString("N0");

            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }

        }

        private void ton_price_KeyUp(object sender, KeyEventArgs e)
        {
            unit_price.Text = (ton_price.Value * txtWeight.Value / 1000).ToString("N3"); ;
            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }
        }

      

        private void mRrate_KeyUp_1(object sender, KeyEventArgs e)
        {
            txtCost_1.Text = (txtCost.Value* (1 + mRrate.Value / 100)).ToString("N3"); ;
            txtTonCost_1.Text = (txtTonCost.Value* (1 + mRrate.Value / 100)).ToString("N0"); ;
            if (unit_price.Value > txtCost_1.Value)
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Ok_icon1;
            }
            else
            {
                piBox1.Image = global::Report_Pro.Properties.Resources.Cross_icon;

            }
        }

        private void Uc_Items_Load(object sender, EventArgs e)
        {
            clearFormData();
           // getData();
        }


        private void clearFormData()
        {

            txtCost.Value = 0;
            txtLong.Value = 0;
            txtWidth.Value = 0;
            txtThickness.Value = 0;
            txtWeight.Value = 0;
            txtTonCost.Value = 0;
            txtUnit.SelectedValue = 0;
            txtCost_1.Value = 0;
            txtTonCost_1.Value = 0;
            unit_price.Value = 0;
            ton_price.Value = 0;

            DGV_b.DataSource = null;
            DGV_b.Rows.Clear();

            dgv_LS.DataSource = null;
            dgv_LS.Rows.Clear();

            dgv_LP.DataSource = null;
            dgv_LP.Rows.Clear();
            total_();
        }

        private void getData()
        {
            if(Uc_Items.ID.Text.Trim()!= string.Empty)
            {
                txtCost.Text = Uc_Items.txtCost.Value.ToString().ToDecimal().ToString();
                txtLong.Text = Uc_Items.txtLenth.Value.ToString().ToDecimal().ToString();
                txtWidth.Text = Uc_Items.txtWidth.Value.ToString().ToDecimal().ToString();
                txtThickness.Text = Uc_Items.txtDepth.Value.ToString().ToDecimal().ToString();
                txtWeight.Text = Uc_Items.itemWeight.Value.ToString().ToDecimal().ToString();
                txtTonCost.Text = Math.Round(Uc_Items.txtCost.Value.ToString().ToDecimal() / Uc_Items.itemWeight.Value.ToString().ToDecimal() * 1000,0).ToString();
                txtUnit.SelectedValue = Uc_Items.itemUnit.Text;
                txtCost_1.Value = txtCost.Value * (1 + mRrate.Value / 100);
                txtTonCost_1.Value = txtTonCost.Value * (1 + mRrate.Value / 100);
                unit_price.Value = 0;
                ton_price.Value = 0;
                get_balance();
                get_last_Purch(Uc_Items.ID.Text);
                get_last_Sales(Uc_Items.ID.Text);
            }
            else
            {
                MessageBox.Show("فضلا تأكد من اختيار الصنف");
            }


        }

        private void get_balance()
        {

            DataTable dt_b = dal.getDataTabl_1(@"select * from(select T.Branch_code,t.branch_name,T.balance,X.Sales_,Y.GIT_ from ( SELECT  D.Branch_code,A.branch_name,sum (case when cast(D.G_date as date) <= '" + ToDate.Value.ToString("yyyy-MM-dd") + "' and D.cyear = '"+ ToDate.Value.ToString("yy") + "' then D.QTY_ADD-D.QTY_TAKE  else 0 end)  as balance "+
            "FROM wh_material_transaction As D inner join wh_BRANCHES As A on A.Branch_code = D.Branch_code "+
            "where D.item_no = '" + Uc_Items.ID.Text+"'  group by D.Branch_code, A.branch_name) as T " +
            "left join (select Branch_code,SUM(QTY_TAKE-QTY_ADD) as Sales_ " +
            "from wh_material_transaction  where TRANSACTION_CODE like 'xs%'  and cast(G_DATE as date) between '"+ FromDate.Value.ToString("yyyy-MM-dd")+"' and '"+ ToDate.Value.ToString("yyyy-MM-dd")+"'	and item_no = '"+ Uc_Items.ID.Text + "'		group by Branch_code) as X " +
            "on T.Branch_code=X.Branch_code " +
            "left join (select B.Acc_no,SUM(QTY_TAKE-QTY_ADD) as GIT_ " +
            "from wh_material_transaction as A " +
            "inner join wh_inv_data As B on A.SER_NO = B.Ser_no and A.Branch_code = B.Branch_code and A.Cyear = B.Cyear and A.Transaction_code = B.Transaction_code   where B.TRANSACTION_CODE = 'XTO' and B.Recvied_by_another_Store is null  and item_no = '" + Uc_Items.ID.Text + 
            "' group by B.Acc_no) as Y " +
            "on T.Branch_code = Y.Acc_no " +
            "where t.balance <> 0 or X.Sales_ <> 0 or Y.GIT_ <> 0) as Z where Branch_code like '"+Store.ID.Text+"%'");
            if (dt_b.Rows.Count > 0)
            {
                
                days =Convert.ToInt32 ((ToDate.Value - FromDate.Value).TotalDays);
                DGV_b.RowCount = dt_b.Rows.Count;

                for (int i = 0; i < DGV_b.RowCount; i++)
                {
                    DGV_b.Rows[i].Cells[0].Value = dt_b.Rows[i]["branch_name"];
                    DGV_b.Rows[i].Cells[1].Value = dt_b.Rows[i]["balance"];
                    DGV_b.Rows[i].Cells[2].Value = dt_b.Rows[i]["GIT_"];
                    DGV_b.Rows[i].Cells[3].Value = dt_b.Rows[i]["balance"].ToString().ToDecimal() + dt_b.Rows[i]["GIT_"].ToString().ToDecimal();
                    DGV_b.Rows[i].Cells[4].Value = (dt_b.Rows[i]["balance"].ToString().ToDecimal() + dt_b.Rows[i]["GIT_"].ToString().ToDecimal()) * txtWeight.Value;
                    DGV_b.Rows[i].Cells[5].Value = dt_b.Rows[i]["Sales_"].ToString().ToDecimal();
                    DGV_b.Rows[i].Cells[6].Value = dt_b.Rows[i]["Sales_"].ToString().ToDecimal() * txtWeight.Text.ToDecimal();
                    DGV_b.Rows[i].Cells[7].Value = Math.Round(dt_b.Rows[i]["Sales_"].ToString().ToDecimal() * 30 / days,0) ;
                    DGV_b.Rows[i].Cells[8].Value = Math.Round((dt_b.Rows[i]["Sales_"].ToString().ToDecimal() * 30 / days) * txtWeight.Text.ToDecimal(), 0); 
                    if (dt_b.Rows[i]["Sales_"].ToString().ToDecimal() > 0)
                    {
                        DGV_b.Rows[i].Cells[9].Value = (dt_b.Rows[i]["balance"].ToString().ToDecimal() + dt_b.Rows[i]["GIT_"].ToString().ToDecimal()) / (dt_b.Rows[i]["Sales_"].ToString().ToDecimal() * 30 / days);
                    }
                    else
                    {
                        DGV_b.Rows[i].Cells[9].Value = "0";
                    }

                    DGV_b.Rows[i].Cells[10].Value = dt_b.Rows[i]["Branch_code"];
                }
            }
            else
            {
                DGV_b.DataSource = null;
                DGV_b.Rows.Clear();
            }
                                                                    
            total_();


        }
        private void get_last_Purch(string item_no)
        {
            int X = nRow.Value;
            if (X > 0)
            {
                X = nRow.Value;
            }
            else
            {
                X = 1000;
            }
            DataTable dt_LP = dal.getDataTabl_1(" DECLARE  @X int ='" + X + @"' select top (isnull(@X,1000))  A.ser_no,A.G_DATE,A.QTY_ADD,A.Local_Price,P.PAYER_NAME,C.branch_name,A.Branch_code,a.Cyear, A.TRANSACTION_CODE from wh_material_transaction as A
            inner join wh_inv_data as B on A.SER_NO=B.Ser_no and A.TRANSACTION_CODE=B.TRANSACTION_CODE and a.Branch_code=b.Branch_code and a.Cyear=b.Cyear
            inner join payer2 as P on p.ACC_NO=b.Acc_no and b.Acc_Branch_code=p.BRANCH_code 
            inner join wh_BRANCHES As C on A.Branch_code=C.Branch_code 
            where item_no='" + item_no + "' and A.Branch_code like '"+Store.ID.Text+ "%' and cast(A.G_DATE as Date) between '" + fromDate_1.Value.ToString("yyyy-MM-dd")+ "' and '" + toDate_1.Value.ToString("yyyy-MM-dd") + "'  and (A.TRANSACTION_CODE='Xpc' or A.TRANSACTION_CODE='XpE' or A.TRANSACTION_CODE='Xpd') order by G_DATE desc");



            if (dt_LP.Rows.Count > 0)
            {

                dgv_LP.RowCount = dt_LP.Rows.Count;

                for (int ii = 0; ii < dgv_LP.RowCount; ii++)
                {
                    dgv_LP.Rows[ii].Cells[0].Value = dt_LP.Rows[ii]["branch_name"].ToString();
                    dgv_LP.Rows[ii].Cells[1].Value = dt_LP.Rows[ii]["ser_no"].ToString();
                    dgv_LP.Rows[ii].Cells[2].Value = dt_LP.Rows[ii]["G_DATE"];
                    dgv_LP.Rows[ii].Cells[3].Value = dt_LP.Rows[ii]["QTY_ADD"];
                    dgv_LP.Rows[ii].Cells[4].Value = dt_LP.Rows[ii]["Local_Price"];

                    if (txtWeight.Value > 0)
                    {
                        dgv_LP.Rows[ii].Cells[5].Value = (Math.Round(dt_LP.Rows[ii]["Local_Price"].ToString().ToDecimal() / txtWeight.Text.ToDecimal() * 1000, 0)).ToString("N0");
                    }
                    else
                    {
                        dgv_LP.Rows[ii].Cells[5].Value = 0;
                    }
                    dgv_LP.Rows[ii].Cells[6].Value = dt_LP.Rows[ii]["PAYER_NAME"].ToString();
                    dgv_LP.Rows[ii].Cells[7].Value = dt_LP.Rows[ii]["Branch_code"].ToString();
                    dgv_LP.Rows[ii].Cells[8].Value = dt_LP.Rows[ii]["Cyear"].ToString();
                    dgv_LP.Rows[ii].Cells[9].Value = dt_LP.Rows[ii]["TRANSACTION_CODE"].ToString();


                }
            }
            else
            {
                dgv_LP.DataSource = null;
                dgv_LP.Rows.Clear();
            }



        }


        private void get_last_Sales(string item_no)
        {
            int X = nRow.Value;
            if (X > 0)
            {
                X = nRow.Value;
            }
            else
            {
                X = 1000;
            }
            DataTable dt_Ls = dal.getDataTabl_1(" DECLARE  @X int ='" + X + @"' select top (isnull(@X,1000))  A.ser_no,A.G_DATE,A.QTY_TAKE,A.Local_Price,P.PAYER_NAME,C.branch_name,A.Branch_code,a.Cyear, A.TRANSACTION_CODE  from wh_material_transaction as A
            inner join wh_inv_data as B on A.SER_NO=B.Ser_no and A.TRANSACTION_CODE=B.TRANSACTION_CODE and a.Branch_code=b.Branch_code and a.Cyear=b.Cyear
            inner join payer2 as P on p.ACC_NO=b.Acc_no and b.Acc_Branch_code=p.BRANCH_code
            inner join wh_BRANCHES As C on A.Branch_code=C.Branch_code 
            where item_no='" + item_no + "'  and A.Branch_code like '" + Store.ID.Text + "%'  and cast(A.G_DATE as Date) between '" + fromDate_1.Value.ToString("yyyy-MM-dd") + "' and '" + toDate_1.Value.ToString("yyyy-MM-dd") + "' and (A.TRANSACTION_CODE='XSC' or A.TRANSACTION_CODE='XSD' or A.TRANSACTION_CODE='opo') order by G_DATE desc");



            if (dt_Ls.Rows.Count > 0)
            {

                dgv_LS.RowCount = dt_Ls.Rows.Count;

                for (int ii = 0; ii < dgv_LS.RowCount; ii++)
                {
                    dgv_LS.Rows[ii].Cells[0].Value = dt_Ls.Rows[ii]["branch_name"].ToString();
                    dgv_LS.Rows[ii].Cells[1].Value = dt_Ls.Rows[ii]["ser_no"].ToString();
                    dgv_LS.Rows[ii].Cells[2].Value = dt_Ls.Rows[ii]["G_DATE"];
                    dgv_LS.Rows[ii].Cells[3].Value = dt_Ls.Rows[ii]["QTY_TAKE"];
                    dgv_LS.Rows[ii].Cells[4].Value = dt_Ls.Rows[ii]["Local_Price"];

                    if (txtWeight.Value > 0)
                    {
                        dgv_LS.Rows[ii].Cells[5].Value = (Math.Round(dt_Ls.Rows[ii]["Local_Price"].ToString().ToDecimal() / txtWeight.Text.ToDecimal() * 1000, 0)).ToString("N0");
                    }
                    else
                    {
                        dgv_LS.Rows[ii].Cells[5].Value = 0;
                    }
                    dgv_LS.Rows[ii].Cells[6].Value = dt_Ls.Rows[ii]["PAYER_NAME"].ToString();
                    dgv_LS.Rows[ii].Cells[7].Value = dt_Ls.Rows[ii]["Branch_code"].ToString();
                    dgv_LS.Rows[ii].Cells[8].Value = dt_Ls.Rows[ii]["Cyear"].ToString();
                    dgv_LS.Rows[ii].Cells[9].Value = dt_Ls.Rows[ii]["TRANSACTION_CODE"].ToString();
                }
            }
            else
            {
                dgv_LS.DataSource = null;
                dgv_LS.Rows.Clear();
            }





        }





        private void Uc_Items_KeyDown(object sender, KeyEventArgs e)
        {
            try
            {
                if (e.KeyCode == Keys.Enter)
                {

                    dt_ = dal.getDataTabl_1("SELECT *  FROM wh_main_master where item_no = '"+ Uc_Items.ID.Text + "'");
                    if (dt_.Rows.Count > 0)
                    {
                        txtCost.Value = dt_.Rows[0][7].ToString().ToDecimal();
                        txtLong.Value = dt_.Rows[0][19].ToString().ToDecimal();
                        txtWeight.Value = dt_.Rows[0][20].ToString().ToDecimal();
                        txtThickness.Value = dt_.Rows[0][21].ToString().ToDecimal();
                        txtWeight.Value = dt_.Rows[0][22].ToString().ToDecimal();
                        txtTonCost.Value = dt_.Rows[0][7].ToString().ToDecimal() / txtWeight.Value * 1000;
                        txtCost_1.Value = txtCost.Value * (1 + mRrate.Value / 100);
                        txtTonCost_1.Value = txtTonCost.Value * (1 + mRrate.Value / 100);
                        unit_price.Value = 0;
                        ton_price.Value = 0;
                        get_balance();
                    }
                    else
                    {
                        txtCost.Value = 0;
                        txtLong.Value = 0;
                        txtWeight.Value = 0;
                        txtThickness.Value = 0;
                        txtWeight.Value = 0;
                        unit_price.Value = 0;
                        ton_price.Value = 0;
                        txtTonCost.Value = 0;
                        PL.frm_search_items frm = new PL.frm_search_items();
                        frm.ShowDialog();
                        Uc_Items.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                        get_balance();
                    }

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


       

        private void Uc_Items_Click(object sender, EventArgs e)
        {
          
        }

        private void labelX16_Click(object sender, EventArgs e)
        {

        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }

        private void frm_check_item_Price_Load(object sender, EventArgs e)
        {
            // set datagridveiw location and size
            Store.dgv1 = dgv1;
            Store._x = Store.Location.X;
            Store._y = Store.Location.Y + Store.Height;
            Store._width = Store.Width; 
          


            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;

            fromDate_1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            toDate_1.Value = DateTime.Today;

            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));
            string currency = Properties.Settings.Default.Currency;
            if (!(currency == "s"))
            {
                if (!(currency == "BH"))
                {
                    if (!(currency == "OM"))
                    {
                        if (!(currency == "DR"))
                            return;
                        currencyNo = 1;
                    }
                    else
                        currencyNo = 6;
                }
                else
                    currencyNo = 5;
            }
            else
                currencyNo = 2;

              

        }

    
        private void nRow_ValueChanged(object sender, EventArgs e)
        {
            get_last_Purch(Uc_Items.ID.Text);
            get_last_Sales(Uc_Items.ID.Text);
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void dgv_LS_DoubleClick(object sender, EventArgs e)
        {
            RPT.Rpt_inv rptInv = new RPT.Rpt_inv();
            RPT.Form1 frm = new RPT.Form1();

            DataSet dataSet = new DataSet();

            string inv_no = dgv_LS.CurrentRow.Cells[1].Value.ToString();
            string brnch_code = dgv_LS.CurrentRow.Cells[7].Value.ToString();
            string trans_code = dgv_LS.CurrentRow.Cells[9].Value.ToString();
            string cyear = dgv_LS.CurrentRow.Cells[8].Value.ToString();



            getSalesInv(inv_no, brnch_code, trans_code, cyear);
            getInvoiceTotal(inv_no, brnch_code, trans_code, cyear);



            string code = "\\188.117.98.44\\d\\xx";
                //"  /RPT/print_inv.aspx?p1=" + inv_no+"&p2=" +brnch_code+"&p3="+trans_code+"&p4="+cyear;
                //"Alusaimi Steel " + System.Environment.NewLine + "Invoice No. :" + dgv_LS.CurrentRow.Cells[1].Value.ToString() + System.Environment.NewLine + "Branch Code :" + dgv_LS.CurrentRow.Cells[7].Value.ToString() + System.Environment.NewLine + "Total Value :" + dt_inv_total.Rows[0]["NetValue"] + System.Environment.NewLine + "VAT Value :" + dt_inv_total.Rows[0]["tax"];

            
            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap bmp = qRCode.GetGraphic(7);
            DataTable dQR = new DataTable();
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);

                byte[] byteImage = ms.ToArray();

                //picQR.Image = bmp;

                // RPT.QR_rpt rpt = new RPT.QR_rpt();
                dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
                dQR.Rows.Add(byteImage);
            }



            dataSet.Tables.Add(dt_inv);
            dataSet.Tables.Add(dQR);
            //dataSet.WriteXmlSchema("schema_rpt.xml");
            rptInv.SetDataSource(dataSet);
            rptInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + dgv_LS.CurrentRow.Cells[7].Value.ToString() + " - " + dgv_LS.CurrentRow.Cells[0].Value.ToString() + "'";
            ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_inv_total.Rows[0]["NetValue"].ToString())), currencies[currencyNo]);
            rptInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";


            frm.crystalReportViewer1.ReportSource = rptInv;
            frm.ShowDialog();

            //rptInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;

            //rptInv.PrintToPrinter(1, false, 0, 0);
            //rptInv.Close();
            //rptInv.Dispose();
        }


        private byte[] GenerateQrCode(string qrmsg)
        {

            string code = qrmsg;
            QRCodeGenerator qrGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qrGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
               QRCode qrCode = new QRCode(qRCodeData);

            System.Web.UI.WebControls.Image imgBarCode = new System.Web.UI.WebControls.Image();
            imgBarCode.Height = 150;
            imgBarCode.Width = 150;
            using (Bitmap bitMap = qrCode.GetGraphic(7))
            {
                using (MemoryStream ms = new MemoryStream())
                {
                    bitMap.Save(ms, System.Drawing.Imaging.ImageFormat.Bmp);
                    byte[] byteImage = ms.ToArray();
                    return byteImage;
                }
            }

        }

        private void getSalesInv(string ser_, string branch_, string transaction_, string cyear_)

        {
            dt_inv = this.dal.getDataTabl_1(@"select A.ser_no,A.Branch_code,A.Cyear,A.Transaction_code,A.G_date,A.Acc_no,A.Payment_Type,A.Sales_man_Id,A.Inv_no,A.Inv_date,a.Inv_Notes,A.Phone,A.Adress,
            B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.Unit,B.Local_Price,isnull(B.TAX_IN,0)as TAX_IN ,isnull(B.TAX_OUT,0)as TAX_OUT , round(b.total_disc*B.local_price*QTY_TAKE/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,
            m.descr,m.Descr_eng, br.branch_name,BR.WH_E_NAME,PT.Payment_name 
            ,(select top 1 vat_ratio from VAT_RATIO_MASTER where cast(A.G_date as date ) between date_of_vat and '"+ DateTime.Today.ToString("yyyy-MM-dd")+"' order by date_of_vat desc) as VatRatio " +
            "from wh_inv_data As A "+
            "inner join wh_material_transaction As B on a.Ser_no = b.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code  " +
            "inner join payer2 As P on a.Acc_no = p.ACC_NO and a.Acc_Branch_code = p.BRANCH_code  " +
            "left join(select* from payer2)as p2 on p2.ACC_NO = a.LC_ACC_NO and a.Acc_Branch_code = p2.BRANCH_code  " +
            "inner join wh_main_master as M on M.item_no = b.ITEM_NO  " +
            "inner join wh_BRANCHES As BR on BR.Branch_code = a.Branch_code  " +
            "inner join wh_Payment_type as PT on A.Payment_Type=PT.Payment_type  " +
            "where a.SER_NO = '" + ser_ + "' and a.Transaction_code = '" + transaction_ + "' and a.Branch_code = '" + branch_ + "' and a.Cyear = '" + cyear_ + "'");
        }
        //(select case when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) between '2018-01-01' and '2020-06-30'   then 5  when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) > '2020-06-30' then 15  else 0 end)as VatRatio

        private void getInvoiceTotal(string ser_, string branch_, string transaction_, string cyear_)
        {
            dt_inv_total = dal.getDataTabl_1(@"select round(sum(b.QTY_TAKE*Local_Price),2) as TotalValue
            , round(sum(b.total_disc * B.local_price * QTY_TAKE / 100), 2) as discount
            , round(sum(isnull(b.TAX_OUT, 0)), 2) as tax
            , round(sum(b.QTY_TAKE * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_TAKE / 100), 2) + round(sum(isnull(b.TAX_OUT, 0)), 2) as NetValue
            , round(sum(b.QTY_ADD * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_ADD / 100), 2) + round(sum(isnull(b.TAX_IN, 0)), 2) as NetValuePurch from wh_material_transaction as b
            where b.SER_NO = '" + ser_ + "'  and b.Transaction_code = '" + transaction_ + "' and b.Branch_code = '" + branch_ + "' and b.Cyear = '" + cyear_ + "'  " +
            "group by TRANSACTION_CODE,Branch_code,Cyear,SER_NO");
        }

        private void getInvoiceTotal_purch(string ser_, string branch_, string transaction_, string cyear_)
        {
            dt_inv_total = dal.getDataTabl_1(@"select round(sum(b.QTY_TAKE*Local_Price),2) as TotalValue
            , round(sum(b.total_disc * B.local_price * QTY_ADD / 100), 2) as discount
            , round(sum(isnull(b.TAX_IN, 0)), 2) as tax
            , round(sum(b.QTY_ADD * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_ADD / 100), 2) + round(sum(isnull(b.TAX_IN, 0)), 2) as NetValue
             from wh_material_transaction as b
            where b.SER_NO = '" + ser_ + "'  and b.Transaction_code = '" + transaction_ + "' and b.Branch_code = '" + branch_ + "' and b.Cyear = '" + cyear_ + "'  " +
            "group by TRANSACTION_CODE,Branch_code,Cyear,SER_NO");
        }

        private void dgv_LP_DoubleClick(object sender, EventArgs e)
        {
           // RPT.Rpt_inv rptInv = new RPT.Rpt_inv();

            RPT.print_PurchaseInv rptInv = new RPT.print_PurchaseInv();
            RPT.Form1 frm = new RPT.Form1();

            DataSet dataSet = new DataSet();
            getSalesInv(dgv_LP.CurrentRow.Cells[1].Value.ToString(), dgv_LP.CurrentRow.Cells[7].Value.ToString(), dgv_LP.CurrentRow.Cells[9].Value.ToString(), dgv_LP.CurrentRow.Cells[8].Value.ToString());
            dataSet.Tables.Add(dt_inv);
            //dataSet.WriteXmlSchema("schema_rpt.xml");
            rptInv.SetDataSource(dataSet);
            rptInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + dgv_LP.CurrentRow.Cells[7].Value.ToString() + " - " + dgv_LP.CurrentRow.Cells[0].Value.ToString() + "'";
            getInvoiceTotal_purch(dgv_LP.CurrentRow.Cells[1].Value.ToString(), dgv_LP.CurrentRow.Cells[7].Value.ToString(), dgv_LP.CurrentRow.Cells[9].Value.ToString(), dgv_LP.CurrentRow.Cells[8].Value.ToString());
            ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_inv_total.Rows[0]["NetValue"].ToString())), currencies[currencyNo]);
            rptInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

            frm.crystalReportViewer1.ReportSource = rptInv;
            frm.ShowDialog();
        }

        private void DGV_b_DoubleClick(object sender, EventArgs e)
        {
            if (Uc_Items.ID.Text == string.Empty ||DGV_b.SelectedRows.Count<1 || DGV_b.CurrentRow.Cells[10].Value.ToString() == null)
            {
                return;
            }
            else { 
                RPT.frm_Item_Transaction frm = new RPT.frm_Item_Transaction();
                frm.UC_Branch.ID.Text = DGV_b.CurrentRow.Cells[10].Value.ToString();
                frm.UC_Items.ID.Text = Uc_Items.ID.Text;
                frm.FromDate_.Text = FromDate.Text;
                frm.ToDate_.Text = ToDate.Text;
                frm.buttonX1.PerformClick();
                frm.ShowDialog();
            }
            
        }

      

        private void dgv_LS_DragDrop(object sender, DragEventArgs e)
        {

        }

        private void btnPrin_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            DataTable dtP = new DataTable();
            DataTable dtS = new DataTable();
            DataTable dtB = new DataTable();
            RPT.rpt_ItemCheck rpt = new RPT.rpt_ItemCheck();
            //  get_balance();

            //  RPT.rpt_inventory_Group_byBranch rpt = new RPT.rpt_inventory_Group_byBranch();
            // RPT.Form1 frm = new RPT.Form1();

            dtB.Columns.Add("branch", typeof(string));
            dtB.Columns.Add("Balance", typeof(decimal));
            dtB.Columns.Add("GIT", typeof(decimal));
            dtB.Columns.Add("Total Balance", typeof(decimal));
            dtB.Columns.Add("Balance weight", typeof(decimal));
            dtB.Columns.Add("Sales", typeof(decimal));
            dtB.Columns.Add("Sales weight", typeof(decimal));
            dtB.Columns.Add("Monthely Sales", typeof(decimal));
            dtB.Columns.Add("Monthely Sales Weight", typeof(decimal));
            dtB.Columns.Add("Balance Period", typeof(decimal));
            //  rpt.SetParameterValue("noOfDays", System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(dTP1.Value, dTP2.Value));

            foreach (DataGridViewRow dgvrow in DGV_b.Rows)
            {
                dtB.Rows.Add(dgvrow.Cells[0].Value, dgvrow.Cells[1].Value,
                dgvrow.Cells[2].Value, dgvrow.Cells[3].Value, dgvrow.Cells[4].Value,
                dgvrow.Cells[5].Value, dgvrow.Cells[6].Value, dgvrow.Cells[7].Value,
                dgvrow.Cells[8].Value, dgvrow.Cells[9].Value);
            }



            dtP.Columns.Add("branch_P", typeof(string));
            dtP.Columns.Add("Inv No", typeof(string));
            dtP.Columns.Add("Date", typeof(DateTime));
            dtP.Columns.Add("Qty", typeof(decimal));
            dtP.Columns.Add("Unit Price", typeof(decimal));
            dtP.Columns.Add("Ton Price", typeof(decimal));
            dtP.Columns.Add("Supplier", typeof(string));

            foreach (DataGridViewRow P_row in dgv_LP.Rows)
            {
                dtP.Rows.Add(P_row.Cells[0].Value, P_row.Cells[1].Value,
                    P_row.Cells[2].Value, P_row.Cells[3].Value, P_row.Cells[4].Value,
                    P_row.Cells[5].Value, P_row.Cells[6].Value);
            }


            ds.Tables.Add(dtB);
            ds.Tables.Add(dtP);
            //      //ds.WriteXmlSchema("reports.xml");
            rpt.DataSource = ds;
            //rpt.SetDataSource(dtP);
            //frm.crystalReportViewer1.ReportSource = rpt;
            rpt.txtfromDate.Text = FromDate.Value.ToString("yyyy/MM/dd");
            rpt.txtToDate.Text = ToDate.Value.ToString("yyyy/MM/dd");
            rpt.txtItemNo.Text = Uc_Items.ID.Text;
            rpt.txtItemDesc.Text = Uc_Items.Desc.Text;
            rpt.txtUnitWeight.Text = txtWeight.Text;
            rpt.txtUnitCost.Text = txtCost.Text;
            rpt.txtUnit.Text = txtUnit.Text;
            rpt.txtUnitPrice.Text = unit_price.Text;
            rpt.txtTonPrice.Text = ton_price.Text;
            rpt.txtBranch.Text = Store.Desc.Text;
            //rpt.DataDefinition.FormulaFields["fromGroup"].Text = "'" + Group.Desc.Text + "'";
            //rpt.DataDefinition.FormulaFields["toGroup"].Text = "'" + Group1.Desc.Text + "'";
            //frm.ShowDialog();
            rpt.ShowPreview();
            Cursor.Current = Cursors.Default;

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void Uc_Branch_Load(object sender, EventArgs e)
        {
            clearFormData();
        }

        private void FromDate_ValueChanged(object sender, EventArgs e)
        {
            clearFormData();
        }

        private void ToDate_ValueChanged(object sender, EventArgs e)
        {
            clearFormData();
        }

        private void uc_SearchItem1_Load(object sender, EventArgs e)
        {

        }

        private void unit_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void ton_price_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX14_Click(object sender, EventArgs e)
        {

        }

        private void Uc_Items_KeyDown_1(object sender, KeyEventArgs e)
        {
            getItemData();
        }


        private void getItemData()
        {
            txtCost.Text = Uc_Items.txtCost.Value.ToString().ToDecimal().ToString();
            txtLong.Text = Uc_Items.txtLenth.Value.ToString().ToDecimal().ToString();
            txtWidth.Text = Uc_Items.txtWidth.Value.ToString().ToDecimal().ToString();
            txtThickness.Text = Uc_Items.txtDepth.Value.ToString().ToDecimal().ToString();
            txtWeight.Text = Uc_Items.itemWeight.Value.ToString().ToDecimal().ToString();
            if (txtWeight.Value > 0)
            {
            txtTonCost.Text = Math.Round(Uc_Items.txtCost.Value.ToString().ToDecimal() / txtWeight.Value * 1000, 0).ToString();
            }
            else
            {
                txtTonCost.Text = "0";
            }
            txtUnit.SelectedValue = Uc_Items.itemUnit.Text;
            txtCost_1.Value = txtCost.Value * (1 + mRrate.Value / 100);
            txtTonCost_1.Value = txtTonCost.Value * (1 + mRrate.Value / 100);
            unit_price.Text = "0";
            ton_price.Text = "0";
        }

        private void Uc_Items_Leave(object sender, EventArgs e)
        {
            getItemData();
        }

        private void DGV_b_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txtThickness_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtWeight_TextChanged(object sender, EventArgs e)
        {

        }

        private void piBox1_Click(object sender, EventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            getData();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void Uc_Branch_Click(object sender, EventArgs e)
        {
            //dgv1.Visible = true;

            //if (Properties.Settings.Default.lungh == "0")
            //{
            //    Store._x = Store.Location.X;
            //       Store._y= Store.Location.Y + Store.Height;

            //}
            //else
            //{
            //    Store._x = Store.Location.X;
            //    Store._y = Store.Location.Y + Store.Height;
            //   // dgv1.Location = new Point(, Uc_Branch.Location.Y + Uc_Branch.Height);

            //}

            ////gv1.Location = new Point(Uc_Branch.Location.X, Uc_Branch.Location.Y + Uc_Branch.Height);
            //dgv1.Height = 150;
            //dgv1.Width = Uc_Branch.Width;




            //    if (Properties.Settings.Default.lungh == "0")
            //    {
            //        if (Program.userID.ToLower() == "administrator")
            //        {
            //            dgv1.DataSource = dal.getDataTabl_1(@"select Branch_code,branch_name from  wh_BRANCHES 
            //            where  t_final like '" + Uc_Branch.txtTfinal.Text + "%' and branch_name like '%" + Uc_Branch.Desc.Text + "%'");
            //            //select Branch_code,branch_name from  wh_BRANCHES where t_final like '" + txtTfinal.Text+"%' and branch_name like '%" + Desc.Text + "'+'%'  ");
            //        }
            //        else
            //        {
            //            dgv1.DataSource = dal.getDataTabl_1(@"select A.Branch_code,A.branch_name from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
            //          where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + Uc_Branch.txtTfinal.Text + "%' and branch_name like '%" + Uc_Branch.Desc.Text + "%'");
            //            //select Branch_code,branch_name from  wh_BRANCHES where t_final like '" + txtTfinal.Text+"%' and branch_name like '%" + Desc.Text + "'+'%'  ");
            //        }

            //    }
            //    else
            //    {
            //        if (Program.userID.ToLower() == "administrator")
            //        {
            //            dgv1.DataSource = dal.getDataTabl_1(@"select Branch_code,WH_E_NAME from  wh_BRANCHES 
            //          where  t_final like '" + Uc_Branch.txtTfinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + Uc_Branch.Desc.Text + "%'");

            //        }
            //        else
            //        {
            //            dgv1.DataSource = dal.getDataTabl_1(@"select A.Branch_code,A.WH_E_NAME from  wh_BRANCHES As A inner join Wh_users_branch As B on A.Branch_code =B.branch_code
            //          where b.User_id = '" + Program.userID.ToString() + "' and t_final like '" + Uc_Branch.txtTfinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + Uc_Branch.Desc.Text + "%'");
            //            //select Branch_code,WH_E_NAME from wh_BRANCHES where t_final like '" + txtTfinal.Text + "%' and isnull(WH_E_NAME,'') like '%" + Desc.Text + "'+'%'  ");
            //        }
            //    }


        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            int ii = dgv1.CurrentCell.RowIndex;

            Store.ID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
            //Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
            //get_desc();

            dgv1.Visible = false;

            //// this.Height = 26;
            //this.SendToBack();
        }

        private void dgv_LS_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void uC_Store1_Load(object sender, EventArgs e)
        {

        }

        private void Uc_Items_Load_1(object sender, EventArgs e)
        {
            unit_price.Clear();
            ton_price.Clear();

        }
    }
}
