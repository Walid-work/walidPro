using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Reflection;
using System.Resources;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.Loans
{
    public partial class frmLoan : Form
    {
        CultureInfo cul;
        string _branch = Properties.Settings.Default.BranchAccID;
        Assembly a = Assembly.Load("Report_Pro");

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmLoan()
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



        }

        private void BSave_Click(object sender, EventArgs e)
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
                            "',Branch_code = '" + _branch + "' ,Loan_Tearm='" + Convert.ToString(txtLoanTearm.SelectedValue) + "'   where  id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");
                        MessageBox.Show(rm.GetString("msgEdit", cul), rm.GetString("msgEdit_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                        if(txtJorSer.Text != string.Empty)
                        {
                            dal.Execute_1(@"delete from daily_transaction where ser_no='"+txtJorSer.Text+"' and Branch_code='"+_branch+"'");
                        }
                        UpdateJor();
                    }
                    else
                    {

                        dal.Execute_1(@"INSERT INTO LoansTbl(id,LoanNo,BankId,LoanACC,LoanDate,NumberOfPayments,LoanValue,PaymentNo,
                        PaymentValue,StartDate,MaturityDate,Rate,LoanPurpose,LoanRefrance,Branch_code,Loan_Tearm)
                        VALUES(  '" + txtLoanId.Text + "', '" + txtLoanNo.Text + "','" + BName.ID.Text + "','" + txtLoanAcc.ID.Text + "','" + L_StartDate.Value.ToString("yyyy-MM-dd") + "','" + NoOfPayments.Value +
                        "','" + txtLoanValue.Value + "','" + r.paySer.Value + "','" + r.PayValue.Text.ToDecimal() + "','" + r.startDate.Value.ToString("yyyy-MM-dd") +
                        "','" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "','" + r.intrestRate.Text.ToDecimal() + "','" + Convert.ToString(txtLoanPurpose.SelectedValue) + 
                        "', '" + txtLoanRefrance.Text + "','" + _branch + "','"+Convert.ToString(txtLoanTearm.SelectedValue)+"')");
                        MessageBox.Show(rm.GetString("msgSave", cul), rm.GetString("msgSave_H", cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                        chLoanSave.Checked = true;
                    }
                }
            }


            dal.Execute_1(@"delete from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo >'" + flowLayoutPanel1.Controls.Count + "' ");


        }

        private void txtLoanNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtLoanValue_TextChanged(object sender, EventArgs e)
        {

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
                    r.intrestRate.Text = txtIntrestRate.Text;
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

        private void frmLoan_Load(object sender, EventArgs e)
        {
           

            getLoanID();
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
                BName.ID.Text= loanData.Rows[0]["BankId"].ToString();
                txtLoanAcc.ID.Text = loanData.Rows[0]["LoanACC"].ToString();
                L_StartDate.Text = loanData.Rows[0]["LoanDate"].ToString();
                NoOfPayments.Text = loanData.Rows[0]["NumberOfPayments"].ToString();
                txtLoanNo.Text = loanData.Rows[0]["LoanNo"].ToString();
                txtIntrestRate.Text = loanData.Rows[0]["Rate"].ToString().ToDecimal().ToString();
                txtLoanValue.Text = loanData.Rows[0]["LoanValue"].ToString();
                txtLoanPurpose.SelectedValue= loanData.Rows[0]["LoanPurpose"].ToString().ParseInt(0);
                txtLoanRefrance.Text= loanData.Rows[0]["LoanRefrance"].ToString();
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

        private void btnStatment_Click(object sender, EventArgs e)
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
            int JorSer;
            getJorSer();
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

            string DbDesc = "صرف قرض رقم " + txtLoanNo.Text +" - "+ L_StartDate.Text.ToString();
            dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                   , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
                   txtJorSer.Text + "','1','"+txtLoanValue.Value+"','0','" + txtLoanValue.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                   "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + DbDesc + "','0','1','" + JorSer + "')");


            foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
            {

                if (r.PayValue.Text.ToDecimal() > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                {

                    string crDesc = "صرف الدفعة رقم " + r.paySer.Text + " من القرض - "+ L_StartDate.Text.ToString();

                    dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                   , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + txtLoanAcc.ID.Text + "','" + _branch + "','" +
                    txtJorSer.Text + "','1','0','" + r.PayValue.Text.ToDecimal() + "','" + -r.PayValue.Text.ToDecimal() + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                    "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + crDesc + "','0','1','" + JorSer + "')");

                }

                dal.Execute_1(@"UPDATE serial_no SET daily_sn_ser='" + txtSanadSer.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + _branch + "' and ACC_YEAR='" + txtYear.Text + "' ");

                dal.Execute_1(@"UPDATE LoansTbl SET Jor_ser_no = '" + txtJorSer.Text + "' WHERE id =  '" + txtLoanId.Text + "' ");


                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




        }


        private void UpdateJor()
        {
            int JorSer;
       
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
            dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                   , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + BName.ID.Text + "','" + _branch + "','" +
                   txtJorSer.Text + "','1','" + txtLoanValue.Value + "','0','" + txtLoanValue.Value + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                   "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + DbDesc + "','0','1','" + JorSer + "')");


            foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
            {

                if (r.PayValue.Text.ToDecimal() > 0 && dal.IsDateTime(r.startDate.Text) && dal.IsDateTime(r.maturityDate.Text))
                {

                    string crDesc = "صرف الدفعة رقم " + r.paySer.Text + " من القرض - " + L_StartDate.Text.ToString();

                    dal.Execute_1(@"INSERT INTO daily_transaction(ACC_YEAR, ACC_NO, BRANCH_code, ser_no, COST_CENTER, meno, loh
                   , balance, g_date, sanad_no, SANAD_TYPE, user_name, desc2, POASTING, CAT_CODE, MAIN_SER_NO)
                    VALUES('" + txtYear.Text + "','" + txtLoanAcc.ID.Text + "','" + _branch + "','" +
                    txtJorSer.Text + "','1','0','" + r.PayValue.Text.ToDecimal() + "','" + -r.PayValue.Text.ToDecimal() + "','" + jorDate.Value.ToString("yyyy/MM/dd HH:mm:ss") +
                    "','" + txtSanadSer.Text + "','6','" + Program.userID + "','" + crDesc + "','0','1','" + JorSer + "')");

                }

                dal.Execute_1(@"UPDATE serial_no SET daily_sn_ser='" + txtSanadSer.Text + "' , main_daily_ser = '" + JorSer + "' WHERE BRANCH_CODE=  '" + _branch + "' and ACC_YEAR='" + txtYear.Text + "' ");

                dal.Execute_1(@"UPDATE LoansTbl SET Jor_ser_no = '" + txtJorSer.Text + "' WHERE id =  '" + txtLoanId.Text + "' ");


                MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }




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
            DataTable dt_ = dal.getDataTabl_1(@"select A.ser_no,A.ACC_NO,A.g_date,A.desc2,
            a.meno,A.loh,A.sanad_no,A.BRANCH_code,A.user_name,A.COST_CENTER,
            A.CAT_CODE ,B.PAYER_NAME,B.payer_l_name,C.COST_name,C.COST_E_NAME,
            D.CAT_NAME,E.BRANCH_name,E.BRANCH_E_NAME
            from daily_transaction as A
            inner join payer2 as B on A.ACC_NO = B.ACC_NO and a.BRANCH_code=B.BRANCH_code
            inner join COST_CENTER  as C on a.COST_CENTER = C.COST_CODE
            inner Join CATEGORY as D on D.CAT_CODE=A.CAT_CODE
            inner join BRANCHS as E on A.BRANCH_code=E.BRANCH_code

            where a.ser_no='" + txtJorSer.Text+"' and A.BRANCH_CODE = 'A1110'");

            DataTable dt_Loan = dal.getDataTabl_1(@"SELECT A.id,A.LoanNo,A.BankId,A.LoanACC,A.LoanDate,A.NumberOfPayments,A.LoanValue,A.PaymentNo,A.PaymentValue
            ,A.StartDate,A.MaturityDate,A.Rate,A.LoanPurpose,A.LoanRefrance,A.Branch_code,A.Jor_ser_no
            ,B.PAYER_NAME,B.payer_l_name,C.Loan_Purpose,C.Loan_Purpose_E
              FROM LoansTbl As A
              inner Join payer2 as B  on A.BankId=B.ACC_NO and A.Branch_code=B.BRANCH_code
              inner join LoanPurpose as C on c.Id=A.LoanPurpose
              where A.LoanNo='"+ txtLoanNo.Text + "'");



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



        }

        private void loanPanel_Click(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
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
            if (txtJorSer.Text.Trim() == string.Empty)
            {
                btnCreateJor.Enabled = true;
            }
            else
            {
                btnCreateJor.Enabled = false;
            }
        }

        private void chLoanSave_CheckedChanged(object sender, EventArgs e)
        {
            if (chLoanSave.Checked == true)
            {
                chLoanSave.Text = "Saved";
                chLoanSave.BackColor = Color.GreenYellow;
                btnCreateJor.Enabled = true;
            }
            else
            {
                chLoanSave.Text = " Not Saved";
                chLoanSave.BackColor = Color.Transparent;
                btnCreateJor.Enabled = false;
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

                  loanAccNo = dal.GetCell_1(@"select max(acc_no) + 1 from payer2 where MAIN_NO = '" + txtMainLoanAccNo.Text + "' and BRANCH_code = 'a1110'").ToString();
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
            DataTable dtBank = dal.getDataTabl_1(@"select * from BanksTbl where Acc_nO='" + BName.ID.Text + "'");
            if (dtBank.Rows.Count > 0)
            {
                
                txtMainLoanAccNo.Text = dtBank.Rows[0]["MainLoanAccNo"].ToString();
                //clc_openFees();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            addLoanAcc();
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

        private void integerInput1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtMainLoanAccNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void integerInput1_TextChanged(object sender, EventArgs e)
        {
            addRows();
        }
    }
}
