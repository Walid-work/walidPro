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
    public partial class frmSerchSanad : Form
    {

        public string Search_studes = "0";
        public frmSerchSanad()
        {
            InitializeComponent();
        }

        private void frmSerchSanad_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Search_studes = "1";
            this.Close();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Search_studes = "0";
            this.Close();
        }
    }
}
