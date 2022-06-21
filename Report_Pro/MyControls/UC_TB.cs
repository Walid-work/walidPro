using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_TB : UserControl
    {
        string btn_name;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_TB()
        {
            InitializeComponent();
        }

        private void Branch_code_Enter(object sender, EventArgs e)
        {
            DGV3.Visible = false;
        }

        private void Acc_no_Enter(object sender, EventArgs e)
        {
            DGV3.Visible = false;
        }

        private void Cost_No_Enter(object sender, EventArgs e)
        {
            DGV3.Visible = false;
        }

        private void Cat_No_Enter(object sender, EventArgs e)
        {
            DGV3.Visible = false;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search_branch();
        }

        private void search_ACC()
        {
            btn_name = "Acc_serch";
            DGV3.Visible = true;
            DGV3.DataSource = dal.getDataTabl_1("select Acc_no,PAYER_NAME,payer_l_name from payer2 where BRANCH_code like '" + Branch_code.Text
            + "%' and (PAYER_NAME like '%" + Acc_name.Text + "%' or payer_l_name like '%" + Acc_name.Text + "%')");
            DGV3.Columns[2].Visible = false;
            DGV3.Columns[0].Width = 80;
            int clientX = (int)(Acc_name.Location.X);
            int clientY = (int)(Acc_name.Location.Y);
            DGV3.Location = new Point(clientX, clientY + 20);
        }


        private void search_branch()
        {
            btn_name = "Search_Branch";
            DGV3.Visible = true;
            DGV3.DataSource = dal.getDataTabl_1("select Branch_code,branch_name,WH_E_NAME from wh_BRANCHES where branch_name like '%" + Branch_name.Text + "%' and t_final= '1'");
            DGV3.Columns[2].Visible = false;
            DGV3.Columns[0].Width = 80;
            int clientX = (int)(Branch_name.Location.X);
            int clientY = (int)(Branch_name.Location.Y);
            DGV3.Location = new Point(clientX, clientY + 20);
        }

        private void Search_Acc_Click(object sender, EventArgs e)
        {
            search_ACC();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn_name = "cost_serch";
            DGV3.Visible = true;
            DGV3.DataSource = dal.getDataTabl("SearchCost", Cost_Name.Text);
            DGV3.Columns[0].Width = 80;
            int clientX = (int)(Cost_Name.Location.X);
            int clientY = (int)(Cost_Name.Location.Y);
            DGV3.Location = new Point(clientX, clientY + 20);
        }

        private void Branch_name_KeyUp(object sender, KeyEventArgs e)
        {
            search_branch();
        }

        private void Acc_name_KeyUp(object sender, KeyEventArgs e)
        {
            search_ACC();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void Acc_no_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {

                DataTable dtAcc = dal.getDataTabl_1("select PAYER_NAME,payer_l_name from payer2 where BRANCH_code like '" + Branch_code.Text
                    + "%' and acc_no ='" + Acc_no.Text + "'");
                if (dtAcc.Rows.Count > 0)
                {
                    Acc_name.Text = (dal.getDataTabl_1("select PAYER_NAME,payer_l_name from payer2 where BRANCH_code like '" + Branch_code.Text
                   + "%' and acc_no ='" + Acc_no.Text + "'")).Rows[0][0].ToString();
                }
                else
                {
                    Acc_name.Text = "";
                }
            }
            catch
            {

            }
        }

        private void DGV3_DoubleClick(object sender, EventArgs e)
        {
            if (btn_name == "Acc_serch")
            {
                int ii = DGV3.CurrentCell.RowIndex;

                Acc_no.Text = DGV3.Rows[ii].Cells[0].Value.ToString();
                Acc_name.Text = DGV3.Rows[ii].Cells[1].Value.ToString();

            }

            else if (btn_name == "Search_Branch")
            {
                int ii = DGV3.CurrentCell.RowIndex;
                Branch_code.Text = DGV3.Rows[ii].Cells[0].Value.ToString();
                Branch_name.Text = DGV3.Rows[ii].Cells[1].Value.ToString();
            }

            else if (btn_name == "cost_serch")
            {
                int ii = DGV3.CurrentCell.RowIndex;
                Cost_No.Text = DGV3.Rows[ii].Cells[0].Value.ToString();
                Cost_Name.Text = DGV3.Rows[ii].Cells[1].Value.ToString();
            }


            DGV3.Visible = false;

        }

        private void RBtnAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBtn1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBtn2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBtn3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBtn4_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
