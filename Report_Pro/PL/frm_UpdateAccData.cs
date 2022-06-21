using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_UpdateAccData : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_UpdateAccData()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

    

        private void frm_UpdateAccData_Load(object sender, EventArgs e)
        {

        }

        private void get_desc()
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select PAYER_NAME,COSTMER_K_M_NO from  main_acc_wh.dbo.payer2 where ACC_NO= '" + ID.Text + "'   ");
                if (dt_.Rows.Count > 0)
                {
                    Desc.Text = dt_.Rows[0][0].ToString();
                    txtDesc.Text = dt_.Rows[0][0].ToString();
                    txt_VatNo.Text= dt_.Rows[0][1].ToString();
                }
                else
                {

                    Desc.Clear();

                }
            }
            catch { }
        }


        private void search_()
        {
            try
            {
                dgv1.Visible = true;
                dgv1.DataSource = dal.getDataTabl_1("select ACC_NO,PAYER_NAME,COSTMER_K_M_NO from  main_acc_wh.dbo.payer2 where PAYER_NAME like '%" + Desc.Text + "%'  ORDER BY acc_no ");
                dgv1.Columns[0].Width = 50;
            }
            catch { }

        }

     

        private void btn1_Click(object sender, EventArgs e)
        {
            search_();
        }

    

        private void Desc_KeyUp(object sender, KeyEventArgs e)
        {
            search_();
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {

            int ii = dgv1.CurrentCell.RowIndex;

            ID.Text = dgv1.Rows[ii].Cells[0].Value.ToString();
            Desc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
            txtDesc.Text = dgv1.Rows[ii].Cells[1].Value.ToString();
            txt_VatNo.Text= dgv1.Rows[ii].Cells[2].Value.ToString();
            dgv1.Visible = false;
          
        }

        private void ID_Enter(object sender, EventArgs e)
        {
            dgv1.Visible = false;
         
        }

        private void ID_KeyUp(object sender, KeyEventArgs e)
        {
            get_desc();
            txtDesc.Text = Desc.Text;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dal.Execute_1("update "+dal.db1+".dbo.payer2 set PAYER_NAME = '" + txtDesc.Text + "',COSTMER_K_M_NO='" + txt_VatNo.Text + "' where acc_no='"+ID.Text+"'");
            MessageBox.Show("تمت عملية التحديث بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
