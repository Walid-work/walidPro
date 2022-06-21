using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class FrmSerchLcs : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dtSearch = new DataTable();
        public int clos_;
        public FrmSerchLcs()
        {
            InitializeComponent();
            createDT();
            serch_lc();
           
        }

        private void createDT()
        {
            if (Properties.Settings.Default.lungh == "0")
            {
                dtSearch.Columns.Add("مسلسل");
                dtSearch.Columns.Add("رقم الاعتماد");
                dtSearch.Columns.Add(" الفاتورة المبدئية");
                dtSearch.Columns.Add(" البنك");
                dtSearch.Columns.Add("المورد");
                dtSearch.Columns.Add(" المبلغ");
                DGV1.DataSource = dtSearch;
            }
            else
            {
                dtSearch.Columns.Add("ID");
                dtSearch.Columns.Add("Lc No");
                dtSearch.Columns.Add("Proforma");
                dtSearch.Columns.Add("Bank");
                dtSearch.Columns.Add("Supplier");
                dtSearch.Columns.Add("Amount");
                DGV1.DataSource = dtSearch;

            }
        }


        private void serch_lc()
        {
           
            DataTable dt_ = dal.getDataTabl_1(@"select L.ID,L.LcNo,L.Proforma,L.Amount,P.PAYER_NAME as Bank,P.payer_l_name as Bank_L,P1.PAYER_NAME as Suplier,P1.payer_l_name as Suplier_L FROM LcsTbl as L
            inner join(select acc_no, PAYER_NAME, payer_l_name, ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS RCount from payer2) as P on p.ACC_NO = L.BID
            inner join(select acc_no, PAYER_NAME, payer_l_name, ROW_NUMBER() OVER(PARTITION BY Acc_no ORDER BY acc_no) AS RCount_1 from payer2) as P1 on P1.ACC_NO = L.Supplier
            where p.RCount = 1 and p1.RCount_1 = 1 and L.LcNo like '%" + txtlcNo.Text + "%' and Proforma like '%"+txtPreformNo.Text+ "%' and Supplier like '"+
            txtSupplier.ID.Text+ "%' and BID like '"+txtBank.ID.Text+"%'   order by BID , LcNo");

            if (dt_.Rows.Count > 0)
            {
              
                dtSearch.Clear();
                int i = 0;
                DataRow row = null;
                foreach (DataRow r in dt_.Rows)
                {

                    row = dtSearch.NewRow();
                    row[0] = dt_.Rows[i]["Id"].ToString();
                    row[1] = dt_.Rows[i]["LcNo"].ToString();
                    row[2] = dt_.Rows[i]["Proforma"].ToString();
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        row[3] = dt_.Rows[i]["Bank"].ToString();
                        row[4] = dt_.Rows[i]["Suplier"].ToString();
                    }
                    else
                    {
                        row[3] = dt_.Rows[i]["Bank_L"].ToString();
                        row[4] = dt_.Rows[i]["Suplier_L"].ToString();
                    }
                    row[5] = dt_.Rows[i]["Amount"].ToString().ToDecimal().ToString("N0");
                   
                    dtSearch.Rows.Add(row);
                    i = i + 1;
                }

                DGV1.DataSource = dtSearch;
            }

        }
        

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            clos_ = 1;
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            serch_lc();
        }

        private void txtSearch_KeyUp(object sender, KeyEventArgs e)
        {
            
        }

        private void FrmSerchLcs_Load(object sender, EventArgs e)
        {
            txtSupplier.txtMainAcc.Text = "234";
            txtSupplier.txtFinal.Text = "1";

            txtBank.txtMainAcc.Text = "122";
            txtBank.txtFinal.Text = "1";

        }

        private void txtlcNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtlcNo_KeyUp(object sender, KeyEventArgs e)
        {
            serch_lc();
        }

        private void txtPreformNo_KeyUp(object sender, KeyEventArgs e)
        {
            serch_lc();
        }

        private void txtBank_KeyUp(object sender, KeyEventArgs e)
        {
            serch_lc();
        }

        private void txtSupplier_KeyUp(object sender, KeyEventArgs e)
        {
            serch_lc();
        }
    }
}
