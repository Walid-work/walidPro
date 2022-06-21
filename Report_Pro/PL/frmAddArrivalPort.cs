using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmAddArrivalPort : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        string frmType = "input";
        string saveType = "add";

        public frmAddArrivalPort()
        {
            InitializeComponent();
            creatDattable();
            dgv_1.EnableHeadersVisualStyles = false;
            resizeDG();
            fillDG();
        }

        void creatDattable()
        {
            dt.Columns.Add("الكود");
            dt.Columns.Add("الوصف");
            dt.Columns.Add("الوصف لاتيني");
            dgv_1.DataSource = dt;
        }
        void resizeDG()
        {
            dgv_1.Columns[0].Width = 80;
            dgv_1.Columns[1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv_1.Columns[2].Width = 300;
        }

        private void btnNew_Click(object sender, EventArgs e)
        {
            frmType = "input";
            saveType = "add";
            btnSave.Text = "حفظ";
            fillDG();
            btnSave.Enabled = true;
            txtCode.BackColor = Color.White;
            txtDesc.BackColor = Color.White;
            txtDesc_L.BackColor = Color.White;
            txtCode.Clear();
            txtDesc.Clear();
            txtDesc_L.Clear();
            txtCode.Focus();
            txtCode.Enabled = true;
        }

        private void frmAddPaymentTearms_Load(object sender, EventArgs e)
        {

        }

        private void SearchDG()
        {
            DataTable dt_ = dal.getDataTabl_1("select * from Cus_Ports where Port_code like '%" + txtCode.Text + "%' and Port_name like '%" + txtDesc.Text + "%' and Port_E_name like '%" + txtDesc_L.Text + "%'");
            dt.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_.Rows)
            {

                row = dt.NewRow();
                row[0] = dt_.Rows[i][0];
                row[1] = dt_.Rows[i][1];
                dt.Rows.Add(row);
                i = i + 1;
            }
            dgv_1.DataSource = dt;

        }

        private void fillDG()
        {
            DataTable dt_ = dal.getDataTabl_1("select * from  Cus_Ports");
            dt.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_.Rows)
            {

                row = dt.NewRow();
                row[0] = dt_.Rows[i][0];
                row[1] = dt_.Rows[i][1];
                row[2] = dt_.Rows[i][2];
                dt.Rows.Add(row);
                row[2] = dt_.Rows[i][2];
                i = i + 1;
            }
            dgv_1.DataSource = dt;

        }


        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmType = "search";
            txtCode.Enabled = true;
            btnSave.Enabled = false;
            txtCode.Clear();
            txtDesc.Clear();
            txtDesc_L.Clear();
            txtCode.BackColor = Color.Bisque;
            txtDesc.BackColor = Color.Bisque;
            txtDesc_L.BackColor = Color.Bisque;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtCode.Text != string.Empty && txtDesc.Text != string.Empty)
                if (saveType == "add")
                {
                    {
                        dal.Execute_1("insert into  Cus_Ports values('" + txtCode.Text + "','" + txtDesc.Text + "','" + txtDesc_L.Text + "')");
                        MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        fillDG();
                    }
                }
                else
                {
                    dal.Execute_1("update  Cus_Ports set Port_name ='" + txtDesc.Text + "',Port_E_name ='" + txtDesc_L.Text + "' where Port_code = '" + txtCode.Text + "'");
                    MessageBox.Show("تم تعديل البيانات بنجاح", "تاكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    fillDG();
                }
            else { MessageBox.Show("تأكد من البيانات"); }
        }

        private void txtCode_KeyUp(object sender, KeyEventArgs e)
        {
            if (frmType == "search")
            {
                SearchDG();
            }
        }

        private void txtDesc_KeyUp(object sender, KeyEventArgs e)
        {
            if (frmType == "search")
            {
                SearchDG();
            }
        }

        private void txtDesc_L_KeyUp(object sender, KeyEventArgs e)
        {
            if (frmType == "search")
            {
                SearchDG();
            }
        }

        private void dgv_1_DoubleClick(object sender, EventArgs e)
        {
            frmType = "input";
            saveType = "edit";
            btnSave.Text = "تعديل";
            btnSave.Enabled = true;
            txtCode.BackColor = Color.White;
            txtDesc.BackColor = Color.White;
            txtDesc_L.BackColor = Color.White;

            txtCode.Text = dgv_1.CurrentRow.Cells[0].Value.ToString();
            txtDesc.Text = dgv_1.CurrentRow.Cells[1].Value.ToString();
            txtDesc_L.Text = dgv_1.CurrentRow.Cells[2].Value.ToString();

            //fillDG();
            txtCode.Enabled = false;
        }
    }
}
