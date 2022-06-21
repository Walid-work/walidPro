using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_serch_cost : Form
    {
        public frm_serch_cost()
        {
            DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
            InitializeComponent();

            DGV1.DataSource = dal.getDataTabl("SearchCost_", txtSerch.Text, txtSerch_1.Text,dal.db1);
        }

        private void frm_serch_cost_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
