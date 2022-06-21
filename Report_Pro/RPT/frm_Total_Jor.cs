using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_Total_Jor : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
     
        public frm_Total_Jor()
        {
            InitializeComponent();
            //try
            //{
            //    cmb_DB_1.DataSource = dal.getDataTabl("get_DB_");
            //    cmb_DB_1.DisplayMember = "name";
            //    cmb_DB_1.ValueMember = "database_id";
            //    cmb_DB_1.SelectedText = Properties.Settings.Default.Database_1;
            //}
            //catch { }
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = true;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            RPT.Total_jor rpt = new RPT.Total_jor();
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            dt1 = dal.getDataTabl_1(@"select * from(
            SELECT  CAST(D.g_date AS DATE ) as date_,D.Branch_code,B.BRANCH_name, D.ser_no, SUM(meno) as M,SUM(loh) as C FROM " + cmb_DB_1.Text+ 
            ".dbo.daily_transaction as D inner join "+ cmb_DB_1.Text+ 
            ".dbo.BRANCHS as B on B.BRANCH_code=D.BRANCH_code where CAST(D.g_date AS DATE ) BETWEEN '"+dtp1.Value.ToString("yyyy/MM/dd")+ 
            "' AND '" + dtp2.Value.ToString("yyyy/MM/dd") + "' group by  CAST(D.g_date AS DATE ),D.Branch_code,B.BRANCH_name,D.ser_no ) as X where x.C <> x.M");

            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema1.xml");

            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["from_date"].Text = "'" + dtp1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["to_date"].Text = "'" + dtp2.Value.ToString("yyyy/MM/dd") + "'";


            groupPanel2.Visible = false;
        }

        private void frm_Total_Jor_Load(object sender, EventArgs e)
        {

        }

        private void uC_AccBranch1_Load(object sender, EventArgs e)
        {

        }

        private void CompanyDB_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CompanyDB.SelectedIndex == 0)
            {
                cmb_DB_1.Text = "MAIN_ACC_WH";
            }
            else if (CompanyDB.SelectedIndex == 1)
            {
                cmb_DB_1.Text = "FACTORY";
            }
            else if (CompanyDB.SelectedIndex == 2)
            {
                cmb_DB_1.Text = "CUST_ACC_WH";
            }
        }
    }
}
