using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class rpt_Mantinance : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public rpt_Mantinance()
        {

            InitializeComponent();
        }

        private void btn_Report_Click(object sender, EventArgs e)
        {

            RPT.CrystalReport2 rpt = new RPT.CrystalReport2();
            rpt.SetDataSource(dal.getDataTabl("Get_WorkShope_Inv_",txt_AccId.Text, dTP1.Value.Date, dTP2.Value.Date));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Acc_Id"].Text = "'" + txt_AccId.Text + "'";
            rpt.DataDefinition.FormulaFields["Acc_Name"].Text = "'" + txt_AccName.Text + "'";

        }

       

       
     

        private void rpt_Mantinance_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            PL.frm_SearchAcc F = new PL.frm_SearchAcc();

            F.radioTransaction.Checked = true;
            F.ShowDialog();

            int ii = F.DGV1.CurrentCell.RowIndex;


            txt_AccId.Text = F.DGV1.Rows[ii].Cells[0].Value.ToString();
            txt_AccName.Text = F.DGV1.Rows[ii].Cells[1].Value.ToString();
        }

        private void txt_AccId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt_ = new DataTable();
                dt_ = dal.getDataTabl("Get_Acc_", txt_AccId.Text, "A2319","cust_acc_wh");
                if (dt_.Rows.Count > 0)
                {
                    txt_AccName.Text = dt_.Rows[0][0].ToString();
                    dTP1.Focus();
                }
                else
                {
                    txt_AccId.Clear();
                    txt_AccName.Clear();
                    PL.frm_SearchAcc F = new PL.frm_SearchAcc();

                    F.radioTransaction.Checked = true;
                    F.ShowDialog();

                    int ii = F.DGV1.CurrentCell.RowIndex;


                    txt_AccId.Text = F.DGV1.Rows[ii].Cells[0].Value.ToString();
                    txt_AccName.Text = F.DGV1.Rows[ii].Cells[1].Value.ToString();

                }
            }
        }

        private void txt_AccId_Leave(object sender, EventArgs e)
        {
            DataTable dt_ = new DataTable();
            dt_ = dal.getDataTabl("Get_Acc_", txt_AccId.Text, "A2319", "cust_acc_wh");
            if (dt_.Rows.Count > 0)
            {
                txt_AccName.Text = dt_.Rows[0][0].ToString();
            }
            else
            {
                txt_AccId.Clear();
                txt_AccName.Clear();
            }
        }
    }
}
