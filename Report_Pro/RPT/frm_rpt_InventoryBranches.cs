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
 
    public partial class frm_rpt_InventoryBranches :Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string R, F, C, P, S, Z, X;
        double T1, T2;

        public frm_rpt_InventoryBranches()
        {
            InitializeComponent();

            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM " + Properties.Settings.Default.Database_1 + ".dbo.Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;
        }
        private void btn_print_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            DataTable dtP = new DataTable();
            RPT.rpt_inventory_Group_byBranch rpt = new RPT.rpt_inventory_Group_byBranch();
            RPT.Form1 frm = new RPT.Form1();

            dtP.Columns.Add("Code",typeof(string));
            dtP.Columns.Add("Name", typeof(string));
            dtP.Columns.Add("Balance_weight", typeof(decimal));
            dtP.Columns.Add("Sales_weight", typeof(decimal));
            dtP.Columns.Add("Monthely Sales", typeof(decimal));
            dtP.Columns.Add("Balance Period", typeof(decimal));
            rpt.SetParameterValue("noOfDays", System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(dTP1.Value, dTP2.Value));

            foreach (DataGridViewRow dgvrow in dataGridView1.Rows)
            {
                dtP.Rows.Add(dgvrow.Cells[0].Value, dgvrow.Cells[1].Value, dgvrow.Cells[2].Value, dgvrow.Cells[3].Value, dgvrow.Cells[4].Value, dgvrow.Cells[5].Value);
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

        private void dataGridView1_DoubleClick(object sender, EventArgs e)
        {
            RPT.frm_rpt_InventoryGroups frm = new RPT.frm_rpt_InventoryGroups();
            frm.Branch.ID.Text = this.dataGridView1.CurrentRow.Cells[0].Value.ToString();
            frm.Group.ID.Text = Group.ID.Text;
            frm.Group1.ID.Text = Group1.ID.Text;
            frm.Item.ID.Text = Item.ID.Text;
            frm.cmb_DimCategory.Text = cmb_DimCategory.Text;
            frm.Uc_Transaction.ID.Text = Uc_Transaction.ID.Text;
            frm.thick_1.Text = thick_1.Text;
            frm.thick_2.Text = thick_2.Text;
            frm.dTP1.Value = dTP1.Value;
            frm.dTP2.Value = dTP2.Value;
            frm.chR.Checked = chR.Checked;
            frm.chC.Checked = chC.Checked;
            frm.chF.Checked = chF.Checked;
            frm.chS.Checked = chS.Checked;
            frm.chP.Checked = chP.Checked;
            frm.chX.Checked = chX.Checked;
            frm.chZ.Checked = chZ.Checked;
            
            frm.getInventoryByGroup();
            frm.Show();
        }

       
        private void Item_Click(object sender, EventArgs e)
        {
          //  uc_SearchItem1.Visible = true;
         

        }

        private void printPreviewDialog1_Load(object sender, EventArgs e)
        {

        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;

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
            Cursor.Current = Cursors.WaitCursor;
           // groupBox1.Visible = false;

            choises();



            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT d.Branch_code as Code,B.branch_name as Name,B.WH_E_NAME as Name_E
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
        "%' group by  d.Branch_code,B.branch_name,B.WH_E_NAME order by d.Branch_code");

            int days = System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(dTP1.Value, dTP2.Value)+1;
           // dataGridView1.DataSource = dt1;


            int B_rowscount = dt1.Rows.Count;
            
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(B_rowscount);
            for (int i = 0; i<= (B_rowscount - 1); i++)
            {


                dataGridView1.Rows[i].Cells[0].Value = dt1.Rows[i][0];
                if (languh == "0")
                {
                    dataGridView1.Rows[i].Cells[1].Value = dt1.Rows[i][1];
                }
                else
                {
                    dataGridView1.Rows[i].Cells[1].Value = dt1.Rows[i][2];
                }
               
                dataGridView1.Rows[i].Cells[2].Value = dt1.Rows[i][4].ToString().ToDecimal();
                dataGridView1.Rows[i].Cells[3].Value = dt1.Rows[i][8].ToString().ToDecimal();
                dataGridView1.Rows[i].Cells[4].Value = (dt1.Rows[i][8].ToString().ToDecimal() * 30 / days).ToString().ToDecimal();
                if (dataGridView1.Rows[i].Cells[4].Value.ToString().ToDecimal() != 0)
                {
                    dataGridView1.Rows[i].Cells[5].Value = (dataGridView1.Rows[i].Cells[2].Value.ToString().ToDecimal()  / dataGridView1.Rows[i].Cells[4].Value.ToString().ToDecimal());
                }
                else
                {
                    dataGridView1.Rows[i].Cells[5].Value="0".ToDecimal();
                }

            }
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
            totSales.Text =
                (from DataGridViewRow row in dataGridView1.Rows
                 where row.Cells[3].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[3].FormattedValue).ToString().ToDecimal()).Sum().ToString("N0");

            totMonthelySales.Text =
                (from DataGridViewRow row in dataGridView1.Rows
                 where row.Cells[4].FormattedValue.ToString() != string.Empty 
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select (row.Cells[4].FormattedValue).ToString().ToDecimal()).Sum().ToString("N0");
            if (totMonthelySales.Text.ToDecimal() != 0)
            {
                totBalancePeriod.Text = (totBalance.Text.ToDecimal() / totMonthelySales.Text.ToDecimal()).ToString("N2");
            }
            else { totBalancePeriod.Text = "0"; }
        }


    }
}
