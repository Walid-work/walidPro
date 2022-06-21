using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing; using System.Linq;
using System.Globalization;

using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;

//using Syncfusion.Pdf;
//using Syncfusion.Pdf.Graphics;
//using Syncfusion.Pdf.Parsing;
//using Syncfusion.Pdf.Security;


namespace Report_Pro.PL
{
    public partial class frm_PreformaInvoice_Local : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        DataTable dt_P = new DataTable();
        string _branchCode = Properties.Settings.Default.BranchId;
        Assembly a = Assembly.Load("Report_Pro");
        CultureInfo cul;

        public frm_PreformaInvoice_Local()
        {


            InitializeComponent();


            comboBox1.DataSource = Enumerable.Range(1983, DateTime.Now.Year - 1983 + 1).ToList();
            comboBox1.SelectedItem = DateTime.Now.Year;


           






            if (Properties.Settings.Default.lungh == "0")
            {
                cul = new CultureInfo("ar");
            }
            else
            {
                cul = new CultureInfo("en");
            }


            txtCurrency.DataSource = dal.getDataTabl_1("SELECT * FROM Wh_Currency");

            txtCurrency.ValueMember = "Currency_Code";
            if (Properties.Settings.Default.lungh == "ar")
            {
                txtCurrency.DisplayMember = "Currency_Name";
            }
            else
            {
                txtCurrency.DisplayMember = "Currency_Name";

            }
            txtCurrency.SelectedIndex = -1;

            txtCrago_Method.DataSource = dal.getDataTabl_1("SELECT DeLEVRY_CODE,DeLEVRY_Name,DELEVER_NAME_E FROM WH_PO_DELEVRY_CODE");
            txtCrago_Method.ValueMember = "DeLEVRY_CODE";
            if (Properties.Settings.Default.lungh == "ar")
            {
                txtCrago_Method.DisplayMember = "DeLEVRY_Name";
            }
            else
            {
                txtCrago_Method.DisplayMember = "DELEVER_NAME_E";

            }
            txtCrago_Method.SelectedIndex = -1;



            txtRegion.DataSource = dal.getDataTabl_1("SELECT * FROM REGIONS");

            txtRegion.ValueMember = "REGION_code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtRegion.DisplayMember = "REGION_name";
            }
            else
            {
                txtRegion.DisplayMember = "REGION_E_NAME";

            }
            txtRegion.SelectedIndex = -1;


            txtArivePort.DataSource = dal.getDataTabl_1("SELECT * FROM Cus_Ports");

