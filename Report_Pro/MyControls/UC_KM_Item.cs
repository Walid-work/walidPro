using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_KM_Item : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_KM_Item()
        {
            InitializeComponent();
        }

        private void UC_KM_Purch_Load(object sender, EventArgs e)
        {

        }

        private void btn1_Click_1(object sender, EventArgs e)
        {
            search_();

        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            int ii = dgv1.CurrentCell.RowIndex;

            ID.Text   = dgv1.Rows[ii].Cells[0].Value.ToString();
            Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();

            dgv1.Visible = false;
            this.Height = 24;
            this.SendToBack();


        }

        private void search_()
        {
            try
            {
                dgv1.Visible = true;
                this.Height = 130;
                this.BringToFront();
                dgv1.Visible = true;
                dgv1.DataSource = dal.getDataTabl_1("SELECT KM_CODE,KM_DESCR,KM_RATIO FROM KM_MATERIAL_CODE  where KM_DESCR like'%" + Desc.Text + "%'");


                for (int i = 2; i < dgv1.Columns.Count; i++)
                {
                    dgv1.Columns[i].Visible = false;
                }
                dgv1.BringToFront();
                dgv1.Columns[0].Width = 50;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
                return;
            }
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
            this.Height = 24;
            this.SendToBack();
        }

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
            search_();
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT KM_DESCR FROM KM_MATERIAL_CODE where KM_CODE = '" + ID.Text + "'");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0]["KM_DESCR"].ToString();
                }
                else
                {
                    Desc.Text = "";
                }
            }
            catch { }
        }

        private void ID_TextChanged(object sender, EventArgs e)
        {
            get_desc();
        }
    }
}
