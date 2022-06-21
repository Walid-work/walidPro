using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_SearchAcc : XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string _tFinal = "1";
        public frm_SearchAcc()
        {
            InitializeComponent();
            //DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A","", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));
            searchAcc_();
        }

        private void frm_SearchAcc_Load(object sender, EventArgs e)
        {

        }

        private void txtsearchID_TextChanged(object sender, EventArgs e)
        {
            //DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A", "", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));
            searchAcc_();
        }

        private void txtSearchName_TextChanged(object sender, EventArgs e)
        {
            //DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A", "", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));
            searchAcc_();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            // DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A", "", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));
            searchAcc_();
        }

        private void radioTransaction_CheckedChanged(object sender, EventArgs e)
        {
            //  DGV1.DataSource = dal.getDataTabl("SearchAcc_", "A", "", txtsearchID.Text, txtSearchName.Text, (radioParent.Checked ? "" : "1"));
            searchAcc_();
        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void searchAcc_()
        {
         
             DataTable dt1 = dal.getDataTabl_1(@"select ACC_NO,PAYER_NAME,case when ISNULL(payer_l_name,'')='' then PAYER_NAME else payer_l_name end as payer_l_name  FROM payer2
            where BRANCH_code like '" + Properties.Settings.Default.BranchAccID + "%' and Acc_No like '" + txtsearchID.Text + "%' and(PAYER_NAME like '%" + txtSearchName.Text + "%' or payer_l_name like '%" + txtSearchName.Text + "%') and t_final like '" + _tFinal + "%' ");

            if (dt1.Rows.Count > 0)
            {
                int B_rowscount = dt1.Rows.Count;

                DGV1.Rows.Clear();
                DGV1.Rows.Add(B_rowscount);
                for (int i = 0; i <= (B_rowscount - 1); i++)
                {


                    DGV1.Rows[i].Cells[0].Value = dt1.Rows[i]["ACC_NO"];
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        DGV1.Rows[i].Cells[1].Value = dt1.Rows[i]["PAYER_NAME"];
                    }
                    else
                    {
                        DGV1.Rows[i].Cells[1].Value = dt1.Rows[i]["payer_l_name"];
                    }
                }
            }
            else
            {
                DGV1.Rows.Clear();
            }
        }

            private void radioParent_CheckedChanged(object sender, EventArgs e)
        {
            if (radioParent.Checked == true)
            {
                _tFinal = "";
            }
            else
            {
                _tFinal = "1";
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_search_Click(object sender, EventArgs e)
        {
            searchAcc_();
        }
    }
}
