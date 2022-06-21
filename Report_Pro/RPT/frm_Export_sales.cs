using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
//
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_Export_sales : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string btn_name;
        string db1 = Properties.Settings.Default.Database_1;
        public frm_Export_sales()
        {
            InitializeComponent();
        }

     
        private void btn_Report_Click(object sender, EventArgs e)
        {

            string str_t = "1";
            string car_studes = "";
            if (radioBtn1.Checked)
            {
                str_t = "1";
                car_studes = radioBtn1.Text;
            }
            else if (radioBtn2.Checked)
            {
                str_t = "2";
                car_studes = radioBtn2.Text;
            }
            else if (radioBtn3.Checked)
            {
                str_t = "3";
                car_studes = radioBtn3.Text;
            }

            RPT.rpt_Export_Sales rpt = new RPT.rpt_Export_Sales();

            rpt.SetDataSource(dal.getDataTabl("Get_Sales_", dTP1.Value.Date, dTP2.Value.Date, '3',str_t,UC_Acc.ID.Text,db1));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
              groupPanel1.Visible = false;
        }

     
       

       

        private void button1_Click(object sender, EventArgs e)
        {
             groupPanel1.Visible = true;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

            RPT.rpt_local_sales rpt = new RPT.rpt_local_sales();

            rpt.SetDataSource(dal.getDataTabl("Get_local_Sales_", dTP1.Value.Date, dTP2.Value.Date, '1', UC_Branch.ID.Text, UC_Acc.ID.Text, UC_PayType.ID.Text, db1));

            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + UC_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + UC_PayType.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Report_Titel"].Text = "'المبيعات بالنسبة الاساسية 5 % '";
            rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";

            groupPanel1.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            RPT.return_previws_period rpt = new RPT.return_previws_period();

            rpt.SetDataSource(dal.getDataTabl_1(@"SELECT  A.Transaction_code,A.Ser_no,A.Branch_code,A.G_date,A.Payment_Type,A.Inv_no,A.Inv_date,A.acc_serial_no,
                ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) as Value,
                PAYER_NAME, branch_name, Payment_name, sum(D.TAX_OUT - D.TAX_IN) as VAt, T.INV_NAME, KM_CODE_ACC
       
                FROM    wh_inv_data as A  INNER JOIN
                payer2 ON A.Acc_no = payer2.ACC_NO
                AND A.Acc_Branch_code = payer2.BRANCH_code
                INNER JOIN wh_BRANCHES ON A.Branch_code = wh_BRANCHES.Branch_code
                INNER JOIN wh_Payment_type ON A.Payment_Type = wh_Payment_type.Payment_type
                INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO AND A.Branch_code = D.Branch_code AND
                A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
                inner join WH_INV_TYPE As T on T.INV_CODE = a.Transaction_code

                WHERE   (A.Transaction_code = 'Xsr' or A.Transaction_code = 'XsT')
                and CAST(A.G_date AS DATE) BETWEEN '"+dTP1.Value.ToString("yyyy-MM-dd")+"' " +
                "AND '"+dTP2.Value.ToString("yyyy-MM-dd") + "' " +
                "and CAST(A.Inv_date as date) <'"+dTP1.Value.ToString("yyyy-MM-dd")+"' " +
                "and KM_CODE_ACC <> 3 and KM_CODE_ACC = '1' and A.Branch_code like '"+UC_Branch.ID.Text+"%' " +
                "and a.Acc_no like '"+UC_Acc.ID.Text+"%' and a.Payment_Type like '"+ UC_PayType.ID.Text+"%' " +
                "group by    A.Transaction_code, A.Ser_no, A.Branch_code, A.G_date, A.Payment_Type, A.Inv_no, A.Inv_date," +
                "A.acc_serial_no, A.NetAmount, PAYER_NAME, branch_name, Payment_name, T.INV_NAME, KM_CODE_ACC"));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                groupPanel1.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {

            RPT.rpt_local_sales rpt = new RPT.rpt_local_sales();

            rpt.SetDataSource(dal.getDataTabl("Get_CashCustomer_Sales_", dTP1.Value.Date, dTP2.Value.Date,"", UC_Branch.ID.Text, UC_Acc.ID.Text, UC_PayType.ID.Text, db1, cashCustomer1.ID.Text.ToString()));

            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + cashCustomer1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + UC_PayType.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["CashCustomer"].Text = "'" + cashCustomer1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Report_Titel"].Text = "'تقرير مبيعات عميل نقدي '";
            

            groupPanel1.Visible = false;

        }

        private void totSales_Click(object sender, EventArgs e)
        {
            RPT.rpt_local_sales rpt = new RPT.rpt_local_sales();

            rpt.SetDataSource(dal.getDataTabl_1(@"SELECT A.Ser_no,A.Transaction_code,A.Branch_code,A.G_date,A.Payment_Type,
T.INV_NAME, A.Inv_no, A.Inv_date, A.acc_serial_no, p.PAYER_NAME, p.payer_l_name, p.adress,
B.branch_name, C.Payment_name, A.Acc_no, sum(D.QTY_TAKE - D.QTY_ADD) As Qty
, ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
, sum(D.TAX_OUT) - sum(D.TAX_IN) As Vat, A.CUSTOM_NO, A.Storing_Expire_Date, A.COSTMER_K_M_NO

FROM wh_inv_data as A
INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code

WHERE(A.Transaction_code like 'Xs%')
and CAST(A.G_date AS DATE) BETWEEN '" + dTP1.Value.ToString("yyyy/MM/dd") + "' AND '" + dTP2.Value.ToString("yyyy/MM/dd") +
"' and A.Branch_code like '"+UC_Branch.ID.Text+"%' and a.Acc_no like '"+UC_Acc.ID.Text+"%' and a.Payment_Type like '"+UC_PayType.ID.Text+
"%' group by    A.Ser_no, A.Transaction_code, A.Branch_code, A.G_date, A.Payment_Type, A.Inv_no," +
"A.Inv_date, A.acc_serial_no, A.NetAmount, P.PAYER_NAME, B.branch_name, C.Payment_name, A.Acc_no," +
"T.INV_NAME, A.CUSTOM_NO, A.Storing_Expire_Date, p.payer_l_name, p.adress, A.COSTMER_K_M_NO"));

            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            groupPanel1.Visible = false;
        }

        private void dTP1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
