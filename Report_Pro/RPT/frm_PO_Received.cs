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
    public partial class frm_PO_Received : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public string _branch;
        public string _PO;
        public string _year;
        DataTable dt_inv;
        DataTable dt_inv_total;
        int currencyNo = 2;
        List<CurrencyInfo> currencies = new List<CurrencyInfo>();

        public frm_PO_Received()
        {
            InitializeComponent();
        }

        private void frm_PO_Received_Load(object sender, EventArgs e)
        {
            get_PO_Received();
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Syria));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.UAE));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.s));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Tunisia));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Gold));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Bahrain));
            currencies.Add(new CurrencyInfo(CurrencyInfo.Currencies.Oman));
            string currency = Properties.Settings.Default.Currency;
            if (!(currency == "s"))
            {
                if (!(currency == "BH"))
                {
                    if (!(currency == "OM"))
                    {
                        if (!(currency == "DR"))
                            return;
                        currencyNo = 1;
                    }
                    else
                        currencyNo = 6;
                }
                else
                    currencyNo = 5;
            }
            else
                currencyNo = 2;


           
        }
        private void get_PO_Received()
        {
             DataTable dt_LP = dal.getDataTabl_1(@"select  B.po_no,A.ser_no,A.item_no,M.descr,M.Descr_eng,M.Unit,isnull(M.weight,0) as weight ,A.G_DATE,(A.QTY_ADD-A.Qty_take) as Qty ,A.Local_Price,P.PAYER_NAME,P.payer_l_name,C.branch_name,C.WH_E_NAME,A.Branch_code,a.Cyear, A.TRANSACTION_CODE 
            from wh_material_transaction as A
            inner join wh_inv_data as B on A.SER_NO=B.Ser_no and A.TRANSACTION_CODE=B.TRANSACTION_CODE and a.Branch_code=b.Branch_code and a.Cyear=b.Cyear
            inner join payer2 as P on p.ACC_NO=b.Acc_no and b.Acc_Branch_code=p.BRANCH_code 
            inner join wh_BRANCHES As C on A.Branch_code=C.Branch_code 
            inner join wh_main_master AS M on M.item_no = A.ITEM_NO           
where B.po_no ='" + _PO + "' and A.Branch_code = '" + _branch+ "' and A.Cyear = '"+_year+"' and A.TRANSACTION_CODE like 'Xp%' order by G_DATE desc");



            if (dt_LP.Rows.Count > 0)
            {

                dgv_LP.RowCount = dt_LP.Rows.Count;

                for (int ii = 0; ii < dgv_LP.RowCount; ii++)
                {
                    dgv_LP.Rows[ii].Cells[0].Value = dt_LP.Rows[ii]["po_no"].ToString();
                    dgv_LP.Rows[ii].Cells[2].Value = dt_LP.Rows[ii]["ser_no"].ToString();
                    dgv_LP.Rows[ii].Cells[3].Value = dt_LP.Rows[ii]["G_DATE"];
                    dgv_LP.Rows[ii].Cells[4].Value = dt_LP.Rows[ii]["item_no"];
                    if (Properties.Settings.Default.lungh == "0")
                    {
                        dgv_LP.Rows[ii].Cells[1].Value = dt_LP.Rows[ii]["branch_name"].ToString();
                        dgv_LP.Rows[ii].Cells[5].Value = dt_LP.Rows[ii]["descr"];
                        dgv_LP.Rows[ii].Cells[9].Value = dt_LP.Rows[ii]["PAYER_NAME"].ToString();
                    }
                    else
                    {
                        dgv_LP.Rows[ii].Cells[1].Value = dt_LP.Rows[ii]["WH_E_NAME"].ToString();
                        dgv_LP.Rows[ii].Cells[5].Value = dt_LP.Rows[ii]["Descr_eng"];
                        dgv_LP.Rows[ii].Cells[9].Value = dt_LP.Rows[ii]["payer_l_name"].ToString();
                    }
                    dgv_LP.Rows[ii].Cells[6].Value = dt_LP.Rows[ii]["qty"];
                    dgv_LP.Rows[ii].Cells[7].Value = dt_LP.Rows[ii]["Local_Price"];


                    if (dt_LP.Rows[ii]["weight"].ToString().ToDecimal()>0)
                    {
                        dgv_LP.Rows[ii].Cells[8].Value = (Math.Round(dt_LP.Rows[ii]["Local_Price"].ToString().ToDecimal() / dt_LP.Rows[ii]["weight"].ToString().ToDecimal() * 1000, 0)).ToString("N0");
                    }
                    else
                    {
                        dgv_LP.Rows[ii].Cells[8].Value = 0;
                    }

                    dgv_LP.Rows[ii].Cells[10].Value = dt_LP.Rows[ii]["Branch_code"].ToString();
                    dgv_LP.Rows[ii].Cells[11].Value = dt_LP.Rows[ii]["Cyear"].ToString();
                    dgv_LP.Rows[ii].Cells[12].Value = dt_LP.Rows[ii]["TRANSACTION_CODE"].ToString();


                }
            }
            else
            {
                dgv_LP.DataSource = null;
                dgv_LP.Rows.Clear();
            }



        }

        private void dgv_LP_DoubleClick(object sender, EventArgs e)
        {
            // RPT.Rpt_inv rptInv = new RPT.Rpt_inv();

            RPT.print_PurchaseInv rptInv = new RPT.print_PurchaseInv();
            RPT.Form1 frm = new RPT.Form1();

            DataSet dataSet = new DataSet();
            getSalesInv(dgv_LP.CurrentRow.Cells[2].Value.ToString(), dgv_LP.CurrentRow.Cells[10].Value.ToString(), dgv_LP.CurrentRow.Cells[12].Value.ToString(), dgv_LP.CurrentRow.Cells[11].Value.ToString());
            dataSet.Tables.Add(dt_inv);
            //dataSet.WriteXmlSchema("schema_rpt.xml");
            rptInv.SetDataSource(dataSet);
            rptInv.DataDefinition.FormulaFields["Branch_"].Text = "'" + dgv_LP.CurrentRow.Cells[7].Value.ToString() + " - " + dgv_LP.CurrentRow.Cells[0].Value.ToString() + "'";
            getInvoiceTotal_purch(dgv_LP.CurrentRow.Cells[2].Value.ToString(), dgv_LP.CurrentRow.Cells[10].Value.ToString(), dgv_LP.CurrentRow.Cells[12].Value.ToString(), dgv_LP.CurrentRow.Cells[11].Value.ToString());
            ToWord toWord = new ToWord(Math.Abs(Convert.ToDecimal(dt_inv_total.Rows[0]["NetValue"].ToString())), currencies[currencyNo]);
            rptInv.DataDefinition.FormulaFields["NuToText_A"].Text = "'" + toWord.ConvertToArabic().ToString() + "'";

            frm.crystalReportViewer1.ReportSource = rptInv;
            frm.ShowDialog();
        }

        private void getSalesInv(string ser_, string branch_, string transaction_, string cyear_)

        {
            dt_inv = this.dal.getDataTabl_1(@"select A.ser_no,A.Branch_code,A.Cyear,A.Transaction_code,A.G_date,A.Acc_no,A.Payment_Type,A.Sales_man_Id,A.Inv_no,A.Inv_date,a.Inv_Notes,A.Phone,A.Adress,
            B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.Unit,B.Local_Price,isnull(B.TAX_IN,0)as TAX_IN ,isnull(B.TAX_OUT,0)as TAX_OUT , round(b.total_disc*B.local_price*QTY_TAKE/100,2) as disc_ ,p.PAYER_NAME,p.payer_l_name,p2.PAYER_NAME as lc_name ,p2.payer_l_name as lc_L_Name,
            m.descr,m.Descr_eng, br.branch_name,BR.WH_E_NAME,PT.Payment_name 
            ,(select top 1 vat_ratio from VAT_RATIO_MASTER where cast(A.G_date as date ) between date_of_vat and '" + DateTime.Today.ToString("yyyy-MM-dd") + "' order by date_of_vat desc) as VatRatio " +
            "from wh_inv_data As A " +
            "inner join wh_material_transaction As B on a.Ser_no = b.SER_NO and a.Cyear = b.Cyear and a.Transaction_code = b.TRANSACTION_CODE and a.Branch_code = b.Branch_code  " +
            "inner join payer2 As P on a.Acc_no = p.ACC_NO and a.Acc_Branch_code = p.BRANCH_code  " +
            "left join(select* from payer2)as p2 on p2.ACC_NO = a.LC_ACC_NO and a.Acc_Branch_code = p2.BRANCH_code  " +
            "inner join wh_main_master as M on M.item_no = b.ITEM_NO  " +
            "inner join wh_BRANCHES As BR on BR.Branch_code = a.Branch_code  " +
            "inner join wh_Payment_type as PT on A.Payment_Type=PT.Payment_type  " +
            "where a.SER_NO = '" + ser_ + "' and a.Transaction_code = '" + transaction_ + "' and a.Branch_code = '" + branch_ + "' and a.Cyear = '" + cyear_ + "'");
        }
        //(select case when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) between '2018-01-01' and '2020-06-30'   then 5  when B.K_M_TYPE_ITEMS =1 and CAST(B.G_DATE as date ) > '2020-06-30' then 15  else 0 end)as VatRatio

        private void getInvoiceTotal_purch(string ser_, string branch_, string transaction_, string cyear_)
        {
            dt_inv_total = dal.getDataTabl_1(@"select round(sum(b.QTY_TAKE*Local_Price),2) as TotalValue
            , round(sum(b.total_disc * B.local_price * QTY_ADD / 100), 2) as discount
            , round(sum(isnull(b.TAX_IN, 0)), 2) as tax
            , round(sum(b.QTY_ADD * Local_Price), 2) - round(sum(b.total_disc * B.local_price * QTY_ADD / 100), 2) + round(sum(isnull(b.TAX_IN, 0)), 2) as NetValue
             from wh_material_transaction as b
            where b.SER_NO = '" + ser_ + "'  and b.Transaction_code = '" + transaction_ + "' and b.Branch_code = '" + branch_ + "' and b.Cyear = '" + cyear_ + "'  " +
            "group by TRANSACTION_CODE,Branch_code,Cyear,SER_NO");
        }
    }
}
