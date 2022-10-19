using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class Uc_Group : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Uc_Group()
        {
            InitializeComponent();
        }

      

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT group_code,Group_name FROM wh_Groups where group_code = '" + ID.Text + "' ");
                if (ID.Text!="" && dt_.Rows.Count > 0)
                {
                    ID.Text= dt_.Rows[0][0].ToString();
                    Desc.Text = dt_.Rows[0][1].ToString();
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
                this.Height = 130;
                this.BringToFront();
                dgv1.DataSource = dal.getDataTabl_1("SELECT group_code,Group_name FROM [wh_Groups] where Group_name like '%" + Desc.Text + "'+'%'  ");
                dgv1.Columns[0].Width = 50;
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

        private void UC_Catogry_Leave(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();
        }

        private void Desc_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
