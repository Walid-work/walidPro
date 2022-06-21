using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;

using System.Text;

using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class JorRow : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public JorRow()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Dispose();
           // OnClick(e);
        }

        private void txtDebit_ValueChanged(object sender, EventArgs e)
        {
            OnLoad(e);
        }


      


     



   

      

        private void txtAccDesc_Click(object sender, EventArgs e)
        {

        }

        private void Jor_Row_Load(object sender, EventArgs e)
        {
            branchID.Text = Properties.Settings.Default.BranchAccID;

            
        }

        private void txtBalance_Click(object sender, EventArgs e)
        {

        }

      
       

        private void txtDescription_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter && txtDescription.t.Text.Trim()!= string.Empty)
            //{
            //    myText1.Focus();

            //}
           
        }

        private void txtCatID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtCostID_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txtDebit_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txtCredit_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txtDocument_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtDocDate.Focus();
            }
        }

        private void txtDocDate_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
               txtVatNo.Focus();
            }
        }

        private void txtVatNo_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                txtAcc_2.Focus();
            }
        }

        private void txtAcc_2_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void txtDocDate_Click(object sender, EventArgs e)
        {

        }

        private void txtCredit_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtDescription_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatID_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtCatDesc_Click(object sender, EventArgs e)
        {

        }

        private void txtDocument_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtVatNo_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void txtDb_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{

            //    if (txtDb.d.Value != 0)
            //    {
            //        txtCr.d.Value = 0;
            //        txtCr.d.Focus();
            //    }
            //    else
            //    {
            //        txtCr.d.Focus();
            //    }

            //}



        }

        private void txtDb_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txtDb_Leave(object sender, EventArgs e)
        {
            //if (txtDb.d.Value != 0)
            //{
            //    txtCr.d.Value = 0;

            //}
        }

        private void txtCr_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{

            //    if (txtCr.d.Value != 0)
            //    {
            //        txtDb.d.Value = 0;
            //      acc_no.Focus();
            //    }

            //    else
            //    {
            //        acc_no.Focus();
            //    }

            //}
        }

        private void txtCr_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txtCr_Leave(object sender, EventArgs e)
        {
            //if (txtCr.d.Value != 0)
            //{
            //    txtDb.d.Value = 0;

            //}
        }

        private void txtAccID_KeyDown(object sender, KeyEventArgs e)
        {
          
        }

       

        private void txtCat_KeyDown(object sender, KeyEventArgs e)
        {
            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (myText1.Text.Trim() != string.Empty)
            //    {
            //        myText2.Focus();
            //    }
            //    else
            //    {
            //        myText1.Text = "1";
            //        myText2.Focus();

            //    }
            //}
        }

        private void txtCost_KeyDown(object sender, KeyEventArgs e)
        {

            //if (e.KeyCode == Keys.Enter)
            //{
            //    if (myText2.Text.Trim() == string.Empty)
            //    {
            //        myText2.Text = "1";
            //    }

            //    if (acc_no.Text.StartsWith("238"))
            //    {
            //        txtDocument.Focus();
            //    }
            //    else
            //    {
            //        OnKeyDown(e);

            //    }
            //}

        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            OnClick(e);
        }

      

        private void txtDescription_KeyPress(object sender, KeyPressEventArgs e)
        {
            OnKeyPress(e);
        }

       

        private void buttonX2_DoubleClick(object sender, EventArgs e)
        {
            
        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            OnDoubleClick(e);
        }

        private void txtCost_Load(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //txtDescription.Focus();
            //OnClick(e);
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            //txtDb.Focus();
            //OnDoubleClick(e);
        }

        private void Acc__KeyDown(object sender, KeyEventArgs e)
        {
            //if (acc_no.Text.Trim() != string.Empty && e.KeyCode == Keys.Enter)
            //{
            //    txtDescription.Focus();
            //}

        }

        private void Acc__Load(object sender, EventArgs e)
        {

        }

        private void ser__Click(object sender, EventArgs e)
        {

        }

        private void txtBalance_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void ser__TextChanged(object sender, EventArgs e)
        {
            rowBackcolor();
        }
        private void rowBackcolor()
        {
            if ((ser_.Text.ToDecimal()) % 2 == 0)
            {
                this.BackColor = Color.Bisque;
            }
            else
            {
                this.BackColor = Color.Transparent;
            }
        }

        private void txtDescription_Load(object sender, EventArgs e)
        {

        }

        private void txtDocument_Load(object sender, EventArgs e)
        {

        }
    }

}
