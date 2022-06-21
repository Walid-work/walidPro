using DevExpress.XtraEditors;
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
    public partial class frm_rpt_Po : XtraForm
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        string languh = Properties.Settings.Default.lungh;
        DataTable dt = new DataTable();
        DataTable dt_Q;
        public frm_rpt_Po()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnReport_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            // groupControl2.Visible = false;
            dgvPO.Dock = DockStyle.Fill; 

            
            getData();
            dgvPO.Rows.Clear();
            if (dt.Rows.Count > 0)
            {
                int B_rowscount = dt.Rows.Count;

                
                dgvPO.Rows.Add(B_rowscount+1);
                for (int i = 1; i <= (B_rowscount ); i++)
                {


                    dgvPO.Rows[i].Cells[0].Value = dt.Rows[i-1]["ser_no"];
                    if (languh == "0")
                    {
                        dgvPO.Rows[i].Cells[1].Value = dt.Rows[i - 1]["branch_name"];
                        dgvPO.Rows[i].Cells[3].Value = dt.Rows[i - 1]["payer_name"];
                        dgvPO.Rows[i].Cells[5].Value = dt.Rows[i - 1]["descr"];

                    }
                    else
                    {
                        dgvPO.Rows[i].Cells[1].Value = dt.Rows[i - 1]["WH_E_NAME"];
                        dgvPO.Rows[i].Cells[3].Value = dt.Rows[i-1]["payer_l_name"];
                        dgvPO.Rows[i].Cells[5].Value = dt.Rows[i-1]["Descr_eng"];
                    }

                    dgvPO.Rows[i].Cells[2].Value = Convert.ToDateTime(dt.Rows[i-1]["G_Date"]).ToString("yyyy/MM/dd");
                    dgvPO.Rows[i].Cells[4].Value = dt.Rows[i-1]["item_no"];
                    dgvPO.Rows[i].Cells[6].Value = dt.Rows[i-1]["Unit"];
                    dgvPO.Rows[i].Cells[7].Value = dt.Rows[i-1]["qty_take"].ToString().ToDecimal();
                    dgvPO.Rows[i].Cells[8].Value = dt.Rows[i-1]["qty_Add"].ToString().ToDecimal();
                    dgvPO.Rows[i].Cells[9].Value = dt.Rows[i-1]["Po_balance"].ToString().ToDecimal();
                    dgvPO.Rows[i].Cells[10].Value = dt.Rows[i-1]["Local_Price"].ToString().ToDecimal();
                    dgvPO.Rows[i].Cells[11].Value = dt.Rows[i-1]["TonPrice"].ToString().ToDecimal();

                    dgvPO.Rows[i].Cells[12].Value = dt.Rows[i-1]["branch_code"];
                    dgvPO.Rows[i].Cells[13].Value = dt.Rows[i-1]["Acc_no"];
                    dgvPO.Rows[i].Cells[14].Value = dt.Rows[i-1]["cyear"];

                }
                FreezeBand(dgvPO.Rows[0]);
                total_();
              }    
                Cursor.Current = Cursors.Default;
          

        }


        void total_()
        {
            decimal totqty = 0;
            decimal totReceive = 0;
            decimal totBalance = 0;
            for (int s=1;s<dgvPO.Rows.Count;s++ )
            {
                var value1 = dgvPO.Rows[s].Cells[7].Value;
                var value2 = dgvPO.Rows[s].Cells[8].Value;
                var value3 = dgvPO.Rows[s].Cells[9].Value;
                if (value1 != DBNull.Value)
                {
                    totqty += Convert.ToDecimal(value1);
                }
                if (value2 != DBNull.Value)
                {
                    totReceive += Convert.ToDecimal(value2);
                }
                if (value3 != DBNull.Value)
                {
                    totBalance += Convert.ToDecimal(value3);
                }
            }
            dgvPO.Rows[0].Cells[7].Value = totqty;
            dgvPO.Rows[0].Cells[8].Value = totReceive;
            dgvPO.Rows[0].Cells[9].Value = totBalance;

        }



        private static void FreezeBand(DataGridViewBand band)
        {
            band.Frozen = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.Yellow;
            style.SelectionBackColor = Color.Yellow;
            style.SelectionForeColor = Color.Black;
            band.DefaultCellStyle = style;
        }

        private void btnOptions_Click(object sender, EventArgs e)
        {
            // groupControl2.Visible = true;
            dgvPO.Dock = DockStyle.None;
            dgvPO.Rows.Clear();
        }

        private DataTable getData()
        {
            double T1, T2;
            if (txtThick_1.Text == "")
            { T1 = 0; }
            else { T1 = Convert.ToDouble(txtThick_1.Text); }
            if (txtThick_2.Text == "" || txtThick_2.Text == "0")
            { T2 = 100000; }
            else { T2 = Convert.ToDouble(txtThick_2.Text); }


            dt = dal.getDataTabl_1(@"select x.ser_no,X.G_Date,X.Cyear,X.Acc_no,P.payer_name,P.payer_l_name,x.item_no,D.descr,D.Descr_eng ,X.branch_code,C.branch_name,C.WH_E_NAME,D.Unit,X.qty_take,Y.qty_Add ,X.qty_take-isnull(Y.qty_Add,0) as Po_balance,D.Weight,X.Local_Price, case when D.Weight>0 then X.Local_Price/D.Weight*1000 else 0 end as TonPrice from 
            (select S2.Acc_no,S1.ser_no,S1.Cyear,S1.G_Date ,S1.branch_code,item_no, qty_take,Local_Price 
            from wh_Po_Cot_MATERIAL_TRANSACTION as S1 
            inner join  wh_Po_Cot_inv_data as S2
            on S1.ser_no = S2.ser_no and S1.branch_code =S2.branch_code and S1.cyear= S2.cyear and S1.transaction_code = S2.transaction_code
            where S1.TRANSACTION_CODE='ps' 
           and cast(S1.G_date as date) between '" + txtFromDate.Value.ToString("yyyy-MM-dd") + "' and '" + txtToDate.Value.ToString("yyyy-MM-dd")
            +"' and S1.branch_code like '"+txtBranch.ID.Text+"%') as X " +
            "left join  (select A.item_no,A.Branch_code,A.Cyear,B.po_no,sum(qty_add-qty_take) as qty_Add   from wh_material_transaction as A inner join wh_inv_data As B on "+
            "A.ser_no = B.ser_no and A.branch_code =B.branch_code and A.cyear= B.cyear and A.transaction_code = B.transaction_code where A.transaction_code like 'xp%'   group by A.item_no,A.Branch_code,A.Cyear,B.po_no ) as Y "+
            "on  cast(X.ser_no as varchar)= cast(Y.Po_no as varchar) and X.Cyear=Y.Cyear and X.branch_code = Y.branch_code and X.item_no = Y.item_no "+
            "inner join wh_branches as C on X.branch_code = C.branch_code "+
            "inner join wh_main_master as D on X.item_no = D.item_no "+
            "inner join Payer2 as p on P.acc_no = X.acc_no and C.ACC_BRANCH =  P.branch_code "+
           " where D.group_code  between(CASE WHEN '" + txtGroup.ID.Text.Length + "' > 3  then  '" + txtGroup.ID.Text + "' else '" + txtGroup.ID.Text + "' + '0' end) and " +
           "(CASE WHEN '" + txtGroup1.ID.Text.Length + "' >3   then  '" + txtGroup1.ID.Text + "' else  '" + txtGroup1.ID.Text + "'+'z' end) " +
           "and x.ser_no like case when '"+txtPO.Text.Trim()+"'!= '' then '"+txtPO.Text+ "' else '" + txtPO.Text + "%' end  "+
           "and X.Acc_no Like '"+txtAcc.ID.Text +"%' and x.item_no like '" + txtItem.ID.Text
           + "%' and ISNULL(D.UnitDepth, '') BETWEEN '" + T1 + "' AND '" + T2 +
           "' and( isnull(Y.qty_Add,0)>0 and  (X.qty_take-isnull(Y.qty_Add,0)) > case when '" + radioGroup1.EditValue + "'=1 then 0  end  " +
          "or (X.qty_take-isnull(Y.qty_Add,0))=case when '" + radioGroup1.EditValue + "'=2 then 0 end or isnull(Y.qty_Add,0)= case when '" + radioGroup1.EditValue + "'=3 then 0 end or X.qty_take > case when '" + radioGroup1.EditValue + "'=0 then 0 end) " +
          "order by X.branch_code,x.ser_no");

            return dt;
        }

        private void dgvPO_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (dgvPO.SelectedRows.Count < 1 || dgvPO.CurrentRow.Cells[13].Value.ToString() == null || dgvPO.CurrentRow.Cells[12].Value.ToString() == null || dgvPO.CurrentRow.Cells[0].Value.ToString() == null)
            {
                return;
            }



            if (e.ColumnIndex == 0)
            {
                Cursor.Current = Cursors.WaitCursor;
                //MessageBox.Show("PO");

                string printModel = Properties.Settings.Default.inv_print;
               
                    RPT.rpt_Purchase_Order reportInv = new RPT.rpt_Purchase_Order();
                    RPT.Form1 frminv = new RPT.Form1();
                    DataSet ds = new DataSet();
                    getQuotation(dgvPO.CurrentRow.Cells[0].Value.ToString(), dgvPO.CurrentRow.Cells[12].Value.ToString(), "PS", txtToDate.Value.ToString("yy"));
                    ds.Tables.Add(dt_Q);
                    //ds.WriteXmlSchema("schema_rpt.xml");
                    reportInv.SetDataSource(ds);
                    //reportInv.SetDataSource(dal.getDataTabl("get_invDetails", txt_InvNu.Text, txt_transaction_code.Text, txt_InvDate.Value.Year.ToString()));
                    frminv.crystalReportViewer1.ReportSource = reportInv;
                    frminv.ShowDialog();
               

                Cursor.Current = Cursors.Default;
            }
           else if (e.ColumnIndex == 3)
            {
                Cursor.Current = Cursors.WaitCursor;
                // MessageBox.Show("statment");
                               
                    RPT.frm_statment_Rpt frm = new RPT.frm_statment_Rpt();
                    frm.UC_Acc1.ID.Text = dgvPO.CurrentRow.Cells[13].Value.ToString();
                   // frm.UC_Items.ID.Text = dgvPO.CurrentRow.Cells[4].Value.ToString();
                    frm.FromDate.Text = txtFromDate.Text;
                    frm.ToDate.Text = txtToDate.Text;
                    frm.Report_btn.PerformClick();
                    frm.ShowDialog();

                Cursor.Current = Cursors.Default;

            }
            else if (e.ColumnIndex == 5)
            {
                //MessageBox.Show("item card");

                Cursor.Current = Cursors.WaitCursor;

                    RPT.frm_Item_Transaction frm = new RPT.frm_Item_Transaction();
                    frm.UC_Branch.ID.Text = dgvPO.CurrentRow.Cells[12].Value.ToString();
                    frm.UC_Items.ID.Text = dgvPO.CurrentRow.Cells[4].Value.ToString();
                    frm.FromDate_.Text =  txtFromDate.Text;
                    frm.ToDate_.Text = txtToDate.Text;
                    frm.buttonX1.PerformClick();
                    frm.ShowDialog();
                
                Cursor.Current = Cursors.Default;
            }
            else if (e.ColumnIndex == 8)
            {
                Cursor.Current = Cursors.WaitCursor;
                // MessageBox.Show("received qty");
                if (dgvPO.CurrentRow.Cells[8].Value.ToString().ToDecimal() > 0)
                {
                    RPT.frm_PO_Received frm = new RPT.frm_PO_Received();
                    frm._branch = dgvPO.CurrentRow.Cells[12].Value.ToString();
                    frm._PO = dgvPO.CurrentRow.Cells[0].Value.ToString();
                    frm._year = dgvPO.CurrentRow.Cells[14].Value.ToString();
                    frm.ShowDialog();
                }

               Cursor.Current = Cursors.Default;
            }
        }


        private void getQuotation(string ser_, string branch_, string transaction_, string cyear_)
        {
            //try
            //{ //, ReportDB.dbo.Tafkeet('+@4+', '''+@5+''')  from wh_Po_Cot_inv_data As A
            dt_Q = dal.getDataTabl_1(@"select A.Ser_no,A.Branch_code,A.Transaction_code,A.Cyear,A.Sanad_no,A.G_date,A.Acc_no,A.Acc_Branch_code
            ,A.Payment_Type,A.Sales_man_Id,A.User_id,A.Po_Status,A.Po_Expire_Date,A.Cash_costomer_name,A.Costomer_adress
            ,A.Costomer_Phone,A.Costmer_fax,A.Ref,A.E_mail,A.TermsOfPayment,A.Validity,A.DelevryE,A.FORIN_TYPE
            ,A.K_M_ACC_NO,A.K_M_Credit_TAX,A.COSTMER_K_M_NO,A.KM_CODE_ACC,A.MAIN_KM_CODE,A.Costomer_Notes,A.VAT_RATIO,A.COMP_TAX_NO
            ,B.ITEM_NO,B.QTY_ADD,B.QTY_TAKE,B.Unit,B.total_disc,B.Local_Price,B.TAX_IN,B.TAX_OUT,B.DETAILS,B.Pice_Total_Cost,B.K_M_TYPE_ITEMS

            ,M.descr,M.Descr_eng,m.Weight,m.BALANCE ,K.KM_RATIO,
            SP.Payment_name,SP.Notes,
            DP.DeLEVRY_Name,DP.DELEVER_NAME_E,U.USER_NAME
			,P.PAYER_NAME,P.payer_l_name
            ,(select top 1 vat_ratio from VAT_RATIO_MASTER where cast(A.G_date as date ) between date_of_vat and '" + DateTime.Today.ToString("yyyy-MM-dd") + "' order by date_of_vat desc) as VatRatio "+
            "from wh_Po_Cot_inv_data As A "+
            "Inner join wh_Po_Cot_MATERIAL_TRANSACTION As B " +
            "on A.Ser_no = B.SER_NO and A.Branch_code = B.Branch_code AND A.Transaction_code = B.TRANSACTION_CODE AND A.Cyear = B.Cyear " +
            "inner join wh_main_master AS M on M.item_no = B.ITEM_NO " +
            "left join KM_MATERIAL_CODE As K on K.KM_CODE = ISNULL(NULLIF(M.KM_CODE, ''), 1) " +
            "left join Sal_Pyment_type As SP on SP.Payment_type = A.termsOfPayment " +
            "left join WH_PO_DELEVRY_CODE As DP on DP.DeLEVRY_CODE = A.DelevryE " +
            "inner join wh_USERS As U on U.USER_ID = A.USER_ID " +
            "inner join wh_BRANCHES as BR on A.Branch_code = BR.Branch_code " +
            "inner join payer2 as P on P.acc_no = A.acc_no and p.BRANCH_code = BR.ACC_BRANCH "+ 
            "where A.Ser_no = '" + ser_ + "'  and A.Branch_code = '" + branch_ + "'  and A.transaction_code = '" + transaction_ + "'  and A.cyear = '" + cyear_ + "'");
            //}
            //catch (Exception ex) { MessageBox.Show(ex.Message); }
        }

        private void frm_rpt_Po_Load(object sender, EventArgs e)
        {

        }

        private void dgvPO_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void groupControl2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void txtItem_Click(object sender, EventArgs e)
        {
            //uc_SearchItem1.Visible = true;
            //uc_SearchItem1.BringToFront();
        }

      
        private void txtBranch_Load(object sender, EventArgs e)
        {

        }

        private void txtAcc_Load(object sender, EventArgs e)
        {

        }

        private void txtGroup_Load(object sender, EventArgs e)
        {

        }

        private void txtGroup1_Load(object sender, EventArgs e)
        {

        }

        private void txtItem_Load(object sender, EventArgs e)
        {

        }
    }
}
