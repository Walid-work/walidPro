using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_cost : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_cost()
        {
            InitializeComponent();
        }

     
        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            search_();
         }

        private void search_()
        {
            try
            {




                dgv1.Visible = true;
                this.Height = 150;
                this.BringToFront();

                dgv1.DataSource = dal.getDataTabl_1("select COST_CODE ,COST_name ,COST_E_NAME,acc_no FROM COST_CENTER where (COST_name like '%"+ Desc.Text + "%'  or COST_E_NAME like '%"+ Desc.Text + "%') and COST_CODE like '"+ID.Text+ "%' and COST_CODE like '" + txtMain.Text + "%' and t_final like '" + txt_Tfinl.Text + "%' and isnull(BRANCH_CODE,'') like '" + txtBranch.Text+"%'");
                dgv1.Columns[0].Width = 100;
            }
            catch { }
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
        
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            int ii = dgv1.CurrentCell.RowIndex;

            ID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
            if (Properties.Settings.Default.lungh == "0")
            {
                Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
            }
            else
            {
                Desc.Text = dgv1.Rows[ii].Cells[2].Value.ToString();
            }

            txtAcc.Text = dgv1.Rows[ii].Cells[3].Value.ToString();
            dgv1.Visible = false;
           this.Height = 22;
            this.SendToBack();

        }

        private void ID_TextChanged_1(object sender, EventArgs e)
        {
            get_desc();
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
           this.Height = 22;
            this.SendToBack();
            //this.BackColor = Color.Red;
        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
            search_();
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select Cost_name,acc_no  FROM COST_CENTER where COST_CODE = '" + ID.Text + "' and COST_CODE like '" + txtMain.Text + "%' and t_final like '" + txt_Tfinl.Text + "%'  and isnull(BRANCH_CODE,'') like '" + txtBranch.Text+"%'");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0]["Cost_name"].ToString();
                    txtAcc.Text= dt_.Rows[0]["acc_no"].ToString();
                }
                else
                { Desc.Text = "";
                    txtAcc.Text = "";
                }
            }
            catch { }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select Cost_name  FROM COST_CENTER where COST_CODE = '" + ID.Text + "' and COST_CODE like '" + txtMain.Text + "%' and t_final like '"+txt_Tfinl.Text+"%' and isnull(BRANCH_CODE,'') like '" + txtBranch.Text + "%'");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                }
                else
                { Desc.Text = "";
                    ID.Text = "";
                }
            }
            catch { }
        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void UC_cost_Leave(object sender, EventArgs e)
        {
            dgv1.Visible = false;
           this.Height = 22;
            this.SendToBack();
        //    this.BackColor = Color.Transparent;
        }

        private void UC_cost_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (e.KeyChar == (char)27) {
            //    MessageBox.Show("hhhhhhhhhhhhh");
            //}


        }

        private void UC_cost_KeyDown(object sender, KeyEventArgs e)
        {
           
        }

        private void ID_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }
    }
}
