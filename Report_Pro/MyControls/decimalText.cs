using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public class decimalText : TextBox
    {
        //DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        //[Browsable(true)]
        //[Category("Extended Properties")]
        //[Description("Set TextBox border Color")]
       

      

        public decimal Value
        {
            get
            {
                return Text.ToDecimal();
            }
            set
            {
                Text = Value.ToString();
            }
        }

        public int _digit;


        public int DicemalDigits
        {
            get { return _digit; }
            set
            {
                _digit = value;
               
            }
        }


        private Boolean ProDigits;

        public Boolean ProgramDigits
        {
            get { return ProDigits; }
            set
            {
                ProDigits = value;

            }
        }


        public decimalText()
        {
          KeyPress += new KeyPressEventHandler(UserControl1_KeyPress);
          Leave += new EventHandler(UserControl1_leave);
           this.BindingContextChanged += new EventHandler(UserControl1_leave);
            BorderStyle = BorderStyle.FixedSingle;

          
        }

        int digtNumber()
        {
            int nd = 0;
             if (ProDigits == true)
            {
               nd = _digit;
    }
            else
            {
               nd = _digit;
            }
            return nd;



}

        private void UserControl1_leave(object sender, EventArgs e)
        {
            if(Text.Length>0)
                Text = this.Text.ToDecimal().ToString("N" + digtNumber());
           

        }

     
        

        private void UserControl1_KeyPress(object sender, KeyPressEventArgs e)
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
            && splitByDecimal[1].Length == digtNumber()))
            {
                e.Handled = true;
            }
        }

    }
}
