using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.MyControls
{
    public partial class UC_Years : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_Years()
        {
            InitializeComponent();
        }

        private void UC_Years_Load(object sender, EventArgs e)
        {
            DataTable dt_ = dal.getDataTabl_1(@"SELECT * from Main_acc_wh.dbo.wh_database_years");
            dataGridViewX1.DataSource = dt_;
            dataGridViewX1.Columns[1].Visible = false;
        }

        private void dataGridViewX1_Click(object sender, EventArgs e)
        {
           
            Properties.Settings.Default.Database_1 = dataGridViewX1.CurrentRow.Cells[1].Value.ToString();
            Properties.Settings.Default.Save();


            PL.Frm_Main.ActiveForm.Dispose();
            PL.Frm_Main sd = new PL.Frm_Main();
            sd.Show();


            MessageBox.Show("تمت الاعدادات بنجاح", "عملية الحفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
