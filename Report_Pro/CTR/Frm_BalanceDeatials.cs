using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.CTR
{
    public partial class Frm_BalanceDeatials : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public Frm_BalanceDeatials()
        {
            InitializeComponent();
        }

        private void Frm_BalanceDeatials_Load(object sender, EventArgs e)
        {
            txtDate.Value = DateTime.Today;

          
        }
    }
}
