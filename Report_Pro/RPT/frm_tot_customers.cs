using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_tot_customers : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_tot_customers()
        {
            InitializeComponent();
        }

        private void frm_tot_customers_Load(object sender, EventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            RPT.rpt_total_customers rpt = new RPT.rpt_total_customers();

//            DataTable dt_ = dal.getDataTabl_1(@"use cust_acc_wh

//SELECT p.Acc_no,p.PREV_NO,p.PAYER_NAME
//,isnull(sum(X2.Costmer_Charge),0) as trans
//,isnull(sum(X2.TAX_OUT),0) as trans_tax
//,isnull(sum(X.value_ ),0)+ isnull(sum(X1.Spare_Parts_value),0) as sp
//,isnull(sum(X1.Reparing_Value),0) as work_fess
//,isnull(sum(X1.K_M_Debit_TAX),0) as work_tax
   
//FROM (SELECT p.PREV_NO as PREV_NO,p.BRANCH_code
//,sum((B.QTY_TAKE-b.QTY_ADD)*b.Local_Price) as value_
//FROM wh_inv_data as A
//inner join wh_MATERIAL_TRANSACTION as B 
//on a.Ser_no=B.SER_NO and a.Branch_code=b.BRANCH_code and a.Transaction_code=b.TRANSACTION_CODE
//inner join payer2 as p on A.Acc_no=p.ACC_NO and a.Branch_code=b.BRANCH_code
//where A.Acc_no like '%' and CAST( A.G_date as date) between '2020-01-01' and  '2020-01-31' and (b.TRANSACTION_CODE='XWo' or b.TRANSACTION_CODE='XWI')  AND A.acc_serial_no IS NOT NULL
//group by  p.PREV_NO ,p.BRANCH_code)AS X

//FULL JOIN (SELECT b.PREV_NO,a.Branch_code as Branch_code  
//,sum([Reparing_Value]) as Reparing_Value
//,sum([Spare_Parts_value]) as Spare_Parts_value
//,sum([K_M_Debit_TAX]) as K_M_Debit_TAX
//FROM wh_inv_data_MAINT as A
//inner join payer2 as B on A.Acc_no=B.ACC_NO and a.Branch_code=b.BRANCH_code
//where A.Acc_no like '%' and CAST( Deleviry_date as date)  between '2020-01-01' and  '2020-01-31' 
//group by b.PREV_NO ,a.Branch_code) AS X1
//on X.PREV_NO = X1.PREV_NO 

//FULL JOIN (SELECT e.PREV_NO,E.PAYER_NAME,e.BRANCH_code
//,sum(a.[Costmer_Charge]) as Costmer_Charge
//,sum([TAX_OUT]) as TAX_OUT
//FROM C_Travel As A inner join payer2 AS E
//on A.Acc_no =E.ACC_NO and a.Branch_Code=E.BRANCH_code
//where  a.acc_no like '%' and  (cast( inv_date as date ) between '2020-01-01' and  '2020-01-31' )
//group by e.PREV_NO,E.PAYER_NAME,e.BRANCH_code) AS X2
//on X.PREV_NO = X2.PREV_NO 
//inner join payer2 as p
//on ((p.acc_no=X.PREV_NO or p.acc_no =X1.PREV_NO or p.acc_no =X2.PREV_NO ) and 
//(X1.Branch_code = p.BRANCH_code or X.Branch_code = p.BRANCH_code or X2.Branch_code = p.BRANCH_code)) 
//group by   p.Acc_no,p.PREV_NO,p.PAYER_NAME");

//            DataSet ds_ = new DataSet();
//            ds_.Tables.Add(dt_);


            rpt.SetDataSource(dal.getDataTabl("proc_1_", txt_AccId.Text, dTP1.Value.Date, dTP2.Value.Date));
            //rpt.SetDataSource(ds_);
            //ds_.WriteXmlSchema("schema_New_rpt.xml");
             //rpt.DataSource = ds;
             crystalReportViewer1.ReportSource = rpt;
            // rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            // rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            //// rpt.DataDefinition.FormulaFields["Acc_Id"].Text = "'" + txt_AccId.Text + "'";
            // rpt.DataDefinition.FormulaFields["cust_"].Text = "'" + txt_AccName.Text + "'";



        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            PL.frm_SearchAcc F = new PL.frm_SearchAcc();

            F.radioTransaction.Checked = true;
            F.ShowDialog();

            int ii = F.DGV1.CurrentCell.RowIndex;


           txt_AccId.Text = F.DGV1.Rows[ii].Cells[0].Value.ToString();
          txt_AccName.Text = F.DGV1.Rows[ii].Cells[1].Value.ToString();
        }

        private void txt_AccId_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_AccId_Leave(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_Search_Click_1(object sender, EventArgs e)
        {
            PL.frm_SearchAcc F = new PL.frm_SearchAcc();

            F.radioTransaction.Checked = true;
            F.ShowDialog();

            int ii = F.DGV1.CurrentCell.RowIndex;


            txt_AccId.Text = F.DGV1.Rows[ii].Cells[0].Value.ToString();
            txt_AccName.Text = F.DGV1.Rows[ii].Cells[1].Value.ToString();
        }

        private void txt_AccName_TextChanged(object sender, EventArgs e)
        {

        }

        private void txt_AccId_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void txt_AccId_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable dt_ = new DataTable();
                dt_ = dal.getDataTabl("Get_Acc_", txt_AccId.Text, "A2319", "cust_acc_wh");
                if (dt_.Rows.Count > 0)
                {
                    txt_AccName.Text = dt_.Rows[0][0].ToString();
                    dTP1.Focus();
                }
                else
                {
                    txt_AccId.Clear();
                    txt_AccName.Clear();
                    PL.frm_SearchAcc F = new PL.frm_SearchAcc();

                    F.radioTransaction.Checked = true;
                    F.ShowDialog();

                    int ii = F.DGV1.CurrentCell.RowIndex;


                    txt_AccId.Text = F.DGV1.Rows[ii].Cells[0].Value.ToString();
                    txt_AccName.Text = F.DGV1.Rows[ii].Cells[1].Value.ToString();

                }
            }
        }

        private void txt_AccId_Leave_1(object sender, EventArgs e)
        {
            DataTable dt_ = new DataTable();
            dt_ = dal.getDataTabl("Get_Acc_", txt_AccId.Text, "A2319","cust_acc_wh");
            if (dt_.Rows.Count > 0)
            {
                txt_AccName.Text = dt_.Rows[0][0].ToString();
            }
            else
            {
                txt_AccId.Clear();
                txt_AccName.Clear();
            }
        }
    }
}
