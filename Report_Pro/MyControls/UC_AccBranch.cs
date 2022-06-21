using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_AccBranch : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_AccBranch()
        {
            InitializeComponent();
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
            OnDoubleClick(e);
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT BRANCH_name,BRANCH_E_NAME  FROM BRANCHS where BRANCH_code='" + ID.Text + "' and t_final like '" + txtFinal.Text + "%' ");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                }
                else
                {

                    Desc.Clear();

                }
            }

            catch { }
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
                dgv1.DataSource = dal.getDataTabl_1("SELECT BRANCH_code,BRANCH_name,BRANCH_E_NAME  FROM BRANCHS where (BRANCH_name like'%" + Desc.Text + "%' or BRANCH_E_NAME  like '%" + Desc.Text + "%') and t_final like '"+txtFinal.Text+"%' ");
                dgv1.Columns[0].Width = 100;
            }
            catch { }

        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
            search_();
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {

            int ii = dgv1.CurrentCell.RowIndex;

            ID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
            Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();

            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();
            OnDoubleClick(e);

        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            get_desc();
            OnLoad(e);

        }

        private void Desc_TextChanged(object sender, EventArgs e)
        {

        }

       

        private void UC_AccBranch_Leave(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT BRANCH_name,BRANCH_E_NAME  FROM BRANCHS where BRANCH_code='" + ID.Text + "' and t_final like '" + txtFinal.Text + "%' ");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                }
                else
                {
                    ID.Clear();
                    Desc.Clear();

                }
            }

            catch { }
            OnDoubleClick(e);
        }

        private void Desc_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT BRANCH_name,BRANCH_E_NAME  FROM BRANCHS where BRANCH_code='" + ID.Text + "' and t_final like '" + txtFinal.Text + "%' ");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                }
                else
                {
                    ID.Clear();
                    Desc.Clear();

                }
            }

            catch { }

        }

        private void UC_AccBranch_DoubleClick(object sender, EventArgs e)
        {

        }
    }
}
