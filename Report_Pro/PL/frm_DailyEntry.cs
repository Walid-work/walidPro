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
    public partial class frm_DailyEntry : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_DailyEntry()
        {
            InitializeComponent();
        }

        private void frm_DailyEntry_Load(object sender, EventArgs e)
        {
            getAccBrnchData(Properties.Settings.Default.BranchAccID);
            txtUserID.Text = Program.userID;
            getJorSer(txtBranchCode.Text);
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void getAccBrnchData(string BranchCode)
        {
            DataTable dtBranch = dal.getDataTabl_1(@"select BRANCH_code,BRANCH_name,BRANCH_E_NAME from BRANCHS where BRANCH_code = '" +BranchCode+"'");
            if (dtBranch.Rows.Count > 0)
            {
                txtBranchCode.Text = dtBranch.Rows[0]["BRANCH_code"].ToString();
                if (Properties.Settings.Default.lungh == "0")
                {
                    txtBranchName.Text = dtBranch.Rows[0]["BRANCH_name"].ToString();
                }
                else
                {
                    txtBranchName.Text = dtBranch.Rows[0]["BRANCH_E_NAME"].ToString();
                }
            }
        }

        private void btn_ChoseCompamy_Click(object sender, EventArgs e)
        {
            PL.frm_ChoseAccBranch frm = new frm_ChoseAccBranch();
            frm.ShowDialog();
            getAccBrnchData(frm.AccBranchCode);
            getJorSer(txtBranchCode.Text);
        }


        private void getJorSer(string Branch_)
        {

            DataTable dtSer = dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) as Jor_ser,isnull(daily_sn_ser+1,1) as Main_ser from serial_no where BRANCH_CODE='" + Branch_
                     + "' and ACC_YEAR= '" + txtCyear.Text + "'");

            if (dtSer.Rows.Count > 0)
            {
                txtSerNo.Text = "M" + dtSer.Rows[0]["Jor_ser"].ToString();
                Main_serNo.Text =  dtSer.Rows[0]["Main_ser"].ToString();
            }

            //this.txtSerNo.Text = "M" + dal.getDataTabl_1(@"select isnull(main_daily_ser+1,1) from serial_no where BRANCH_CODE='" + txtBranchCode.Text
            //         + "' and ACC_YEAR= '" + txtCyear.Text + "'").Rows[0][0].ToString().PadLeft(4, '0');

            //this.Main_serNo.Text = dal.getDataTabl_1(@"select isnull(daily_sn_ser+1,1) from serial_no where BRANCH_CODE='" + Branch_.ID.Text
            //     + "' and ACC_YEAR= '" + txtAcc_year.Text + "' ").Rows[0][0].ToString();//.PadLeft(4, '0');


        }

        private void buttonX1_Click(object sender, EventArgs e)
        {
            PL.frmSerch frm = new PL.frmSerch();
            frm.lblHead.Text = "Enter Jornal No.";
            frm.ShowDialog();
            if (frm.Close_Type == 1)
            {
                DataTable dtJor= dal.getDataTabl_1(@"SELECT ser_no,sanad_no,sp_ser_no,g_date,h_date,user_name,notes
                ,meno,loh,aCC_NO,isnull(CAT_CODE,1) as CAT_CODE,isnull(COST_CENTER,1) as COST_CENTER,desc2
                FROM daily_transaction where BRANCH_code = '" + txtBranchCode.Text+"' and ser_no = '"+frm.txtSearch.t.Text+"' and ACC_YEAR = 'cy' order by sorting_ser");
                  if (dtJor.Rows.Count > 0)
                {
                    txtSerNo.Text = dtJor.Rows[0]["ser_no"].ToString();
                    Main_serNo.Text = dtJor.Rows[0]["sanad_no"].ToString();
                    txt_sp_ser.Text = dtJor.Rows[0]["sp_ser_no"].ToString();
                    txtDate.Text = dtJor.Rows[0]["g_date"].ToString();
                    txtDate_H.Text = dtJor.Rows[0]["h_date"].ToString();
                    txtUserID.Text = dtJor.Rows[0]["user_name"].ToString();
                    txtMainNote.Text = dtJor.Rows[0]["notes"].ToString();


                   jorDebit1.flowLayoutPanel1.Controls.Clear();

                    //MyControls.Jor_Row rw = new MyControls.Jor_Row();
                    //jorDebit1.flowLayoutPanel1.Controls.Add(rw);

                    for (int i=0;i < dtJor.Rows.Count;i++)
                       
                        {

                        jorRow.Jor_Row rw = new jorRow.Jor_Row();
                         // MyControls.Jor_Row rw = new MyControls.Jor_Row();

                        rw.Width = jorDebit1.flowLayoutPanel1.Width;
                        jorDebit1.flowLayoutPanel1.Controls.Add(rw);
                        
                       // flowLayoutPanel1.SuspendLayout();


                        rw.ser_.Text = (i + 1).ToString();
                        rw.txtDb.d.Text = dtJor.Rows[i]["meno"].ToString();
                        rw.txtCr.d.Text = dtJor.Rows[i]["loh"].ToString();
                        rw.Acc_.ID.Text = dtJor.Rows[i]["ACC_NO"].ToString();
                        //rw.txtCat.ID.Text =dtJor.Rows[i]["CAT_CODE"].ToString();
                        //rw.txtCost.ID.Text = dtJor.Rows[i]["COST_CENTER"].ToString();
                        rw.txtDescription.t.Text = dtJor.Rows[i]["desc2"].ToString();
                        rw.Width = jorDebit1.flowLayoutPanel1.Width;
                        jorDebit1.flowLayoutPanel1.Controls.Add(rw);
                       
                        rw.KeyDown += jorDebit1.r_KeyDown;
                        rw.KeyUp += jorDebit1.r_KeyUP;
                        rw.Click += jorDebit1.r_Click;
                        rw.DoubleClick += jorDebit1.r_DoubleClick;


                        //  i++;
                       
                    }
                    MyControls.Jor_Row r = new MyControls.Jor_Row();
                    r.Width = jorDebit1.flowLayoutPanel1.Width;
                    jorDebit1.flowLayoutPanel1.Controls.Add(r);
                    //
                    r.ser_.Text = (jorDebit1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                    r.KeyDown += jorDebit1.r_KeyDown;
                    r.KeyUp += jorDebit1.r_KeyUP;
                    r.Click += jorDebit1.r_Click;
                      r.DoubleClick += jorDebit1.r_DoubleClick;


                }

                jorDebit1.gettotDb();


                }

            
           
        }

        private void getJorData(string serNo,string MserNo_,string privateNo,string branch_,string cyear_)
        {

        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void buttonX2_Click(object sender, EventArgs e)
        {
            jorDebit1.flowLayoutPanel1.Controls.Clear();
            

            for (int i = 0; i <= 100; i++)
            {
                MyControls.Jor_Row rw = new MyControls.Jor_Row();
                jorDebit1.flowLayoutPanel1.Controls.Add(rw);

            }


        }

        private void jorDebit1_Load(object sender, EventArgs e)
        {

        }

        private void buttonX3_Click(object sender, EventArgs e)
        {
            PL.frmSerch frm = new PL.frmSerch();
            frm.lblHead.Text = "Enter Jornal No.";
            frm.ShowDialog();
            if (frm.Close_Type == 1)
            {
                DataTable dtJor = dal.getDataTabl_1(@"SELECT ser_no,sanad_no,sp_ser_no,g_date,h_date,user_name,notes
                ,meno,loh,aCC_NO,isnull(CAT_CODE,1) as CAT_CODE,isnull(COST_CENTER,1) as COST_CENTER,desc2
                FROM daily_transaction where BRANCH_code = '" + txtBranchCode.Text + "' and ser_no = '" + frm.txtSearch.t.Text + "' and ACC_YEAR = 'cy' order by sorting_ser");
                if (dtJor.Rows.Count > 0)
                {
                    txtSerNo.Text = dtJor.Rows[0]["ser_no"].ToString();
                    Main_serNo.Text = dtJor.Rows[0]["sanad_no"].ToString();
                    txt_sp_ser.Text = dtJor.Rows[0]["sp_ser_no"].ToString();
                    txtDate.Text = dtJor.Rows[0]["g_date"].ToString();
                    txtDate_H.Text = dtJor.Rows[0]["h_date"].ToString();
                    txtUserID.Text = dtJor.Rows[0]["user_name"].ToString();
                    txtMainNote.Text = dtJor.Rows[0]["notes"].ToString();


                    //jorDebit1.flowLayoutPanel1.Controls.Clear();


                    for (int i = 0; i < dtJor.Rows.Count; i++)

                    {

                        // MyControls.Jor_Row rw = new MyControls.Jor_Row();
                        foreach (MyControls.Jor_Row rw in jorDebit1.flowLayoutPanel1.Controls)
                        {
                            if (jorDebit1.flowLayoutPanel1.Controls.GetChildIndex(rw) == i)
                            {
                                rw.ser_.Text = (i + 1).ToString();
                                rw.txtDb.d.Text = dtJor.Rows[i]["meno"].ToString();
                                rw.txtCr.d.Text = dtJor.Rows[i]["loh"].ToString();
                                rw.Acc_.ID.Text = dtJor.Rows[i]["ACC_NO"].ToString();
                                rw.txtCat.ID.Text = dtJor.Rows[i]["CAT_CODE"].ToString();
                                rw.txtCost.ID.Text = dtJor.Rows[i]["COST_CENTER"].ToString();
                                rw.txtDescription.t.Text = dtJor.Rows[i]["desc2"].ToString();
                                //rw.Width = jorDebit1.flowLayoutPanel1.Width;
                                //jorDebit1.flowLayoutPanel1.Controls.Add(rw);

                                rw.KeyDown += jorDebit1.r_KeyDown;
                                rw.KeyUp += jorDebit1.r_KeyUP;
                                rw.Click += jorDebit1.r_Click;
                                rw.DoubleClick += jorDebit1.r_DoubleClick;
                            }

                            //  i++;
                        }
                    }
                    MyControls.Jor_Row r = new MyControls.Jor_Row();
                    r.Width = jorDebit1.flowLayoutPanel1.Width;
                    jorDebit1.flowLayoutPanel1.Controls.Add(r);
                    //
                    r.ser_.Text = (jorDebit1.flowLayoutPanel1.Controls.GetChildIndex(r) + 1).ToString();
                    r.KeyDown += jorDebit1.r_KeyDown;
                    r.KeyUp += jorDebit1.r_KeyUP;
                    r.Click += jorDebit1.r_Click;
                    r.DoubleClick += jorDebit1.r_DoubleClick;


                }

                jorDebit1.gettotDb();


            }




        }

        private void BtnPrint_Click(object sender, EventArgs e)
        {

        }

        private void BSearch_Click(object sender, EventArgs e)
        {

        }
    }
}
