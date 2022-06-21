using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_deposit : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int currencyNo = 2;
        public frm_deposit()
        {
            InitializeComponent();

            DataTable dt_bank = dal.getDataTabl_1("select * from BanksTbl");
            cmb_Bank.DataSource = dt_bank;
            cmb_Bank.ValueMember = "BID";
            cmb_Bank.DisplayMember = "BNameA";
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frm_deposit_Load(object sender, EventArgs e)
        {
            txtDate.Value = DateTime.Today.Date;
            dgv.RowCount = 6;
            dgv.Rows[0].Cells[4].Value = "20";
            dgv.Rows[1].Cells[4].Value = "10";
            dgv.Rows[2].Cells[4].Value = "5";
            dgv.Rows[3].Cells[4].Value = "1";
            dgv.Rows[4].Cells[4].Value = "1/2";
            dgv.Rows[5].Cells[4].Value = "Coins";

            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));

            switch (Properties.Settings.Default.Currency)
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
            }

        }
        private void tot_()
        {
            txt_tot_F.Text =
             (from DataGridViewRow row in dgv.Rows
              where row.Cells[0].FormattedValue.ToString() != string.Empty
              select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString("n0");

            txt_tot_D.Text =
              (from DataGridViewRow row in dgv.Rows
               where row.Cells[1].FormattedValue.ToString() != string.Empty
               select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString("n0");
            decimal balance_ = txt_tot_D.Text.ToDecimal() + txt_tot_F.Text.ToDecimal() / 1000;
           ToWord toWord = new ToWord(Math.Abs(Math.Round(balance_, dal.digits_)), currencies[currencyNo]);
            txt_NoToText.Text = "'" + toWord.ConvertToArabic().ToString() + "'";


        }

        private void cmb_Bank_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1("select * from BanksTbl where BID = '1'");
            txtAccName.Text = dt_.Rows[0]["Acc_Details_E"].ToString();
            string acc_no = dt_.Rows[0]["BAccNo"].ToString();
            txtAcc_1.Text = acc_no.Substring(0, 1).ToString();
            txtAcc_2.Text = acc_no.Substring(1, 1).ToString();
            txtAcc_3.Text = acc_no.Substring(2, 1).ToString();
            txtAcc_4.Text = acc_no.Substring(3, 1).ToString();
            txtAcc_5.Text = acc_no.Substring(4, 1).ToString();
            txtAcc_6.Text = acc_no.Substring(5, 1).ToString();
            txtAcc_7.Text = acc_no.Substring(6, 1).ToString();
            txtAcc_8.Text = acc_no.Substring(7, 1).ToString();
            txtAcc_9.Text = acc_no.Substring(8, 1).ToString();
            txtAcc_10.Text = acc_no.Substring(9, 1).ToString();
            txtAcc_11.Text = acc_no.Substring(10, 1).ToString();
            txtAcc_12.Text = acc_no.Substring(11, 1).ToString();
            txtAcc_13.Text = acc_no.Substring(12, 1).ToString();
            txtAcc_14.Text = acc_no.Substring(13, 1).ToString();
            txtAcc_15.Text = acc_no.Substring(14, 1).ToString();
        }

        private void dataGridViewX1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgv_KeyUp(object sender, KeyEventArgs e)
        {
            tot_();
        }

        private void checkBoxX1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
