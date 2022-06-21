using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Report_Pro.RPT
{
    public partial class Rpt_Pro_Frm : Form

    {
       // BL.Cls_product prd = new BL.Cls_product();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public Rpt_Pro_Frm()
        {
            InitializeComponent();
        }

        private void Rpt_Pro_Frm_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            RPT.rpt_cat_all rpt = new RPT.rpt_cat_all();
            RPT.Rpt_Pro_Frm frm = new RPT.Rpt_Pro_Frm();
            rpt.SetDataSource(dal.getDataTabl("get_Cat"));
            //frm.MdiParent = BL.Main_frm();
            rpt.Refresh();
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.Show();
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, @"c:\pic\tst.pdf");

        }
    }
}
