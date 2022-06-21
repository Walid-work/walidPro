using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    
    public partial class frm_Compare_PQ : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Compare_PQ()
        {
            InitializeComponent();
          
        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = false;

            RPT.rpt_Compear_Qutation rpt = new RPT.rpt_Compear_Qutation();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl("Compear_Qutation_", txt_RQ_No.Text,Convert.ToString(txtSupplier.SelectedValue),100, dal.db1);
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
                     
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = true;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {

            groupPanel2.Visible = false;

            RPT.rpt_Compear_Qutation rpt = new RPT.rpt_Compear_Qutation();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl("Compear_Qutation_", txt_RQ_No.Text, Convert.ToString(txtSupplier.SelectedValue), "1", dal.db1);
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frm_Compare_PQ_Load(object sender, EventArgs e)
        {
            txtSupplier.DataSource = dal.getDataTabl_1(@"select SupplierID,P.PAYER_NAME,p.payer_l_name FROM " + dal.db1 + ".dbo.Purchase_Qutation As A " +
              "inner join " + dal.db1 + ".dbo.payer2 As P on a.SupplierID = p.ACC_NO and a.Branch_code = p.BRANCH_code where A.RQ_ser='" + txt_RQ_No.Text + "'");

            txtSupplier.DisplayMember = "Payer_Name";
            txtSupplier.ValueMember = "SupplierID";
            txtSupplier.SelectedIndex = -1;
        }

        private void txt_RQ_No_TextChanged(object sender, EventArgs e)
        {
            txtSupplier.DataSource = dal.getDataTabl_1(@"select SupplierID,P.PAYER_NAME,p.payer_l_name FROM " + dal.db1 + ".dbo.Purchase_Qutation As A " +
              "inner join " + dal.db1 + ".dbo.payer2 As P on a.SupplierID = p.ACC_NO and a.Branch_code = p.BRANCH_code where A.RQ_ser='" + txt_RQ_No.Text + "'");

            txtSupplier.DisplayMember = "Payer_Name";
            txtSupplier.ValueMember = "SupplierID";
            txtSupplier.SelectedIndex = -1;
        }
    }
}
