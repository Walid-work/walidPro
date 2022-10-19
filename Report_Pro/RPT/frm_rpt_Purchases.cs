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
    public partial class frm_rpt_Purchases : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
   


        string R, F, C, P, S, Z, X, B, N;
        string SC = "1";
        string str_t = "1";
        string car_studes = "";
        double T1, T2;
        string sp;

        string pay_code = "";


      

        public frm_rpt_Purchases()
        {
            InitializeComponent();
           
            OP.cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM Wh_Unit_dim");
            OP.cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            OP.cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            OP.cmb_DimCategory.SelectedIndex = -1;

        }


        private void choises()
        {
            if (OP.chR.Checked == true) { R = "R"; } else { R = "Y"; }
            if (OP.chF.Checked == true) { F = "F"; } else { F = "Y"; }
            if (OP.chC.Checked == true) { C = "C"; } else { C = "Y"; }
            if (OP.chS.Checked == true) { S = "S"; } else { S = "Y"; }
            if (OP.chP.Checked == true) { P = "P"; } else { P = "Y"; }
            if (OP.chZ.Checked == true) { Z = "Z"; } else { Z = "Y"; }
            if (OP.chX.Checked == true) { X = "X"; } else { X = "Y"; }
            if (OP.chB.Checked == true) { B = "B"; } else { B = "Y"; }
            if (OP.chN.Checked == true) { N = "N"; } else { N = "Y"; }
            // Cursor.Current = Cursors.WaitCursor;
            // double T1, T2;


            if (OP.thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(OP.thick_1.Text); }
            if (OP.thick_2.Text == "" || OP.thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(OP.thick_2.Text); }



            if (OP.payment_type.SelectedIndex == 0)
            {
                pay_code = "";
            }
            else if (OP.payment_type.SelectedIndex == 1)
            {
                pay_code = "11";
            }
            else if (OP.payment_type.SelectedIndex == 2)
            {
                pay_code = "2";
            }


            if (OP.rBtnAll.Checked)
            {
                SC = "";
            }
            if (OP.rBtnS.Checked)
            {
                SC = "1";
            }
            if (OP.rBtnWithoutS.Checked)
            {
                SC = "0";
            }



            if (OP.radioBtn1.Checked)
            {
                str_t = "1";
                car_studes = OP.radioBtn1.Text;
            }
            else if (OP.radioBtn2.Checked)
            {
                str_t = "2";
                car_studes = OP.radioBtn2.Text;
            }
            else if (OP.radioBtn3.Checked)
            {
                str_t = "3";
                car_studes = OP.radioBtn3.Text;
            }




        }





    
   
    
       
        private void button6_Click(object sender, EventArgs e)
        {
            OP.Visible = false;
            choises();

        RPT.CrystalReport3 rpt = new RPT.CrystalReport3();
        DataTable dt_ = dal.getDataTabl_1(@"SELECT  H.Branch_code,
		H.branch_name As name_
		,sum((D.QTY_ADD-D.QTY_TAKE)*A.Weight) as Weight_
		,sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100) as value_
		,sum(D.TAX_IN-D.TAX_OUT) as tax_
		,ROUND(ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*A.Weight),0 ),0),1),3)*1000 AS Average_
     
		FROM wh_material_transaction As D
		inner join wh_main_master As A on A.item_no=D.ITEM_NO
		inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
		C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
		inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
  
		where D.TRANSACTION_CODE like 'xp%'
		and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
         "' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
        " and ISNULL (A.Dim_category,'') like '" + Convert.ToString( OP.cmb_DimCategory.SelectedValue) +
        "%' and ISNULL (A.UnitDepth,'') BETWEEN '" + T1 + "' AND '" + T2 +
        "' 	and Payment_Type like '" + pay_code +
         "%' and c.acc_no like '" +  OP.AccountID.Text +
        "%' and  H.Branch_code like '" + OP.StoreID.Text +
        "%'	and A.group_code like '" + OP.GroupID1.Text +
        "%' and isnull(C.LC_ACC_NO,'') like '" + OP.LcAccountID.Text + 
        "%'	and A.Item_No  like '"+ OP.ItemID1.Text +
        "%' and isnull(C.Po_no,'') like case when '"+ OP.txtPO.Text.Trim()+"'='' then '%' else '"+OP.txtPO.Text+"' end group by H.Branch_code,H.branch_name");

           // rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", Op.dTP1.Value.Date, Op.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(Op.cmb_DimCategory.SelectedValue), "xp",Op.StoreID.Text,Op.AccountID.Text,db1,Op.GroupID1.Text,""));
            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
            rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
            //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
            rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.cmb_DimCategory.Text + "'";
            rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + OP.payment_type.Text + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالفروع'";
            //}
            //catch
            //    { }


        }

        private void button9_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                OP.Visible = false;
                choises();

                RPT.sales_by_group rpt = new RPT.sales_by_group();

                DataTable dt_ = dal.getDataTabl_1(@"SELECT 	v.G_ID As Group_ID,G.Group_name as Group_name,V.xe_
                ,ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*A.Weight),0 )as Weight_
                ,ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0) as value_
                ,ROUND(ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*A.Weight),0 ),0),1),3)*1000 AS Average_
                FROM [wh_material_transaction]As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join 
                (SELECT CASE Category WHEN 'r' THEN LEFT(group_code, 4) WHEN 'F' THEN LEFT(group_code, 2) WHEN 'c' THEN LEFT(group_code, 2) ELSE LEFT(group_code, 2) END AS G_Id
                , item_no, CASE WHEN LEFT(group_code, 2) IN ('40','41','42','43','44','45','46','47','48','49') THEN '2' WHEN LEFT(group_code, 2) IN ('50') THEN '3' ELSE '1' END AS xe_
                FROM wh_main_master	) As V on V.item_no=a.item_no
                inner join wh_Groups As G on  v.G_ID=G.group_code
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code

                where D.TRANSACTION_CODE like 'xp%' 
                and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
                 "' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
                " and ISNULL (A.Dim_category,'') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) + 
                "%' and ISNULL (A.UnitDepth,'') BETWEEN '"+T1+"' AND '"+T2+ 
                "' and C.Payment_Type like '"+ pay_code + 
                "%' and c.acc_no like '"+ OP.AccountID.Text + 
                "%' and C.Branch_code like '"+ OP.StoreID.Text + 
                "%' and G.group_code like '"+ OP.GroupID1.Text +
                "%' and isnull(C.LC_ACC_NO,'') like '" + OP.LcAccountID.Text +
                "%'	and A.Item_No  like '" + OP.ItemID1.Text +
                "%' and isnull(C.Po_no,'') like case when '" + OP.txtPO.Text.Trim() + "'='' then '%' else '" + OP.txtPO.Text + "' end group by v.G_ID ,G.Group_name ,v.xe_");
                rpt.SetDataSource(dt_);
                //rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", Op.dTP1.Value.Date, Op.dTP2.Value.Date, , , T1, T2, , "xp",db1,, , ,"",""));
                               

                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
                //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالمجموعات'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

    
        private void button7_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                OP.Visible = false;
                choises();
                RPT.rpt_transaction_byGroup_payType rpt = new RPT.rpt_transaction_byGroup_payType();

                DataTable dt_ = dal.getDataTabl_1(@"SELECT v.G_ID As Group_ID,G.Group_name as Group_name,p.Payment_name
                ,ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*A.Weight),0 )as Weight_
                ,ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0) as value_
                ,ROUND(ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*A.Weight),0 ),0),1),3)*1000 AS Average_
                FROM wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
                C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear	

                inner join 
                (SELECT CASE Category WHEN 'r' THEN LEFT(group_code, 4) WHEN 'F' THEN LEFT(group_code, 2) WHEN 'c' THEN LEFT(group_code, 2) ELSE LEFT(group_code, 2) END AS G_Id
                , item_no, CASE WHEN LEFT(group_code, 2) IN ('40','41','42','43','44','45','46','47','48','49') THEN '2' WHEN LEFT(group_code, 2) IN ('50') THEN '3' ELSE '1' END AS xe_
                FROM wh_main_master	) As V on V.item_no=a.item_no

                inner join wh_Groups As G on  v.G_ID=G.group_code
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                inner join wh_Payment_type As P on P.Payment_type=C.Payment_Type

                where D.TRANSACTION_CODE like 'xp%' 
                and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
                 "' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
                " and ISNULL (A.Dim_category,'') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) +
                "%' and ISNULL (A.UnitDepth,'') BETWEEN '" + T1 + "' AND '" + T2 +
                "' and C.Payment_Type like '" + pay_code +
                "%' and c.acc_no like '" + OP.AccountID.Text +
                "%' and C.Branch_code like '" + OP.StoreID.Text +
                "%' and G.group_code like '" + OP.GroupID1.Text +
                "%' and isnull(C.LC_ACC_NO,'') like '" + OP.LcAccountID.Text +
                "%'	and A.Item_No  like '" + OP.ItemID1.Text +
                "%' and isnull(C.Po_no,'') like case when '" + OP.txtPO.Text.Trim() + "'='' then '%' else '" + OP.txtPO.Text + "' end group by v.G_ID,G.Group_name,p.Payment_name");

                rpt.SetDataSource(dt_);




                //rpt.SetDataSource(dal.getDataTabl("sales_by_Group_Paytype_", Op.dTP1.Value.Date, Op.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(Op.cmb_DimCategory.SelectedValue), "xp",Op.StoreID.Text,Op.AccountID.Text,db1));

                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
                //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالمجموعات وطريقة الدفع'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            OP.Visible = false;
            choises();
            RPT.S_P_by_Items rpt = new RPT.S_P_by_Items();
            DataTable dt_ = dal.getDataTabl_1(@"SELECT d.ITEM_NO,s.descr,s.UnitDepth,s.group_code,s.Dim_category,s.Category
                ,sum(D.QTY_ADD - D.QTY_TAKE) as Qty
                ,ROUND(sum((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price) - sum(((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price * D.total_disc) / 100), 2) AS Value
                ,sum(D.TAX_IN) - sum(D.TAX_OUT) As Vat
                ,sum((D.QTY_ADD - D.QTY_TAKE) * s.Weight) as Weight

                FROM wh_inv_data as A
                INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
                AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
                inner join wh_main_master As S  on D.ITEM_NO = s.item_no
               
                where D.TRANSACTION_CODE like 'xp%'
                and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") + "'" +
                "and A.Payment_Type like '" + pay_code + "%' " +
                "and ISNULL (S.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','"+ B +"','"+ N +"') " +
                "and isnull(S.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 + "' " +
                "and S.Dim_category like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) + "%' " +
                "and A.Branch_code like '" + OP.StoreID.Text + "%' " +
                "and A.acc_no like '" + OP.AccountID.Text + "%' " +
                "and S.group_code like '" + OP.GroupID1.Text + "%' " +
                "and isnull(A.LC_ACC_NO,'') like '" + OP.LcAccountID.Text +
                "%'	and S.Item_No  like '" + OP.ItemID1.Text +
                "%' and isnull(A.Po_no,'') like case when '" + OP.txtPO.Text.Trim() + "'='' then '%' else '" + OP.txtPO.Text + "' end" +
                " group by d.ITEM_NO, s.descr,s.UnitDepth,s.group_code,s.Dim_category,s.Category");

            //INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            //INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            //    INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            //    inner join WH_INV_TYPE As T on T.INV_CODE = A.Transaction_code


            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المشتريات بالاصناف'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + OP.AccountID.Text + " - '+'" + OP.AccountDesc.Text + "'";
            rpt.DataDefinition.FormulaFields["Lc_"].Text = " '" + OP.LcAccountID.Text + " - '+'" + OP.LcAccountDesc.Text + "'";

            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + OP.StoreDesc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + OP.payment_type.Text + "'";

        }

      

    
   
        private void btnOption_Click(object sender, EventArgs e)
        {
            OP.Visible = true;
          
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                //groupBox1.Visible = false;

                //double T1, T2;
                //if (OP.thick_1.Text == "")
                //{ T1 = 0;
                //}
                //else { T1 = Convert.ToDouble(OP.thick_1.Text); }
                //if (OP.thick_2.Text == "" || OP.thick_2.Value == 0)
                //{ T2 = 10000;
                //}
                //else { T2 = Convert.ToDouble(OP.thick_2.Text); }

                //if (OP.payment_type.SelectedIndex == 0)
                //{
                //    pay_code = "";
                //}
                //else if (OP.payment_type.SelectedIndex == 1)
                //{
                //    pay_code = "11";
                //}
                //else if (OP.payment_type.SelectedIndex == 2)
                //{
                //    pay_code = "2";
                //}
                choises();

                RPT.rptMonthly_sales_pur rpt = new RPT.rptMonthly_sales_pur();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl("Monthly_Sales_", OP.dTP1.Value.Date, OP.dTP2.Value.Date, OP.StoreID.Text,"xs", db1));

                ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Sales Report'";
                rpt.DataDefinition.FormulaFields["Rep_Kind"].Text = "'Sales'";
                rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void button14_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                choises();
                OP.Visible = false;


                RPT.rptMonthly_sales_pur rpt = new RPT.rptMonthly_sales_pur();

                RPT.DataSet1 ds = new RPT.DataSet1();
                DataTable dt1 = new DataTable();
                dt1 = dal.getDataTabl_1(@" SELECT 
     FORMAT(C.g_date, 'MM-yyyy')  as Month_
	,Abs(ROUND(SUM(CASE WHEN  D.Transaction_code like 'XP%' and C.Payment_Type='2' THEN (isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * A.Weight  ELSE 0 END),0) )AS Cr_Weight_sales
	,Abs(Round(SUM(CASE WHEN  D.Transaction_code like 'XP%' and C.Payment_Type='2' THEN ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price) - ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS Cr_Value_sales
	
	,Abs(ROUND(SUM(CASE WHEN  D.Transaction_code  like 'XP%' and C.Payment_Type >10 THEN (isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * A.Weight  ELSE 0 END),0)) AS Cash_Weight_sales
	,Abs(Round(SUM(CASE WHEN  D.Transaction_code like 'XP%' and C.Payment_Type  >10 THEN ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price) - ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS Cash_Value_sales
		
	,Abs(ROUND(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code  like 'XP%' and C.Payment_Type='2' THEN (isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * A.Weight  ELSE 0 END),0)) AS R_Cr_Weight_sales
	,Abs(Round(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'XP%' and C.Payment_Type='2' THEN ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price) - ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS R_Cr_Value_sales
	
	,Abs(ROUND(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code  like 'XP%' and C.Payment_Type >10 THEN (isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * A.Weight  ELSE 0 END),0)) AS R_Cash_Weight_sales
	,Abs(Round(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'XP%' and C.Payment_Type  >10 THEN ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price ) - ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price * D.total_disc ) / 100  ELSE 0 END),0)) AS R_Cash_Value_sales
	
  FROM  wh_material_transaction As D
		inner join wh_main_master As A on A.item_no=D.ITEM_NO
        inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
		inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code 
		AND  C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
		left join ReportDB.dbo.View_G_ID As V on V.item_no=a.item_no
		inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code					  
		inner join wh_Payment_type As P on p.Payment_type=c.Payment_Type
        Inner Join Payer2 as P2 on P2.ACC_NO = C.Acc_no  and P2.BRANCH_code =C.Acc_Branch_code
        
  where cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") +
              "' and ISNULL(A.group_code,'0')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end)  " +
              "  and C.Branch_code like '" + OP.StoreID.Text +
              "%' and isnull(P2.SisterCompany,0) like '" + SC +
              "%' GROUP BY FORMAT(C.g_date, 'MM-yyyy') ");



                ds.Tables.Add(dt1);


                ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Sales Report'";
                rpt.DataDefinition.FormulaFields["Rep_Kind"].Text = "'Sales'";
                rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            //try
            //{
            OP.Visible = false;

            choises();
                RPT.rpt_Sales_byAcc rpt = new RPT.rpt_Sales_byAcc();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



            //dt1 = (dal.getDataTabl("sales_by_Acc_", Op.dTP1.Value.Date, Op.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(Op.cmb_DimCategory.SelectedValue), "xp", Op.StoreID.Text, Op.AccountID.Text, db1,Op.GroupID1.Text));

            dt1 = dal.getDataTabl_1(@"SELECT C.acc_no,P.PAYER_NAME
		        ,sum((D.QTY_ADD-D.QTY_TAKE)*A.Weight) as Weight_
		        ,sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100) as value_
		        ,sum(d.TAX_IN-D.TAX_OUT) as tax_
		        ,ROUND(ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*A.Weight),0 ),0),1),3)*1000 AS Average_
     
		        FROM wh_material_transaction As D
		        inner join wh_main_master As A on A.item_no=D.ITEM_NO
		        inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
		        inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
		        C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
		        inner join wh_Groups As G on A.group_code=G.group_code
		        inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
		        left JOIN payer2 As P ON C.Acc_no = P.ACC_NO AND C.Acc_Branch_code = P.BRANCH_code 

            where D.TRANSACTION_CODE like 'xp%'
            and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") +
            "' and C.Payment_Type like '" + pay_code +
            "%' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
            " and isnull(A.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 +
            "' and A.Dim_category like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) +
            "%' and C.Branch_code like '" + OP.StoreID.Text +
            "%' and C.acc_no like '" + OP.AccountID.Text +
            "%' and A.group_code like '" + OP.GroupID1.Text +
            "%' and isnull(C.LC_ACC_NO,'') like '" + OP.LcAccountID.Text +
            "%'	and A.Item_No  like '" + OP.ItemID1.Text +
            "%' and isnull(C.Po_no,'') like case when '" + OP.txtPO.Text.Trim() + "'='' then '%' else '" + OP.txtPO.Text + "' end group by C.acc_no, P.PAYER_NAME");

            //      where D.TRANSACTION_CODE like 'xp%' 
            //and cast(D.G_date as date) between '2020-01-01' and '2020-12-27'
            // and ISNULL (a.Category,'') like '%'
            //and ISNULL (A.Dim_category,'') like '%'
            //and ISNULL (A.UnitDepth,'') BETWEEN '0' AND '500000' 
            // and Payment_Type like '%'  
            //and  H.Branch_code like '%' 
            //and C.Acc_no like '%' 
            //and G.group_code like '%'



            ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);

                //rpt.SetDataSource(dal.getDataTabl("sales_by_Acc", Op.dTP1.Value.Date, Op.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(Op.cmb_DimCategory.SelectedValue), "xs", Op.StoreID.Text, Op.AccountID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
               // rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["decimal_"].Text = "'" + Properties.Settings.Default.digitNo_+ "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالموردين'";
                
            //}
            //catch
            //{ }

        }
    

  
        private void frm_rpt_Purchases_Load(object sender, EventArgs e)
        {

            OP.txtMainAcc.Text = "234";
            OP.txtMainLcAcc.Text = "125";
            OP.txtFinal.Text = "1";
            OP.txtLcAccFinal.Text = "1";
            OP.txtStoreFinal.Text = "";

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            OP.Visible = false;
            choises();
            RPT.rpt_purchase rpt = new RPT.rpt_purchase();
            //  DataTable dt_ =dal.getDataTabl("Get_local_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,Op.AccountID.Text,Op.StoreID.Text,UC_PayType.ID.Text,KM_Value,dal.db1);

            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_ADD-D.QTY_TAKE) As Qty_Add
        , ROUND(sum((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price) - sum(((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price * D.total_disc) / 100), 2) AS Value
        , sum(D.TAX_IN) - sum(D.TAX_OUT) As Vat, A.Inv_no, A.Inv_date, p.COSTMER_K_M_NO, A.Transaction_code, A.Branch_code,
        A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no

        FROM    wh_inv_data as A
        INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
        INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
        INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
        INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
        AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
        inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
        inner join wh_main_master As S  on D.ITEM_NO = s.item_no
        

 where D.TRANSACTION_CODE like 'xp%'
                and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") + 
                "' and A.Payment_Type like '" + pay_code +
                "%' and ISNULL (s.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
                " and isnull(S.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 + 
                "' and S.Dim_category like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) + 
                "%' and A.Branch_code like '" + OP.StoreID.Text + 
                "%' and A.acc_no like '" + OP.AccountID.Text + 
                "%' and S.group_code like '" + OP.GroupID1.Text + 
                "%' and isnull(A.LC_ACC_NO,'') like '" + OP.LcAccountID.Text +
                "%'	and S.Item_No  like '" + OP.ItemID1.Text +
                "%' and isnull(A.Po_no,'') like case when '" + OP.txtPO.Text.Trim() + "'='' then '%' else '" + OP.txtPO.Text + "' end group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Inv_no, A.Inv_date, p.COSTMER_K_M_NO, A.Transaction_code, A.Branch_code," +
              " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no order by a.Branch_code, A.Ser_no");

            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المشتريات بالفواتير'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + OP.AccountID.Text + " - '+'" + OP.AccountDesc.Text + "'";
            rpt.DataDefinition.FormulaFields["Lc_"].Text = " '" + OP.LcAccountID.Text + " - '+'" + OP.LcAccountDesc.Text + "'";

            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + OP.StoreDesc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + OP.payment_type.Text + "'";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

