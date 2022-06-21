using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class Form2 : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();


        public Form2()
        {
            InitializeComponent();
        }





        private void dataGridViewX1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                e.Handled = true;

               

                int col = dataGridViewX1.CurrentCell.ColumnIndex;
                int row = dataGridViewX1.CurrentCell.RowIndex;
                if (col < dataGridViewX1.ColumnCount - 1) //if last column
                {
                    if (col == 1)
                    {

                        get_desc(dataGridViewX1.CurrentCell, "", dataGridViewX1.Rows[row].Cells[2]);
                       
                    }

                    else if (col == 4)
                    {

                        getCostCenter(dataGridViewX1.CurrentCell, "", dataGridViewX1.Rows[row].Cells[5]);
                        
                    }
                    else if (col == 6)
                    {

                        getCat(dataGridViewX1.CurrentCell, "", dataGridViewX1.Rows[row].Cells[7]);
                       
                    }
                    else
                    {


                        dataGridViewX1.CurrentCell = dataGridViewX1.Rows[row].Cells[col + 1];
                        dataGridViewX1.Focus();
                    }
                }
                else if (col == dataGridViewX1.ColumnCount - 1)
                {
                    if (row == dataGridViewX1.RowCount - 1)
                    {
                        dataGridViewX1.Rows.Add(1);
                    }
                    dataGridViewX1.CurrentCell = dataGridViewX1.Rows[row + 1].Cells[0];
                    dataGridViewX1.Focus();
                }

            }

        }

        private void dataGridViewX1_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            int col = dataGridViewX1.CurrentCell.ColumnIndex;
            int row = dataGridViewX1.CurrentCell.RowIndex;

            if (col == 0)
            {

                
                dataGridViewX1.CurrentCell = dataGridViewX1.Rows[row].Cells[col + 1];
                SendKeys.Send("{up}");
                //SendKeys.Send("{Left}");

            }


            if (col == 1)
            {

                get_desc(dataGridViewX1.CurrentCell, "", dataGridViewX1.Rows[row].Cells[2]);
                dataGridViewX1.CurrentCell = dataGridViewX1.Rows[row].Cells[col+2];
                SendKeys.Send("{up}");
                //SendKeys.Send("{Left}");

            }
            else if (col == 4)
            {

                getCostCenter(dataGridViewX1.CurrentCell, "", dataGridViewX1.Rows[row].Cells[5]);
                dataGridViewX1.CurrentCell = dataGridViewX1.Rows[row].Cells[col + 2];
                SendKeys.Send("{up}");
            }
            else if (col == 6)
            {

                getCat(dataGridViewX1.CurrentCell, "", dataGridViewX1.Rows[row].Cells[7]);
                
            }
            else
            {
                SendKeys.Send("{up}");
            }
            
        }








        private void get_desc(DataGridViewCell _id, string branchID, DataGridViewCell _desc)
        {

            //try
            //{
            DataTable dt_ = dal.getDataTabl_1(@"select A.PAYER_NAME,A.payer_l_name from payer2 As A 
                   where A.ACC_NO= '" + _id.Value + "'  and A.BRANCH_code like '" + branchID + "'+'%' and A.t_final = 1 ");


            if (dt_.Rows.Count > 0)
            {
                if (Properties.Settings.Default.lungh == "0")
                {
                    _desc.Value = dt_.Rows[0]["PAYER_NAME"].ToString();
                }
                else
                {
                    _desc.Value = dt_.Rows[0]["payer_l_name"].ToString();
                }
                dataGridViewX1.CurrentCell = dataGridViewX1.CurrentRow.Cells[_id.ColumnIndex + 2];
            }
            else
            {
                _id.Value = "";
                _desc.Value = "";
                dataGridViewX1.CurrentCell = _id;
                PL.frm_SearchAcc frm = new PL.frm_SearchAcc();
                frm.ShowDialog();
                _id.Value = frm.DGV1.CurrentRow.Cells[0].Value.ToString();
                _desc.Value = frm.DGV1.CurrentRow.Cells[1].Value.ToString();
              //  dataGridViewX1.CurrentCell = dataGridViewX1.CurrentRow.Cells[_id.ColumnIndex + 2];
                
            }
            //  }
            //  catch { }
        }


        private void getCostCenter(DataGridViewCell _id, string branchID, DataGridViewCell _desc)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("select Cost_name  FROM COST_CENTER where COST_CODE = '" + _id.Value + "'");
                if (dt_.Rows.Count > 0)
                {
                    _desc.Value = dt_.Rows[0][0].ToString();
                }
                else
                { _desc.Value = ""; }
                dataGridViewX1.CurrentCell = dataGridViewX1.CurrentRow.Cells[_id.ColumnIndex + 2];
            }
            catch { }
        }

        private void getCat(DataGridViewCell _id, string branchID, DataGridViewCell _desc)
        {
            try
            {
                DataTable dt_ = dal.getDataTabl_1("SELECT CAT_NAME  FROM CATEGORY where CAT_CODE='" + _id.Value + "' ");
                if (dt_.Rows.Count > 0)
                {
                    _desc.Value = dt_.Rows[0][0].ToString();
                }
                else
                { _desc.Value = ""; }


                if (_id.RowIndex == dataGridViewX1.RowCount - 1)
                {
                    dataGridViewX1.Rows.Add(1);
                }
                dataGridViewX1.CurrentCell = dataGridViewX1.Rows[_id.RowIndex + 1].Cells[0];
                dataGridViewX1.Focus();
            }

            catch { }
        }


        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
           
        }
    }
}
