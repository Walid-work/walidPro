using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmSerch_PE : Form
    {
       DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmSerch_PE()
        {
            InitializeComponent();
            serchDG();
        }

        private void frmSerch_PE_Load(object sender, EventArgs e)
        {


        }

        private void serchDG()
        {
             DataTable dt_ = dal.getDataTabl_1("select A.*,D.BRANCH_name,C.CAT_NAME from P_expenses_T1 as A " +
            "left join main_acc_wh.dbo.CATEGORY AS C ON A.category_code=C.CAT_CODE "+
            "left join main_acc_wh.dbo.BRANCHS AS D ON A.branch_code=D.BRANCH_code where A.kind like '" + txtKind.Text
            + "%' and A.branch_code like '" + UC_AccBranch.ID.Text + "%' and A.category_code like '" + UC_Catogry.ID.Text + "%'  and A.id like '" + txtID.Text + "%'  and A.amount like '" + txtAmount.Text + "%' ");
             dataGridViewX1.DataSource = dt_;
        }

        private void txtDescribtion_TextChanged(object sender, EventArgs e)
        {
            serchDG();
        }

     

        private void UC_AccBranch_Load(object sender, EventArgs e)
        {
            serchDG();
        }

        private void UC_Catogry_Load(object sender, EventArgs e)
        {
            serchDG();
        }

        private void txtKind_TextChanged(object sender, EventArgs e)
        {
            serchDG();
        }

        private void txtKind_SelectedIndexChanged(object sender, EventArgs e)
        {
            serchDG();
        }

        private void dataGridViewX1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
            serchDG();
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            serchDG();
        }
    }
}
