using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
//using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_rpt_MonthelySales : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_rpt_MonthelySales()
        {
            InitializeComponent();
        }

        private void rBtnAll_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {

            Cursor.Current = Cursors.WaitCursor;
            //try
            //{
                groupPanel2.Visible = false;
                string X = "1";
                string h_txt = "Monthly Sales By Branch";
                if (rBtnAll.Checked ==true) { X = "1";
                    h_txt = "Monthly Sales By Branch";
                }
                if (rBtnS.Checked==true) { X = "2";
                    h_txt = "Monthly Sales By Branch - Sister Companies";
                }
                if (rBtnWithoutS.Checked ==true) { X = "3";
                    h_txt = "Monthly Sales By Branch - With Out Sister Companies";
                }



                RPT.rpt_M_BranchSales rpt = new RPT.rpt_M_BranchSales();

                DataSet1 ds = new DataSet1();
                DataTable dt1 = new DataTable();


            //if (X == "1")
            {
                dt1 = (dal.getDataTabl_1(@" SELECT * from ( SELECT H.branch_code,H.branch_name
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
                    ,Abs(Round(SUM(CASE WHEN   D.Transaction_code like'XS%'  THEN ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price) - ((D.QTY_TAKE-D.QTY_ADD) * D.Local_Price * D.total_disc) / 100  ELSE 0 END),0)) AS 'tot_'

                    FROM  wh_material_transaction As D
                    inner join wh_main_master As A on A.item_no=D.ITEM_NO
                    inner join wh_inv_data As C on  C.Ser_no = D.SER_NO AND C.Branch_code =D.Branch_code 
                    AND  C.Transaction_code = D.TRANSACTION_CODE AND C.Cyear = D.Cyear
                    inner join wh_BRANCHES As H on H.Branch_code=d.Branch_code					 
                    where cast(D.G_date as date) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") +
                "'  and A.Company_code='A'   And H.branch_code like '" + UC_Branch.ID.Text + "%' " +
                "and c.acc_no not like case when '" + X + "'= '3' then '123998%' else '' end and c.acc_no like case when '" + X + "'=2 then '123998%' else '%' end  " +
                "GROUP BY H.branch_code,H.branch_name )as t1 where t1.tot_ <>0"));
            }
                ds.Tables.Add(dt1);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                crystalReportViewer1.ReportSource = rpt;

                rpt.DataDefinition.FormulaFields["FromDate"].Text = "'" + dTP1.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["ToDate"].Text = "'" + dTP2.Value.ToString("dd/MM/yyyy") + "'";
                rpt.DataDefinition.FormulaFields["Rep_Head"].Text = "'"+h_txt+"'";
                rpt.DataDefinition.FormulaFields["company_name"].Text = "'" + Properties.Settings.Default.head_txt_EN + "'";
                rpt.DataDefinition.FormulaFields["Branch_Name"].Text = "'" + Properties.Settings.Default.Branch_txt_EN + "'";
            //}
            //catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //}
            Cursor.Current = Cursors.Default;
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = true;
        }

        private void frm_rpt_MonthelySales_Load(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }
    }
}
