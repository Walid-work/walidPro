using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.RPT
{
    public partial class frm_transRepot : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_transRepot()
        {
            InitializeComponent();
            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;
        }

        private void Report_btn_Click(object sender, EventArgs e)
        {
            string str_t="1";
            string car_studes = "";
            if (radioBtn1.Checked)
            {str_t="1";
            car_studes = radioBtn1.Text;
            } 
            else if (radioBtn2.Checked)
            { str_t = "2";
            car_studes = radioBtn2.Text;
            }
            else if (radioBtn3.Checked)
            { str_t = "3";
            car_studes = radioBtn3.Text;
            }
        
        
             RPT.rpt_Trans_details rpt = new RPT.rpt_Trans_details();
             rpt.SetDataSource(dal.getDataTabl("Get_All_travels", Uc_Acc.ID.Text, FromDate.Value.Date, ToDate.Value.Date,str_t,Driver_No.Text,Car_No.Text));
             crystalReportViewer1.ReportSource = rpt;
             rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
             rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
             rpt.DataDefinition.FormulaFields["Cust_name"].Text = "'" + Uc_Acc.ID.Text + " - ' & '" + Uc_Acc.Desc.Text + "'";
             rpt.DataDefinition.FormulaFields["Driver_name"].Text = "'" + Driver_No.Text + " - ' & '" + Driver_Name.Text + "'";
             rpt.DataDefinition.FormulaFields["Car_Desc"].Text = "'" + Car_No.Text + " - ' & '" + Car_Desc.Text + "'";
             rpt.DataDefinition.FormulaFields["Line_Desc"].Text = "'" + line_no.Text + " - ' & '" + Line_Desc.Text + "'";
             rpt.DataDefinition.FormulaFields["travel_studes"].Text = "'" +car_studes + "'";
             groupPanel1.Visible=false; 

        }

        private void frm_transRepot_Load(object sender, EventArgs e)
        {
            FromDate.Value = new DateTime(DateTime.Now.Year, 1, 1);
            ToDate.Value = DateTime.Today;
        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            string str_t = "1";
            string car_studes = "";
            if (radioBtn1.Checked)
            {
                str_t = "1";
                car_studes = radioBtn1.Text;
            }
            else if (radioBtn2.Checked)
            {
                str_t = "2";
                car_studes = radioBtn2.Text;
            }
            else if (radioBtn3.Checked)
            {
                str_t = "3";
                car_studes = radioBtn3.Text;
            }

            
            RPT.rpt_travels_byCust rpt = new RPT.rpt_travels_byCust();
            rpt.SetDataSource(dal.getDataTabl("Get_All_travels", Uc_Acc.ID.Text, FromDate.Value.Date, ToDate.Value.Date, str_t, Driver_No.Text, Car_No.Text));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Cust_name"].Text = "'" + Uc_Acc.ID.Text + " - ' & '" + Uc_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Driver_name"].Text = "'" + Driver_No.Text + " - ' & '" + Driver_Name.Text + "'";
            rpt.DataDefinition.FormulaFields["Car_Desc"].Text = "'" + Car_No.Text + " - ' & '" + Car_Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Line_Desc"].Text = "'" + line_no.Text + " - ' & '" + Line_Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["travel_studes"].Text = "'" + car_studes + "'";
         
            groupPanel1.Visible=false;

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonX6_Click(object sender, EventArgs e)
        {
            groupPanel1.Visible=true;
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            string str_t = "1";
            string car_studes = "";
            if (radioBtn1.Checked)
            {
                str_t = "1";
                car_studes = radioBtn1.Text;
            }
            else if (radioBtn2.Checked)
            {
                str_t = "2";
                car_studes = radioBtn2.Text;
            }
            else if (radioBtn3.Checked)
            {
                str_t = "3";
                car_studes = radioBtn3.Text;
            }

            
            RPT.rpt_driver_details_trvels rpt = new RPT.rpt_driver_details_trvels();
            rpt.SetDataSource(dal.getDataTabl("Get_All_travels", Uc_Acc.ID.Text, FromDate.Value.Date, ToDate.Value.Date, str_t, Driver_No.Text, Car_No.Text));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Cust_name"].Text = "'" + Uc_Acc.ID.Text + " - ' & '" + Uc_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Driver_name"].Text = "'" + Driver_No.Text + " - ' & '" + Driver_Name.Text + "'";
            rpt.DataDefinition.FormulaFields["Car_Desc"].Text = "'" + Car_No.Text + " - ' & '" + Car_Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Line_Desc"].Text = "'" + line_no.Text + " - ' & '" + Line_Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["travel_studes"].Text = "'" + car_studes + "'";
           
            groupPanel1.Visible=false;

        }

        private void buttonX7_Click(object sender, EventArgs e)
        {
            string str_t = "1";
            string car_studes = "";
            if (radioBtn1.Checked)
            {
                str_t = "1";
                car_studes = radioBtn1.Text;
            }
            else if (radioBtn2.Checked)
            {
                str_t = "2";
                car_studes = radioBtn2.Text;
            }
            else if (radioBtn3.Checked)
            {
                str_t = "3";
                car_studes = radioBtn3.Text;
            }
           
            RPT.rpt_driver_total rpt = new RPT.rpt_driver_total();
            rpt.SetDataSource(dal.getDataTabl("Get_All_travels", Uc_Acc.ID.Text, FromDate.Value.Date, ToDate.Value.Date, str_t, Driver_No.Text, Car_No.Text));
            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Cust_name"].Text = "'" + Uc_Acc.ID.Text + " - ' & '" + Uc_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Driver_name"].Text = "'" + Driver_No.Text + " - ' & '" + Driver_Name.Text + "'";
            rpt.DataDefinition.FormulaFields["Car_Desc"].Text = "'" + Car_No.Text + " - ' & '" + Car_Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Line_Desc"].Text = "'" + line_no.Text + " - ' & '" + Line_Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["travel_studes"].Text = "'" + car_studes + "'";
          
            groupPanel1.Visible=false;

        }

        private void buttonX4_Click(object sender, EventArgs e)
        {
            string str_t = "1";
            string car_studes = "";
            if (radioBtn1.Checked)
            {
                str_t = "1";
                car_studes = radioBtn1.Text;
            }
            else if (radioBtn2.Checked)
            {
                str_t = "2";
                car_studes = radioBtn2.Text;
            }
            else if (radioBtn3.Checked)
            {
                str_t = "3";
                car_studes = radioBtn3.Text;
            }

            RPT.rpt_Lines_total rpt = new RPT.rpt_Lines_total();

            DataTable dt_ = dal.getDataTabl_1(@"Use cust_acc_wh  SELECT T.line_no ,T.Acc_no,L.Line_name ,Costmer_Charge,PAYER_NAME,No_Of_Trips,T.COSTMER_K_M_NO,L.Distance
                                                FROM C_Travel as T  inner join C_Lines as L on L.Line_code=T.line_no  inner join payer2 as P on T.Acc_no =P.ACC_NO
                                                where Trans_to_driver like case when '" + str_t + "'=2 then 'T' else '%' end " +
                                                "and Trans_to_driver <> case when '" + str_t + "' =3 then 'T' else '' end  " +
                                                "And convert(varchar,T.S_date,111) BETWEEN '" + FromDate.Value.ToString("yyyy/MM/dd") + "' AND '" + ToDate.Value.ToString("yyyy/MM/dd") + "'");

            //rpt.SetDataSource(dal.getDataTabl("Get_All_travels", Acc_no.Text, FromDate.Value.Date, ToDate.Value.Date, str_t, Driver_No.Text, Car_No.Text));
            DataSet ds = new DataSet();
            ds.Tables.Add(dt_);
            rpt.SetDataSource(ds);
            //ds.WriteXmlSchema("schema3.xml");

            crystalReportViewer1.ReportSource = rpt;
            rpt.DataDefinition.FormulaFields["From_date"].Text = "'" + FromDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["To_Date"].Text = "'" + ToDate.Value.ToString("yyyy/MM/dd") + "'";
            rpt.DataDefinition.FormulaFields["Cust_name"].Text = "'" + Uc_Acc.ID.Text + " - ' & '" + Uc_Acc.Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Driver_name"].Text = "'" + Driver_No.Text + " - ' & '" + Driver_Name.Text + "'";
            rpt.DataDefinition.FormulaFields["Car_Desc"].Text = "'" + Car_No.Text + " - ' & '" + Car_Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["Line_Desc"].Text = "'" + line_no.Text + " - ' & '" + Line_Desc.Text + "'";
            rpt.DataDefinition.FormulaFields["travel_studes"].Text = "'" + car_studes + "'";

            groupPanel1.Visible = false;

        }

        
    }
}
