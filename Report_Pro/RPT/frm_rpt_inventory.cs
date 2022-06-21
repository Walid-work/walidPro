using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Text;
using System.Windows.Forms;
using DevExpress;
using DevExpress.XtraReports.UI;

namespace Report_Pro.RPT
{
    public partial class frm_rpt_inventory :Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string R, F, C, P, S, Z, X;
        double T1, T2;
        public frm_rpt_inventory()
        {
            InitializeComponent();
            dTP2.Value = DateTime.Today;

            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;

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
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }
        }


        private DataTable dt_report()
        {
            choises();

            string rpt_str = @"SELECT A.item_no,A.descr,a.Descr_eng,A.group_code,G.Group_name,a.Category,A.Weight,a.UnitDepth,a.local_cost,t2.COST_PRICE,
                a.Dim_category, round(sum(D.QTY_ADD - D.QTY_TAKE), 2) as balance, sum(D.QTY_ADD - D.QTY_TAKE) * a.local_cost as cost
                FROM wh_material_transaction As D
                inner join wh_main_master As A on A.item_no = D.ITEM_NO
                inner join wh_Groups As G on g.group_code = a.group_code
                inner join(select ITEM_NO, COST_PRICE from(select*, ROW_NUMBER() OVER(PARTITION BY item_no ORDER BY G_DATE DESC) AS DuplicateCount
                FROM wh_MATERIAL_TRANSACTION  where cast(G_DATE as date) <= '" +
                dTP2.Value.ToString("yyyy/MM/dd") + "') as t1 where DuplicateCount = 1) as t2 on t2.ITEM_NO = a.item_no " +
                "where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' " +
                "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "')  and   D.branch_code like " +
                " (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "' else  '" + Branch.ID.Text + "%' end) and A.group_code like '" + Group.ID.Text +
                "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "' and D.TRANSACTION_CODE like '"+Uc_Transaction.ID.Text+"%'  " +
                "group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name, a.Category, A.Weight, a.UnitDepth, a.local_cost, a.Dim_category, t2.COST_PRICE order by A.item_no";

            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(rpt_str);
            return dt1;
        }
               
        private void btnReport_Click(object sender, EventArgs e)
        {
            choises();
             
             DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT  d.Branch_code,B.branch_name,B.WH_E_NAME,A.item_no,A.descr,a.Descr_eng,A.group_code,G.Group_name,a.Category,A.Weight,a.UnitDepth,a.local_cost,t2.COST_PRICE,
            a.Dim_category, round(sum(D.QTY_ADD - D.QTY_TAKE), 2) as balance, sum(D.QTY_ADD - D.QTY_TAKE) * a.local_cost as cost
            FROM wh_material_transaction As D 
            inner join wh_BRANCHES as B on B.branch_code = D.Branch_code
            inner join wh_main_master As A on A.item_no = D.ITEM_NO 
            inner join wh_Groups As G on g.group_code = a.group_code 
            inner join(select ITEM_NO, COST_PRICE from(select *, ROW_NUMBER() OVER(PARTITION BY item_no ORDER BY G_DATE DESC) AS DuplicateCount 
            FROM wh_MATERIAL_TRANSACTION  where cast(G_DATE as date) <= '" + 
            dTP2.Value.ToString("yyyy/MM/dd") + "') as t1 where DuplicateCount = 1) as t2 on t2.ITEM_NO = a.item_no " +
            "where cast(D.G_date as date) <= '"+ dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '"+ dTP2.Value.ToString("yy") + "' " +
            "and A.Category in('"+R+"','"+ F + "','" + C + "','" + P +"','" + S +"','" + Z+"','"+X+"')  and   D.branch_code like " +
            " (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "%' else  '" + Branch.ID.Text + "%' end) and A.group_code like '"+Group.ID.Text+
            "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "' and D.Transaction_Code like '"+Uc_Transaction.ID.Text+"%'   " +
            "group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name, a.Category, A.Weight, a.UnitDepth, a.local_cost, a.Dim_category, t2.COST_PRICE,d.Branch_code,B.branch_name,B.WH_E_NAME order by A.item_no");

            DataSet1 ds = new DataSet1();
            ds.Tables.Add(dt1);
            ////ds.WriteXmlSchema("schema_rpt.xml");
            Reports.rpt_BalanceByBranch rpt = new Reports.rpt_BalanceByBranch();
            rpt.DataSource = ds;

            if (Properties.Settings.Default.lungh == "0")
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
                rpt.pram1.Value = 0;
            }
            else
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
                rpt.pram1.Value = 1;
            }

            rpt.ShowPreview();
            rpt.lbl_Branch.Text = Branch.Desc.Text;
            rpt.lbl_Group.Text = Group.Desc.Text;
            rpt.lbl_Item.Text = Item.Desc.Text;
            rpt.lbl_Date.Text = dTP2.Value.ToShortDateString();
            rpt.lbl_Type.Text = cmb_DimCategory.Text;
            rpt.lbl_From_Thick.Text = thick_1.Value.ToString();
            rpt.lbl_To_Thick.Text = thick_2.Value.ToString();
            rpt.ch_Raw.Checked = chR.Checked;
            rpt.ch_Commercial.Checked = chC.Checked;
            rpt.ch_Finshed.Checked = chF.Checked;
            rpt.ch_WIP.Checked = chS.Checked;
            rpt.ch_Others.Checked = chZ.Checked;
            rpt.ch_S_Parts.Checked = chP.Checked;
            rpt.ch_Scrap.Checked = chX.Checked;
            Cursor.Current = Cursors.Default;

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            choises();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT A.group_code,G.Group_name,G.Group_E_NAME,C.Category_code as Category,C.Category_name,C.Category_name_E,
            sum(D.QTY_ADD - D.QTY_TAKE) as balance,sum((D.QTY_ADD - D.QTY_TAKE) * A.Weight) as Weight_,
            sum((D.QTY_ADD - D.QTY_TAKE) * a.local_cost) as cost
            FROM wh_material_transaction As D
            inner join wh_main_master As A on A.item_no = D.ITEM_NO
            inner join wh_Groups As G on g.group_code = a.group_code
            inner join wh_Category As C on C.Category_code = A.Category 

            where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' " +
             "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "')  and   D.branch_code like " +
             " (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "%' else  '" + Branch.ID.Text + "%' end) and A.group_code like '" + Group.ID.Text +
             "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  " +

             "group by A.group_code,G.Group_name,G.Group_E_NAME,C.Category_code,C.Category_name,C.Category_name_E");

         
            
            
            DataSet ds = new DataSet1();
            ds.Tables.Add(dt1);
            ////ds.WriteXmlSchema("schema_rpt.xml");

            Report.rpt_TotalStockByCategory rpt = new Report.rpt_TotalStockByCategory();
            rpt.DataSource = ds;

            if (Properties.Settings.Default.lungh == "0")
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
                rpt.pram1.Value = 0;
            }
            else
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
                rpt.pram1.Value = 1;
            }

            rpt.ShowPreview();
            rpt.lbl_Branch.Text = Branch.Desc.Text;
            rpt.lbl_Group.Text = Group.Desc.Text;
            rpt.lbl_Item.Text = Item.Desc.Text;
            rpt.lbl_Date.Text = dTP2.Value.ToShortDateString();
            rpt.lbl_Type.Text = cmb_DimCategory.Text;
            rpt.lbl_From_Thick.Text = thick_1.Value.ToString();
            rpt.lbl_To_Thick.Text = thick_2.Value.ToString();
            rpt.ch_Raw.Checked = chR.Checked;
            rpt.ch_Commercial.Checked = chC.Checked;
            rpt.ch_Finshed.Checked = chF.Checked;
            rpt.ch_WIP.Checked = chS.Checked;
            rpt.ch_Others.Checked = chZ.Checked;
            rpt.ch_S_Parts.Checked = chP.Checked;
            rpt.ch_Scrap.Checked = chX.Checked;
            //rptFeesReport.DataDefinition.FormulaFields["Acc_Group"].Text = "'" + this.Acc_Group.Desc.Text + "'";

            Cursor.Current = Cursors.Default;
            //groupPanel1.Visible = false;






        }

        private void frm_rpt_inventory_Load(object sender, EventArgs e)
        {
            dTP1.Value = new DateTime(DateTime.Now.Year, 1, 1);
            dTP2.Value = DateTime.Today;
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            choises();

            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT d.Branch_code,B.branch_name,B.WH_E_NAME,round(sum(D.QTY_ADD - D.QTY_TAKE), 2) as balance,sum((D.QTY_ADD - D.QTY_TAKE) * A.Weight) as Weight_, sum((D.QTY_ADD - D.QTY_TAKE)*a.local_cost) as cost
            FROM wh_material_transaction As D 
            inner join wh_BRANCHES as B on B.branch_code = D.Branch_code
            inner join wh_main_master As A on A.item_no = D.ITEM_NO 
            inner join wh_Groups As G on g.group_code = a.group_code 
            inner join(select ITEM_NO, COST_PRICE from(select *, ROW_NUMBER() OVER(PARTITION BY item_no ORDER BY G_DATE DESC) AS DuplicateCount 
            FROM wh_MATERIAL_TRANSACTION  where cast(G_DATE as date) <= '" +
            dTP2.Value.ToString("yyyy/MM/dd") + "') as t1 where DuplicateCount = 1) as t2 on t2.ITEM_NO = a.item_no " +
            "where cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' " +
            "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "')  and   D.branch_code like " +
            " (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "%' else  '" + Branch.ID.Text + "%' end) and A.group_code like '" + Group.ID.Text +
            "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  " +
            "group by d.Branch_code,B.branch_name,B.WH_E_NAME order by d.Branch_code");

            DataSet1 ds = new DataSet1();
            ds.Tables.Add(dt1);
           // //ds.WriteXmlSchema("schema_rpt.xml");
            Reports.rpt_TotalInventoryByBranch rpt = new Reports.rpt_TotalInventoryByBranch();
            rpt.DataSource = ds;

            if (Properties.Settings.Default.lungh == "0")
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
                rpt.pram1.Value = 0;
            }
            else
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
                rpt.pram1.Value = 1;
            }

            rpt.ShowPreview();
            rpt.lbl_Branch.Text = Branch.Desc.Text;
            rpt.lbl_Group.Text = Group.Desc.Text;
            rpt.lbl_Item.Text = Item.Desc.Text;
            rpt.lbl_Date.Text = dTP2.Value.ToShortDateString();
            rpt.lbl_Type.Text = cmb_DimCategory.Text;
            rpt.lbl_From_Thick.Text = thick_1.Value.ToString();
            rpt.lbl_To_Thick.Text = thick_2.Value.ToString();
            rpt.ch_Raw.Checked = chR.Checked;
            rpt.ch_Commercial.Checked = chC.Checked;
            rpt.ch_Finshed.Checked = chF.Checked;
            rpt.ch_WIP.Checked = chS.Checked;
            rpt.ch_Others.Checked = chZ.Checked;
            rpt.ch_S_Parts.Checked = chP.Checked;
            rpt.ch_Scrap.Checked = chX.Checked;
            Cursor.Current = Cursors.Default;

        }

        private void cmb_DimCategory_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void labelX9_Click(object sender, EventArgs e)
        {

        }

        private void btn_stockGroupByBranch_Click(object sender, EventArgs e)
        {

            choises();



            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT d.Branch_code,B.branch_name,B.WH_E_NAME
        ,sum (case when cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy")+"' then D.QTY_ADD-D.QTY_TAKE  else 0 end)  as Balance_ " +
        ",sum(case when cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.cyear = '" + dTP2.Value.ToString("yy")+"' then (D.QTY_ADD - D.QTY_TAKE)*A.Weight  else 0 end) as Balance_Weight " +


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

        "group by  d.Branch_code,B.branch_name,B.WH_E_NAME order by d.Branch_code");

            ds.Tables.Add(dt1);
            //Reports.rpt_ItemBalanceByBranches rpt = new Reports.rpt_ItemBalanceByBranches();
            RPT.rpt_inventory_Group_byBranch rpt = new rpt_inventory_Group_byBranch();
            //rpt.DataSource = ds;
            ////ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            //rpt.ShowPreview();
            //if (Properties.Settings.Default.lungh == "0")
            //{
            //    rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
            //    rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
            //    rpt.pram1.Value = 0;
            //}
            //else
            //{
            //    rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            //    rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
            //    rpt.pram1.Value = 1;
            //}

            //rpt.lbl_Date.Text = dTP1.Value.ToShortDateString();
            //rpt.lbl_ToDate.Text = dTP2.Value.ToShortDateString();
            //rpt.lbl_ItemCode.Text = Item.ID.Text;
            //rpt.lbl_ItemDescription.Text = Item.Desc.Text;
            rpt.SetParameterValue("noOfDays", System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(dTP1.Value, dTP2.Value));
            Form1 frm = new Form1();
            frm.crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["fromDate"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["toDate"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["fromGroup"].Text = "'" + Group.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["toGroup"].Text = "'" + Group1.Desc.Text + "'";




            frm.ShowDialog();
            Cursor.Current = Cursors.Default;

        }

        private void btn_stockByBranch_Click(object sender, EventArgs e)
        {
            choises();


           // RPT.rpt_inventory_Item_byBranch rpt = new RPT.rpt_inventory_Item_byBranch();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            //dt1 = dal.getDataTabl("get_inventory_", dTP2.Value.Date, Convert.ToString(category.SelectedValue), dal.db1);
            dt1 = dal.getDataTabl_1(@"	SELECT d.Branch_code,B.branch_name,B.WH_E_NAME,A.Weight,A.local_cost,A.Unit
		,sum (case when cast(D.G_date as date) <= '" + dTP2.Value.ToString("yyyy/MM/dd")+ "' and D.cyear = '" + dTP2.Value.ToString("yy") + "' then D.QTY_ADD-D.QTY_TAKE  else 0 end)  as Balance_ "+
		",sum (case when D.TRANSACTION_CODE  like'Xp%' and  cast(D.G_date as date) between '"+dTP1.Value.ToString("yyyy/MM/dd")+"' and '"+dTP2.Value.ToString("yyyy/MM/dd")+"' then D.QTY_ADD-D.QTY_TAKE  else 0 end)  as Purchases_ "+
        ",sum (case when D.TRANSACTION_CODE  like'XS%' and  cast(D.G_date as date) between '"+dTP1.Value.ToString("yyyy/MM/dd")+"' and '"+dTP2.Value.ToString("yyyy/MM/dd")+"' then D.QTY_TAKE-D.QTY_ADD  else 0 end)  as Sales_ "+
        "FROM wh_material_transaction As D inner join wh_BRANCHES as B on B.branch_code = D.Branch_code " +
		"inner join wh_main_master As A on A.item_no = D.ITEM_NO inner join wh_Groups As G on g.group_code = a.group_code "+
		"and  A.item_no = '"+Item.ID.Text+ "' and  D.branch_code like (CASE WHEN '" + Branch.ID.Text + "' !=''  then  '" + Branch.ID.Text + "%' else  '" + Branch.ID.Text + "%' end) " +
        "group by d.Branch_code,B.branch_name,B.WH_E_NAME,A.Weight,A.local_cost,A.Unit order by d.Branch_code");

    ds.Tables.Add(dt1);

            Reports.rpt_ItemBalanceByBranches rpt = new Reports.rpt_ItemBalanceByBranches();
            rpt.DataSource = ds;
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.ShowPreview();
            if (Properties.Settings.Default.lungh == "0")
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
                rpt.pram1.Value = 0;
            }
            else
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
                rpt.pram1.Value = 1;
            }
            
            rpt.lbl_Date.Text = dTP1.Value.ToShortDateString();
            rpt.lbl_ToDate.Text = dTP2.Value.ToShortDateString();
            rpt.lbl_ItemCode.Text = Item.ID.Text;
            rpt.lbl_ItemDescription.Text = Item.Desc.Text;
            rpt.noOfDays.Value = System.Data.Linq.SqlClient.SqlMethods.DateDiffDay(dTP1.Value, dTP2.Value);

            Cursor.Current = Cursors.Default;

        }

      




        private void buttonX1_Click(object sender, EventArgs e)
        {
            Reports.rpt_TotalInventory rpt = new Reports.rpt_TotalInventory();
            DataSet1 ds = new DataSet1();
            ds.Tables.Add(dt_report());
            rpt.DataSource = ds;
            rpt.ShowPreview();

            if (Properties.Settings.Default.lungh == "0")
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
                rpt.pram1.Value = 0;
            }
            else
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
                rpt.pram1.Value = 1;
            }

            rpt.lbl_Branch.Text = Branch.Desc.Text;
            rpt.lbl_Group.Text = Group.Desc.Text;
            rpt.lbl_Item.Text = Item.Desc.Text;
            rpt.lbl_Date.Text = dTP2.Value.ToShortDateString();
            rpt.lbl_Type.Text = cmb_DimCategory.Text;
            rpt.lbl_From_Thick.Text = thick_1.Value.ToString();
            rpt.lbl_To_Thick.Text = thick_2.Value.ToString();
            rpt.ch_Raw.Checked = chR.Checked;
            rpt.ch_Commercial.Checked = chC.Checked;
            rpt.ch_Finshed.Checked = chF.Checked;
            rpt.ch_WIP.Checked = chS.Checked;
            rpt.ch_Others.Checked = chZ.Checked;
            rpt.ch_S_Parts.Checked = chP.Checked;
            rpt.ch_Scrap.Checked = chX.Checked;

            Cursor.Current = Cursors.Default;

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            choises();

            //RPT.rpt_inventory_Mstore_Branchs rpt = new RPT.rpt_inventory_Mstore_Branchs();
            Report.XtraReport1 rpt = new Report.XtraReport1();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

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
            "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "') " +
            "and A.group_code like '" + Group.ID.Text +
            "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  group by A.item_no, A.descr, a.Descr_eng, A.group_code, G.Group_name order by A.item_no");

            ds.Tables.Add(dt1);
            ////ds.WriteXmlSchema("schema_rpt.xml");
            // rpt.SetDataSource(ds);
            //crystalReportViewer1.ReportSource = rpt;
            //rpt.DataSource = ds;
            //rpt.ShowPreview();


            Report.XtraReport1.Print(ds);
            Cursor.Current = Cursors.Default;
        

        }

        private void Item_Click(object sender, EventArgs e)
        {
            try
            {
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                Item.ID.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
               
            }
            catch { }
        }

        private void buttonX2_Click_1(object sender, EventArgs e)
        {
           


        }


        private void buttonX3_Click(object sender, EventArgs e)
        {
            choises();

            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"SELECT A.group_code,G.Group_name,G.Group_E_NAME,
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
            "and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','"+X+"') " +
            "and A.group_code like '" + Group.ID.Text +
            "%' and  A.item_no like '" + Item.ID.Text + "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' and '" + T2 + "'  group by  A.group_code, G.Group_name,G.Group_E_NAME order by A.group_code");

            DataSet1 ds = new DataSet1();
            ds.Tables.Add(dt1);

            Reports.rpt_Inventory_M_Br rpt = new Reports.rpt_Inventory_M_Br();

            rpt.DataSource = ds;
            if (Properties.Settings.Default.lungh == "0")
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
                rpt.pram1.Value = 0;
            }
            else
            {
            rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
            rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
                rpt.pram1.Value = 1;
            }
            rpt.ShowPreview();
            rpt.lbl_Branch.Text = Branch.Desc.Text;
            rpt.lbl_Group.Text = Group.Desc.Text;
            rpt.lbl_Item.Text = Item.Desc.Text;
            rpt.lbl_Date.Text = dTP2.Value.ToShortDateString();
            rpt.lbl_Type.Text = cmb_DimCategory.Text;
            rpt.lbl_From_Thick.Text = thick_1.Value.ToString();
            rpt.lbl_To_Thick.Text = thick_2.Value.ToString();
            rpt.ch_Raw.Checked = chR.Checked;
            rpt.ch_Commercial.Checked = chC.Checked;
            rpt.ch_Finshed.Checked = chF.Checked;
            rpt.ch_WIP.Checked = chS.Checked;
            rpt.ch_Others.Checked = chZ.Checked;
            rpt.ch_S_Parts.Checked = chP.Checked;
            rpt.ch_Scrap.Checked = chX.Checked;

            Cursor.Current = Cursors.Default;
           // //ds.WriteXmlSchema("schema_rpt.xml");

        }


        private void buttonX4_Click(object sender, EventArgs e)
        {
           
            DataSet ds = new DataSet1();
            ds.Tables.Add(dt_report());
            ////ds.WriteXmlSchema("schema_rpt.xml");

            Reports.rpt_InventoryList rpt = new Reports.rpt_InventoryList();
            rpt.DataSource=ds;

            if (Properties.Settings.Default.lungh == "0")
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.Yes;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.Yes;
                rpt.pram1.Value = 0;
            }
            else
            {
                rpt.RightToLeft = DevExpress.XtraReports.UI.RightToLeft.No;
                rpt.RightToLeftLayout = DevExpress.XtraReports.UI.RightToLeftLayout.No;
                rpt.pram1.Value = 1;
            }
            rpt.Watermark.Text = "Inventory Count " + dTP2.Value.Year.ToString();
            rpt.Watermark.ForeColor = Color.Silver;
            rpt.Watermark.TextTransparency = 120;
            rpt.ShowPreview();
            rpt.lbl_Branch.Text = Branch.Desc.Text;
            rpt.lbl_Group.Text = Group.Desc.Text;
            rpt.lbl_Item.Text = Item.Desc.Text;
            rpt.lbl_Date.Text = dTP2.Value.ToShortDateString();
            rpt.lbl_Type.Text = cmb_DimCategory.Text;
            rpt.lbl_From_Thick.Text = thick_1.Value.ToString();
            rpt.lbl_To_Thick.Text = thick_2.Value.ToString();
            rpt.ch_Raw.Checked = chR.Checked;
            rpt.ch_Commercial.Checked = chC.Checked;
            rpt.ch_Finshed.Checked = chF.Checked;
            rpt.ch_WIP.Checked = chS.Checked;
            rpt.ch_Others.Checked = chZ.Checked;
            rpt.ch_S_Parts.Checked = chP.Checked;
            rpt.ch_Scrap.Checked = chX.Checked;
            //rptFeesReport.DataDefinition.FormulaFields["Acc_Group"].Text = "'" + this.Acc_Group.Desc.Text + "'";

            Cursor.Current = Cursors.Default;
            //groupPanel1.Visible = false;

        }
    }
}   
