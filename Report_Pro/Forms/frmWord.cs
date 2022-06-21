using DevExpress.XtraReports.UI;
using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using Table = Microsoft.Office.Interop.Word.Table;

namespace Report_Pro.Forms
{
    public partial class frmWord : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();
        int currencyNo = 2;
        public frmWord()
        {
            InitializeComponent();
            DataTable dtCurrencySAR = dal.getDataTabl_1(@"SELECT Currency_Code,Currency_Name,Currency_Name_e FROM Wh_Currency");
            txtLoanCurrency.DataSource = dtCurrencySAR;
            txtLoanCurrency.ValueMember = "Currency_Code";
            txtLoanCurrency.DisplayMember = "Currency_Name";
            txtLoanCurrency.SelectedValue = "s";

            DataTable dtCurrency = dal.getDataTabl_1(@"SELECT Currency_Code,Currency_Name,Currency_Name_e FROM Wh_Currency");
            txtLcCurrency.DataSource = dtCurrency;
            txtLcCurrency.ValueMember = "Currency_Code";
            txtLcCurrency.DisplayMember = "Currency_Name";
            txtLcCurrency.SelectedValue = "D";

            DataTable dtBank = dal.getDataTabl_1(@"SELECT BID,BNameA,BNameE,BAccNo FROM BanksTbl");
            txtBank.DataSource = dtBank;
            txtBank.ValueMember = "BID";
            txtBank.DisplayMember = "BNameA";
            txtBank.SelectedIndex = -1;


        }

