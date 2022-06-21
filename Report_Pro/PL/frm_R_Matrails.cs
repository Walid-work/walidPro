using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

using Outlook = Microsoft.Office.Interop.Outlook;
using System.Runtime.InteropServices;
using System.Diagnostics;
using System.Reflection;
using System.Resources;

namespace Report_Pro.PL
{
    public partial class frm_R_Matrails : frm_Master
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        Int32 m;

        public string clos_type;
        string btntype = "0";
        string frmType="ADD";

        public frm_R_Matrails()
        {
            InitializeComponent();
           
            creatDattable();
            //resizeDG();
            getJorSer();

            
        }

        private void tabControlPanel2_Click(object sender, EventArgs e)
        {

        }

        private void dGV_Item_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btn_braws_Click(object sender, EventArgs e)
        {
            try
            {
                clear_txtBoxs();
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                this.TxtId.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                if (Properties.Settings.Default.lungh == "0")
                {
                    this.TxtDesc.Text = frm.dGV_pro_list.CurrentRow.Cells[2].Value.ToString();
                }
                else
                {
                    this.TxtDesc.Text = frm.dGV_pro_list.CurrentRow.Cells[3].Value.ToString();
                }
                this.txtUnit.Text = frm.dGV_pro_list.CurrentRow.Cells[6].Value.ToString();
                this.txtUnitWeight.Text = frm.dGV_pro_list.CurrentRow.Cells[4].Value.ToString().ToDecimal().ToString("n3");
                this.txtBalance.Text = frm.dGV_pro_list.CurrentRow.Cells[5].Value.ToString().ToDecimal().ToString("n1");
                //this.txtBalance.Text = (dal.getDataTabl("get_item_balance_", TxtId.Text, "", "0", dal.db1)).Rows[0][0].ToString().ToDecimal().ToString("n2");

                txtNote.Focus();
            }
            catch
            {
                return;
            }
        }

      

        void clear_texts()
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
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;

