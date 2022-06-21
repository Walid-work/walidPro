using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class Frm_Banks : frm_Master
    {
        string frmType = "add";
        //BL.Cls_public cls_public = new BL.Cls_public();
        //BL.Cls_Lcs lcs = new BL.Cls_Lcs();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DAL.BanksTbl bnk;
        /// <summary>
        ///// جزء من كود عدم تكرار الفتح للفورم
        ///// </summary>
        //private static Frm_Banks Frm_Bank = null;
        ////---------

        public Frm_Banks()
        {

            //    // كود منع تكرار فتح الفورم---------

            //    // If the form already exists, and has not been closed
            //    if (Frm_Bank != null && !Frm_Bank.IsDisposed)
            //    {
            //        Frm_Bank.Focus();            // Bring the old one to top
            //        Shown += (s, e) => this.Close();  // and destroy the new one.
            //        return;
            //    }

            //    // Otherwise store this one as reference
            //    Frm_Bank = this;
            //    //--------------------------------

            InitializeComponent();
            New();

        }



        void clear_texts()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;

                    else
                        func(control.Controls);
            };

            func(Controls);


        }




        private void BID_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BID.Text != string.Empty)
            {
                BNameA.Focus();
            }
        }

        private void BNameA_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BNameA.Text != string.Empty)
            {
                BNameE.Focus();
            }
        }

        private void BNameE_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BNameE.Text != string.Empty)
            {
                BAccNo.Focus();
            }
        }

        private void BAccNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BAccNo.Text != string.Empty)
            {
                BTel.Focus();
            }
        }

        private void BTel_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BTel.Text != string.Empty)
            {
                BFax.Focus();
            }
        }

        private void BFax_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BFax.Text != string.Empty)
            {

                BEmail.Focus();
            }
        }




        private void BEmail_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BEmail.Text != string.Empty)
            {
                BAccept.Focus();
            }
        }


        private void BNew_Click(object sender, EventArgs e)
        {
            //frmType = "add";
            //BSave.Text = "حفظ";
            ////clear_texts();
            //New();
            //BID.Enabled = true;
            //BSave.Enabled = true;
            //BID.Focus();
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            //save_();
            //if (BID.Text.Trim() == string.Empty)
            //{
            //    //MessageBox.Show("erro", "رسالة ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    BID.ErrorText="برجاء ادخال اسم التسلسل";
            //    return;
            //}

            //if (BNameA.Text.Trim() == string.Empty)
            //{
            //    //MessageBox.Show("erro", "رسالة ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            //    BNameA.ErrorText = "برجاء ادخال اسم البنك";
            //    return;
            //}


            ////   && 

            ////{

            ////    try
            ////    {
            ////        if (frmType == "add")
            ////        {
            ////        dal.Execute_1(@"INSERT INTO BanksTbl(BID,BNameA,BNameE,Acc_Details_A,Acc_Details_E,BAccNo
            ////        , BTel, BFax, BEmail, BAccept, Bfacelty, Bmargin, BIban, Acc_No, Loan_Rate,BComnication,mainLcAccNo) 
            ////        VALUES('" + BID.Text + "','" + BNameA.Text + "','" + BNameE.Text +
            ////        "','"+txt_accName.Text+"','"+txt_accNameE.Text + "','" + BAccNo.Text + 
            ////        "','" + BTel.Text + "','" + BFax.Text + "','" + BEmail.Text + "','" + BAccept.Text.ToDecimal() +
            ////        "','" + txt_Facility.Text.ToDecimal() + "','" + txt_Margin.Text.ToDecimal() + "', '" + txt_Iban.Text + 
            ////        "','" + UC_Acc.ID.Text + "','" + Loans_Rate.Text.ToDecimal()+ "','" + txtComnication.Text.ToDecimal() + "','"+txtLcAcc.ID.Text+"')");
            ////        MessageBox.Show("تم الحفظ بنجاح", "رسالة الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////        clear_texts();
            ////        }
            ////        else
            ////        {
            ////            dal.Execute_1("update "+dal.db1+".dbo.BanksTbl set BID='" + BID.Text + "',BNameA='" + BNameA.Text + "',BNameE='" + BNameE.Text +
            ////                "',Acc_Details_A='" + txt_accName.Text + "',Acc_Details_E='" + txt_accNameE.Text +"', BAccNo='" + BAccNo.Text +
            ////              "',BTel='" + BTel.Text + "',BFax='" + BFax.Text + "',BEmail='" + BEmail.Text + "',BAccept='" + BAccept.Text.ToDecimal() +
            ////              "',Bfacelty='" + txt_Facility.Text.ToDecimal() + "',Bmargin='" + txt_Margin.Text.ToDecimal() + "' ,BIban='" + txt_Iban.Text +
            ////              "',Acc_No='" + UC_Acc.ID.Text + "',Loan_Rate='" + Loans_Rate.Text.ToDecimal() + "',BComnication='" + txtComnication.Text.ToDecimal() + "',mainLcAccNo='"+txtLcAcc.ID.Text+"' where BID='" + BID.Text + "' ");
            ////            MessageBox.Show("تم التعديل بنجاح", " تأكيد التعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            ////            clear_texts();
            ////        }
            ////    }
            ////    catch (System.Exception ex)
            ////    {
            ////        MessageBox.Show(ex.Message);
            ////    }
            ////}

            //DAL.BanksTbl bnk = new DAL.BanksTbl();
            //bnk.BID = Convert.ToInt32(BID.Text);
            //bnk.BNameA = BNameA.Text;
            //bnk.BNameE = BNameE.Text;
            //bnk.Acc_Details_A = txt_accName.Text;
            //bnk.Acc_Details_E = txt_accNameE.Text;
            //bnk.BAccNo = BAccNo.Text;
            //bnk.BTel = BTel.Text;
            //bnk.BFax = BFax.Text;
            //bnk.BEmail = BEmail.Text;
            //bnk.BAccept = BAccept.Text.ToDecimal();
            //bnk.Bfacelty = txt_Facility.Text.ToDecimal();
            //bnk.Bmargin = txt_Margin.Text.ToDecimal();
            //bnk.BIban = txt_Iban.Text;
            //bnk.Acc_No = UC_Acc.ID.Text;
            //bnk.Loan_Rate = Loans_Rate.Text.ToDecimal();
            //bnk.BComnication = txtComnication.Text.ToDecimal();
            //bnk.mainLcAccNo = txtLcAcc.ID.Text;

            //DAL.dbDataContext db = new DAL.dbDataContext();
            //db.BanksTbls.InsertOnSubmit(bnk);
            //db.SubmitChanges();

            //MessageBox.Show("تم الحفظ بنجاح", "رسالة الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);







        }

        public override void Save()
        {
            if (BID.Text.Trim() == string.Empty)
            {

                return;
            }

            if (BNameA.Text.Trim() == string.Empty)
            {

                return;
            }


            var db = new DAL.dbDataContext();
            //DAL.BanksTbl bnk = db.BanksTbls.FirstOrDefault();
            if (bnk.BID == "0")
            {
                db.BanksTbls.InsertOnSubmit(bnk);

            }
            else
            {
                db.BanksTbls.Attach(bnk);
            }
            SetData();

            db.SubmitChanges();

           // MessageBox.Show("تم الحفظ بنجاح", "رسالة الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);


            base.Save();
        }
       

            
        


        public override void SetData()
        {
            bnk.BID = BID.Text;
            bnk.BNameA = BNameA.Text;
            bnk.BNameE = BNameE.Text;
            bnk.Acc_Details_A = txt_accName.Text;
            bnk.Acc_Details_E = txt_accNameE.Text;
            bnk.BAccNo = BAccNo.Text;
            bnk.BTel = BTel.Text;
            bnk.BFax = BFax.Text;
            bnk.BEmail = BEmail.Text;
            bnk.BAccept = BAccept.Text.ToDecimal();
            bnk.Bfacelty = txt_Facility.Text.ToDecimal();
            bnk.Bmargin = txt_Margin.Text.ToDecimal();
            bnk.BIban = txt_Iban.Text;
            bnk.Acc_No = UC_Acc.ID.Text;
            bnk.Loan_Rate = Loans_Rate.Text.ToDecimal();
            bnk.BComnication = txtComnication.Text.ToDecimal();
            bnk.mainLcAccNo = txtLcAcc.ID.Text;
            bnk.MainLoanAccNo = txtLoanAcc.ID.Text;
            bnk.LoanIntrestAccNo = txtFeesAcc.ID.Text;

            base.SetData();
        }


        public override void GetData()
        {
            BID.Text = bnk.BID;
            BNameA.Text = bnk.BNameA;
            BNameE.Text = bnk.BNameE;
            txt_accName.Text = bnk.Acc_Details_A;
            txt_accNameE.Text = bnk.Acc_Details_E;
            BAccNo.Text = bnk.BAccNo;
            BFax.Text = bnk.BFax;
            BEmail.Text = bnk.BEmail;
            BAccept.Text = bnk.BAccept.ToString().ToDecimal().ToString("N2");
            txt_Facility.Text = bnk.Bfacelty.ToString().ToDecimal().ToString("N2");
            txt_Margin.Text = bnk.Bmargin.ToString().ToDecimal().ToString("N2");
            txt_Iban.Text = bnk.BIban;
            UC_Acc.ID.Text = bnk.Acc_No;
            Loans_Rate.Text = bnk.Loan_Rate.ToString().ToDecimal().ToString("N2"); ;
            txtComnication.Text = bnk.BComnication.ToString().ToDecimal().ToString("N2");
            txtLcAcc.ID.Text = bnk.mainLcAccNo;
            txtLoanAcc.ID.Text = bnk.MainLoanAccNo;
            txtFeesAcc.ID.Text = bnk.LoanIntrestAccNo;

            base.GetData();
        }

    
        public override void New()
        {
            bnk = new DAL.BanksTbl();
            base.New();
        }


        public override void CloseForm(Form frm)
        {
            base.CloseForm(frm);

        }

        

        public override void Search()
        {
            frm_serchbanks frmSrchBank = new frm_serchbanks();
            frmSrchBank.ShowDialog();


            frmType = "search";
            BID.Enabled = false;
          
            var db = new DAL.dbDataContext();
            bnk = db.BanksTbls.Where(b => b.BID == frmSrchBank.DGV1.CurrentRow.Cells[0].Value.ToString()).First();
            GetData();
         

            base.Search();
        }

       private void showData(string BankID)
        {
        try
        {
            //DataTable Bdt = dal.getDataTabl_1(@"select * from BanksTbl where BID='" + BankID + "'");
            //if (Bdt.Rows.Count > 0)
            //{
            //    BID.Text = Bdt.Rows[0]["BID"].ToString();
            //    BNameA.Text = Bdt.Rows[0]["BNameA"].ToString();
            //    BNameE.Text = Bdt.Rows[0]["BNameE"].ToString();
            //    txt_accName.Text = Bdt.Rows[0]["Acc_Details_A"].ToString();
            //    txt_accNameE.Text = Bdt.Rows[0]["Acc_Details_E"].ToString();
            //    BAccNo.Text = Bdt.Rows[0]["BAccNo"].ToString();
            //    BTel.Text = Bdt.Rows[0]["BTel"].ToString();
            //    BFax.Text = Bdt.Rows[0]["BFax"].ToString();
            //    BEmail.Text = Bdt.Rows[0]["BEmail"].ToString();
            //    BAccept.Text = Bdt.Rows[0]["BAccept"].ToString();
            //    txt_Facility.Text = Bdt.Rows[0]["Bfacelty"].ToString().ToDecimal().ToString();
            //    txt_Margin.Text = Bdt.Rows[0]["Bmargin"].ToString().ToDecimal().ToString();
            //    txt_Iban.Text = Bdt.Rows[0]["BIban"].ToString();
            //    UC_Acc.ID.Text = Bdt.Rows[0]["Acc_No"].ToString();
            //    Loans_Rate.Text = Bdt.Rows[0]["Loan_Rate"].ToString().ToDecimal().ToString();
            //    txtComnication.Text = Bdt.Rows[0]["BComnication"].ToString().ToDecimal().ToString(); ;
            //    txtLcAcc.ID.Text = Bdt.Rows[0]["mainLcAccNo"].ToString();

            //}
            }
            catch
            {
            }
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    
        private void BAccept_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void F8_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void F9_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void F10_KeyPress(object sender, KeyPressEventArgs e)
        {
            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)
            {
                e.Handled = true;
            }
        }

        private void Frm_Banks_Load(object sender, EventArgs e)
        {
            DAL.dbDataContext  db= new DAL.dbDataContext();
            UC_Acc.txtMainAcc.Text = "1221";
            UC_Acc.txtFinal.Text = "1";

            txtLcAcc.txtMainAcc.Text = "125";
            txtLcAcc.txtFinal.Text = "0";
           // New();

            //DAL.BanksTbl bnk = db.BanksTbls.First();

            //BID.Text = bnk.BID.ToString();
            //BNameA.Text = bnk.BNameA;
            //BNameE.Text = bnk.BNameE;
            //txt_accName.Text=bnk.Acc_Details_A;
            //txt_accNameE.Text=bnk.Acc_Details_E;
            //BAccNo.Text=bnk.BAccNo;
            //BFax.Text=bnk.BFax;
            //BEmail.Text=bnk.BEmail;
            //BAccept.Text=bnk.BAccept.ToString().ToDecimal().ToString("N2");
            //txt_Facility.Text = bnk.Bfacelty.ToString().ToDecimal().ToString("N2");
            //txt_Margin.Text = bnk.Bmargin.ToString().ToDecimal().ToString("N2");
            //txt_Iban.Text = bnk.BIban;
            //UC_Acc.ID.Text = bnk.Acc_No;
            //Loans_Rate.Text= bnk.Loan_Rate.ToString().ToDecimal().ToString("N2"); ;
            //txtComnication.Text= bnk.BComnication.ToString().ToDecimal().ToString("N2");
            //txtLcAcc.ID.Text = bnk.mainLcAccNo;


        }

       

        private void btnNew_Click(object sender, EventArgs e)
        {
            //clear_texts();
            //BSave.Enabled = true;
        }



        private void Frm_Banks_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.F1)
            //{
            //    save_();
            //}
        }



       
    }
}