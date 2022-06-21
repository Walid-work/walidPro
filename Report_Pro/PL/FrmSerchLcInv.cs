using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class FrmSerchLcInv : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable searchDT=new DataTable();
        //BL.Cls_Lcs lcs = new BL.Cls_Lcs();
        public FrmSerchLcInv()
        {
            InitializeComponent();
            //this.DGV1.DataSource = lcs.getLcInv(txtSerch.Text);
                   }


        private void FrmSerchLcInv_Load(object sender, EventArgs e)
        {
            searchInv(txtSerch.Text);

        }

        private void searchInv(string txtSearch)
        {
            searchDT = dal.getDataTabl_1("SELECT * FROM LcInvTbl where LcNo like '" + txtSearch + "%'");
            if (searchDT.Rows.Count > 0)
            {
                DGV1.DataSource = searchDT;
            }
            else
            {
                DGV1.DataSource = null;
                DGV1.Rows.Clear();
            }
        }
        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            searchInv(txtSerch.Text);
        }

  

       

     
    }
}
