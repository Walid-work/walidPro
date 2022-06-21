using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PagedList;
namespace Report_Pro.RPT
{

    public partial class frm_rpt_InventoryItems : Form
    {
        DataTable dt_ = new DataTable();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        BindingSource bs = new BindingSource();

        string R, F, C, P, S, Z, X;
        double T1, T2;

        public frm_rpt_InventoryItems()
        {
            InitializeComponent();
            createDattable();

            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM " + Properties.Settings.Default.Database_1 + ".dbo.Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;
        }

        void createDattable()
        {
            dt_.Columns.Add("Code", typeof(string));
            dt_.Columns.Add("Name", typeof(string));
            dt_.Columns.Add("Balance", typeof(decimal));
            dt_.Columns.Add("Balance weight", typeof(decimal));
            dt_.Columns.Add("Sales", typeof(decimal));
            dt_.Columns.Add("Sales weight", typeof(decimal));
            dt_.Columns.Add("Monthely Sales", typeof(decimal));
            dt_.Columns.Add("Monthely Sales weight", typeof(decimal));
            dt_.Columns.Add("Balance Period", typeof(decimal));
        }

       void FormatDG()
        {
            dataGridView1.Columns[0].Width = 110;
            dataGridView1.Columns[1].Width = 250;
            dataGridView1.Columns[2].Width = 150;
            dataGridView1.Columns[3].Width = 150;
            dataGridView1.Columns[4].Width = 150;
            dataGridView1.Columns[5].Width = 150;
            dataGridView1.Columns[6].Width = 150;
            dataGridView1.Columns[7].Width = 150;
            dataGridView1.Columns[8].Width = 110;
            dataGridView1.Columns[2].DefaultCellStyle.Format = "n0";
            dataGridView1.Columns[3].DefaultCellStyle.Format = "n0";
            dataGridView1.Columns[4].DefaultCellStyle.Format = "n0";
            dataGridView1.Columns[5].DefaultCellStyle.Format = "n0";
            dataGridView1.Columns[6].DefaultCellStyle.Format = "n0";
            dataGridView1.Columns[7].DefaultCellStyle.Format = "n0";
            dataGridView1.Columns[8].DefaultCellStyle.Format = "n2";
        }
        

        private void btn_print_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            DataTable dtP = new DataTable();
            RPT.rpt_inventory_Group_byBranch rpt = new RPT.rpt_inventory_Group_byBranch();
            RPT.Form1 frm = new RPT.Form1();

            dtP.Columns.Add("Code", typeof(string));
            dtP.Columns.Add("Name", typeof(string));
            dtP.Columns.Add("Balance", typeof(decimal));
            dtP.Columns.Add("Balance weight", typeof(decimal));
            dtP.Columns.Add("Sales", typeof(decimal));
            dtP.Columns.Add("Sales weight", typeof(decimal));
            dtP.Columns.Add("Monthely Sales", typeof(decimal));
            dtP.Columns.Add("Monthely Sales Weight", typeof(decimal));
            dtP.Columns.Add("Balance Period", typeof(decimal));
            rpt.SetParameterValue("noOfDays", System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(dTP1.Value, dTP2.Value));

            foreach (DataGridViewRow dgvrow in dataGridView1.Rows)
            {
                dtP.Rows.Add(dgvrow.Cells[0].Value, dgvrow.Cells[1].Value,
                    dgvrow.Cells[2].Value, dgvrow.Cells[3].Value, dgvrow.Cells[4].Value,
                    dgvrow.Cells[5].Value, dgvrow.Cells[6].Value, dgvrow.Cells[7].Value,
                    dgvrow.Cells[8].Value);
            }

            ds.Tables.Add(dtP);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(dtP);
            frm.crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["fromGroup"].Text = "'" + Group.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["toGroup"].Text = "'" + Group1.Desc.Text + "'";
            frm.ShowDialog();
            Cursor.Current = Cursors.Default;
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap objBmp = new Bitmap(this.dataGridView1.Width, this.dataGridView1.Height);
            dataGridView1.DrawToBitmap(objBmp, new Rectangle(0, 0, this.dataGridView1.Width, this.dataGridView1.Height));
            e.Graphics.DrawImage(objBmp, 100, 100);
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

        }

