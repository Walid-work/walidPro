using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.Group
{
    public partial class frm_Customers_TB_Group : Form
    {
        DataTable dt_ = new DataTable();
        string db1 = "GroupDB";
        string btn_name;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        BindingSource bs = new BindingSource();

        string bal = "1";
        string accNO = "";
        string Acc_Stope = "";
        double b_1, b_2;
        string Facilty_="";

        public frm_Customers_TB_Group()
        {
            InitializeComponent();


            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;

            DataGridView1.DataSource = null;
            DataGridView1.Rows.Clear();
            
        }

        void createDattable()
        {
            dt_.Columns.Add("Account", typeof(string));
            dt_.Columns.Add("Name", typeof(string));
            dt_.Columns.Add("Status", typeof(string));
            dt_.Columns.Add("Credit Days", typeof(int));
            dt_.Columns.Add("Credit Amount", typeof(decimal));
            dt_.Columns.Add("Previous Balance", typeof(decimal));
            dt_.Columns.Add("Current Balance", typeof(decimal));
            dt_.Columns.Add("Sales", typeof(decimal));
            dt_.Columns.Add("Paid", typeof(decimal));
            dt_.Columns.Add("Collection Rate", typeof(decimal));
            dt_.Columns.Add("Turnover", typeof(decimal));
            dt_.Columns.Add("Collection Period", typeof(decimal));

        }

        private void frm_TB_Load(object sender, EventArgs e)
        {
            createDattable();
            DataGridView1.DataSource = dt_;
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = true;
            crystalReportViewer1.Visible = false;




            //try
            //{

            if (RB1.Checked == true)
            { bal = "1"; }
            if (RB2.Checked == true)
            { bal = "2"; }
            if (RB3.Checked == true)
            { bal = "3"; }
            if (RB4.Checked == true)
            { bal = "4"; }
            if (RB5.Checked == true)
            { bal = "5"; }
            if (RB6.Checked == true)
            { bal = "6"; }


            if (chBox.Checked == true)
            {
                b_1 = b1.Value;
                b_2 = b2.Value;
            }
            else
            {
                b_1 = -1000000000;
                b_2 = 1000000000;
            }
            check_condetion();

            DataTable Tb_dt = dal.getDataTabl("Get_customer_TB_", FromDate.Value.Date, ToDate.Value.Date, accNO, UC_Branch.ID.Text, "", bal, "1", Properties.Settings.Default.closeAcc, Acc_Stope, db1, b_1, b_2);

            dt_.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in Tb_dt.Rows)
            {

                row = dt_.NewRow();




             //   if (Tb_dt.Rows.Count> 0){
                //int B_rowscount = Tb_dt.Rows.Count;
                //DataGridView1.Rows.Clear();
                //DataGridView1.Rows.Add(B_rowscount);
                //for (int i = 0; (i <= (B_rowscount - 1)); i++)
                //{


                   row[0] = Tb_dt.Rows[i][0];
                   row[1] = Tb_dt.Rows[i][2];
                    if (Convert.ToString(Tb_dt.Rows[i][9]).ToUpper() == "S")
                    {
                       row[2] = "متوقف";
                    }

                   row[3] = Tb_dt.Rows[i][11];
                    DataGridView1.Columns[4].DefaultCellStyle.Format = "n0";
                    DataGridView1.Columns[9].DefaultCellStyle.Format = "P0";
                   row[4] = Tb_dt.Rows[i][10];
                   row[5] = Tb_dt.Rows[i][14].ToString().ToDecimal().ToString("n3");
                   row[6] = Tb_dt.Rows[i][17].ToString().ToDecimal().ToString("n3");
                   row[7] = Tb_dt.Rows[i][15].ToString().ToDecimal().ToString("n3");
                   row[8] = Tb_dt.Rows[i][16].ToString().ToDecimal().ToString("n3");
                    if (Tb_dt.Rows[i][15].ToString().ToDecimal() > 0)
                    {
                       row[9] = Math.Round(Tb_dt.Rows[i][16].ToString().ToDecimal() / Tb_dt.Rows[i][15].ToString().ToDecimal(), 2);
                    }

                    if (Tb_dt.Rows[i][15].ToString().ToDecimal() > 0 && (Tb_dt.Rows[i][14].ToString().ToDecimal() + Tb_dt.Rows[i][17].ToString().ToDecimal()) / 2 > 0)
                    {
                       row[10] = Math.Round(Tb_dt.Rows[i][15].ToString().ToDecimal() / ((Tb_dt.Rows[i][14].ToString().ToDecimal() + Tb_dt.Rows[i][15].ToString().ToDecimal()) / 2), 2);
                    }

                    if (Tb_dt.Rows[i][14].ToString().ToDecimal() + Tb_dt.Rows[i][17].ToString().ToDecimal() > 0)
                    {

                        if ((Tb_dt.Rows[i][15].ToString().ToDecimal() / ((Tb_dt.Rows[i][14].ToString().ToDecimal() + Tb_dt.Rows[i][17].ToString().ToDecimal()) / 2)) > 0)
                        {
                           row[11] = Math.Round(365 / (Tb_dt.Rows[i][15].ToString().ToDecimal() / ((Tb_dt.Rows[i][14].ToString().ToDecimal() + Tb_dt.Rows[i][17].ToString().ToDecimal()) / 2)), 0);
                        }
                    }

                dt_.Rows.Add(row);
                i = i + 1;
            }

            DataGridView1.DataSource = dt_;

            bs.DataSource = DataGridView1.DataSource;
            bs.Filter = "[Account] <> '' ";
            DataGridView1.DataSource = bs;

            total_TB();

            
           
            //catch
            //{
            //}
            Cursor.Current = Cursors.Default;
           
        }

        void total_TB()
        {
            T_Bb.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[5].FormattedValue.ToString() != string.Empty 
                 //&& row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[5].FormattedValue).ToString().ToDecimal()).Sum().ToString();
            T_Db.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[7].FormattedValue.ToString() != string.Empty 
                 //&& row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[7].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            T_Cr.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[8].FormattedValue.ToString() != string.Empty 
                 //&& row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[8].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            T_Eb.Text =
                (from DataGridViewRow row in DataGridView1.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty 
                 //&& row.Cells[2].FormattedValue.ToString() == "0"
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[6].FormattedValue).ToString().ToDecimal()).Sum().ToString();

        }

        private void Button2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = false;
            crystalReportViewer1.Visible = true;


            if (RB1.Checked == true)
            { bal = "1"; }
            if (RB2.Checked == true)
            { bal = "2"; }
            if (RB3.Checked == true)
            { bal = "3"; }
            if (RB4.Checked == true)
            { bal = "4"; }
            if (RB5.Checked == true)
            { bal = "5"; }
            if (RB6.Checked == true)
            { bal = "6"; }

            if (chBox.Checked == true)
            {
                b_1 = b1.Value;
                b_2 = b2.Value;
            }
            else
            {
                b_1 = -1000000000;
                b_2 = 1000000000;
            }



            check_condetion();
            RPT.rpt_TB_EN tb_rep = new RPT.rpt_TB_EN();

            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl("Get_customer_TB_", FromDate.Value.Date, ToDate.Value.Date, accNO, UC_Branch.ID.Text, "", bal, "1", Properties.Settings.Default.closeAcc, Acc_Stope, db1, b_1, b_2);
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema1.xml");
            tb_rep.SetDataSource(ds);
            crystalReportViewer1.ReportSource = tb_rep;
            tb_rep.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
            tb_rep.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'"; 
            Cursor.Current = Cursors.Default;

        }


        private void check_condetion()
        {
            if (RS1.Checked == true)
            { Acc_Stope = ""; }
            else if (RS2.Checked == true)
            { Acc_Stope = "S"; }

            //string accNO = UC_Acc.ID.Text;
            if (UC_Acc.ID.Text == "")
            {
                accNO = "123";
            }
            else
            {
                accNO = UC_Acc.ID.Text;
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = false;
            crystalReportViewer1.Visible = true;

        
            if (RB1.Checked == true)
            { bal = "1"; }
            if (RB2.Checked == true)
            { bal = "2"; }
            if (RB3.Checked == true)
            { bal = "3"; }
            if (RB4.Checked == true)
            { bal = "4"; }
            if (RB5.Checked == true)
            { bal = "5"; }
            if (RB6.Checked == true)
            { bal = "6"; }





            if (chBox.Checked == true)
            {
                b_1 = b1.Value;
                b_2 = b2.Value;
            }
            else
            {
                b_1 = -1000000000;
                b_2 = 1000000000;
            }

            check_condetion();

            RPT.rpt_Customers_TB tb_rep = new RPT.rpt_Customers_TB();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();
            dt1 = dal.getDataTabl("Get_customer_TB_", FromDate.Value.Date, ToDate.Value.Date, accNO, UC_Branch.ID.Text, "", bal, "1", "", Acc_Stope,db1, b_1, b_2);
            ds.Tables.Add(dt1);
            //tb_rep.SetDataSource(dal.getDataTabl("Get_customer_TB", FromDate.Value.Date, ToDate.Value.Date, accNO, UC_Branch.ID.Text, "", bal,"1",Properties.Settings.Default.closeAcc,db1));                  
            //ds.WriteXmlSchema("schema_rpt.xml");
            tb_rep.SetDataSource(ds);

            crystalReportViewer1.ReportSource = tb_rep;
            tb_rep.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            tb_rep.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            tb_rep.DataDefinition.FormulaFields["decimal_"].Text = "'" + Properties.Settings.Default.digitNo_ + "'";

            Cursor.Current = Cursors.Default;
         
           
        }

        private void DGV3_DoubleClick(object sender, EventArgs e)
        {
            if (btn_name == "Acc_serch")
            {
                int ii = DGV3.CurrentCell.RowIndex;

                UC_Acc.ID.Text = DGV3.Rows[ii].Cells[0].Value.ToString();
                UC_Acc.Desc.Text = DGV3.Rows[ii].Cells[1].Value.ToString();

            }

            else if (btn_name == "Search_Branch")
            {
                int ii = DGV3.CurrentCell.RowIndex;
                UC_Branch.ID.Text = DGV3.Rows[ii].Cells[0].Value.ToString();
                UC_Branch.Desc.Text = DGV3.Rows[ii].Cells[1].Value.ToString();
            }

            else if (btn_name == "cost_serch")
            {
                int ii = DGV3.CurrentCell.RowIndex;
                UC_cost.ID.Text = DGV3.Rows[ii].Cells[0].Value.ToString();
                UC_cost.Desc.Text = DGV3.Rows[ii].Cells[1].Value.ToString();
            }


            DGV3.Visible = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            btn_name = "cost_serch";
            DGV3.Visible = true;
            DGV3.DataSource = dal.getDataTabl("SearchCost", UC_cost.Desc.Text);
            DGV3.Columns[0].Width = 80;
            int clientX = (int)(UC_cost.Location.X);
            int clientY = (int)(UC_cost.Location.Y);
            DGV3.Location = new Point(clientX, clientY + 20);
        }


        private void search_ACC()
        {
            btn_name = "Acc_serch";
            DGV3.Visible = true;
            DGV3.DataSource = dal.getDataTabl_1("select Acc_no,PAYER_NAME,payer_l_name from "+db1+".dbo.payer2 where BRANCH_code like '" + UC_Branch.ID.Text
            + "%' and (PAYER_NAME like '%" + UC_Acc.Desc.Text + "%' or payer_l_name like '%" + UC_Acc.Desc.Text + "%') and t_final= ''");
            DGV3.Columns[2].Visible = false;
            DGV3.Columns[0].Width = 80;
            int clientX = (int)(UC_Acc.Location.X);
            int clientY = (int)(UC_Acc.Location.Y);
            DGV3.Location = new Point(clientX, clientY + 20);
        }


        private void search_branch()
        {
            btn_name = "Search_Branch";
            DGV3.Visible = true;
            DGV3.DataSource = dal.getDataTabl_1("select Branch_code,branch_name,WH_E_NAME from " + db1 + ".dbo.wh_BRANCHES where branch_name like '%" + UC_Branch.Desc.Text + "%' and t_final= '1'");
            DGV3.Columns[2].Visible = false;
            DGV3.Columns[0].Width = 80;
            int clientX = (int)(UC_Branch.Location.X);
            int clientY = (int)(UC_Branch.Location.Y);
            DGV3.Location = new Point(clientX, clientY + 20);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            search_branch();
        }

      

        private void Branch_code_Enter(object sender, EventArgs e)
        {
            DGV3.Visible = false;
        }

        private void Acc_no_Enter(object sender, EventArgs e)
        {
            DGV3.Visible = false;
        }

        private void Cost_No_Enter(object sender, EventArgs e)
        {
            DGV3.Visible = false;
        }

        private void Cat_No_Enter(object sender, EventArgs e)
        {
            DGV3.Visible = false;
        }

        private void Acc_name_KeyUp(object sender, KeyEventArgs e)
        {
            search_ACC();
        }

        private void Branch_name_KeyUp(object sender, KeyEventArgs e)
        {
            search_branch();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void Search_Acc_1_Click(object sender, EventArgs e)
        {
            search_ACC();
        }

        private void Acc_no_TextChanged(object sender, EventArgs e)
        {

        }

        private void RBtn6_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton5_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Acc_name_TextChanged(object sender, EventArgs e)
        {

        }

        private void Branch_code_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void UC_Branch_Load(object sender, EventArgs e)
        {
            UC_Acc.branchID.Text = UC_Branch.ID.Text;
        }

        private void uC_cost1_Load(object sender, EventArgs e)
        {

        }

        private void Cost_No_TextChanged(object sender, EventArgs e)
        {

        }

        private void Cost_Name_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void RBtn3_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void RBtn4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void Statment__Click(object sender, EventArgs e)
        {
            int ii = DataGridView1.CurrentCell.RowIndex;

            RPT.frm_statment_Rpt frm_statment_Rpt = new RPT.frm_statment_Rpt();
            frm_statment_Rpt.UC_Acc1.ID.Text = DataGridView1.Rows[ii].Cells[0].Value.ToString();
            
            frm_statment_Rpt.Show();
        }

        private void RS2_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chBox_CheckedChanged(object sender, EventArgs e)
        {
            if (chBox.Checked == true)
            {
                gBox3.Visible = true;
            }
            else
            {
                gBox3.Visible = false;
            }
        }

        private void DataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            bs.Filter = DataGridView1.FilterString;
        }

        private void DataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            bs.Sort = DataGridView1.SortString;

        }

        private void T_Cr_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
