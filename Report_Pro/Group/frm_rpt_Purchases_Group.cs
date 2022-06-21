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
    public partial class frm_rpt_Purchases_Group : Form
    {
        string db1 = Properties.Settings.Default.Database_1;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string sp;
       
        string pay_code = "";

        public frm_rpt_Purchases_Group()
        {
            InitializeComponent();
            category.DataSource = dal.getDataTabl("Get_category_",db1);
            category.DisplayMember = "Category_name";
            category.ValueMember = "Category_code";
            category.SelectedIndex = -1;

            cmb_DimCategory.DataSource = dal.getDataTabl_1(@"select * FROM "+Properties.Settings.Default.Database_1+".dbo.Wh_Unit_dim");
            cmb_DimCategory.DisplayMember = "Wh_Unit_dim";
            cmb_DimCategory.ValueMember = "Wh_Unit_dim";
            cmb_DimCategory.SelectedIndex = -1;

        }
        private void btn_Report_Click(object sender, EventArgs e)
        {
       
        try
            {
                groupBox1.Visible = false;
                double T1,T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }
                
                

                RPT.CrystalReport3 rpt = new RPT.CrystalReport3();

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs",UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالفروع'";

            }
            catch
            { }


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
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

    
                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }

                
                RPT.sales_by_group rpt = new RPT.sales_by_group();


                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs",db1,Uc_Acc.ID.Text,UC_Branch.ID.Text));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالمجموعات'";
            }
           catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
           
        }

        private void button2_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

               if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rpt_sales_ByBranch rpt = new RPT.rpt_sales_ByBranch();

                rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالفروع'";
            }
            catch
            { }
        }

        private void thick_2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

         
                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rpt_transaction_byGroup_payType rpt = new RPT.rpt_transaction_byGroup_payType();

                rpt.SetDataSource(dal.getDataTabl("sales_by_Group_Paytype_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1));
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالمجموعات وطريقة الدفع'";
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

        private void button4_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            double T1, T2;
            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }

            if (payment_type.SelectedIndex == 0)
            {
                pay_code = "";
            }
            else if (payment_type.SelectedIndex == 1)
            {
                pay_code = "11";
            }
            else if (payment_type.SelectedIndex == 2)
            {
                pay_code = "2";
            }
            
            RPT.S_P_by_Items rpt = new RPT.S_P_by_Items();

            rpt.SetDataSource(dal.getDataTabl(@"sales_by_item_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
            crystalReportViewer1.ReportSource = rpt;
          
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
                Cursor.Current = Cursors.WaitCursor;
                try
                {
                groupBox1.Visible = false;

                    double T1, T2;
                    if (thick_1.Text == "")
                    { T1 = 0; }
                    else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0) 
                    { T2 = 10000; }
                    else { T2 = Convert.ToDouble(thick_2.Text); }

                    if (payment_type.SelectedIndex == 0)
                    {
                        pay_code = "";
                    }
                    else if (payment_type.SelectedIndex == 1)
                    {
                        pay_code = "11";
                    }
                    else if (payment_type.SelectedIndex == 2)
                    {
                        pay_code = "2";
                    }


                    RPT.Sales_Purchase_Groups rpt = new RPT.Sales_Purchase_Groups();

                    DataSet1 ds = new DataSet1();
                    DataTable dt1 = new DataTable();
                    DataTable dt2 = new DataTable();
                    DataTable dt3 = new DataTable();


                    dt1 = (dal.getDataTabl("sales_ByGroup__", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue),UC_Branch.ID.Text,Uc_Acc.ID.Text,db1));
                    dt2 = (dal.getDataTabl("Get_customers_payments", dTP1.Value.Date, dTP2.Value.Date,db1));
                    dt3 = (dal.getDataTabl("Sales_total", dTP1.Value.Date, dTP2.Value.Date,db1));

                    ds.Tables.Add(dt1);
                    ds.Tables.Add(dt2);
                    ds.Tables.Add(dt3);

                    //ds.WriteXmlSchema("schema2.xml");
                    rpt.SetDataSource(ds);

                    crystalReportViewer1.ReportSource = rpt;
                    rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                    rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                    rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                    rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                    rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                    rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + payment_type.Text + "'";
                    rpt.DataDefinition.FormulaFields["Type_"].Text = "'ملخص المبيعات والمشتريات'";
                    rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt + "'";
                    rpt.DataDefinition.FormulaFields["branch_name"].Text = "'" + Properties.Settings.Default.Branch_txt + "'";
            }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                Cursor.Current = Cursors.Default;

            }

       
        private void button6_Click(object sender, EventArgs e)
        {
          
                //try
                //{
                groupBox1.Visible = false;
                    double T1, T2;
                    if (thick_1.Text == "")
                    { T1 = 0; }
                    else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                    else { T2 = Convert.ToDouble(thick_2.Text); }

                   if (payment_type.SelectedIndex == 0)
                    {
                        pay_code = "";
                    }
                    else if (payment_type.SelectedIndex == 1)
                    {
                        pay_code = "11";
                    }
                    else if (payment_type.SelectedIndex == 2)
                    {
                        pay_code = "2";
                    }



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
		and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
        "' and ISNULL (a.Category,'') like '" + Convert.ToString(category.SelectedValue) +
        "%' and ISNULL (A.Dim_category,'') like '" + Convert.ToString(cmb_DimCategory.SelectedValue) +
        "%' and ISNULL (A.UnitDepth,'') BETWEEN '" + T1 + "' AND '" + T2 +
        "' 	and Payment_Type like '" + pay_code +
         "%' and c.acc_no like '" + Uc_Acc.ID.Text +
        "%' and  H.Branch_code like '" + UC_Branch.ID.Text +
        "%'	and A.group_code like '" + Uc_Group.ID.Text +
        "%' and isnull(C.LC_ACC_NO,'') like '" + Lc_Acc.ID.Text + 
        "%'	and A.Item_No  like '"+UcItem.ID.Text + 
        "%' group by H.Branch_code,H.branch_name");

            // rpt.SetDataSource(dal.getDataTabl("sales_by_branch_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1,Uc_Group.ID.Text,""));
            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
            rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
            rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
            rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
            rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
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
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


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
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "' and ISNULL (a.Category,'')  like '"+ Convert.ToString(category.SelectedValue) + 
                "%' and ISNULL (A.Dim_category,'') like '"+ Convert.ToString(cmb_DimCategory.SelectedValue) + 
                "%' and ISNULL (A.UnitDepth,'') BETWEEN '"+T1+"' AND '"+T2+ 
                "' and C.Payment_Type like '"+ pay_code + 
                "%' and c.acc_no like '"+ Uc_Acc.ID.Text + 
                "%' and C.Branch_code like '"+ UC_Branch.ID.Text + 
                "%' and G.group_code like '"+ Uc_Group.ID.Text +
                "%' and isnull(C.LC_ACC_NO,'') like '" + Lc_Acc.ID.Text +
                "%'	and A.Item_No  like '" + UcItem.ID.Text +
                "%' group by v.G_ID ,G.Group_name ,v.xe_");
                rpt.SetDataSource(dt_);
                //rpt.SetDataSource(dal.getDataTabl("sales_by_Group_", dTP1.Value.Date, dTP2.Value.Date, , , T1, T2, , "xp",db1,, , ,"",""));
                               

                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
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
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                //if (cmb_transaction.SelectedIndex == 0)
                //{
                //    trans_code = "xs";
                //}
                //else if (cmb_transaction.SelectedIndex == 1)
                //{
                //    trans_code = "xp";
                //}

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


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
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "' and ISNULL (a.Category,'')  like '" + Convert.ToString(category.SelectedValue) +
                "%' and ISNULL (A.Dim_category,'') like '" + Convert.ToString(cmb_DimCategory.SelectedValue) +
                "%' and ISNULL (A.UnitDepth,'') BETWEEN '" + T1 + "' AND '" + T2 +
                "' and C.Payment_Type like '" + pay_code +
                "%' and c.acc_no like '" + Uc_Acc.ID.Text +
                "%' and C.Branch_code like '" + UC_Branch.ID.Text +
                "%' and G.group_code like '" + Uc_Group.ID.Text +
                "%' and isnull(C.LC_ACC_NO,'') like '" + Lc_Acc.ID.Text +
                "%'	and A.Item_No  like '" + UcItem.ID.Text +
                "%' group by v.G_ID,G.Group_name,p.Payment_name");

                rpt.SetDataSource(dt_);




                //rpt.SetDataSource(dal.getDataTabl("sales_by_Group_Paytype_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1));

                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + payment_type.Text + "'";
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
            groupBox1.Visible = false;
            double T1, T2;
            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }

            

            if (payment_type.SelectedIndex == 0)
            {
                pay_code = "";
            }
            else if (payment_type.SelectedIndex == 1)
            {
                pay_code = "11";
            }
            else if (payment_type.SelectedIndex == 2)
            {
                pay_code = "2";
            }
              RPT.S_P_by_Items rpt = new RPT.S_P_by_Items();

            // DataTable dt_ = dal.getDataTabl(@"sales_by_item_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp",UC_Branch.ID.Text,Uc_Acc.ID.Text,db1, Uc_Group.ID.Text,Lc_Acc.ID.Text);

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
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + dTP2.Value.ToString("yyyy-MM-dd") + "'" +
                "and A.Payment_Type like '" + pay_code + "%' " +
                "and s.Category like '" + Convert.ToString(category.SelectedValue) + "%' " +
                "and isnull(S.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 + "' " +
                "and S.Dim_category like '" + Convert.ToString(cmb_DimCategory.SelectedValue) + "%' " +
                "and A.Branch_code like '" + UC_Branch.ID.Text + "%' " +
                "and A.acc_no like '" + Uc_Acc.ID.Text + "%' " +
                "and S.group_code like '" + Uc_Group.ID.Text + "%' " +
                "and isnull(A.LC_ACC_NO,'') like '" + Lc_Acc.ID.Text +
                "%'	and S.Item_No  like '" + UcItem.ID.Text +
                "%' group by d.ITEM_NO, s.descr,s.UnitDepth,s.group_code,s.Dim_category,s.Category");

            //INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
            //INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
            //    INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
            //    inner join WH_INV_TYPE As T on T.INV_CODE = A.Transaction_code


            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;

            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المشتريات بالاصناف'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + Uc_Acc.ID.Text + " - '+'" + Uc_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Lc_"].Text = " '" + Lc_Acc.ID.Text + " - '+'" + Lc_Acc.Desc.Text + "'";

            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + payment_type.Text + "'";

        }

      

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void button11_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }



                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.sales_by_group rpt = new RPT.sales_by_group();


                rpt.SetDataSource(dal.getDataTabl("take_to_production_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xtp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المنصرف للانتاج'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;

        }

        private void button12_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                //if (cmb_transaction.SelectedIndex == 0)
                //{ trans_code="xs";
                //}
                //else if (cmb_transaction.SelectedIndex == 1)
                //{
                //    trans_code = "xp";
                //}

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.sales_by_group rpt = new RPT.sales_by_group();


                rpt.SetDataSource(dal.getDataTabl("Out_from_production_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xtp",db1));


                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير الانتاج'";
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            Cursor.Current = Cursors.Default;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
        }

        private void button13_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            try
            {
                groupBox1.Visible = false;

                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0;
                }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000;
                }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rptMonthly_sales_pur rpt = new RPT.rptMonthly_sales_pur();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl("Monthly_Sales_", dTP1.Value.Date, dTP2.Value.Date, UC_Branch.ID.Text,"xs", db1));

                ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
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
                groupBox1.Visible = false;

                double T1, T2;
                if (thick_1.Text == "")
                {
                    T1 = 0;
                }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                {
                    T2 = 10000;
                }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }


                RPT.rptMonthly_sales_pur rpt = new RPT.rptMonthly_sales_pur();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();

                dt1 = dal.getDataTabl_1(@"SELECT  FORMAT(C.g_date, 'MM-yyyy')  as Month_
	,Abs(ROUND(SUM(CASE WHEN  D.Transaction_code  like 'xp%' and C.Payment_Type='2' THEN (D.QTY_TAKE-D.QTY_ADD) * A.Weight  ELSE 0 END),0) )AS Cr_Weight_sales
	,Abs(Round(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS Cr_Value_sales
	,Abs(ROUND(ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)/ISNULL(NULLIF(ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN (D.QTY_TAKE-D.QTY_ADD) * A.Weight  ELSE 0 END),0 ),0),1),3)*1000) AS Cr_Average_Sales
	,Abs(ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN (D.TAX_OUT-d.TAX_IN) else 0 end),0)) as Cr_tax_sal
	,Abs(Round(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0) + ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN (D.TAX_OUT-d.TAX_IN) else 0 end),0)) as Tot_cr_sal
	
	,Abs(ROUND(SUM(CASE WHEN  D.Transaction_code  like 'xp%' and C.Payment_Type='11' THEN (D.QTY_TAKE-D.QTY_ADD) * A.Weight  ELSE 0 END),0)) AS Cash_Weight_sales
	,Abs(Round(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS Cash_Value_sales
	,Abs(ROUND(ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)/ISNULL(NULLIF(ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN (D.QTY_TAKE-D.QTY_ADD) * A.Weight  ELSE 0 END),0 ),0),1),3)*1000) AS Cash_Average_Sales
	,Abs(ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN (D.TAX_OUT-d.TAX_IN) else 0 end),0)) as Cash_tax_sal
	,Abs(Round(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0) + ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN (D.TAX_OUT-d.TAX_IN) else 0 end),0)) as Tot_cash_sal

	
	,Abs(ROUND(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code  like 'xp%' and C.Payment_Type='2' THEN (D.QTY_TAKE-D.QTY_ADD) * A.Weight  ELSE 0 END),0)) AS Cr_Weight_sales
	,Abs(Round(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS Cr_Value_sales
	,Abs(ROUND(ROUND(SUM(CASE WHEN V.xe_ ='3' and D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)/ISNULL(NULLIF(ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN (D.QTY_TAKE-D.QTY_ADD) * A.Weight  ELSE 0 END),0 ),0),1),3)*1000) AS Cr_Average_Sales
	,Abs(ROUND(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN (D.TAX_OUT-d.TAX_IN) else 0 end),0)) as Cr_tax_sal
	,Abs(Round(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0) + ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='2' THEN (D.TAX_OUT-d.TAX_IN) else 0 end),0)) as Tot_cr_sal
	
	,Abs(ROUND(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code  like 'xp%' and C.Payment_Type='11' THEN (D.QTY_TAKE-D.QTY_ADD) * A.Weight  ELSE 0 END),0)) AS Cash_Weight_sales
	,Abs(Round(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS Cash_Value_sales
	,Abs(ROUND(ROUND(SUM(CASE WHEN V.xe_ ='3' and D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)/ISNULL(NULLIF(ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN (D.QTY_TAKE-D.QTY_ADD) * A.Weight  ELSE 0 END),0 ),0),1),3)*1000) AS Cash_Average_Sales
	,Abs(ROUND(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN (D.TAX_OUT-d.TAX_IN) else 0 end),0)) as Cash_tax_sal
	,Abs(Round(SUM(CASE WHEN  V.xe_ ='3' and D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0) + ROUND(SUM(CASE WHEN  D.Transaction_code like 'xp%' and C.Payment_Type='11' THEN (D.TAX_OUT-d.TAX_IN) else 0 end),0)) as Tot_cash_sal


	
  FROM  wh_material_transaction As D
		inner join wh_main_master As A on A.item_no=D.ITEM_NO
        inner join WH_INV_TYPE As B on D.TRANSACTION_CODE=b.INV_CODE
		inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code 
		AND  C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
		inner join ReportDB.dbo.View_G_ID As V on V.item_no=a.item_no
		inner join wh_Groups As G on  v.G_ID=G.group_code
		inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code					  
		inner join wh_Payment_type As P on p.Payment_type=c.Payment_Type
               
                where D.TRANSACTION_CODE like 'xp%'
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + dTP2.Value.ToString("yyyy-MM-dd") + "'" +
                "and C.Payment_Type like '" + pay_code + "%' " +
                "and A.Category like '" + Convert.ToString(category.SelectedValue) + "%' " +
                "and isnull(A.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 + "' " +
                "and A.Dim_category like '" + Convert.ToString(cmb_DimCategory.SelectedValue) + "%' " +
                "and C.Branch_code like '" + UC_Branch.ID.Text + "%' " +
                "and C.acc_no like '" + Uc_Acc.ID.Text + "%' " +
                "and A.group_code like '" + Uc_Group.ID.Text + "%' " +
                "and isnull(C.LC_ACC_NO,'') like '" + Lc_Acc.ID.Text +
                "%'	and A.Item_No  like '" + UcItem.ID.Text +
                "%' GROUP BY FORMAT(C.g_date, 'MM-yyyy') ");
           

                //dt1 = (dal.getDataTabl("Monthly_Sales_", dTP1.Value.Date, dTP2.Value.Date, UC_Branch.ID.Text, "xp", db1));

                ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'Monthly Purchases Report'";
                rpt.DataDefinition.FormulaFields["Rep_Kind"].Text = "'Purchases'";
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
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }



                RPT.rpt_Sales_byAcc rpt = new RPT.rpt_Sales_byAcc();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



            //dt1 = (dal.getDataTabl("sales_by_Acc_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xp", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1,Uc_Group.ID.Text));

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
            and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + dTP2.Value.ToString("yyyy-MM-dd") +
            "' and C.Payment_Type like '" + pay_code +
            "%' and A.Category like '" + Convert.ToString(category.SelectedValue) +
            "%' and isnull(A.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 +
            "' and A.Dim_category like '" + Convert.ToString(cmb_DimCategory.SelectedValue) +
            "%' and C.Branch_code like '" + UC_Branch.ID.Text +
            "%' and C.acc_no like '" + Uc_Acc.ID.Text +
            "%' and A.group_code like '" + Uc_Group.ID.Text +
            "%' and isnull(C.LC_ACC_NO,'') like '" + Lc_Acc.ID.Text +
            "%'	and A.Item_No  like '" + UcItem.ID.Text +
            "%' group by C.acc_no, P.PAYER_NAME");

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

                //rpt.SetDataSource(dal.getDataTabl("sales_by_Acc", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["decimal_"].Text = "'" + Properties.Settings.Default.digitNo_+ "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المشتريات موزع بالموردين'";
                
            //}
            //catch
            //{ }

        }
    

        private void button15_Click(object sender, EventArgs e)
        {
            try
            {
                groupBox1.Visible = false;
                double T1, T2;
                if (thick_1.Text == "")
                { T1 = 0; }
                else { T1 = Convert.ToDouble(thick_1.Text); }
                if (thick_2.Text == "" || thick_2.Value == 0)
                { T2 = 10000; }
                else { T2 = Convert.ToDouble(thick_2.Text); }

                if (payment_type.SelectedIndex == 0)
                {
                    pay_code = "";
                }
                else if (payment_type.SelectedIndex == 1)
                {
                    pay_code = "11";
                }
                else if (payment_type.SelectedIndex == 2)
                {
                    pay_code = "2";
                }



                RPT.rpt_Sales_byAcc rpt = new RPT.rpt_Sales_byAcc();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();



                dt1 = (dal.getDataTabl("sales_by_Acc_", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));

                ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);

                //rpt.SetDataSource(dal.getDataTabl("sales_by_Acc", dTP1.Value.Date, dTP2.Value.Date, pay_code, Convert.ToString(category.SelectedValue), T1, T2, Convert.ToString(cmb_DimCategory.SelectedValue), "xs", UC_Branch.ID.Text, Uc_Acc.ID.Text, db1));
                crystalReportViewer1.ReportSource = rpt;
                rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["From_thick"].Text = "'" + thick_1.Text + "'";
                rpt.DataDefinition.FormulaFields["To_thick"].Text = "'" + thick_2.Text + "'";
                rpt.DataDefinition.FormulaFields["Catogery"].Text = "'" + category.Text + "'";
                rpt.DataDefinition.FormulaFields["Dim_category"].Text = "'" + cmb_DimCategory.Text + "'";
                rpt.DataDefinition.FormulaFields["payment_"].Text = "'" + payment_type.Text + "'";
                rpt.DataDefinition.FormulaFields["Type_"].Text = "'تقرير المبيعات موزع بالعميل'";
        
            }
            catch
            { }

        }

        private void txtNU_TextChanged(object sender, EventArgs e)
        {

        }

        private void frm_rpt_Purchases_Load(object sender, EventArgs e)
        {
            //this.skinEngine1.SkinFile = "Skins/Eighteen.ssk";
       
    }

        private void button1_Click_1(object sender, EventArgs e)
        {
            groupBox1.Visible = false;
            double T1, T2;
            if (thick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(thick_1.Text); }
            if (thick_2.Text == "" || thick_2.Value == 0)
            { T2 = 10000; }
            else { T2 = Convert.ToDouble(thick_2.Text); }



            if (payment_type.SelectedIndex == 0)
            {
                pay_code = "";
            }
            else if (payment_type.SelectedIndex == 1)
            {
                pay_code = "11";
            }
            else if (payment_type.SelectedIndex == 2)
            {
                pay_code = "2";
            }

            RPT.rpt_purchase rpt = new RPT.rpt_purchase();
            //  DataTable dt_ =dal.getDataTabl("Get_local_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,UC_Acc.ID.Text,UC_Branch.ID.Text,UC_PayType.ID.Text,KM_Value,dal.db1);

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
                and cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + dTP2.Value.ToString("yyyy-MM-dd") + 
                "' and A.Payment_Type like '" + pay_code + 
                "%' and s.Category like '" + Convert.ToString(category.SelectedValue) + 
                "%' and isnull(S.UnitDepth,0) BETWEEN '" + T1 + "' AND '" + T2 + 
                "' and S.Dim_category like '" + Convert.ToString(cmb_DimCategory.SelectedValue) + 
                "%' and A.Branch_code like '" + UC_Branch.ID.Text + 
                "%' and A.acc_no like '" + Uc_Acc.ID.Text + 
                "%' and S.group_code like '" + Uc_Group.ID.Text + 
                "%' and isnull(A.LC_ACC_NO,'') like '" + Lc_Acc.ID.Text +
                "%'	and S.Item_No  like '" + UcItem.ID.Text +
                "%' group by   A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME, A.Inv_no, A.Inv_date, p.COSTMER_K_M_NO, A.Transaction_code, A.Branch_code," +
              " A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, C.Payment_name, A.Acc_no order by a.Branch_code, A.Ser_no");

            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المشتريات بالفواتير'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + Uc_Acc.ID.Text + " - '+'" + Uc_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Lc_"].Text = " '" + Lc_Acc.ID.Text + " - '+'" + Lc_Acc.Desc.Text + "'";

            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + payment_type.Text + "'";
            
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}

