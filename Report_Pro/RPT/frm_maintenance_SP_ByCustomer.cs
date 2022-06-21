using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_maintenance_SP_ByCustomer : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_maintenance_SP_ByCustomer()
        {
            InitializeComponent();
        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = true;

        }

        private void button6_Click(object sender, EventArgs e)
        {
            //try
            //{
                groupPanel2.Visible = false;

                
                RPT.rpt_Maintenance_SP_ByCustomer rpt = new rpt_Maintenance_SP_ByCustomer();
                DataTable dt_ = dal.getDataTabl_1(@"select A.ser_no,A.Branch_code,A.Cyear,A.Transaction_code,A.G_date,A.Acc_no,A.Payment_Type,A.Sales_man_Id,A.Inv_no,A.Inv_date,a.Inv_Notes,A.Phone,A.Adress,A.acc_serial_no,
                B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.Unit,B.Local_Price,isnull(B.TAX_IN,0)as TAX_IN ,isnull(B.TAX_OUT,0)as TAX_OUT , round(b.total_disc*B.local_price*QTY_TAKE/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,
                m.descr,m.Descr_eng, br.branch_name,BR.WH_E_NAME,PT.Payment_name 
                ,(select case when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) between '2018-01-01' and '2020-06-30'   then 5  when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) > '2020-06-30' then 15  else 0 end)as VatRatio
       
                from wh_inv_data As A 
                inner join wh_material_transaction As B on a.Ser_no = b.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code 
                inner join payer2 As P on a.Acc_no = p.ACC_NO and a.Acc_Branch_code = p.BRANCH_code 
                left join(select* from payer2)as p2 on p2.ACC_NO = a.LC_ACC_NO and a.Acc_Branch_code = p2.BRANCH_code 
                inner join wh_main_master as M on M.item_no = b.ITEM_NO 
                inner join wh_BRANCHES As BR on BR.Branch_code = a.Branch_code 
                inner join wh_Payment_type as PT on A.Payment_Type=PT.Payment_type 
                where isnull(A.acc_serial_no,'')<>'' and a.Acc_no like '" + Acc.ID.Text + "%' and a.Transaction_code = 'xwo' and a.Branch_code = 'A2319' and a.Cyear = '15' and CAST(A.G_DATE as date ) between '" + dtp1.Value.ToString("yyyy/MM/dd") + "' and '" + dtp2.Value.ToString("yyyy/MM/dd") + "' ");




                //DataSet ds = new DataSet();
                //ds.Tables.Add(dt_);
                ////ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(dt_);
                rpt.DataDefinition.FormulaFields["from_date"].Text = "'" + dtp1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["to_date"].Text = "'" + dtp2.Value.ToString("yyyy/MM/dd") + "'";
                crystalReportViewer1.ReportSource = rpt;
            //}
            //catch
            //{

            //}


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            try
            {
                groupPanel2.Visible = false;

                DataSet ds = new DataSet();
                RPT.rpt_Maintenance_SP_ByCustomer_JO rpt = new rpt_Maintenance_SP_ByCustomer_JO();
                DataTable dt_ = dal.getDataTabl_1(@"SELECT C.Ser_no as ser,B.Ser_no,B.Deleviry_date,B.acc_serial_no,(A.QTY_TAKE-A.QTY_ADD) as qty_,A.Local_Price,((A.QTY_TAKE-A.QTY_ADD)*A.Local_Price) as subTot_ ,(A.TAX_OUT-A.TAX_IN) as Tax_ 
      FROM wh_MATERIAL_TRANSACTION_MAINT As A
      inner join wh_inv_data_MAINT as B on 
      A.SER_NO=B.SER_NO

	 inner join  wh_inv_data as C on C.jop_order_no = b.Ser_no
      and A.Branch_code =B.Branch_code
      and A.TRANSACTION_CODE=B.TRANSACTION_CODE
      and A.Cyear=B.Cyear
	  where A.ITEM_NO<>'ser' and B.Acc_no like '" + Acc.ID.Text + "%' and CAST(B.Deleviry_date as date ) between '" + dtp1.Value.ToString("yyyy/MM/dd") + "' and '" + dtp2.Value.ToString("yyyy/MM/dd") + "' ");


                ds.Tables.Add(dt_);


                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                rpt.DataDefinition.FormulaFields["from_date"].Text = "'" + dtp1.Value.ToString("yyyy/MM/dd") + "'";
                rpt.DataDefinition.FormulaFields["to_date"].Text = "'" + dtp2.Value.ToString("yyyy/MM/dd") + "'";
                crystalReportViewer1.ReportSource = rpt;
            }
            catch
            {

            }
        }
    }
}
