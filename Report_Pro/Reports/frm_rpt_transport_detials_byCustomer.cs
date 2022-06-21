using DevExpress.XtraEditors;
using DevExpress.XtraReports.UI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Reports
{
    public partial class frm_rpt_transport_detials_byCustomer : XtraForm
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt_;
        BindingSource MyBindingSource = new BindingSource();
        public frm_rpt_transport_detials_byCustomer()
        {
            InitializeComponent();
        }

        private void advancedDataGridView1_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
           
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
           
        }

        private void propertyGridControl1_Click(object sender, EventArgs e)
        {

        }

        private void advancedDataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void frm_rpt_transport_detials_byCustomer_Load(object sender, EventArgs e)
        {
           foreach (DataGridViewRow r in dataGridView1.Rows)
            {
                if(r.Index== dataGridView1.Rows.Count - 1)
                {
                    r.Cells[0].Value = "Total";
                }
            }
        }

      DataTable getData (string accNo,DateTime date1, DateTime date2)
        {
            dt_ = dal.getDataTabl_1(@"SELECT T.Travel_no,T.S_date,t.line_no,Line_name,T.Driver_no,D.Driver_name,C.Cost_Center, T.Car_no
            ,C.Car_no as Car_Plate,T.No_of_trips,T.Costmer_Charge*T.No_of_trips as Costmer_Charge ,T.TAX_OUT*T.No_of_trips as TAX_OUT 
            ,(T.Costmer_Charge*T.No_of_trips)+(T.TAX_OUT*T.No_of_trips) as totAmount,T.Acc_no,PAYER_NAME,P.payer_l_name,T.COSTMER_K_M_NO,T.Notes  
            FROM C_Travel as T
            inner join C_Lines as L on L.Line_code=T.line_no
            inner join  C_Cars as C on C.Car_Code=T.Car_no
            inner join C_Drivers as D on D.Driver_code =T.Driver_no
            inner join payer2 as P on T.Acc_no =P.ACC_NO
            where T.Acc_no='" + accNo+ "' and T.S_date between '" + date1.ToString("yyyy-MM-dd") + "' and '" + date2.ToString("yyyy-MM-dd") + "' ");
            return dt_;

        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
            getData(Uc_Acc.ID.Text, fromDate.Value, toDate.Value);
            //DataTable dt_ = dal.getDataTabl_1(@"SELECT T.Travel_no,T.S_date,t.line_no,Line_name,T.Driver_no,D.Driver_name,C.Cost_Center, T.Car_no
            //,C.Car_no as Car_Plate,T.No_of_trips,T.Costmer_Charge*T.No_of_trips as Costmer_Charge ,T.TAX_OUT*T.No_of_trips as TAX_OUT ,(T.Costmer_Charge*T.No_of_trips)+(T.TAX_OUT*T.No_of_trips) as totAmount,T.Acc_no,PAYER_NAME,T.COSTMER_K_M_NO,T.Notes     
            //FROM C_Travel as T
            //inner join C_Lines as L on L.Line_code=T.line_no
            //inner join  C_Cars as C on C.Car_Code=T.Car_no
            //inner join C_Drivers as D on D.Driver_code =T.Driver_no
            //inner join payer2 as P on T.Acc_no =P.ACC_NO
            //where T.Acc_no='" + Uc_Acc.ID.Text+"' and T.S_date between '"+fromDate.Value.ToString("yyyy-MM-dd")+ "' and '" + toDate.Value.ToString("yyyy-MM-dd") + "' ");
           
            //this.MyBindingSource.DataSource = dt_;
            //this.dataGridView1.DataSource = this.MyBindingSource;

            int B_rowscount = dt_.Rows.Count;
            dataGridView1.Rows.Clear();
            dataGridView1.Rows.Add(B_rowscount);
            for (int i = 0; (i
                       <= (B_rowscount - 1)); i++)
            {


                dataGridView1.Rows[i+1].Cells[0].Value = dt_.Rows[i]["Travel_no"];
                dataGridView1.Rows[i+1].Cells[1].Value = dt_.Rows[i]["S_date"];
                dataGridView1.Rows[i+1].Cells[2].Value = dt_.Rows[i]["Line_name"];
                dataGridView1.Rows[i+1].Cells[3].Value = dt_.Rows[i]["Driver_name"];
                dataGridView1.Rows[i+1].Cells[4].Value = dt_.Rows[i]["Car_Plate"];
                dataGridView1.Rows[i+1].Cells[5].Value = dt_.Rows[i]["No_of_trips"];
                dataGridView1.Rows[i+1].Cells[6].Value = dt_.Rows[i]["Costmer_Charge"];
                dataGridView1.Rows[i+1].Cells[7].Value = dt_.Rows[i]["TAX_OUT"];
                dataGridView1.Rows[i+1].Cells[8].Value = dt_.Rows[i]["totAmount"];
                dataGridView1.Rows[i+1].Cells[9].Value = dt_.Rows[i]["Notes"];
            }

            int sum = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum += Convert.ToInt32(dataGridView1.Rows[i].Cells[5].Value);
            }
           // textBox1.Text = sum.ToString();
            int sum1 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum1 += Convert.ToInt32(dataGridView1.Rows[i].Cells[6].Value);
            }
            int sum2 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum2 += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            int sum3 = 0;
            for (int i = 0; i < dataGridView1.Rows.Count; ++i)
            {
                sum3 += Convert.ToInt32(dataGridView1.Rows[i].Cells[8].Value);
            }
            //  textBox3.Text = sum1.ToString();

            dataGridView1.Rows[0].Cells[0].Value = "Total";
            dataGridView1.Rows[0].Cells[1].Value = "";
            dataGridView1.Rows[0].Cells[2].Value = "";
            dataGridView1.Rows[0].Cells[3].Value = "";
            dataGridView1.Rows[0].Cells[4].Value = "";
            dataGridView1.Rows[0].Cells[5].Value = sum;
            dataGridView1.Rows[0].Cells[6].Value = sum1;
            dataGridView1.Rows[0].Cells[7].Value =sum2;
            dataGridView1.Rows[0].Cells[8].Value = sum3;

              FreezeBand(dataGridView1.Rows[0]);
            dataGridView1.Rows[0].DefaultCellStyle.BackColor = Color.Yellow;
            dataGridView1.Rows[0].DefaultCellStyle.Font=new Font("Tahoma",9,FontStyle.Bold);
        }

        private static void FreezeBand(DataGridViewBand band)
        {
            band.Frozen = true;
            DataGridViewCellStyle style = new DataGridViewCellStyle();
            style.BackColor = Color.WhiteSmoke;
            band.DefaultCellStyle = style;
        }

        private void btn_Print_Click(object sender, EventArgs e)
        {
            //======Print DataGrid ======

            // Cursor.Current = Cursors.WaitCursor;
            // DataSet ds = new DataSet();
            // DataTable dtP = new DataTable();
            //Reports.rpt_transport_detials_byCustomer rpt = new Reports.rpt_transport_detials_byCustomer();

            // dtP.Columns.Add("Travel_no", typeof(string));
            // dtP.Columns.Add("S_date", typeof(string));
            // dtP.Columns.Add("Line_name", typeof(string));
            // dtP.Columns.Add("Driver_name", typeof(string));
            // dtP.Columns.Add("Car_Plate", typeof(string));
            // dtP.Columns.Add("No_of_trips", typeof(Int32));
            // dtP.Columns.Add("Costmer_Charge", typeof(decimal));
            // dtP.Columns.Add("TAX_OUT", typeof(decimal));
            // dtP.Columns.Add("totAmount", typeof(decimal));
            // dtP.Columns.Add("Notes", typeof(string));

            // foreach (DataGridViewRow row in dataGridView1.Rows)
            // {
            //     dtP.Rows.Add(row.Cells[0].Value, row.Cells[1].Value, row.Cells[2].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value,
            //      row.Cells[6].Value, row.Cells[7].Value, row.Cells[8].Value, row.Cells[9].Value);
            // }

            // ds.Tables.Add(dtP);
            // //ds.WriteXmlSchema("schema_rpt.xml");
            // rpt.DataSource = ds;
            // Cursor.Current = Cursors.Default;
            // rpt.ShowPreview();
            //====================================================
            Cursor.Current = Cursors.WaitCursor;
             DataSet ds = new DataSet();
            Reports.rpt_transport_detials_byCustomer rpt = new Reports.rpt_transport_detials_byCustomer();

            getData(Uc_Acc.ID.Text, fromDate.Value, toDate.Value);
            ds.Tables.Add(dt_);
           // //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.DataSource = ds;
            rpt.lblFromDate.Value = fromDate.Value;
            rpt.lblToDate.Value = toDate.Value;
            rpt.lblFromDate.Text = fromDate.Text;
            rpt.lblToDate.Text = toDate.Text;
            rpt.ShowPreview();
          //  rpt.lblFromDate.Text = fromDate.Value.ToString("yyyy-MM-dd");
            
            Cursor.Current = Cursors.Default;
          
        }
        

        private void dataGridView1_FilterStringChanged(object sender, EventArgs e)
        {
           // this.MyBindingSource.Filter = this.dataGridView1.FilterString;
        }

        private void dataGridView1_SortStringChanged(object sender, EventArgs e)
        {

        }
    }
}
