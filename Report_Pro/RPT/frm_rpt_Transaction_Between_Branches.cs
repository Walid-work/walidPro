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
    public partial class frm_rpt_Transaction_Between_Branches : frm_ReportMaster
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_rpt_Transaction_Between_Branches()
        {
            InitializeComponent();
        }

        private void frm_rpt_Transaction_Between_Branches_Load(object sender, EventArgs e)
        {

        }

        public override void Option()
        {

            base.Option();
            OS.Visible = true;
        }


        public override void Report()
        {
            base.Report();
            OS.Visible = false;
            DataTable dt_ = dal.getDataTabl_1(@"select A.branch_code,D.branch_name,A.SER_NO ,A.G_DATE ,A.ITEM_NO ,C.descr ,A.QTY_TAKE,C.Weight,A.QTY_TAKE*C.Weight as total_Weight,B.Acc_no,E.branch_name as R_Branch_Name from 
                wh_material_transaction as A
                inner join wh_inv_data as B
                on A.Branch_code = B.Branch_code and A.Cyear = B.Cyear and A.TRANSACTION_CODE = B.Transaction_code  and A.SER_NO = B.Ser_no
                inner join wh_main_master As C on A.ITEM_NO = c.item_no
                inner join wh_BRANCHES as D on B.Branch_code = D.Branch_code 
                inner join wh_BRANCHES as E on B.Acc_no = E.Branch_code 
                where C.group_code  between(CASE WHEN '" + OS.GroupID1.Text.Length + "' > 3  then  '" + OS.GroupID1.Text + "' else '" + OS.GroupID1.Text + "' + '0' end) and " +
               "(CASE WHEN '" + OS.GroupID2.Text.Length + "' >3   then  '" + OS.GroupID2.Text + "' else  '" + OS.GroupID2.Text + "'+'z' end) " +
               " and cast(A.G_date as date) between '" +OS.dTP1.Value.ToString("yyyy-MM-dd") + "' and '" + OS.dTP2.Value.ToString("yyyy-MM-dd")+
               "' and B.branch_code like '"+OS.StoreID.Text+ "%' and B.Acc_no like '"+OS.toStoreID.Text+"%'");


            dgv1.Rows.Clear();
            if (dt_.Rows.Count > 0)
            {
                int B_rowscount = dt_.Rows.Count;


                dgv1.Rows.Add(B_rowscount + 1);
                for (int i = 1; i <= (B_rowscount); i++)
                {


                        dgv1.Rows[i].Cells[0].Value = dt_.Rows[i - 1]["branch_code"];
                    if (dal.languh_ == "0")
                    {
                        dgv1.Rows[i].Cells[1].Value = dt_.Rows[i - 1]["branch_name"];
                        dgv1.Rows[i].Cells[5].Value = dt_.Rows[i - 1]["R_Branch_Name"];
                        dgv1.Rows[i].Cells[7].Value = dt_.Rows[i - 1]["descr"];

                    }
                    else
                    {
                        dgv1.Rows[i].Cells[1].Value = dt_.Rows[i - 1]["branch_name"];
                        dgv1.Rows[i].Cells[5].Value = dt_.Rows[i - 1]["R_Branch_Name"];
                        dgv1.Rows[i].Cells[7].Value = dt_.Rows[i - 1]["descr"];
                    }
                    dgv1.Rows[i].Cells[2].Value = dt_.Rows[i - 1]["ser_no"];
                    dgv1.Rows[i].Cells[3].Value  = Convert.ToDateTime(dt_.Rows[i - 1]["G_Date"]).ToString("yyyy/MM/dd");
                    dgv1.Rows[i].Cells[4].Value  = dt_.Rows[i - 1]["acc_no"];
                    dgv1.Rows[i].Cells[6].Value  = dt_.Rows[i - 1]["ITEM_NO"];
                    dgv1.Rows[i].Cells[8].Value  = dt_.Rows[i - 1]["qty_take"].ToString().ToDecimal();
                    dgv1.Rows[i].Cells[9].Value  = dt_.Rows[i - 1]["Weight"].ToString().ToDecimal();
                    dgv1.Rows[i].Cells[10].Value =dt_.Rows[i - 1]["total_Weight"].ToString().ToDecimal();
                   
                }
               // FreezeBand(dgvPO.Rows[0]);
               // total_();
            }

        }
    }
}
