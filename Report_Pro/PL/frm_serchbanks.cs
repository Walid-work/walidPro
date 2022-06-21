using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro
{
    public partial class frm_serchbanks : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
      //  BL.Cls_Lcs Lcs = new BL.Cls_Lcs();
        
        public frm_serchbanks()
        {
            InitializeComponent();

            DGV1.DataSource = dal.getDataTabl_1("select * from BanksTbl where BID like  '" + txtSearch.Text + "%' or  BNameA+BNameE like '%" + txtSearch.Text +"%'");
        }

     

        private void btnSearch_Click(object sender, EventArgs e)
        {
            DGV1.DataSource = dal.getDataTabl_1("select * from BanksTbl where BID like  '" + txtSearch.Text + "%' or  BNameA+BNameE like '%" + txtSearch.Text + "%'");
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            DGV1.DataSource = dal.getDataTabl_1("select * from BanksTbl where BID like  '" + txtSearch.Text + "%' or  BNameA+BNameE like '%" + txtSearch.Text + "%'");
        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frm_serchbanks_Load(object sender, EventArgs e)
        {

        }
    }
}
