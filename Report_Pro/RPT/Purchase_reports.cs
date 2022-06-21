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
    public partial class Purchase_reports : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string db1 = Properties.Settings.Default.Database_1;
        public Purchase_reports()
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
            this.Cursor = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            if (rdo_byItem.Checked)
            {
                dt1 = dal.getDataTabl_1(@"select * from ( SELECT A.Ser_no,A.ITEM_NO,A.QTY_TAKE-A.QTY_ADD as Qty,A.Local_Price,a.G_DATE
                ,B.Acc_no,p.PAYER_NAME,Forign_price,descr,a.Branch_code,x.branch_name,M.weight,a.TRANSACTION_CODE,IY.INV_NAME
                ,ROW_NUMBER() OVER(PARTITION BY A.ITEM_NO ORDER BY a.G_DATE desc) AS DuplicateCount
                FROM    wh_material_transaction as A
		        inner join wh_inv_data As B on a.Branch_code=b.Branch_code and a.SER_NO=b.Ser_no and a.TRANSACTION_CODE = b.Transaction_code and A.cyear = B.Cyear
		        Inner join payer2 as P on p.ACC_NO=b.Acc_no and p.BRANCH_code = b.Acc_Branch_code
		        inner join wh_main_master As M on M.item_no=A.ITEM_NO
		        inner join wh_BRANCHES As X on a.Branch_code=X.Branch_code
                inner join WH_INV_TYPE IY on IY.INV_CODE=a.TRANSACTION_CODE
                where CAST(a.G_date as date) between '" + FromDate_.Value.ToString("yyyy/MM/dd") + "'  and '" + ToDate_.Value.ToString("yyyy/MM/dd") +
                "' and A.item_no like '" + UC_Items.ID.Text + "%' " +
                "and M.group_code like '" + Uc_Group.ID.Text + "%' " +
                "and a.TRANSACTION_CODE like 'xp%' " +
                "and a.TRANSACTION_CODE <> 'xpr' " +
                "and a.Branch_code like '" + UC_Branch.ID.Text + "%' " +
                "and B.Acc_no like '" + UC_Acc.ID.Text + "%' ) as X  where X.DuplicateCount='1' " +
                "order by X.ITEM_NO,X.Acc_no ");
            }
            else
            {
                dt1 = dal.getDataTabl_1(@"select * from ( SELECT A.Ser_no,A.ITEM_NO,A.QTY_TAKE-A.QTY_ADD as Qty,A.Local_Price,a.G_DATE
                ,B.Acc_no,p.PAYER_NAME,Forign_price,descr,a.Branch_code,x.branch_name,M.weight,a.TRANSACTION_CODE,IY.INV_NAME
                ,ROW_NUMBER() OVER(PARTITION BY  A.ITEM_NO,B.Acc_no ORDER BY a.G_DATE desc) AS DuplicateCount
                FROM    wh_material_transaction as A
		        inner join wh_inv_data As B on a.Branch_code=b.Branch_code and a.SER_NO=b.Ser_no and a.TRANSACTION_CODE = b.Transaction_code and A.cyear = B.Cyear
		        Inner join payer2 as P on p.ACC_NO=b.Acc_no and p.BRANCH_code = b.Acc_Branch_code
		        inner join wh_main_master As M on M.item_no=A.ITEM_NO
		        inner join wh_BRANCHES As X on a.Branch_code=X.Branch_code
                inner join WH_INV_TYPE IY on IY.INV_CODE=a.TRANSACTION_CODE
                where CAST(a.G_date as date) between '" + FromDate_.Value.ToString("yyyy/MM/dd") + "'  and '" + ToDate_.Value.ToString("yyyy/MM/dd") +
                "' and A.item_no like '" + UC_Items.ID.Text + "%' " +
                "and M.group_code like '" + Uc_Group.ID.Text + "%' " +
                "and a.TRANSACTION_CODE like 'xp%' " +
                "and a.TRANSACTION_CODE <> 'xpr' " +
                "and a.Branch_code like '" + UC_Branch.ID.Text + "%' " +
                "and B.Acc_no like '" + UC_Acc.ID.Text + "%' ) as X  where X.DuplicateCount='1' " +
                "order by X.ITEM_NO,X.Acc_no ");
            }

           

            RPT.Get_Last_Purch rpt = new RPT.Get_Last_Purch();
           
            //dt1 = (dal.getDataTabl("Get_last_purch_", FromDate_.Value.Date, ToDate_.Value.Date, "", UC_Branch.ID.Text, UC_Acc.ID.Text, "xp", db1));
          
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

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            if (UC_Items.ID.Text == "") {
                MessageBox.Show("تاكد من رقم الصنف", "تنبيه", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            this.Cursor = Cursors.WaitCursor;
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();
            groupPanel1.Visible = false;
            RPT.Get_Last_Purch_Item rpt = new RPT.Get_Last_Purch_Item();
            dt1 = dal.getDataTabl_1(@"select * from ( SELECT A.Ser_no,A.ITEM_NO,A.QTY_TAKE-A.QTY_ADD as Qty,A.Local_Price,a.G_DATE
                ,B.Acc_no,p.PAYER_NAME,Forign_price,descr,a.Branch_code,x.branch_name,M.weight,a.TRANSACTION_CODE,IY.INV_NAME
                ,ROW_NUMBER() OVER(PARTITION BY A.ITEM_NO,B.Acc_no ORDER BY a.G_DATE desc) AS DuplicateCount
                FROM    wh_material_transaction as A
		        inner join wh_inv_data As B on a.Branch_code=b.Branch_code and a.SER_NO=b.Ser_no and a.TRANSACTION_CODE = b.Transaction_code
		        Inner join payer2 as P on p.ACC_NO=b.Acc_no and p.BRANCH_code = b.Acc_Branch_code
		        inner join wh_main_master As M on M.item_no=A.ITEM_NO
		        inner join wh_BRANCHES As X on a.Branch_code=X.Branch_code
                inner join WH_INV_TYPE IY on IY.INV_CODE=a.TRANSACTION_CODE
                where CAST(a.G_date as date) between '" + FromDate_.Value.ToString("yyyy/MM/dd") + "'  and '" + ToDate_.Value.ToString("yyyy/MM/dd") +
                "' and A.item_no like '"+UC_Items.ID.Text+"%' and M.group_code like '" + Uc_Group.ID.Text + "%' and a.TRANSACTION_CODE like 'xp%' and a.TRANSACTION_CODE <> 'xpr'  and a.Branch_code like '" + UC_Branch.ID.Text + "%' and B.Acc_no like '" + UC_Acc.ID.Text + "%' ) as X  where X.DuplicateCount='1' order by X.ITEM_NO,X.Acc_no ");

            //rpt.SetDataSource(dal.getDataTabl("Get_last_purch_", FromDate_.Value.Date, ToDate_.Value.Date, UC_Items.ID.Text, UC_Branch.ID.Text, UC_Acc.ID.Text, "xp", db1));
            //crystalReportViewer1.ReportSource = rpt;
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

            this.Cursor = Cursors.Default;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            this.Cursor = Cursors.WaitCursor;
            groupPanel1.Visible = false;
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"select * from ( SELECT A.Ser_no,A.ITEM_NO,A.QTY_TAKE-A.QTY_ADD as Qty,A.Local_Price,a.G_DATE
                ,B.Acc_no,p.PAYER_NAME,Forign_price,descr,a.Branch_code,x.branch_name,M.weight,a.TRANSACTION_CODE,IY.INV_NAME
                ,ROW_NUMBER() OVER(PARTITION BY A.ITEM_NO ORDER BY a.G_DATE desc) AS DuplicateCount
                FROM    wh_material_transaction as A
		        inner join wh_inv_data As B on a.Branch_code=b.Branch_code and a.SER_NO=b.Ser_no and a.TRANSACTION_CODE = b.Transaction_code
		        Inner join payer2 as P on p.ACC_NO=b.Acc_no and p.BRANCH_code = b.Acc_Branch_code
		        inner join wh_main_master As M on M.item_no=A.ITEM_NO
		        inner join wh_BRANCHES As X on a.Branch_code=X.Branch_code
                inner join WH_INV_TYPE IY on IY.INV_CODE=a.TRANSACTION_CODE
                where CAST(a.G_date as date) between '" + FromDate_.Value.ToString("yyyy/MM/dd") + "'  and '" + ToDate_.Value.ToString("yyyy/MM/dd") +
              "' and A.item_no like '" + UC_Items.ID.Text + "%' " +
              "and M.group_code like '" + Uc_Group.ID.Text + "%' " +
              "and a.TRANSACTION_CODE like 'xs%' " +
              "and a.TRANSACTION_CODE <> 'xsr' " +
              "and a.TRANSACTION_CODE <> 'xst' " +

              "and a.Branch_code like '" + UC_Branch.ID.Text + "%' " +
              "and B.Acc_no like '" + UC_Acc.ID.Text + "%' ) as X  where X.DuplicateCount='1' " +
              "order by X.ITEM_NO,X.Acc_no ");

            RPT.Get_Last_Purch rpt = new RPT.Get_Last_Purch();

            //dt1 = (dal.getDataTabl("Get_last_purch_", FromDate_.Value.Date, ToDate_.Value.Date, "", UC_Branch.ID.Text, UC_Acc.ID.Text, "xp", db1));

            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            this.Cursor = Cursors.Default;

        }
    }
}
