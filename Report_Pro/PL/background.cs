using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class background : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public background()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void changeColor_Click(object sender, EventArgs e)
        {
            panel_Review.BackColor = ((Panel)sender).BackColor;
        }

        private void btnOkColor_Click(object sender, EventArgs e)
        {
            int R = panel_Review.BackColor.R;
            int G = panel_Review.BackColor.G;
            int B = panel_Review.BackColor.B;
            try
            {
                dal.Execute_1("update "+Properties.Settings.Default.Database+".dbo.setting_bg_font set R=" + R + ", G=" + G + ", B=" + B + " where id='Chiled' ");
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel13_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnOkColorMain_Click(object sender, EventArgs e)
        {
            int R = panel_Review.BackColor.R;
            int G = panel_Review.BackColor.G;
            int B = panel_Review.BackColor.B;
            try
            {
                dal.Execute_1("update ReportDB.dbo.setting_bg_font set R=" + R + ", G=" + G + ", B=" + B + " where id='Main' ");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }
    }
}
