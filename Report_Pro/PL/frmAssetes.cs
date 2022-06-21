using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmAssetes : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        string frmType = "A";
        public frmAssetes()
        {
            InitializeComponent();

            creatDattable();
        

            cobLocation.DataSource = dal.getDataTabl_1("SELECT * FROM LocationsTbl where BranchCode like '"+AccBranch.ID.Text+"%'");
            cobLocation.ValueMember = "id";
            cobLocation.DisplayMember = "Name";
            cobLocation.SelectedIndex = -1;

            cmbGroup.DataSource = dal.getDataTabl_1("SELECT * FROM AssetsGroup where isFinal = '1'");
            cmbGroup.ValueMember = "id";
            cmbGroup.DisplayMember = "Name";
            cmbGroup.SelectedIndex = -1;
            get_ser();
        }


        private void get_ser()
        {
            txtId.Text = (dal.getDataTabl_1("SELECT isnull(max(id+1),1) ,isnull(max(Code+1),1) FROM AssetsTbl")).Rows[0][0].ToString();
        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtId.Text!=string.Empty && txtCode.Text != string.Empty && txtName.Text!=string.Empty && cmbGroup.SelectedIndex>-1 &&
                txtAge.Value>0 && txtEndValue.Value>0 && txtPurchaseValue.Value>0 && cobLocation.SelectedIndex>-1)
            {
                dal.Execute_1(@"INSERT INTO AssetsTbl(Id, Code, Name, Name_L, GroupID, lastDepDate, Notes, assKinf, assOrigin, assSize, assColor
            , assModel, assStuds, assWeight, assLocation, assSerail, proCo, proCoAddres, proDate, SuppCo, ContractNo, ContractDate
            , PurchaseDate, receveDate, SuppCoAddres, Tel1, Tel2, Fax, Email, Web, ReceveNote, isStopDepris, assAge, assEndValue
            , assPurchValue, deprisStartDate, addValue, reductionValue, gReevaluation, lReevaluation, A_Deprecition, netValue
            , assAcc, depAcc, adepAcc, gsAcc, lsAcc, rgAcc, rlAcc,BranchCode) VALUES ('" + txtId.Text + "','" + txtCode.Text + "','" + txtName.Text + "','" + txtName_L.Text + "','" + Convert.ToString(cmbGroup.SelectedValue) +
            "','" + lastDepDat.Value.ToString("yyyy-MM-dd") + "','" + txtNote.Text + "','" + txtKind.Text + "','" + txtOrigin.Text + "','" + txtSize.Text + "','" + txtColor.Text +
            "','" + txtModel.Text + "','" + txtStuds.Text + "','" + txtWeight.Text + "','" + Convert.ToString(cobLocation.SelectedValue) + "','" + txtSearil.Text +
            "','" + txtproCo.Text + "','" + txtproCoAddres.Text+"','"+ proDate.Text + "','" + txtSuppCo.Text + "','" + txtContractNo.Text +
            "','" + ContractDate.Text + "','" + PurchaseDate.Text+ "','" + receveDate.Text + "','" + txtSuppCoAddres.Text + "','" + txtTel1.Text +
            "','" + txtTel2.Text + "','" + txtFax.Text + "','" + txtEmail.Text + "','" + txtWeb.Text + "','" + txtReceveNote.Text +
            "','" + chb1.Checked + "','" + txtAge.Value + "','" + txtEndValue.Value + "','" + txtPurchaseValue.Value + "','" + StartDate.Text +
            "','" + txtAddValue.Value + "','" + txtReductionValue.Value + "','" + txtGReevaluation.Value + "','" + txtLReevaluation.Value +
            "','" + A_Deprecition.Value + "','" + netValue.Value + "','" + txtAssAcc.ID.Text + "','" + txtDepAcc.ID.Text + "','" + txtADepAcc.ID.Text +
            "','" + txtGSAcc.ID.Text + "','" + txtLSAcc.ID.Text + "','" + txtRGAcc.ID.Text + "','" + txtRLAcc.ID.Text + "','"+ AccBranch.ID.Text+"')");
            }
            else
            {
                MessageBox.Show("تاكد من البيانات الاساسية");
            }
        }

        private void frmAssetes_Load(object sender, EventArgs e)
        {
            search_();
            Assign(this);
            get_ser();
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


        void cmb_SelectedIndexChanged(object sender, EventArgs e)
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



        private void search_()
        {
            DataTable dt_L = new DataTable();
            if (frmType == "A")
            {
                dt_L = dal.getDataTabl_1(@"SELECT A.id,A.Code,A.Name,A.Name_L,G.Name,G.Name_L,L.Name,L.Name_L  FROM AssetsTbl As A 
                inner join AssetsGroup As G on A.GroupID = G.Id
                inner join LocationsTbl As L on A.assLocation = L.Id ");
                            }
            else if (frmType == "S")
            {
                dt_L = dal.getDataTabl_1(@"SELECT A.id,A.Code,A.Name,A.Name_L,G.Name,G.Name_L,L.Name,L.Name_L  FROM AssetsTbl As A 
                inner join AssetsGroup As G on A.GroupID = G.Id
                inner join LocationsTbl As L on A.assLocation = L.Id
                where A.Id like '" + txtId.Text +"%'and A.Code like'" + txtCode.Text + "%' and A.Name like '%" + txtName.Text +
                "%' and A.Name_L like '%" + txtName_L.Text + "%' and A.GroupID like '" +
                  Convert.ToString(cmbGroup.SelectedValue) + "%' and A.assLocation like '" +
                  Convert.ToString(cobLocation.SelectedValue) + "%'  ");
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
            row[3] = dt_L.Rows[i][4].ToString();
            row[4] = dt_L.Rows[i][6].ToString();
            dt.Rows.Add(row);
                i = i + 1;
            }
            dgv.DataSource = dt;
            resizeDG();
        }

        void creatDattable()
        {
            dt.Columns.Add("الرقم");
            dt.Columns.Add(" الرمز ");
            dt.Columns.Add(" الاسم");
            dt.Columns.Add("المجموعة");
            dt.Columns.Add("الموقع");

        }


        void resizeDG()
        {

            dgv.Columns[0].Width = 50;
            dgv.Columns[1].Width = 50;
            dgv.Columns[2].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
           // dgv.Columns[3].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            dgv.Columns[3].Width = 200;
            dgv.Columns[4].Width = 200;
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

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

        private void txtFax_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX25_Click(object sender, EventArgs e)
        {

        }

        private void cobLocation_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_();
        }

        private void cmbGroup_SelectedIndexChanged(object sender, EventArgs e)
        {
            search_();
        }

        private void dgv_Click(object sender, EventArgs e)
        {
            DataTable dt_ass = dal.getDataTabl_1("SELECT *  FROM AssetsTbl where id='"+ dgv.CurrentRow.Cells[0].Value.ToString() + "'");
            if (dt_ass.Rows.Count > 0)
            {
                foreach (DataRow r in dt_ass.Rows)
                {
                    txtId.Text = r[0].ToString();
                    txtCode.Text = r[1].ToString();
                    txtName.Text = r[2].ToString();
                    txtName_L.Text = r[3].ToString();
                    cmbGroup.SelectedValue = r[4].ToString();
                    lastDepDat.Text = r[5].ToString();
                    txtNote.Text= r[6].ToString();
                    txtKind.Text = r[7].ToString();
                    txtOrigin.Text = r[8].ToString();
                    txtSize.Text= r[9].ToString();
                    txtColor.Text= r[10].ToString();
                    txtModel.Text= r[11].ToString();
                    txtStuds.Text= r[12].ToString();
                    txtWeight.Text= r[13].ToString();
                    cobLocation.SelectedValue= r[14].ToString();
                    txtSearil.Text= r[15].ToString();
                    txtproCo.Text= r[16].ToString();
                    txtproCoAddres.Text= r[17].ToString();
                    proDate.Text= r[18].ToString();
                    txtSuppCo.Text= r[19].ToString();
                    txtContractNo.Text= r[20].ToString();
                    ContractDate.Text = r[21].ToString();
                    PurchaseDate.Text = r[22].ToString();
                    receveDate.Text = r[23].ToString();

                    txtSuppCoAddres.Text = r[24].ToString();
                    txtTel1.Text = r[25].ToString();
                    txtTel2.Text = r[26].ToString();
                    txtFax.Text = r[27].ToString();
                    txtEmail.Text = r[28].ToString();
                    txtWeb.Text = r[29].ToString();
                    txtReceveNote.Text = r[30].ToString();
                    chb1.Checked =Convert.ToBoolean(r[31].ToString());
                    txtAge.Value = Convert.ToDouble(r[32].ToString());
                    txtEndValue.Value = Convert.ToDouble(r[33].ToString());
                    txtPurchaseValue.Value = Convert.ToDouble(r[34].ToString());
                    StartDate.Text = r[35].ToString();
                    txtAddValue.Value = Convert.ToDouble(r[36].ToString());
                    txtReductionValue.Value = Convert.ToDouble(r[37].ToString());
                    txtGReevaluation.Value = Convert.ToDouble(r[38].ToString());
                    txtLReevaluation.Value = Convert.ToDouble(r[39].ToString());
                    A_Deprecition.Value = Convert.ToDouble(r[40].ToString());
                    netValue.Value = Convert.ToDouble(r[41].ToString());
                    txtAssAcc.ID.Text = r[42].ToString();
                    txtDepAcc.ID.Text = r[43].ToString();
                    txtADepAcc.ID.Text = r[44].ToString();
                    txtGSAcc.ID.Text = r[45].ToString();
                    txtLSAcc.ID.Text = r[46].ToString();
                    txtRGAcc.ID.Text = r[47].ToString();
                    txtRLAcc.ID.Text = r[48].ToString();
                    AccBranch.ID.Text = r["BranchCode"].ToString();
                }
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            dal.Execute_1(@"update AssetsTbl set Id ='" + txtId.Text + "',Code = '" + txtCode.Text +
                "',Name = '" + txtName.Text + "',Name_L = '" + txtName_L.Text + "',GroupID = '" + Convert.ToString(cmbGroup.SelectedValue) +
                "',lastDepDate = '" + lastDepDat.Value.ToString("yyyy-MM-dd") + "',Notes = '" + txtNote.Text + "',assKinf = '" + txtKind.Text +
                "',assOrigin = '" + txtOrigin.Text + "',assSize = '" + txtSize.Text + "',assColor = '" + txtColor.Text +
                "',assModel = '" + txtModel.Text + "',assStuds = '" + txtStuds.Text + "',assWeight = '" + txtWeight.Text +
                "',assLocation = '" + Convert.ToString(cobLocation.SelectedValue) + "',assSerail = '" + txtSearil.Text + "',proCo = '" + txtproCo.Text +
                "',proCoAddres = '" + txtproCoAddres.Text + "',proDate = '" + proDate.Text + "',SuppCo = '" + txtSuppCo.Text +
                "',ContractNo = '" + txtContractNo.Text + "',ContractDate = '" + ContractDate.Text + "',PurchaseDate = '" + PurchaseDate.Text +
                "',receveDate = '" + receveDate.Text + "',SuppCoAddres = '" + txtSuppCoAddres.Text + "',Tel1 = '" + txtTel1.Text +
                "',Tel2 = '" + txtTel2.Text + "',Fax = '" + txtFax.Text + "',Email = '" + txtEmail.Text + "',Web = '" + txtWeb.Text +
                "',ReceveNote = '" + txtReceveNote.Text + "',isStopDepris = '" + chb1.Checked + "',assAge = '" + txtAge.Value +
                "',assEndValue = '" + txtEndValue.Value + "',assPurchValue = '" + txtPurchaseValue.Value + "',deprisStartDate = '" + StartDate.Text +
                "',addValue = '" + txtAddValue.Value + "',reductionValue = '" + txtReductionValue.Value + "',gReevaluation = '" + txtGReevaluation.Value +
                "',lReevaluation = '" + txtLReevaluation.Value + "',A_Deprecition = '" + A_Deprecition.Value + "',netValue = '" + netValue.Value +
                "',assAcc = '" + txtAssAcc.ID.Text + "',depAcc = '" + txtDepAcc.ID.Text + "',adepAcc = '" + txtADepAcc.ID.Text +
                "',gsAcc = '" + txtGSAcc.ID.Text + "',lsAcc = '" + txtLSAcc.ID.Text + "',rgAcc = '" + txtRGAcc.ID.Text + "',rlAcc = '" + 
                txtRLAcc.ID.Text + "',BranchCode='"+AccBranch.ID.Text+"'  where Id ='" + txtId.Text + "' ");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void AccBranch_Load(object sender, EventArgs e)
        {
            cobLocation.DataSource = dal.getDataTabl_1("SELECT * FROM LocationsTbl where BranchCode like'" + AccBranch.ID.Text + "%'");
            cobLocation.ValueMember = "id";
            cobLocation.DisplayMember = "Name";
           
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {

        }
    }
}
