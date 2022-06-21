using System;
using System.Windows.Forms;
using System.Data;
using System.Drawing; using System.Linq;

namespace Report_Pro.PL
{
    public partial class Prepaid_expenses : Form
    {
        string new_id;
        string frmType = "input";
        string saveType = "add";

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        DataTable dt = new DataTable();

        public Prepaid_expenses()
        {
            InitializeComponent();
            creatDattable();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void Prepaid_expenses_Load(object sender, EventArgs e)
        {
            //Assign(this);
            get_Id();
            txtCost.ID.Text = "1";
            Acc_.txtMainAcc.Text = "3";
            Acc_1.txtMainAcc.Text = "127";
            Acc_.txtFinal.Text = "1";
            Acc_1.txtFinal.Text = "1";
            Acc_.branchID.Text = UC_AccBranch.ID.Text;

        }

        private void get_Id() 
        {
      
             new_id=dal.getDataTabl_1(@"SELECT isnull (max (id)+1,1) FROM P_expenses_T1").Rows[0][0].ToString();
             txtID.Text = new_id;
        }

        private void S_Date_Load(object sender, EventArgs e)
        {
            clac_();
        }

        private void clac_()
        {
            //try
            //{
                if (ValidateData() == false)
                {
                dataGridViewX1.Rows.Clear();
                return;
                }
                else
                {
                    E_year.Value = new DateTime(S_Date.GD.Value.Year, 12, 31);
                    totalDays.Value = ((TimeSpan)(E_Date.GD.Value - S_Date.GD.Value)).Days + 1;
                    if (E_year.Value >= E_Date.GD.Value)
                    {
                        days_1.Value = ((TimeSpan)(E_Date.GD.Value - S_Date.GD.Value)).Days + 1;
                        days_2.Value = 0;
                        No_of_Monthes.Value = E_Date.GD.Value.Month - S_Date.GD.Value.Month + 1;
                        txtExpenss.Value = txtAmount.Value * days_1.Value / totalDays.Value;

                    }
                    else
                    {
                        int noOfYears = E_Date.GD.Value.Year - S_Date.GD.Value.Year;
                        days_1.Value = ((TimeSpan)(E_year.Value - S_Date.GD.Value)).Days + 1;
                        days_2.Value = ((TimeSpan)(E_Date.GD.Value - E_year.Value)).Days;
                        No_of_Monthes.Value = E_Date.GD.Value.Month - S_Date.GD.Value.Month + (noOfYears * 12) + 1;
                        txtExpenss.Value = txtAmount.Value * days_1.Value / totalDays.Value;
                        txtPrepaid.Value = txtAmount.Value * days_2.Value / totalDays.Value;

                    }
                    dataGridViewX1.Rows.Clear();
                    dataGridViewX1.RowCount = No_of_Monthes.Value;
                }
                              
            //}
            //catch { }
        }
        private void E_Date_Load(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
        }

        private void S_Date_Leave(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
        }

        private void E_Date_Leave(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            //if (Acc_.ID.Text.Trim() != string.Empty && Acc_1.ID.Text.Trim() != string.Empty
            //    && UC_AccBranch.ID.Text.Trim() != string.Empty && txtAmount.Value > 0
            //    && E_Date.GD.Value>S_Date.GD.Value)
            if (ValidateData() == false)
            {
                dataGridViewX1.Rows.Clear();
                return;
            }
            else

            {
                clac_();
                //dataGridViewX1.Rows.Clear();
                //dataGridViewX1.RowCount = No_of_Monthes.Value;
            }
            //else
            //{
            //    MessageBox.Show("تأكد من البيانات المطلوبة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    dataGridViewX1.Rows.Clear();
            //}


        }



        bool ValidateData()
        {

            if (Acc_.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من حساب المصروف", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;

            }
            if (Acc_1.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من حساب المقدم", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (UC_AccBranch.ID.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من الفرع", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtAmount.Value <= 0)
            {
                MessageBox.Show("تأكد من القيمة", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (E_Date.GD.Value <= S_Date.GD.Value)
            {
                MessageBox.Show("تأكد من التواريخ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (txtDescribtion.Text.Trim() == string.Empty)
            {
                MessageBox.Show("تأكد من البيان", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
           

            return true;

        }


        public static DateTime GetLastDayOfMonth(DateTime date_, int months_)
        {


            return new DateTime(date_.Year, date_.Month, 1).AddMonths(months_).AddDays(-1);
        }

        //public static DateTime FirstDayOfMonth_NewMethod(this DateTime value)
        //{
        //    return new DateTime(value.Year, value.Month, 1);
        //}

        //public static DateTime LastDayOfMonth_AddMethod(this DateTime value)
        //{
        //    return value.FirstDayOfMonth_AddMethod().AddMonths(1).AddDays(-1);
        //}


        private void dataGridViewX1_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
        {

           


                //if (frmType == "input")
                //{
                    double sum = 0, sum_1 = 0;
                    for (int i = 0; i < dataGridViewX1.RowCount; i++)
                    {

                        if (i == 0)
                        {
                            this.dataGridViewX1.Rows[i].Cells[0].Value = (i + 1).ToString();
                            this.dataGridViewX1.Rows[i].Cells[1].Value = (GetLastDayOfMonth(S_Date.GD.Value, (i+1))).Date.ToString("dd/MM/yyyy");
                            DateTime d1 = Convert.ToDateTime(dataGridViewX1.Rows[i].Cells[1].Value);
                            DateTime d2 = S_Date.GD.Value;
                            TimeSpan ts = d1 - d2;
                            dataGridViewX1.Rows[i].Cells[2].Value = ts.Days + 1;
                            dataGridViewX1.Rows[i].Cells[3].Value = Math.Round((ts.Days + 1) * txtAmount.Value / totalDays.Value, 0);
                            dataGridViewX1.Rows[i].Cells[4].Value = d1.Year;
                            if (d1.Month == 1 || d1.Month == 2 || d1.Month == 3) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الاول"; }
                            else if (d1.Month == 4 || d1.Month == 5 || d1.Month == 6) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الثاني"; }
                            else if (d1.Month == 7 || d1.Month == 8 || d1.Month == 9) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الثالث"; }
                            else if (d1.Month == 10 || d1.Month == 11 || d1.Month == 12) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الرابع"; }
                        }
                        else if (i == dataGridViewX1.RowCount - 1)
                        {
                            this.dataGridViewX1.Rows[i].Cells[0].Value = (i + 1).ToString();
                            this.dataGridViewX1.Rows[i].Cells[1].Value = E_Date.GD.Value.ToString("dd/MM/yyyy");
                            DateTime d1 = Convert.ToDateTime(dataGridViewX1.Rows[i].Cells[1].Value);
                            DateTime d2 = Convert.ToDateTime(dataGridViewX1.Rows[i - 1].Cells[1].Value);
                            TimeSpan ts = d1 - d2;
                            dataGridViewX1.Rows[i].Cells[2].Value = ts.Days;
                            dataGridViewX1.Rows[i].Cells[3].Value = Math.Round((ts.Days) * txtAmount.Value / totalDays.Value, 0);
                            dataGridViewX1.Rows[i].Cells[4].Value = d1.Year;
                            if (d1.Month == 1 || d1.Month == 2 || d1.Month == 3) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الاول"; }
                            else if (d1.Month == 4 || d1.Month == 5 || d1.Month == 6) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الثاني"; }
                            else if (d1.Month == 7 || d1.Month == 8 || d1.Month == 9) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الثالث"; }
                            else if (d1.Month == 10 || d1.Month == 11 || d1.Month == 12) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الرابع"; }
                        }
                        else
                        {
                            this.dataGridViewX1.Rows[i].Cells[0].Value = (i + 1).ToString();
                            this.dataGridViewX1.Rows[i].Cells[1].Value = (GetLastDayOfMonth(S_Date.GD.Value, (i+1))).Date.ToString("dd/MM/yyyy");
                            DateTime d1 = Convert.ToDateTime(dataGridViewX1.Rows[i].Cells[1].Value);
                            DateTime d2 = Convert.ToDateTime(dataGridViewX1.Rows[i - 1].Cells[1].Value);
                            TimeSpan ts = d1 - d2;
                            dataGridViewX1.Rows[i].Cells[2].Value = ts.Days;
                            dataGridViewX1.Rows[i].Cells[3].Value = Math.Round((ts.Days) * txtAmount.Value / totalDays.Value, 0);
                            dataGridViewX1.Rows[i].Cells[4].Value = d1.Year;


                            if (d1.Month == 1 || d1.Month == 2 || d1.Month == 3) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الاول"; }
                            else if (d1.Month == 4 || d1.Month == 5 || d1.Month == 6) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الثاني"; }
                            else if (d1.Month == 7 || d1.Month == 8 || d1.Month == 9) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الثالث"; }
                            else if (d1.Month == 10 || d1.Month == 11 || d1.Month == 12) { dataGridViewX1.Rows[i].Cells[5].Value = "الربع الرابع"; }
                        }


                    }

                    for (int i = 0; i < dataGridViewX1.RowCount - 1; i++)
                    {
                        sum_1 += Convert.ToDouble(dataGridViewX1.Rows[i].Cells[3].Value);
                    }




                    lbl2.Text = sum_1.ToString();
                    dataGridViewX1.Rows[dataGridViewX1.RowCount - 1].Cells[3].Value = Math.Round(txtAmount.Value - sum_1, 2);


                    for (int i = 0; i < dataGridViewX1.RowCount; i++)
                    {
                        sum += Convert.ToDouble(dataGridViewX1.Rows[i].Cells[3].Value);
                    }
                    lbl1.Text = sum.ToString();

                //}
            
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            dataGridViewX1.Rows.Clear();
        }

        private void txtDescribtion_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void S_Date_Load_1(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
        }

        private void E_Date_Load_1(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
        }

        private void S_Date_Leave_1(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
        }

        private void E_Date_Leave_1(object sender, EventArgs e)
        {
            dataGridViewX1.Rows.Clear();
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
           
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void BNew_Click(object sender, EventArgs e)
        {
            ClearTextBoxes();
            dataGridViewX1.Rows.Clear();
            saveType = "add";
            BSave.Text = "حفظ";
            frmType = "input";
   
            get_Id();

            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).BackColor = Color.White;
                    else if (control is MaskedTextBox)
                        (control as MaskedTextBox).BackColor = Color.White;
                    else
                        func(control.Controls);
            };
            func(Controls);


        }
        private void ClearTextBoxes()
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Text="";
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;
                    else if (control is DevComponents.DotNetBar.Controls.ComboBoxEx)
                        (control as DevComponents.DotNetBar.Controls.ComboBoxEx).SelectedIndex = -1;
                    else if (control is MaskedTextBox)
                        (control as MaskedTextBox).Clear();
                    
                    else
                        func(control.Controls);
            };
            func(Controls);
            txtCost.ID.Text = "1";
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            try
            {
                saveType = "Edit";
                frmType = "search";
                BSave.Text = "تعديل";
                frmSerch_PE frm = new frmSerch_PE();
                frm.ShowDialog();
                txtID.Text = frm.dataGridViewX1.CurrentRow.Cells[0].Value.ToString();

            }
            catch { }
        }
      

        //--------------- كود جعل مفتاح الادخال مثل مفتاح التاب --------------------
        private void frmCars_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }

        }


        private void SearchDG()
        {


            DataTable dt_ = dal.getDataTabl_1("select * from P_expenses_T2 where ID='" + txtID.Text + "' order by p_ser");
            dataGridViewX1.RowCount=dt_.Rows.Count;

            for (int i = 0; i < dataGridViewX1.RowCount; i++)
            {
                dataGridViewX1.Rows[i].Cells[0].Value = dt_.Rows[i][1];
                dataGridViewX1.Rows[i].Cells[1].Value = Convert.ToDateTime(dt_.Rows[i][2].ToString());
                dataGridViewX1.Rows[i].Cells[2].Value = dt_.Rows[i][3];
                dataGridViewX1.Rows[i].Cells[3].Value = Convert.ToDecimal(dt_.Rows[i][4]);
                dataGridViewX1.Rows[i].Cells[4].Value = dt_.Rows[i][5];
                dataGridViewX1.Rows[i].Cells[5].Value = dt_.Rows[i][6];

            }
            
            //   dt.Clear();
          //   int i = 0;
          //   DataRow row = null;
          //   foreach (DataRow r in dt_.Rows)
          //{
          //     row = dt.NewRow();
          //     row[0] = dt_.Rows[i][1];
          //     row[1] = Convert.ToDateTime(dt_.Rows[i][2].ToString());
          //     row[2] = dt_.Rows[i][3];
          //     row[3] = Convert.ToDecimal(dt_.Rows[i][4]);
          //     row[4] = dt_.Rows[i][5];
          //     row[5] = dt_.Rows[i][6];
          //      dt.Rows.Add(row);
          //      i = i + 1;
          //  }
          // dataGridViewX1.DataSource = dt;
          }

        void creatDattable()
        {
            dt.Columns.Add("مسلسل");
            dt.Columns.Add("تاريخ الاستحقاق");
            dt.Columns.Add("ايام الاستحقاق");
            dt.Columns.Add("المبلغ");
            dt.Columns.Add("العام");
            dt.Columns.Add("الفترة");

            //dgv_1.DataSource = dt;
        }

        private void txtID_TextChanged(object sender, EventArgs e)
        {
            try
            {
                if (frmType == "search")
                {
                    DataTable dt_1 = dal.getDataTabl_1("SELECT *  FROM P_expenses_T1 where ID ='" + txtID.Text + "'");

                    txtID.Text = dt_1.Rows[0][0].ToString();
                    txtAmount.Value = Convert.ToDouble(dt_1.Rows[0][1]);
                    Acc_.ID.Text = dt_1.Rows[0][2].ToString();
                    txtDescribtion.Text = dt_1.Rows[0][3].ToString();
                    UC_AccBranch.ID.Text = dt_1.Rows[0][4].ToString();
                    UC_Catogry.ID.Text = dt_1.Rows[0][5].ToString();
                    S_Date.GD.Text = dt_1.Rows[0][6].ToString();
                    S_Date.HD.Text = dt_1.Rows[0][7].ToString();
                    E_Date.GD.Text = dt_1.Rows[0][8].ToString();
                    E_Date.HD.Text = dt_1.Rows[0][9].ToString();
                    Acc_1.ID.Text= dt_1.Rows[0][10].ToString();
                    clac_();
                    SearchDG();
                }
            }
            catch
            {
                ClearTextBoxes();
                dataGridViewX1.Rows.Clear();
            }
        }

        private void txtID_KeyUp(object sender, KeyEventArgs e)
        {
          
            try
            {
                if (frmType == "search")
                {
                    DataTable dt_1 = dal.getDataTabl_1("SELECT *  FROM P_expenses_T1 where ID ='" + txtID.Text + "'");

                    txtID.Text = dt_1.Rows[0][0].ToString();
                    txtAmount.Value = Convert.ToDouble(dt_1.Rows[0][1]);
                    Acc_.ID.Text = dt_1.Rows[0][2].ToString();
                    txtDescribtion.Text = dt_1.Rows[0][3].ToString();
                    UC_AccBranch.ID.Text = dt_1.Rows[0][4].ToString();
                    UC_Catogry.ID.Text = dt_1.Rows[0][5].ToString();
                    S_Date.GD.Text = dt_1.Rows[0][6].ToString();
                    S_Date.HD.Text = dt_1.Rows[0][7].ToString();
                    E_Date.GD.Text = dt_1.Rows[0][8].ToString();
                    E_Date.HD.Text = dt_1.Rows[0][9].ToString();

                    SearchDG();
                }
            }
            catch {
                ClearTextBoxes();
                dataGridViewX1.Rows.Clear();
            }
        }

        private void Prepaid_expenses_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyData == System.Windows.Forms.Keys.Enter)
            {

                SendKeys.Send("{TAB}");
            }
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            if (ValidateData() == false)
                return;

            if (dataGridViewX1.Rows.Count <= 0)
            {
                MessageBox.Show("لاتوجد بيانات في الجدول", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            if (saveType == "add")
            {
                get_Id();
                save_();
              
            }
            else
            {
                delete_();
                save_();

            }
            saveType = "Edit";
            BSave.Text = "تعديل";

        }

        private void save_()
        {
        
             
                
            dal.Execute_1(@"INSERT INTO P_expenses_T1 (id,amount,kind,descr,branch_code,category_code,s_date,s_date_H,e_date,e_date_H,Acc_no_P,costCode)
            VALUES('" + txtID.Text + "', '" + txtAmount.Value + "', '" + Acc_.ID.Text +
            "', '" + txtDescribtion.Text + "','" + UC_AccBranch.ID.Text + "','" + UC_Catogry.ID.Text +
            "','" + S_Date.GD.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + S_Date.HD.Text + "','" +
            E_Date.GD.Value.ToString("yyyy-MM-dd HH:mm:ss") + "','" + E_Date.HD.Text + "','" + Acc_1.ID.Text + "','"+txtCost.ID.Text +"')");
            for (int i = 0; i <= dataGridViewX1.Rows.Count - 1; i++)
            {
                DataGridViewRow DgRow = dataGridViewX1.Rows[i];
                if (DgRow.Cells[1].Value != null && DgRow.Cells[2].Value != null && DgRow.Cells[3].Value != null)
                {
                    dal.Execute_1(@"INSERT INTO P_expenses_T2(id,P_ser,p_date,P_days,p_amount,p_year,p_Quarter)
                     VALUES ('" + txtID.Text + "','" + DgRow.Cells[0].Value + "','" + (Convert.ToDateTime(DgRow.Cells[1].Value)).ToString("yyyy-MM-dd HH:mm:ss") + "','" + DgRow.Cells[2].Value + "','" + DgRow.Cells[3].Value + "','" + DgRow.Cells[4].Value + "','" + DgRow.Cells[5].Value + "')");

                }
            }
                MessageBox.Show("تم حفظ البيانات بنجاح", "تاكيد الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
           

        }


        private void delete_()
        {
            dal.Execute_1("DELETE FROM P_expenses_T2 WHERE id ='"+txtID.Text+"'");
            dal.Execute_1("DELETE FROM P_expenses_T1 WHERE id ='" + txtID.Text + "'");
        }


        private void BDelete_Click(object sender, EventArgs e)
        {
           

        }

        private void buttonItem1_Click(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1("select A.*,B.*,D.BRANCH_name,C.CAT_NAME from P_expenses_T1 as A inner join P_expenses_T2 as B on A.id=B.id " +
           "left join main_acc_wh.dbo.CATEGORY AS C ON A.category_code=C.CAT_CODE " +
           "inner join main_acc_wh.dbo.BRANCHS AS D ON A.branch_code=D.BRANCH_code where A.id ='" + txtID.Text + "'");
            DataSet ds_ = new DataSet();
            ds_.Tables.Add(dt_);
            RPT.rpt_P_expenses rpt = new RPT.rpt_P_expenses();
            RPT.Form1 frm = new RPT.Form1();
            rpt.SetDataSource(ds_);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.ShowDialog();


            //
            ds_.WriteXmlSchema("schema1.xml");
        }

        private void txtAmount_ValueChanged(object sender, EventArgs e)
        {
         
        }

        private void UC_AccBranch_Load(object sender, EventArgs e)
        {

            if (checkAcc(UC_AccBranch.ID.Text, Acc_.ID.Text) == false)
            {
                Acc_.branchID.Text = UC_AccBranch.ID.Text;
                Acc_.ID.Clear();
            }

        }

        private void labelX15_Click(object sender, EventArgs e)
        {

        }

       
        bool checkAcc(string branchID,string accNo)
        {
            if (dal.getDataTabl_1("select PAYER_NAME from payer2  where ACC_NO = '"+ accNo+ "' and BRANCH_code = '" + branchID + "' and t_final = '1'").Rows.Count > 0)
            {
                return true;
            }
            else
            {
            return false;
            }

        }
        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


    }
}
