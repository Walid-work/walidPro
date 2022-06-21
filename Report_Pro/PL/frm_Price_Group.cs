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
    public partial class frm_Price_Group : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_Price_Group()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void radioParent_CheckedChanged(object sender, EventArgs e)
        {
            get_code();
        }

        private void get_code()
        {
            if (radioParent.Checked == true)
            {
                txtMainGroup.ID.Clear();
                txtMainGroup.Enabled = false;
                txtCode.Text = dal.GetCell_1(@"SELECT isnull(max(code)+1,1)  FROM Price_Group_Table
                where T_Final = 0 ").ToString().PadLeft(2, '0');
            }
            else
            {
                txtMainGroup.Enabled = true;
                txtCode.Text = txtMainGroup.ID.Text + dal.GetCell_1(@"SELECT isnull(max(Right(code,len(code)-len('" + txtMainGroup.ID.Text+ "')))+1,1)  FROM Price_Group_Table " +
                    "where T_Final = 1 and Main_Code ='"+ txtMainGroup.ID.Text+"' ").ToString().PadLeft(3, '0');

            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if(radioParent.Checked == true)
            {
                if (txtCode.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("تأكد من كود المجموعة");
                    return;
                }
            }
            else
            {
                if (txtCode.Text.Trim() == string.Empty || txtMainGroup.ID.Text.Trim() == string.Empty)
                {
                    MessageBox.Show("تأكد من كود المجموعة");
                    return;
                }
            }

                DataTable dt1 =  dal.getDataTabl_1(@"SELECT *  FROM Price_Group_Table where code = '"+txtCode.Text+ "' and t_final='" + (radioParent.Checked ? "0" : "1") + "'");
            if (dt1.Rows.Count > 0)
            {
                dal.Execute_1("update Price_Group_Table set Descr='" + txtDescription.Text + "',Descr_E='" + txtDescription_E.Text + "',T_Final='" + (radioParent.Checked ? "0" : "1") + "',Main_Code='" + txtMainGroup.ID.Text + "',Ton_Price='" + txtPrice.Value + "' where Code='" + txtCode.Text + "'");
                MessageBox.Show(dal.rm.GetString("msgEdit", dal.cul), dal.rm.GetString("msgEdit_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                dal.Execute_1("insert into  Price_Group_Table (Code,Descr,Descr_E,T_Final,Main_Code,Ton_Price) values('" + txtCode.Text + "','" + txtDescription.Text + "','" + txtDescription_E.Text + "','" + (radioParent.Checked ? "0" : "1") + "','" + txtMainGroup.ID.Text + "','" + txtPrice.Value + "') ");
                MessageBox.Show(dal.rm.GetString("msgSave", dal.cul), dal.rm.GetString("msgSave_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

            }

        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            dal.ClearTextBoxes(this);
            get_code();
        }

        private void frm_Price_Group_Load(object sender, EventArgs e)
        {
            txtMainGroup.txtFinal.Text = "0";
            search_();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {

        }private void search_()
        {
            DataTable dt2 = dal.getDataTabl_1(@"select Code,Descr,Descr_E,T_Final,Main_Code,Ton_Price from Price_Group_Table where Descr like '%" + txtSearch.Text + "'+'%' or  Descr_E like '%" + txtSearch.Text + "'+'%'");
            int rowscount = dt2.Rows.Count;
            dgv1.Rows.Clear();
            if (rowscount > 0)
            {


                dgv1.Rows.Add(rowscount);
                for (int i = 0; i <= (rowscount - 1); i++)
                {

                    dgv1.Rows[i].Cells[0].Value = dt2.Rows[i]["Code"];
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        dgv1.Rows[i].Cells[1].Value = dt2.Rows[i]["Descr"];
                        dgv1.Rows[i].Cells[2].Value = dt2.Rows[i]["T_Final"].ToString() == "0" ? "رئيسي" : "فرعي";
                    }
                    else
                    {
                        dgv1.Rows[i].Cells[1].Value = dt2.Rows[i]["Descr_E"];
                        dgv1.Rows[i].Cells[2].Value = dt2.Rows[i]["T_Final"].ToString() == "0" ? "Main" : "Sub";

                    }
                    dgv1.Rows[i].Cells[3].Value = dt2.Rows[i]["Ton_Price"];

                }
            }
        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            DataTable dt3 = dal.getDataTabl_1(@"select Code,Descr,Descr_E,T_Final,Main_Code,Ton_Price from Price_Group_Table where code ='"+dgv1.CurrentRow.Cells[0].Value.ToString() + "'");

            if (dt3.Rows.Count > 0)
            {
                if (dt3.Rows[0]["T_Final"].ToString() == "0")
                {
                    radioParent.Checked = true;
                }
                else
                {
                    radioTransaction.Checked = true;
                }
                txtCode.Text = dt3.Rows[0]["code"].ToString();
                txtDescription.Text = dt3.Rows[0]["Descr"].ToString();
                txtDescription_E.Text = dt3.Rows[0]["Descr_E"].ToString();
                
                     
              
                txtMainGroup.ID.Text = dt3.Rows[0]["Main_Code"].ToString();
                txtPrice.Text = dt3.Rows[0]["Ton_Price"].ToString().ToDecimal().ToString("N0");

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            search_();
        }

        private void txtMainGroup_Load(object sender, EventArgs e)
        {
            get_code();
        }
    }
}
