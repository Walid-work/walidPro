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
    public partial class frm_rpt_Sales_by_Br : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string R, F, C, P, S, Z, X,B,N;
        string SC = "1";
        string str_t = "1";
        string car_studes = "";
        double T1, T2;
        string sp;

        string pay_code = "";

        public frm_rpt_Sales_by_Br()
        {
            InitializeComponent();
           

            OP.cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM  Wh_Unit_dim");
            OP.cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            OP.cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            OP.cmb_DimCategory.SelectedIndex = -1;

        }
        private void btn_Report_Click(object sender, EventArgs e)
        {

            try
            {
                choises();

                RPT.CrystalReport3 rpt = new RPT.CrystalReport3();

                DataTable dt_ = dal.getDataTabl_1(@"SELECT  H.Branch_code,
		        H.branch_name As name_
		        ,sum((D.QTY_TAKE-D.QTY_ADD)*A.Weight) as Weight_
		        ,sum((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price*D.total_disc)/100) as value_
		        ,sum(D.TAX_OUT-D.TAX_IN) as tax_
		        ,ROUND(ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*A.Weight),0 ),0),1),3)*1000 AS Average_
     
		        FROM wh_material_transaction As D
		        inner join wh_main_master As A on A.item_no=D.ITEM_NO
		        inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
		        C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
		        inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                Inner Join Payer2 as P2 on P2.ACC_NO = C.Acc_no  and P2.BRANCH_code =C.Acc_Branch_code

		        where D.TRANSACTION_CODE like 'xs%'
		        and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") + 
                "' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
                " and ISNULL (A.Dim_category,'') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) +
                "%' and ISNULL (A.UnitDepth,'') BETWEEN '" + T1 + "' AND '" + T2 +
                "' and Payment_Type like '" + pay_code +
                "%' and c.acc_no like '" + OP.AccountID.Text +
                "%' and isnull(P2.SisterCompany,0) like '" + SC +
                "%' and  H.Branch_code like '" + OP.StoreID.Text +
                "%' and A.group_code  between (CASE WHEN '" +OP.GroupID1.Text.Length + "' >3  then  '" +OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end) and D.Item_No like '" +  OP.ItemID1.Text +
                "%' and KM_CODE_ACC like case when '" + str_t + "'= 3 then '3%' else '%' end  and KM_CODE_ACC not like case when '" + str_t + "'= 2 then '3%' else '' end " +
                " group by H.Branch_code,H.branch_name");



                rpt.SetDataSource(dt_);
               // rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", OP.dTP1.Value.Date, OP.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(OP.cmb_DimCategory.SelectedValue), "xs", OP.StoreID.Text, OP.AccountID.Text, db1, OP.GroupID1.Text,""));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
                //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" +  category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالفروع'";
                OP.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }


        }

        private void frm_rpt_Sales_by_Br_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                choises();
                
                RPT.sales_by_group rpt = new RPT.sales_by_group();

                DataTable dt_ = dal.getDataTabl_1(@"SELECT v.G_ID As Group_ID,G.Group_name as Group_name,V.xe_
	        ,ROUND(sum((D.[QTY_TAKE]-D.[QTY_ADD])*A.Weight),0 )as Weight_
	        ,ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price*D.total_disc)/100),0) as value_
	        ,ROUND(ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.[QTY_TAKE]-D.[QTY_ADD])*A.Weight),0 ),0),1),3)*1000 AS Average_
	        FROM [wh_material_transaction]As D
  	        inner join wh_main_master As A on A.item_no=D.ITEM_NO
 	        inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
	        inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear

	        inner join (SELECT CASE Category WHEN 'r' THEN LEFT(group_code, 4) WHEN 'F' THEN LEFT(group_code, 2) WHEN 'c' THEN LEFT(group_code, 2) ELSE LEFT(group_code, 2) END AS G_Id, item_no
           , CASE WHEN LEFT(group_code, 2) IN ('40','41','42','43','44','45','46','47','48','49') THEN '2' WHEN LEFT(group_code, 2) IN ('50') THEN '3' ELSE '1' END AS xe_ FROM wh_main_master) As V on V.item_no=a.item_no
	        left join wh_Groups As G on  v.G_ID=G.group_code
	        inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
            Inner Join Payer2 as P2 on P2.ACC_NO = C.Acc_no  and P2.BRANCH_code =C.Acc_Branch_code


               where D.TRANSACTION_CODE like 'xs%'
		        and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
               "' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
               " and ISNULL (A.Dim_category,'') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) +
               "%' and ISNULL (A.UnitDepth,'0') BETWEEN '" + T1 + "' AND '" + T2 +
               "' and Payment_Type like '" + pay_code +
               "%' and c.acc_no like '" + OP.AccountID.Text +
               "%' and isnull(P2.SisterCompany,0) like '" + SC +
               "%' and  H.Branch_code like '" + OP.StoreID.Text +
               "%' and ISNULL(A.group_code,'')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end) and D.Item_No like '" + OP.ItemID1.Text +
               "%' and KM_CODE_ACC like case when '" + str_t + "'= 3 then '3%' else '%' end  and KM_CODE_ACC not like case when '" + str_t + "'= 2 then '3%' else '' end " +
                " group by   v.G_ID ,G.Group_name ,v.xe_");

                rpt.SetDataSource(dt_);

                //rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", OP.dTP1.Value.Date, OP.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(OP.cmb_DimCategory.SelectedValue), "xs", db1, OP.AccountID.Text, OP.StoreID.Text, OP.GroupID1.Text,X,str_t));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
                //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالمجموعات'";

                OP.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
         Cursor.Current = Cursors.Default;

        }

      
        private void thick_2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                choises();

                RPT.rpt_transaction_byGroup_payType rpt = new RPT.rpt_transaction_byGroup_payType();

                DataTable dt_ = dal.getDataTabl_1(@"SELECT v.G_ID As Group_ID,G.Group_name as Group_name,p.Payment_name
                ,ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*A.Weight),0 )as Weight_
                ,ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price*D.total_disc)/100),0) as value_
                ,ROUND(ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*A.Weight),0 ),0),1),3)*1000 AS Average_
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
                Inner Join Payer2 as P2 on P2.ACC_NO = C.Acc_no  and P2.BRANCH_code =C.Acc_Branch_code

                where D.TRANSACTION_CODE like 'xs%' 
                and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
                "' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
                " and ISNULL (A.Dim_category,'') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) +
                "%' and ISNULL (A.UnitDepth,'') BETWEEN '" + T1 + "' AND '" + T2 +
                "' and C.Payment_Type like '" + pay_code +
                "%' and c.acc_no like '" + OP.AccountID.Text +
                "%' and isnull(P2.SisterCompany, 0) like '" + SC +
                "%' and C.Branch_code like '" + OP.StoreID.Text +
                "%' and ISNULL(A.group_code,'')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end) and D.item_no like '" + OP.ItemID1.Text +
                "%' and KM_CODE_ACC like case when '" + str_t + "'= 3 then '3%' else '%' end  and KM_CODE_ACC not like case when '" + str_t + "'= 2 then '3%' else '' end " +
                " group by v.G_ID,G.Group_name,p.Payment_name");

                rpt.SetDataSource(dt_);



                //rpt.SetDataSource(dal.getDataTabl("sales_by_Group_Paytype_", OP.dTP1.Value.Date, OP.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(OP.cmb_DimCategory.SelectedValue), "xs", OP.StoreID.Text, OP.AccountID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
                //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالمجموعات وطريقة الدفع'";

               OP.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

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
            if (OP.chB.Checked == true) { Z = "B"; } else { Z = "Y"; }
            if (OP.chN.Checked == true) { X = "N"; } else { X = "Y"; }

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



        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor.Current = Cursors.WaitCursor;

                choises();

                RPT.S_P_by_Items rpt = new RPT.S_P_by_Items();

                DataTable dt_ = dal.getDataTabl_1(@"SELECT d.ITEM_NO,s.descr,s.UnitDepth,s.group_code,s.Dim_category,s.Category
                ,sum(D.QTY_TAKE - D.QTY_ADD) as Qty
                ,ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
                ,sum(D.TAX_OUT - D.TAX_IN) As Vat
                ,sum((D.QTY_TAKE - D.QTY_ADD) * s.Weight) as Weight

                FROM wh_inv_data as A
                INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
                AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
                inner join wh_main_master As S  on D.ITEM_NO = s.item_no
                Inner Join Payer2 as P2 on P2.ACC_NO = A.Acc_no  and P2.BRANCH_code =A.Acc_Branch_code

                where D.TRANSACTION_CODE like 'xs%'
                and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") + "'" +
                 " and A.Payment_Type like '" + pay_code + "%' " +
                 " and ISNULL (S.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
                 " and isnull(S.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 + "' " +
                 " and ISNULL(S.Dim_category,'C') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) + "%' " +
                 " and A.Branch_code like '" + OP.StoreID.Text + "%' " +
                 " and A.acc_no like '" + OP.AccountID.Text +
                 "%' and isnull(P2.SisterCompany, 0) like '" + SC +
                "%' and ISNULL(S.group_code,'')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end) and D.item_no like '" + OP.ItemID1.Text +
                 "%' group by d.ITEM_NO, s.descr,s.UnitDepth,s.group_code,s.Dim_category,s.Category");
                //"%' and ISNULL(KM_CODE_ACC,'1') like case when '" + str_t + "'= 3 then '3%' else '%' end  and KM_CODE_ACC not like case when '" + str_t + "'= 2 then '3%' else '' end " +

