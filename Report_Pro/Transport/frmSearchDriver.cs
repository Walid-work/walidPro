using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.Transport
{
    public partial class frmSearchDriver : Form
    {
        DAL.DataAccesslayer1 dal=new DAL.DataAccesslayer1();
        public frmSearchDriver()
        {
            InitializeComponent();
           
        }

        private void frmSearchDriver_Load(object sender, EventArgs e)
        {
            this.DGV1.DataSource = dal.getDataTabl_1("SELECT * FROM C_Drivers  Where Driver_code+Driver_name like '%"+txtSerch.Text+"%'" );
            
            for (int i = 2; i < DGV1.Columns.Count; i++)
            {
                DGV1.Columns[i].Visible = false;
            }
            DGV1.Columns[0].Width = 70;
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            this.DGV1.DataSource = dal.getDataTabl("Get_Drivers", txtSerch.Text);
            
            for (int i = 2; i < DGV1.Columns.Count; i++)
            {
                DGV1.Columns[i].Visible = false;
            }
            DGV1.Columns[0].Width = 70;
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
