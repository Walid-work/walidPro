using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Reflection;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_rpt_Productin : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        string R, F, C, P, S, Z, X;
        string SC = "1";
        string str_t = "1";
        string car_studes = "";
        double T1, T2;
        string sp;

        string pay_code = "";

        public frm_rpt_Productin()
        {
            InitializeComponent();
           

            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM " + Properties.Settings.Default.Database_1 + ".dbo.Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;

        }
        



        private void button11_Click(object sender, EventArgs e)
        {
         

        }

        private void button12_Click(object sender, EventArgs e)
        {

           
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

   
     
   
        private void button6_Click_1(object sender, EventArgs e)
        {
          }

        private void button7_Click_1(object sender, EventArgs e)
        {
           
        }

        private void button8_Click_1(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {

            

        }

        private void frm_rpt_Productin_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //string R, F, C, P, S, Z;
                //if (chR.Checked == true) { R = "R"; } else { R = "X"; }
                //if (chF.Checked == true) { F = "F"; } else { F = "X"; }
                //if (chC.Checked == true) { C = "C"; } else { C = "X"; }
                //if (chS.Checked == true) { S = "S"; } else { S = "X"; }
                //if (chP.Checked == true) { P = "P"; } else { P = "X"; }
                //if (chZ.Checked == true) { Z = "Z"; } else { Z = "X"; }

                groupBox1.Visible = false;
                //double T1, T2;
                //if (thick_1.Text == "")
                //{ T1 = 0; }
                //else { T1 = Convert.ToDouble(thick_1.Text); }
                //if (thick_2.Text == "" || thick_2.Value == 0)
                //{ T2 = 10000; }
                //else { T2 = Convert.ToDouble(thick_2.Text); }
                choises();

                RPT.RM_to_production_items rpt = new RPT.RM_to_production_items();


                DataTable dt_rpt = (dal.getDataTabl_1(@"SELECT D.ITEM_NO,A.descr
        ,ROUND(sum((D.[QTY_TAKE])*A.Weight),0 )as Weight_ ,ROUND(sum((D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0) as value_
        ,ROUND(ROUND(sum((D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.[QTY_TAKE])*A.Weight),0 ),0),1),3)*1000 AS Average_
        FROM	wh_material_transaction As D
        inner join wh_main_master As A on A.item_no=D.ITEM_NO
        inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
        inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
        C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear	  
        inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
  
        where	D.TRANSACTION_CODE = 'xtp' and cast(D.G_date as date) between '"
        + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' and A.Dim_category like '%" + Convert.ToString(cmb_DimCategory.SelectedValue) +
        "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' AND '" + T2 + "' and  A.group_code like '" + Uc_Group.ID.Text + "%' and c.Branch_code like '" + UC_Branch.ID.Text +
        "%' and  A.Category in ('" + R + "', '" + F + "', '" + C + "', '" + P + "', '" + S + "', '" + Z + "','" + X + "')  group by   D.ITEM_NO,A.descr "));

                DataSet ds = new DataSet();
                ds.Tables.Add(dt_rpt);
                //ds.WriteXmlSchema("schema1.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;


                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المنصرف للانتاج'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                choises();
                RPT.sales_by_group rpt = new RPT.sales_by_group();


                rpt.SetDataSource(dal.getDataTabl_1(@"SELECT v.G_ID As Group_ID,G.Group_name as Group_name
                ,V.xe_ ,ROUND(sum((D.[QTY_TAKE])*A.Weight),0 )as Weight_ ,ROUND(sum((D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0) as value_
                ,ROUND(ROUND(sum((D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.[QTY_TAKE])*A.Weight),0 ),0),1),3)*1000 AS Average_
                FROM	wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear	  
                inner join (SELECT CASE Category WHEN 'r' THEN LEFT(group_code, 4) WHEN 'F' THEN LEFT(group_code, 2) WHEN 'c' THEN LEFT(group_code, 2) ELSE LEFT(group_code, 2) END AS G_Id, item_no, CASE WHEN LEFT(group_code, 2) IN ('40', 
                '41', '42', '43', '44', '45', '46', '47', '48', '49') THEN '2' WHEN LEFT(group_code, 2) IN ('50') THEN '3' ELSE '1' END AS xe_
                FROM wh_main_master)  As V on V.item_no=a.item_no
                left join wh_Groups As G on  v.G_ID=G.group_code
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
  
                where	D.TRANSACTION_CODE = 'xtp' and cast(D.G_date as date) between '"
                + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "' and A.Dim_category like '%" + Convert.ToString(cmb_DimCategory.SelectedValue) +
                "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' AND '" + T2 + "' and A.group_code like '" + Uc_Group.ID.Text + "%' and c.Branch_code like '" + UC_Branch.ID.Text +
                "%' and  A.Category in ('" + R + "', '" + F + "', '" + C + "', '" + P + "', '" + S + "', '" + Z + "','" + X + "')  group by  v.G_ID,G.Group_name,v.xe_"));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المنصرف للانتاج'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnMonthelyReport_Click(object sender, EventArgs e)
        {
            choises();

            Cursor.Current = Cursors.WaitCursor;
            //try
            //{
                groupBox1.Visible = false;
                
                RPT.rpt_MonthelyProduction rpt = new RPT.rpt_MonthelyProduction();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = dal.getDataTabl_1(@"SELECT FORMAT(C.g_date, 'MM-yyyy')  as Month_,A.group_code,G.Group_name,G_1.Group_name as M_Group
                ,ROUND(sum(D.[QTY_ADD]),0 )as Qty_
                ,ROUND(sum((D.[QTY_ADD])*A.Weight),3 )as Weight_
                ,ROUND(sum((D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_ADD)*D.Local_Price*D.total_disc)/100),3) as value_
	           
                FROM	wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                inner join Fac_Machine As M on M.Machine_no=C.Machin_No 
                inner join wh_Groups As G on  A.group_code=G.group_code 
                 
                inner join (SELECT CASE Category WHEN 'r' THEN LEFT(group_code, 4) WHEN 'F' THEN LEFT(group_code, 2) WHEN 'c' THEN LEFT(group_code, 2) ELSE LEFT(group_code, 2) END AS G_Id, item_no, CASE WHEN LEFT(group_code, 2) IN ('40', 
                '41', '42', '43', '44', '45', '46', '47', '48', '49') THEN '2' WHEN LEFT(group_code, 2) IN ('50') THEN '3' ELSE '1' END AS xe_
                 FROM wh_main_master)  As V on V.item_no=a.item_no
                inner join wh_Groups As G_1 on  v.G_ID=G_1.group_code
                where C.transaction_code='xtp' and IN_OUT_TYPE='O' 
                and D.ITEM_NO like'" + Items.ID.Text +
                "%' and A.group_code like '" + Uc_Group.ID.Text + 
                "%' and  A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "') " +
                "and Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "' and C.Branch_code like '" + UC_Branch.ID.Text +
                "%'and ISNULL(A.UnitDepth, '') BETWEEN '" + T1 + "' AND '" + T2 +
                "' GROUP BY FORMAT(C.g_date, 'MM-yyyy'),A.group_code,G.Group_name,G_1.Group_name");

                ds.Tables.Add(dt1);
                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

                rpt.DataDefinition.FormulaFields["Type_"].Text = "' تقرير الانتاج الشهري'";
            rpt.DataDefinition.FormulaFields["Group_"].Text = "'" + Uc_Group.Desc.Text + "'";
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
           Cursor.Current = Cursors.Default;

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //string R, F, C, P, S, Z;
                //if (chR.Checked == true) { R = "R"; } else { R = "X"; }
                //if (chF.Checked == true) { F = "F"; } else { F = "X"; }
                //if (chC.Checked == true) { C = "C"; } else { C = "X"; }
                //if (chS.Checked == true) { S = "S"; } else { S = "X"; }
                //if (chP.Checked == true) { P = "P"; } else { P = "X"; }
                //if (chZ.Checked == true) { Z = "Z"; } else { Z = "X"; }

                groupBox1.Visible = false;
                //double T1, T2;
                //if (thick_1.Text == "")
                //{ T1 = 0; }
                //else { T1 = Convert.ToDouble(thick_1.Text); }
                //if (thick_2.Text == "" || thick_2.Value == 0)
                //{ T2 = 10000; }
                //else { T2 = Convert.ToDouble(thick_2.Text); }
                choises();
                RPT.RM_to_production rpt = new RPT.RM_to_production();


                DataTable dt_rpt = (dal.getDataTabl_1(@"SELECT D.ser_no,D.ITEM_NO,A.descr
        ,ROUND(sum((D.[QTY_TAKE])*A.Weight),0 )as Weight_ ,ROUND(sum((D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0) as value_
        ,ROUND(ROUND(sum((D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.[QTY_TAKE])*A.Weight),0 ),0),1),3)*1000 AS Average_
        FROM	wh_material_transaction As D
        inner join wh_main_master As A on A.item_no=D.ITEM_NO
        inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
        inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
        C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear	  
        inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
  
        where	D.TRANSACTION_CODE = 'xtp' and cast(D.G_date as date) between '"
        + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' and A.Dim_category like '%" + Convert.ToString(cmb_DimCategory.SelectedValue) +
        "%' and ISNULL (A.UnitDepth,'') between '" + T1 + "' AND '" + T2 + "' and A.group_code like '" + Uc_Group.ID.Text + "%' and c.Branch_code like '" + UC_Branch.ID.Text +
        "%' and  A.Category in ('" + R + "', '" + F + "', '" + C + "', '" + P + "', '" + S + "', '" + Z + "','" + X + "')  group by  D.ser_no, D.ITEM_NO,A.descr"));

                DataSet ds = new DataSet();
                ds.Tables.Add(dt_rpt);
                //ds.WriteXmlSchema("schema1.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;


                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المنصرف للانتاج'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
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
            // Cursor.Current = Cursors.WaitCursor;
            // double T1, T2;


            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }


        }




        private void buttonX4_Click(object sender, EventArgs e)
        {
            choises();

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                //double T1, T2;
                //if (thick_1.Text == "")
                //{ T1 = 0; }
                //else { T1 = Convert.ToDouble(thick_1.Text); }
                //if (thick_2.Text == "" || thick_2.Value == 0)
                //{ T2 = 10000; }
                //else { T2 = Convert.ToDouble(thick_2.Text); }



                RPT.Productin rpt = new RPT.Productin();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = dal.getDataTabl_1(@"SELECT C.ser_no,C.G_date,A.item_no,A.descr,C.Branch_code,H.Branch_Name,C.Machin_No,Prod_code
                ,ROUND(sum(D.[QTY_ADD]),0 )as Qty_
                ,ROUND(sum((D.[QTY_ADD])*A.Weight),3 )as Weight_
                ,ROUND(sum((D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_ADD)*D.Local_Price*D.total_disc)/100),3) as value_
	           
                FROM	wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                inner join Fac_Machine As M on M.Machine_no=C.Machin_No 
                where C.transaction_code='xtp' and IN_OUT_TYPE='O' and D.ITEM_NO like'" + Items.ID.Text +
                "%' and A.group_code like '" + Uc_Group.ID.Text + "%' and  A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "') " +
                "and Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "' and C.Branch_code like '"+UC_Branch.ID.Text+
                "%'and ISNULL(A.UnitDepth, '') BETWEEN '" + T1 + "' AND '" + T2 +
                "' group by C.ser_no,C.G_date,A.item_no,A.descr,C.Branch_code,H.Branch_Name,Machin_No,Prod_code ");

                ds.Tables.Add(dt1);
                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير الانتاج'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {

                groupBox1.Visible = false;
                choises();

                RPT.sales_by_group rpt = new RPT.sales_by_group();


                rpt.SetDataSource(dal.getDataTabl_1(@"SELECT v.G_ID As Group_ID,G.Group_name as Group_name ,V.xe_ ,ROUND(sum((D.[QTY_add])*A.Weight),0 )as Weight_ ,
                ROUND(sum((D.QTY_add)*D.Local_Price)-sum(((D.QTY_add)*D.Local_Price*D.total_disc)/100),0) as value_
                ,ROUND(ROUND(sum((D.QTY_add)*D.Local_Price)-sum(((D.QTY_add)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.[QTY_add])*A.Weight),0 ),0),1),3)*1000 AS Average_
                FROM	wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear	  
                inner join (SELECT CASE Category WHEN 'r' THEN LEFT(group_code, 4) WHEN 'F' THEN LEFT(group_code, 2) WHEN 'c' THEN LEFT(group_code, 2) ELSE LEFT(group_code, 2) END AS G_Id, item_no, CASE WHEN LEFT(group_code, 2) IN ('40', 
                '41', '42', '43', '44', '45', '46', '47', '48', '49') THEN '2' WHEN LEFT(group_code, 2) IN ('50') THEN '3' ELSE '1' END AS xe_
                FROM wh_main_master)  As V on V.item_no=a.item_no
                inner join wh_Groups As G on  v.G_ID=G.group_code
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                where  C.transaction_code='xtp' and IN_OUT_TYPE='O' and D.ITEM_NO like'" + Items.ID.Text +
                "%' and A.group_code like '" + Uc_Group.ID.Text + "%' and  A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "') " +
                "and Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "'  and ISNULL (A.UnitDepth,'') between '" + T1 + "' AND '" + T2 + "' group by  v.G_ID,G.Group_name,v.xe_"));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

                rpt.DataDefinition.FormulaFields["Type_"].Text = "' تقرير الانتاج - موزع بالمجموعات'";
                }
                catch (System.Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
                Cursor.Current = Cursors.Default;
        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //string R, F, C, P, S, Z;
                //if (chR.Checked == true) { R = "R"; } else { R = "X"; }
                //if (chF.Checked == true) { F = "F"; } else { F = "X"; }
                //if (chC.Checked == true) { C = "C"; } else { C = "X"; }
                //if (chS.Checked == true) { S = "S"; } else { S = "X"; }
                //if (chP.Checked == true) { P = "P"; } else { P = "X"; }
                //if (chZ.Checked == true) { Z = "Z"; } else { Z = "X"; }
                groupBox1.Visible = false;
                //double T1, T2;
                //if (thick_1.Text == "")
                //{ T1 = 0; }
                //else { T1 = Convert.ToDouble(thick_1.Text); }
                //if (thick_2.Text == "" || thick_2.Value == 0)
                //{ T2 = 10000; }
                //else { T2 = Convert.ToDouble(thick_2.Text); }
                choises();


                RPT.Productin_by_Item rpt = new RPT.Productin_by_Item();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = dal.getDataTabl_1(@"SELECT A.item_no,A.descr
                ,ROUND(sum(D.[QTY_ADD]),0 )as Qty_
                ,ROUND(sum((D.[QTY_ADD])*A.Weight),3 )as Weight_
                ,ROUND(sum((D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_ADD)*D.Local_Price*D.total_disc)/100),3) as value_
	            FROM	wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                inner join Fac_Machine As M on M.Machine_no=C.Machin_No 
            
                where C.transaction_code='xtp'  and A.group_code like '" + Uc_Group.ID.Text + 
                "%'  and IN_OUT_TYPE='O'  and C.Branch_code like '" + UC_Branch.ID.Text+ 
                "%' and D.ITEM_NO like'" + Items.ID.Text + 
                "%' and A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "') " +
                "and Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "'and ISNULL(A.UnitDepth, '') BETWEEN '" + T1 + "' AND '" + T2 +
                "'group by A.item_no,A.descr");

                ds.Tables.Add(dt1);
                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير الانتاج - موزع بالاصناف'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void buttonX7_Click(object sender, EventArgs e)
        {

            getProductionByMachine();
            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{
            //    groupBox1.Visible = false;
            //    choises();

            //    DateTime psDate = dTP1.Value.AddYears(-1);
            //    DateTime peDate = dTP2.Value.AddYears(-1);
            //    RPT.Productin_by_Machin rpt = new RPT.Productin_by_Machin();

            //    DataSet1 ds = new DataSet1();
            //    DataTable dt1 = new DataTable();
            //    dt1 = dal.getDataTabl_1(@"SELECT C.Branch_code,H.Branch_Name,C.Machin_No,Machine_Name
            //   ,SUM(CASE WHEN  Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
            //   "' THEN D.QTY_ADD ELSE 0 END) AS 'Qty'" +
            //   ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + psDate.ToString("yyyy/MM/dd") + "' and '" + peDate.ToString("yyyy/MM/dd") +
            //   "'  THEN D.QTY_ADD ELSE 0 END) AS 'QtyPastYear'" +
            //   ", SUM(CASE WHEN  Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
            //   "' THEN D.QTY_ADD*A.unitlenth/1000 ELSE 0 END) AS 'lenth'" +
            //   ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + psDate.ToString("yyyy/MM/dd") + "' and '" + peDate.ToString("yyyy/MM/dd") +
            //   "'  THEN D.QTY_ADD*A.unitlenth/1000 ELSE 0 END) AS 'lenthPastYear'" +


            //    ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
            //    "' THEN D.QTY_ADD*A.Weight ELSE 0 END) AS 'Weight'" +
            //    ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + psDate.ToString("yyyy/MM/dd") + "' and '" + peDate.ToString("yyyy/MM/dd") +
            //    "' THEN D.QTY_ADD*A.Weight ELSE 0 END) AS 'WeightPastYear'" +

            //    ",SUM(CASE WHEN  Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
            //    "' THEN (D.QTY_ADD*D.Local_Price)-((D.QTY_ADD*D.Local_Price*D.total_disc)/100) ELSE 0 END) AS 'Value'" +
            //    ", SUM(CASE WHEN  Cast(C.G_date as date) between '" + psDate.ToString("yyyy/MM/dd") + "' and '" + peDate.ToString("yyyy/MM/dd") +
            //    "'  THEN (D.QTY_ADD*D.Local_Price)-((D.QTY_ADD*D.Local_Price*D.total_disc)/100)  ELSE 0 END) AS 'ValuePastYear'" +

            //    "FROM	wh_material_transaction As D " +
            //    "inner join wh_main_master As A on A.item_no=D.ITEM_NO " +
            //    "inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE " +
            //    "inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND " +
            //    "C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear " +
            //    "inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code " +
            //    "inner join Fac_Machine As M on M.Machine_no=C.Machin_No " +

            //    "where C.transaction_code = 'xtp' and IN_OUT_TYPE = 'O' and D.ITEM_NO like'" + Items.ID.Text +
            //    "%' and A.group_code like '" + Uc_Group.ID.Text + "%' and  A.Category in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "') " +
            //    "and Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
            //    "' and d.Branch_code like '" + UC_Branch.ID.Text +
            //    "%'and ISNULL(A.UnitDepth, '') BETWEEN '" + T1 + "' AND '" + T2 +
            //    "' group by C.Branch_code,H.Branch_Name,C.Machin_No,Machine_Name ");

            //    ds.Tables.Add(dt1);
            //    //ds.WriteXmlSchema("schema_rpt.xml");
            //    rpt.SetDataSource(ds);
            //    crystalReportViewer1.ReportSource = rpt;

            //    //crystalReportViewer1.ReportSource = rpt;
            //    rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            //    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            //    rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
            //    rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

            //    rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

            //    rpt.DataDefinition.FormulaFields["Type_"].Text = "' تقرير الانتاج - موزع بخطوط الانتاج'";

            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //Cursor.Current = Cursors.Default;

        }

        private void getProductionByMachine()
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                choises();

              
                RPT.rpt_Productin_by_Machin rpt = new RPT.rpt_Productin_by_Machin();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = dal.getDataTabl_1(@"SELECT C.Branch_code,H.Branch_Name,C.Machin_No,Machine_Name
                , SUM(CASE WHEN A.Category in('F','C') THEN D.QTY_ADD ELSE 0 END) AS 'Qty'" +

                ",SUM(CASE WHEN A.Category in('X') THEN D.QTY_ADD ELSE 0 END) AS 'QtyScrap'" +

                ",SUM(CASE WHEN A.Category in('F','C') THEN D.QTY_ADD*A.Weight ELSE 0 END) AS 'Weight'" +

                ",SUM(CASE WHEN A.Category in('X') THEN D.QTY_ADD*A.Weight ELSE 0 END) AS 'WeightScrap'" +

                ",SUM(CASE WHEN A.Category in('F','C') THEN (D.QTY_ADD*D.Local_Price)-((D.QTY_ADD*D.Local_Price*D.total_disc)/100) ELSE 0 END) AS 'Value'" +

                ",SUM(CASE WHEN A.Category in('X') THEN (D.QTY_ADD*D.Local_Price)-((D.QTY_ADD*D.Local_Price*D.total_disc)/100)  ELSE 0 END) AS 'ValueScrap'" +

                "FROM	wh_material_transaction As D " +
                "inner join wh_main_master As A on A.item_no=D.ITEM_NO " +
                "inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE " +
                "inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear " +
                "inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code " +
                "inner join Fac_Machine As M on M.Machine_no=C.Machin_No " +

                "where C.transaction_code = 'xtp' and IN_OUT_TYPE = 'O' and D.ITEM_NO like'" + Items.ID.Text +
                "%' and A.group_code like '" + Uc_Group.ID.Text + 
                "%' and Cast(C.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "' and d.Branch_code like '" + UC_Branch.ID.Text +
                "%'and ISNULL(A.UnitDepth, '') BETWEEN '" + T1 + "' AND '" + T2 +
                "' group by C.Branch_code,H.Branch_Name,C.Machin_No,Machine_Name ");

                ds.Tables.Add(dt1);
                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";

                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";

                rpt.DataDefinition.FormulaFields["Type_"].Text = "' تقرير الانتاج - موزع بخطوط الانتاج'";

                }
                catch (System.Exception ex)
                {
                MessageBox.Show(ex.Message);
                }
                Cursor.Current = Cursors.Default;

        }



        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