DataSet ds = new DataSet();
                ds.Tables.Add(dt_);
                //ds.WriteXmlSchema("schema2.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المبيعات بالاصناف'";
                rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + OP.AccountID.Text + " - '+'" + OP.AccountDesc.Text + "'";
                rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + OP.StoreDesc.Text + "'";
                rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + OP.payment_type.Text + "'";

               OP.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void button5_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                choises();


                RPT.Sales_Purchase_Groups rpt = new RPT.Sales_Purchase_Groups();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();
                DataTable dt2 = new DataTable();
                DataTable dt3 = new DataTable();


                dt1 = dal.getDataTabl_1(@"SELECT 
                a.item_no
                ,A.descr 
                ,v.G_ID As Group_ID
                ,G.Group_name as Group_name
                ,V.xe_
                ,p.Payment_type
                ,p.Payment_name
                ,A.Weight
                ,SUM(CASE WHEN  D.Transaction_code like 'XS%' THEN (isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * A.Weight  ELSE 0 END) AS Weight_sales
                ,SUM(CASE WHEN  D.Transaction_code like 'XS%' THEN ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price) - ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price* D.total_disc) / 100  ELSE 0 END) AS Value_sales
                ,ROUND(SUM(CASE WHEN  D.Transaction_code like 'XS%' THEN ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price) - ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END)/ISNULL(NULLIF(SUM(CASE WHEN  D.Transaction_code like 'XS%' THEN (isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * A.Weight  ELSE 0 END),0),1),3)*1000 AS Average_Sales
                ,SUM(CASE WHEN  D.Transaction_code like 'XS%' THEN (isnull(D.TAX_OUT,0)-isnull(d.TAX_IN,0)) else 0 end) as tax_sal
                ,SUM(CASE WHEN  D.Transaction_code like 'XS%' THEN (isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0))  ELSE 0 END) AS qty_sales

                ,SUM(CASE WHEN  D.Transaction_code like 'Xp%' THEN (isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * A.Weight  ELSE 0 END) AS Weight_Purchase
                ,SUM(CASE WHEN  D.Transaction_code like 'Xp%' THEN ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price ) - ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END) AS Value_Purchase
                ,ROUND(SUM(CASE WHEN  D.Transaction_code like 'Xp%' THEN ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price ) - ((isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END)/ISNULL(NULLIF(SUM(CASE WHEN  D.Transaction_code like  'Xp%' THEN (isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0)) * A.Weight  ELSE 0 END),0),1),3)*1000 AS Average_Purchase
                ,SUM(CASE WHEN  D.Transaction_code like 'Xp%' THEN (isnull(D.TAX_IN,0)-isnull(D.TAX_OUT,0)) else 0 end) as tax_pur 
                ,SUM(CASE WHEN  D.Transaction_code like 'Xp%' THEN (isnull(D.QTY_ADD,0)-isnull(D.QTY_TAKE,0))  ELSE 0 END) AS qty_Purchase

                FROM wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code 
                AND  C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear

                inner join (SELECT CASE Category WHEN 'r' THEN LEFT(group_code, 4) WHEN 'F' THEN LEFT(group_code, 2) WHEN 'c' THEN LEFT(group_code, 2) ELSE LEFT(group_code, 2) END AS G_Id, item_no
                , CASE WHEN LEFT(group_code, 2) IN ('40','41','42','43','44','45','46','47','48','49') THEN '2' WHEN LEFT(group_code, 2) IN ('50') THEN '3' ELSE '1' END AS xe_ FROM wh_main_master) As V on V.item_no=a.item_no

                inner join wh_Groups As G on  v.G_ID=G.group_code
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                inner join wh_Payment_type As P on p.Payment_type=c.Payment_Type
                inner JOIN payer2 As P2 ON C.Acc_no = P2.ACC_NO AND C.Acc_Branch_code = P2.BRANCH_code 
                
                where (D.TRANSACTION_CODE like 'XS%' or D.TRANSACTION_CODE like  'Xp%')
                and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") + "'" +
                "and ISNULL (A.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
                "and isnull(A.Dim_category,'C') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) +
                "%' and isnull(A.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 +
                "' and c.Payment_Type like '" + pay_code +
                "%' and  H.Branch_code like '" + OP.StoreID.Text +
                "%'  and C.Acc_no like '"+ OP.AccountID.Text +
                "%' and  ISNULL(A.group_code, '')  between(CASE WHEN '" + OP.GroupID1.Text.Length + "' > 3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "' + '0' end) and(CASE WHEN '" + OP.GroupID2.Text.Length + "' > 3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "' + 'z' end)  " +
                " and D.item_no like '" + OP.ItemID1.Text +
                "%' and isnull(P2.SisterCompany, 0) like '" + SC +
                "%' group by  A.Weight,a.item_no ,A.descr ,v.G_ID ,G.Group_name ,v.xe_ ,p.Payment_type ,p.Payment_name  order by   v.G_ID ");

                dt2 = (dal.getDataTabl("Get_customers_payments", OP.dTP1.Value.Date, OP.dTP2.Value.Date, db1));
                dt3 = (dal.getDataTabl("Sales_total", OP.dTP1.Value.Date, OP.dTP2.Value.Date, db1));

                ds.Tables.Add(dt1);
                ds.Tables.Add(dt2);
                ds.Tables.Add(dt3);

                //ds.WriteXmlSchema("schema2.xml");
                rpt.SetDataSource(ds);

                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
                //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'ملخص المبيعات والمشتريات'";
                rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
                rpt.DataDefinition.FormulaFields["branch_name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            OP.Visible = false;
            Cursor.Current = Cursors.Default;

        }

        private void category_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void payment_type_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel3_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        private void button9_Click(object sender, EventArgs e)
        {

        }

    
        private void button7_Click(object sender, EventArgs e)
        {

        }

        private void button8_Click(object sender, EventArgs e)
        {

        }



        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

      
     
        private void btnOption_Click(object sender, EventArgs e)
        {
            OP.Visible  = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {


            Cursor.Current = Cursors.WaitCursor;
            try
            {
                choises();
                OP.Visible = false;

                // double T1, T2;
                // if (thick_1.Text == "")
                // {
                //     T1 = 0;
                // }
                // else { T1 = Convert.ToDouble(thick_1.Text); }
                // if (thick_2.Text == "" || thick_2.Value == 0)
                // {
                //     T2 = 10000;
                // }
                // else { T2 = Convert.ToDouble(thick_2.Text); }

                // if (payment_type.SelectedIndex == 0)
                // {
                //     pay_code = "";
                // }
                // else if (payment_type.SelectedIndex == 1)
                // {
                //     pay_code = "11";
                // }
                // else if (payment_type.SelectedIndex == 2)
                // {
                //     pay_code = "2";
                // }


                RPT.rptMonthly_sales_pur rpt = new RPT.rptMonthly_sales_pur();

                RPT.DataSet1 ds = new RPT.DataSet1();
                DataTable dt1 = new DataTable();



                //  dt1 = (dal.getDataTabl("Monthly_Sales_", OP.dTP1.Value.Date, OP.dTP2.Value.Date, OP.StoreID.Text, "xs", db1,OP.GroupID1.Text, OP.GroupID2.Text));

                dt1 = dal.getDataTabl_1(@"SELECT 
     FORMAT(C.g_date, 'MM-yyyy')  as Month_
	,Abs(ROUND(SUM(CASE WHEN  D.Transaction_code like 'XS%' and C.Payment_Type='2' THEN (isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * A.Weight  ELSE 0 END),0) )AS Cr_Weight_sales
	,Abs(Round(SUM(CASE WHEN  D.Transaction_code like 'XS%' and C.Payment_Type='2' THEN ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price) - ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS Cr_Value_sales
	
	,Abs(ROUND(SUM(CASE WHEN  D.Transaction_code  like 'XS%' and C.Payment_Type >10 THEN (isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * A.Weight  ELSE 0 END),0)) AS Cash_Weight_sales
	,Abs(Round(SUM(CASE WHEN  D.Transaction_code like 'XS%' and C.Payment_Type  >10 THEN ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price) - ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS Cash_Value_sales
		
	,Abs(ROUND(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code  like 'XS%' and C.Payment_Type='2' THEN (isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * A.Weight  ELSE 0 END),0)) AS R_Cr_Weight_sales
	,Abs(Round(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'XS%' and C.Payment_Type='2' THEN ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price) - ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS R_Cr_Value_sales
	
	,Abs(ROUND(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code  like 'XS%' and C.Payment_Type >10 THEN (isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * A.Weight  ELSE 0 END),0)) AS R_Cash_Weight_sales
	,Abs(Round(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'XS%' and C.Payment_Type  >10 THEN ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price) - ((isnull(D.QTY_TAKE,0)-isnull(D.QTY_ADD,0)) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS R_Cash_Value_sales
	
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


            //Cursor.Current = Cursors.WaitCursor;
            //try
            //{
            //   OP.Visible = false;

            //    double T1, T2;
            //    if (thick_1.Text == "")
            //    {
            //        T1 = 0;
            //    }
            //    else { T1 = Convert.ToDouble(thick_1.Text); }
            //    if (thick_2.Text == "" || thick_2.Value == 0)
            //    {
            //        T2 = 10000;
            //    }
            //    else { T2 = Convert.ToDouble(thick_2.Text); }

            //    if (payment_type.SelectedIndex == 0)
            //    {
            //        pay_code = "";
            //    }
            //    else if (payment_type.SelectedIndex == 1)
            //    {
            //        pay_code = "11";
            //    }
            //    else if (payment_type.SelectedIndex == 2)
            //    {
            //        pay_code = "2";
            //    }


            //    RPT.rptMonthly_sales_pur rpt = new RPT.rptMonthly_sales_pur();

            //    DataSet1 ds = new DataSet1();
            //    DataTable dt1 = new DataTable();



            //    dt1 = (dal.getDataTabl("Monthly_Sales_", OP.dTP1.Value.Date, OP.dTP2.Value.Date, OP.StoreID.Text, "xs", db1,OP.GroupID1.Text, OP.GroupID2.Text));

            //    ds.Tables.Add(dt1);


            //    //ds.WriteXmlSchema("schema_rpt.xml");
            //    rpt.SetDataSource(ds);
            //    crystalReportViewer1.ReportSource = rpt;

            //    rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
            //    rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
            //    rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Sales Report'";
            //    rpt.DataDefinition.FormulaFields["Rep_Kind"].Text = "'Sales'";
            //    rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
            //    rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            //Cursor.Current = Cursors.Default;

        }

        private void button14_Click(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {

        }


        private void button15_Click(object sender, EventArgs e)
        {
            try
            {

                choises();


                RPT.rpt_Sales_byAcc rpt = new RPT.rpt_Sales_byAcc();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"SELECT C.acc_no,P.PAYER_NAME
		        ,sum((D.QTY_TAKE - D.QTY_ADD)*A.Weight) as Weight_
		        ,sum((D.QTY_TAKE - D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE - D.QTY_ADD)*D.Local_Price*D.total_disc)/100) as value_
		        ,sum(D.TAX_OUT-d.TAX_IN) as tax_
		        ,ROUND(ROUND(sum((D.QTY_TAKE - D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE - D.QTY_ADD)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.QTY_TAKE - D.QTY_ADD)*A.Weight),0 ),0),1),3)*1000 AS Average_
     
		        FROM wh_material_transaction As D
		        inner join wh_main_master As A on A.item_no=D.ITEM_NO
		        inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
		        inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND 
		        C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
		        inner join wh_Groups As G on A.group_code=G.group_code
		        inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
		        left JOIN payer2 As P ON C.Acc_no = P.ACC_NO AND C.Acc_Branch_code = P.BRANCH_code 

            where D.TRANSACTION_CODE like 'xs%'
            and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") + 
            "' and C.Payment_Type like '" + pay_code + 
            "%' and isnull(A.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 +
            "' and A.Dim_category like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) + 
            "%' and C.Branch_code like '" + OP.StoreID.Text + 
            "%' and D.item_no like '" + OP.ItemID1.Text + 
            "%' and C.acc_no like '" + OP.AccountID.Text +
           "%' and isnull(P.SisterCompany, 0) like '" + SC +
                "%' and isnull(A.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
            " and ISNULL(A.group_code,'')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end) and KM_CODE_ACC like case when '" + str_t + "'= 3 then '3%' else '%' end  and KM_CODE_ACC not like case when '" + str_t + "'= 2 then '3%' else '' end " +
            " group by C.acc_no, P.PAYER_NAME");
               // dt1 = (dal.getDataTabl("sales_by_Acc_", OP.dTP1.Value.Date, OP.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(OP.cmb_DimCategory.SelectedValue), "xs", OP.StoreID.Text, OP.AccountID.Text, db1, OP.GroupID1.Text));

                ds.Tables.Add(dt1);

                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);

                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
                //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالعميل'";
               OP.Visible = false;

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        private void txtNU_TextChanged(object sender, EventArgs e)
        {

        }

    
      
        private void buttonX5_Click(object sender, EventArgs e)
        {
        try {
            Cursor.Current = Cursors.WaitCursor;
            choises();
            RPT.rpt_purchase rpt = new RPT.rpt_purchase();
            //  DataTable dt_ =dal.getDataTabl("Get_local_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,OP.AccountID.Text,OP.StoreID.Text,UC_PayType.ID.Text,KM_Value,dal.db1);

            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
            , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
            , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Inv_no, A.Inv_date, p.COSTMER_K_M_NO, A.Transaction_code, A.Branch_code,
            A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no

            FROM    wh_inv_data as A
            INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
            AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
            inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
            inner join wh_main_master As S  on D.ITEM_NO = s.item_no
           Inner Join Payer2 as P2 on P2.ACC_NO = A.Acc_no  and P2.BRANCH_code =A.Acc_Branch_code


            where D.TRANSACTION_CODE like 'xs%'
            and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") +
            "' and A.Payment_Type like '" + pay_code +
            "%' and isnull(s.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
            " and isnull(S.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 +
            "' and isnull(S.Dim_category,'') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) +
            "%' and A.Branch_code like '" + OP.StoreID.Text +
            "%' and A.acc_no like '" + OP.AccountID.Text +
            "%' and isnull(P2.SisterCompany, 0) like '" + SC +
                "%' and isnull(S.Category,'Y') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
            " and ISNULL(S.group_code,'')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end)  and D.Item_no like '" + OP.ItemID1.Text +
            "%' and isnull(KM_CODE_ACC,0) like case when '" + str_t + "'= 3 then '3%' else '%' end  and isnull(KM_CODE_ACC,0) not like case when '" + str_t + "'= 2 then '3%' else '' end " +
            "group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Inv_no, A.Inv_date, p.COSTMER_K_M_NO, A.Transaction_code, A.Branch_code," +
            " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no order by a.Branch_code, A.Ser_no");

            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المبيعات بالفواتير'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + OP.AccountID.Text + " - '+'" + OP.AccountDesc.Text + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + OP.StoreDesc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + OP.payment_type.Text + "'";
            OP.Visible = false;
            }
        catch (System.Exception ex)
            {
            MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //try
            //{
            Cursor.Current = Cursors.WaitCursor;
            choises();
            RPT.rpt_Cut_Off rpt = new RPT.rpt_Cut_Off();
            //  DataTable dt_ =dal.getDataTabl("Get_local_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,OP.AccountID.Text,OP.StoreID.Text,UC_PayType.ID.Text,KM_Value,dal.db1);
            DataSet1 ds = new DataSet1();
            DataTable dt_ = dal.getDataTabl_1(@" select X.* from (SELECT 
            ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE desc) AS ser
            ,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
            , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
            , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Transaction_code,
            A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no
		

            FROM    wh_inv_data as A
            INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
            AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
            inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
            inner join wh_main_master As S  on D.ITEM_NO = s.item_no
        

            where D.TRANSACTION_CODE like 'xs%' and D.TRANSACTION_CODE <> 'xsr' and D.TRANSACTION_CODE <> 'xst'
            and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") +
             "'  group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Transaction_code, A.Branch_code," +
             " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no) as X  where ser <= 5  ");

                ds.Tables.Add(dt_);
                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                //rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المبيعات بالفواتير'";
                //rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + OP.AccountID.Text + " - '+'" + Uc_Acc.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + OP.StoreDesc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + payment_type.Text + "'";
               OP.Visible = false;
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            Cursor.Current = Cursors.Default;

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                OP.Visible = false;

                double T1, T2;
                if (OP.thick_1.Text == "")
                {
                    T1 = 0;
                }
                else { T1 = Convert.ToDouble(OP.thick_1.Text); }
                if (OP.thick_2.Text == "" || OP.thick_2.Value == 0)
                {
                    T2 = 10000;
                }
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


                RPT.rpt_M_BranchSales rpt = new RPT.rpt_M_BranchSales();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl_1(@"SELECT H.branch_code,H.branch_name
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='01-'+FORMAT(C.g_date, 'yyyy') and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '01' 
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='02-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD)* isnull(A.weight,0) ELSE 0 END),0)) AS '02'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='03-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '03'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='04-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '04'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='05-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '05'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='06-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '06'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='07-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '07'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='08-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '08'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='09-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '09'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='10-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '10'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='11-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '11'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='12-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN (D.QTY_TAKE-D.QTY_ADD) * isnull(A.weight,0) ELSE 0 END),0)) AS '12'

                FROM  wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code 
                AND  C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code					  
                Inner Join Payer2 as P2 on P2.ACC_NO = C.Acc_no  and P2.BRANCH_code =C.Acc_Branch_code
               
where cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
                "' and D.Item_no like '" +OP.ItemID1.Text + "%' and ISNULL(A.group_code,'')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end) " +
                "And H.branch_code like '" + OP.StoreID.Text +
                "%' and isnull(P2.SisterCompany, 0) like '" + SC +
                "%' and c.acc_no like '%'  GROUP BY H.branch_code,H.branch_name order by H.branch_code"));

                ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Sales By Branch'";
                //rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                //rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void OP_Load(object sender, EventArgs e)
        {

        }

        private void btn_CustomersMonthelySales_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                OP.Visible = false;
                choises();

                RPT.rpt_M_CustomerSales rpt = new RPT.rpt_M_CustomerSales();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl_1(@"SELECT C.Acc_no,p.Payer_Name
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='01-'+FORMAT(C.g_date, 'yyyy') and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '01' 
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='02-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '02'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='03-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '03'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='04-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '04'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='05-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '05'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='06-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '06'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='07-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '07'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='08-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '08'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='09-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '09'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='10-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '10'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='11-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '11'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='12-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '12'

                FROM  wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code 
                AND  C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code	
               inner join payer2 As P on p.acc_no = C.acc_no and C.branch_code= P.branch_code
                where cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
                "' and ISNULL(A.group_code,'')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end)  and D.Item_no like '" + OP.ItemID1.Text +
              "%' and isnull(P.SisterCompany, 0) like '" + SC +
                "%'  And H.branch_code like '" + OP.StoreID.Text + "%' and c.acc_no like '%'  " +
                "GROUP BY C.Acc_no,p.Payer_Name order by C.Acc_no"));

                ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Sales By Branch'";
                //rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                //rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                choises();

                RPT.sales_by_group rpt = new RPT.sales_by_group();

                DataTable dt_ = dal.getDataTabl_1(@"SELECT VM.group_code As Group_ID,VM.Group_name as Group_name
	        ,ROUND(sum((D.[QTY_TAKE]-D.[QTY_ADD])*A.Weight),0 )as Weight_
	        ,ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price*D.total_disc)/100),0) as value_
	        ,ROUND(ROUND(sum((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price)-sum(((D.QTY_TAKE-D.QTY_ADD)*D.Local_Price*D.total_disc)/100),0)/ISNULL(NULLIF(ROUND(sum((D.[QTY_TAKE]-D.[QTY_ADD])*A.Weight),0 ),0),1),3)*1000 AS Average_
	        FROM [wh_material_transaction]As D
  	        inner join wh_main_master As A on A.item_no=D.ITEM_NO
 	        inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
	        inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code AND C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear

	       	 inner join wh_Groups As G on A.group_code=G.group_code
			inner join Wh_Main_Group as V on V.group_code = G.MAIN_GROUP
			inner join Wh_Main_Group as VM on VM.group_code = V.MAIN_NO

	        inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code
                Inner Join Payer2 as P2 on P2.ACC_NO = C.Acc_no  and P2.BRANCH_code =C.Acc_Branch_code


               where D.TRANSACTION_CODE like 'xs%'
		        and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
               "' and ISNULL (a.Category,'') in('" + R + "','" + F + "','" + C + "','" + P + "','" + S + "','" + Z + "','" + X + "','" + B + "','" + N + "') " +
               " and ISNULL (A.Dim_category,'') like '" + Convert.ToString(OP.cmb_DimCategory.SelectedValue) +
               "%' and ISNULL (A.UnitDepth,'0') BETWEEN '" + T1 + "' AND '" + T2 +
               "' and Payment_Type like '" + pay_code +
               "%' and c.acc_no like '" + OP.AccountID.Text +
               "%' and isnull(P2.SisterCompany, 0) like '" + SC +
                "%' and  H.Branch_code like '" + OP.StoreID.Text +
               "%' and ISNULL(A.group_code,'') like '" + OP.GroupID1.Text +
               "%' and D.Item_No like '" + OP.ItemID1.Text +
               "%' and KM_CODE_ACC like case when '" + str_t + "'= 3 then '3%' else '%' end  and KM_CODE_ACC not like case when '" + str_t + "'= 2 then '3%' else '' end " +
                " group by vM.group_code,VM.Group_name");

                rpt.SetDataSource(dt_);

                //rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", OP.dTP1.Value.Date, OP.dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(OP.cmb_DimCategory.SelectedValue), "xs", db1, OP.AccountID.Text, OP.StoreID.Text, OP.GroupID1.Text,X,str_t));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + OP.thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + OP.thick_2.Text + "'";
                //rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + OP.cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + OP.payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالمجموعات'";

                OP.Visible = false;
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {

                          //try
                //{
                Cursor.Current = Cursors.WaitCursor;
                choises();
                RPT.rpt_Cut_Off rpt = new RPT.rpt_Cut_Off();
                //  DataTable dt_ =dal.getDataTabl("Get_local_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,OP.AccountID.Text,OP.StoreID.Text,UC_PayType.ID.Text,KM_Value,dal.db1);
                DataSet1 ds = new DataSet1();
                DataTable dt_ = dal.getDataTabl_1(@" select X.* from (SELECT 
ROW_NUMBER() OVER(PARTITION BY B.branch_name ORDER BY A.G_DATE ) AS ser
,A.Ser_no, A.Branch_code,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_TAKE - D.QTY_ADD) As Qty_Add
            , ROUND(sum((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price) - sum(((D.QTY_TAKE - D.QTY_ADD) * D.Local_Price * D.total_disc) / 100), 2) AS Value
            , sum(D.TAX_OUT-D.TAX_IN) As Vat, A.Transaction_code,
            A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no
		

            FROM    wh_inv_data as A
            INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
            AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
            inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
            inner join wh_main_master As S  on D.ITEM_NO = s.item_no
        

            where D.TRANSACTION_CODE like 'xs%' and D.TRANSACTION_CODE <> 'xsr' and D.TRANSACTION_CODE <> 'xst'
            and cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OP.dTP2.Value.ToString("yyyy-MM-dd") +
             "'  group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Transaction_code, A.Branch_code," +
             " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no) as X  where ser <= 5  ");

                ds.Tables.Add(dt_);
                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;
                //rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المبيعات بالفواتير'";
                //rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + OP.AccountID.Text + " - '+'" + Uc_Acc.Desc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + OP.StoreDesc.Text + "'";
                //rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + payment_type.Text + "'";
               OP.Visible = false;
                //}
                //catch (System.Exception ex)
                //{
                //    MessageBox.Show(ex.Message);
                //}
                Cursor.Current = Cursors.Default;

    



        }

    
        private void btnMonthelySales_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
               OP.Visible = false;

                double T1, T2;
                if (OP.thick_1.Text == "")
                {
                    T1 = 0;
                }
                else { T1 = Convert.ToDouble(OP.thick_1.Text); }
                if (OP.thick_2.Text == "" || OP.thick_2.Value == 0)
                {
                    T2 = 10000;
                }
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


                RPT.rpt_M_BranchSales rpt = new RPT.rpt_M_BranchSales();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl_1(@"SELECT H.branch_code,H.branch_name
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='01-'+FORMAT(C.g_date, 'yyyy') and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '01' 
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='02-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '02'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='03-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '03'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='04-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '04'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='05-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '05'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='06-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '06'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='07-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '07'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='08-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '08'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='09-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '09'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='10-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '10'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='11-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '11'
                ,Abs(Round(SUM(CASE WHEN   FORMAT(C.g_date, 'MM-yyyy')='12-'+FORMAT(C.g_date, 'yyyy')  and D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS '12'

                FROM  wh_material_transaction As D
                inner join wh_main_master As A on A.item_no=D.ITEM_NO
                inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code 
                AND  C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code					  
                Inner Join Payer2 as P2 on P2.ACC_NO = C.Acc_no  and P2.BRANCH_code =C.Acc_Branch_code
            
where cast(D.G_date as date) between '" + OP.dTP1.Value.ToString("yyyy/MM/dd")+ "' and '" + OP.dTP2.Value.ToString("yyyy/MM/dd") +
                "' and D.Item_no like '" + OP.ItemID1.Text +
                "%' and ISNULL(A.group_code,'')  between (CASE WHEN '" + OP.GroupID1.Text.Length + "' >3  then  '" + OP.GroupID1.Text + "' else '" + OP.GroupID1.Text + "'+'0' end) and (CASE WHEN '" + OP.GroupID2.Text.Length + "' >3   then  '" + OP.GroupID2.Text + "' else  '" + OP.GroupID2.Text + "'+'z' end) " +
                " and isnull(P2.SisterCompany, 0) like '" + SC +
                "%' And H.branch_code like '" + OP.StoreID.Text+"%' and c.acc_no like '%'  GROUP BY H.branch_code,H.branch_name order by H.branch_code"));

                ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                //rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + OP.dTP1.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + OP.dTP2.Value.ToString("yyyy/MM/dd") + "'";
                //rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Sales By Branch'";
                //rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                //rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void Items_Load(object sender, EventArgs e)
        {

        }

        private void Items_Click(object sender, EventArgs e)
        {
            try
            {
                PL.frm_search_items frm = new PL.frm_search_items();
                frm.ShowDialog();
                OP.ItemID1.Text = frm.dGV_pro_list.CurrentRow.Cells[0].Value.ToString();
                //get_balance();
            }
            catch { }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void rBtnS_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click_1(object sender, EventArgs e)
        {

        }
    }
}

