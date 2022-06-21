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
    public partial class frm_rpt_Galvanaize : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_rpt_Galvanaize()
        {
            InitializeComponent();
        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = false;

            RPT.rpt_Galvanaize_rpt rpt = new RPT.rpt_Galvanaize_rpt();
            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"select A.*, sum(b.QTY_ADD * b.Local_Price) from(SELECT[Ser_no]
        ,Branch_code,Transaction_code,Cyear,G_date,Acc_no,Payment_Type,Acc_Galvanize
        ,GALVANISE_EXPENSIVE_AMOUNT,Sales_man_Id,Inv_no,Inv_date,acc_serial_no,Inv_Notes,FACTORY_INV
        ,case when LEN(FACTORY_INV) > 0 then SUBSTRING(FACTORY_INV, 1, CHARINDEX('/', FACTORY_INV) - 1) else '' end as PO
        FROM wh_inv_data) AS A
        inner join wh_material_transaction AS B
        on a.Ser_no = B.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code
        where a.Transaction_code = 'xti' and a.Acc_Galvanize like '"+ Acc_.ID.Text+ "%' and a.Branch_code like '" + Branch_.ID.Text + "%' " +
        " and cast(A.g_date as date ) between '"+ FromDate.Value.ToString("yyyy-MM-dd")+ "' and '" + ToDate.Value.ToString("yyyy-MM-dd") + "' " +
        " group by a.Ser_no, a.Branch_code, a.Transaction_code, a.Cyear, a.G_date, a.Acc_no" +
        ",a.Payment_Type, a.Acc_Galvanize, a.GALVANISE_EXPENSIVE_AMOUNT, a.Sales_man_Id, a.Inv_no" +
        ",a.Inv_date, a.acc_serial_no, a.Inv_Notes, a.FACTORY_INV, a.PO");

        ds.Tables.Add(dt1);
        //ds.WriteXmlSchema("schema1.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;

        }

        private void btnOption_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = true;
        }

        private void groupPanel2_Click(object sender, EventArgs e)
        {

        }
    }
}
