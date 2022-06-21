using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
//using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class Rpt_Trans_Detials : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public Rpt_Trans_Detials()
        {
            InitializeComponent();
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btn_Report_Click(object sender, EventArgs e)
        {
            string str_t="";
            string str_Name="";

            if (rBtn1.Checked)
            {
                str_t = "I";
                str_Name=rBtn1.Text;

            }
            else if (rBtn2.Checked)
            {
                str_t = "E";
                 str_Name=rBtn2.Text;
            }
            else if (rBtn3.Checked)
            {
                str_t = "";
                 str_Name=rBtn3.Text;
            }


            RPT.trans_by_inv rpt = new RPT.trans_by_inv();

            DataTable dt_ = dal.getDataTabl_1(@"use cust_acc_wh SELECT  A.inv_no,A.inv_date,Travel_no,E.PAYER_NAME,d.Line_name,B.Driver_name,C.Car_no
                                                ,A.S_date,a.Costmer_Charge,A.TAX_OUT,A.COSTMER_K_M_NO,D.INTER_EXT,a.COMP_TAX_NO
                                                FROM C_Travel As A
                                                inner join C_Drivers AS B  on A.Driver_no=B.Driver_code
                                                inner join C_Cars AS C  on A.Car_no =C.Car_Code
                                                inner join C_Lines AS D  on A.line_no = D.Line_code
                                                inner join payer2 AS E  on A.Acc_no =E.ACC_NO and a.Branch_Code=E.BRANCH_code
                                                where   convert(varchar,inv_date,111) between '"+dTP1.Value.ToString("yyyy/MM/dd")+"' and '"+dTP2.Value.ToString("yyyy/MM/dd")+"' and D.INTER_EXT like '"+str_t+"%'");
            //rpt.SetDataSource(dal.getDataTabl("Get_Trans_Detials_", dTP1.Value.Date,dTP2.Value.Date,str_t));

            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Trans_Kind"].Text = "'" + str_Name + "'";
            rpt.DataDefinition.FormulaFields["datails_"].Text = "'1'";
           

        }

        private void Rpt_Trans_Detials_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string str_t = "";
            string str_Name = "";

            if (rBtn1.Checked)
            {
                str_t = "I";
                str_Name = rBtn1.Text;

            }
            else if (rBtn2.Checked)
            {
                str_t = "E";
                str_Name = rBtn2.Text;
            }
            else if (rBtn3.Checked)
            {
                str_t = "";
                str_Name = rBtn3.Text;
            }


            RPT.CrystalReport1 rpt = new RPT.CrystalReport1();

            DataTable dt_ = dal.getDataTabl_1(@"use cust_acc_wh SELECT  A.inv_no,A.inv_date,Travel_no,E.PAYER_NAME,d.Line_name,B.Driver_name,C.Car_no
                                                ,A.S_date,a.Costmer_Charge,A.TAX_OUT,A.COSTMER_K_M_NO,D.INTER_EXT,a.COMP_TAX_NO
                                                FROM C_Travel As A
                                                inner join C_Drivers AS B  on A.Driver_no=B.Driver_code
                                                inner join C_Cars AS C  on A.Car_no =C.Car_Code
                                                inner join C_Lines AS D  on A.line_no = D.Line_code
                                                inner join payer2 AS E  on A.Acc_no =E.ACC_NO and a.Branch_Code=E.BRANCH_code
                                                where   convert(varchar,inv_date,111) between '" + dTP1.Value.ToString("yyyy/MM/dd") + "' and '" + dTP2.Value.ToString("yyyy/MM/dd") + "' and D.INTER_EXT like '" + str_t + "%'");
            //rpt.SetDataSource(dal.getDataTabl("Get_Trans_Detials_", dTP1.Value.Date,dTP2.Value.Date,str_t));

            rpt.SetDataSource(dt_);
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + dTP1.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + dTP2.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Trans_Kind"].Text = "'" + str_Name + "'";
            rpt.DataDefinition.FormulaFields["datails_"].Text = "'0'";
           

        }
    }
}
