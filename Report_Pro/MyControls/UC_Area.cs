using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_Area : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_Area()
        {
            InitializeComponent();
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {

        }
        private void search_()
        {
            try
            {
                dgv1.Visible = true;
                this.Height = 130;
                this.BringToFront();
                dgv1.DataSource = dal.getDataTabl_1("select Main_Area_code,Main_Area_Name from wh_Area where Main_Area_Name like '%"+ Desc.Text +"%'");
                dgv1.Columns[0].Width = 50;
            }
            catch { }

        }


        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select Main_Area_Name from wh_Area where Main_Area_code= '" + ID.Text +"'");
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

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.BringToFront();
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

        private void btn1_Click(object sender, EventArgs e)
        {
            search_();
        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
            search_();
        }

        private void UC_Area_Leave(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 23;
            this.BringToFront();
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            get_desc();
        }
    }
}