                    else
                        func(control.Controls);
            };

            func(Controls);
            dt.Clear();
            dGV_Item.DataSource = null;

        }

        void clear_txtBoxs()
        {
            TxtId.Clear();
            TxtDesc.Clear();
            txtNote.Clear();
            txtUnit.SelectedIndex = -1;
            txtUnitWeight.Clear();
            TxtQty.Text = "0".ToString().ToDecimal().ToString("n2");
            txtBalance.Clear();
            txt_TotWeight.Clear();

        }

            private void get_B_C()
        {
          
          
                DataTable dt_B_c = new DataTable();
                dt_B_c = dal.getDataTabl("getBalnceAndCost_", TxtId.Text, Uc_Branch.ID.Text,dal.db1);
            if (dt_B_c.Rows.Count > 0)
            {
                txtBalance.Text = dt_B_c.Rows[0][0].ToString().ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
            }
           else
            {
                txtBalance.Text = "0".ToDecimal().ToString("N" + Properties.Settings.Default.digitNo_);
            }                
                    
             
          
        }

        void clculat_amount()
        {
            try
            {
               txt_TotWeight.Text = (TxtQty.Text.ToDecimal() * txtUnitWeight.Text.ToDecimal()).ToString("N" + dal.digits_);
               
            }
            catch
            {
                return;
            }
        }


        void resizeDG()
        {

            this.dGV_Item.Columns[0].Width = this.TxtId.Width;
            this.dGV_Item.Columns[1].Width = this.TxtDesc.Width;
            this.dGV_Item.Columns[2].Width = this.txtNote.Width;
            this.dGV_Item.Columns[3].Width = this.txtUnit.Width;
            this.dGV_Item.Columns[4].Width = this.txtUnitWeight.Width;
            this.dGV_Item.Columns[5].Width = this.TxtQty.Width;
            this.dGV_Item.Columns[6].Width = this.txtBalance.Width;
            this.dGV_Item.Columns[7].Width = this.txt_TotWeight.Width;
            foreach (DataGridViewRow row in this.dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                dGV_Item.EnableHeadersVisualStyles = false;


            }
        }
            void addrow_new()
        {
            DataRow r = dt.NewRow();
            r[0] = TxtId.Text;
            r[1] = TxtDesc.Text;
            r[2] = txtNote.Text;
            r[3] = txtUnit.Text;
            r[4] = txtUnitWeight.Text.ToDecimal().ToString("N3");
            r[5] = TxtQty.Text.ToDecimal().ToString("N0");
            r[6] = txtBalance.Text.ToDecimal().ToString("N1");
            r[7] = txt_TotWeight.Text.ToDecimal().ToString("N3");


            dt.Rows.Add(r);
            dGV_Item.DataSource = dt;
            clear_txtBoxs();
            TxtId.Focus();
            total_inv();
            resizeDG();
        }

        void editrow()
        {
            dGV_Item.Rows[m].Cells[0].Value = TxtId.Text;
            dGV_Item.Rows[m].Cells[1].Value = TxtDesc.Text;
            dGV_Item.Rows[m].Cells[2].Value = txtNote.Text;
            dGV_Item.Rows[m].Cells[3].Value = txtUnit.Text;
            dGV_Item.Rows[m].Cells[4].Value = txtUnitWeight.Text.ToDecimal().ToString("N3");
            dGV_Item.Rows[m].Cells[5].Value = TxtQty.Text.ToDecimal().ToString("N0");
            dGV_Item.Rows[m].Cells[6].Value = txtBalance.Text.ToDecimal().ToString("N1");
            dGV_Item.Rows[m].Cells[7].Value = txt_TotWeight.Text.ToDecimal().ToString("N3"); 
            

            total_inv();
            clear_txtBoxs();
            TxtId.Focus();
            resizeDG();

        }


        void creatDattable()
        {
           
                dt.Columns.Add("رقم الصنف");
                dt.Columns.Add(" اسم الصنف");
                dt.Columns.Add(" الوصف");
                dt.Columns.Add("الوحدة");
                dt.Columns.Add(" الوزن");
                dt.Columns.Add("الكمية");
                dt.Columns.Add("الرصيد");
                dt.Columns.Add("اجمالي الوزن");
                dGV_Item.DataSource = dt;
          
        }

        private void total_inv()
        {

            totalQty.Text =
                (from DataGridViewRow row in dGV_Item.Rows
                 where row.Cells[5].FormattedValue.ToString() != string.Empty
                 select Convert.ToDouble(row.Cells[5].FormattedValue)).Sum().ToString().ToDecimal().ToString("N0");
            totalWeight.Text =
                  (from DataGridViewRow row in dGV_Item.Rows
                   where row.Cells[7].FormattedValue.ToString() != string.Empty
                   select Convert.ToDouble(row.Cells[7].FormattedValue)).Sum().ToString().ToDecimal().ToString("N3");
        }

        private void TxtQty_KeyUp(object sender, KeyEventArgs e)
        {
            clculat_amount();
        }

        private void TxtQty_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtId.Text!="" && TxtDesc.Text!="" &&TxtQty.Value>0)
            {
                clculat_amount();

                if (btntype == "0")
                {
                    for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
                    {
                        if (dGV_Item.Rows[i].Cells[0].Value.ToString() == TxtId.Text)
                        {
                            MessageBox.Show("هذا الصنف مضاف من قبل", "تنبية !!", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                            return;
                        }
                    }
                    addrow_new();
                    btntype = "0";

                }
                else if (btntype == "1")
                {
                    editrow();
                    btntype = "0";

                }

            }
        }

        private void dGV_Item_DoubleClick(object sender, EventArgs e)
        {

            btntype = "1";
            m = dGV_Item.CurrentRow.Index;
            try
            {
               // DataTable itemdata_ = dal.getDataTabl("get_product_name", dGV_Item.CurrentRow.Cells[0].Value.ToString(), Properties.Settings.Default.CoId);
                TxtId.Text = dGV_Item.CurrentRow.Cells[0].Value.ToString();
                TxtDesc.Text = dGV_Item.CurrentRow.Cells[1].Value.ToString();
                txtNote.Text = dGV_Item.CurrentRow.Cells[2].Value.ToString();
                txtUnit.Text = dGV_Item.CurrentRow.Cells[3].Value.ToString();
                txtUnitWeight.Text = dGV_Item.CurrentRow.Cells[4].Value.ToString();
                TxtQty.Text = dGV_Item.CurrentRow.Cells[5].Value.ToString();
                txtBalance.Text = dGV_Item.CurrentRow.Cells[6].Value.ToString();
                txt_TotWeight.Text = dGV_Item.CurrentRow.Cells[7].Value.ToString();
                TxtId.Focus();
              
            }
            catch
            {
                return;
            }
        }

        private void TxtId_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && TxtId.Text!="")
            {
                DataTable dt = dal.getDataTabl("get_product_name_", TxtId.Text,dal.db1);
                if (dt.Rows.Count > 0)
                {
                    TxtId.Text = dt.Rows[0][0].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        TxtDesc.Text = dt.Rows[0][2].ToString();
                    }
                    else
                    {
                        TxtDesc.Text = dt.Rows[0][3].ToString();
                    }
                    txtUnitWeight.Text = dt.Rows[0][4].ToString().ToDecimal().ToString("N3");
                    txtUnit.Text = dt.Rows[0][5].ToString();
                    txtBalance.Text = dt.Rows[0][6].ToString().ToDecimal().ToString("N1");
                   
                   
                    txtNote.Focus();


                }
                else
                {
                    btn_braws.PerformClick();
                }


            }
        }

        private void txtNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtUnit.Focus();
            }
        }

        private void groupPanel7_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel6_Click(object sender, EventArgs e)
        {

        }

        private void Uc_Branch_Load(object sender, EventArgs e)
        {
            uc_Supplier1.branchID.Text = Uc_Branch.ID.Text;
            if (frmType == "ADD")
            {
                DataTable dt_br = dal.getDataTabl("Get_branch_Name_", Uc_Branch.ID.Text, dal.db1);

                if (dt_br.Rows.Count > 0)
                {
                    txt_Tel.Text = dt_br.Rows[0][21].ToString();
                    txt_Fax.Text = dt_br.Rows[0][22].ToString();
                    txtMobile.Text = "";
                    txtE_Fax.Text = "";
                    txt_Email.Text = dt_br.Rows[0][23].ToString();
                    txt_address.Text = dt_br.Rows[0][6].ToString();
                    txt_MainNote.Text = dt_br.Rows[0][28].ToString();
                    getJorSer();
                }
            }
        }

        private void getJorSer()
        {
            string serNo = dal.getDataTabl_1("select isnull(max(ser_no)+1,1) FROM " + dal.db1 + ".dbo.R_Qutation where Transaction_code='" + txt_transaction_code.Text+ "' and Branch_code ='"+ Uc_Branch.ID.Text+"' ").Rows[0][0].ToString();
            txt_serNo.Text = serNo;


        }

        private void BNew_Click(object sender, EventArgs e)
        {
            clear_texts();
            getJorSer();
            Uc_Branch.ID.Text = Properties.Settings.Default.BranchId;
            BSave.Enabled = true;
            BEdit.Enabled = false;
        }

        private void Btn_DelRow_Click(object sender, EventArgs e)
        {
            if (this.dGV_Item.SelectedRows.Count > 0)
            {
                dGV_Item.Rows.RemoveAt(this.dGV_Item.SelectedRows[0].Index);
                total_inv();
                foreach (DataGridViewRow row in this.dGV_Item.Rows)
                {
                    row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                }
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            Assembly a = Assembly.Load("Report_Pro");
            ResourceManager rm = new ResourceManager("Report_Pro.RPT.login_frm", a);
       
            if (Uc_Branch.ID.Text == string.Empty)
            {
                MessageBox.Show(rm.GetString("txtMes"), rm.GetString("MesH"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dGV_Item.Rows.Count<1)
            {
                MessageBox.Show(rm.GetString("txtMes"), rm.GetString("MesH"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            test_Add_R_Qutation_Transaction();
            Add_R_Qutation();
            Add_R_Qutation_Transaction();
            MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BSave.Enabled = false;
        }

        private void Add_R_Qutation()
        {
            //if (Spacil_Chb.Checked==true)

            dal.Execute("Add_R_Qutation_",txt_serNo.Text,Uc_Branch.ID.Text,txt_transaction_code.Text,
            txt_InvDate.Value.Date.ToString("yy"), txt_InvDate.Value.Date,txt_Tel.Text,txt_Fax.Text,
            txt_Email.Text,txtMobile.Text,txtE_Fax.Text,txt_address.Text,txt_MainNote.Text,"",
            uc_Supplier1.ID.Text,supp_address.Text, supp_tel.Text, supp_fax.Text, supp_Email.Text,Spacil_Chb.Checked,dal.db1);
        }

        private void test_Add_R_Qutation()
        {

            dal.Execute_test("Add_R_Qutation_", txt_serNo.Text, Uc_Branch.ID.Text, txt_transaction_code.Text,
            txt_InvDate.Value.Date.ToString("yy"), txt_InvDate.Value.Date, txt_Tel.Text, txt_Fax.Text,
            txt_Email.Text, txtMobile.Text, txtE_Fax.Text, txt_address.Text, txt_MainNote.Text, "", 
            uc_Supplier1.ID.Text, supp_address.Text, supp_tel.Text, supp_fax.Text, supp_Email.Text, Spacil_Chb.Checked, dal.db1);
        }


        private void Add_R_Qutation_Transaction()
        {
            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                if (dGV_Item.Rows[i].Cells[0].Value != null && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0)
                    dal.Execute("Add_R_Qutation_Transaction_", txt_serNo.Text, Uc_Branch.ID.Text, txt_transaction_code.Text,
                    txt_InvDate.Value.Date.ToString("yy"), txt_InvDate.Value.Date, dGV_Item.Rows[i].Cells[0].Value, 
                    dGV_Item.Rows[i].Cells[2].Value, dGV_Item.Rows[i].Cells[3].Value, dGV_Item.Rows[i].Cells[4].Value, 
                    dGV_Item.Rows[i].Cells[5].Value, dGV_Item.Rows[i].Cells[6].Value, dGV_Item.Rows[i].Cells[7].Value, dal.db1);
            }
        }

        private void test_Add_R_Qutation_Transaction()
        {
            for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
            {
                if (dGV_Item.Rows[i].Cells[0].Value != null && dGV_Item.Rows[i].Cells[5].Value.ToString().ToDecimal() > 0)
                    dal.Execute_test("Add_R_Qutation_Transaction_", txt_serNo.Text, Uc_Branch.ID.Text, txt_transaction_code.Text,
                    txt_InvDate.Value.Date.ToString("yy"), txt_InvDate.Value.Date, dGV_Item.Rows[i].Cells[0].Value,
                    dGV_Item.Rows[i].Cells[2].Value, dGV_Item.Rows[i].Cells[3].Value, dGV_Item.Rows[i].Cells[4].Value,
                    dGV_Item.Rows[i].Cells[5].Value, dGV_Item.Rows[i].Cells[6].Value, dGV_Item.Rows[i].Cells[7].Value, dal.db1);
            }
        }


        private void BSearch_Click(object sender, EventArgs e)
        {

            groupPanel1.Visible = true;
            txtSearch.Focus();
          
        }

        private void tabControl1_Click(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            frmType = "EDIT";
            
            DataTable dt_RQ = dal.getDataTabl_1(@"SELECT A.*,b.*,m.descr,m.Descr_eng,m.Weight,m.Unit,Br.branch_name,Br.WH_E_NAME,
            p.PAYER_NAME,p.payer_l_name FROM " + dal.db1 + ".dbo.R_Qutation As A " +
            "inner join  " + dal.db1 + ".dbo.R_Qutation_Transaction As B" +
            " on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO " +
            "inner join  " + dal.db1 + ".dbo.wh_main_master as M on m.item_no = b.ITEM_NO " +
            "inner join  " + dal.db1 + ".dbo.wh_BRANCHES as Br on Br.Branch_code = a.Branch_code " +
            "inner join  " + dal.db1 + ".dbo.payer2 as P on P.acc_no = a.acc_no and p.branch_code = a.branch_code " +
            "where A.ser_no = '" + txtSearch.Text + "' and a.Transaction_code = '" + txt_transaction_code.Text + "'");
            if (dt_RQ.Rows.Count > 0)
            {

                txt_serNo.Text = dt_RQ.Rows[0][0].ToString();
                Uc_Branch.ID.Text = dt_RQ.Rows[0][1].ToString();
                txt_InvDate.Text = dt_RQ.Rows[0][4].ToString();
                txt_Tel.Text = dt_RQ.Rows[0][5].ToString();
                txt_Fax.Text = dt_RQ.Rows[0][6].ToString();
                txt_Email.Text = dt_RQ.Rows[0][7].ToString();
                txtMobile.Text = dt_RQ.Rows[0][8].ToString();
                txtE_Fax.Text = dt_RQ.Rows[0][9].ToString();
                txt_address.Text = dt_RQ.Rows[0][10].ToString();
                txt_MainNote.Text = dt_RQ.Rows[0][11].ToString();
                txtNote.Text = dt_RQ.Rows[0][12].ToString();
                uc_Supplier1.ID.Text = dt_RQ.Rows[0][13].ToString();
                supp_address.Text = dt_RQ.Rows[0][14].ToString();
                supp_tel.Text = dt_RQ.Rows[0][15].ToString();
                supp_fax.Text = dt_RQ.Rows[0][16].ToString();
                supp_Email.Text = dt_RQ.Rows[0][17].ToString();
                if (string.IsNullOrEmpty(dt_RQ.Rows[0][18].ToString()))
                {
                    Spacil_Chb.Checked = false;
                }
                else
                {
                    Spacil_Chb.Checked = Convert.ToBoolean(dt_RQ.Rows[0][18]);
                }
                dt.Clear();
                int i = 0;
                DataRow row = null;
                foreach (DataRow r in dt_RQ.Rows)
                {

                    row = dt.NewRow();
                    row[0] = dt_RQ.Rows[i][24].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        row[1] = dt_RQ.Rows[i][32].ToString();
                    }
                    else
                    {
                        row[1] = dt_RQ.Rows[i][33].ToString();
                    }
                    row[2] = dt_RQ.Rows[i][25].ToString();
                    row[3] = dt_RQ.Rows[i][26].ToString();
                    row[4] = dt_RQ.Rows[i][27].ToString().ToDecimal().ToString("N3");
                    row[5] = dt_RQ.Rows[i][28].ToString().ToDecimal().ToString("N0");
                    row[6] = dt_RQ.Rows[i][29].ToString().ToDecimal().ToString("N1");
                    row[7] = dt_RQ.Rows[i][30].ToString().ToDecimal().ToString("N3");


                    dt.Rows.Add(row);
                    i = i + 1;
                }

                dGV_Item.DataSource = dt;
                resizeDG();
                total_inv();
                txtSearch.Text = "";
                groupPanel1.Visible = false;
                BSave.Enabled = false;
                BEdit.Enabled = true;
            }
            else
            {
                MessageBox.Show("تاكد من الرقم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            txtSearch.Text = "";
            groupPanel1.Visible = false;
        }

        private void Uc_Branch_KeyUp(object sender, KeyEventArgs e)
        {
            DataTable dt_br = dal.getDataTabl("Get_branch_Name_", Uc_Branch.ID.Text, dal.db1);

            if (dt_br.Rows.Count > 0)
            {
                txt_Tel.Text = dt_br.Rows[0][21].ToString();
                txt_Fax.Text = dt_br.Rows[0][22].ToString();
                txtMobile.Text = "";
                txtE_Fax.Text = "";
                txt_Email.Text = dt_br.Rows[0][23].ToString();
                txt_address.Text = dt_br.Rows[0][6].ToString();
                txt_MainNote.Text = dt_br.Rows[0][28].ToString();
                getJorSer();
            }
        }

        private void txtSearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtSearch.Text !="")
            {
                btnOk.Focus();
            }
        }

      
        private void buttonItem1_Click(object sender, EventArgs e)
        {
            RPT.Form1 frm = new RPT.Form1();

            RPT.rpt_R_Matrails rpt = new RPT.rpt_R_Matrails();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT A.*,b.*,m.descr,m.Descr_eng,m.Weight,m.Unit,Br.branch_name,Br.WH_E_NAME,
            p.PAYER_NAME,p.payer_l_name FROM " + dal.db1 + ".dbo.R_Qutation As A " +
            "inner join  " + dal.db1 + ".dbo.R_Qutation_Transaction As B" +
            " on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO " +
            "inner join  " + dal.db1 + ".dbo.wh_main_master as M on m.item_no = b.ITEM_NO " +
            "inner join  " + dal.db1 + ".dbo.wh_BRANCHES as Br on Br.Branch_code = a.Branch_code " +
            "inner join  " + dal.db1 + ".dbo.payer2 as P on P.acc_no = a.acc_no and p.branch_code = a.branch_code " +
            "where A.ser_no = '" + txt_serNo.Text + "' and a.Transaction_code = '" + txt_transaction_code.Text + "'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.DataDefinition.FormulaFields["Co_Name_E"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
            rpt.DataDefinition.FormulaFields["Branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.WindowState = FormWindowState.Maximized;

            frm.ShowDialog();

        }

        private void BtnEmail_Click(object sender, EventArgs e)
        {
            RPT.Form1 frm = new RPT.Form1();

            RPT.rpt_R_Qutation rpt = new RPT.rpt_R_Qutation();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT A.*,b.*,m.descr,m.Descr_eng,m.Weight,m.Unit,Br.branch_name,Br.WH_E_NAME,
            p.PAYER_NAME,p.payer_l_name FROM "+dal.db1+".dbo.R_Qutation As A " +
            "inner join  "+dal.db1+".dbo.R_Qutation_Transaction As B" +
            " on a.Branch_code = b.Branch_code and a.Transaction_code = b.TRANSACTION_CODE and a.Cyear = b.Cyear and a.Ser_no = b.SER_NO " +
            "inner join  "+dal.db1+".dbo.wh_main_master as M on m.item_no = b.ITEM_NO " +
            "inner join  "+dal.db1+".dbo.wh_BRANCHES as Br on Br.Branch_code = a.Branch_code " +
            "inner join  "+dal.db1+".dbo.payer2 as P on P.acc_no = a.acc_no and p.branch_code = a.branch_code " +
            "where A.ser_no = '"+txt_serNo.Text+ "' and a.Transaction_code = '"+txt_transaction_code.Text+"'");
            ds.Tables.Add(dt1);
            ////ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["Co_Name_E"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
            rpt.DataDefinition.FormulaFields["Branch_E_"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";

            frm.crystalReportViewer1.ReportSource = rpt;
            rpt.ExportToDisk(CrystalDecisions.Shared.ExportFormatType.PortableDocFormat, (Application.StartupPath + "\\attachment.pdf"));
            Outlook.Application oApp = new Outlook.Application();
            Outlook.MailItem email = (Outlook.MailItem)(oApp.CreateItem(Outlook.OlItemType.olMailItem));
            email.To = "";
            //email.Attachments.Add(Application.StartupPath + "\\attachment.pdf");
            email.Subject = "Material Request : " + this.txt_serNo.Text;
            email.Display(true);

          
        }


        private void BEdit_Click(object sender, EventArgs e)
        {
            test_Add_R_Qutation_Transaction();
            test_Add_R_Qutation();
            dal.Execute("Delet_R_Qutation_", txt_serNo.Text, Uc_Branch.ID.Text, txt_transaction_code.Text, dal.db1);
            Add_R_Qutation();
            Add_R_Qutation_Transaction();
            MessageBox.Show("تم تعديل البيانات بنجاح", "تعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void txt_address_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_MainNote_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Email_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_Fax_TextChanged(object sender, EventArgs e)
        {

        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_R_Qutaion_Load(object sender, EventArgs e)
        {
            txtUnit.DataSource = dal.getDataTabl_1("select * from " + dal.db1+".dbo.wh_unit");
            txtUnit.DisplayMember = "Wh_Unit";
            txtUnit.ValueMember = "Wh_Unit";
            txtUnit.SelectedIndex = -1;

            Uc_Branch.ID.Text = Properties.Settings.Default.BranchId;
        }

        private void dGV_Item_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void TxtId_TextChanged(object sender, EventArgs e)
        {

        }

        private void Doc_Name_Click(object sender, EventArgs e)
        {

        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

        private void labelX14_Click(object sender, EventArgs e)
        {

        }

        private void labelX11_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void txtUnit_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               TxtQty.Focus();
            }
        }

        private void Spacil_Chb_CheckedChanged(object sender, EventArgs e)
        {
            if (Spacil_Chb.Checked == true)
            {
                Spacil_Chb.BackColor = Color.Yellow;
            }
            else
            {
                Spacil_Chb.BackColor = Color.Transparent;
            }
        }
    }


}