        private void thick_1_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_SortStringChanged(object sender, EventArgs e)
        {
            bs.Sort = dataGridView1.SortString;
            getTotal();
        }

        private void dataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
            bs.Filter = dataGridView1.FilterString;
            getTotal();
        }

        private void dataGridView1_BindingContextChanged(object sender, EventArgs e)
        {
            getTotal();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            RPT.frm_Item_Transaction frm = new RPT.frm_Item_Transaction();
            frm.UC_Branch.ID.Text = Branch.ID.Text;
            frm.Uc_Group1.ID.Text = Group.ID.Text;
            frm.UC_Items.ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.UC_Transaction.ID.Text = Uc_Transaction.ID.Text;
            frm.FromDate_.Value = dTP1.Value;
            frm.ToDate_.Value = dTP2.Value;
           
            frm.getItemCard();
            frm.ShowDialog();
        }

        string languh = Properties.Settings.Default.lungh;

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rpt_InventoryBranches_Load(object sender, EventArgs e)
        {

        }

        private void choises()
        {
            if (chR.Checked == true) { R = "R"; } else { R = "Y"; }
            if (chF.Checked == true) { F = "F"; } else { F = "Y"; }
            if (chC.Checked == true) { C = "C"; } else { C = "Y"; }
            if (chS.Checked == true) { S = "S"; } else { S = "Y"; }
            if (chP.Checked == true) { P = "P"; } else { P = "Y"; }
            if (chZ.Checked == true) { Z = "Z"; } else { Z = "Y"; }
            if (chX.Checked == true) { X = "X"; } else { X = "Y"; }
            Cursor.Current = Cursors.WaitCursor;
            // double T1, T2;
            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Text == "0")
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }
        }




        private void btnReport_Click(object sender, EventArgs e)
        {

            getInventoryByItems();

        }

        public void getInventoryByItems(){

  Cursor.Current = Cursors.WaitCursor;
           // groupBox1.Visible = false;

            choises();



        DataSet1 ds = new DataSet1();
        DataTable dt1 = new DataTable();

        dt1 = dal.getDataTabl_1(@"SELECT D.item_no as Code ,A.descr as Name,A.Descr_eng as Name_E
        ,sum (case when cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' then D.QTY_ADD-D.QTY_TAKE  else 0 end)  as Balance_ " +
        ",sum(case when cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' then (D.QTY_ADD - D.QTY_TAKE)*A.Weight  else 0 end) as Balance_Weight " +


        ",sum (case when D.TRANSACTION_CODE  like 'Xp%' and  cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") + "' then D.QTY_ADD-D.QTY_TAKE  else 0 end)  as Purchases_ " +
        ",sum (case when D.TRANSACTION_CODE  like 'Xp%' and  cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") + "' then (D.QTY_ADD-D.QTY_TAKE)*A.Weight  else 0 end)  as Purchases_Weight " +

        ",sum (case when D.TRANSACTION_CODE  like 'XS%' and  cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") + "' then D.QTY_TAKE-D.QTY_ADD  else 0 end)  as Sales_ " +
        ",sum (case when D.TRANSACTION_CODE  like 'XS%' and  cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") + "' then (D.QTY_TAKE-D.QTY_ADD)*A.Weight   else 0 end)  as Sales_Weight " +

        "FROM wh_material_transaction As D " +
        "inner join wh_BRANCHES as B on B.branch_code = D.Branch_code " +
        "inner join wh_main_master As A on A.item_no = D.ITEM_NO " +
        "inner join wh_Groups As G on g.group_code = a.group_code " +

        "where  g.group_code  between (CASE WHEN '" + Group.ID.Text.Length + "' >3  then  '" + Group.ID.Text + "' else '" + Group.ID.Text + "'+'0' end) and " +
        "(CASE WHEN '" + Group1.ID.Text.Length + "' >3   then  '" + Group1.ID.Text + "' else  '" + Group1.ID.Text + "'+'z' end) " +
        "and  D.branch_code like (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "%' else  '" + Branch.ID.Text + "%' end) " +
        " and ISNULL (A.UnitDepth,'') BETWEEN '" + T1 + "' AND '" + T2 +
        "' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "') " +
        " and ISNULL (A.Dim_category,'') like '" + Convert.ToString(cmb_DimCategory.SelectedValue) +
        "%' and D.Item_No like '" + Item.ID.Text +
        "%'group by    D.item_no ,A.descr ,A.Descr_eng order by D.item_no");

            int days = System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(dTP1.Value, dTP2.Value) + 1;
            // dataGridView1.DataSource = dt1;


            dt_.Clear();
            int i = 0;
            DataRow row = null;
            foreach (DataRow r in dt1.Rows)
            {

                row = dt_.NewRow();
                row[0] = dt1.Rows[i]["Code"];
                if (languh == "0")
                {
                    row[1] = dt1.Rows[i]["Name"];
                }
                else
                {
                    row[1] = dt1.Rows[i]["Name_E"];
                }
                row[2] = dt1.Rows[i]["Balance_"].ToString().ToDecimal();
                row[3] = dt1.Rows[i]["Balance_Weight"].ToString().ToDecimal();
                row[4] = dt1.Rows[i]["Sales_"].ToString().ToDecimal();
                row[5] = dt1.Rows[i]["Sales_Weight"].ToString().ToDecimal();
                if (days>0)
                {
                    row[6] = row[4].ToString().ToDecimal()*30 / days;
                    row[7] = row[5].ToString().ToDecimal() * 30 / days;
                }
                else
                {
                    row[6] = "0".ToDecimal();
                    row[7] = "0".ToDecimal();
                }
                if (row[6].ToString().ToDecimal()>0)
                {
                    row[8] = row[2].ToString().ToDecimal() / row[6].ToString().ToDecimal();
                }
                else
                {
                    row[8] = "0".ToDecimal();
                }




                dt_.Rows.Add(row);
                i = i + 1;
            }

            dataGridView1.DataSource = dt_;
             
            bs.DataSource = dataGridView1.DataSource;
            bs.Filter = "[Balance] <> 0 or [Sales Weight] <> 0 ";
            dataGridView1.DataSource = bs;
            FormatDG();
            getTotal();
            Cursor.Current = Cursors.Default;



}

        void getTotal()
        {
            totBalance.Text =
               (from DataGridViewRow row in dataGridView1.Rows
                where row.Cells[2].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[2].FormattedValue).ToString().ToDecimal()).Sum().ToString("N0");

            totBalanceWeight.Text =
                (from DataGridViewRow row in dataGridView1.Rows
                 where row.Cells[3].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[3].FormattedValue).ToString().ToDecimal()).Sum().ToString("N0");

                totSales.Text =
                (from DataGridViewRow row in dataGridView1.Rows
                 where row.Cells[4].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[4].FormattedValue).ToString().ToDecimal()).Sum().ToString("N0");

                    totSalesWeight.Text =
                    (from DataGridViewRow row in dataGridView1.Rows
                    where row.Cells[5].FormattedValue.ToString() != string.Empty
                    // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                    select (row.Cells[5].FormattedValue).ToString().ToDecimal()).Sum().ToString("N0");

              totMonthelySales.Text =
                (from DataGridViewRow row in dataGridView1.Rows
                 where row.Cells[6].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[6].FormattedValue).ToString().ToDecimal()).Sum().ToString("N0");

            totMonthelySalesWeight.Text =
               (from DataGridViewRow row in dataGridView1.Rows
                where row.Cells[7].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[7].FormattedValue).ToString().ToDecimal()).Sum().ToString("N0");

            if (totMonthelySales.Text.ToDecimal() != 0)
            {
                totBalancePeriod.Text = (totBalance.Text.ToDecimal() / totMonthelySales.Text.ToDecimal()).ToString("N2");
            }
        }


    }
}
