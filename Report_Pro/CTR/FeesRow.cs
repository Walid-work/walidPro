using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.CTR
{
    public partial class FeesRow : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public FeesRow()
        {
            InitializeComponent();
        }

        private void txtNote_KeyDown(object sender, KeyEventArgs e)
        {
            OnKeyDown(e);
        }

        private void txtAmount_KeyUp(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void txtAmount_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode==Keys.Enter )
            {
                txtDiscription.Focus();
            
            }
        }

        private void txtDiscription_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtDiscription.Text.Trim()!= string.Empty)
            {
                txt_R_Date.Focus();

            }
        }

        private void txtAmount_ValueChanged(object sender, EventArgs e)
        {

        }

        private void txtamount_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
            txtType.Focus();
            }
        }

        private void txtamount_KeyUp_1(object sender, KeyEventArgs e)
        {
            OnKeyUp(e);
        }

        private void dateTimeInput1_KeyDown(object sender, KeyEventArgs e)
        {

        }

        private void txt_R_Date_KeyDown(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter && dal.IsDateTime(txt_R_Date.Text))
            {
                txtNote.Focus();
            }
        }

        private void txtType_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txtType.Text!= string.Empty)
            {
                txtDiscription.Focus();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            OnClick(e);
            this.Dispose();

        }

        private void txtType_TextChanged(object sender, EventArgs e)
        {
            //Action<Control.ControlCollection> func = null;

            //func = (controls) =>
            //{

            //    foreach (Control ctrl in controls)
            //        if (txtType.Text == "فواتير")
            //        {
            //            ctrl.BackColor = System.Drawing.SystemColors.Info;
            //        }
            //        else {

            //            ctrl.BackColor = Color.White;
            //        }

            //};

            //func(Controls);

            //OnEnabledChanged(e);
        }

        private void FeesRow_EnabledChanged(object sender, EventArgs e)
        {

        }

        private void FeesRow_MouseClick(object sender, MouseEventArgs e)
        {
          
        }

        private void txtamount_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void Ser_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void txtType_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void txtDiscription_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void txt_R_Date_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }

        private void txtNote_MouseClick(object sender, MouseEventArgs e)
        {
            OnMouseClick(e);
        }
    }
}
