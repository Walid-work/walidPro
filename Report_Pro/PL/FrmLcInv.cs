using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class FrmLcInv : Form
    {
        //BL.Cls_public cls_public = new BL.Cls_public();
        //BL.Cls_Lcs Lcs = new BL.Cls_Lcs();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        /// <summary>
        /// جزء من كود عدم تكرار الفتح للفورم
        /// </summary>
        private static FrmLcInv frm_lcinv = null;
        //---------

        public FrmLcInv()
        {

            // كود منع تكرار فتح الفورم---------

            // If the form already exists, and has not been closed
            if (frm_lcinv != null && !frm_lcinv.IsDisposed)
            {
                frm_lcinv.Focus();            // Bring the old one to top
                Shown += (s, e) => this.Close();  // and destroy the new one.
                return;
            }

            // Otherwise store this one as reference
            frm_lcinv = this;
            //--------------------------------


            InitializeComponent();

            //DataTable dtcheck = dal.getDataTabl_1(@"select * from LcInvTbl where LcNo='"+LcNo.Text+ "' and InvNo='"+InvNo.Text+"'");
            //if (dtcheck.Rows.Count > 0)
            //{
            //    recivePanel.Enabled = true;
            //}
            //else
            //{
            //    recivePanel.Enabled = false;
            //}
            Currency.DataSource = dal.getDataTabl_1("SELECT * FROM Wh_Currency");

            Currency.ValueMember = "Currency_Code";
            if (Properties.Settings.Default.lungh == "ar")
            {
                Currency.DisplayMember = "Currency_Name";
            }
            else
            {
                Currency.DisplayMember = "Currency_Name";

            }
            Currency.SelectedIndex = -1;
        




    }


        private void getBalance(string lcNum)
        {
            try
            {
                DataTable lcBalance = dal.getDataTabl_1(@"SELECT isnull(sum(InvAmount),0),isnull(sum(InvQty),0) FROM LcInvTbl where LcNo='" + lcNum + "'");
                if (lcBalance.Rows.Count > 0)
                {
                    balanceAmount.Value = Convert.ToDouble(Amount.Text) - Convert.ToDouble(lcBalance.Rows[0][0].ToString()) - InvAmount.Value;
                    balanceQty.Value = Convert.ToDouble(txtQty.Text) - Convert.ToDouble(lcBalance.Rows[0][1].ToString()) - InvQty.Value;
                }
                else
                {
                    balanceAmount.Value = Convert.ToDouble(Amount.Text) - InvAmount.Value;
                    balanceQty.Value = Convert.ToDouble(txtQty.Text) - InvQty.Value;

                }
        }
            catch { }
            }
    private void button1_Click_1(object sender, EventArgs e)
        {

            ClearTextBoxes();
            //if (DGV1.Rows.Count > 0)
            //{
            //    DGV1.Rows.Clear();
            //}

            FrmSerchLcs frmSrchLcs = new FrmSerchLcs();
            frmSrchLcs.ShowDialog();
            try
            {
                showData(frmSrchLcs.DGV1.CurrentRow.Cells[1].Value.ToString());
                this.InvNo.Text = dal.getDataTabl_1("SELECT count(LcNo)+1 FROM LcInvTbl where LcNo ='" + frmSrchLcs.DGV1.CurrentRow.Cells[1].Value.ToString() + "'").Rows[0][0].ToString().PadLeft(2, '0');

                BSave.Enabled = true;
                BEdit.Enabled = false;
                //balanceAmount.Value = Convert.ToDouble(Amount.Text) - InvAmount.Value;
                //balanceQty.Value = Convert.ToDouble(txtQty.Text) - InvQty.Value;
                getBalance(LcNo.Text);
                searchInv(LcNo.Text);
            }
            catch
            {
            }
        }
        private void showData(string LcNum)
        {
            DataTable dtLc = dal.getDataTabl_1(@"select * from LcsTbl where LcNo='" + LcNum + "'");
            if (dtLc.Rows.Count > 0)
            {
                LcNo.Text = dtLc.Rows[0]["LcNo"].ToString();
                BName.ID.Text = dtLc.Rows[0]["BID"].ToString();
                Currency.SelectedValue = dtLc.Rows[0]["Currency"].ToString();
                Amount.Text = dtLc.Rows[0]["Amount"].ToString();
                txtQty.Text = dtLc.Rows[0]["Qty"].ToString();
                txtMatrails.Text = dtLc.Rows[0]["Materials"].ToString();
                txtSupplier.ID.Text = dtLc.Rows[0]["Supplier"].ToString();
                AcceptDays.Text = dtLc.Rows[0]["AcceptDays"].ToString();
                Rate.Text= dtLc.Rows[0]["CurrencyRate"].ToString();
                txtLcAcc.ID.Text= dtLc.Rows[0]["LcAccNo"].ToString();
                DateTime Op_Date;
                DateTime.TryParse(dtLc.Rows[0]["OpenDate"].ToString(), out Op_Date);
                OpenDate.Text = Op_Date.ToString("d");
                DateTime Ex_Date;
                DateTime.TryParse(dtLc.Rows[0]["ExpiryDate"].ToString(), out Ex_Date);
                ExpiryDate.Text = Ex_Date.ToString("d");
                DateTime Sh_Date;
                DateTime.TryParse(dtLc.Rows[0]["LShipDate"].ToString(), out Sh_Date);
                LShipDate.Text = Sh_Date.ToString("d");




                //    this.LcNo.Text = frmSrchLcs.DGV1.CurrentRow.Cells[0].Value.ToString();
                this.BAccept.Text = dal.getDataTabl_1("select BAccept from BanksTbl where Acc_No='"+ BName.ID.Text+"'").Rows[0][0].ToString().ToDecimal().ToString("n2");

                

            }
        }


        private void searchInv(string txtSearch)
        {
           DataTable  searchDT = dal.getDataTabl_1("SELECT * FROM LcInvTbl where LcNo = '" + txtSearch + "'");
            if (searchDT.Rows.Count > 0)
            {
                DGV1.DataSource = searchDT;
            }
            else
            {
                DGV1.DataSource = null;
                DGV1.Rows.Clear();
            }
        }



        private void InvShipDate_ValueChanged(object sender, EventArgs e)
        {
            try
            {
                InvMaturtyDate.Text = InvShipDate.Value.AddDays(Convert.ToDouble(AcceptDays.Text)).ToShortDateString();
            }
            catch
            {
            }

        }

   

        private void Rate_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                //this.Accept_Amount.Text = Math.Round((Convert.ToDecimal(InvAmount.Text) * Convert.ToDecimal(BAccept.Text) * Convert.ToDecimal(Rate.Text) / 100 * Convert.ToDecimal(AcceptDays.Text) / 360), 2).ToString();
                this.Accept_Amount.Text = Math.Round((InvAmount.Text.ToDecimal() * BAccept.Text.ToDecimal() * Rate.Text.ToDecimal() / 100 * AcceptDays.Text.ToDecimal() / 360), 2).ToString();

            }
            catch
            {

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
                    else if (control is FlowLayoutPanel)
                        (control as FlowLayoutPanel).Controls.Clear();
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Text = "";

                    else
                        func(control.Controls);
            };

            func(Controls);
       
        }

        
     
        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            BSave.Enabled = true;
            if (DGV1.Rows.Count > 0)
            {
                DGV1.Rows.Clear();
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            try
            {
                dal.Execute_1("insert into LcInvTbl(LcNo,InvNo,InvAmount,InvQty,InvShipDate,InvMaturtyDate,Rate,Accept_Amount) values('" + LcNo.Text+"','"+ InvNo.Text + "','" + InvAmount.Text.ToDecimal() + "','" +
                    InvQty.Text.ToDecimal() + "','" + InvShipDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + InvMaturtyDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" +
                    Rate.Text.ToDecimal() + "','" + Accept_Amount.Text.ToDecimal() + "')");
                //MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                MessageBox.Show(dal.rm.GetString("msgSave", dal.cul), dal.rm.GetString("msgSave_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                ClearTextBoxes();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        
        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            try
            {
                //Lcs.editLcInv(LcNo.Text, InvNo.Text, InvAmount.Text.ToDecimal(), InvQty.Text.ToDecimal(), InvShipDate.Value.Date, InvMaturtyDate.Value.Date, Rate.Text.ToDecimal(), Accept_Amount.Text.ToDecimal());
                dal.Execute_1("update LcInvTbl set LcNo='" + LcNo.Text + "', InvNo='" + InvNo.Text + "',InvAmount='" + InvAmount.Text.ToDecimal() +
                    "', InvQty='" + InvQty.Text.ToDecimal() + "', InvShipDate='" + InvShipDate.Value.ToString("yyyy-MM-dd HH:mm:ss") + "',InvMaturtyDate='" + InvMaturtyDate.Value.ToString("yyyy-MM-dd HH:mm:ss")
                    + "', Rate='" + Rate.Text.ToDecimal() + "', Accept_Amount='" + Accept_Amount.Text.ToDecimal() + "' where  LcNo='" + LcNo.Text + "' and InvNo='" + InvNo.Text + "'");

                MessageBox.Show(dal.rm.GetString("msgEdit", dal.cul), dal.rm.GetString("msgEdit_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);

                //MessageBox.Show("تم التعديل بنجاح", "تعديل ", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ClearTextBoxes();
                BSave.Enabled = true;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void BSearch_Click(object sender, EventArgs e)
        {

            //try
            //{
                ClearTextBoxes();
          PL.FrmSerchLcInv frm = new PL.FrmSerchLcInv();
                frm.ShowDialog();
                
                showInvData(frm.DGV1.CurrentRow.Cells[0].Value.ToString(), frm.DGV1.CurrentRow.Cells[1].Value.ToString());

               


                BSave.Enabled = false;
                BEdit.Enabled = true;
                searchInv(LcNo.Text);
          //  }
            //catch { }
        }

       private void showInvData(string lcNo_, string invNo_)
        {
            DataTable invData = dal.getDataTabl_1(@"SELECT * FROM LcInvTbl where LcNo='"+lcNo_+"' and InvNo='"+invNo_+"'");
            if (invData.Rows.Count > 0)
            {

                LcNo.Text = invData.Rows[0]["lcNo"].ToString();
                showData(LcNo.Text);
                InvNo.Text = invData.Rows[0]["InvNo"].ToString();
                InvAmount.Text = invData.Rows[0]["InvAmount"].ToString();
                InvQty.Text = invData.Rows[0]["InvQty"].ToString();
                InvShipDate.Text = invData.Rows[0]["InvShipDate"].ToString();
                InvMaturtyDate.Text = invData.Rows[0]["InvMaturtyDate"].ToString();
                Rate.Text = invData.Rows[0]["Rate"].ToString();
                Accept_Amount.Text = invData.Rows[0]["Accept_Amount"].ToString();
                if (invData.Rows[0]["isReceve"].ToString().Equals("1"))
                {
                    rdoReceve.Checked = true;
                    reciveDate.Text= invData.Rows[0]["receveDate"].ToString();
                }
                else
                {
                    rdoNotReceve.Checked = true;
                }

                if (invData.Rows[0]["isPaied"].ToString().Equals("1"))
                {
                    rdoPaied.Checked = true;
                     PayDate.Text = invData.Rows[0]["paiedDate"].ToString();
                }
                else
                {
                    rdoNotPaied.Checked = true;
                }

                showLoanData(lcNo_,invNo_);

            }

        }
   

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void showLoanData(string lcNo_, string invNo_)
        {
           
            string InvNum = lcNo_ + "-" + invNo_;
            DataTable loanData = dal.getDataTabl_1(@"SELECT *  FROM LoansTbl where LoanRefrance='" + InvNum + "'");
            if (loanData.Rows.Count > 0)
            {
                txtLoanId.Text = loanData.Rows[0]["Id"].ToString();
                txtLoanAcc.ID.Text = loanData.Rows[0]["LoanACC"].ToString();
                NoOfPayments.Text = loanData.Rows[0]["NumberOfPayments"].ToString();
                txtLoanNo.Text = loanData.Rows[0]["LoanNo"].ToString();
                txtIntrestRate.Text = loanData.Rows[0]["Rate"].ToString();
                txtLoanValue.Text = loanData.Rows[0]["LoanValue"].ToString();

                int i = 0;
                flowLayoutPanel1.Controls.Clear();

                foreach (DataRow r in loanData.Rows)
                {


                    MyControls.LoanRow row = new MyControls.LoanRow();
                    row.paySer.Text = loanData.Rows[i]["PaymentNo"].ToString();
                    row.PayValue.Text = loanData.Rows[i]["PaymentValue"].ToString();
                    row.startDate.Text = loanData.Rows[i]["StartDate"].ToString();
                    row.maturityDate.Text = loanData.Rows[i]["MaturityDate"].ToString();
                    row.intrestRate.Text = loanData.Rows[i]["Rate"].ToString();

                    flowLayoutPanel1.Controls.Add(row);
                    i = i + 1;
                }
            }
            else
            {
                getLoanID();
                addRows();
            }
        }

        
        private void InvAmount_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13 && InvAmount.Text != string.Empty)
            {
                
                InvQty.Focus();
            }
        }

        private void InvQty_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {

                InvShipDate.Focus();
            }
        }

        private void InvAmount_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                this.Accept_Amount.Text = Math.Round((Convert.ToDecimal(InvAmount.Text) * Convert.ToDecimal(BAccept.Text) * Convert.ToDecimal(Rate.Text) / 100 * Convert.ToDecimal(AcceptDays.Text) / 360), 2).ToString();
            }
            catch
            {

            }
        }

        private void FrmLcInv_Load(object sender, EventArgs e)
        {
            addRows();
            getLoanID();
        }
        private void getLoanID()
        {
            txtLoanId.Text = dal.GetCell_1("select isnull(MAX(id)+1,1) from LoansTbl").ToString();

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void ribbonBar1_ItemClick(object sender, EventArgs e)
        {

        }

        private void btnAttach_Click(object sender, EventArgs e)
        {
            Frm_uploadImage frmUpload = new Frm_uploadImage();
            frmUpload.p_id = this.LcNo.Text;
            frmUpload.ShowDialog();
        }

        private void LcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void InvAmount_ValueChanged(object sender, EventArgs e)
        {
            getBalance(LcNo.Text);

        }

        private void InvQty_ValueChanged(object sender, EventArgs e)
        {
            getBalance(LcNo.Text);

        }

        private void groupPanel1_Click_1(object sender, EventArgs e)
        {

        }

        private void btnStatment_Click(object sender, EventArgs e)
        {
            RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
            frm.UC_Acc1.ID.Text = txtLcAcc.ID.Text;
            frm.ShowDialog();
        }

        private void dateTimeInput2_Click(object sender, EventArgs e)
        {

        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void rdoNotPaied_CheckedChanged(object sender, EventArgs e)
        {
            if (rdoNotPaied.Checked)
            {
                loanPanel.Visible = false;
            }
            else
            {
                loanPanel.Visible = true;
            }
        }

        private void btnRecive_Click(object sender, EventArgs e)
        {
           

                DataTable dtcheck = dal.getDataTabl_1(@"select * from LcInvTbl where LcNo='" + LcNo.Text + "' and InvNo='" + InvNo.Text + "'");
                if (dtcheck.Rows.Count > 0)
                {
                    if (rdoNotReceve.Checked)
                    {
                        dal.Execute_1("update LcInvTbl set isReceve=0 ,receveDate=NULL where LcNo='" + LcNo.Text + "' and InvNo='" + InvNo.Text + "' ");
                    }
                    else
                    {
                        dal.Execute_1("update LcInvTbl set isReceve=1,receveDate='"+ reciveDate.Value.ToString("yyyy-MM-dd")+"' where LcNo='" + LcNo.Text + "' and InvNo='" + InvNo.Text + "' ");
                    }
                }
                
        }

        private void btnUpdatePay_Click(object sender, EventArgs e)
        {
            DataTable dtcheck = dal.getDataTabl_1(@"select * from LcInvTbl where LcNo='" + LcNo.Text + "' and InvNo='" + InvNo.Text + "'");
            if (dtcheck.Rows.Count > 0)
            {
                if (rdoNotPaied.Checked)
                {
                    dal.Execute_1("update LcInvTbl set isPaied=0 ,paiedDate=NULL where LcNo='" + LcNo.Text + "' and InvNo='" + InvNo.Text + "' ");
                }
                else
                {
                    dal.Execute_1("update LcInvTbl set isPaied=1,paiedDate='" + PayDate.Value.ToString("yyyy-MM-dd") + "' where LcNo='" + LcNo.Text + "' and InvNo='" + InvNo.Text + "' ");
                    foreach (MyControls.LoanRow r in flowLayoutPanel1.Controls)
                    {

                        if (r.PayValue.Text.ToDecimal() > 0 && IsDateTime(r.startDate.Text) &&IsDateTime(r.maturityDate.Text))
                        {
                            DataTable dt_ = dal.getDataTabl_1(@"select * from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");
                            if (dt_.Rows.Count > 0) {
                                string invNum = LcNo.Text + "-" + InvNo.Text;
                                dal.Execute_1(@"UPDATE LoansTbl set LoanNo='" + txtLoanNo.Text + "',BankId='" + BName.ID.Text + "',LoanACC='" + txtLoanAcc.ID.Text +
                                    "',NumberOfPayments='" + NoOfPayments.Value + "',LoanValue='" + txtLoanValue.Value + "',PaymentNo='" + r.paySer.Value +
                                    "', PaymentValue='" + r.PayValue.Text.ToDecimal() + "',StartDate='" + r.startDate.Value.ToString("yyyy-MM-dd") +
                                    "', MaturityDate='" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "', Rate='" + r.intrestRate.Text.ToDecimal() +
                                    "',LoanPurpose='0' ,LoanRefrance='" + invNum + 
                                    "' where  id='" + txtLoanId.Text + "' and PaymentNo='" + r.paySer.Text + "' ");

                            }
                            else
                            {
                            string invNum = LcNo.Text + "-" + InvNo.Text;
                            dal.Execute_1(@"INSERT INTO LoansTbl(id,LoanNo,BankId,LoanACC,NumberOfPayments,LoanValue,PaymentNo,
                            PaymentValue,StartDate,MaturityDate,Rate,LoanPurpose,LoanRefrance)
                            VALUES('"+txtLoanId.Text+"','" + txtLoanNo.Text + "','" + BName.ID.Text + "','" + txtLoanAcc.ID.Text + "','" + NoOfPayments.Value +
                                "','" + txtLoanValue.Value + "','" + r.paySer.Value + "','" + r.PayValue.Text.ToDecimal() + "','" + r.startDate.Value.ToString("yyyy-MM-dd") +
                                "','" + r.maturityDate.Value.ToString("yyyy-MM-dd") + "','" + r.intrestRate.Text.ToDecimal() + "','0','" + invNum + "')");
                            }
                        }
                    }

                    dal.Execute_1(@"delete from LoansTbl where id='" + txtLoanId.Text + "' and PaymentNo >'" + flowLayoutPanel1.Controls.Count + "' ");


                }


            }

        }

        public bool IsDateTime(string text)
        {
            DateTime dateTime;
            bool isDateTime = false;

            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            isDateTime = DateTime.TryParse(text, out dateTime);

            return isDateTime;
        }



        private void integerInput1_ValueChanged(object sender, EventArgs e)
        {
            addRows();

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

                    r.intrestRate.Text = txtIntrestRate.Text.ParseInt(0).ToString();
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

        private void groupPanel2_Click_1(object sender, EventArgs e)
        {

        }

        private int GetIndexFocusedControl()
        {
            int ind = -1;


            foreach (Control ctr in this.flowLayoutPanel1.Controls)
            {
                if (ctr.Focused)
                {
                    ind = (int)this.flowLayoutPanel1.Controls.IndexOf(ctr);
                }
               
            }
            return ind;
        }

        private void txtIntrestRate_ValueChanged(object sender, EventArgs e)
        {
           
            foreach (MyControls.LoanRow ctr in flowLayoutPanel1.Controls)
            {
                ctr.intrestRate.Text = txtIntrestRate.Text;
            }
        }

        private void txtIntrestRate_Leave(object sender, EventArgs e)
        {
            
           
        }

        private void NoOfPayments_Leave(object sender, EventArgs e)
        {
                    }

        private void FrmLcInv_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter) {
                SelectNextControl(ActiveControl, true, true, true, true);

            }
        }

        private void loanPanel_Click(object sender, EventArgs e)
        {

        }

        private void txtLoanAcc_Load(object sender, EventArgs e)
        {

        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            showInvData(DGV1.CurrentRow.Cells[0].Value.ToString(), DGV1.CurrentRow.Cells[1].Value.ToString());




            BSave.Enabled = false;
            BEdit.Enabled = true;
        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show(dal.rm.GetString("msgConfirmDelete", dal.cul), dal.rm.GetString("msgConfirmDelete_H!", dal.cul), MessageBoxButtons.YesNo, MessageBoxIcon.Exclamation) == DialogResult.Yes)

            {
                try
                {


                    dal.Execute_1("delete from LcInvTbl  where  LcNo='" + LcNo.Text + "' and InvNo='" + InvNo.Text + "'");

                    MessageBox.Show(dal.rm.GetString("msgDelete", dal.cul), dal.rm.GetString("msgDelete_H", dal.cul), MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ClearTextBoxes();
                    BSave.Enabled = true;

                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}