        private void getser()
        {
          txtSerail.Text= dal.GetCell_1(@"select isnull(RL,0)+1 from serial_no where BRANCH_CODE='A1110' and ACC_YEAR = 'cy'").ToString();
        }
        private void frmWord_Load(object sender, EventArgs e)
        {
            getser();
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Qatar));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Kuwait));

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
                case "QR":
                    currencyNo = 7;
                    break;
                case "KD":
                    currencyNo = 8;
                    break;
            }
            txtisueDate.Value = DateTime.Now;
            txtLoanDate.Value = DateTime.Now;
        }

        private void CreateDocument()
        {
            try
            {
                //Create an instance for word app  
                Microsoft.Office.Interop.Word.Application winword = new Microsoft.Office.Interop.Word.Application();

                //Set animation status for word application  
            //    winword.ShowAnimation = false;

                //Set status for word application is to be visible or not.  
                winword.Visible = false;

                //Create a missing variable for missing value  
                object missing = System.Reflection.Missing.Value;

                //Create a new document  
                Microsoft.Office.Interop.Word.Document document = winword.Documents.Add(ref missing, ref missing, ref missing, ref missing);

                //Add header into the document  
                foreach (Microsoft.Office.Interop.Word.Section section in document.Sections)
                {
                    //Get the header range and add the header details.  
                    Microsoft.Office.Interop.Word.Range headerRange = section.Headers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    headerRange.Fields.Add(headerRange, Microsoft.Office.Interop.Word.WdFieldType.wdFieldPage);
                    headerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    headerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdBlue;
                    headerRange.Font.Size = 10;
                    headerRange.Text = "Header text goes here";
                }

                //Add the footers into the document  
                foreach (Microsoft.Office.Interop.Word.Section wordSection in document.Sections)
                {
                    //Get the footer range and add the footer details.  
                    Microsoft.Office.Interop.Word.Range footerRange = wordSection.Footers[Microsoft.Office.Interop.Word.WdHeaderFooterIndex.wdHeaderFooterPrimary].Range;
                    footerRange.Font.ColorIndex = Microsoft.Office.Interop.Word.WdColorIndex.wdDarkRed;
                    footerRange.Font.Size = 10;
                    footerRange.ParagraphFormat.Alignment = Microsoft.Office.Interop.Word.WdParagraphAlignment.wdAlignParagraphCenter;
                    footerRange.Text = "Footer text goes here";
                }

                //adding text to document  
                document.Content.SetRange(0, 0);
                document.Content.Text = "This is test document " + Environment.NewLine;

                //Add paragraph with Heading 1 style  
                Microsoft.Office.Interop.Word.Paragraph para1 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading1 = "Heading 1";
                para1.Range.set_Style(ref styleHeading1);
                para1.Range.Text = "Para 1 text";
                para1.Range.InsertParagraphAfter();

                //Add paragraph with Heading 2 style  
                Microsoft.Office.Interop.Word.Paragraph para2 = document.Content.Paragraphs.Add(ref missing);
                object styleHeading2 = "Heading 2";
                para2.Range.set_Style(ref styleHeading2);
                para2.Range.Text = "Para 2 text";
                para2.Range.InsertParagraphAfter();

                //Create a 5X5 table and insert some dummy record  
                Table firstTable = document.Tables.Add(para1.Range, 5, 5, ref missing, ref missing);

                firstTable.Borders.Enable = 1;
                foreach (Row row in firstTable.Rows)
                {
                    foreach (Cell cell in row.Cells)
                    {
                        //Header row  
                        if (cell.RowIndex == 1)
                        {
                            cell.Range.Text = "Column " + cell.ColumnIndex.ToString();
                            cell.Range.Font.Bold = 1;
                            //other format properties goes here  
                            cell.Range.Font.Name = "verdana";
                            cell.Range.Font.Size = 10;
                            //cell.Range.Font.ColorIndex = WdColorIndex.wdGray25;                              
                            cell.Shading.BackgroundPatternColor = WdColor.wdColorGray25;
                            //Center alignment for the Header cells  
                            cell.VerticalAlignment = WdCellVerticalAlignment.wdCellAlignVerticalCenter;
                            cell.Range.ParagraphFormat.Alignment = WdParagraphAlignment.wdAlignParagraphCenter;

                        }
                        //Data row  
                        else
                        {
                            cell.Range.Text = (cell.RowIndex - 2 + cell.ColumnIndex).ToString();
                        }
                    }
                }

                //Save the document  
                object filename = @"c:\temp1.docx";
                document.SaveAs(ref filename);
                document.Close(ref missing, ref missing, ref missing);
                document = null;
                winword.Quit(ref missing, ref missing, ref missing);
                winword = null;
                MessageBox.Show("Document created successfully !");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {

            string strLetter = "";

            Reports.rpt_LoanLetter rpt = new Reports.rpt_LoanLetter();
            ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(txtLoanAmount.Text)), currencies[currencyNo]);

            strLetter = "يرجي التكرم بمنحنا القرض بمبلغ "+ txtLoanAmount.Text.ToDecimal().ToString("N0")+
                " " + txtLoanCurrency.Text.ToString()+" ( "+ toWord.ConvertToArabic().ToString()+" ) لمدة "+
                txtLoanDays.Text.ToDecimal().ToString("N0")+" يوم"+ Environment.NewLine+"وذلك لتمويل سداد اعتماد رقم "+
                txtLcNo.Text.ToString() + "-" + txtInvNo.Text.ToString()+" بمبلغ "+
                txtLcAmount.Text.ToDecimal().ToString("N2")+" "+ txtLcCurrency.Text.ToString()+" إستحقاق "+
                lcInvDate.Value.ToString("yyyy/MM/dd");

                rpt.txtLetter.Text = strLetter;
                rpt.bank_.Value = txtBank.Text.ToString();
                rpt.AccountNo.Value = txtBankAccount.Text.ToString();
                rpt.txtDate.Text = txtLoanDate.Value.ToString("yyyy/MM/dd");

            rpt.ShowPreview();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtBank_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                DataTable getBankAcc = dal.getDataTabl_1(@"SELECT BID,BNameA,BNameE,BAccNo FROM BanksTbl where BID='"+txtBank.SelectedValue.ToString().ParseInt(0)+"'");
                txtBankAccount.Text = getBankAcc.Rows[0]["BAccNo"].ToString();

            }
            catch (Exception)
            {

                
            }
          
        }

        private void txtLoanAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string senderText = (sender as TextBox).Text;
            string senderName = (sender as TextBox).Name;
            string[] splitByDecimal = senderText.Split('.');
            int cursorPosition = (sender as TextBox).SelectionStart;


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (senderText.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar)
            && (senderText.IndexOf('.') < cursorPosition
             && splitByDecimal.Length > 1
            && splitByDecimal[1].Length == dal.digits_))
            {
                e.Handled = true;
            }
        }

        private void txtLoanAmount_Leave(object sender, EventArgs e)
        {
            if (txtLoanAmount.Text.Length > 0)
                txtLoanAmount.Text = double.Parse(txtLoanAmount.Text).ToString("N" +dal.digits_ );
        }

        private void txtLoanDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (dal.IsDateTime(txtLoanDate.Text) == true && e.KeyCode==Keys.Enter)
            {
                txtBank.Focus();
            }
        }

        private void txtBank_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && txtBank.SelectedIndex > -1)
            {
                txtLoanAmount.Focus();
            }
        }

        private void txtLoanAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLoanAmount.Text.Trim()!=string.Empty)
            {
                txtLoanDays.Focus();
            }
        }

        private void txtLoanDays_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLoanDays.Text.Trim() != string.Empty)
            {
                txtLcNo.Focus();
            }
        }

        private void txtLcNo_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtLcNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLcNo.Text.Trim() != string.Empty)
            {
               txtInvNo.Focus();
            }
        }

        private void txtInvNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtInvNo.Text.Trim() != string.Empty)
            {
                txtLcAmount.Focus();
            }
        }

        private void txtLcAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtLcAmount.Text.Trim() != string.Empty)
            {
                lcInvDate.Focus();
            }
        }

        private void txtLoanDays_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtLcAmount_KeyPress(object sender, KeyPressEventArgs e)
        {
            string senderText = (sender as TextBox).Text;
            string senderName = (sender as TextBox).Name;
            string[] splitByDecimal = senderText.Split('.');
            int cursorPosition = (sender as TextBox).SelectionStart;


            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) &&
           (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && (senderText.IndexOf('.') > -1))
            {
                e.Handled = true;
            }

            if (!char.IsControl(e.KeyChar)
            && (senderText.IndexOf('.') < cursorPosition
             && splitByDecimal.Length > 1
            && splitByDecimal[1].Length == dal.digits_))
            {
                e.Handled = true;
            }
        }

        private void txtLcAmount_Leave(object sender, EventArgs e)
        {
            if (txtLcAmount.Text.Length > 0)
                txtLcAmount.Text = double.Parse(txtLcAmount.Text).ToString("N" + dal.digits_);

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            if(txtLoanAmount.Text.ToDecimal()>0 &&  txtLoanCurrency.SelectedIndex >-1 &&
            txtLoanDays.Text.ParseInt(0)>0 && txtLcNo.Text.Trim() !="" &&
            txtInvNo.Text.Trim()!="" && txtLcAmount.Text.ToDecimal() > 0 &&
            txtLcCurrency.SelectedIndex >-1 && dal.IsDateTime(lcInvDate.Value.ToString()))
            {
                dal.Execute_1(@"INSERT INTO loanRequest_tbl (LrId,LrDate,Issue_Date,BankNo
                                ,LrAmount,LrCurrency,Days,LcNo,InvNo,InvAmount,LcCurrency,invMaturityDate)
     VALUES ('" + txtSerail.Text+"','"+txtLoanDate.Value.ToString("yyyy-MM-dd") + "','"+txtisueDate.Value.ToString("yyyy-MM-dd") + "','"+Convert.ToString(txtBank.SelectedValue)+
     "','"+txtLoanAmount.Text.ToDecimal()+"','"+txtLoanCurrency.SelectedValue+"','"+txtLoanDays.Text.ParseInt(0)+"','"+txtLcNo.Text+
     "','"+txtInvNo.Text+"','"+txtLcAmount.Text.ToDecimal()+"','"+txtLcCurrency.SelectedValue+"','"+lcInvDate.Value.ToString("yyyy-MM-dd")+"')");
            }
        }
    }
    }

