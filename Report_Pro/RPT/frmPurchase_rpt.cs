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
    public partial class frmPurchase_rpt : Form
    {
        string KM_Value;
        string P_Kind ;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmPurchase_rpt()
        {
            InitializeComponent();

            comboBox1.SelectedIndex = 2;
          
        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (comboBox1.SelectedIndex == 0) { P_Kind = "1"; }
            else if (comboBox1.SelectedIndex == 1) { P_Kind = "2"; }
            else if (comboBox1.SelectedIndex == 2) { P_Kind = "3"; }
            //else { P_Kind="3"; }
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = false;
            RPT.rpt_purchase rpt = new RPT.rpt_purchase();
            //  DataTable dt_ =dal.getDataTabl("Get_local_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,UC_Acc.ID.Text,UC_Branch.ID.Text,UC_PayType.ID.Text,KM_Value,dal.db1);

         DataTable dt_ = dal.getDataTabl_1(@"SELECT A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_ADD-D.QTY_TAKE) As Qty_Add
        , ROUND(sum((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price) - sum(((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price * D.total_disc) / 100), 2) AS Value
        , sum(D.TAX_IN) - sum(D.TAX_OUT) As Vat, A.Inv_no, A.Inv_date, p.COSTMER_K_M_NO, A.Transaction_code, A.Branch_code,
        A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, p.adress, C.Payment_name, A.Acc_no, A.CUSTOM_NO, A.Storing_Expire_Date

        FROM    wh_inv_data as A
        INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
        INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
        INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
        INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
        AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
        inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
        
        WHERE A.Transaction_code like  CASE WHEN '" + P_Kind + "' = 2 THEN 'xpe%' else  'xp%'  END " +
        " and A.Transaction_code <> CASE WHEN '" + P_Kind + "' = 1 THEN 'xpe' else  ''  END" +
        " and CAST(A.G_date AS DATE) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' AND '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and a.Acc_no like '" + UC_Acc.ID.Text
        + "%'and a.Branch_code like '" + UC_Branch.ID.Text + "%' and a.Payment_Type like '" + UC_PayType.ID.Text
        + "%' group by    A.Ser_no, A.Transaction_code, A.Branch_code, A.G_date, A.Payment_Type, A.Inv_no, A.Inv_date, A.acc_serial_no, A.NetAmount," +
        " P.PAYER_NAME, B.branch_name, C.Payment_name, A.Acc_no, T.INV_NAME, A.CUSTOM_NO, A.Storing_Expire_Date, p.payer_l_name, p.adress, p.COSTMER_K_M_NO order by a.Branch_code, A.Ser_no");

            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المشتريات - '+ '" + comboBox1.Text + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + UC_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + UC_PayType.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["vat_val"].Text = "'الجميع'";

            
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void frmPurchase_rpt_Load(object sender, EventArgs e)
        {

        }

        private void uC_Branch1_Load(object sender, EventArgs e)
        {
            UC_Acc1.branchID.Text = UC_Branch1.ID.Text;
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
         
        groupPanel1.Visible = false;
            RPT.rpt_purchase_details rpt = new RPT.rpt_purchase_details();
            DataSet ds1 = new DataSet();
            DataTable dt1 = new DataTable();
            //rpt.SetDataSource(dal.getDataTabl("Get_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,UC_Acc.ID.Text,UC_Branch.ID.Text,UC_PayType.ID.Text,dal.db1));

            dt1 = dal.getDataTabl_1(@"SELECT A.ser_no,d.ITEM_NO,s.descr,sum(D.QTY_ADD) As Qty_Add,sum(D.QTY_TAKE) As Qty_Take
				,ROUND(sum((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price)-sum(((D.QTY_ADD-D.QTY_TAKE)*D.Local_Price*D.total_disc)/100),2) AS Value
				,sum(D.TAX_IN)-sum(D.TAX_OUT) As Vat,sum((D.QTY_ADD-D.QTY_TAKE)*s.Weight) as Weight, A.Transaction_code
				,A.Branch_code,A.Payment_Type,T.INV_NAME,p.payer_l_name,C.Payment_name,A.Acc_no,B.branch_name,a.G_date
			 
                FROM wh_inv_data as A
                INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
				INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
				INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
				INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
				AND A.Branch_code =D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
				inner join WH_INV_TYPE As T  on T.INV_CODE=A.Transaction_code
				inner join wh_main_master As S  on D.ITEM_NO=s.item_no

                WHERE (A.Transaction_code like  CASE WHEN '" + P_Kind+"' = 2 THEN 'xpe%' else  'xp%'  END )" +
                " and A.Transaction_code <> CASE WHEN '" + P_Kind + "' = 1 THEN 'xpe' else  ''  END " +
                "and CAST(A.G_date AS DATE) BETWEEN '"+FromDate.Value.ToString("yyyy-MM-dd")+"' AND '"+ToDate.Value.ToString("yyyy-MM-dd")+
                "' and a.Acc_no like '"+UC_Acc.ID.Text+"%'  and a.Branch_code like '"+UC_Branch.ID.Text+"%' and a.Payment_Type like '"+UC_PayType.ID.Text+"%' " +
                "group by A.ser_no,d.ITEM_NO,s.descr,A.Transaction_code,A.Branch_code,A.Payment_Type,A.NetAmount," +
                "P.PAYER_NAME,B.branch_name,C.Payment_name,A.Acc_no,T.INV_NAME,p.payer_l_name,B.branch_name,a.G_date");
            ds1.Tables.Add(dt1);
            ds1.WriteXmlSchema("schema1.xml");
            rpt.SetDataSource(ds1);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'تفاصيل المشتريات - '+ '" + comboBox1.Text + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + UC_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + UC_PayType.Desc.Text + "'";
            

        }

      
        private void UC_Branch_Load(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = false;
            RPT.rpt_purchase rpt = new RPT.rpt_purchase();
            //  DataTable dt_ =dal.getDataTabl("Get_local_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,UC_Acc.ID.Text,UC_Branch.ID.Text,UC_PayType.ID.Text,KM_Value,dal.db1);

            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_ADD-D.QTY_TAKE) As Qty_Add
        , ROUND(sum((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price) - sum(((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price * D.total_disc) / 100), 2) AS Value
        , sum(D.TAX_IN) - sum(D.TAX_OUT) As Vat, A.Inv_no, A.Inv_date, p.COSTMER_K_M_NO, A.Transaction_code, A.Branch_code,
        A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, p.adress, C.Payment_name, A.Acc_no, A.CUSTOM_NO, A.Storing_Expire_Date

        FROM    wh_inv_data as A
        INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
        INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
        INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
        INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
        AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
        inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
        
        WHERE A.Transaction_code like  CASE WHEN '" + P_Kind + "' = 2 THEN 'xpe%' else  'xp%'  END " +
           " and A.Transaction_code <> CASE WHEN '" + P_Kind + "' = 1 THEN 'xpe' else  ''  END" +
           " and CAST(A.G_date AS DATE) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' AND '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and a.Acc_no like '" + UC_Acc.ID.Text
           + "%'and a.Branch_code like '" + UC_Branch.ID.Text + "%' and a.Payment_Type like '" + UC_PayType.ID.Text
           + "%' and  (isnull(D.TAX_IN,0)+isnull(D.TAX_OUT,0)) <> 0  " +
           " group by    A.Ser_no, A.Transaction_code, A.Branch_code, A.G_date, A.Payment_Type, A.Inv_no, A.Inv_date, A.acc_serial_no, A.NetAmount," +
           " P.PAYER_NAME, B.branch_name, C.Payment_name, A.Acc_no, T.INV_NAME, A.CUSTOM_NO, A.Storing_Expire_Date, p.payer_l_name, p.adress, p.COSTMER_K_M_NO order by a.Branch_code, A.Ser_no");

            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "' اجمالي المشتريات الضريبية - '+ '" + comboBox1.Text + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + UC_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + UC_PayType.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["vat_val"].Text = "'مشتريات ضريبية'";

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = false;
            RPT.rpt_purchase rpt = new RPT.rpt_purchase();
            //  DataTable dt_ =dal.getDataTabl("Get_local_purchase_", FromDate.Value.Date, ToDate.Value.Date, P_Kind,UC_Acc.ID.Text,UC_Branch.ID.Text,UC_PayType.ID.Text,KM_Value,dal.db1);

            DataTable dt_ = dal.getDataTabl_1(@"SELECT A.Ser_no,B.branch_name,A.G_date,p.PAYER_NAME,sum(D.QTY_ADD-D.QTY_TAKE) As Qty_Add
        , ROUND(sum((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price) - sum(((D.QTY_ADD - D.QTY_TAKE) * D.Local_Price * D.total_disc) / 100), 2) AS Value
        , sum(D.TAX_IN) - sum(D.TAX_OUT) As Vat, A.Inv_no, A.Inv_date, p.COSTMER_K_M_NO, A.Transaction_code, A.Branch_code,
        A.Payment_Type, T.INV_NAME, A.acc_serial_no, p.payer_l_name, p.adress, C.Payment_name, A.Acc_no, A.CUSTOM_NO, A.Storing_Expire_Date

        FROM    wh_inv_data as A
        INNER JOIN payer2 As P ON A.Acc_no = P.ACC_NO AND A.Acc_Branch_code = P.BRANCH_code
        INNER JOIN wh_BRANCHES As B ON A.Branch_code = B.Branch_code
        INNER JOIN wh_Payment_type As C ON A.Payment_Type = C.Payment_type
        INNER JOIN wh_material_transaction As D ON A.Ser_no = D.SER_NO
        AND A.Branch_code = D.Branch_code AND A.Transaction_code = D.TRANSACTION_CODE AND A.Cyear = D.Cyear
        inner join WH_INV_TYPE As T  on T.INV_CODE = A.Transaction_code
        
        WHERE A.Transaction_code like  CASE WHEN '" + P_Kind + "' = 2 THEN 'xpe%' else  'xp%'  END " +
           " and A.Transaction_code <> CASE WHEN '" + P_Kind + "' = 1 THEN 'xpe' else  ''  END" +
           " and CAST(A.G_date AS DATE) between '" + FromDate.Value.ToString("yyyy/MM/dd") + "' AND '" + ToDate.Value.ToString("yyyy/MM/dd") + "' and a.Acc_no like '" + UC_Acc.ID.Text
           + "%'and a.Branch_code like '" + UC_Branch.ID.Text + "%' and a.Payment_Type like '" + UC_PayType.ID.Text
           + "%' and  (isnull(D.TAX_IN,0)+isnull(D.TAX_OUT,0)) = 0  " +
           " group by    A.Ser_no, A.Transaction_code, A.Branch_code, A.G_date, A.Payment_Type, A.Inv_no, A.Inv_date, A.acc_serial_no, A.NetAmount," +
           " P.PAYER_NAME, B.branch_name, C.Payment_name, A.Acc_no, T.INV_NAME, A.CUSTOM_NO, A.Storing_Expire_Date, p.payer_l_name, p.adress, p.COSTMER_K_M_NO order by a.Branch_code, A.Ser_no");

            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Type_"].Text = "'اجمالي المشتريات الصفرية - '+ '" + comboBox1.Text + "'";
            rpt.DataDefinition.FormulaFields["Acc_"].Text = "'" + UC_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Branch_"].Text = "'" + UC_Branch.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Payment_"].Text = "'" + UC_PayType.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["vat_val"].Text = "'مشتريات صفرية'";


        }
    }
}
