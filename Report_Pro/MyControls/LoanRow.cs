using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class LoanRow : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public LoanRow()
        {
            InitializeComponent();
        }

        private void PayValue_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter && PayValue.Text.ToDecimal() > 0)
            {
                startDate.Focus();
            }
        }

        private void startDate_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter &&  dal.IsDateTime(startDate.Text))
            {
                maturityDate.Focus();
            }
        }

        private void maturityDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && dal.IsDateTime(maturityDate.Text))
            {
                intrestRate.Focus();
            }
        }

        private void intrestRate_KeyDown(object sender, KeyEventArgs e)
        {
           if (e.KeyCode == Keys.Enter)
            {
                OnKeyDown(e);
            }
        }
    }
}
