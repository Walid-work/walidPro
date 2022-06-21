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
    public partial class frmAccDetails : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmAccDetails()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"SELECt A.Acc_no,B.PAYER_NAME,B.PAYER_L_NAME,A.BRANCH_code,C.BRANCH_name,C.BRANCH_E_name,ser_no
            ,meno,loh,g_date,desc2,T.c1  FROM daily_transaction as A
            inner join payer2 as B on A.ACC_NO=B.ACC_NO and A.BRANCH_code=B.BRANCH_code
            inner join Branchs as C on  A.BRANCH_code=C.BRANCH_code
            inner join (select acc_no,sum(meno-loh) as c1 FROM daily_transaction  group by ACC_NO) t on t.ACC_NO=A.ACC_NO
            where A.ACC_NO like '" + txtAcc.ID.Text+"%'  and t.c1 <>0");

            DataSet ds = new DataSet();
            RPT.rpt_AccDetials rpt = new RPT.rpt_AccDetials();
            ds.Tables.Add(dt_);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }
    }
}
