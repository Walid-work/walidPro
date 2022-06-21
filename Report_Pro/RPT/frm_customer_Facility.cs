using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_customer_Facility : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string Acc_Stope = "";
        string Facilty_ = "";
        string Facilty_1 = "";
        public frm_customer_Facility()
        {
            InitializeComponent();
        }

        private void frm_customer_Facility_Load(object sender, EventArgs e)
        {

        }

        private void btn_2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            if (RS1.Checked == true)
            { Acc_Stope = ""; }
            else if (RS2.Checked == true)
            { Acc_Stope = "S"; }

            if (FaciltyAll.Checked == true)
            { Facilty_ = ""; 
            Facilty_1 = ""; }

            if (Facilty.Checked == true)
            { Facilty_ = "Yes"; 
            Facilty_1 = "Yes"; }

            if (WithoutFacilty.Checked == true)
            { Facilty_ = "NO"; 
             Facilty_1 = ""; }


            RPT.rpt_Facility tb_rep = new RPT.rpt_Facility();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = (dal.getDataTabl("Get_FAcility", Uc_Acc.ID.Text, Uc_Branch.ID.Text,Facilty_ ,Facilty_1, Acc_Stope, dal.db1));
                ds.Tables.Add(dt1);
                //ds.WriteXmlSchema("schema_rpt.xml");
            tb_rep.SetDataSource(ds);

            crystalReportViewer1.ReportSource = tb_rep;
            tb_rep.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            tb_rep.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            Cursor.Current = Cursors.Default;
           groupPanel1.Visible = false;


            


        }

        private void btn_3_Click(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }
    }
}
