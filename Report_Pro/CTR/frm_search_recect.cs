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
    public partial class frm_search_recect : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();
        public frm_search_recect()
        {
            InitializeComponent();
           

        }





        void Search_sand()
        {
            DataTable dt_ = dal.getDataTabl_1("select * from Sands_tbl where SOURCE_CODE='"+ txt_source_code.Text+ "' and BRANCH_code='" + Properties.Settings.Default.BranchId + "' and Inv_No like '%" + invNo.Text + "%' and CashCust_Name + sanad_no + desc2 like '%" + txtsearch.Text + "%'");

            if (dt_.Rows.Count > 0)
            {
                DGV1.Rows.Clear();
                DGV1.RowCount = dt_.Rows.Count + 1;
                int count_ = 0;

                for (int ii = 0; ii <= dt_.Rows.Count - 1; ii++)
                {
                    DGV1.Rows[count_].Cells[0].Value = dt_.Rows[ii][9].ToString();
                    DGV1.Rows[count_].Cells[1].Value = dt_.Rows[ii][8].ToString();
                    DGV1.Rows[count_].Cells[2].Value = dt_.Rows[ii][25].ToString();
                    DGV1.Rows[count_].Cells[3].Value = dt_.Rows[ii][24].ToString();
                    DGV1.Rows[count_].Cells[4].Value = dt_.Rows[ii][12].ToString();

                    count_ = count_ + 1;
                }

                // txtsearch.Clear();
            }
        }

        private void txtsearch_TextChanged(object sender, EventArgs e)
        {
            Search_sand();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Search_sand();
        }

        private void frm_search_recect_Load(object sender, EventArgs e)
        {
            Search_sand();
        }

        private void Btn_srch_cust_Click(object sender, EventArgs e)
        {
            Search_sand();
        }

        private void invNo_TextChanged(object sender, EventArgs e)
        {
            Search_sand();
        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

      
        
    }
}
