using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using TextBox = System.Windows.Forms.TextBox;

namespace Report_Pro
{
   public class NumericTextBox : TextBox
    {
        public NumericTextBox()
        {
            this.KeyPress += new KeyPressEventHandler(TextBoxKeyPress);
            this.Leave += new EventHandler(TextBoxLeave);
        }

        private void TextBoxLeave(object sender, EventArgs e)
        {
            if (this.Text.Length > 0)
            {
                this.Text = Convert.ToDecimal(this.Text).ToString("N" + decimaldigit_);
            }
            
        }

        protected void TextBoxKeyPress(object sender, KeyPressEventArgs e)
        {

            char DecimalSeparator = Convert.ToChar(System.Globalization.CultureInfo.CurrentCulture.NumberFormat.NumberDecimalSeparator);
            if (!char.IsDigit(e.KeyChar) && e.KeyChar != 8 && e.KeyChar != DecimalSeparator)



            {

                e.Handled = true;
            }
            else
            {


                if (e.KeyChar == DecimalSeparator)
                {
                    if (this.Text.IndexOf(DecimalSeparator) < 0)
                        e.Handled = false;
                    else
                        e.Handled = true;

                }

                if (this.Text.IndexOf(DecimalSeparator) > 0 && e.KeyChar != 8)
                {
                    var txtlen = this.Text.Length;
                    var dotpos = this.Text.IndexOf(DecimalSeparator);
                    //Change the number here to allow more decimal points than 2
                    if ((txtlen - dotpos) > decimaldigit_)
                        e.Handled = true;

                }
            }


        }
            int decimaldigit_;
        public int decimaldigit
        {
            get { return decimaldigit_; }
            set { decimaldigit_ = value; }
            //}

        }

       
    } }