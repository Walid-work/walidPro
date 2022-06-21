using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_from_toDate : Form

    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_from_toDate()
        {
            InitializeComponent();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            this.Close();
            RPT.Form1 frm = new RPT.Form1();

            RPT.rpt_print_Emplement_jor rpt = new RPT.rpt_print_Emplement_jor();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1("SELECT*  FROM " + dal.db1 + ".dbo.tbl1 As T inner join " + dal.db1 + ".dbo.MEZANIA_ARBAH_CHART As M on M.Gr_Code=T.acc_Code  where cast(T.G_Date as date)  between '"+FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;

            frm.WindowState = FormWindowState.Maximized;
            frm.ShowDialog();
        }
    }
}
