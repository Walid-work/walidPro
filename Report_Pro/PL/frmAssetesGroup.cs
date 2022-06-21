using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmAssetesGroup : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        string frmType = "A";
        public frmAssetesGroup()
        {
            InitializeComponent();
            creatDattable();

            cmbMainGroup.DataSource = dal.getDataTabl_1("select * from AssetsGroup where isFinal = 0 ");
            cmbMainGroup.ValueMember = "id";
            cmbMainGroup.DisplayMember = "Name";
            cmbMainGroup.SelectedIndex = -1;
        }


        void creatDattable()
        {
            dt.Columns.Add("الرقم");
            dt.Columns.Add(" الرمز ");
            dt.Columns.Add(" الاسم");
            dt.Columns.Add("الاسم لاتيني");
            dt.Columns.Add(" كودالمجموعة الرئيسية");
            dt.Columns.Add("ملاحظات");
            dt.Columns.Add("AssetAcc");
            dt.Columns.Add("Deprec_Acc");
            dt.Columns.Add("A_Deprec_Acc");
            dt.Columns.Add("G_Sales_Acc");
            dt.Columns.Add("L_Sales_Acc");
            dt.Columns.Add("RG_Acc");
            dt.Columns.Add("RL_Acc");
            dt.Columns.Add("نوع المجموعة");
            dt.Columns.Add("المجموعة الرئسية");
            dt.Columns.Add("المجموعة الرئسية لاتيني");
            
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

       

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmAssetesGroup_Load(object sender, EventArgs e)
        {
            search_();
            Assign(this);
            get_ser();
        }

        private void frmAssetesGroup_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        void resizeDG()
        {

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 50;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[5].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[14].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[3].Visible = false;
            dgv.Columns[4].Visible = false;
            dgv.Columns[6].Visible = false;
            dgv.Columns[7].Visible = false;
            dgv.Columns[8].Visible = false;
            dgv.Columns[9].Visible = false;
            dgv.Columns[10].Visible = false;
            dgv.Columns[11].Visible = false;
            dgv.Columns[12].Visible = false;
            dgv.Columns[13].Visible = false;
            dgv.Columns[15].Visible = false;
        }
            private void get_ser()
        {
            txtId.Text = (dal.getDataTabl_1("SELECT isnull(max(id+1),1) ,isnull(max(Code+1),1) FROM AssetsGroup")).Rows[0][0].ToString();
        }

        private void search_()
        {
            DataTable dt_L = new DataTable();
            if (frmType == "A")
            {
                dt_L = dal.getDataTabl_1("select G.* ,MG.Name as MName ,MG.Name_L as MName_L  from AssetsGroup as G inner join AssetsGroup as MG On G.id=MG.id ");
            }
            else if (frmType == "S")
            {
                dt_L = dal.getDataTabl_1("select G.* ,MG.Name as MName ,MG.Name_L as MName_L  from AssetsGroup as G inner join AssetsGroup as MG On G.id=MG.id  where G.Id like '" + txtId.Text +
                   "%'and G.Code like'" + txtCode.Text + "%' and G.Name like '%" + txtName.Text +
                   "%' and G.Name_L like '%" + txtName_L.Text + "%' and G.MainId like '" +
                  Convert.ToString(cmbMainGroup.SelectedValue) + "%' and G.Notes like '%" + txtNotes.Text + "%'");
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
                row[7] = dt_L.Rows[i][7].ToString();
                row[8] = dt_L.Rows[i][8].ToString();
                row[9] = dt_L.Rows[i][9].ToString();
                row[10] = dt_L.Rows[i][10].ToString();
                row[11] = dt_L.Rows[i][11].ToString();
                row[12] = dt_L.Rows[i][12].ToString();
                row[13] = dt_L.Rows[i][13].ToString();
                row[14] = dt_L.Rows[i][14].ToString();
                row[15] = dt_L.Rows[i][15].ToString();
                dt.Rows.Add(row);
                i = i + 1;
            }
            dgv.DataSource = dt;
            resizeDG();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            try {
                if (txtId.Text != string.Empty && txtCode.Text != string.Empty && txtName.Text != string.Empty )
                {
                   if( cmbMainGroup.SelectedIndex ==-1 && radioTransaction.Checked==true)
                    {
                        MessageBox.Show("تاكد من المجموعة الرئيسية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }
                    string isFinal_ = radioParent.Checked ? "0" : "1";
                    
                    dal.Execute_1(@" INSERT INTO AssetsGroup(Id, Code, Name, Name_L, MainId, 
                    Notes, AssetAcc, Deprec_Acc, A_Deprec_Acc, G_Sales_Acc, L_Sales_Acc, RG_Acc, RL_Acc,isFinal)
                    VALUES('" + txtId.Text + "','" + txtCode.Text + "','" + txtName.Text + "','" +
                    txtName_L.Text + "','" + cmbMainGroup.SelectedValue + "','" + txtNotes.Text +
                    "','" + txtAssAcc.ID.Text + "','" + txtDepAcc.ID.Text + "','" + txtADepAcc.ID.Text +
                    "','" + txtGSAcc.ID.Text + "','" + txtLSAcc.ID.Text + "','" + txtRGAcc.ID.Text +
                    "','" + txtRLAcc.ID.Text + "','"+isFinal_+"')");

                    MessageBox.Show("تم الحفظ بنجاح", "تاكيد الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else { MessageBox.Show("تاكد من البيانات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch(Exception ex)
            {
                                 MessageBox.Show(ex.Message); 
            }
        }

        private void dgv_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_Click(object sender, EventArgs e)
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
                cmbMainGroup.SelectedValue = dgv.CurrentRow.Cells[4].Value.ToString();
                txtNotes.Text = dgv.CurrentRow.Cells[5].Value.ToString();
                txtAssAcc.ID.Text = dgv.CurrentRow.Cells[6].Value.ToString();
                txtDepAcc.ID.Text = dgv.CurrentRow.Cells[7].Value.ToString();
                txtADepAcc.ID.Text = dgv.CurrentRow.Cells[8].Value.ToString();
                txtGSAcc.ID.Text = dgv.CurrentRow.Cells[9].Value.ToString();
                txtLSAcc.ID.Text = dgv.CurrentRow.Cells[10].Value.ToString();
                txtRGAcc.ID.Text = dgv.CurrentRow.Cells[11].Value.ToString();
                txtRLAcc.ID.Text = dgv.CurrentRow.Cells[12].Value.ToString();
                if (dgv.CurrentRow.Cells[13].Value.ToString() == "0") { radioParent.Checked = true; } else { radioTransaction.Checked = true; }

                search_();
            }
            catch (Exception ex) { MessageBox.Show(ex.Message); }

        }

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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtId.Text != string.Empty && txtCode.Text != string.Empty && txtName.Text != string.Empty && cmbMainGroup.SelectedIndex > -1)
                {
                    string isFinal_ = radioParent.Checked ? "0" : "1";

                    dal.Execute_1(@" Update AssetsGroup set Id='" + txtId.Text + "',Code='" + txtCode.Text + "',Name='" + txtName.Text + "',Name_L='" +
                    txtName_L.Text + "',MainId='" + cmbMainGroup.SelectedValue + "',Notes='" + txtNotes.Text +
                    "',AssetAcc='" + txtAssAcc.ID.Text + "',Deprec_Acc='" + txtDepAcc.ID.Text + "',A_Deprec_Acc='" + txtADepAcc.ID.Text +
                    "',G_Sales_Acc='" + txtGSAcc.ID.Text + "',L_Sales_Acc='" + txtLSAcc.ID.Text + "',RG_Acc='" + txtRGAcc.ID.Text +
                    "',RL_Acc='" + txtRLAcc.ID.Text + "',isFinal='" + isFinal_ + "' where Id='" + txtId.Text + "'");

                    MessageBox.Show("تم التعديل بنجاح", "تاكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else { MessageBox.Show("تاكد من البيانات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error); }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
