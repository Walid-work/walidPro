using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ComboBox = System.Windows.Forms.ComboBox;

namespace Report_Pro.Loans
{
    public partial class frm_Loan : XtraForm
    {

        CultureInfo cul;
        string _branch = Properties.Settings.Default.BranchAccID;
        Assembly a = Assembly.Load("Report_Pro");

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public frm_Loan()
        {
            InitializeComponent();

            txtLoanPurpose.DataSource = dal.getDataTabl_1(@"SELECT Id,Loan_Purpose,Loan_Purpose_E FROM LoanPurpose ");
            txtLoanPurpose.ValueMember = "Id";
            if (dal.languh_ == "0")
            {
                txtLoanPurpose.DisplayMember = "Loan_Purpose";
            }
            else
            {
                txtLoanPurpose.DisplayMember = "Loan_Purpose_E";
            }


            txtLoanTearm.DataSource = dal.getDataTabl_1(@"SELECT id,descr,descr_E FROM LoanTearms");
            txtLoanTearm.ValueMember = "Id";
            if (dal.languh_ == "0")
            {
                txtLoanTearm.DisplayMember = "descr";
            }
            else
            {
                txtLoanTearm.DisplayMember = "descr_E";
            }
            BName.txtMainAcc.Text = "122";
            BName.txtFinal.Text = "1";
            Uc_Acc_M.txtFinal.Text = "1";

            if (ch_Murabaha.Checked == true)
            {
                Uc_Acc_M.txtMainAcc.Text = "2322";
            }
            else
            {
                Uc_Acc_M.txtMainAcc.Text = "122";
            }

        }

        private void frm_Loan_Load(object sender, EventArgs e)
        {

            getLoanID();
            addRows();
            L_StartDate.Focus();
        }

