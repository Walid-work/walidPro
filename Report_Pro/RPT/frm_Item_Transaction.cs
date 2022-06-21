using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_Item_Transaction : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string db1 = Properties.Settings.Default.Database_1;
        public frm_Item_Transaction()
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

        private void Report_btn_Click(object sender, EventArgs e)
        {
            DateTime fd_ofYear = new DateTime(FromDate_.Value.Year, 1, 1);
            this.Cursor = Cursors.WaitCursor;
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            groupPanel1.Visible = false;
            RPT.rpt_Item_Transaction rpt = new RPT.rpt_Item_Transaction();

            //,SUM(CASE WHEN  cast(D.g_date as date) < '"+FromDate_.Value.ToString("yyyy/MM/dd")+ "' and cast(D.g_date as date) >= '" + fd_ofYear.ToString("yyyy/MM/dd") + "' THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS B_balance " +
            dt1 = (dal.getDataTabl_1(@"select * from(
         SELECT d.ITEM_NO, s.descr,s.Descr_eng
		
        , SUM(CASE WHEN  cast(D.g_date as date) BETWEEN '" + FromDate_.Value.ToString("yyyy/MM/dd") + "' AND '" + ToDate_.Value.ToString("yyyy/MM/dd") + "' and D.TRANSACTION_CODE='xio' and D.ser_no='0' THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS B_balance " +
        ",SUM(CASE WHEN  cast(D.g_date as date) BETWEEN '" +FromDate_.Value.ToString("yyyy/MM/dd")+"' AND '"+ToDate_.Value.ToString("yyyy/MM/dd")+"' and A.Transaction_code like 'Xp%' THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS Xp_ " +
        ",SUM(CASE WHEN  cast(D.g_date as date) BETWEEN '"+FromDate_.Value.ToString("yyyy/MM/dd")+ "' AND '" + ToDate_.Value.ToString("yyyy/MM/dd") + "' and A.Transaction_code like 'Xs%' THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS Xs_ " +
		",SUM(CASE WHEN  cast(D.g_date as date) BETWEEN '"+FromDate_.Value.ToString("yyyy/MM/dd")+ "' AND '" + ToDate_.Value.ToString("yyyy/MM/dd") + "' and A.Transaction_code like 'Xi%' THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS Xi_ " + 
		",SUM(CASE WHEN  cast(D.g_date as date) BETWEEN '"+FromDate_.Value.ToString("yyyy/MM/dd")+ "' AND '" + ToDate_.Value.ToString("yyyy/MM/dd") + "' and A.Transaction_code = 'XtP' THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS Xtp_ " +
        ",SUM(CASE WHEN  cast(D.g_date as date) BETWEEN '" +FromDate_.Value.ToString("yyyy/MM/dd")+ "' AND '" + ToDate_.Value.ToString("yyyy/MM/dd") + "' and A.Transaction_code like'Xt%' and A.Transaction_code <> 'Xtp'  THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS Xt_ " +
        ",SUM(CASE WHEN  cast(D.g_date as date) BETWEEN '" +FromDate_.Value.ToString("yyyy/MM/dd")+ "' AND '" + ToDate_.Value.ToString("yyyy/MM/dd") + "' and A.Transaction_code like'Op%'  THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS Op_ " +
        ",SUM(CASE WHEN  cast(D.g_date as date) BETWEEN '"+ fd_ofYear.ToString("yyyy/MM/dd") + "' and '" + ToDate_.Value.ToString("yyyy/MM/dd")+ "' and a.Branch_code like '%' THEN D.QTY_ADD - D.QTY_TAKE else 0 END) AS E_balance " +
        "FROM    wh_inv_data as A   " +
        "INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code  " +
        "INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code  " +
        "INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO " +
        "AND A.Branch_code =D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear " +
        "inner join wh_main_master As S  on D.ITEM_NO=s.item_no  " +
        "WHERE d.ITEM_NO like '"+UC_Items.ID.Text+"%' and a.Branch_code like '"+UC_Branch.ID.Text+"%' " +
        " and  S.group_code like '" + Uc_Group1.ID.Text+"%' and a.Acc_no like '"+UC_Acc.ID.Text+"%' " +
        "group by   d.ITEM_NO, s.descr ,s.Descr_eng ) as x " +
        "where abs(x.Xp_)+abs(x.Xs_)+abs(x.Xi_)+abs(x.Xtp_)+abs(x.Xt_)+abs(x.Op_)>0   order by  x.ITEM_NO "));
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate_.Value.ToString("dd/MM/yyyy") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate_.Value.ToString("dd/MM/yyyy") + "'";
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;
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
            //UC_Branch.txtUser.Text = Program.userID.ToString();
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            getItemCard();

           
        }

      public  void getItemCard(){
            this.Cursor = Cursors.WaitCursor;
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            groupPanel1.Visible = false;
            RPT.CrystalReport5 rpt = new RPT.CrystalReport5();
            dt1 = (dal.getDataTabl_1(@"select D.ser_no,D.g_date,D.ITEM_NO,s.descr,D.QTY_ADD,D.QTY_TAKE
            ,D.Local_Price*(100-ISNULL(D.DISC_R3,0))/100 as Local_Price
            ,D.TRANSACTION_CODE,p.ACC_NO,p.PAYER_NAME,t.INV_NAME,A.branch_code
            ,C_Balance= SUM(QTY_ADD-QTY_TAKE) OVER (  ORDER BY  D.G_DATE,D.SER_NO,D.main_counter)
	       ,A.inv_no,A.inv_Date
           , ROW_NUMBER()OVER(  ORDER BY  D.G_DATE,D.SER_NO ,D.BRANCH_CODE) " +
            "from wh_inv_data as A " +
            "INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code " +
            "INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code " +
            "INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type " +
            "INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO " +
            "AND A.Branch_code =D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear " +
            "inner join wh_main_master As S  on D.ITEM_NO=s.item_no " +
            "inner join WH_INV_TYPE As T  on T.INV_CODE=A.Transaction_code " +
            "where D.ITEM_NO = '" + UC_Items.ID.Text + "' and CAST (D.G_DATE as date )between '" + FromDate_.Value.ToString("yyyy-MM-dd") +
            "' and '" + ToDate_.Value.ToString("yyyy-MM-dd") + "' and D.Branch_code like '" + UC_Branch.ID.Text +
            "%' and A.Acc_no like '" + UC_Acc.ID.Text + "%'  and A.Transaction_code like '" + UC_Transaction.ID.Text +
            "%' and S.group_code like '" + Uc_Group1.ID.Text +
            "%' and D.cyear= '"+ToDate_.Value.ToString("yy") + "' order by D.G_DATE,D.SER_NO "));
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate_.Value.ToString("yyyy/MM/dd") + "'";

            dt2 = (dal.getDataTabl_1(@"select SUM(CASE WHEN  D.ITEM_NO like '" + UC_Items.ID.Text + "%' and cast(D.G_DATE as date) <'" + FromDate_.Value.ToString("yyyy/MM/dd") + "' and D.cyear= '"+Properties.Settings.Default.C_year+"' THEN  QTY_ADD-QTY_TAKE else 0 END) AS 'B_balance' from wh_material_transaction As D"));
            ds.Tables.Add(dt1);
            ds.Tables.Add(dt2);

            ////ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;
        }


        private void buttonX2_Click(object sender, EventArgs e)
        {

            this.Cursor = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            RPT.count_report_byGroup rpt = new RPT.count_report_byGroup();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            dt1 = dal.getDataTabl("get_stock_count_byGroup_", FromDate_.Value.Date, ToDate_.Value.Date, UC_Items.ID.Text, UC_Branch.ID.Text, UC_Transaction.ID.Text, Uc_Group1.ID.Text, db1, ToDate_.Value.Date.ToString("yy"))
                ;
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.ID.Text + "'+' - '+'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Group_"].Text = "'" + Uc_Group1.ID.Text + "'+' - '+'" + Uc_Group1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Transaction_"].Text = "'" + UC_Transaction.Desc.Text + "'";
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            RPT.rpt_stock_count_byItem rpt = new RPT.rpt_stock_count_byItem();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();
            dt1 = dal.getDataTabl("get_stock_count_byItem_", FromDate_.Value.Date, ToDate_.Value.Date, UC_Items.ID.Text, UC_Branch.ID.Text, UC_Transaction.ID.Text, Uc_Group1.ID.Text, db1);
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate_.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.ID.Text + "'+' - '+'" + UC_Branch.Desc.Text + "'";
            //rpt.DataDefinition.FormulaFields["Group_"].Text = "'" + Uc_Group1.ID.Text + "'+' - '+'" + Uc_Group1.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Transaction_"].Text = "'" + UC_Transaction.Desc.Text + "'";
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;
        }
    }
}
