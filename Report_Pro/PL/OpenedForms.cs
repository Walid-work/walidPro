using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class OpenedForms : Form
    {
        public OpenedForms()
        {
            InitializeComponent();
        }

        private void showForms()
        {
            this.Enabled = false;
            lblCount.Text = (Application.OpenForms.Count - 2).ToString();
            lbxFormText.Items.Clear();
            lbxFormName.Items.Clear();
            foreach (Form frm in Application.OpenForms)
            {
                if (frm.Name == "login_frm" || frm.Name == "Frm_Main") continue;
                lbxFormText.Items.Add(frm.Text);
                lbxFormName.Items.Add(frm.Name);
            }
            this.Enabled = true;
        }
        private void OpenedForms_Load(object sender, EventArgs e)
        {
            showForms();
        }

        private void lbxFormName_DoubleClick(object sender, EventArgs e)
        {
            Form f = Application.OpenForms[lbxFormName.SelectedIndex];
            if (f != null)
            {
                f.Activate();
            }
        }

        private void lbxFormText_DoubleClick(object sender, EventArgs e)
        {
            if (lbxFormName.Items.Count > 0 && lbxFormText.Items.Count > 0 && lbxFormText.SelectedIndex > -1)

            {
                Form f = Application.OpenForms[lbxFormName.Items[lbxFormText.SelectedIndex].ToString()];
                if (f != null)
                {
                    f.Activate();
                }
            }
        }

        private void cbxUpdate_CheckedChanged(object sender, EventArgs e)
        {
            timer1.Enabled = cbxUpdate.Checked;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            showForms();
        }

        private void btnUpdatForms_Click(object sender, EventArgs e)
        {
            showForms();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
