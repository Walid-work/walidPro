using CrystalDecisions.Shared;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZXing;
using ZXing.Common;
using ZXing.QrCode;

using System.Drawing.Imaging;
using ImageFormat = System.Drawing.Imaging.ImageFormat;

namespace Report_Pro.RPT
{
    public partial class frm_Print_invoice : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt_inv;
        int currencyNo = 2;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        DataTable dt_inv_total;
        public frm_Print_invoice()
        {
            InitializeComponent();
            txtYear.Value = DateTime.Today.Year;
        }

        private void frm_Print_invoice_Load(object sender, EventArgs e)
        {
            this.currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            this.currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            this.currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            this.currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            this.currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            this.currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            this.currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));
            string currency = Properties.Settings.Default.Currency;
            if (!(currency == "s"))
            {
                if (!(currency == "BH"))
                {
                    if (!(currency == "OM"))
                    {
                        if (!(currency == "DR"))
                            return;
                        this.currencyNo = 1;
                    }
                    else
                        this.currencyNo = 6;
                }
                else
                    this.currencyNo = 5;
            }
            else
                this.currencyNo = 2;


        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            RPT.rpt_print_XPE rpt = new RPT.rpt_print_XPE();
            RPT.Form1 frm = new RPT.Form1();
            DataSet ds = new DataSet();
            get_invoice(txtSer.Text, Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
            ds.Tables.Add(dt_inv);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["decimal_"].Text = "'" + Properties.Settings.Default.digitNo_ + "'";
            rpt.DataDefinition.FormulaFields["Currency_"].Text = "'" + Properties.Settings.Default.Currency + "'";
            //reportInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
            //reportInv.PrintToPrinter(1, false, 0, 15);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }

        private void get_invoice(string ser_, string branch_, string transaction_, string cyear_)
        {
            dt_inv = dal.getDataTabl_1(@"select a.*,b.*,round(b.total_disc*Forign_price*QTY_ADD/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,m.descr,m.Descr_eng,
            C.Currency_Name,ex.Main_Perform_no, ex.Perform_invoice,EX.Perform_invoice_date,br.branch_name,BR.WH_E_NAME
            from wh_inv_data As A inner join wh_material_transaction As B
            on a.Ser_no =b.SER_NO and a.Cyear=b.Cyear and a.Transaction_code=b.TRANSACTION_CODE and a.Branch_code=b.Branch_code
            inner join payer2 As P on a.Acc_no=p.ACC_NO and a.Acc_Branch_code=p.BRANCH_code
            left join (select * from payer2 )as p2 on p2.ACC_NO=a.LC_ACC_NO and a.Acc_Branch_code=p2.BRANCH_code
            inner join wh_main_master as M on M.item_no=b.ITEM_NO
            inner join Wh_Currency as C on C.Currency_Code=b.FORIN_TYPE
            inner join wh_inv_data_Ext as EX on a.Ser_no =EX.SER_NO and a.Cyear=EX.Cyear  and a.Branch_code=EX.Branch_code and Ex.Transaction_code = 'PEX'
            inner join wh_BRANCHES As BR on BR.Branch_code=a.Branch_code
            where a.SER_NO = '" + ser_ + "' and a.Transaction_code = '" + transaction_ + "' and a.Branch_code = '" + branch_ + "' and a.Cyear = '" + cyear_ + "'");
        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)

        {
            FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
            if (folderBrowserDialog.ShowDialog() != DialogResult.OK)
                return;
            string selectedPath = folderBrowserDialog.SelectedPath;
            int num1;
            for (int int32 = Convert.ToInt32(this.txtSer.Text); int32 <= Convert.ToInt32(txtSer_1.Text); ++int32)
            {
                if (this.Transaction.ID.Text == "xpc")
                {
                    print_PurchaseInv printPurchaseInv = new print_PurchaseInv();
                    Form1 form1 = new Form1();
                    DataSet dataSet = new DataSet();
                    string ser_1 = int32.ToString();
                    string text1 = this.Branch.ID.Text;
                    string text2 = this.Transaction.ID.Text;
                    num1 = txtYear.Value - 2000;
                    string cyear_1 = num1.ToString();
                    this.getSalesInv(ser_1, text1, text2, cyear_1);
                    dataSet.Tables.Add(this.dt_inv);
                    //dataSet.WriteXmlSchema("schema_rpt.xml");
                    printPurchaseInv.SetDataSource(dataSet);
                    printPurchaseInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + this.Branch.ID.Text + " - " + this.Branch.Desc.Text + "'";
                    string ser_2 = int32.ToString();
                    string text3 = Branch.ID.Text;
                    string text4 = Transaction.ID.Text;
                    num1 = txtYear.Value - 2000;
                    string cyear_2 = num1.ToString();
                    this.getInvoiceTotal(ser_2, text3, text4, cyear_2);
                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(this.dt_inv_total.Rows[0]["NetValuePurch"].ToString())), this.currencies[this.currencyNo]);
                    printPurchaseInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
                    string str = int32.ToString();
                    printPurchaseInv.ExportToDisk(ExportFormatType.PortableDocFormat, folderBrowserDialog.SelectedPath + "\\" + str + ".pdf");
                    printPurchaseInv.Close();
                    printPurchaseInv.Dispose();
                }
                else
                {
                    Rpt_inv rptInv = new Rpt_inv();
                    Form1 form1 = new Form1();
                    DataSet dataSet = new DataSet();
                    string ser_1 = int32.ToString();
                    string text1 = Branch.ID.Text;
                    string text2 = Transaction.ID.Text;
                    num1 = txtYear.Value - 2000;
                    string cyear_1 = num1.ToString();
                    this.getSalesInv(ser_1, text1, text2, cyear_1);
                    dataSet.Tables.Add(dt_inv);
                    //dataSet.WriteXmlSchema("schema_rpt.xml");
                    rptInv.SetDataSource(dataSet);
                    rptInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + this.Branch.ID.Text + " - " + this.Branch.Desc.Text + "'";
                    string ser_2 = int32.ToString();
                    string text3 = this.Branch.ID.Text;
                    string text4 = this.Transaction.ID.Text;
                    num1 = this.txtYear.Value - 2000;
                    string cyear_2 = num1.ToString();
                    this.getInvoiceTotal(ser_2, text3, text4, cyear_2);
                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(this.dt_inv_total.Rows[0]["NetValue"].ToString())), this.currencies[this.currencyNo]);
                    rptInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
                    string str = int32.ToString();
                    rptInv.ExportToDisk(ExportFormatType.PortableDocFormat, folderBrowserDialog.SelectedPath + "\\" + str + ".pdf");
                   // rptInv.ExportToDisk(ExportFormatType.PortableDocFormat, folderBrowserDialog.SelectedPath + "\\" + str + ".pdf");
                    rptInv.Close();
                    rptInv.Dispose();
                }
            }
            int num2 = (int)MessageBox.Show("Invoices was Exprted ", "", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void buttonX2_Click(object sender, EventArgs e)

        {
            DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp ");


           

            for (int int32 = Convert.ToInt32(this.txtSer.Text); int32 <= Convert.ToInt32(txtSer_1.Text); ++int32)
            {



                if (Transaction.ID.Text == "xpc" )
                {
                    print_PurchaseInv printPurchaseInv = new print_PurchaseInv();
                    DataSet dataSet = new DataSet();
                    getSalesInv(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
                    getInvoiceTotal(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());

                    string vat_no = dt_Co.Rows[0]["Comp_Vat_no"].ToString();
                    string Co_Name = dt_Co.Rows[0]["Company_e_name"].ToString();
                    string invDate = dt_inv.Rows[0]["G_date"].ToString();
                    string TotalInv = dt_inv_total.Rows[0]["NetValue"].ToString().ToDecimal().ToString("N2");
                    string TotalTax = dt_inv_total.Rows[0]["tax"].ToString();


                    PictureBox pic_ = new PictureBox();
                    dal.pic1 = pic_;
                    dal.GetImsge(Co_Name, vat_no, invDate, TotalInv, TotalTax);

                    DataTable dQR = new DataTable();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pic_.Image.Save(ms, ImageFormat.Bmp);

                        byte[] byteImage = ms.ToArray();
                        dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
                        dQR.Rows.Add(byteImage);
                    }



                    dataSet.Tables.Add(dt_inv);
                    dataSet.Tables.Add(dQR); //dataSet.WriteXmlSchema("schema_rpt.xml");
                    printPurchaseInv.SetDataSource(dataSet);
                    printPurchaseInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + Branch.ID.Text + " - " + Branch.Desc.Text + "'";
                    getInvoiceTotal(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_inv_total.Rows[0]["NetValuePurch"].ToString())), currencies[currencyNo]);
                    printPurchaseInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
                    printPurchaseInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
                    printPurchaseInv.PrintToPrinter(1, false, 0, 0);
                    printPurchaseInv.Close();
                    printPurchaseInv.Dispose();


                }
              else if (Transaction.ID.Text == "xpr" || Transaction.ID.Text == "xpt")
                {
                    print_Purchase_Return printPurchaseInv = new print_Purchase_Return();
                    DataSet dataSet = new DataSet();
                    getSalesInv(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
                    getInvoiceTotal(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());

                    string vat_no = dt_Co.Rows[0]["Comp_Vat_no"].ToString();
                    string Co_Name = dt_Co.Rows[0]["Company_e_name"].ToString();
                    string invDate = dt_inv.Rows[0]["G_date"].ToString();
                    string TotalInv = dt_inv_total.Rows[0]["NetValue"].ToString().ToDecimal().ToString("N2");
                    string TotalTax = dt_inv_total.Rows[0]["tax"].ToString();


                    PictureBox pic_ = new PictureBox();
                    dal.pic1 = pic_;
                    dal.GetImsge(Co_Name, vat_no, invDate, TotalInv, TotalTax);

                    DataTable dQR = new DataTable();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pic_.Image.Save(ms, ImageFormat.Bmp);

                        byte[] byteImage = ms.ToArray();
                        dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
                        dQR.Rows.Add(byteImage);
                    }



                    dataSet.Tables.Add(dt_inv);
                    dataSet.Tables.Add(dQR); //dataSet.WriteXmlSchema("schema_rpt.xml");
                    printPurchaseInv.SetDataSource(dataSet);
                    printPurchaseInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + Branch.ID.Text + " - " + Branch.Desc.Text + "'";
                    getInvoiceTotal(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_inv_total.Rows[0]["NetValuePurch"].ToString())), currencies[currencyNo]);
                    printPurchaseInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";
                    printPurchaseInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
                    printPurchaseInv.PrintToPrinter(1, false, 0, 0);
                    printPurchaseInv.Close();
                    printPurchaseInv.Dispose();


                }



                else
                {
                    //print_PurchaseInv rptInv = new print_PurchaseInv();
                    RPT.Form1 frm = new RPT.Form1();
                    Rpt_inv rptInv = new Rpt_inv();
                    DataSet dataSet = new DataSet();
                    getSalesInv(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
                    getInvoiceTotal(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());

                    string vat_no = dt_Co.Rows[0]["Comp_Vat_no"].ToString();
                    string Co_Name = dt_Co.Rows[0]["Company_e_name"].ToString();
                    string invDate = dt_inv.Rows[0]["G_date"].ToString();
                    string TotalInv = dt_inv_total.Rows[0]["NetValue"].ToString().ToDecimal().ToString("N2");
                    string TotalTax = dt_inv_total.Rows[0]["tax"].ToString();


                    PictureBox pic_ = new PictureBox();
                    dal.pic1 = pic_;
                    dal.GetImsge(Co_Name, vat_no, invDate, TotalInv, TotalTax);

                    DataTable dQR = new DataTable();
                    using (MemoryStream ms = new MemoryStream())
                    {
                        pic_.Image.Save(ms, ImageFormat.Bmp);

                        byte[] byteImage = ms.ToArray();
                        dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
                        dQR.Rows.Add(byteImage);
                    }



                    dataSet.Tables.Add(dt_inv);
                    dataSet.Tables.Add(dQR);
                    //dataSet.WriteXmlSchema("schema_rpt.xml");
                    rptInv.SetDataSource(dataSet);
                    rptInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + Branch.ID.Text + " - " + Branch.Desc.Text + "'";
                    getInvoiceTotal(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
                    ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_inv_total.Rows[0]["NetValue"].ToString())), currencies[currencyNo]);
                    rptInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

                    frm.crystalReportViewer1.ReportSource = rptInv;
                    frm.ShowDialog();
                    //rptInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;

                    //rptInv.PrintToPrinter(1, false, 0, 0);
                    //rptInv.Close();
                    //rptInv.Dispose();
                }
            }
        }


        private void getSalesInv(string ser_, string branch_, string transaction_, string cyear_)

        { dt_inv = this.dal.getDataTabl_1(@"select A.ser_no,A.Branch_code,A.Cyear,A.Transaction_code,A.G_date,A.Acc_no,A.Payment_Type,A.Sales_man_Id,A.Inv_no,A.Inv_date,a.Inv_Notes,A.Phone,A.Adress,
                 B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.Unit,B.Local_Price,isnull(B.TAX_IN,0)as TAX_IN ,isnull(B.TAX_OUT,0)as TAX_OUT , round(b.total_disc*B.local_price*QTY_TAKE/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,
                 m.descr,m.Descr_eng, br.branch_name,BR.WH_E_NAME,PT.Payment_name 
	  ,(select case when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) between '2018-01-01' and '2020-06-30'   then 5  when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) > '2020-06-30' then 15  else 0 end)as VatRatio
       
        from wh_inv_data As A 
        inner join wh_material_transaction As B on a.Ser_no = b.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code 
        inner join payer2 As P on a.Acc_no = p.ACC_NO and a.Acc_Branch_code = p.BRANCH_code 
        left join(select* from payer2)as p2 on p2.ACC_NO = a.LC_ACC_NO and a.Acc_Branch_code = p2.BRANCH_code 
        inner join wh_main_master as M on M.item_no = b.ITEM_NO 
        inner join wh_BRANCHES As BR on BR.Branch_code = a.Branch_code 
        inner join wh_Payment_type as PT on A.Payment_Type=PT.Payment_type 
                 where a.SER_NO = '" + ser_ + "' and a.Transaction_code = '" + transaction_ + "' and a.Branch_code = '" + branch_ + "' and a.Cyear = '" + cyear_ + "'"); }
        //{ dt_inv = this.dal.getDataTabl_1("select a.*, b.*, round(b.total_disc*B.local_price*QTY_TAKE/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,m.descr,m.Descr_eng,\r\n             br.branch_name,BR.WH_E_NAME,PT.Payment_name\r\n            from wh_inv_data As A inner join wh_material_transaction As B\r\n            on a.Ser_no = b.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code\r\n            inner join payer2 As P on a.Acc_no = p.ACC_NO and a.Acc_Branch_code = p.BRANCH_code\r\n            left join(select* from payer2)as p2 on p2.ACC_NO = a.LC_ACC_NO and a.Acc_Branch_code = p2.BRANCH_code\r\n            inner join wh_main_master as M on M.item_no = b.ITEM_NO\r\n            inner join wh_BRANCHES As BR on BR.Branch_code = a.Branch_code\r\n            inner join wh_Payment_type as PT on A.Payment_Type=PT.Payment_type\r\n           where a.SER_NO = '" + ser_ + "' and a.Transaction_code = '" + transaction_ + "' and a.Branch_code = '" + branch_ + "' and a.Cyear = '" + cyear_ + "'"); }

    private void getDelevry(string ser_)
        {
            this.dt_inv = this.dal.getDataTabl_1("select a.*, b.*, round(b.total_disc*B.local_price*QTY_TAKE/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,m.descr,m.Descr_eng,\r\n             br.branch_name,BR.WH_E_NAME,PT.Payment_name\r\n            from production.dbo.wh_inv_data As A inner join production.dbo.wh_material_transaction As B\r\n            on a.Ser_no = b.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code\r\n            inner join production.dbo.payer2 As P on a.Acc_no = p.ACC_NO and a.Acc_Branch_code = p.BRANCH_code\r\n            left join(select* from production.dbo.payer2)as p2 on p2.ACC_NO = a.LC_ACC_NO and a.Acc_Branch_code = p2.BRANCH_code\r\n            inner join production.dbo.wh_main_master as M on M.item_no = b.ITEM_NO\r\n            inner join production.dbo.wh_BRANCHES As BR on BR.Branch_code = a.Branch_code\r\n            inner join production.dbo.wh_Payment_type as PT on A.Payment_Type=PT.Payment_type\r\n           where a.SER_NO = '" + ser_ + "' and a.Transaction_code = 'XSD' and a.Branch_code = 'A1113' and a.Cyear = '20'");
        }

        private void getInvoiceTotal(string ser_, string branch_, string transaction_, string cyear_)
        {
            dt_inv_total = dal.getDataTabl_1(@"select round(sum(b.QTY_TAKE*Local_Price),2) as TotalValue
            , round(sum(b.total_disc * B.local_price * QTY_TAKE / 100), 2) as discount
            , round(sum(isnull(b.TAX_OUT, 0)), 2) as tax
            , round(sum(b.QTY_TAKE * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_TAKE / 100), 2) + round(sum(isnull(b.TAX_OUT, 0)), 2) as NetValue
            , round(sum(b.QTY_ADD * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_ADD / 100), 2) + round(sum(isnull(b.TAX_IN, 0)), 2) as NetValuePurch 
            from wh_material_transaction as b
            where b.SER_NO = '" + ser_ + "'  and b.Transaction_code = '" + transaction_ + "' and b.Branch_code = '" + branch_ + "' and b.Cyear = '" + cyear_ + "'  " +
            "group by TRANSACTION_CODE,Branch_code,Cyear,SER_NO");
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
                      Rpt_inv rptInv = new Rpt_inv();
            RPT.Form1 frm = new RPT.Form1();
            DataSet dataSet = new DataSet();

            DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp ");

            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.Ser_no,A.Branch_code,A.cyear,A.Transaction_code,A.G_date as s_Date
                ,A.Acc_no,A.Payment_Type,A.Sales_man_Id,A.Inv_no,A.Inv_date,A.Inv_Notes
                ,A.Phone,A.Adress,c.ITEM_NO,c.QTY_ADD,C.QTY_TAKE,M.Unit,c.Local_Price
                ,c.TAX_IN,C.TAX_OUT, round(C.total_disc*C.local_price*QTY_TAKE/100,2) as disc_
                ,PAYER_NAME,payer_l_name,M.descr,M.Descr_eng,br.branch_name,BR.WH_E_NAME
                ,PT.Payment_name,Expited_Deleviry_date,Deleviry_date as G_date
                ,round((C.QTY_TAKE*local_price),2) -round(C.total_disc*C.local_price*QTY_TAKE/100,2) as NetValue
                ,round((C.QTY_TAKE*local_price),2) -round(C.total_disc*C.local_price*QTY_TAKE/100,2)+C.TAX_OUT as totalNetValue
				
                FROM wh_inv_data_MAINT as A
                inner join payer2 as B on A.Acc_no=B.ACC_NO and a.Branch_code=b.BRANCH_code
                inner join wh_MATERIAL_TRANSACTION_MAINT as C
                on A.Ser_no=c.SER_NO and a.Transaction_code=c.TRANSACTION_CODE and a.Branch_code=c.Branch_code and A.Cyear=C.Cyear
                inner join wh_main_master As M on C.ITEM_NO=M.item_no
                inner join wh_BRANCHES As BR on BR.Branch_code = a.Branch_code 
                inner join wh_Payment_type as PT on A.Payment_Type=PT.Payment_type 
                where A.SER_NO='" + txtSer.Text + "'and C.item_No ='ser' ");

          //  getInvoiceTotal(txtSer.Text, "A2319", "XSH", (txtYear.Value - 2000).ToString());

            string vat_no = dt_Co.Rows[0]["Comp_Vat_no"].ToString();
            string Co_Name = dt_Co.Rows[0]["Company_e_name"].ToString();
            string invDate =  Convert.ToDateTime (dt_.Rows[0]["G_date"].ToString()).ToString("yyyy/MM/dd HH:mm:ss");
            string TotalInv = dt_.Rows[0]["NetValue"].ToString().ToDecimal().ToString("0.00");
            string TotalTax = dt_.Rows[0]["TAX_OUT"].ToString().ToDecimal().ToString("0.00");


            PictureBox pic_ = new PictureBox();
            dal.pic1 = pic_;
            dal.GetImsge(Co_Name, vat_no, invDate, TotalInv, TotalTax);

            DataTable dQR = new DataTable();
            using (MemoryStream ms = new MemoryStream())
            {
                pic_.Image.Save(ms, ImageFormat.Bmp);

                byte[] byteImage = ms.ToArray();
                dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
                dQR.Rows.Add(byteImage);
            }

            // getSalesInv(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
            dataSet.Tables.Add(dt_);
            dataSet.Tables.Add(dQR);
            //dataSet.WriteXmlSchema("schema_rpt.xml");
            rptInv.SetDataSource(dataSet);
            rptInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + Branch.ID.Text + " - " + Branch.Desc.Text + "'";
            //getInvoiceTotal(int32.ToString(), Branch.ID.Text, Transaction.ID.Text, (txtYear.Value - 2000).ToString());
            ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_.Rows[0]["totalNetValue"].ToString())), currencies[currencyNo]);
            rptInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

            rptInv.DataDefinition.FormulaFields["invKind&No"].Text = "'أمر شغل رقم - " + txtSer.Text + "'";

            frm.crystalReportViewer1.ReportSource = rptInv;
            frm.ShowDialog();


            //rptInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;
            //rptInv.PrintToPrinter(1, false, 0, 0);
            //rptInv.Close();
            //rptInv.Dispose();




        }
    }
}