            txtArivePort.ValueMember = "Port_code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtArivePort.DisplayMember = "Port_name";
            }
            else
            {
                txtArivePort.DisplayMember = "Port_E_name";

            }
            txtArivePort.SelectedIndex = -1;


            txt_InvSM.Text = Program.salesman;
            userID.Text = Program.userID;

        }



        private void currencyRate(DevComponents.Editors.DoubleInput txt1, string currencyId)
        {
            DataTable dtReate = dal.getDataTabl_1("SELECT Change_Factor  FROM Wh_Currency where Currency_Code ='" + currencyId + "'");
            if (dtReate.Rows.Count > 0)
            {
                txt1.Value = Convert.ToDouble(dtReate.Rows[0][0].ToString());
            }
            else
            {
                txt1.Value = 0;
            }
         
        }

        private void get_invSer()
        {
           
            DataTable dtSer = dal.getDataTabl_1(@"select isnull(PEQ+1,1) from wh_Serial where Branch_code= '" + txtBranch.ID.Text + "' and Cyear='" + txtcyear.Text + "'");
            if (dtSer.Rows.Count > 0)
            {
               txtId.Text =dtSer.Rows[0][0].ToString();
            }
            else
            {
                txtId.Text = "1";
            }

        }

      
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
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Text = "";
                    else if (control is DataGridView)
                        (control as DataGridView).DataSource = null;
                    else if (control is FlowLayoutPanel)
                        (control as FlowLayoutPanel).Controls.Clear();
                    else if (control is DevComponents.DotNetBar.Controls.CheckBoxX)
                        (control as DevComponents.DotNetBar.Controls.CheckBoxX).Checked = false;

                    else
                        func(control.Controls);
            };

            func(Controls);


           // inv_Grid1.flowLayoutPanel1.Controls.Clear();

        }












        private void Currency_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtCurrency.Text != string.Empty)
            {
                txtAmount.Focus();
            }

        }



        private void AcceptDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && AcceptDays.Text != string.Empty)
            {
                OpenDate.Focus();

            }
        }

        private void Amount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtAmount.Text != string.Empty)
            {
                AcceptDays.Focus();

            }
        }

        private void Amount_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void AcceptDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void OpenDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                ExpiryDate.Focus();
            }
        }

        private void ExpiryDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                LShipDate.Focus();
            }
        }




        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();

            txtBranch.ID.Text = Properties.Settings.Default.BranchId;
            txtSupplier.txtMainAcc.Text = "234";
            txtSupplier.txtFinal.Text = "1";
            //txtLcAcc.txtMainAcc.Text = "";
            txtLcAcc.txtFinal.Text = "1";
            Bank_.txtMainAcc.Text = "1221";
            Bank_.txtFinal.Text = "1";
            txtBranch.txtTfinal.Text = "1";
            txtDate.Value = DateTime.Today;
            Doc_Type.Text = "PEQ";
            txtcyear.Text = txtDate.Value.ToString("yy");
            MyControls.Inv_Row r = new MyControls.Inv_Row();
            inv_Grid1.flowLayoutPanel1.Controls.Add(r);
            r.Ser.Text = (inv_Grid1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
            r.KeyDown += inv_Grid1.r_KeyDown;

            get_invSer();

          
                r.VatAccRate.Text = Acc_Vat_Rate.Text;
           




            BSave.Enabled = true;
            //BEdit.Enabled = false;
            txtBranch.Enabled = true;

        }





        private void buttonX1_Click(object sender, EventArgs e)
        {

            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.txtLcNo.Text;
            frmUpload.ShowDialog();
        }

        private void frmLcs_Load(object sender, EventArgs e)
        {
            txtBranch.ID.Text = Properties.Settings.Default.BranchId;
            txtSupplier.txtMainAcc.Text = "234";
            txtSupplier.txtFinal.Text = "1";
            //txtLcAcc.txtMainAcc.Text = "";
            txtLcAcc.txtFinal.Text = "1";
            Bank_.txtMainAcc.Text = "1221";
            Bank_.txtFinal.Text = "1";
            txtBranch.txtTfinal.Text = "1";
            txtDate.Value = DateTime.Today;
            txtcyear.Text = txtDate.Value.ToString("yy");
            get_invSer();
            //foreach(MyControls.Inv_Row r in inv_Grid1.flowLayoutPanel1.Controls)
            //{
            //    r.VatAccRate.Value = Convert.ToDouble(Acc_Vat_Rate.Text); 
            //}
            


        }

      

      



        private void btnPrintIssueFees_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            RPT.lcOpenDocument rpt = new RPT.lcOpenDocument();
            RPT.Form1 frm = new RPT.Form1();
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();
            //ds.WriteXmlSchema("schema1.xml");
        }










        private void txtSupplier_Load(object sender, EventArgs e)
        {

            DataTable dtSupp = dal.getDataTabl_1("select adress,resp_name,COSTMER_K_M_NO,phone_no,E_MAIL from payer2 where acc_no='" + txtSupplier.ID.Text + "' and BRANCH_code='"+txtSupplier.branchID.Text+"'");
            if (dtSupp.Rows.Count > 0)
            {
                txtAddress.Text = dtSupp.Rows[0]["adress"].ToString();
                txtSuppContact.Text = dtSupp.Rows[0]["resp_name"].ToString();
                txtSuppVAT.Text = dtSupp.Rows[0]["COSTMER_K_M_NO"].ToString();
                txtSuppPhone.Text = dtSupp.Rows[0]["phone_no"].ToString();
                txtSuppEmail.Text = dtSupp.Rows[0]["E_MAIL"].ToString();
                Vat_Class.Text = txtSupplier.KM_Code_Purch.Text;
                Vat_Class_Desc.Text = txtSupplier.KM_Desc_Purch.Text;
                Acc_Vat_Rate.Text = txtSupplier.KM_Ratio_Purch.Text;
                inv_Grid1.txtAccVat_Rate.Text= txtSupplier.KM_Ratio_Purch.Text;

            }
            else
            {
                txtAddress.Clear();     
                txtSuppContact.Clear(); 
                txtSuppVAT.Clear();     
                txtSuppPhone.Clear();   
                txtSuppEmail.Clear();   
                Vat_Class.Clear();      
                Vat_Class_Desc.Clear(); 
                Acc_Vat_Rate.Clear();
                inv_Grid1.txtAccVat_Rate.Clear();
            }
            foreach (MyControls.Inv_Row r in inv_Grid1.flowLayoutPanel1.Controls)
            {
                if (Doc_Type.Text == "PER")
                {
                    r.VatAccRate.Text = "0";
                }
                else
                {
                    r.VatAccRate.Text = Acc_Vat_Rate.Text.ToDecimal().ToString();
                }
                r.VatValue.Text = ((r.VatRate.Text.ToDecimal() <= r.VatAccRate.Text.ToDecimal() ? r.VatRate.Text : r.VatAccRate.Text).ToDecimal() * r.Txtvalue.Text.ToDecimal()).ToString("N" + dal.digits_);

            }
            inv_Grid1.total_inv();
        }





        private void buttonItem2_Click(object sender, EventArgs e)
        {
            RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
            frm.UC_Acc1.ID.Text = txtLcAcc.ID.Text;
            frm.ShowDialog();
        }

        private void btnAttachment_Click(object sender, EventArgs e)
        {
            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.txtLcNo.Text;
            frmUpload.ShowDialog();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void frm_PreformaInvoice_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                foreach (MyControls.Inv_Row inv_r in inv_Grid1.flowLayoutPanel1.Controls)
                {
                    inv_r.Ser.Text = (inv_Grid1.flowLayoutPanel1.Controls.GetChildIndex(inv_r) + 1).ToString();

                    if (inv_r.txt_Code.Text == string.Empty)
                    {
                        inv_r.Dispose();

                    }


                }
                MyControls.Inv_Row r = new MyControls.Inv_Row();
                inv_Grid1.flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (inv_Grid1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                if (Doc_Type.Text == "PER")
                {
                    r.VatAccRate.Text = "0";
                }
                else
                {
                    r.VatAccRate.Text = Acc_Vat_Rate.Text;
                }
                r.VatValue.Text = ((r.VatRate.Text.ToDecimal() <= r.VatAccRate.Text.ToDecimal() ? r.VatRate.Text : r.VatAccRate.Text).ToDecimal() * r.Txtvalue.Text.ToDecimal()).ToString("N" + dal.digits_);

                r.txt_Code.Focus();
                r.KeyDown += inv_Grid1.r_KeyDown;
                r.KeyUp += inv_Grid1.r_KeyUP;
                r.Click +=inv_Grid1.r_Click;
            }
        }



        //private void r_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        //{

        //    OnKeyDown(e);
        //}


        //private void r_KeyUp(object sender, System.Windows.Forms.KeyEventArgs e)
        //{

        //    OnKeyUp(e);
        //}

        //private void r_Click(object sender, EventArgs e)
        //{
        //    OnClick(e);
        //}
            private void BSearch_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtsearch.Focus();
        }

        private void txtBranch_Load(object sender, EventArgs e)
        {
            txtLcAcc.branchID.Text = txtBranch.txtAccBranch.Text;
            Bank_.branchID.Text = txtBranch.txtAccBranch.Text;
            txtSupplier.branchID.Text = txtBranch.txtAccBranch.Text;
            get_invSer();
        }



        bool IsDataValid()
        {
           
            if (txtBranch.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Branch", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtBranch.ID.Focus();
                return false;
                               
            }
            else if (txtSupplier.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Account", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtSupplier.ID.Focus();
                return false;
            }
            else if (txtLcAcc.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Lc Account", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtLcAcc.ID.Focus();
                return false;
            }

            else if (Cost_.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "User", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                Cost_.ID.Focus();
                return false;
            }

            else if (txtRegion.SelectedIndex < 0)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Region", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRegion.Focus();
                return false;
            }

            else if (txtFactory.Text.Trim() == string.Empty)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Factory", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtFactory.Focus();
                return false;
            }

            else if (txtProforma.Text.Trim() == string.Empty)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Proforma No.", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProforma.Focus();
                return false;
            }
            else if (txtCurrency.SelectedIndex < 0)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Currency", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtCurrency.Focus();
                return false;
            }


            else if (txtRate.Value <= 0)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Currency Rate", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtRate.Focus();
                return false;
            }
            else if (AcceptDays.Value < 0)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Accept Days", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                AcceptDays.Focus();
                return false;
            }

            else if (dal.IsDateTime(OpenDate.Text)==false)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Isue Date", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                OpenDate.Focus();
                return false;
            }

            else if (dal.IsDateTime(LShipDate.Text) == false)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "ShipDate", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                LShipDate.Focus();
                return false;
            }

            else if (dal.IsDateTime(ExpiryDate.Text) == false)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Expiry Date", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                ExpiryDate.Focus();
                return false;
            }

            else if (dal.IsDateTime(txtProformaDate.Text) == false)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Proforma Date", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtProformaDate.Focus();
                return false;
            }

            else if (txtCrago_Method.SelectedIndex < 0)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Shipping Tearms", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabcontrol1.SelectedTab= tabDelevery;
                txtCrago_Method.Focus();
                return false;
            }

            else if (txtArivePort.SelectedIndex < 0)
            {
                MessageBox.Show(dal.rm.GetString("msgError") + "Shipp To ", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);
                tabcontrol1.SelectedTab = tabDelevery;
                txtArivePort.Focus();
                return false;
                
            }
          
            else
            {
                return true;
            }

        }

        bool IsGridValid()
        {

            int countR = 0;

            foreach (MyControls.Inv_Row c in inv_Grid1.flowLayoutPanel1.Controls)
            {
                if (c.txt_Code.Text != String.Empty && c.qty.Value > 0 && c.TxtPrice.Value > 0)
                {
                    countR++;
                }

            }
            if (countR > 0)
            {
                return true;
            }
            else
            {
                MessageBox.Show(dal.rm.GetString("msgError") + " No Items", dal.rm.GetString("msgError_H"), MessageBoxButtons.OK, MessageBoxIcon.Error);

                return false;
            }
        }


