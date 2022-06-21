using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmSearchAcc : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public frmSearchAcc()
        {
            InitializeComponent();
            serch_acc();
            
        }

        void serch_acc()
        {
            DGV1.DataSource = dal.getDataTabl_1("SELECT Gr_Code,Gr_name,Gr_E_Name FROM "+dal.db1+".dbo.MEZANIA_ARBAH_CHART where t_final=1 and Gr_Code like '" + txtsearchID.Text + "%' and Gr_name like '%" + txtSearchName.Text + "%'");
        }
        private void frmSearchAcc_Load(object sender, EventArgs e)
        {

        }

        private void txtsearchID_KeyUp(object sender, KeyEventArgs e)
        {
            serch_acc();
        }

        private void txtSearchName_KeyUp(object sender, KeyEventArgs e)
        {
            serch_acc();
        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
