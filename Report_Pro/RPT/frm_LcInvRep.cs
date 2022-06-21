using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_LcInvRep : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_LcInvRep()
        {
            InitializeComponent();
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            //this.Cursor = Cursors.WaitCursor;
            groupPanel2.Visible = false;
            DataSet ds = new DataSet();
            RPT.rpt_LcsInv rpt = new RPT.rpt_LcsInv();
            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.*,B.BID,B.Currency,B.AcceptDays ,B.Branch_Code,C.ACC_BRANCH,C.branch_name,D.PAYER_NAME
                                                FROM LcInvTbl as A inner join LcsTbl as B on A.LcNo=B.LcNo
                                                inner join wh_BRANCHES as C on B.Branch_Code=C.Branch_code
                                                inner Join payer2 as D on D.ACC_NO=B.BID and C.ACC_BRANCH=D.Branch_Code 
            where B.BID like '"+txtBank.ID.Text+"%' and A.LcNo like '"+txtLcNo.Text+"%' and cast(( case when '" + comb1.SelectedIndex + "' = 0 then InvMaturtyDate when '" + comb1.SelectedIndex + "' = 1  then InvShipDate when '" + comb1.SelectedIndex + "' = 2  then receveDate when '" + comb1.SelectedIndex + "' = 3  then paiedDate end ) as date) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'");
            //where B.BID like '" + txtBank.ID.Text + "%' and A.LcNo like '" + txtLcNo.Text + "%' and cast(( case when '" + comb1.SelectedIndex + "'=0 then InvMaturtyDate when '" + comb1.SelectedIndex + "'=1  then InvShipDate when '" + comb1.SelectedIndex + "'=2  then receveDate when '" + comb1.SelectedIndex + "'=3  then paiedDate end ) as date) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'  ");


            ds.Tables.Add(dt_);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);

            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["titelText"].Text = "'" + comb1.SelectedText.ToString() + "'";



            //this.Cursor = Cursors.Default;

        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = true;
        }

        private void frm_LcInvRep_Load(object sender, EventArgs e)
        {
            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;

            comb1.SelectedIndex = 0;

            txtBank.txtMainAcc.Text = "122";
            txtBank.txtFinal.Text = "1";
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {

        }
    }
}