        private void BSave_Click(object sender, EventArgs e)
        {

            if (BName.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من رقم البنك", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Uc_Acc_M.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من الحساب المدين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtLoanPurpose.SelectedIndex == -1)
            {
                MessageBox.Show("تأكد من سبب القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLoanTearm.SelectedIndex == -1)
            {
                MessageBox.Show("تأكد من نوع القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (txtLoanAcc.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من حساب القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveLoanDataWithUpdateJor();
            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void saveLoanDataWithUpdateJor()
        {
            ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", a);


            foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
            {
                gettot();
                if (txtLoanValue.Value <= 0 || txtTotal.Value <= 0 || txtLoanValue.Value != txtTotal.Value)
                {
                    MessageBox.Show("تأكد من توازن القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (r.PayValue.Text.ToDecimal() > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                {
                    DataTable dt_ = dal.getDataTabl_1(@"select * from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");
                    if (dt_.Rows.Count > 0)
                    {

                        dal.Execute_1(@"UPDATE LoansTbl set LoanNo='" + txtLoanNo.Text + "',BankId='" + BName.ID.Text + "',LoanACC='" + txtLoanAcc.ID.Text +
                            "',LoanDate='" + L_StartDate.Value.ToString("yyyy-MM-dd") + "',NumberOfPayments='" + NoOfPayments.Value + "',LoanValue='" + txtLoanValue.Value + "',PaymentNo='" + r.paySer.Value +
                            "', PaymentValue='" + r.PayValue.Text.ToDecimal() + "',StartDate='" + r.startDate.Value.ToString("yyyy-MM-dd") +
                            "', MaturityDate='" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "', Rate='" + r.intrestRate.Text.ToDecimal() +
                            "',LoanPurpose='" + Convert.ToString(txtLoanPurpose.SelectedValue) + "',LoanRefrance='" + txtLoanRefrance.Text + "',isMurabha='" + ch_Murabaha.Checked +
                            "',Branch_code = '" + _branch + "' ,Loan_Tearm='" + Convert.ToString(txtLoanTearm.SelectedValue) + "', DebitAcc='" + Uc_Acc_M.ID.Text +
                            "'  where  id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");

                        DataTable checkJor = dal.getDataTabl_1(@"select * from daily_transaction where ser_no = '" + txtJorSer.Text + "'");
                        if (checkJor.Rows.Count > 0)
                        {
                            UpdateJor();
                        }



                    }
                    else
                    {

                        dal.Execute_1(@"INSERT INTO LoansTbl(id,LoanNo,BankId,LoanACC,LoanDate,NumberOfPayments,LoanValue,PaymentNo,
                        PaymentValue,StartDate,MaturityDate,Rate,LoanPurpose,LoanRefrance,Branch_code,Loan_Tearm,DebitAcc,isMurabha)
                        VALUES(  '" + txtLoanId.Text + "', '" + txtLoanNo.Text + "','" + BName.ID.Text + "','" + txtLoanAcc.ID.Text + "','" + L_StartDate.Value.ToString("yyyy-MM-dd") + "','" + NoOfPayments.Value +
                        "','" + txtLoanValue.Value + "','" + r.paySer.Value + "','" + r.PayValue.Text.ToDecimal() + "','" + r.startDate.Value.ToString("yyyy-MM-dd") +
                        "','" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "','" + r.intrestRate.Text.ToDecimal() + "','" + Convert.ToString(txtLoanPurpose.SelectedValue) +
                        "', '" + txtLoanRefrance.Text + "','" + _branch + "','" + Convert.ToString(txtLoanTearm.SelectedValue) + "','" + Uc_Acc_M.ID.Text + "','" + ch_Murabaha.Checked + "')");
                        //MessageBox.Show(rm.GetString("msgSave", cul), rm.GetString("msgSave_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                        chLoanSave.Checked = true;
                    }
                }
            }
            //MessageBox.Show(rm.GetString("msgSave", cul), rm.GetString("msgSave_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

            dal.Execute_1(@"delete from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo >'" + flowLayoutPanel1.Controls.Count + "' ");

        }


        private void saveLoanData()
        {
            ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", a);

            foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
            {

                if (r.PayValue.Text.ToDecimal() > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                {
                    DataTable dt_ = dal.getDataTabl_1(@"select * from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");
                    if (dt_.Rows.Count > 0)
                    {

                        dal.Execute_1(@"UPDATE LoansTbl set LoanNo='" + txtLoanNo.Text + "',BankId='" + BName.ID.Text + "',LoanACC='" + txtLoanAcc.ID.Text +
                            "',LoanDate='" + L_StartDate.Value.ToString("yyyy-MM-dd") + "',NumberOfPayments='" + NoOfPayments.Value + "',LoanValue='" + txtLoanValue.Value + "',PaymentNo='" + r.paySer.Value +
                            "', PaymentValue='" + r.PayValue.Text.ToDecimal() + "',StartDate='" + r.startDate.Value.ToString("yyyy-MM-dd") +
                            "', MaturityDate='" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "', Rate='" + r.intrestRate.Text.ToDecimal() +
                            "',LoanPurpose='" + Convert.ToString(txtLoanPurpose.SelectedValue) + "',LoanRefrance='" + txtLoanRefrance.Text +
                            "',Branch_code = '" + _branch + "',Loan_Tearm='" + Convert.ToString(txtLoanTearm.SelectedValue) + "', DebitAcc='" + Uc_Acc_M.ID.Text + "' where  id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");
                        //       MessageBox.Show(rm.GetString("msgEdit", cul), rm.GetString("msgEdit_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                    else
                    {

                        dal.Execute_1(@"INSERT INTO LoansTbl(id,LoanNo,BankId,LoanACC,LoanDate,NumberOfPayments,LoanValue,PaymentNo,
                        PaymentValue,StartDate,MaturityDate,Rate,LoanPurpose,LoanRefrance,Branch_code,Loan_Tearm,DebitAcc)
                        VALUES(  '" + txtLoanId.Text + "', '" + txtLoanNo.Text + "','" + BName.ID.Text + "','" + txtLoanAcc.ID.Text + "','" + L_StartDate.Value.ToString("yyyy-MM-dd") + "','" + NoOfPayments.Value +
                        "','" + txtLoanValue.Value + "','" + r.paySer.Value + "','" + r.PayValue.Text.ToDecimal() + "','" + r.startDate.Value.ToString("yyyy-MM-dd") +
                        "','" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "','" + r.intrestRate.Text.ToDecimal() + "','" + Convert.ToString(txtLoanPurpose.SelectedValue) +
                        "', '" + txtLoanRefrance.Text + "','" + _branch + "','" + Convert.ToString(txtLoanTearm.SelectedValue) + "','" + Uc_Acc_M.ID.Text + "')");
                        //MessageBox.Show(rm.GetString("msgSave", cul), rm.GetString("msgSave_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                        chLoanSave.Checked = true;
                    }
                }
            }


            dal.Execute_1(@"delete from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo >'" + flowLayoutPanel1.Controls.Count + "' ");
            //  MessageBox.Show(rm.GetString("msgSave", cul), rm.GetString("msgSave_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

        }



        private void addRows()
        {
            //try
            //{
            if ((NoOfPayments.Value - flowLayoutPanel1.Controls.Count) > 0)
            {
                for (int i = 1; i <= (NoOfPayments.Value - flowLayoutPanel1.Controls.Count); i++)
                {
                    MyControls.LoanRow r = new MyControls.LoanRow();
                    flowLayoutPanel1.Controls.Add(r);
                    r.paySer.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                    r.intrestRate.Value = txtIntrestRate.Value;
                    r.KeyDown += r_KeyDown;
                }
            }
            else if ((NoOfPayments.Value - flowLayoutPanel1.Controls.Count) < 0)
            {
                for (int i = 1; i <= (flowLayoutPanel1.Controls.Count - NoOfPayments.Value); i++)

                {
                    flowLayoutPanel1.Controls.RemoveAt(flowLayoutPanel1.Controls.Count - 1);
                }
            }
            //}
            //catch { }

        }


        private void NoOfPayments_ValueChanged(object sender, EventArgs e)
        {
            addRows();
        }


        private void getLoanID()
        {
            txtLoanId.Text = dal.GetCell_1("select isnull(MAX(id)+1,1) from LoansTbl").ToString();

        }

        private void txtLoanId_TextChanged(object sender, EventArgs e)
        {

            showLoanData(txtLoanId.Text.ParseInt(0));
        }


        private void showLoanData(int id_)
        {

            // string InvNum = lcNo_ + "-" + invNo_;
            DataTable loanData = dal.getDataTabl_1(@"SELECT A.* ,B.sanad_no,B.g_date FROM LoansTbl As A 
                left Join(select * from (select p.ser_no,p.sanad_no,p.g_date,p.BRANCH_code, ROW_NUMBER() OVER(PARTITION BY p.ser_no ORDER BY p.ser_no) AS DuplicateCount 
                FROM daily_transaction As P) as t1  where t1.DuplicateCount = 1) as B on A.Jor_ser_no=B.ser_no and A.Branch_code=B.BRANCH_code where A.id='" + id_ + "'");
            if (loanData.Rows.Count > 0)
            {
                txtLoanId.Text = loanData.Rows[0]["Id"].ToString();
                BName.ID.Text = loanData.Rows[0]["BankId"].ToString();
                txtLoanAcc.ID.Text = loanData.Rows[0]["LoanACC"].ToString();
                L_StartDate.Text = loanData.Rows[0]["LoanDate"].ToString();
                NoOfPayments.Text = loanData.Rows[0]["NumberOfPayments"].ToString();
                txtLoanNo.Text = loanData.Rows[0]["LoanNo"].ToString();
                txtIntrestRate.Text = loanData.Rows[0]["Rate"].ToString().ToDecimal().ToString();
                txtLoanValue.Text = loanData.Rows[0]["LoanValue"].ToString();
                txtLoanPurpose.SelectedValue = loanData.Rows[0]["LoanPurpose"].ToString().ParseInt(0);
                txtLoanRefrance.Text = loanData.Rows[0]["LoanRefrance"].ToString();
                ch_Murabaha.Checked = Convert.ToBoolean(loanData.Rows[0]["isMurabha"].ToString());
                txtLoanTearm.SelectedValue = loanData.Rows[0]["Loan_Tearm"].ToString();

                Uc_Acc_M.ID.Text = loanData.Rows[0]["DebitAcc"].ToString();

                txtJorSer.Text = loanData.Rows[0]["Jor_ser_no"].ToString();
                txtSanadSer.Text = loanData.Rows[0]["sanad_no"].ToString();
                jorDate.Text = loanData.Rows[0]["g_date"].ToString();
                int i = 0;
                flowLayoutPanel1.Controls.Clear();

                foreach (DataRow r in loanData.Rows)
                {


                    MyControls.LoanRow row = new MyControls.LoanRow();
                    row.paySer.Text = loanData.Rows[i]["PaymentNo"].ToString();
                    row.PayValue.Text = loanData.Rows[i]["PaymentValue"].ToString();
                    row.startDate.Text = loanData.Rows[i]["StartDate"].ToString();
                    row.maturityDate.Text = loanData.Rows[i]["MaturityDate"].ToString();
                    row.intrestRate.Text = loanData.Rows[i]["Rate"].ToString().ToDecimal().ToString();

                    flowLayoutPanel1.Controls.Add(row);
                    i = i + 1;
                }

                chLoanSave.Checked = true;
            }
            else
            {
                chLoanSave.Checked = false;
            }
            txtLoanAcc.leaveID();
            BName.leaveID();
            gettot();
        }



        private void BSearch_Click(object sender, EventArgs e)
        {
            Loans.frmLoanSearch frm = new Loans.frmLoanSearch();
            frm.ShowDialog();
            txtLoanId.Text = frm.DGV1.CurrentRow.Cells[0].Value.ToString();
        }

        private void BStatment_Click(object sender, EventArgs e)
        {
            RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
            frm.UC_Acc1.ID.Text = txtLoanAcc.ID.Text;
            frm.ShowDialog();

        }

        private void getJorSer()
        {

            txtJorSer.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + _branch
                     + "' and ACC_YEAR= '" + txtYear.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

            txtSanadSer.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + _branch
                + "' and ACC_YEAR= '" + txtYear.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


        }

        private void btnCreateJor_Click(object sender, EventArgs e)
        {
            saveLoanData();
            DataTable checkJor = dal.getDataTabl_1(@"select * from daily_transaction where ser_no = '" + txtJorSer.Text + "'");
            if (checkJor.Rows.Count > 0)
            {
                UpdateJor();

            }
            else
            {
                AddJor();

            }
            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }


        private void UpdateJor()
        {


            if (dal.sqlconn_1.State == ConnectionState.Closed)
            {
                dal.sqlconn_1.Open();
            }
            SqlCommand cmd = dal.sqlconn_1.CreateCommand();
            SqlTransaction trans;
            trans = dal.sqlconn_1.BeginTransaction();
            cmd.Connection = dal.sqlconn_1;
            cmd.Transaction = trans;


            try
            {
                int JorSer;
                if (txtJorSer.Text != string.Empty)
                {
                    cmd.CommandText = @"delete from daily_transaction where ser_no='" + txtJorSer.Text + "' and Branch_code='" + _branch + "'";
                    cmd.ExecuteNonQuery();
                    gettot();
                    if (txtLoanValue.Value <= 0 || txtTotal.Value <= 0 || txtLoanValue.Value != txtTotal.Value)
                    {
                        MessageBox.Show("تأكد من توازن القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (txtLoanAcc.ID.Text == string.Empty)
                    {
                        MessageBox.Show("تأكد من حساب القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        txtLoanAcc.Focus();
                        return;
                    }
                    if (BName.ID.Text == string.Empty)
                    {
                        MessageBox.Show("تأكد من حساب البنك", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        BName.Focus();
                        return;
                    }
                    if (!dal.IsDateTime(jorDate.Text))
                    {
                        MessageBox.Show("تأكد تاريخ القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        jorDate.Focus();
                        return;
                    }

                    if (!dal.IsDateTime(L_StartDate.Text))
                    {
                        MessageBox.Show("تأكد تاريخ بداية القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        L_StartDate.Focus();
                        return;
                    }

                    if (txtJorSer.Text.Contains('M'))
                    {
                        var Jor_ser = txtJorSer.Text.Split('M');
                        JorSer = Convert.ToInt32(Jor_ser[1]);
                    }

                    else
                    {
                        JorSer = Convert.ToInt32(txtJorSer.Text);
                    }


                    string DbDesc = "صرف قرض رقم " + txtLoanNo.Text + " - " + L_StartDate.Text.ToString();
                    cmd.CommandText = @"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                   , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + Uc_Acc_M.ID.Text + "','" + _branch + "','" +
                            txtJorSer.Text + "','1','" + txtLoanValue.Value + "','0','" + txtLoanValue.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                            "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + DbDesc + "','0','810','" + JorSer + "')";
                    cmd.ExecuteNonQuery();


                    foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
                    {

                        if (r.PayValue.Text.ToDecimal() > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                        {

                            string crDesc = "صرف الدفعة رقم " + r.paySer.Text + " من القرض - " + L_StartDate.Text.ToString();

                            cmd.CommandText = @"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                            , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                             VALUES('" + txtYear.Text + "','" + txtLoanAcc.ID.Text + "','" + _branch + "','" +
                               txtJorSer.Text + "','1','0','" + r.PayValue.Text.ToDecimal() + "','" + -r.PayValue.Text.ToDecimal() + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                               "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + crDesc + "','0','1','" + JorSer + "')";
                            cmd.ExecuteNonQuery();


                        }


                    }
                    //MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);



                    trans.Commit();
                }
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





            //---


            // UpdateJor();









        }



        private void AddJor()
        {


            if (dal.sqlconn_1.State == ConnectionState.Closed)
            {
                dal.sqlconn_1.Open();
            }
            SqlCommand cmd = dal.sqlconn_1.CreateCommand();
            SqlTransaction trans;
            trans = dal.sqlconn_1.BeginTransaction();
            cmd.Connection = dal.sqlconn_1;
            cmd.Transaction = trans;


            try
            {
                //cmd.CommandText = @"delete  FROM fund_Balance_Detials WHERE branch_code='" + Branch.ID.Text + "' and cast(G_date as date) = '" + ToDate.Value.ToString("yyyy-MM-dd") + "'";
                //cmd.ExecuteNonQuery();

                int JorSer;
                if (txtJorSer.Text != string.Empty)
                {
                    cmd.CommandText = @"delete from daily_transaction where ser_no='" + txtJorSer.Text + "' and Branch_code='" + _branch + "'";
                    cmd.ExecuteNonQuery();
                }
                else
                {
                    getJorSer();
                }
                gettot();
                if (txtLoanValue.Value <= 0 || txtTotal.Value <= 0 || txtLoanValue.Value != txtTotal.Value)
                {
                    MessageBox.Show("تأكد من توازن القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (txtLoanAcc.ID.Text == string.Empty)
                {
                    MessageBox.Show("تأكد من حساب القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    txtLoanAcc.Focus();
                    return;
                }
                if (BName.ID.Text == string.Empty)
                {
                    MessageBox.Show("تأكد من حساب البنك", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    BName.Focus();
                    return;
                }
                if (!dal.IsDateTime(jorDate.Text))
                {
                    MessageBox.Show("تأكد تاريخ القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    jorDate.Focus();
                    return;
                }

                if (!dal.IsDateTime(L_StartDate.Text))
                {
                    MessageBox.Show("تأكد تاريخ بداية القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    L_StartDate.Focus();
                    return;
                }

                if (txtJorSer.Text.Contains('M'))
                {
                    var Jor_ser = txtJorSer.Text.Split('M');
                    JorSer = Convert.ToInt32(Jor_ser[1]);
                }

                else
                {
                    JorSer = Convert.ToInt32(txtJorSer.Text);
                }


                string DbDesc = "صرف قرض رقم " + txtLoanNo.Text + " - " + L_StartDate.Text.ToString();
                cmd.CommandText = @"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                    , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + Uc_Acc_M.ID.Text + "','" + _branch + "','" +
                txtJorSer.Text + "','1','" + txtLoanValue.Value + "','0','" + txtLoanValue.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + DbDesc + "','0','810','" + JorSer + "')";
                cmd.ExecuteNonQuery();


                foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
                {

                    if (r.PayValue.Text.ToDecimal() > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                    {

                        string crDesc = "صرف الدفعة رقم " + r.paySer.Text + " من القرض - " + L_StartDate.Text.ToString();

                        cmd.CommandText = @"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                     , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                      VALUES('" + txtYear.Text + "','" + txtLoanAcc.ID.Text + "','" + _branch + "','" +
                               txtJorSer.Text + "','1','0','" + r.PayValue.Text.ToDecimal() + "','" + -r.PayValue.Text.ToDecimal() + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                               "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + crDesc + "','0','1','" + JorSer + "')";
                        cmd.ExecuteNonQuery();

                        cmd.CommandText = @"UPDATE LoansTbl SET Jor_ser_no = '" + txtJorSer.Text + "' WHERE id =  '" + txtLoanId.Text + "' ";
                        cmd.ExecuteNonQuery();


                        cmd.CommandText = @"UPDATE serial_no SET daily_sn_ser='" + txtSanadSer.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + _branch + "' and ACC_YEAR='" + txtYear.Text + "' ";
                        cmd.ExecuteNonQuery();
                    }


                }
                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

                trans.Commit();


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





            //---


            // UpdateJor();









        }


        public void gettot()
        {
            decimal totDb = 0;

            foreach (MyControls.LoanRow c in flowLayoutPanel1.Controls)
            {

                totDb += c.PayValue.Text.ToDecimal();
                txtTotal.Text = totDb.ToString();



            }
        }


        private void btnPrintJor_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            DataTable dt_ = dal.getDataTabl_1(@"select A.ser_no,A.ACC_NO,A.g_date,A.desc2,
            a.meno,A.loh,A.sanad_no,A.BRANCH_code,A.user_name,A.COST_CENTER,
            A.CAT_CODE ,B.PAYER_NAME,B.payer_l_name,C.COST_name,C.COST_E_NAME,
            D.CAT_NAME,E.BRANCH_name,E.BRANCH_E_NAME
            from daily_transaction as A
            inner join payer2 as B on A.ACC_NO = B.ACC_NO and a.BRANCH_code=B.BRANCH_code
            inner join COST_CENTER  as C on a.COST_CENTER = C.COST_CODE
            inner Join CATEGORY as D on D.CAT_CODE=A.CAT_CODE
            inner join BRANCHS as E on A.BRANCH_code=E.BRANCH_code

            where a.ser_no='" + txtJorSer.Text + "' and A.BRANCH_CODE = 'A1110' order by A.sorting_ser");

            DataTable dt_Loan = dal.getDataTabl_1(@"SELECT A.id,A.LoanNo,A.BankId,A.LoanACC,A.LoanDate,A.NumberOfPayments,A.LoanValue,A.PaymentNo,A.PaymentValue
            ,A.StartDate,A.MaturityDate,A.Rate,A.LoanPurpose,A.LoanRefrance,A.Branch_code,A.Jor_ser_no
            ,B.PAYER_NAME,B.payer_l_name,C.Loan_Purpose,C.Loan_Purpose_E
              FROM LoansTbl As A
              inner Join payer2 as B  on A.BankId=B.ACC_NO and A.Branch_code=B.BRANCH_code
              inner join LoanPurpose as C on c.Id=A.LoanPurpose
              where A.LoanNo='" + txtLoanNo.Text + "'");



            RPT.Form1 frm = new RPT.Form1();
            RPT.rpt_DailyEntry rpt = new RPT.rpt_DailyEntry();
            RPT.reportDS ds = new RPT.reportDS();
            ds.Tables["dt_JorPrint"].Merge(dt_);
            ds.Tables["dt_LoandDetials"].Merge(dt_Loan);
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;

            // rpt.DataDefinition.FormulaFields["branchCode"].Text = "'" + dt_.Rows[0]["BRANCH_code"].ToString() + "'";
            rpt.DataDefinition.FormulaFields["companyName"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            //  rpt.DataDefinition.FormulaFields["branchName"].Text = "'" +dt_.Rows[0]["BRANCH_name"].ToString()+"'";


            frm.ShowDialog();

            ////ds.WriteXmlSchema("schema_rpt.xml");


            Cursor.Current = Cursors.Default;


        }

        private void BPrint_Click(object sender, EventArgs e)
        {

            DataTable dt_Loan = dal.getDataTabl_1(@"SELECT A.id,A.LoanNo,A.BankId,A.LoanACC,A.LoanDate,A.NumberOfPayments,A.LoanValue,A.PaymentNo,A.PaymentValue
            ,A.StartDate,A.MaturityDate,A.Rate,A.LoanPurpose,A.LoanRefrance,A.Branch_code,A.Jor_ser_no
            ,B.PAYER_NAME,B.payer_l_name,C.Loan_Purpose,C.Loan_Purpose_E
              FROM LoansTbl As A
              inner Join payer2 as B  on A.BankId=B.ACC_NO and A.Branch_code=B.BRANCH_code
              inner join LoanPurpose as C on c.Id=A.LoanPurpose
              where A.LoanNo='" + txtLoanNo.Text + "'");



            RPT.Form1 frm = new RPT.Form1();
            //RPT.rpt_DailyEntry rpt = new RPT.rpt_DailyEntry();
            //rpt.SetDataSource(dt_);
            RPT.reportDS ds = new RPT.reportDS();
            ds.Tables["dt_LoandDetials"].Merge(dt_Loan);
            RPT.rpt_LoanDetials rpt_1 = new RPT.rpt_LoanDetials();
            rpt_1.SetDataSource(dt_Loan);

            frm.crystalReportViewer1.ReportSource = rpt_1;

            //rpt.DataDefinition.FormulaFields["branchCode"].Text = "'" + dt_.Rows[0]["BRANCH_code"].ToString() + "'";
            //rpt.DataDefinition.FormulaFields["companyName"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            //rpt.DataDefinition.FormulaFields["branchName"].Text = "'" + dt_.Rows[0]["BRANCH_name"].ToString() + "'";


            frm.ShowDialog();

            ////ds.WriteXmlSchema("schema_rpt.xml");

        }

        private void txtJorSer_TextChanged(object sender, EventArgs e)
        {
            //if (txtJorSer.Text.Trim() == string.Empty)
            //{
            //    btnCreateJor.Enabled = true;
            //}
            //else
            //{
            //    btnCreateJor.Enabled = false;
            //}
        }

        private void chLoanSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chLoanSave.Checked == true)
            {
                chLoanSave.Text = "Saved";
                chLoanSave.BackColor = Color.GreenYellow;
                //    btnCreateJor.Enabled = true;
            }
            else
            {
                chLoanSave.Text = " Not Saved";
                chLoanSave.BackColor = Color.Transparent;
                //btnCreateJor.Enabled = false;
            }
        }



        private void addLoanAcc()
        {
            string accDesc = "";
            string accDesc_E = "";
            string loanAccNo = "";
            string addDate = "";

            DataTable dtCheckAcc = dal.getDataTabl_1(@"SELECT ACC_NO,PAYER_NAME,payer_l_name FROM payer2 where PAYER_NAME like '%" + txtLoanNo.Text + "%' and MAIN_NO='" + txtMainLoanAccNo.Text + "'");
            if (dtCheckAcc.Rows.Count > 0)
            {
                if (MessageBox.Show("توجد حسابات تحتوي نفس رقم القرض ... هل تريد الاضافة؟  ", "تحذير !!!", MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation, MessageBoxDefaultButton.Button2) == DialogResult.Yes)
                {
                    accDesc = "قرض رقم : " + txtLoanNo.Text;
                    accDesc_E = "Loan No : " + txtLoanNo.Text;

                    loanAccNo = dal.GetCell_1(@"select isnull(max(acc_no)+ 1,'0001') from payer2 where MAIN_NO = '" + txtMainLoanAccNo.Text + "' and BRANCH_code = 'a1110'").ToString();
                    addDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");


                    dal.Execute_1(@"insert into payer2 (acc_type,ACC_NO,BRANCH_code,MAIN_NO,PAYER_NAME,payer_l_name,t_final,t_level
                        ,PREV_NO,balance,MAIN_MEZAN,S_DATE,user_id,med_MEZAN,MASTER_ACC_NO,MASTER_PREV_NO) values('A',
                         '" + loanAccNo + "','A1110','" + txtMainLoanAccNo.Text + "','" + accDesc + "','" + accDesc_E +
                                "','1','4','" + txtMainLoanAccNo.Text + "','0','231','" + addDate + "','" + Program.userID + "','2101','23','" + txtMainLoanAccNo.Text + "')");


                    dal.Execute_1(@"update LoansTbl set  LoanACC ='" + loanAccNo + "' where LoanNo='" + txtLoanNo.Text + "' ");

                }
                else
                {
                    dgAccNo.DataSource = dtCheckAcc;
                }
            }

            else
            {
                dgAccNo.DataSource = null;
                dgAccNo.Rows.Clear();



                accDesc = "قرض رقم : " + txtLoanNo.Text;
                accDesc_E = "Loan No : " + txtLoanNo.Text;

                loanAccNo = dal.GetCell_1(@"select max(acc_no) + 1 from payer2 where MAIN_NO = '" + txtMainLoanAccNo.Text + "' and BRANCH_code = 'a1110'").ToString();
                addDate = DateTime.Now.ToString("yyyy-MM-dd HH:mm:ss");



                dal.Execute_1(@"insert into payer2 (acc_type,ACC_NO,BRANCH_code,MAIN_NO,PAYER_NAME,payer_l_name,t_final,t_level
                        ,PREV_NO,balance,MAIN_MEZAN,S_DATE,user_id,med_MEZAN,MASTER_ACC_NO,MASTER_PREV_NO) values('A',
                         '" + loanAccNo + "','A1110','" + txtMainLoanAccNo.Text + "','" + accDesc + "','" + accDesc_E +
                            "','1','4','" + txtMainLoanAccNo.Text + "','0','231','" + addDate + "','" + Program.userID + "','2101','23','" + txtMainLoanAccNo.Text + "')");

                dal.Execute_1(@"update LoansTbl set  LoanACC ='" + loanAccNo + "' where LoanNo='" + txtLoanNo.Text + "' ");

                txtLoanAcc.ID.Text = loanAccNo;
            }

        }




        private void BName_Load(object sender, EventArgs e)
        {
            DataTable dtBank = dal.getDataTabl_1(@"select * from BanksTbl where Acc_no='" + BName.ID.Text + "'");
            if (dtBank.Rows.Count > 0)
            {

                txtMainLoanAccNo.Text = dtBank.Rows[0]["MainLoanAccNo"].ToString();
                if (ch_Murabaha.Checked == false)
                {
                    Uc_Acc_M.ID.Text = BName.ID.Text;
                    Uc_Acc_M.txtMainAcc.Text = "122";
                }
                else
                {
                    Uc_Acc_M.txtMainAcc.Text = "2322";

                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (dal.getDataTabl_1(@"select ACC_NO FROM payer2 where ACC_NO='" + txtMainLoanAccNo.Text + "'").Rows.Count > 0)
            {
                addLoanAcc();
            }
            else
            {
                MessageBox.Show("تأكد من الحساب الرئيسي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }


        }

        private void dgAccNo_DoubleClick(object sender, EventArgs e)
        {
            txtLoanAcc.ID.Text = dgAccNo.CurrentRow.Cells[0].Value.ToString();
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



                    else
                        func(control.Controls);
            };

            func(Controls);
        }

        private void BNew_Click(object sender, EventArgs e)
        {

            ClearTextBoxes();
            NoOfPayments.Value = 1;
            getLoanID();
            addRows();
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtLoanNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLoanNo.Text.Trim() != string.Empty)
            {
                NoOfPayments.Focus();
            }
        }

        private void txtIntrestRate_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label25_Click(object sender, EventArgs e)
        {

        }

        private void label24_Click(object sender, EventArgs e)
        {

        }

        private void NoOfPayments_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && NoOfPayments.Value > 0)
            {
                txtLoanValue.Focus();
            }
        }

        private void txtLoanValue_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLoanValue.Value > 0)
            {
                txtIntrestRate.Focus();
            }
        }

        private void txtIntrestRate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtIntrestRate.Value > 0)
            {
                BName.ID.Focus();
            }
        }

        private void BName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && BName.ID.Text.Trim() != string.Empty)
            {
                txtLoanAcc.ID.Focus();
            }
        }

        private void txtLoanAcc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLoanAcc.ID.Text.Trim() != string.Empty)
            {
                txtLoanPurpose.Focus();
            }
        }

        private void txtLoanPurpose_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtLoanRefrance.Focus();
            }
        }



        private void L_StartDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dal.IsDateTime(L_StartDate.Text))
            {
                txtLoanNo.Focus();
            }
        }

        private void txtLoanValue_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtLoanValue_KeyUp(object sender, KeyEventArgs e)
        {

        }

        private void txtLoanNo_KeyUp(object sender, KeyEventArgs e)
        {
            fillFristRow();
        }

        void fillFristRow()
        {
            foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
            {
                if (flowLayoutPanel1.Controls.GetChildIndex(r) == 0)
                {
                    r.startDate.Text = L_StartDate.Text;
                    r.intrestRate.Value = txtIntrestRate.Value;
                    r.PayValue.Value = txtLoanValue.Value;
                }
            }
        }

        private void L_StartDate_KeyUp(object sender, KeyEventArgs e)
        {
            fillFristRow();
        }

        private void txtIntrestRate_KeyUp(object sender, KeyEventArgs e)
        {
            fillFristRow();
        }

        private void ch_Murabaha_CheckedChanged(object sender, EventArgs e)
        {
            if (ch_Murabaha.Checked == true)
            {
                Uc_Acc_M.txtMainAcc.Text = "2322";
            }
            else
            {
                Uc_Acc_M.txtMainAcc.Text = "122";
            }

        }

        private void frm_Loan_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control && e.KeyCode == Keys.N)
            {
                BNew_Click(sender, e);
            }


            if (e.KeyCode == Keys.Enter)
            {
                int index = flowLayoutPanel1.Controls.GetChildIndex(ActiveControl);

                foreach (MyControls.LoanRow inv_r in flowLayoutPanel1.Controls)
                {

                    inv_r.paySer.Text = (flowLayoutPanel1.Controls.GetChildIndex(inv_r) + 1).ToString();

                    if (flowLayoutPanel1.Controls.Count - 1 == index)
                    {
                        if (inv_r.paySer.Text == string.Empty)
                        {
                            inv_r.Dispose();

                        }


                        MyControls.LoanRow r = new MyControls.LoanRow();

                        flowLayoutPanel1.Controls.Add(r);
                        r.paySer.Text = (flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();

                        r.paySer.Focus();
                        r.KeyDown += r_KeyDown;
                    }
                    else if (flowLayoutPanel1.Controls.GetChildIndex(inv_r) == index + 1)
                    {
                        inv_r.PayValue.Focus();
                    }
                    else { }
                }



            }
        }

        public void r_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            base.OnKeyDown(e);
        }

        private void Uc_Acc_M_Load(object sender, EventArgs e)
        {

        }

        private void btnUploadDoc__Click(object sender, EventArgs e)
        {

        }

        private void btnAddAccount(object sender, EventArgs e)
        {
            if (dal.getDataTabl_1(@"select ACC_NO FROM payer2 where ACC_NO='" + txtMainLoanAccNo.Text + "'").Rows.Count > 0)
            {
                addLoanAcc();
            }
            else
            {
                MessageBox.Show("تأكد من الحساب الرئيسي", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (BName.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من رقم البنك", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (Uc_Acc_M.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من الحساب المدين", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            if (txtLoanPurpose.SelectedIndex == -1)
            {
                MessageBox.Show("تأكد من سبب القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (txtLoanTearm.SelectedIndex == -1)
            {
                MessageBox.Show("تأكد من نوع القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (txtLoanAcc.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من حساب القرض", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            saveLoanDataWithUpdateJor();
            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void BExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();

        }

        private void BPrint_HyperlinkClick(object sender, DevExpress.Utils.HyperlinkClickEventArgs e)
        {

        }

        private void BPrint_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            DataTable dt_Loan = dal.getDataTabl_1(@"SELECT A.id,A.LoanNo,A.BankId,A.LoanACC,A.LoanDate,A.NumberOfPayments,A.LoanValue,A.PaymentNo,A.PaymentValue
            ,A.StartDate,A.MaturityDate,A.Rate,A.LoanPurpose,A.LoanRefrance,A.Branch_code,A.Jor_ser_no
            ,B.PAYER_NAME,B.payer_l_name,C.Loan_Purpose,C.Loan_Purpose_E
              FROM LoansTbl As A
              inner Join payer2 as B  on A.BankId=B.ACC_NO and A.Branch_code=B.BRANCH_code
              inner join LoanPurpose as C on c.Id=A.LoanPurpose
              where A.LoanNo='" + txtLoanNo.Text + "'");



            RPT.Form1 frm = new RPT.Form1();
            //RPT.rpt_DailyEntry rpt = new RPT.rpt_DailyEntry();
            //rpt.SetDataSource(dt_);
            RPT.reportDS ds = new RPT.reportDS();
            ds.Tables["dt_LoandDetials"].Merge(dt_Loan);
            RPT.rpt_LoanDetials rpt_1 = new RPT.rpt_LoanDetials();
            rpt_1.SetDataSource(dt_Loan);

            frm.crystalReportViewer1.ReportSource = rpt_1;

            //rpt.DataDefinition.FormulaFields["branchCode"].Text = "'" + dt_.Rows[0]["BRANCH_code"].ToString() + "'";
            //rpt.DataDefinition.FormulaFields["companyName"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            //rpt.DataDefinition.FormulaFields["branchName"].Text = "'" + dt_.Rows[0]["BRANCH_name"].ToString() + "'";


            frm.ShowDialog();

            ////ds.WriteXmlSchema("schema_rpt.xml");

        }

        private void BStatment_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
            frm.UC_Acc1.ID.Text = txtLoanAcc.ID.Text;
            frm.ShowDialog();
        }

        private void BSearch_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            Loans.frmLoanSearch frm = new Loans.frmLoanSearch();
            frm.ShowDialog();
            txtLoanId.Text = frm.DGV1.CurrentRow.Cells[0].Value.ToString();

        }

        private void BNew_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            ClearTextBoxes();
            NoOfPayments.Value = 1;
            getLoanID();
            addRows();
        }

        private void btnUploadDoc_Click(object sender, EventArgs e)
        {
            OpenFileDialog opnFile = new OpenFileDialog();
            opnFile.Filter = "All Files|*.*|pdf|*.pdf|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
            opnFile.FilterIndex = 2;
            opnFile.Multiselect = true;
            if (opnFile.ShowDialog() == DialogResult.OK)
            {
                foreach (string p in opnFile.FileNames)
                {
                    DataTable dt = new DataTable();
                    dt.Clear();
                    dt.Columns.Add("path");
                    dt.Columns.Add("Extension");
                    DataRow _ravi = dt.NewRow();
                    _ravi["path"] = Path.GetFileName(p);
                    dt.Rows.Add(_ravi);
                    //  string newPath = @"\\192.168.101.4\LC_Folder\" + LcNo.Text.Trim() + @"\LcDocuments\" + _ravi["path"].ToString().Trim();

                    string newLcDir = @"\\192.168.101.4\Loans_Folder";
                    string newDirPath = newLcDir + @"\" + txtLoanNo.Text.Trim();
                    string newPath = newDirPath + @"\" + _ravi["path"].ToString().Trim();
                    if (!Directory.Exists(newLcDir))
                    {
                        Directory.CreateDirectory(newLcDir);
                    }
                    if (!Directory.Exists(newDirPath))
                    {
                        Directory.CreateDirectory(newDirPath);
                    }

                    File.Copy(p, newPath);

                }
            }
        }

        private void btnViewDoc_Click(object sender, EventArgs e)
        {
            if (txtLoanNo.Text.Trim() != string.Empty)
            {
                string newPath = @"\\192.168.101.4\Loans_Folder\" + txtLoanNo.Text.Trim();
                if (!Directory.Exists(newPath))
                {
                    MessageBox.Show("Folder Not Exists");
                }
                else
                {
                    Process.Start("explorer.exe", newPath);
                }

            }
        }
    }
}
