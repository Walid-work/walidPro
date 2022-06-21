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
    public partial class frmMain : Form
    {
        PL.frm_home frm_home = new PL.frm_home();
        PL.FRM_SALESREPORTS frm_salesreports = new PL.FRM_SALESREPORTS();
        public frmMain()
        {
            InitializeComponent();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {
            pn_contaner.Controls.Clear();
            pn_contaner.Controls.Add(frm_home.pn_homepage);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
          
        }
        private bool MouseDown= false;
        private Point LastLocation;

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void pnlHeader_MouseUp(object sender, MouseEventArgs e)
        {
            MouseDown = false;
            pnlHeader.Cursor = Cursors.Default;
        }

        private void pnlHeader_MouseDown(object sender, MouseEventArgs e)
        {
            MouseDown = true;
            LastLocation = e.Location;
            pnlHeader.Cursor = Cursors.Hand;
        }

        private void pnlHeader_MouseMove(object sender, MouseEventArgs e)
        {
            if (MouseDown)
            {
                int NewX = (this.Location.X - LastLocation.X) + e.X;
                int NewY = (this.Location.Y - LastLocation.Y) + e.Y;
                this.Location = new Point(NewX, NewY);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {
        
        }

        private void btnSales_Click(object sender, EventArgs e)
        {
      RPT.frm_rpt_Sales_by_Br frm = new RPT.frm_rpt_Sales_by_Br();
            frm.MdiParent = this;
            frm.Show();
        }

        private void btnFile_Click(object sender, EventArgs e)
        {
            PL.Frm_Config frm = new PL.Frm_Config();
            frm.MdiParent = this;
            frm.Show();

        }

        private void login_Click(object sender, EventArgs e)
        {
            RPT.login_frm frm = new RPT.login_frm();
            frm.ShowDialog();
        }
        //close app
        private void btn_close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        // minimize app
        private void btn_min_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        // maximize app
        private void btn_max_Click(object sender, EventArgs e)
        {
            if (WindowState == FormWindowState.Normal)
            {
                WindowState = FormWindowState.Maximized;
            }
            else
            {
                WindowState = FormWindowState.Normal;
            }
        }

        private void gLogin_Click(object sender, EventArgs e)
        {

        }

        private void gHome_Click(object sender, EventArgs e)
        {
            pn_contaner.Controls.Clear();
            pn_contaner.Controls.Add(frm_home.pn_homepage);
        }

        private void gSales_Click(object sender, EventArgs e)
        {

        }

        private void accordionControlElement1_Click(object sender, EventArgs e)
        {
            pn_contaner.Controls.Clear();
            pn_contaner.Controls.Add(frm_salesreports.PN_SALESREPORTS);
        }
    }
}
