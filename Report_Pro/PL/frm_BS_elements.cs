using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_BS_elements : Form
    {

        string savtype = "0";
        string btntype = "0";
        Int32 m;
        DataTable dt = new DataTable();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();

        public frm_BS_elements()
        {
            InitializeComponent();
            creatDattable();
            dGV_Item.EnableHeadersVisualStyles = false;
            resizeDG();
            getJorSer();
        }


        void creatDattable()
        {
            dt.Columns.Add("مدين");
            dt.Columns.Add(" دائن");
            dt.Columns.Add(" كود الحساب");
            dt.Columns.Add(" اسم الحساب");
            dt.Columns.Add("البيان");
            dGV_Item.DataSource = dt;
        }

        void resizeDG()
        {
            dGV_Item.Columns[0].Width = txt_Db.Width;
            dGV_Item.Columns[1].Width = txt_Cr.Width;
            dGV_Item.Columns[2].Width = txt_accNo.Width;
            dGV_Item.Columns[3].Width = txt_accName.Width;
            dGV_Item.Columns[4].Width = txt_Desc.Width;
          

            foreach (DataGridViewRow row in this.dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                dGV_Item.EnableHeadersVisualStyles = false;


            }
        }

        void addrow_new()
        {
            DataRow r = dt.NewRow();
            r[0] = txt_Db.Text;
            r[1] = txt_Cr.Text;
            r[2] = txt_accNo.Text;
            r[3] = txt_accName.Text;
            r[4] = txt_Desc.Text;
            dt.Rows.Add(r);
            dGV_Item.DataSource = dt;
            dGV_Item.CurrentCell = dGV_Item.Rows[dGV_Item.Rows.Count - 1].Cells[0];


            clear_texts();

            total_inv();
            resizeDG();
        }

        void editrow()
        {
            dGV_Item.Rows[m].Cells[0].Value = txt_Db.Text;
            dGV_Item.Rows[m].Cells[1].Value = txt_Cr.Text;
            dGV_Item.Rows[m].Cells[2].Value = txt_accNo.Text;
            dGV_Item.Rows[m].Cells[3].Value = txt_accName.Text;
            dGV_Item.Rows[m].Cells[4].Value = txt_Desc.Text;
           

            total_inv();
            clear_texts();

            resizeDG();

        }



        void clear_texts()
        {
            txt_Db.Value = 0;
            txt_Cr.Value = 0;
            txt_accNo.Clear();
            txt_accName.Text = "";
            txt_Desc.Clear();
           

        }

        void total_inv()
        {
            totalDebit.Text =
                (from DataGridViewRow row in dGV_Item.Rows
                 where row.Cells[2].FormattedValue.ToString() != string.Empty
                 // select Convert.ToDouble(row.Cells[0].FormattedValue)).Sum().ToString();
                 select Convert.ToDecimal((row.Cells[0].FormattedValue).ToString())).Sum().ToString();
            totalCredit.Text =
               (from DataGridViewRow row in dGV_Item.Rows
                where Convert.ToString(row.Cells[2].FormattedValue) != string.Empty
                //select Convert.ToDouble(row.Cells[1].FormattedValue)).Sum().ToString();
                select (row.Cells[1].FormattedValue).ToString().ToDecimal()).Sum().ToString();

            txtdiff.Text = ((Convert.ToDecimal(totalDebit.Text) - Convert.ToDecimal(totalCredit.Text)).ToString());

            if (Convert.ToDecimal(totalDebit.Text).ToString() == Convert.ToDecimal(totalCredit.Text).ToString())
            {
                pictureBox2.Image = global::Report_Pro.Properties.Resources.Ok_icon;
            }
            else
            {
                pictureBox2.Image = global::Report_Pro.Properties.Resources.Exit_icon;

            }

        }



        private void txtSerNo_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void groupPanel4_Click(object sender, EventArgs e)
        {

        }

        private void txt_Db_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_Db.Text.ToDecimal() != 0)
                {
                    txt_Cr.Text = "0";
                    txt_Cr.Focus();
                }
                else
                {
                    txt_Cr.Focus();
                }

            }

        }

        private void txt_Cr_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {

                if (txt_Cr.Text.ToDecimal() != 0)
                {
                    txt_Db.Text = "0";
                    txt_accNo.Focus();
                }

                else
                {
                    txt_accNo.Focus();
                }

            }

        }

        private void txt_Db_Leave(object sender, EventArgs e)
        {
            if (txt_Db.Text.ToDecimal() != 0)
            {
                txt_Cr.Text = "0";

            }

        }

        private void txt_Cr_Leave(object sender, EventArgs e)
        {
            if (txt_Cr.Text.ToDecimal() != 0)
            {
                txt_Db.Text = "0";

            }

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            if ((txt_Db.Value > 0 || txt_Cr.Value > 0) && txt_accNo.Text != "")

            {
                total_inv();

                if (btntype == "0")
                {
                    addrow_new();
                    btntype = "0";
                    txt_Db.Focus();


                }
                else if (btntype == "1")
                {
                    editrow();
                    btntype = "0";
                    txt_Db.Focus();
                }
            }
            else
            {
                MessageBox.Show("تأكد من البيانات", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void txt_Desc_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               btnEnter.Focus();
            }
            else if (e.KeyCode == Keys.F2)
            {
                txt_Desc.Text = dGV_Item.Rows[dGV_Item.Rows.Count - 1].Cells[4].Value.ToString();
            }
        }

        private void txt_accNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter )
                //&& txt_accNo.Text != string.Empty)
            {
                DataTable dt = new DataTable();
                dt = dal.getDataTabl_1("select * FROM " + Properties.Settings.Default.Database_1 + ".dbo.MEZANIA_ARBAH_CHART where Gr_Code='" + txt_accNo.Text + "' and t_final='1' ");
                if (dt.Rows.Count > 0)
                {
                    txt_accName.Text = dt.Rows[0][1].ToString();
                    txt_Desc.Focus();

                }
                else
                {
                    txt_accNo.Clear();
                    txt_accName.Text = "";
                    PL.frmSearchAcc F = new frmSearchAcc();
                    F.ShowDialog();
                    int ii = F.DGV1.CurrentCell.RowIndex;


                    txt_accNo.Text = F.DGV1.Rows[ii].Cells[0].Value.ToString();
                    txt_accName.Text = F.DGV1.Rows[ii].Cells[1].Value.ToString();
                  
                    txt_Desc.Focus();

                }
            }
        }
            void add_element_jor()
            {
            if(totalDebit.Value != totalCredit.Value || totalDebit.Value<=0 || totalCredit.Value <=0)
            {
                MessageBox.Show("تأكد من توازن القيد", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

                for (int i = 0; i <= dGV_Item.Rows.Count - 1; i++)
                {
                    DataGridViewRow DgRow = dGV_Item.Rows[i];
                    if (dGV_Item.Rows[i].Cells[2].Value != null)
                    {
                        if (dGV_Item.Rows[i].Cells[0].Value == null)
                        {
                            dGV_Item.Rows[i].Cells[0].Value = 0;
                        }

                        if (dGV_Item.Rows[i].Cells[1].Value == null)
                        {
                            dGV_Item.Rows[i].Cells[1].Value = 0;
                        }


                        dal.Execute_1(@"INSERT INTO tbl1 (ser_no,acc_Code,debit,credir,desription,G_date)
                        VALUES ('"+txtSerNo.Text.ToString()+"','"+ DgRow.Cells[2].Value.ToString()+"','"+
                        DgRow.Cells[0].Value.ToString().ToDecimal()+"','"+DgRow.Cells[1].Value.ToString().ToDecimal()+
                        "','"+dGV_Item.Rows[i].Cells[4].Value.ToString()+"','"+dateTimePicker1.Value.ToString("yyyy-MM-dd HH:mm:ss") +"')");

                    }

                }
            MessageBox.Show("تم الحفظ بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            BSave.Enabled = false;
            BEdit.Enabled = true;


        }

        private void getJorSer()
        {
            string serNo= dal.getDataTabl_1("select isnull(max(ser_no)+1,1) FROM tbl1").Rows[0][0].ToString();
            txtSerNo.Text =serNo;
        

        }

        private void BNew_Click(object sender, EventArgs e)
        {
            
            savtype = "0";
            dateTimePicker1.Value = DateTime.Now;
            txtsearch.Clear();
            groupBox1.Visible = false;
            txtSerNo.Clear();
            getJorSer();
            dt.Clear();
            dGV_Item.DataSource = null;
            BSave.Enabled = true;
            BEdit.Enabled = false;

         
        }

        private void BSave_Click(object sender, EventArgs e)
        {
            add_element_jor();
        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            groupBox1.Visible = true;
            txtsearch.Focus();
        }

        private void btn_Srearch_Click(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dGV_Item.Rows)
            {
                row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
            }
            clear_texts();
            showDetails(txtsearch.Text);

            savtype = "1";
            // BSave.Enabled = false;
            BEdit.Enabled = true;
        }

        private void showDetails(string serchtext_)
        {


            ////==============================  احضار تفاصيل القيد =========================================================//
            int count_ = 0;
            DataTable dt_ = new DataTable();
            dt_.Clear();
            dt_ = dal.getDataTabl_1("SELECT*  FROM tbl1 As T inner join MEZANIA_ARBAH_CHART As M on M.Gr_Code=T.acc_Code  where T.ser_no ='" + serchtext_+"'");
            if (dt_.Rows.Count > 0)
            {
                txtSerNo.Text = dt_.Rows[0][0].ToString();
                dateTimePicker1.Text = dt_.Rows[0][5].ToString();
               


                dt.Clear();
                int i = 0;
                DataRow row = null;
                foreach (DataRow r in dt_.Rows)
                {

                    row = dt.NewRow();
                    row[0] = Convert.ToDecimal(dt_.Rows[i][2]).ToString("n" + dal.digits_);
                    row[1] = Convert.ToDecimal(dt_.Rows[i][3]).ToString("n" + dal.digits_);
                    row[2] = dt_.Rows[i][1].ToString();
                    row[3] = dt_.Rows[i][8].ToString();
                    row[4] = dt_.Rows[i][4].ToString();
                    

                    dt.Rows.Add(row);
                    i = i + 1;
                }

                dGV_Item.DataSource = dt;
                resizeDG();
                total_inv();

            }


            else
            {
                MessageBox.Show(" رقم القيد غير موجود .... فضلا تأكد من الرقم ", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txtsearch.Focus();
                txtsearch.SelectAll();
            }

        }

        private void BEdit_Click(object sender, EventArgs e)
        {
            delete_element_jor();
            add_element_jor();
    }

        void delete_element_jor()
        {
            dal.Execute_1("DELETE FROM tbl1 WHERE ser_no='"+ txtSerNo.Text.ToString() + "'");
        }

        private void dGV_Item_DoubleClick(object sender, EventArgs e)
        {
            btntype = "1";
            m = dGV_Item.CurrentRow.Index;
            try
            {
                //DataTable itemdata_ = dal.getDataTabl("get_product_name", dGV_Item.CurrentRow.Cells[0].Value.ToString(), Properties.Settings.Default.CoId);
                txt_Db.Text = dGV_Item.CurrentRow.Cells[0].Value.ToString();
                txt_Cr.Text = dGV_Item.CurrentRow.Cells[1].Value.ToString();
                txt_accNo.Text = dGV_Item.CurrentRow.Cells[2].Value.ToString();
                txt_accName.Text = dGV_Item.CurrentRow.Cells[3].Value.ToString();
                txt_Desc.Text = dGV_Item.CurrentRow.Cells[4].Value.ToString();
                txt_Db.Focus();
            }
            catch
            {
                return;
            }
        }

        private void txtsearch_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtsearch.Text != string.Empty)
            {
                btn_Srearch.Focus();
            }
        }

        private void previous__Click(object sender, EventArgs e)
        {

        }

        private void BtnDelRow_Click(object sender, EventArgs e)
        {
            if (this.dGV_Item.SelectedRows.Count > 0)
            {
                dGV_Item.Rows.RemoveAt(this.dGV_Item.SelectedRows[0].Index);
                total_inv();
                foreach (DataGridViewRow row in this.dGV_Item.Rows)
                {
                    row.HeaderCell.Value = string.Format("{0}", row.Index + 1);
                }
            }
        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {
            RPT.Form1 frm = new RPT.Form1();

            RPT.rpt_print_Emplement_jor rpt = new RPT.rpt_print_Emplement_jor();
            DataSet ds = new DataSet();
            DataTable dt1 = new DataTable();

            dt1 = dal.getDataTabl_1("SELECT *  FROM tbl1 As T inner join MEZANIA_ARBAH_CHART As M on M.Gr_Code=T.acc_Code  where T.ser_no ='" + txtSerNo.Text + "'");
            ds.Tables.Add(dt1);
            //ds.WriteXmlSchema("schema_rpt.xml");
            rpt.SetDataSource(ds);
            frm.crystalReportViewer1.ReportSource = rpt;
            frm.WindowState = FormWindowState.Maximized;

            frm.ShowDialog();
          
        }

        private void BtnPrint_all_Click(object sender, EventArgs e)
        {
            RPT.frm_from_toDate frm = new RPT.frm_from_toDate();
            frm.Show();
        }

        private void frm_BS_elements_Load(object sender, EventArgs e)
        {

        }

        private void labelX28_Click(object sender, EventArgs e)
        {

        }

        private void txt_Desc_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX17_Click(object sender, EventArgs e)
        {

        }

        private void txt_accName_Click(object sender, EventArgs e)
        {

        }

        private void labelX29_Click(object sender, EventArgs e)
        {

        }

        private void txt_accNo_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
