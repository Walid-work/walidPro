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

    public partial class frm_project_materails : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        string btn_name;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_project_materails()
        {
            InitializeComponent();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

        
        }

        private void frm_project_materails_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void btn_Report_Click_1(object sender, EventArgs e)
        {
            RPT.CrystalReport4 rpt = new RPT.CrystalReport4();

            rpt.SetDataSource(dal.getDataTabl("Get_opo_Detials_", dTP1.Value.Date, dTP2.Value.Date, UC_Branch.ID.Text, UC_Acc.ID.Text, UC_Items.ID.Text,UC_Cost.ID.Text,db1));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["Txt_Acc"].Text = "'" + UC_Acc.ID.Text.ToString() + "'+' -  '+'" + UC_Acc.Desc.Text.ToString() + "'";
            rpt.DataDefinition.FormulaFields["Txt_Branch"].Text = "'" + UC_Branch.ID.Text.ToString() + "'+' -  '+'" + UC_Branch.Desc.Text.ToString() + "'";
            rpt.DataDefinition.FormulaFields["txt_cost"].Text = "'" + UC_Cost.ID.Text.ToString() + "'+' -  '+'" + UC_Cost.Desc.Text.ToString() + "'";
            rpt.DataDefinition.FormulaFields["txt_item"].Text = "'" + UC_Items.ID.Text.ToString() + "'+' -  '+'" + UC_Items.Desc.Text.ToString() + "'";
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";

            groupPanel1.Visible = false;

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

    
      
        private void buttonX1_Click(object sender, EventArgs e)
        {
            RPT.project_matirals_byCost rpt = new RPT.project_matirals_byCost();

            rpt.SetDataSource(dal.getDataTabl("Get_opo_Detials_", dTP1.Value.Date, dTP2.Value.Date, UC_Branch.ID.Text.ToString(), UC_Acc.ID.Text.ToString(), UC_Items.ID.Text.ToString(), UC_Cost.ID.Text.ToString(),db1));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["Txt_Acc"].Text = "'" + UC_Acc.ID.Text.ToString() + "'+' -  '+'" + UC_Acc.Desc.Text.ToString() + "'";
            rpt.DataDefinition.FormulaFields["Txt_Branch"].Text = "'" + UC_Branch.ID.Text.ToString() + "'+' -  '+'" + UC_Branch.Desc.Text.ToString() + "'";
            rpt.DataDefinition.FormulaFields["txt_cost"].Text = "'" + UC_Cost.ID.Text.ToString() + "'+' -  '+'" + UC_Cost.Desc.Text.ToString() + "'";
            rpt.DataDefinition.FormulaFields["txt_item"].Text = "'" + UC_Items.ID.Text.ToString() + "'+' -  '+'" + UC_Items.Desc.Text.ToString() + "'";
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";

            groupPanel1.Visible = false;
        }

        private void UC_Branch_Load(object sender, EventArgs e)
        {
            UC_Acc.branchID.Text = UC_Branch.ID.Text;
        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }
    }
}
