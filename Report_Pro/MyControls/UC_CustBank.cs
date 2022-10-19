using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    
    public partial class UC_CustBank : UserControl
    {
       
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        
        public UC_CustBank()
        {
            InitializeComponent();
        }


        private void search_()
        {
            try
            {
                dgv1.Visible = true;
                this.Height = 150;
                this.BringToFront();
           
                if (Properties.Settings.Default.lungh == "0")
                {

                    dgv1.DataSource = dal.getDataTabl_1(@"SELECT BANK_NO,BANK_NAME FROM SHEEK_BANKS_TYPE where BANK_NAME like '%" + Desc.Text + "%' or BANK_NAME_E like '%" + Desc.Text + "%'");

                }

                else
                {
                    dgv1.DataSource = dal.getDataTabl_1(@"SELECT BANK_NO,BANK_NAME_E FROM SHEEK_BANKS_TYPE where BANK_NAME like '%" + Desc.Text + "%' or BANK_NAME_E like '%" + Desc.Text + "%'");

                }

               
                        dgv1.Columns[0].Width = 72;
                dgv1.Columns[0].Visible = false;
            }
            catch { }

        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {

            search_();
            //OnLoad(e);
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 21;
            this.SendToBack();
            //this.BackColor = Color.Red;
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {

            int ii = dgv1.CurrentCell.RowIndex;
            Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
            ID.Text   =  dgv1.Rows[ii].Cells[0].Value.ToString();

            dgv1.Visible = false;
            this.Height = 21;
            this.SendToBack();

        }

        private void btn1_ClientSizeChanged(object sender, EventArgs e)
        {

        }

        private void btn1_Click(object sender, EventArgs e)
        {
            search_();
        }

        private void get_desc()
        {
            try
            {
                DataTable dt_;

                dt_ = dal.getDataTabl_1(@"SELECT BANK_NO,BANK_NAME,BANK_NAME_E FROM SHEEK_BANKS_TYPE where BANK_No= '" + ID.Text + "'");
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["BANK_NAME"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["BANK_NAME_E"].ToString();
                    }
                }
                else
                {

                    Desc.Clear();

                }
            }

            catch { }
        }

        private void Leave_ID()
        {
            try
            {
                DataTable dt_;

                dt_ = dal.getDataTabl_1(@"SELECT BANK_NO,BANK_NAME,BANK_NAME_E FROM SHEEK_BANKS_TYPE where BANK_No = '" + ID.Text + "'");
                if (dt_.Rows.Count > 0)
                {
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        Desc.Text = dt_.Rows[0]["BANK_NAME"].ToString();
                    }
                    else
                    {
                        Desc.Text = dt_.Rows[0]["BANK_NAME_E"].ToString();
                    }
                }
                else
                {
                    ID.Clear();
                    Desc.Clear();

                }
            }

            catch { }
        }

        private void ID_Leave(object sender, EventArgs e)
        {
            Leave_ID();
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            get_desc();
        }
    }
}
