using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_TB : frm_ReportMaster
    {
        string db1 = Properties.Settings.Default.Database_1;
        string btn_name;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_TB()
        {
            InitializeComponent();


            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;

            DataGridView1.DataSource = null;
            DataGridView1.Rows.Clear();

            
        }

        private void frm_TB_Load(object sender, EventArgs e)
        {

        }

        public override void Report()
        {
            base.Report();

            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = true;
            crystalReportViewer1.Visible = false;
            //panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            try
            {

                string lvl = "";
                if (RBtnAll.Checked == true)
                { lvl = ""; }
                else if (RBtn1.Checked == true)
                { lvl = "0"; }
                else if (RBtn2.Checked == true)
                { lvl = "1"; }
                else if (RBtn3.Checked == true)
                { lvl = "2"; }
                else if (RBtn4.Checked == true)
                { lvl = "3"; }

                string Balance_ = "";

                if (All_B.Checked == true)
                {
                    Balance_ = "1";

                }
                else if (T_B.Checked == true)
                {
                    Balance_ = "2";

                }
                else if (debit_B.Checked == true)
                {
                    Balance_ = "3";

                }
                else if (Credit_B.Checked == true)
                {
                    Balance_ = "4";

                }
                else if (Zero_B.Checked == true)
                {
                    Balance_ = "5";

                }
                else if (UnZero_B.Checked == true)
                {
                    Balance_ = "6";

                }
                string Acc_Kind = "";
                if (RB_All_Acc.Checked == true)
                { Acc_Kind = ""; }
                else if (RB_M_Acc.Checked == true)
                { Acc_Kind = "0"; }
                else if (RB_S_Acc.Checked == true)
                { Acc_Kind = "1"; }




                DataTable Tb_dt = dal.getDataTabl("Get_TB_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc.ID.Text, UC_Branch.ID.Text, lvl, Balance_, Acc_Kind, Properties.Settings.Default.closeAcc, db1);

                int B_rowscount = Tb_dt.Rows.Count;
                DataGridView1.Rows.Clear();
                DataGridView1.Rows.Add(B_rowscount);
                for (int i = 0; (i
                           <= (B_rowscount - 1)); i++)
                {


                    DataGridView1.Rows[i].Cells[0].Value = Tb_dt.Rows[i][0];
                    DataGridView1.Rows[i].Cells[1].Value = Tb_dt.Rows[i][2];
                    DataGridView1.Rows[i].Cells[2].Value = Tb_dt.Rows[i][3];
                    DataGridView1.Rows[i].Cells[3].Value = Tb_dt.Rows[i][4];
                    //DataGridView1.Columns[4].DefaultCellStyle.Format = "n2";
                    //DataGridView1.Columns[5].DefaultCellStyle.Format = "n2";
                    //DataGridView1.Columns[6].DefaultCellStyle.Format = "n2";
                    //DataGridView1.Columns[7].DefaultCellStyle.Format = "n2";
                    DataGridView1.Rows[i].Cells[4].Value = Tb_dt.Rows[i][8];
                    DataGridView1.Rows[i].Cells[5].Value = Tb_dt.Rows[i][9];
                    DataGridView1.Rows[i].Cells[6].Value = Tb_dt.Rows[i][10];
                    DataGridView1.Rows[i].Cells[7].Value = Tb_dt.Rows[i][11];

                }
                //DataGridView1.DataSource = Tb_dt;
                total_TB();

            }

            catch
            {
            }
            Cursor.Current = Cursors.Default;



        }



        private void Button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = true;
            crystalReportViewer1.Visible = false;
            //panel3.Dock = System.Windows.Forms.DockStyle.Fill;
            try
            {

                string lvl = "";
                if (RBtnAll.Checked == true)
                { lvl = ""; }
                else if (RBtn1.Checked == true)
                { lvl = "0"; }
                else if (RBtn2.Checked == true)
                { lvl = "1"; }
                else if (RBtn3.Checked == true)
                { lvl = "2"; }
                else if (RBtn4.Checked == true)
                { lvl = "3"; }

                string Balance_ = "";

                if (All_B.Checked == true)
                {
                    Balance_ = "1";

                }
                else if (T_B.Checked == true)
                {
                    Balance_ = "2";

                }
                else if (debit_B.Checked == true)
                {
                    Balance_ = "3";

                }
                else if (Credit_B.Checked == true)
                {
                    Balance_ = "4";

                }
                else if (Zero_B.Checked == true)
                {
                    Balance_ = "5";

                }
                else if (UnZero_B.Checked == true)
                {
                    Balance_ = "6";

                }
                string Acc_Kind="";
                if (RB_All_Acc.Checked == true)
                { Acc_Kind = ""; }
                else if (RB_M_Acc.Checked==true)
                { Acc_Kind = "0"; }
                else if (RB_S_Acc.Checked == true)
                { Acc_Kind = "1"; }

          


                DataTable Tb_dt = dal.getDataTabl("Get_TB_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc.ID.Text, UC_Branch.ID.Text, lvl, Balance_,Acc_Kind,Properties.Settings.Default.closeAcc,db1);

                int B_rowscount = Tb_dt.Rows.Count;
                DataGridView1.Rows.Clear();
                DataGridView1.Rows.Add(B_rowscount);
                for (int i = 0; (i
                           <= (B_rowscount - 1)); i++)
                {


                    DataGridView1.Rows[i].Cells[0].Value = Tb_dt.Rows[i][0];
                    DataGridView1.Rows[i].Cells[1].Value = Tb_dt.Rows[i][2];
                    DataGridView1.Rows[i].Cells[2].Value = Tb_dt.Rows[i][3];
                    DataGridView1.Rows[i].Cells[3].Value = Tb_dt.Rows[i][4];
                    //DataGridView1.Columns[4].DefaultCellStyle.Format = "n2";
                    //DataGridView1.Columns[5].DefaultCellStyle.Format = "n2";
                    //DataGridView1.Columns[6].DefaultCellStyle.Format = "n2";
                    //DataGridView1.Columns[7].DefaultCellStyle.Format = "n2";
                    DataGridView1.Rows[i].Cells[4].Value = Tb_dt.Rows[i][8];
                    DataGridView1.Rows[i].Cells[5].Value = Tb_dt.Rows[i][9];
                    DataGridView1.Rows[i].Cells[6].Value = Tb_dt.Rows[i][10];
                    DataGridView1.Rows[i].Cells[7].Value = Tb_dt.Rows[i][11];

                }
                //DataGridView1.DataSource = Tb_dt;
                total_TB();

            }

            catch
            {
            }
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

        private void Button2_Click(object sender, EventArgs e)
        {
            

        }
        public override void preview()
        {
            base.preview();

            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = false;
            crystalReportViewer1.Visible = true;
            string lvl = "";
            if (RBtnAll.Checked == true)
            { lvl = ""; }
            if (RBtn1.Checked == true)
            { lvl = "0"; }
            if (RBtn2.Checked == true)
            { lvl = "1"; }
            if (RBtn3.Checked == true)
            { lvl = "2"; }
            if (RBtn4.Checked == true)
            { lvl = "3"; }

            //string bal = "1";                           
            //if (RB1.Checked == true)
            //{ bal = "1"; }                              
            //if (T_B.Checked == true)                    
            //{ bal = "2"; }                              
            //if (UnZero_B.Checked == true)
            //{ bal = "3"; }                              

            //if (RB4.Checked == true)                    
            //{ bal = "4"; }                              

            string Acc_Kind = "";
            string t_final = "0";
            if (RB_All_Acc.Checked == true)
            {
                Acc_Kind = "";
                t_final = "0";
            }
            else if (RB_M_Acc.Checked == true)
            {
                Acc_Kind = "0";
                t_final = "0";
            }
            else if (RB_S_Acc.Checked == true)
            {
                Acc_Kind = "1";
                t_final = "1";
            }

            string Balance_ = "";

            if (All_B.Checked == true)
            {
                Balance_ = "1";

            }
            else if (T_B.Checked == true)
            {
                Balance_ = "2";

            }
            else if (debit_B.Checked == true)
            {
                Balance_ = "3";

            }
            else if (Credit_B.Checked == true)
            {
                Balance_ = "4";

            }
            else if (Zero_B.Checked == true)
            {
                Balance_ = "5";

            }
            else if (UnZero_B.Checked == true)
            {
                Balance_ = "6";

            }
            if (Properties.Settings.Default.lungh == "0")
            { 
            
            RPT.rpt_TB tb_rep = new RPT.rpt_TB();

            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            dt1 = (dal.getDataTabl("Get_TB_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc.ID.Text, UC_Branch.ID.Text, lvl, Balance_, Acc_Kind, Properties.Settings.Default.closeAcc, "", db1, UC_cost.ID.Text));
            //  dt2= dal.getDataTabl_1("SELECT*  FROM tbl1 As T inner join " + dal.db1 + ".dbo.MEZANIA_ARBAH_CHART As M on M.Gr_Code=T.acc_Code  where T.acc_Code='1106' and   cast(T.G_Date as date)  between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'");
            // dt3 = dal.getDataTabl_1("select * FROM " + dal.db1 + ".dbo.MEZANIA_ARBAH_CHART  ");
            ds.Tables.Add(dt1);
            //ds.Tables.Add(dt2);
            //ds.Tables.Add(dt3);
            //ds.WriteXmlSchema("schema_rpt.xml");
            tb_rep.SetDataSource(ds);

            crystalReportViewer1.ReportSource = tb_rep;
            tb_rep.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            tb_rep.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            tb_rep.DataDefinition.FormulaFields["t_final"].Text = "'" + t_final + "'";
            tb_rep.DataDefinition.FormulaFields["digts_"].Text = "'" + Properties.Settings.Default.digitNo_ + "'";
        }
        else{
            
            RPT.rpt_TB_EN tb_rep = new RPT.rpt_TB_EN();

            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1=(dal.getDataTabl("Get_TB_", FromDate.Value.Date, ToDate.Value.Date, UC_Acc.ID.Text, UC_Branch.ID.Text, lvl, Balance_, Acc_Kind, Properties.Settings.Default.closeAcc,"", db1, UC_cost.ID.Text));
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema1.xml");
            tb_rep.SetDataSource(ds);
            crystalReportViewer1.ReportSource = tb_rep;
            tb_rep.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
            tb_rep.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            tb_rep.DataDefinition.FormulaFields["digts_"].Text = "'" + Properties.Settings.Default.digitNo_ + "'";
    }
         
            Cursor.Current = Cursors.Default;


            
        }


        private void button3_Click(object sender, EventArgs e)
        {
            
           
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
            
        }

        public override void Option()
        {
            groupPanel1.Visible = true;
            base.Option();
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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            panel3.Visible = false;
            crystalReportViewer1.Visible = true;
            string lvl = "";
            if (RBtnAll.Checked == true)
            { lvl = ""; }
            if (RBtn1.Checked == true)
            { lvl = "0"; }
            if (RBtn2.Checked == true)
            { lvl = "1"; }
            if (RBtn3.Checked == true)
            { lvl = "2"; }
            if (RBtn4.Checked == true)
            { lvl = "3"; }

            string Balance_ = "";

            if (All_B.Checked == true)
            {
                Balance_ = "1";

            }
            else if (T_B.Checked == true)
            {
                Balance_ = "2";

            }
            else if (debit_B.Checked == true)
            {
                Balance_ = "3";

            }
            else if (Credit_B.Checked == true)
            {
                Balance_ = "4";

            }
            else if (Zero_B.Checked == true)
            {
                Balance_ = "5";

            }
            else if (UnZero_B.Checked == true)
            {
                Balance_ = "6";

            }
            string Acc_Kind = "";
            string t_final = "0";
            if (RB_All_Acc.Checked == true)
            {
                Acc_Kind = "";
                t_final = "0";
            }
            else if (RB_M_Acc.Checked == true)
            {
                Acc_Kind = "0";
                t_final = "0";
            }
            else if (RB_S_Acc.Checked == true)
            {
                Acc_Kind = "1";
                t_final = "1";
            }


            RPT.rpt_TB tb_rep = new RPT.rpt_TB();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            DataTable dt3 = new DataTable();
            dt1 = (dal.getDataTabl("Get_TB_group", FromDate.Value.Date, ToDate.Value.Date, UC_Acc.ID.Text, UC_Branch.ID.Text, lvl, Balance_, Acc_Kind, Properties.Settings.Default.closeAcc, "", "GroupDB", UC_cost.ID.Text));
            //  dt2= dal.getDataTabl_1("SELECT*  FROM tbl1 As T inner join " + dal.db1 + ".dbo.MEZANIA_ARBAH_CHART As M on M.Gr_Code=T.acc_Code  where T.acc_Code='1106' and   cast(T.G_Date as date)  between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' and '" + ToDate.Value.ToString("yyyy/MM/dd") + "'");
            // dt3 = dal.getDataTabl_1("select * FROM " + dal.db1 + ".dbo.MEZANIA_ARBAH_CHART  ");
            ds.Tables.Add(dt1);
            //ds.Tables.Add(dt2);
            //ds.Tables.Add(dt3);
            //ds.WriteXmlSchema("schema_rpt.xml");
            tb_rep.SetDataSource(ds);

            crystalReportViewer1.ReportSource = tb_rep;
            tb_rep.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            tb_rep.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
            tb_rep.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            tb_rep.DataDefinition.FormulaFields["t_final"].Text = "'" + t_final + "'";
            tb_rep.DataDefinition.FormulaFields["digts_"].Text = "'" + Properties.Settings.Default.digitNo_ + "'";

            Cursor.Current = Cursors.Default;


        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
