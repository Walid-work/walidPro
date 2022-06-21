using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_BankTransfair : XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        DataTable dt_single;

        int currencyNo = 2;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();

        public frm_BankTransfair()
        {
            InitializeComponent();
        }

        private void frm_BankTransfair_Load(object sender, EventArgs e)
        {
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Qatar));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Kuwait));

            txtBank.txtMainAcc.Text = "1221";
            txtBank.txtFinal.Text = "1";
            txtBank.branchID.Text = Properties.Settings.Default.BranchAccID;
            txtRecipient.txtFinal.Text = "1";
            txtRecipient.branchID.Text = Properties.Settings.Default.BranchAccID;
            txtCost.txt_Tfinl.Text = "1";
            // txtCost.txtMain.Text = "3";
            txtDate.Value = DateTime.Today;
            txtValueDate.Value = DateTime.Today;
            txt_Branch_Code.Text = Properties.Settings.Default.BranchAccID;
            txt_user_name.Text = Program.salesman;
            txt_user_id.Text = Program.userID;
            txt_sanad_type2.Text = "TR";
            txt_source_code.Text = "TR";
            txt_sanad_type.Text = "TR";
            txt_acc_year.Text = "CY";

            cmbCurrency.DataSource = dal.getDataTabl_1(@"SELECT Currency_Code,Currency_Name,Currency_Name_e FROM Wh_Currency");
            txtType.DataSource = dal.getDataTabl_1(@"SELECT sanad_type,sanad_name,sanad_name_E FROM TRANS_TYPE");
            txtType.ValueMember = "sanad_type";
            cmbCurrency.ValueMember = "Currency_Code";
            if (Properties.Settings.Default.lungh == "0")
            {
                txtType.DisplayMember = "sanad_name";
                cmbCurrency.DisplayMember = "Currency_Name_e";
            }
            else
            {
                txtType.DisplayMember = "sanad_name_E";
                cmbCurrency.DisplayMember = "Currency_Name";
            }


            getSer();
            getData();
        }


        private void getData()
        {
            DataTable dt_ = dal.getDataTabl_1(@"SELECT id, g_date, v_date, type, amount, check_no, bank_id, recipient_id, cost_center
            , descr, user_id, sanad_type2, branch_code, acc_year, source_code, sanad_type, JorSer
              FROM transfer_tbl");
            int B_rowscount = dt_.Rows.Count;
            dgv1.Rows.Clear();
            dgv1.Rows.Add(B_rowscount);
            for (int i = 0; (i
                       <= (B_rowscount - 1)); i++)
            {

                dgv1.Rows[i].Cells["id"].Value = dt_.Rows[i]["id"];
                dgv1.Rows[i].Cells["g_date"].Value = dt_.Rows[i]["g_date"];
                dgv1.Rows[i].Cells["v_date"].Value = dt_.Rows[i]["v_date"];
                dgv1.Rows[i].Cells["type"].Value = dt_.Rows[i]["type"];
                dgv1.Rows[i].Cells["amount"].Value = dt_.Rows[i]["amount"];
                dgv1.Rows[i].Cells["check_no"].Value = dt_.Rows[i]["check_no"];
                dgv1.Rows[i].Cells["bank_id"].Value = dt_.Rows[i]["bank_id"];
                dgv1.Rows[i].Cells["recipient_id"].Value = dt_.Rows[i]["recipient_id"];
                dgv1.Rows[i].Cells["cost_center"].Value = dt_.Rows[i]["cost_center"];
                dgv1.Rows[i].Cells["descr"].Value = dt_.Rows[i]["descr"];
                dgv1.Rows[i].Cells["user_id"].Value = dt_.Rows[i]["user_id"];
                dgv1.Rows[i].Cells["sanad_type2"].Value = dt_.Rows[i]["sanad_type2"];
                dgv1.Rows[i].Cells["branch_code"].Value = dt_.Rows[i]["branch_code"];
                dgv1.Rows[i].Cells["acc_year"].Value = dt_.Rows[i]["acc_year"];
                dgv1.Rows[i].Cells["source_code"].Value = dt_.Rows[i]["source_code"];
                dgv1.Rows[i].Cells["sanad_type"].Value = dt_.Rows[i]["sanad_type"];
                dgv1.Rows[i].Cells["JorSer"].Value = dt_.Rows[i]["JorSer"];

            }

        }

        private void getSingaleData(string _id, string _branch)
        {

            dt_single = dal.getDataTabl_1(@"SELECT A.id, A.g_date, A.v_date, A.type, A.amount, A.check_no, A.bank_id, A.recipient_id, A.cost_center
              , A.descr, A.user_id, A.sanad_type2, A.branch_code, A.acc_year, A.source_code, A.sanad_type, A.JorSer,A.currency,LEFT(A.branch_code,1) as com_code
			  ,B.sanad_name,B.sanad_name_E,C.PAYER_NAME as bank,C.payer_l_name as bank_E,D.PAYER_NAME as recipient
			 ,D.payer_l_name as recipient_E,E.COST_name,E.COST_E_NAME,F.USER_NAME,H.Currency_Name,H.Currency_Name_e
              FROM transfer_tbl as A
			  inner join TRANS_TYPE as B on A.type =B.sanad_type
			  inner join payer2 as C on A.bank_id =C.ACC_NO and A.branch_code =C.BRANCH_code
			  inner join payer2 as D on A.recipient_id =D.ACC_NO and A.branch_code =D.BRANCH_code
			  inner join COST_CENTER as E on A.cost_center =E.COST_CODE
			  inner join wh_USERS as F on A.user_id =F.USER_ID 
			  inner join Wh_Currency as H on A.currency =H.Currency_Code 
              where A.id = '" + _id + "' and A.branch_code ='" + _branch + "'");

        }

        private void getSer()
        {
            // txtID.Text = dal.GetCell_1(@"select isnull(max(id)+1,1) from transfer_tbl where branch_code = '"+txt_Branch_Code.Text+"'").ToString();
            txtID.Text = dal.GetCell_1(@"SELECT HEWALA_sarf_ser FROM serial_no where  ACC_YEAR='" + txt_acc_year.Text + "' and  BRANCH_CODE='" + txt_Branch_Code.Text + "'").ToString();


        }

        private void Payment_Type_Click(object sender, EventArgs e)
        {

        }

        private void BSave_Click(object sender, EventArgs e)
        {
            DataTable dt_check = dal.getDataTabl_1(@"select id from transfer_tbl where branch_code = '" + txt_Branch_Code.Text + "' and id = '" + txtID.Text + "'");
            if (dt_check.Rows.Count > 0)
            {
                dal.Execute_1(@"update transfer_tbl set 
    id              ='" + txtID.Text +
    "',g_date       = '" + txtDate.Value.ToString("yyyy-MM-dd hh:mm:ss") +
    "',v_date       = '" + txtValueDate.Value.ToString("yyyy-MM-dd hh:mm:ss") +
    "',type         = '" + Convert.ToString(txtType.SelectedIndex) +
    "',amount       =  '" + txtAmount.Value +
    "',check_no     = '" + txtCheckNo.Text +
    "',bank_id      = '" + txtBank.ID.Text +
    "',recipient_id = '" + txtRecipient.ID.Text +
    "',cost_center  = '" + txtCost.ID.Text +
    "',descr        = '" + txtNotes.Text +
    "',user_id      = '" + txt_user_id.Text +
    "',sanad_type2  = '" + txt_sanad_type2.Text +
    "',branch_code  = '" + txt_Branch_Code.Text +
    "',acc_year     = '" + txt_acc_year.Text +
    "',source_code  = '" + txt_source_code.Text +
    "',sanad_type   = '" + txt_sanad_type.Text +
    "',currency     = '" + Convert.ToString(cmbCurrency.SelectedValue) +
    "' where id ='" + txtID.Text + "' and branch_code = '" + txt_Branch_Code.Text + "' ");


            }
            else
            {
                dal.Execute_1(@"INSERT INTO transfer_tbl (id,g_date,v_date,type,amount,check_no,bank_id,recipient_id
            ,cost_center,descr,user_id,sanad_type2,branch_code,acc_year,source_code,sanad_type)
            VALUES('" + txtID.Text + "','" + txtDate.Value.ToString("yyyy-MM-dd hh:mm:ss") +
                "','" + txtValueDate.Value.ToString("yyyy-MM-dd hh:mm:ss") +
                "','" + Convert.ToString(txtType.SelectedIndex) + "','" + txtAmount.Value +
                "','" + txtCheckNo.Text + "','" + txtBank.ID.Text + "','" + txtRecipient.ID.Text +
                "','" + txtCost.ID.Text + "','" + txtNotes.Text + "','" + txt_user_id.Text +
                "','" + txt_sanad_type2.Text + "','" + txt_Branch_Code.Text + "','" + txt_acc_year.Text +
                "','" + txt_source_code.Text + "', '" + txt_sanad_type.Text + "')");
                dal.Execute_1(@" update serial_no set HEWALA_sarf_ser ='" + txtID.Text +
                    "' ACC_YEAR='" + txt_acc_year.Text + "' and  BRANCH_CODE='" + txt_Branch_Code.Text + "'");

                MessageBox.Show("تم الحفظ بنجاح", "حفظ ", MessageBoxButtons.OK, MessageBoxIcon.Information);



            }


        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BNew_Click(object sender, EventArgs e)
        {
            dal.ClearTextBoxes(this);
            getSer();
        }

        private void txtType_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
               (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void txtAmount_Leave(object sender, EventArgs e)
        {

        }

        private void BSearch_Click(object sender, EventArgs e)
        {

        }

        private void dgv1_DoubleClick(object sender, EventArgs e)
        {
            //string inv_no = dgv1.CurrentRow.Cells[2].Value.ToString();

            txtID.Text = dgv1.CurrentRow.Cells["id"].Value.ToString();
            txtDate.Value = Convert.ToDateTime(dgv1.CurrentRow.Cells["g_date"].Value.ToString());
            txtValueDate.Value = Convert.ToDateTime(dgv1.CurrentRow.Cells["v_date"].Value.ToString());
            txtType.SelectedValue = Convert.ToInt32(dgv1.CurrentRow.Cells["type"].Value.ToString());
            txtAmount.Text = dgv1.CurrentRow.Cells["amount"].Value.ToString();
            txtCheckNo.Text = dgv1.CurrentRow.Cells["check_no"].Value.ToString();
            txtBank.ID.Text = dgv1.CurrentRow.Cells["bank_id"].Value.ToString();
            txtRecipient.ID.Text = dgv1.CurrentRow.Cells["recipient_id"].Value.ToString();
            txtCost.ID.Text = dgv1.CurrentRow.Cells["cost_center"].Value.ToString();
            txtNotes.Text = dgv1.CurrentRow.Cells["descr"].Value.ToString();
            txt_user_id.Text = dgv1.CurrentRow.Cells["user_id"].Value.ToString();
            txt_sanad_type2.Text = dgv1.CurrentRow.Cells["sanad_type2"].Value.ToString();
            txt_Branch_Code.Text = dgv1.CurrentRow.Cells["branch_code"].Value.ToString();
            txt_acc_year.Text = dgv1.CurrentRow.Cells["acc_year"].Value.ToString();
            txt_source_code.Text = dgv1.CurrentRow.Cells["source_code"].Value.ToString();
            txt_sanad_type.Text = dgv1.CurrentRow.Cells["sanad_type"].Value.ToString();
            txtJorSer.Text = dgv1.CurrentRow.Cells["JorSer"].Value.ToString();
        }

        private void BPrint_Click(object sender, EventArgs e)
        {

            // DataSet ds = new DataSet();
            Reports.rpt_PrintTransfer rpt = new Reports.rpt_PrintTransfer();
            getSingaleData(txtID.Text, txt_Branch_Code.Text);
            DataTable dt_Co = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No='" + dt_single.Rows[0]["com_code"].ToString() + "'  ");

            // ds.Tables.Add(dt_single);
            // //ds.WriteXmlSchema("schema_rpt.xml");
            // rpt.DataSource = ds;

            using (MemoryStream ms_Hpic = new MemoryStream((Byte[])dt_Co.Rows[0]["h_pic"]))
            {
                rpt.PicH.Image = Image.FromStream(ms_Hpic);
            }

           
            switch (dt_single.Rows[0]["currency"].ToString())
            {
                case "s":
                    currencyNo = 2;
                    break;
                case "BH":
                    currencyNo = 5;
                    break;
                case "OM":
                    currencyNo = 6;
                    break;
                case "DR":
                    currencyNo = 1;
                    break;
                case "QR":
                    currencyNo = 7;
                    break;
                case "KD":
                    currencyNo = 8;
                    break;
            }






            ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_single.Rows[0]["amount"].ToString())), currencies[currencyNo]);

            rpt.txtId.Text = dt_single.Rows[0]["id"].ToString();
            rpt.txtDate.Text = Convert.ToDateTime(dt_single.Rows[0]["g_date"]).ToString("dd/MM/yyyy");
            rpt.txtCheckNo.Text = dt_single.Rows[0]["check_no"].ToString();
            rpt.txtAmount.Text = dt_single.Rows[0]["amount"].ToString().ToDecimal().ToString("N" + dal.digits_);
            rpt.txtDescription.Text = dt_single.Rows[0]["descr"].ToString();

            if (Properties.Settings.Default.lungh == "0")
            {
                rpt.txtAmountWord.Text = toWord.ConvertToArabic().ToString();
                rpt.txtCurrency.Text = dt_single.Rows[0]["Currency_Name_e"].ToString();
                rpt.txtBank.Text = dt_single.Rows[0]["bank"].ToString();
                rpt.txtRecipient.Text = dt_single.Rows[0]["recipient"].ToString();
                rpt.txtType.Text = dt_single.Rows[0]["sanad_name"].ToString();
                rpt.txtUser.Text = dt_single.Rows[0]["USER_NAME"].ToString();

            }
            else
            {
                rpt.txtAmountWord.Text = "'" + toWord.ConvertToEnglish().ToString() + "'";
                rpt.txtCurrency.Text = dt_single.Rows[0]["Currency_Name"].ToString();
                rpt.txtBank.Text = dt_single.Rows[0]["bank_E"].ToString();
                rpt.txtRecipient.Text = dt_single.Rows[0]["recipient_E"].ToString();
                rpt.txtType.Text = dt_single.Rows[0]["sanad_name_E"].ToString();
                rpt.txtUser.Text = dt_single.Rows[0]["USER_NAME"].ToString();

            }
            rpt.ShowPreview();
        }

       }
}
