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
    public partial class frm_rpt_preform : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_rpt_preform()
        {
            InitializeComponent();

            fromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            toDate.Value = DateTime.Today;
            From_expiryDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            To_expiryDate.Value = DateTime.Today;
            From_lastShipDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            To_lastShipDate.Value = DateTime.Today;
            From_openDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            To_openDate.Value = DateTime.Today;



        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void panelEx1_Click(object sender, EventArgs e)
        {

        }

        private void uC_Items1_Load(object sender, EventArgs e)
        {

        }

        private void btn2_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            RPT.rpt_preforma rpt = new RPT.rpt_preforma();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"select p.Ser_no,p.G_DATE,p.Branch_code,p.Cyear,p.Acc_no,p.LC_ACC_NO,p.LC_NO,Lc_Date,LC_EXPIRE_DATE,p.Perform_invoice_date,p.Cargo_date,Factory,p.Country,P.Estihkak_Dayes,x.PAYER_NAME,C.Currency_Name,pt.Forign_price,pt.ITEM_NO,QTY_ADD,descr
            ,sum(t.qty) as qty ,sum(t.Forign_Value) as F_Value ,sum(t.Local_Value) as L_Value
            from wh_inv_data_Ext_Perform as P 
            inner join wh_MATERIAL_TRANSACTION_Ext_Perform as PT on p.Ser_no = pt.SER_NO and 
            p.Branch_code = pt.Branch_code and p.Cyear = pt.Cyear inner join 
            wh_main_master as M on M.item_no = pt.ITEM_NO 
            inner join Wh_Currency as C on c.Currency_Code=pt.FORIN_TYPE 
           inner join payer2 as x on x.acc_no=p.acc_no and x.branch_code=p.branch_code
            inner join( SELECT  LC_ACC_NO, a.Ser_no, a.cyear, a.Branch_code, ITEM_NO, sum(QTY_ADD) as qty, sum(QTY_ADD * Forign_price) as Forign_Value, sum(QTY_ADD * Local_Price) as Local_Value 
            FROM wh_inv_data_Ext as A  inner join wh_MATERIAL_TRANSACTION_Ext As B 
            on a.Ser_no = b.SER_NO and a.Branch_code = b.Branch_code and a.Cyear = b.Cyear 
            where  a.Branch_code like '" + Branch.ID.Text+"%' group by  LC_ACC_NO, a.Ser_no, a.cyear, a.Branch_code, ITEM_NO) as t on  t.LC_ACC_NO = p.LC_ACC_NO and t.Branch_code = p.Branch_code and " +
            "t.ITEM_NO = pt.ITEM_NO where cast(p.G_DATE as date) between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' and t.LC_ACC_NO like '" + Acc.ID.Text+
            "'+'%' and cast(LC_EXPIRE_DATE as date) between '" + From_expiryDate.Value.ToString("yyyy-MM-dd") +"' and '" + To_expiryDate.Value.ToString("yyyy-MM-dd")+
            "' and cast(p.Cargo_date as date) between '" + From_lastShipDate.Value.ToString("yyyy-MM-dd") + "' and '" + To_lastShipDate.Value.ToString("yyyy-MM-dd") +
            "' and cast(p.Lc_Date as date) between '" + From_openDate.Value.ToString("yyyy-MM-dd") + "' and '" + To_openDate.Value.ToString("yyyy-MM-dd") +
            "' group by p.Ser_no,p.G_DATE,p.Branch_code,p.Cyear,p.Acc_no,p.LC_ACC_NO,p.LC_NO,Lc_Date,LC_EXPIRE_DATE,p.Perform_invoice_date,p.Cargo_date,Factory,p.Country,P.Estihkak_Dayes,x.PAYER_NAME,C.Currency_Name,pt.Forign_price,pt.ITEM_NO,QTY_ADD,descr order by p.g_date ");

            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            groupPanel1.Visible = false;
            Cursor.Current = Cursors.Default;


        }

        private void btn1_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible = true;
        }

        private void frm_rpt_preform_Load(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;

            RPT.rpt_LcsData rpt = new RPT.rpt_LcsData();

            DataSet1 ds = new DataSet1();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1(@"select p.Ser_no,p.G_DATE,branch_name,p.Cyear,p.Acc_no,p.LC_ACC_NO,p.LC_NO,Lc_Date,LC_EXPIRE_DATE,p.Perform_invoice_date,p.Cargo_date,Factory,p.Country,P.Estihkak_Dayes,x.PAYER_NAME,C.Currency_Name,sum(QTY_ADD) As Qty_ ,sum(pt.Forign_price*QTY_ADD) As Value_
            from wh_inv_data_Ext_Perform as P 
            inner join wh_MATERIAL_TRANSACTION_Ext_Perform as PT on p.Ser_no = pt.SER_NO and p.Branch_code = pt.Branch_code and p.Cyear = pt.Cyear 
            inner join wh_main_master as M on M.item_no = pt.ITEM_NO 
            inner join Wh_Currency as C on c.Currency_Code=pt.FORIN_TYPE 
            inner join payer2 as x on x.acc_no=p.acc_no and x.branch_code=p.branch_code
            inner join wh_BRANCHES As WB on WB.Branch_code=p.Branch_code       	
            where cast(p.G_DATE as date) between '" + fromDate.Value.ToString("yyyy/MM/dd") + "' and '" + toDate.Value.ToString("yyyy/MM/dd") + "' and P.LC_ACC_NO like '" + Acc.ID.Text +
            "%' and cast(LC_EXPIRE_DATE as date) between '" + From_expiryDate.Value.ToString("yyyy-MM-dd") + "' and '" + To_expiryDate.Value.ToString("yyyy-MM-dd") +
            "' and cast(p.Cargo_date as date)  between'" + From_lastShipDate.Value.ToString("yyyy-MM-dd") + "' and '" + To_lastShipDate.Value.ToString("yyyy-MM-dd") +
            "' and cast(p.Lc_Date as date) between '" + From_openDate.Value.ToString("yyyy-MM-dd") + "' and '" + To_openDate.Value.ToString("yyyy-MM-dd") + 
            "' group by p.Ser_no, p.G_DATE, branch_name, p.Cyear, p.Acc_no, p.LC_ACC_NO, p.LC_NO, Lc_Date, LC_EXPIRE_DATE, p.Perform_invoice_date, p.Cargo_date, Factory, p.Country, P.Estihkak_Dayes, x.PAYER_NAME, C.Currency_Name order by p.g_date  ");

            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            crystalReportViewer1.ReportSource = rpt;
            groupPanel1.Visible = false;
            Cursor.Current = Cursors.Default;

        }
    }
}
