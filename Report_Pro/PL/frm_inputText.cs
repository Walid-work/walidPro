using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_inputText : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_inputText()
        {
            InitializeComponent();
        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void frm_inputText_Load(object sender, EventArgs e)
        {

        }

        private void btnOk_Click(object sender, EventArgs e)
        {
            if(txtSearch.Text.Trim() != "")
            {
                DataTable dt_RQ = dal.getDataTabl("get_R_Qutation_", txtSearch.Text, dal.db1);
                if (dt_RQ.Rows.Count > 0)
                {
                    this.Close();
                }
                else
                {
                    this.Close();
                    MessageBox.Show("تاكد من الرقم", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("ادخل الرقم للبحث", "", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            
            this.Close();
           
        }
    }
    }
