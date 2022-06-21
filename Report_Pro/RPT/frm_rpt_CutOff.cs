using DevExpress.XtraEditors;
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
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Report_Pro.RPT
{
    public partial class frm_rpt_CutOff : XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        int currencyNo = 2;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();

        Microsoft.Office.Interop.Excel.Application XcelApp = new Microsoft.Office.Interop.Excel.Application();


        DataTable dt_inv;
        DataTable dt_inv_total;

        public frm_rpt_CutOff()
        {
            InitializeComponent();

            txtDate.Value = new DateTime(DateTime.Now.Year, 1, 1);

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void uC_Years1_Load(object sender, EventArgs e)
        {

        }

        private void btn_Early_Sales_Click(object sender, EventArgs e)
        {
          


        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {

            string inv_no = dgv1.CurrentRow.Cells[2].Value.ToString();
            string brnch_code = dgv1.CurrentRow.Cells[8].Value.ToString();
            string trans_code = dgv1.CurrentRow.Cells[10].Value.ToString();
            string cyear = dgv1.CurrentRow.Cells[9].Value.ToString();
            RPT.Form1 frm = new RPT.Form1();
            DataSet dataSet = new DataSet();
            getSalesInv(inv_no, brnch_code, trans_code, cyear);
            getInvoiceTotal(inv_no, brnch_code, trans_code, cyear);

            string code = "Alusaimi Steel " + System.Environment.NewLine + "Invoice No. :" + dgv1.CurrentRow.Cells[1].Value.ToString() + System.Environment.NewLine + "Branch Code :" + dgv1.CurrentRow.Cells[7].Value.ToString() + System.Environment.NewLine + "Total Value :" + dt_inv_total.Rows[0]["NetValue"] + System.Environment.NewLine + "VAT Value :" + dt_inv_total.Rows[0]["tax"];


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


            if (trans_code == "XSD" || trans_code == "XSC")
            {
                RPT.Rpt_inv rptInv = new RPT.Rpt_inv();
                //RPT.print_PurchaseInv rptInv = new RPT.print_PurchaseInv();
                rptInv.SetDataSource(dataSet);
                rptInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + dgv1.CurrentRow.Cells[7].Value.ToString() + " - " + dgv1.CurrentRow.Cells[0].Value.ToString() + "'";
                ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_inv_total.Rows[0]["NetValue"].ToString())), currencies[currencyNo]);
                rptInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";


                frm.crystalReportViewer1.ReportSource = rptInv;
            }
            else
            {
               // RPT.Rpt_inv rptInv = new RPT.Rpt_inv();
                RPT.print_PurchaseInv rptInv = new RPT.print_PurchaseInv();
                rptInv.SetDataSource(dataSet);
                rptInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + dgv1.CurrentRow.Cells[7].Value.ToString() + " - " + dgv1.CurrentRow.Cells[0].Value.ToString() + "'";
                ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_inv_total.Rows[0]["NetValue"].ToString())), currencies[currencyNo]);
                rptInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";


                frm.crystalReportViewer1.ReportSource = rptInv;
            }

                frm.ShowDialog();
            
            //rptInv.PrintOptions.PrinterName = Properties.Settings.Default.Invoice_P;

            //rptInv.PrintToPrinter(1, false, 0, 0);
            //rptInv.Close();
            //rptInv.Dispose();
        }




        private void getSalesInv(string ser_, string branch_, string transaction_, string cyear_)

        {
            dt_inv = this.dal.getDataTabl_1(@"select A.ser_no,A.Branch_code,A.Cyear,A.Transaction_code,A.G_date,A.Acc_no,A.Payment_Type,A.Sales_man_Id,A.Inv_no,A.Inv_date,a.Inv_Notes,A.Phone,A.Adress,
            B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.Unit,B.Local_Price,isnull(B.TAX_IN,0)as TAX_IN ,isnull(B.TAX_OUT,0)as TAX_OUT , round(b.total_disc*B.local_price*QTY_TAKE/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,
            m.descr,m.Descr_eng, br.branch_name,BR.WH_E_NAME,PT.Payment_name 
            ,(select top 1 vat_ratio from VAT_RATIO_MASTER where cast(A.G_date as date ) between date_of_vat and '" + DateTime.Today.ToString("yyyy-MM-dd") + "' order by date_of_vat desc) as VatRatio " +
            "from GroupDB.dbo.wh_inv_data As A " +
            "inner join GroupDB.dbo.wh_material_transaction As B on a.Ser_no = b.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code  " +
            "inner join GroupDB.dbo.payer2 As P on a.Acc_no = p.ACC_NO and a.Acc_Branch_code = p.BRANCH_code  " +
            "left join(select* from payer2)as p2 on p2.ACC_NO = a.LC_ACC_NO and a.Acc_Branch_code = p2.BRANCH_code  " +
            "inner join GroupDB.dbo.wh_main_master as M on M.item_no = b.ITEM_NO  " +
            "inner join GroupDB.dbo.wh_BRANCHES As BR on BR.Branch_code = a.Branch_code  " +
            "inner join GroupDB.dbo.wh_Payment_type as PT on A.Payment_Type=PT.Payment_type  " +
            "where a.SER_NO = '" + ser_ + "' and a.Transaction_code = '" + transaction_ + "' and a.Branch_code = '" + branch_ + "' and a.Cyear = '" + cyear_ + "'");
        }
        //(select case when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) between '2018-01-01' and '2020-06-30'   then 5  when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) > '2020-06-30' then 15  else 0 end)as VatRatio

        private void getInvoiceTotal(string ser_, string branch_, string transaction_, string cyear_)
        {
            dt_inv_total = dal.getDataTabl_1(@"select round(sum(b.QTY_TAKE*Local_Price),2) as TotalValue
            , round(sum(b.total_disc * B.local_price * QTY_TAKE / 100), 2) as discount
            , round(sum(isnull(b.TAX_OUT, 0)), 2) as tax
            , round(sum(b.QTY_TAKE * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_TAKE / 100), 2) + round(sum(isnull(b.TAX_OUT, 0)), 2) as NetValue
            , round(sum(b.QTY_ADD * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_ADD / 100), 2) + round(sum(isnull(b.TAX_IN, 0)), 2) as NetValuePurch 
            from GroupDB.dbo.wh_material_transaction as b
            where b.SER_NO = '" + ser_ + "'  and b.Transaction_code = '" + transaction_ + "' and b.Branch_code = '" + branch_ + "' and b.Cyear = '" + cyear_ + "'  " +
            "group by TRANSACTION_CODE,Branch_code,Cyear,SER_NO");
        }

        private void frm_rpt_CutOff_Load(object sender, EventArgs e)
        {
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

        private void btn_Late_Sales_Click(object sender, EventArgs e)
        {
            
        }

        private void btn_exportToExcel_Click(object sender, EventArgs e)
        {
                   }

        private void btn_Late_Purchase_Click(object sender, EventArgs e)
        {
         

        }

        private void btn_Early_Purchase_Click(object sender, EventArgs e)
        {
           
        }

        private void btn_exportToExcel_Click_1(object sender, EventArgs e)
        {
            Microsoft.Office.Interop.Excel.Application exlApp = new Microsoft.Office.Interop.Excel.Application();
            exlApp.Application.Workbooks.Add(Type.Missing);
            for (int i = 0; i < dgv1.ColumnCount; i++)
            {
                exlApp.Cells[1, i + 1] = dgv1.Columns[i].HeaderText.ToString();
            }

            for (int i = 0; i < dgv1.RowCount; i++)
            {

                for (int j = 0; j < dgv1.ColumnCount; j++)
                {
                    exlApp.Cells[i + 2, j + 1] = dgv1.Rows[i].Cells[j].Value;
                }
            }
            exlApp.Columns.AutoFit();
            exlApp.Visible = true;
        }

        private void btn_Early_Purchase_Click_1(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"select X.* from (SELECT 
            ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE Asc) AS ser
            ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_ADD-D.QTY_TAKE) As Qty_Add
            , ROUND(sum((D.QTY_ADD-D.QTY_TAKE) * D.Local_Price) - sum(((D.QTY_ADD-D.QTY_TAKE) * D.Local_Price * D.total_disc) / 100), 2) AS Value
            , sum(D.TAX_IN-D.TAX_OUT) As Vat, A.Transaction_code,
            A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no,D.Cyear,A.Inv_no
		

            FROM    GroupDB.dbo.wh_inv_data as A
            INNER JOIN GroupDB.dbo.payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            INNER JOIN GroupDB.dbo.wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            INNER JOIN GroupDB.dbo.wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            INNER JOIN GroupDB.dbo.wh_material_transaction As D ON A.Ser_no = D.SER_NO
            AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
            inner join GroupDB.dbo.WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
            inner join GroupDB.dbo.wh_main_master As S  on D.ITEM_NO = s.item_no

            where D.TRANSACTION_CODE like 'xp%' and D.TRANSACTION_CODE <> 'xpr' and D.TRANSACTION_CODE <> 'xpt'
			and cast(D.G_DATE as date) >='" + txtDate.Value.ToString("yyyy-MM-dd") + "' group by   A.Ser_no, B.branch_name, A.G_date, p.PAYER_NAME, A.Transaction_code, A.Branch_code, " +
          "A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no, D.Cyear,A.Inv_no) as X  where ser <= 5 order by Branch_code ");


            int B_rowscount = dt_.Rows.Count;
            dgv1.Rows.Clear();
            dgv1.Rows.Add(B_rowscount);
            for (int i = 0; (i
                       <= (B_rowscount - 1)); i++)
            {

                dgv1.Rows[i].Cells[0].Value = dt_.Rows[i]["Ser"];
                dgv1.Rows[i].Cells[1].Value = dt_.Rows[i]["branch_name"];
                dgv1.Rows[i].Cells[2].Value = dt_.Rows[i]["Ser_no"];
                dgv1.Rows[i].Cells[3].Value = dt_.Rows[i]["INV_NAME"];
                dgv1.Rows[i].Cells[4].Value = dt_.Rows[i]["G_date"];
                dgv1.Rows[i].Cells[5].Value = dt_.Rows[i]["Qty_Add"];
                dgv1.Rows[i].Cells[6].Value = dt_.Rows[i]["Vat"];
                dgv1.Rows[i].Cells[7].Value = dt_.Rows[i]["Value"];
                dgv1.Rows[i].Cells[8].Value = dt_.Rows[i]["Branch_code"];
                dgv1.Rows[i].Cells[9].Value = dt_.Rows[i]["Cyear"];
                dgv1.Rows[i].Cells[10].Value = dt_.Rows[i]["Transaction_code"];
                dgv1.Rows[i].Cells[11].Value = dt_.Rows[i]["Acc_no"];
                dgv1.Rows[i].Cells[12].Value = dt_.Rows[i]["PAYER_NAME"];
                dgv1.Rows[i].Cells[13].Value = dt_.Rows[i]["Inv_no"];
                dgv1.Rows[i].Cells[14].Value = dt_.Rows[i]["acc_serial_no"];
            }

        }

        private void btn_Late_Purchase_Click_1(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"select X.* from (SELECT 
            ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE desc) AS ser
            ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_ADD-D.QTY_TAKE) As Qty_Add
            , ROUND(sum((D.QTY_ADD-D.QTY_TAKE) * D.Local_Price) - sum(((D.QTY_ADD-D.QTY_TAKE) * D.Local_Price * D.total_disc) / 100), 2) AS Value
            , sum(D.TAX_IN-D.TAX_OUT) As Vat, A.Transaction_code,
            A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no,D.Cyear,A.Inv_no
		

            FROM    GroupDB.dbo.wh_inv_data as A
            INNER JOIN GroupDB.dbo.payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            INNER JOIN GroupDB.dbo.wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            INNER JOIN GroupDB.dbo.wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            INNER JOIN GroupDB.dbo.wh_material_transaction As D ON A.Ser_no = D.SER_NO
            AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
            inner join GroupDB.dbo.WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
            inner join GroupDB.dbo.wh_main_master As S  on D.ITEM_NO = s.item_no

            where D.TRANSACTION_CODE like 'xp%' and D.TRANSACTION_CODE <> 'xpr' and D.TRANSACTION_CODE <> 'xpt'
			and cast(D.G_DATE as date) <'" + txtDate.Value.ToString("yyyy-MM-dd") +
        "' group by   A.Ser_no, B.branch_name, A.G_date, p.PAYER_NAME, A.Transaction_code, A.Branch_code, " +
        "A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no, D.Cyear,A.Inv_no) as X  where ser <= 5 order by Branch_code ");


            int B_rowscount = dt_.Rows.Count;
            dgv1.Rows.Clear();
            dgv1.Rows.Add(B_rowscount);
            for (int i = 0; (i
                       <= (B_rowscount - 1)); i++)
            {


                dgv1.Rows[i].Cells[0].Value = dt_.Rows[i]["Ser"];
                dgv1.Rows[i].Cells[1].Value = dt_.Rows[i]["branch_name"];
                dgv1.Rows[i].Cells[2].Value = dt_.Rows[i]["Ser_no"];
                dgv1.Rows[i].Cells[3].Value = dt_.Rows[i]["INV_NAME"];
                dgv1.Rows[i].Cells[4].Value = dt_.Rows[i]["G_date"];
                dgv1.Rows[i].Cells[5].Value = dt_.Rows[i]["Qty_Add"];
                dgv1.Rows[i].Cells[6].Value = dt_.Rows[i]["Vat"];
                dgv1.Rows[i].Cells[7].Value = dt_.Rows[i]["Value"];
                dgv1.Rows[i].Cells[8].Value = dt_.Rows[i]["Branch_code"];
                dgv1.Rows[i].Cells[9].Value = dt_.Rows[i]["Cyear"];
                dgv1.Rows[i].Cells[10].Value = dt_.Rows[i]["Transaction_code"];
                dgv1.Rows[i].Cells[11].Value = dt_.Rows[i]["Acc_no"];
                dgv1.Rows[i].Cells[12].Value = dt_.Rows[i]["PAYER_NAME"];
                dgv1.Rows[i].Cells[13].Value = dt_.Rows[i]["Inv_no"];
                dgv1.Rows[i].Cells[14].Value = dt_.Rows[i]["acc_serial_no"];
            }

        }

        private void btn_Early_Sales_Click_1(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"select X.* from (SELECT 
            ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE Asc) AS ser
            ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
            , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
            , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Transaction_code,
            A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no,D.Cyear,A.Inv_no
		

            FROM    GroupDB.dbo.wh_inv_data as A
            INNER JOIN GroupDB.dbo.payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            INNER JOIN GroupDB.dbo.wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            INNER JOIN GroupDB.dbo.wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            INNER JOIN GroupDB.dbo.wh_material_transaction As D ON A.Ser_no = D.SER_NO
            AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
            inner join GroupDB.dbo.WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
            inner join GroupDB.dbo.wh_main_master As S  on D.ITEM_NO = s.item_no

            where D.TRANSACTION_CODE like 'xs%' and D.TRANSACTION_CODE <> 'xsr' and D.TRANSACTION_CODE <> 'xst'
			and cast(D.G_DATE as date) >='" + txtDate.Value.ToString("yyyy-MM-dd") + "' group by   A.Ser_no, B.branch_name, A.G_date, p.PAYER_NAME, A.Transaction_code, A.Branch_code, " +
          "A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no, D.Cyear,A.Inv_no) as X  where ser <= 5 order by Branch_code");


            int B_rowscount = dt_.Rows.Count;
            dgv1.Rows.Clear();
            dgv1.Rows.Add(B_rowscount);
            for (int i = 0; (i
                       <= (B_rowscount - 1)); i++)
            {

                dgv1.Rows[i].Cells[0].Value = dt_.Rows[i]["Ser"];
                dgv1.Rows[i].Cells[1].Value = dt_.Rows[i]["branch_name"];
                dgv1.Rows[i].Cells[2].Value = dt_.Rows[i]["Ser_no"];
                dgv1.Rows[i].Cells[3].Value = dt_.Rows[i]["INV_NAME"];
                dgv1.Rows[i].Cells[4].Value = dt_.Rows[i]["G_date"];
                dgv1.Rows[i].Cells[5].Value = dt_.Rows[i]["Qty_Add"];
                dgv1.Rows[i].Cells[6].Value = dt_.Rows[i]["Vat"];
                dgv1.Rows[i].Cells[7].Value = dt_.Rows[i]["Value"];
                dgv1.Rows[i].Cells[8].Value = dt_.Rows[i]["Branch_code"];
                dgv1.Rows[i].Cells[9].Value = dt_.Rows[i]["Cyear"];
                dgv1.Rows[i].Cells[10].Value = dt_.Rows[i]["Transaction_code"];
                dgv1.Rows[i].Cells[11].Value = dt_.Rows[i]["Acc_no"];
                dgv1.Rows[i].Cells[12].Value = dt_.Rows[i]["PAYER_NAME"];
                dgv1.Rows[i].Cells[13].Value = dt_.Rows[i]["Inv_no"];
                dgv1.Rows[i].Cells[14].Value = dt_.Rows[i]["acc_serial_no"];
            }

        }

        private void btn_Late_Sales_Click_1(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"select X.* from (SELECT 
            ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE desc) AS ser
            ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
            , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
            , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Transaction_code,
            A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no,D.Cyear,A.Inv_no
		

            FROM    GroupDB.dbo.wh_inv_data as A
            INNER JOIN GroupDB.dbo.payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            INNER JOIN GroupDB.dbo.wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            INNER JOIN GroupDB.dbo.wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            INNER JOIN GroupDB.dbo.wh_material_transaction As D ON A.Ser_no = D.SER_NO
            AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
            inner join GroupDB.dbo.WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
            inner join GroupDB.dbo.wh_main_master As S  on D.ITEM_NO = s.item_no

            where D.TRANSACTION_CODE like 'xs%' and D.TRANSACTION_CODE <> 'xsr' and D.TRANSACTION_CODE <> 'xst'
			and cast(D.G_DATE as date) <'" + txtDate.Value.ToString("yyyy-MM-dd") +
            "' group by   A.Ser_no, B.branch_name, A.G_date, p.PAYER_NAME, A.Transaction_code, A.Branch_code, " +
            "A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no, D.Cyear,A.Inv_no) as X  where ser <= 5 order by Branch_code");


            int B_rowscount = dt_.Rows.Count;
            dgv1.Rows.Clear();
            dgv1.Rows.Add(B_rowscount);
            for (int i = 0; (i
                       <= (B_rowscount - 1)); i++)
            {


                dgv1.Rows[i].Cells[0].Value = dt_.Rows[i]["Ser"];
                dgv1.Rows[i].Cells[1].Value = dt_.Rows[i]["branch_name"];
                dgv1.Rows[i].Cells[2].Value = dt_.Rows[i]["Ser_no"];
                dgv1.Rows[i].Cells[3].Value = dt_.Rows[i]["INV_NAME"];
                dgv1.Rows[i].Cells[4].Value = dt_.Rows[i]["G_date"];
                dgv1.Rows[i].Cells[5].Value = dt_.Rows[i]["Qty_Add"];
                dgv1.Rows[i].Cells[6].Value = dt_.Rows[i]["Vat"];
                dgv1.Rows[i].Cells[7].Value = dt_.Rows[i]["Value"];
                dgv1.Rows[i].Cells[8].Value = dt_.Rows[i]["Branch_code"];
                dgv1.Rows[i].Cells[9].Value = dt_.Rows[i]["Cyear"];
                dgv1.Rows[i].Cells[10].Value = dt_.Rows[i]["Transaction_code"];
                dgv1.Rows[i].Cells[11].Value = dt_.Rows[i]["Acc_no"];
                dgv1.Rows[i].Cells[12].Value = dt_.Rows[i]["PAYER_NAME"];
                dgv1.Rows[i].Cells[13].Value = dt_.Rows[i]["Inv_no"];
                dgv1.Rows[i].Cells[14].Value = dt_.Rows[i]["acc_serial_no"];
            }

        }
    }
}
