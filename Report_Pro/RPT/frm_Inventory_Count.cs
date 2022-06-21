using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_Inventory_Count : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string db1 = Properties.Settings.Default.Database_1;
        public frm_Inventory_Count()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
          
        }

        private void uC_Branch1_Load(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

    
        private void btn_1_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void UC_Branch_Load(object sender, EventArgs e)
        {
            UC_Acc.branchID.Text = UC_Branch.ID.Text;
        }

        private void Purchase_reports_Load(object sender, EventArgs e)
        {

        }

    
        private void btn_stock_count_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string trans_1, trans_2, trans_3;
            if (XIO.Checked == true) { trans_1 = "XIO"; } else { trans_1 = ""; }
            if (XIM.Checked == true) { trans_2 = "XIM"; } else { trans_2 = ""; }
            if (XTT.Checked == true) { trans_3 = "XTT"; } else { trans_3 = ""; }

            groupPanel1.Visible = false;
            RPT.rpt_inventory_count rpt = new RPT.rpt_inventory_count();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            dt1 = dal.getDataTabl_1(@"select A.SER_NO, B.Branch_code, B.branch_name, A.g_date, A.TRANSACTION_CODE
            , M.item_no, M.Weight, M.descr, QTY_ADD - QTY_TAKE as Count_Qty
            from wh_material_transaction As A
            inner join wh_main_master as M on M.item_no = a.ITEM_NO
            inner join wh_BRANCHES as B on B.Branch_code = A.Branch_code
            where cast(a.G_date as date) between '"+FromDate_.Value.ToString("yyyy/MM/dd")+ "' and '" + ToDate_.Value.ToString("yyyy/MM/dd") +
            "' and a.item_no like '" + UC_Items.ID.Text + "%' and a.Branch_code like '" + UC_Branch.ID.Text + 
            "%'and(TRANSACTION_CODE = '"+trans_1+"' or TRANSACTION_CODE = '"+ trans_2 + "' or TRANSACTION_CODE = '"+ trans_3 + 
            "' and M.group_code like '"+ Uc_Group1.ID.Text+ "%') order by a.Branch_code, A.ser_no, a.item_no");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.ID.Text + "'+' - '+'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Item_"].Text = "'" + UC_Items.ID.Text + "'+' - '+'" + UC_Items.Desc.Text + "'";
            //rpt.DataDefinition.FormulaFields["Transaction_"].Text = "'" + UC_Transaction.Desc.Text + "'";
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            string trans_1, trans_2, trans_3;
            if (XIO.Checked == true) { trans_1 = "XIO"; } else { trans_1 = ""; }
            if (XIM.Checked == true) { trans_2 = "XIM"; } else { trans_2 = ""; }
            if (XTT.Checked == true) { trans_3 = "XTT"; } else { trans_3 = ""; }
            groupPanel1.Visible = false;
            RPT.count_report_byGroup rpt = new RPT.count_report_byGroup();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            dt1 = dal.getDataTabl("get_stock_count_byGroup_", FromDate_.Value.Date, ToDate_.Value.Date, UC_Items.ID.Text, UC_Branch.ID.Text, trans_1, trans_2, trans_3, Uc_Group1.ID.Text, db1, ToDate_.Value.Date.ToString("yy"))
                ;
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.ID.Text + "'+' - '+'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Group_"].Text = "'" + Uc_Group1.ID.Text + "'+' - '+'" + Uc_Group1.Desc.Text + "'";
            //rpt.DataDefinition.FormulaFields["Transaction_"].Text = "'" + UC_Transaction.Desc.Text + "'";
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            string trans_1, trans_2, trans_3;
            if (XIO.Checked == true) { trans_1 = "XIO"; } else { trans_1 = ""; }
            if (XIM.Checked == true) { trans_2 = "XIM"; } else { trans_2 = ""; }
            if (XTT.Checked == true) { trans_3 = "XTT"; } else { trans_3 = ""; }
            groupPanel1.Visible = false;
            RPT.rpt_stock_count_byItem rpt = new RPT.rpt_stock_count_byItem();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            dt1 = dal.getDataTabl("get_stock_count_byItem_", FromDate_.Value.Date, ToDate_.Value.Date, UC_Items.ID.Text, UC_Branch.ID.Text, trans_1,trans_2,trans_3, Uc_Group1.ID.Text, db1);
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.ID.Text + "'+' - '+'" + UC_Branch.Desc.Text + "'";
            //rpt.DataDefinition.FormulaFields["Group_"].Text = "'" + Uc_Group1.ID.Text + "'+' - '+'" + Uc_Group1.Desc.Text + "'";
            //rpt.DataDefinition.FormulaFields["Transaction_"].Text = "'" + UC_Transaction.Desc.Text + "'";
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;
        }

        private void UC_Items_DoubleClick(object sender, EventArgs e)
        {
            PL.frm_search_items frm = new PL.frm_search_items();
            frm.ShowDialog();
           UC_Items.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
           UC_Items.Desc.Text = frm.dGV_pro_list.CurrentRow.Cells[2].Value.ToString();
             }
    }
}
