using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;

namespace Report_Pro.RPT
{
    public partial class f1 : DevExpress.XtraEditors.XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public f1()
        {
            InitializeComponent();
        }

        private void f1_Load(object sender, EventArgs e)
        {

        }

        private void barButtonItem2_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            string R, F, C, P, S, Z;
            if (chR.Checked == true) { R = "R"; } else { R = "X"; }
            if (chF.Checked == true) { F = "F"; } else { F = "X"; }
            if (chC.Checked == true) { C = "C"; } else { C = "X"; }
            if (chS.Checked == true) { S = "S"; } else { S = "X"; }
            if (chP.Checked == true) { P = "P"; } else { P = "X"; }
            if (chZ.Checked == true) { Z = "Z"; } else { Z = "X"; }
            Cursor.Current = Cursors.WaitCursor;
            double T1, T2;
            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }

           // RPT.f1 frm = new RPT.f1();
            RPT.XtraReport1 rpt = new RPT.XtraReport1();

            //RPT.rpt_inventory_Mstore_Branchs rpt = new RPT.rpt_inventory_Mstore_Branchs();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            //dt1 = dal.getDataTabl("get_inventory_", dTP2.Value.Date, Convert.ToString(category.SelectedValue), dal.db1);
            dt1 = dal.getDataTabl_1(@"SELECT A.item_no,A.descr,a.Descr_eng,A.group_code,G.Group_name,
            sum (case when D.branch_code like'A21%' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as B_balance, 
			sum( case when D.branch_code like'A21%' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as B_cost,
            sum(case when D.branch_code like'A21%' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as B_Weight_ ,
		    sum (case when D.branch_code='A1112' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as M_balance, 
			sum( case when D.branch_code='A1112' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as M_cost,
            sum(case when D.branch_code='A1112' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as M_Weight_ ,
            sum (case when D.branch_code='A1112' or D.branch_code like 'A21%' then D.QTY_ADD - D.QTY_TAKE  else 0 end)  as balance, 
			sum( case when D.branch_code='A1112' or D.branch_code like 'A21%' then  (D.QTY_ADD - D.QTY_TAKE) * a.local_cost else 0 end) as cost,
            sum(case when D.branch_code='A1112' or D.branch_code like 'A21%' then  (D.QTY_ADD - D.QTY_TAKE)*A.Weight else 0 end) as Weight_ 
			
            FROM wh_material_transaction As D 
            inner join wh_BRANCHES as B on B.branch_code = D.Branch_code
            inner join wh_main_master As A on A.item_no = D.ITEM_NO 
            inner join wh_Groups As G on g.group_code = a.group_code 

             where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' " +
            "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "') " +
            "and A.group_code like '" + Group.ID.Text +
            "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name order by A.item_no");

            ds.Tables.Add(dt1);

            //ds.WriteXmlSchema("schema_rpt.xml");
            // rpt.SetDataSource(ds);
            rpt.DataSource = ds;
            // rpt.ShowPreview();
            //frm.
            
            dv1.DocumentSource=rpt;
          
            ////frm.ShowDialog();
            //////crystalReportViewer1.ReportSource = rpt;
            Cursor.Current = Cursors.Default;
            groupPanel1.Visible = false;


        }
    }
}