using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmLocations : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        string frmType = "A";

        public frmLocations()
        {
            InitializeComponent();
            creatDattable();
          
        }

        private void Branch_Load(object sender, EventArgs e)
        {

        }

        private void frmLocations_Load(object sender, EventArgs e)
        {
            search_();
            Assign(this);
            get_ser();

        }

        private void get_ser()
        {
        txtId.Text = (dal.getDataTabl_1("SELECT max(id+1) ,max(Code+1) FROM LocationsTbl")).Rows[0][0].ToString();
        }

        private void search_()
        {
            DataTable dt_L = new DataTable();
            if (frmType == "A") {
                dt_L = dal.getDataTabl_1("select L.*,B.BRANCH_name from LocationsTbl as L inner join " + dal.db1 + ".dbo.BRANCHS as B On L.BranchCode=B.branch_Code ");
            }
            else if (frmType == "S")
            {
                dt_L = dal.getDataTabl_1("select L.*,B.BRANCH_name from LocationsTbl as L inner join " + dal.db1 + ".dbo.BRANCHS as B On L.BranchCode=B.branch_Code where Id like '" + txtId.Text +
                   "%'and Code like'" + txtCode.Text + "%' and Name like '%" + txtName.Text +
                   "%' and Name_L like '%" + txtName_L.Text + "%' and BranchCode like '" +
                   Branch.ID.Text + "%' and L.Notes like '%" + txtNotes.Text + "%'");
            }
            dt.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt_L.Rows)
            {

                row = dt.NewRow();
                row[0] = dt_L.Rows[i][0].ToString();
                row[1] = dt_L.Rows[i][1].ToString();
                row[2] = dt_L.Rows[i][2].ToString();
                row[3] = dt_L.Rows[i][3].ToString();
                row[4] = dt_L.Rows[i][4].ToString();
                row[5] = dt_L.Rows[i][5].ToString();
                row[6] = dt_L.Rows[i][6].ToString();
                dt.Rows.Add(row);
                i = i + 1;
            }
            dgv.DataSource = dt;
            resizeDG();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
           
            dal.Execute_1("INSERT INTO LocationsTbl(Id,Code,Name,Name_L,BranchCode,Notes) VALUES('"+txtId.Text+ 
                "','" + txtCode.Text + "','" + txtName.Text + "','" + txtName_L.Text + "','" + Branch.ID.Text + 
                "','" + txtNotes.Text + "')");
            MessageBox.Show("تم الحفظ بنجاح", "تاكيد الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            search_();
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dal.Execute_1("Update LocationsTbl set Id='" + txtId.Text +
               "',Code='" + txtCode.Text + "',Name='" + txtName.Text + "',Name_L='" + txtName_L.Text + "',BranchCode='" + Branch.ID.Text +
               "',Notes='" + txtNotes.Text + "' where Id='" + txtId.Text + "'");
            MessageBox.Show("تم التعديل بنجاح", "تاكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            search_();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        void creatDattable()
        {
            dt.Columns.Add("الرقم");
            dt.Columns.Add(" الرمز ");
            dt.Columns.Add(" الاسم");
            dt.Columns.Add("الاسم لاتيني");
            dt.Columns.Add(" كود الفرع");
            dt.Columns.Add("ملاحظات");
            dt.Columns.Add("الفرع");
        }
        void resizeDG()
        {

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 50;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[6].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;
            // dgv.Columns[5].Visible = false;
            //dgv.Columns[3].Width = this.txtUnit.Width;
        }

        



        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmType = "S";
            txtId.Enabled = true;
            btnSave.Enabled = false;
            btnEdit.Enabled = true;
            ClearTextBoxes();
           

            foreach (Control c in this.Controls)
            {
                UpdateColorControls(c);
            }
        }


        //================ كود تفريغ الحقول =====================

        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();

                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;
                    else if (control is DevComponents.DotNetBar.Controls.ComboBoxEx)
                        (control as DevComponents.DotNetBar.Controls.ComboBoxEx).SelectedIndex = -1;
                    else if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    else
                        func(control.Controls);
            };
            func(Controls);


        }

        //================ كود توحيد الامر في كل خانات النص =====================
        void tb_TextChanged(object sender, EventArgs e)
        {
            if (frmType == "S")
            {
                search_();
            }
        }

        void Assign(Control control)
        {
            foreach (Control ctrl in control.Controls)
            {
                if (ctrl is TextBox)
                {

                    TextBox tb = (TextBox)ctrl;
                    tb.TextChanged += new EventHandler(tb_TextChanged);

                }
                else
                {
                    Assign(ctrl);
                }
            }
        }
        //===========================================================================

      

        private void btnNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            btnEdit.Enabled = false;
            btnSave.Enabled = true;
            frmType = "A";
            txtCode.Focus();
            foreach (Control c in this.Controls)
            {
                UpdateColorControls(c);
            }
            get_ser();
            txtId.Enabled = false;


        }




        public void UpdateColorControls(Control myControl)
    {
            
            if (myControl is TextBox)
            {
                if (frmType == "A")
                {
                    myControl.BackColor = Color.White;
                }
                else
                     if (frmType == "S")
                {
                    myControl.BackColor = Color.Bisque;
                }
            }
            //myControl.ForeColor = Color.White;
            foreach (Control subC in myControl.Controls)
        {
            UpdateColorControls(subC);
        }
    }

        //--------------- كود جعل مفتاح الادخال مثل مفتاح التاب --------------------

        private void frmLocations_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void dgv_DoubleClick(object sender, EventArgs e)
        {
           
        }

        private void dgv_Click(object sender, EventArgs e)
        {
           
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dgv_Click_1(object sender, EventArgs e)
        {
            
                try
                {
                    frmType = "A";
                    txtId.Enabled = false;
                    btnSave.Enabled = false;
                    btnEdit.Enabled = true;
                    ClearTextBoxes();

                    foreach (Control c in this.Controls)
                    {
                        UpdateColorControls(c);
                    }


                    txtId.Text = dgv.CurrentRow.Cells[0].Value.ToString();
                    txtCode.Text = dgv.CurrentRow.Cells[1].Value.ToString();
                    txtName.Text = dgv.CurrentRow.Cells[2].Value.ToString();
                    txtName_L.Text = dgv.CurrentRow.Cells[3].Value.ToString();
                    Branch.ID.Text = dgv.CurrentRow.Cells[4].Value.ToString();
                    txtNotes.Text = dgv.CurrentRow.Cells[5].Value.ToString();

                    search_();
                }
                catch (Exception ex) { MessageBox.Show(ex.Message); }
           
        }
    }
}
