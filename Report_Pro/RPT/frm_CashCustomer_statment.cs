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
    public partial class frm_CashCustomer_statment : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string btn_name;
        string db1 = Properties.Settings.Default.Database_1;
        public frm_CashCustomer_statment()
        {
            InitializeComponent();
        }

     
     
       

       

        private void button1_Click(object sender, EventArgs e)
        {
             groupPanel1.Visible = true;
        }

       
    
        private void button4_Click(object sender, EventArgs e)
        {

            RPT.rpt_CashCastomer_sales rpt = new RPT.rpt_CashCastomer_sales();

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
    }
}
