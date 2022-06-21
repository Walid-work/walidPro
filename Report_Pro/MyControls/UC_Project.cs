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
    public partial class UC_Project : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_Project()
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
                this.Height = 130;
                this.BringToFront();

                dgv1.DataSource = dal.getDataTabl_1("SELECT ID,Project_Name,Project_Name_E FROM Projects where Project_Name like '" + Desc.Text+ "%' or Project_Name_E like '" + Desc.Text + "%'");
                dgv1.Columns[0].Width = 50;
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
            Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();

            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();

        }

        private void ID_TextChanged_1(object sender, EventArgs e)
        {
            get_desc();
            OnLoad(e);
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.SendToBack();

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
                DataTable dt_ = dal.getDataTabl_1("SELECT Project_Name,Project_Name_E FROM Projects where ID = '" + ID.Text + "'");
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["Project_Name"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["Project_Name_E"].ToString();
                    }

                }
                else
                { Desc.Text = ""; }
            }
            catch { }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT Project_Name,Project_Name_E FROM Projects where ID = '" + ID.Text + "'");
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["Project_Name"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["Project_Name_E"].ToString();
                    }

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
            this.Height = 23;
            this.SendToBack();
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
    }
}
