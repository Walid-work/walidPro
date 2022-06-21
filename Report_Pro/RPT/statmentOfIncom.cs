using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class statmentOfIncom : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public statmentOfIncom()
        {
            InitializeComponent();

           UcTB1.FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            UcTB1.ToDate.Value = DateTime.Today;
        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            UcTB1.Visible = false;
            panel3.Visible = true;
            crystalReportViewer1.Visible = false;
            //try
            //{



                string lvl = "";
                if (UcTB1.RBtnAll.Checked == true)
                { lvl = ""; }
                if (UcTB1.RBtn1.Checked == true)
                { lvl = "0"; }
                if (UcTB1.RBtn2.Checked == true)
                { lvl = "1"; }
                if (UcTB1.RBtn3.Checked == true)
                { lvl = "2"; }
                if (UcTB1.RBtn4.Checked == true)
                { lvl = "3"; }

                string bal = "1";
                if (UcTB1.RB1.Checked == true)
                { bal = "1"; }
                if (UcTB1.RB2.Checked == true)
                { bal = "2"; }
                if (UcTB1.RB3.Checked == true)
                { bal = "3"; }

                if (UcTB1.RB4.Checked == true)
                { bal = "4"; }

                string Acc_Kind = "";
                if (UcTB1.RB_All_Acc.Checked == true)
                { Acc_Kind = ""; }
                else if (UcTB1.RB_M_Acc.Checked == true)
                { Acc_Kind = "0"; }
                else if (UcTB1.RB_S_Acc.Checked == true)
                { Acc_Kind = "1"; }



            DataTable Tb_dt = dal.getDataTabl("Get_Income_", UcTB1.FromDate.Value.Date, UcTB1.ToDate.Value.Date, UcTB1.Acc_no.Text, UcTB1.Branch_code.Text, lvl, bal, Acc_Kind, Properties.Settings.Default.closeAcc, "", Properties.Settings.Default.Database_1, UcTB1.Cost_No.Text);
                  //  , UcTB1.FromDate.Value.Date, UcTB1.ToDate.Value.Date, UcTB1.Acc_no.Text, UcTB1.Branch_code.Text, lvl, bal, Acc_Kind, Properties.Settings.Default.closeAcc);





                int B_rowscount = Tb_dt.Rows.Count;
                DataGridView1.Rows.Clear();
                DataGridView1.Rows.Add(B_rowscount);
                for (int i = 0; (i
                           <= (B_rowscount - 1)); i++)
                {


                    DataGridView1.Rows[i].Cells[0].Value = Tb_dt.Rows[i]["acc_no"];
                    DataGridView1.Rows[i].Cells[1].Value = Tb_dt.Rows[i]["PAYER_NAME"];
                    DataGridView1.Rows[i].Cells[2].Value = Tb_dt.Rows[i]["t_level"];
                    DataGridView1.Rows[i].Cells[3].Value = Tb_dt.Rows[i]["t_final"];
                    DataGridView1.Rows[i].Cells[4].Value = Tb_dt.Rows[i]["B_balance"];
                    DataGridView1.Rows[i].Cells[5].Value = Tb_dt.Rows[i]["db"];
                    DataGridView1.Rows[i].Cells[6].Value = Tb_dt.Rows[i]["cr"];
                    DataGridView1.Rows[i].Cells[7].Value = Tb_dt.Rows[i]["E_balance"];

                }
                total_TB();

            //}

            //catch
            //{
            //}
            Cursor.Current = Cursors.Default;
        }

        void total_TB()
        {
            T_Bb.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[4].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[4].FormattedValue).ToString().ToDecimal()).Sum().ToString();
            T_Db.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[5].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[5].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            T_Cr.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[6].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            T_Eb.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty && row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[7].FormattedValue).ToString().ToDecimal()).Sum().ToString();

        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            UcTB1.Visible = true;
        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void usTB1_Load(object sender, EventArgs e)
        {

        }

        private void btnPrint_Click(object sender, EventArgs e)
        {

        }
    }
}
