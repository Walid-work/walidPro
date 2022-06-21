using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_Update_Classification : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Update_Classification()
        {
            InitializeComponent();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (OldCat.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من التصنيف القديم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (NewCat.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من التصنيف الجديد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            
          dal.Execute_1(@"update daily_transaction set CAT_CODE ='" + NewCat.ID.Text + "' where CAT_CODE='" + OldCat.ID.Text + "' ");
          //txtUpdatedRecords.Text= dal.effectRows(@"update daily_transaction set CAT_CODE ='" + NewCat.ID.Text + "' where CAT_CODE='" + OldCat.ID.Text + "' ").ToString();

        }

        private void btnUpdateAccount_Click(object sender, EventArgs e)
        {
            if (OldAcc.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من الحساب القديم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
             if (NewAcc.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من الحساب الجديد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dal.Execute_1(@"update daily_transaction set acc_no ='" + NewAcc.ID.Text + "' where acc_no='" + OldAcc.ID.Text + "' and cast(g_date as date ) between '" + from_date.Value.ToString("yyyy-MM-dd") + "' and '" + to_date.Value.ToString("yyyy-MM-dd") + "' and BRANCH_code like case when '" + Uc_AccBranch.ID.Text.Trim() + "'='' then '%' else '" + Uc_AccBranch.ID.Text + "' end ");           
           //txtUpdatedRecords.Text = dal.effectRows(@"update daily_transaction set acc_no ='" + NewAcc.ID.Text + "' where acc_no='" + OldAcc.ID.Text + "'  ").ToString(); ;

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            groupPanel3.Visible = true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"SELECT pass_id,Description,Password  FROM tblPassword where pass_id='pass1' and Password='" + txtOldPass.Text + "' ");
            if (dt_.Rows.Count > 0)
            {
                if (txtNewPass.Text == txtNewPassConfirm.Text)
                {
                    dal.Execute_1(@"UPDATE tblPassword SET Password ='" + txtNewPass.Text + "'  WHERE pass_id ='pass1'");
                    MessageBox.Show(dal.rm.GetString("msgEdit", dal.cul), dal.rm.GetString("msgEdit_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show(dal.rm.GetString("passConfirm", dal.cul), dal.rm.GetString("msgError", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }

            }
            else
            {
                MessageBox.Show(dal.rm.GetString("oldpassConfirm", dal.cul), dal.rm.GetString("msgError", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

            groupPanel3.Visible = false;
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"SELECT pass_id,Description,Password  FROM tblPassword where pass_id='pass1' and Password='" + pass_.Text + "' ");
            if (dt_.Rows.Count > 0)
            {
                groupPanel1.Enabled = true;
                groupPanel2.Enabled = true;
            }
            else
            {
                groupPanel1.Enabled = false;
                groupPanel2.Enabled = false;
            }
        }

        private void btnPreview_Click(object sender, EventArgs e)
        {
            txtSelectedRecords.Clear();
            txtUpdatedRecords.Clear();
            DataTable dtp = dal.getDataTabl_1(@"select  cast(A.g_date as date ) as g_date ,A.ser_no,D.PAYER_NAME,D.payer_l_name,A.meno,A.loh,A.desc2,B.CAT_NAME,C.BRANCH_name,C.BRANCH_E_NAME from daily_transaction As A
            left join CATEGORY As B on A.CAT_CODE=B.CAT_CODE
            inner join BRANCHS As C on A.BRANCH_code = C.BRANCH_code
            inner join payer2 As D on A.ACC_NO=D.ACC_NO and A.BRANCH_code=D.BRANCH_code
            where A.ACC_NO ='" + OldAcc.ID.Text + "'  and cast(A.g_date as date ) between '"+from_date.Value.ToString("yyyy-MM-dd")+ "' and '" + to_date.Value.ToString("yyyy-MM-dd") + "' and A.BRANCH_code like case when '"+Uc_AccBranch.ID.Text.Trim()+"'='' then '%' else '"+Uc_AccBranch.ID.Text+"' end order by A.g_date ");


           // where A.ACC_NO ='" + OldAcc.ID.Text+ "' 
            if (dtp.Rows.Count > 0)
            {
                dataGridView1.RowCount = dtp.Rows.Count;


                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = dtp.Rows[i]["g_date"];
                    dataGridView1.Rows[i].Cells[1].Value = dtp.Rows[i]["ser_no"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dtp.Rows[i]["PAYER_NAME"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dtp.Rows[i]["meno"];
                    dataGridView1.Rows[i].Cells[4].Value = dtp.Rows[i]["loh"];
                    dataGridView1.Rows[i].Cells[5].Value = dtp.Rows[i]["desc2"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dtp.Rows[i]["BRANCH_name"].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dtp.Rows[i]["CAT_NAME"].ToString();

                }

               
            }
            else
            {
                dataGridView1.Rows.Clear();
            }
            txtSelectedRecords.Text = dtp.Rows.Count.ToString();

        }

        private void frm_Update_Classification_Load(object sender, EventArgs e)
        {

        }

        private void labelX9_Click(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {

            txtSelectedRecords.Clear();
            txtUpdatedRecords.Clear();
            DataTable dtp = dal.getDataTabl_1(@"select  cast(A.g_date as date ) as g_date ,A.ser_no,D.PAYER_NAME,D.payer_l_name,A.meno,A.loh,A.desc2,B.CAT_NAME,C.BRANCH_name,C.BRANCH_E_NAME from daily_transaction As A
            left join CATEGORY As B on A.CAT_CODE=B.CAT_CODE
            inner join BRANCHS As C on A.BRANCH_code = C.BRANCH_code
            inner join payer2 As D on A.ACC_NO=D.ACC_NO and A.BRANCH_code=D.BRANCH_code
            where A.CAT_CODE ='" + OldCat.ID.Text + "' order by A.g_date ");
            if (dtp.Rows.Count > 0)
            {
                dataGridView1.RowCount = dtp.Rows.Count;


                for (int i = 0; i < dataGridView1.RowCount; i++)
                {
                    dataGridView1.Rows[i].Cells[0].Value = dtp.Rows[i]["g_date"];
                    dataGridView1.Rows[i].Cells[1].Value = dtp.Rows[i]["ser_no"].ToString();
                    dataGridView1.Rows[i].Cells[2].Value = dtp.Rows[i]["PAYER_NAME"].ToString();
                    dataGridView1.Rows[i].Cells[3].Value = dtp.Rows[i]["meno"];
                    dataGridView1.Rows[i].Cells[4].Value = dtp.Rows[i]["loh"];
                    dataGridView1.Rows[i].Cells[5].Value = dtp.Rows[i]["desc2"].ToString();
                    dataGridView1.Rows[i].Cells[6].Value = dtp.Rows[i]["BRANCH_name"].ToString();
                    dataGridView1.Rows[i].Cells[7].Value = dtp.Rows[i]["CAT_NAME"].ToString();

                }


            }
            txtSelectedRecords.Text = dtp.Rows.Count.ToString();

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