private void BSave_Click(object sender, EventArgs e)
        {

            if (IsDataValid() == false)
            {
                return;
            }
            if (IsGridValid() == false)
            {
                return;
            }



            DataTable dt_ = dal.getDataTabl_1(@"select * from wh_inv_data_Ext_Perform where ser_no='" + txtId.Text + "' and Transaction_code='" + Doc_Type.Text + "' and Branch_code='" + txtBranch.ID.Text + "' and Cyear='" + txtcyear.Text + "' ");
            if (dt_.Rows.Count > 0)
            {
                SqlCommand cmd = dal.sqlconn_1.CreateCommand();
                SqlTransaction trans;
                trans = dal.sqlconn_1.BeginTransaction();
                cmd.Connection = dal.sqlconn_1;
                cmd.Transaction = trans;
                try
                {

                    cmd.CommandText = @"UPDATE wh_inv_data_Ext_Perform set 
                    Ser_no                  = '" + txtId.Text +
                    "',Branch_code          = '" + txtBranch.ID.Text +
                    "',Transaction_code     = '" + Doc_Type.Text +
                    "',Cyear                = '" + txtcyear.Text +
                    "',Sanad_no             = '0'" +
                    ",G_date                = '" + txtDate.Value.ToString("yyyy-MM-dd") +
                    "',ACC_TYPE             = 'A'" +
                    ",Acc_no                = '" + txtSupplier.ID.Text +
                    "',Acc_Branch_code      = '" + txtBranch.txtAccBranch.Text +
                    "',Payment_Type         = '2' " +
                    ",Sales_man_Id          = '" + Cost_.ID.Text +
                    "',User_id              = '" + userID.Text +
                    "',LC_NO                = '" + txtLcNo.Text +
                    "',LC_ACC_NO            = '" + txtLcAcc.ID.Text +
                    "',Perform_invoice      = '" + txtProforma.Text +
                    "',Perform_invoice_date = '" + txtProformaDate.Value.ToString("yyyy-MM-dd") +
                    "',Cargo_date           = '" + LShipDate.Value.ToString("yyyy-MM-dd") +
                    "',Cargo_port           = '" + txtCrago_Port.Text +
                    "',Arrival_port         = '" + Convert.ToString(txtArivePort.SelectedValue) +
                    "',Catgo_Media          = '" + txtCrago_Media.Text +
                    "',cargo_method         = '" + Convert.ToString(txtCrago_Method.SelectedValue) +
                    "',Cargo_notes1         = '" + txtCragoNote1.Text +
                    "',Cargo_notes2         = '" + txtCragoNote2.Text +
                    "',Estihkak_Dayes       = '" + AcceptDays.Value +
                    "',Lc_Date              = '" + OpenDate.Value.ToString("yyyy-MM-dd") +
                    "',Paper_Arival_Notes   = ''" +
                    ",Country               = '" + txtFactory.Text +
                    "',Factory              = '" + Convert.ToString(txtRegion.SelectedValue) +
                    "',LC_EXPIRE_DATE       =  '" + ExpiryDate.Value.ToString("yyyy-MM-dd") +
                    "',LC_STOPED            = '" + (ch_Close.Checked ? "1" : "0") +
                    "',Costmer_No            = '" + Bank_.ID.Text +
                    "' where Ser_no = '" + txtId.Text + "' and Branch_code = '" + txtBranch.ID.Text + "' and  Transaction_code = '" + Doc_Type.Text + "' and Cyear = '" + txtcyear.Text + "' ";

                    cmd.ExecuteNonQuery();

                    cmd.CommandText = @"Delete from wh_MATERIAL_TRANSACTION_Ext_Perform where Ser_no = '" + txtId.Text + "' and Branch_code = '" + txtBranch.ID.Text + "' and  Transaction_code = '" + Doc_Type.Text + "' and Cyear = '" + txtcyear.Text + "' ";
                    cmd.ExecuteNonQuery();


                    foreach (MyControls.Inv_Row r in inv_Grid1.flowLayoutPanel1.Controls)
                    {

                        if (r.txt_Code.Text != string.Empty && r.qty.Value > 0 && r.TxtPrice.Value > 0)
                        {
                            cmd.CommandText = @"INSERT INTO wh_MATERIAL_TRANSACTION_Ext_Perform        
                            (SER_NO,Branch_code,TRANSACTION_CODE,Cyear,SANAD_NO,ITEM_NO,QTY_ADD,QTY_TAKE,
                            total_disc,DISC_R,DISC_R2,DISC_R3,G_DATE,Unit,Forign_price,Local_Price,FORIN_TYPE,
                            USER_ID,main_counter,balance,Currancy_Change_Factor,Backege,GAMAREK,Notes, K_M_TYPE_ITEMS,TAX_IN,TAX_OUT)
                            values ( '" + txtId.Text + "', '" + txtBranch.ID.Text + "', '" + Doc_Type.Text + "', '" + txtcyear.Text + "' ,'0','" +
                            r.txt_Code.Text + "','" + r.qty.Text + "','0','0','0','0','0','" +
                            txtDate.Value.ToString("yyyy/MM/dd HH: mm:ss") + "','" + r.txtUnit.Text + "','" + r.TxtPrice.Text + "','" +
                            r.TxtPrice.Text.ToDecimal() * txtRate.Text.ToDecimal() + "','" + Convert.ToString(txtCurrency.SelectedValue) + "','" + userID.Text + "','" +
                            inv_Grid1.flowLayoutPanel1.Controls.GetChildIndex(r) + "','" + r.txtBalance.Text.ToDecimal() + "','" +
                            txtRate.Text.ToDecimal() + "','1','0','" + r.txtNote.Text + "','" + r.KM_TYPE_ITEMS.Text + "','" + r.VatValue.Text.ToDecimal() + "','0')";

                            cmd.ExecuteNonQuery();

                        }

                    }

                    trans.Commit();
                    MessageBox.Show(dal.rm.GetString("msgEdit", dal.cul), dal.rm.GetString("msgEdit_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dal.sqlconn_1.Close();
                }

            }

            else
            {
                SqlCommand cmd = dal.sqlconn_1.CreateCommand();
                SqlTransaction trans;
                trans = dal.sqlconn_1.BeginTransaction();
                cmd.Connection = dal.sqlconn_1;
                cmd.Transaction = trans;

                try
                {
                    cmd.CommandText = @"insert into wh_inv_data_Ext_Perform (Ser_no,Branch_code,Transaction_code,Cyear,Sanad_no
                ,G_date,ACC_TYPE,Acc_no,Acc_Branch_code,Payment_Type
                ,Sales_man_Id,User_id,LC_NO,LC_ACC_NO,Perform_invoice
                ,Perform_invoice_date,Cargo_date,Cargo_port,Arrival_port,Catgo_Media
                ,cargo_method,Cargo_notes1,Cargo_notes2,Estihkak_Dayes,Lc_Date
                ,Paper_Arival_Notes,Country,Factory,LC_EXPIRE_DATE,LC_STOPED,Costmer_No)
                values('" + txtId.Text + "', '" + txtBranch.ID.Text + "', '" + Doc_Type.Text + "','" + txtcyear.Text +
                "','0','" + txtDate.Value.ToString("yyyy-MM-dd") + "', 'A','" + txtSupplier.ID.Text +
                "','" + txtBranch.txtAccBranch.Text + "', '2','" + Cost_.ID.Text + "', '" + userID.Text +
                "','" + txtLcNo.Text + "', '" + txtLcAcc.ID.Text + "', '" + txtProforma.Text +
                "', '" + txtProformaDate.Value.ToString("yyyy-MM-dd") + "', '" + LShipDate.Value.ToString("yyyy-MM-dd") +
                "', '" + txtCrago_Port.Text + "','" + Convert.ToString(txtArivePort.SelectedValue) + "', '" + txtCrago_Media.Text +
                "', '" + Convert.ToString(txtCrago_Method.SelectedValue) + "', '" + txtCragoNote1.Text + "', '" + txtCragoNote2.Text +
                "', '" + AcceptDays.Value + "', '" + OpenDate.Value.ToString("yyyy-MM-dd") + "', '','" + txtFactory.Text +
                "', '" + Convert.ToString(txtRegion.SelectedValue) + "','" + ExpiryDate.Value.ToString("yyyy-MM-dd") + "','" + 
                (ch_Close.Checked ? "1" : "0") +"','" + Bank_.ID.Text + "')";

                cmd.ExecuteNonQuery();


                    foreach (MyControls.Inv_Row r in inv_Grid1.flowLayoutPanel1.Controls)
                    {

                        if (r.txt_Code.Text != string.Empty && r.qty.Value > 0 && r.TxtPrice.Value > 0)
                        {
                            cmd.CommandText = @"INSERT INTO wh_MATERIAL_TRANSACTION_Ext_Perform        
                            (SER_NO,Branch_code,TRANSACTION_CODE,Cyear,SANAD_NO,ITEM_NO,QTY_ADD,QTY_TAKE,
                            total_disc,DISC_R,DISC_R2,DISC_R3,G_DATE,Unit,Forign_price,Local_Price,FORIN_TYPE,
                            USER_ID,main_counter,balance,Currancy_Change_Factor,Backege,GAMAREK,Notes, K_M_TYPE_ITEMS,TAX_IN,TAX_OUT) 
                            values ( '" + txtId.Text + "', '" + txtBranch.ID.Text + "', '" + Doc_Type.Text + "', '" + txtcyear.Text + "' ,'0','" +
                            r.txt_Code.Text + "','" + r.qty.Text + "','0','0','0','0','0','" +
                            txtDate.Value.ToString("yyyy/MM/dd HH: mm:ss") + "','" + r.txtUnit.Text + "','" + r.TxtPrice.Text + "','" +
                            r.TxtPrice.Text.ToDecimal() * txtRate.Text.ToDecimal() + "','" + Convert.ToString(txtCurrency.SelectedValue) + "','" + userID.Text + "','" +
                            inv_Grid1.flowLayoutPanel1.Controls.GetChildIndex(r) + "','" + r.txtBalance.Text.ToDecimal() + "','" +
                            txtRate.Text.ToDecimal() + "','1','0','" + r.txtNote.Text + "','" + r.KM_TYPE_ITEMS.Text + "','" + r.VatValue.Text.ToDecimal() + "','0')";

                            cmd.ExecuteNonQuery();

                        }

                    }



                  
                    cmd.CommandText = @"UPDATE  wh_Serial SET  PEQ= '" + txtId.Text + "' WHERE Branch_code = '" + txtBranch.ID.Text + "' and Cyear='" + txtDate.Value.ToString("yy") + "' ";
                        cmd.ExecuteNonQuery();


                    trans.Commit();
                    MessageBox.Show(dal.rm.GetString("msgSave", dal.cul), dal.rm.GetString("msgSave_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                catch (Exception ex)
                {
                    trans.Rollback();
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    dal.sqlconn_1.Close();
                }


            }



            }



        private void btn_Cancl_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
        }


        private void get_data(string ser_,string branch_,string year_ ,string transaction_)
        {
            dt_P = dal.getDataTabl_1(@"SELECT A.Ser_no,A.Branch_code,A.Transaction_code,A.Cyear,A.G_date,A.ACC_TYPE,A.Acc_no,A.Acc_Branch_code
            ,A.Payment_Type,A.Sales_man_Id,A.User_id,A.LC_NO,A.LC_ACC_NO,A.Perform_invoice,A.Perform_invoice_date
            ,A.Cargo_date,A.Cargo_port,A.Arrival_port,A.cargo_method,A.Cargo_notes1,A.Cargo_notes2,A.Catgo_Media,A.Estihkak_Dayes
            ,A.Lc_Date,A.Paper_Arival_Notes,A.Country,A.Factory,A.LC_EXPIRE_DATE,A.LC_STOPED,A.Costmer_No
            ,B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.total_disc,B.Unit,B.Forign_price,B.Local_Price,B.FORIN_TYPE,B.Currancy_Change_Factor,B.Notes,B.main_counter
			,C.PAYER_NAME,C.payer_l_name,C.adress,C.resp_name,C.COSTMER_K_M_NO,C.phone_no,C.E_MAIL,D.branch_name,D.WH_E_NAME,E.descr
            ,E.Descr_eng,E.Weight,E.local_cost,E.BALANCE,S.KM_RATIO,S.KM_Code,F.USER_NAME,H.Currency_Name,K.Payment_name
            FROM wh_inv_data_Ext_Perform As A 
			inner join wh_MATERIAL_TRANSACTION_Ext_Perform As B
            on  A.SER_NO=B.SER_NO and A.Branch_code=B.Branch_code and A.TRANSACTION_CODE=B.TRANSACTION_CODE and A.Cyear=B.Cyear
			inner join payer2 as C on A.Acc_no = C.ACC_NO and A.Acc_Branch_code=C.BRANCH_code
			inner join wh_BRANCHES as D on  A.Branch_code = D.Branch_code
		    inner join wh_main_master as E on E.item_no = B.ITEM_NO
            inner join wh_USERS As F on F.USER_ID=A.User_id
            inner join Wh_Currency as H on H.Currency_Code=B.FORIN_TYPE
			inner join wh_Payment_type as K on K.Payment_type =A.Payment_Type
           left join KM_MATERIAL_CODE As S on  ISNULL(NULLIF(E.KM_CODE, ''), 1) = S.KM_CODE
            where A.Ser_no='" + ser_ + "' and A.Branch_code='" + branch_ + "' and A.Cyear = '" + year_ + "' and A.Transaction_code='"+transaction_+"'");

        }


        private void btn_Srearch_Click(object sender, EventArgs e)
        {

            get_data(txtsearch.Text ,_branchCode,comboBox1.Text.Substring(comboBox1.Text.Length - 2),Doc_Type.Text);
           
            if (dt_P.Rows.Count > 0)
            {
                txtBranch.Enabled = false;

                txtcyear.Text                   = comboBox1.Text.Substring(comboBox1.Text.Length - 2);
                txtId.Text                      = dt_P.Rows[0]["Ser_no"].ToString();
                txtDate.Text                    = dt_P.Rows[0]["G_date"].ToString();
                txtBranch.ID.Text               = dt_P.Rows[0]["Branch_code"].ToString();
                txtLcAcc.ID.Text                = dt_P.Rows[0]["LC_ACC_NO"].ToString();
                txtSupplier.ID.Text             = dt_P.Rows[0]["Acc_no"].ToString();
                txtSuppContact.Text             = dt_P.Rows[0]["resp_name"].ToString();
                txtSuppPhone.Text               = dt_P.Rows[0]["phone_no"].ToString();
                txtSuppVAT.Text                 = dt_P.Rows[0]["COSTMER_K_M_NO"].ToString();
                txtAddress.Text                 = dt_P.Rows[0]["adress"].ToString();
                txtSuppEmail.Text               = dt_P.Rows[0]["E_MAIL"].ToString();
                txtRate.Text                    = dt_P.Rows[0]["Currancy_Change_Factor"].ToString();
                AcceptDays.Text                 = dt_P.Rows[0]["Estihkak_Dayes"].ToString();
                txtCurrency.SelectedValue       = dt_P.Rows[0]["FORIN_TYPE"].ToString();
                OpenDate.Text                   = dt_P.Rows[0]["Lc_Date"].ToString();
                ExpiryDate.Text                 = dt_P.Rows[0]["LC_EXPIRE_DATE"].ToString();
                LShipDate.Text                  = dt_P.Rows[0]["Cargo_date"].ToString();
                txtProforma.Text                = dt_P.Rows[0]["Perform_invoice"].ToString();
                txtProformaDate.Text            = dt_P.Rows[0]["Perform_invoice_date"].ToString();
                txtLcNo.Text                    = dt_P.Rows[0]["LC_NO"].ToString();
                Cost_.ID.Text                   = dt_P.Rows[0]["Sales_man_Id"].ToString();
                txtCragoNote1.Text              = dt_P.Rows[0]["Cargo_notes1"].ToString();
                txtCragoNote2.Text              = dt_P.Rows[0]["Cargo_notes2"].ToString();
                txtCrago_Method.SelectedValue   = dt_P.Rows[0]["cargo_method"].ToString();
                txtCrago_Media.Text             = dt_P.Rows[0]["Catgo_Media"].ToString();
                txtCrago_Port .Text             = dt_P.Rows[0]["Cargo_port"].ToString();
                txtArivePort.SelectedValue      = dt_P.Rows[0]["Arrival_port"].ToString();
                txtFactory.Text                 = dt_P.Rows[0]["Country"].ToString();
                txtRegion.SelectedValue         = dt_P.Rows[0]["Factory"].ToString();
                Bank_.ID.Text                   = dt_P.Rows[0]["Costmer_No"].ToString();
                ch_Close.Checked                = Convert.ToBoolean(dt_P.Rows[0]["LC_STOPED"].ToString());

                
                dt.Clear();
                int i = 0;
                inv_Grid1.flowLayoutPanel1.Controls.Clear();
                
                foreach (DataRow row_ in dt_P.Rows)
                {
                  

                        MyControls.Inv_Row rw = new MyControls.Inv_Row();
                        rw.Ser.Text = (i+1).ToString();
                        rw.txt_Code.Text        = dt_P.Rows[i]["ITEM_NO"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        rw.TxtDesc.Text         = dt_P.Rows[i]["descr"].ToString();
                    }
                    else
                    {
                        rw.TxtDesc.Text         = dt_P.Rows[i]["Descr_eng"].ToString();
                    }
                        rw.txtNote.Text         = dt_P.Rows[i]["Notes"].ToString();
                        rw.txtUnit.Text         = dt_P.Rows[i]["Unit"].ToString();
                        rw.Weight_.Text         = dt_P.Rows[i]["Weight"].ToString();
                        rw.qty.Text             = dt_P.Rows[i]["QTY_ADD"].ToString().ToDecimal().ToString("N2");
                        rw.totWeight.Text       = (dt_P.Rows[i]["QTY_ADD"].ToString().ToDecimal() * dt_P.Rows[i]["Weight"].ToString().ToDecimal()).ToString("n3");
                        rw.TxtPrice.Text        = dt_P.Rows[i]["Forign_price"].ToString().ToDecimal().ToString("N3");
                        rw.Price_ton.Text       = (dt_P.Rows[i]["Forign_price"].ToString().ToDecimal() / dt_P.Rows[i]["Weight"].ToString().ToDecimal() * 1000).ToString("N0");
                        rw.txt_subTOt.Text      = (dt_P.Rows[i]["Local_Price"].ToString().ToDecimal() * dt_P.Rows[i]["QTY_ADD"].ToString().ToDecimal()).ToString("N" + dal.digits_);
                        rw.TxtDisc.Text         = "0";
                        rw.Txtvalue.Text        = (rw.txt_subTOt.Text.ToDecimal() - rw.TxtDisc.Text.ToDecimal()).ToString("N2");
                        rw.VatRate.Text         = dt_P.Rows[i]["KM_RATIO"].ToString();
                        rw.KM_TYPE_ITEMS.Text   = dt_P.Rows[i]["KM_Code"].ToString();
                        rw.txtBalance.Text      = dt_P.Rows[i]["balance"].ToString().ToDecimal().ToString("N0");
                        rw.txtCost.Text         = dt_P.Rows[i]["local_cost"].ToString().ToDecimal().ToString("N3");

                        inv_Grid1.flowLayoutPanel1.Controls.Add(rw);
                        rw.KeyDown += inv_Grid1.r_KeyDown;
                        rw.KeyUp += inv_Grid1.r_KeyUP;
                        rw.Click += inv_Grid1.r_Click;
                        i = i + 1;

                }

                MyControls.Inv_Row r = new MyControls.Inv_Row();
                inv_Grid1.flowLayoutPanel1.Controls.Add(r);
                r.Ser.Text = (inv_Grid1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                inv_Grid1.txtAccVat_Rate.Text = txtSupplier.KM_Ratio_Purch.Text;

                r.KeyDown += inv_Grid1.r_KeyDown;
                r.KeyUp += inv_Grid1.r_KeyUP;
                r.Click +=inv_Grid1.r_Click;

                //dGV_Item.DataSource = dt;
                //resizeDG();
                // total_inv();
                txtsearch.Text = "";
                groupBox1.Visible = false;
               // BSave.Enabled = false;
               // BEdit.Enabled = true;
             
            }
        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }

        

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();

            get_data(txtId.Text, txtBranch.ID.Text, comboBox1.Text.Substring(comboBox1.Text.Length - 2), Doc_Type.Text);

            ds.Tables.Add(dt_P);
            //ds.WriteXmlSchema("schema_rpt.xml");
            RPT.Form1 frm = new RPT.Form1();
            RPT.rpt_Preform_Print rpt_P = new RPT.rpt_Preform_Print();
            rpt_P.SetDataSource(ds);
            ////rpt_P.SetDataSource(dal.getDataTabl("get_invDetails", txt_InvNu.Text, txt_transaction_code.Text, txt_InvDate.Value.Year.ToString()));
            frm.crystalReportViewer1.ReportSource = rpt_P;
            frm.ShowDialog();
            //ToWord toWord = new ToWord(Math.Abs(Math.Round(dt_P.Rows[0][1].ToString().ToDecimal(), dal.digits_)), currencies[currencyNo]);
            //rpt_P.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToEnglish().ToString() + "'";


        }









        private void deleteInvDetails(int _Ser_no, string _Branch_code, string _Transaction_code, string _Cyear)
        {
            dal.Execute_1(@"Delete from wh_MATERIAL_TRANSACTION_Ext_Perform where Ser_no = '" + _Ser_no+"' and Branch_code = '"+_Branch_code+"' and  Transaction_code = '"+_Transaction_code+"' and Cyear = '"+_Cyear+"' "); 
        }



private void AddInvDetails()
{
            foreach (MyControls.Inv_Row r in inv_Grid1.flowLayoutPanel1.Controls)
            {

                if (r.txt_Code.Text != string.Empty && r.qty.Value > 0 && r.TxtPrice.Value > 0)
                {
                    dal.Execute_1(@"INSERT INTO wh_MATERIAL_TRANSACTION_Ext_Perform
                    
                    (SER_NO,
                    Branch_code,
                    TRANSACTION_CODE,
                    Cyear,
                    SANAD_NO,
                    ITEM_NO,
                    QTY_ADD,
                    QTY_TAKE,
                    total_disc,
                    DISC_R,
                    DISC_R2,
                    DISC_R3,
                    G_DATE,
                    Unit,
                    Forign_price,
                    Local_Price,
                    FORIN_TYPE,
                    USER_ID,
                    main_counter,
                    balance,
                    Currancy_Change_Factor,
                    Backege,
                    GAMAREK,
                    Notes)
                values ( '" + txtId.Text + "', '" + txtBranch.ID.Text + "', '" +  Doc_Type.Text + "', '" + txtcyear.Text + "' ,'0','"+
        r.txt_Code.Text+"','" + r.qty.Text + "','0','0','0','0','0','"+ 
        txtDate.Value.ToString("yyyy/MM/dd HH: mm:ss") + "','"+ r.txtUnit.Text+"','"+ r.TxtPrice.Text+"','"+
        r.TxtPrice.Text.ToDecimal()* txtRate.Text.ToDecimal()+ "','"+  Convert.ToString(txtCurrency.SelectedValue)+"','"+  userID.Text+"','"+ 
        inv_Grid1.flowLayoutPanel1.Controls.GetChildIndex(r)+"','"+ r.txtBalance.Text.ToDecimal()+"','"+ txtRate.Text.ToDecimal() + "','1','0','"+ r.txtNote.Text+"')");

                }
            }
        }


        private void UpdateInv(int _Ser_no,string _Branch_code,string _Transaction_code,string _Cyear,int _Sanad_no,
            string _G_date,string _ACC_TYPE,string _Acc_no,string _Acc_Branch_code,string _Payment_Type,
            string _Sales_man_Id,string _User_id,string _LC_NO,string _LC_ACC_NO,string _Perform_invoice,
            string _Perform_invoice_date,string _Cargo_date,string _Cargo_port,string _Arrival_port,string _Catgo_Media,
            string _cargo_method,string _Cargo_notes1,string _Cargo_notes2,int _Estihkak_Dayes,string _Lc_Date,string _Paper_Arival_Notes,
            string _Country,string _Factory,string _LC_EXPIRE_DATE,Boolean _LC_STOPED,string _Costmer_No )
        {
            dal.Execute_1(@"UPDATE wh_inv_data_Ext_Perform set 
            Ser_no                 = '"+ txtId.Text+
           "',Branch_code          = '"+ txtBranch.ID.Text+
           "',Transaction_code     = '"+ Doc_Type.Text+
           "',Cyear                = '"+ txtcyear.Text+
           "',Sanad_no             = '0'" +
           ",G_date               = '"+ txtDate.Value.ToString("yyyy-MM-dd")+
           "',ACC_TYPE             = 'A'" +
           ",Acc_no               = '"+ txtSupplier.ID.Text+
           "',Acc_Branch_code      = '"+ txtBranch.txtAccBranch.Text+
           "',Payment_Type         = '2' "+
           ",Sales_man_Id         = '"+ Cost_.ID.Text+
           "',User_id              = '"+ userID.Text+
           "',LC_NO                = '"+ txtLcNo.Text+
           "',LC_ACC_NO            = '"+ txtLcAcc.ID.Text+
           "',Perform_invoice      = '"+ txtProforma.Text+
           "',Perform_invoice_date = '"+ txtProformaDate.Value.ToString("yyyy-MM-dd")+
           "',Cargo_date           = '"+ LShipDate.Value.ToString("yyyy-MM-dd")+
           "',Cargo_port           = '"+ txtCrago_Port.Text+
           "',Arrival_port         = '"+ Convert.ToString(txtArivePort.SelectedValue)+
           "',Catgo_Media          = '"+ txtCrago_Media.Text+
           "',cargo_method         = '" + txtCrago_Method.Text +
           "',Cargo_notes1         = '" + txtCragoNote1.Text +
           "',Cargo_notes2         = '" + txtCragoNote2.Text +
           "',Estihkak_Dayes       = '" + AcceptDays.Text.ParseInt(0) +
           "',Lc_Date              = '" + OpenDate.Value.ToString("yyyy-MM-dd") +
           "',Paper_Arival_Notes   = ''" +
           ",Country              = '" + txtFactory.Text +
           "',Factory              = '" + Convert.ToString(txtRegion.SelectedValue) +
           "',LC_EXPIRE_DATE       =  '" + ExpiryDate.Value.ToString("yyyy-MM-dd") +
           "',LC_STOPED            = '0'" +
           ",Costmer_No           = '" + Bank_.ID.Text +
            "' where Ser_no = '" +txtId.Text+ "' and Branch_code = '" + txtBranch.ID.Text + "' and  Transaction_code = '" + Doc_Type.Text + "' and Cyear = '"+txtcyear.Text+"' "); 
        }



        private void AddInv(int _Ser_no, string _Branch_code, string _Transaction_code, string _Cyear, int _Sanad_no,
           string _G_date, string _ACC_TYPE, string _Acc_no, string _Acc_Branch_code, string _Payment_Type,
           string _Sales_man_Id, string _User_id, string _LC_NO, string _LC_ACC_NO, string _Perform_invoice,
           string _Perform_invoice_date, string _Cargo_date, string _Cargo_port, string _Arrival_port, string _Catgo_Media,
           string _cargo_method, string _Cargo_notes1, string _Cargo_notes2, int _Estihkak_Dayes, string _Lc_Date, string _Paper_Arival_Notes,
           string _Country, string _Factory, string _LC_EXPIRE_DATE, Boolean _LC_STOPED, string _Costmer_No)
        {
            dal.Execute_1(@"insert into wh_inv_data_Ext_Perform (Ser_no,Branch_code,Transaction_code,Cyear,Sanad_no
                            ,G_date,ACC_TYPE,Acc_no,Acc_Branch_code,Payment_Type
                            ,Sales_man_Id,User_id,LC_NO,LC_ACC_NO,Perform_invoice
                            ,Perform_invoice_date,Cargo_date,Cargo_port,Arrival_port,Catgo_Media
                            ,cargo_method,Cargo_notes1,Cargo_notes2,Estihkak_Dayes,Lc_Date
                            ,Paper_Arival_Notes,Country,Factory,LC_EXPIRE_DATE,LC_STOPED,Costmer_No)
                            values ('"+_Ser_no+"','"+ _Branch_code+"','"+ _Transaction_code+"','"+ _Cyear+"','"+ _Sanad_no
                            +"','"+ _G_date+"','"+ _ACC_TYPE+"','"+ _Acc_no+"','"+ _Acc_Branch_code+"','"+ _Payment_Type
                            +"','"+ _Sales_man_Id+"','"+ _User_id+"','"+ _LC_NO+"','"+ _LC_ACC_NO+"','"+ _Perform_invoice
                            +"','"+ _Perform_invoice_date+"','"+ _Cargo_date+"','"+ _Cargo_port+"','"+ _Arrival_port+"','"+ _Catgo_Media
                            +"','"+ _cargo_method+"','"+ _Cargo_notes1+"','"+ _Cargo_notes2+"','"+ _Estihkak_Dayes+"','"+ _Lc_Date
                            +"','"+ _Paper_Arival_Notes+"','"+ _Country+"','"+ _Factory+"','"+ _LC_EXPIRE_DATE+"','"+ _LC_STOPED+"','"+ _Costmer_No+"')");
        }


        
        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtsearch.Text != string.Empty)
            {
                btn_Srearch.Focus();
            }
        }

        private void ch_Close_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Close.Checked == true)
            {
                ch_Close.BackColor = Color.OrangeRed;
                ch_Close.Text = "Closed";
            }
            else
            {
                ch_Close.BackColor = Color.GreenYellow;
                ch_Close.Text = "Opened";
            }
        }

        private void frm_PreformaInvoice_KeyUp(object sender, KeyEventArgs e)
        {
           inv_Grid1.total_inv();
        }

       
        private void frm_PreformaInvoice_Click(object sender, EventArgs e)
        {
            inv_Grid1.txtAccVat_Rate.Text = "1";
           
        }

        private void txtCurrency_SelectedIndexChanged(object sender, EventArgs e)
        {
            currencyRate(txtRate, Convert.ToString(txtCurrency.SelectedValue));
        }

        private void btnAddPayment_Click(object sender, EventArgs e)
        {
            PL.frmAddDelevryTearms frm = new frmAddDelevryTearms();
            frm.ShowDialog();
        }

        private void buttonX1_Click_1(object sender, EventArgs e)
        {
             PL.frmAddArrivalPort frm = new frmAddArrivalPort();
            frm.ShowDialog();
        }

        private void tabControlPanel1_Click(object sender, EventArgs e)
        {

        }

        private void inv_Grid1_Load(object sender, EventArgs e)
        {

        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }
    }
}
