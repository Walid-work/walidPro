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
    public partial class frmDrivers : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frmDrivers()
        {
            InitializeComponent();

            Txt_User.Text = Program.userID;
            
            DriverAvilable.DataSource = dal.getDataTabl_1("SELECT Driver_Status,Status_name  FROM C_Driver_Status");
            DriverAvilable.DisplayMember = "Status_name";
            DriverAvilable.ValueMember = "Driver_Status";

            DriverNationalty.DataSource = dal.getDataTabl_1("SELECT NATION_CODE,nation_name FROM nations");
            DriverNationalty.DisplayMember = "nation_name";
            DriverNationalty.ValueMember = "NATION_CODE";

        }



        private void BSave_Click(object sender, EventArgs e)
        {
            if (DriverID.Text != string.Empty && DriverName.Text != string.Empty && DriverAcc.ID.Text != string.Empty)
            {
                DateTime SDate_, Iq_IssD, Iq_ExpD, licence_IssD, licence_ExpD, Auth_IssD, Auth_ExpD, Menalicence_IssD, Menalicence_ExpD;
                //   if (Start_Date.Value > Start_Date.MinDate) { SDate_ = Start_Date.Value.Date; } else { SDate_ = Start_Date.MinDate; }
                if (Iq_IssueDate.GD.Value > Iq_IssueDate.GD.MinDate) { Iq_IssD = Iq_IssueDate.GD.Value.Date; } else { Iq_IssD = Iq_IssueDate.GD.MinDate; }
                if (Iq_ExpirDate.GD.Value > Iq_ExpirDate.GD.MinDate) { Iq_ExpD = Iq_ExpirDate.GD.Value.Date; } else { Iq_ExpD = Iq_ExpirDate.GD.MinDate; }
                if (licence_IssueDate.GD.Value > licence_IssueDate.GD.MinDate) { licence_IssD = licence_IssueDate.GD.Value.Date; } else { licence_IssD = licence_IssueDate.GD.MinDate; }
                if (licence_ExpirDate.GD.Value > licence_ExpirDate.GD.MinDate) { licence_ExpD = licence_ExpirDate.GD.Value.Date; } else { licence_ExpD = licence_ExpirDate.GD.MinDate; }
                if (Auth_IssueDate.GD.Value > Auth_IssueDate.GD.MinDate) { Auth_IssD = Auth_IssueDate.GD.Value.Date; } else { Auth_IssD = Auth_IssueDate.GD.MinDate; }
                if (Auth_ExpirDate.GD.Value > Auth_ExpirDate.GD.MinDate) { Auth_ExpD = Auth_ExpirDate.GD.Value.Date; } else { Auth_ExpD = Auth_ExpirDate.GD.MinDate; }
                if (Menalicence_IssueDate.GD.Value > Menalicence_IssueDate.GD.MinDate) { Menalicence_IssD = Menalicence_IssueDate.GD.Value.Date; } else { Menalicence_IssD = Menalicence_IssueDate.GD.MinDate; }
                if (Menalicence_ExpirDate.GD.Value > Menalicence_ExpirDate.GD.MinDate) { Menalicence_ExpD = Menalicence_ExpirDate.GD.Value.Date; } else { Menalicence_ExpD = Menalicence_ExpirDate.GD.MinDate; }

                dal.Execute_1(@"insert into C_Drivers
                    (Driver_code,Driver_name,Acc_no,Car_no,Nation,Cafala,Avilable,User_id,G_date
                    ,Notes,Mobile,Last_Line_no,Last_s_date,Last_E_Date,Last_Trip_No,eqama_no
                    ,eqama_issue_place,eqama_issue_date,eqama_issue_date_h,eqama_expire_date
                    ,eqama_expire_date_h,Roksa_no,Roksa_issue_date,Roksa_issue_date_h,Roksa_Expire_date
                    ,Roksa_Expire_date_h,Roksa_type,VACATION_DUE_DATE,Track_Drive_licence_No
                    ,Track_Drive_licence_Type,Track_Drive_licence_Issue_date,Track_Drive_licence_Issue_date_h
                    ,Track_Drive_licence_expire_date,Track_Drive_licence_expire_date_h,Drive_mena_licence_No
                    ,Drive_mena_licence_Type,Drive_mena_licence_issue_date,Drive_mena_licence_issue_date_h
                    ,Drive_mena_licence_expire_date,Drive_mena_licence_expire_date_h,Tasneef_no,Driver_Status,Traveled)
                    Values('"+DriverID.Text+"','"+ DriverName.Text+"','"+ DriverAcc.ID.Text+"','"+ CarNo.ID.Text+"','"+ Convert.ToString(DriverNationalty.SelectedValue)+"','"+
                    Convert.ToString(DriverSponser.SelectedValue)+"','"+ Convert.ToString(DriverAvilable.SelectedValue)+"','"+ Txt_User.Text+"','"+
                    S_Date.Value+"','"+ TxtNotes.Text+"','"+ DriverMobile.Text+"','"+ DBNull.Value+"','"+ DBNull.Value+"','"+ DBNull.Value+"','"+ DBNull.Value+"','"+
                    IqamaNo.Text+"','"+ Convert.ToString(IqamaDesc.SelectedValue)+"','"+ Iq_IssD+"','"+ Iq_IssueDate.HD.Text+"','"+
                    Iq_ExpD+"','"+ Iq_ExpirDate.HD.Text+"','"+ licenceNo.Text+"','"+ licence_IssD+"','"+
                    licence_IssueDate.HD.Text+"','"+ licence_ExpD+"','"+ licence_ExpirDate.HD.Text+"','"+
                    Convert.ToString(licenceDesc.SelectedValue)+"','"+ DBNull.Value+"','"+ AuthNo.Text+"','"+ Convert.ToString(AuthDesc.SelectedValue)+"','"+
                    Auth_IssD+"','"+ Auth_IssueDate.HD.Text+"','"+ Auth_ExpD+"','"+
                    Auth_ExpirDate.HD.Text+"','"+ MenalicenceNo.Text+"','"+ Convert.ToString(MenalicenceDesc.SelectedValue)+"','"+
                    Menalicence_IssD+"','"+ Menalicence_IssueDate.HD.Text+"','"+ Menalicence_ExpD+"','"+
                    Menalicence_ExpirDate.HD.Text+"','"+ DBNull.Value+"','"+ DBNull.Value+"','"+ DBNull.Value+"')");


                //dal.Execute("AddDriver", DriverID.Text, DriverName.Text, DriverAcc.ID.Text, CarNo.ID.Text, Convert.ToString(DriverNationalty.SelectedValue),
                //    Convert.ToString(DriverSponser.SelectedValue), Convert.ToString(DriverAvilable.SelectedValue), Txt_User.Text,
                //    S_Date.Value, TxtNotes.Text, DriverMobile.Text, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                //    IqamaNo.Text, Convert.ToString(IqamaDesc.SelectedValue), Iq_IssD, Iq_IssueDate.HD.Text,
                //    Iq_ExpD, Iq_ExpirDate.HD.Text, licenceNo.Text, licence_IssD,
                //    licence_IssueDate.HD.Text, licence_ExpD, licence_ExpirDate.HD.Text,
                //    Convert.ToString(licenceDesc.SelectedValue), DBNull.Value, AuthNo.Text, Convert.ToString(AuthDesc.SelectedValue),
                //    Auth_IssD, Auth_IssueDate.HD.Text, Auth_ExpD,
                //    Auth_ExpirDate.HD.Text, MenalicenceNo.Text, Convert.ToString(MenalicenceDesc.SelectedValue),
                //    Menalicence_IssD, Menalicence_IssueDate.HD.Text, Menalicence_ExpD,
                //    Menalicence_ExpirDate.HD.Text, DBNull.Value, DBNull.Value, DBNull.Value);
                BSave.Enabled = false;
                MessageBox.Show("تم حفظ البيانات بنجاح", "حفظ", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            else
            {
                MessageBox.Show("فضلا تاكد من البيانات الاساسية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            }

        private void BNew_Click(object sender, EventArgs e)
        {
            BSave.Enabled = true;
        }

        private void CarNo_Click(object sender, EventArgs e)
        {
           
            groupPanel2.Visible = true;
            groupPanel2.Location = new Point(515, 110);
           DGV1.DataSource = dal.getDataTabl("Serech_Car", txtSerch.Text);
           
        }

    

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSerch_TextChanged(object sender, EventArgs e)
        {
            DGV1.DataSource = dal.getDataTabl("Serech_Car", txtSerch.Text);
        }

        private void btnSerch_Click(object sender, EventArgs e)
        {
            groupPanel2.Visible = false;
            txtSerch.Clear();
        }

        private void DGV1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void DGV1_DoubleClick(object sender, EventArgs e)
        {
            int ii = DGV1.CurrentCell.RowIndex;
             CarNo.ID.Text = DGV1.Rows[ii].Cells[0].Value.ToString();
             CarNo.Desc.Text = DGV1.Rows[ii].Cells[1].Value.ToString();
            groupPanel2.Visible = false;
            txtSerch.Clear();
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {

        }

        private void BSearch_Click(object sender, EventArgs e)
        {
            Transport.frmSearchDriver frmSearchDriver = new Transport.frmSearchDriver();
            frmSearchDriver.ShowDialog();

            int ii = frmSearchDriver.DGV1.CurrentCell.RowIndex;
            DriverID.Text = frmSearchDriver.DGV1.Rows[ii].Cells[0].Value.ToString();
            DriverName.Text = frmSearchDriver.DGV1.Rows[ii].Cells[1].Value.ToString();
            DriverAcc.ID.Text = frmSearchDriver.DGV1.Rows[ii].Cells[2].Value.ToString();
            CarNo.ID.Text = frmSearchDriver.DGV1.Rows[ii].Cells[3].Value.ToString();
            DriverNationalty.SelectedValue = frmSearchDriver.DGV1.Rows[ii].Cells[4].Value.ToString();
            DriverSponser.SelectedValue = frmSearchDriver.DGV1.Rows[ii].Cells[5].Value.ToString();
            DriverAvilable.SelectedValue = frmSearchDriver.DGV1.Rows[ii].Cells[6].Value.ToString();
            Txt_User.Text = frmSearchDriver.DGV1.Rows[ii].Cells[7].Value.ToString();
            S_Date.Text = frmSearchDriver.DGV1.Rows[ii].Cells[8].Value.ToString();
            TxtNotes.Text = frmSearchDriver.DGV1.Rows[ii].Cells[9].Value.ToString();
            DriverMobile.Text = frmSearchDriver.DGV1.Rows[ii].Cells[10].Value.ToString();
            IqamaNo.Text = frmSearchDriver.DGV1.Rows[ii].Cells[15].Value.ToString();
            IqamaDesc.SelectedValue = frmSearchDriver.DGV1.Rows[ii].Cells[16].Value.ToString();
            Iq_IssueDate.GD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[17].Value.ToString();
            Iq_IssueDate.HD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[18].Value.ToString();
            Iq_ExpirDate.GD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[19].Value.ToString();
            Iq_ExpirDate.HD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[20].Value.ToString();
            licenceNo.Text = frmSearchDriver.DGV1.Rows[ii].Cells[21].Value.ToString();
            licence_IssueDate.GD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[22].Value.ToString();
            licence_IssueDate.HD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[23].Value.ToString();
            licence_ExpirDate.GD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[24].Value.ToString();
            licence_ExpirDate.HD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[25].Value.ToString();
            licenceDesc.SelectedValue = frmSearchDriver.DGV1.Rows[ii].Cells[26].Value.ToString();
            AuthNo.Text = frmSearchDriver.DGV1.Rows[ii].Cells[28].Value.ToString();
            AuthDesc.SelectedValue = frmSearchDriver.DGV1.Rows[ii].Cells[29].Value.ToString();
            Auth_IssueDate.GD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[30].Value.ToString();
            Auth_IssueDate.HD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[31].Value.ToString();
            Auth_ExpirDate.GD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[32].Value.ToString();
            Auth_ExpirDate.HD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[33].Value.ToString();
            MenalicenceNo.Text = frmSearchDriver.DGV1.Rows[ii].Cells[34].Value.ToString();
            MenalicenceDesc.SelectedValue = frmSearchDriver.DGV1.Rows[ii].Cells[35].Value.ToString();
            Menalicence_IssueDate.GD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[36].Value.ToString();
            Menalicence_IssueDate.HD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[37].Value.ToString();
            Menalicence_ExpirDate.GD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[38].Value.ToString();
            Menalicence_ExpirDate.HD.Text = frmSearchDriver.DGV1.Rows[ii].Cells[39].Value.ToString();
            BEdit.Enabled = true;
        }


       
        private void BEdit_Click(object sender, EventArgs e)
        {
            if (DriverID.Text != string.Empty && DriverName.Text != string.Empty && DriverAcc.ID.Text != string.Empty)
            {

                DateTime SDate_, Iq_IssD, Iq_ExpD, licence_IssD, licence_ExpD, Auth_IssD, Auth_ExpD, Menalicence_IssD, Menalicence_ExpD;
             //   if (Start_Date.Value > Start_Date.MinDate) { SDate_ = Start_Date.Value.Date; } else { SDate_ = Start_Date.MinDate; }
                if (Iq_IssueDate.GD.Value > Iq_IssueDate.GD.MinDate) { Iq_IssD = Iq_IssueDate.GD.Value.Date; } else { Iq_IssD = Iq_IssueDate.GD.MinDate; }
                if (Iq_ExpirDate.GD.Value > Iq_ExpirDate.GD.MinDate) { Iq_ExpD = Iq_ExpirDate.GD.Value.Date; } else { Iq_ExpD = Iq_ExpirDate.GD.MinDate; }
                if (licence_IssueDate.GD.Value > licence_IssueDate.GD.MinDate) { licence_IssD = licence_IssueDate.GD.Value.Date; } else { licence_IssD = licence_IssueDate.GD.MinDate; }
                if (licence_ExpirDate.GD.Value > licence_ExpirDate.GD.MinDate) { licence_ExpD = licence_ExpirDate.GD.Value.Date; } else { licence_ExpD = licence_ExpirDate.GD.MinDate; }
                if (Auth_IssueDate.GD.Value > Auth_IssueDate.GD.MinDate) { Auth_IssD = Auth_IssueDate.GD.Value.Date; } else { Auth_IssD = Auth_IssueDate.GD.MinDate; }
                if (Auth_ExpirDate.GD.Value > Auth_ExpirDate.GD.MinDate) { Auth_ExpD = Auth_ExpirDate.GD.Value.Date; } else { Auth_ExpD = Auth_ExpirDate.GD.MinDate; }
                if (Menalicence_IssueDate.GD.Value > Menalicence_IssueDate.GD.MinDate) { Menalicence_IssD = Menalicence_IssueDate.GD.Value.Date; } else { Menalicence_IssD = Menalicence_IssueDate.GD.MinDate; }
                if (Menalicence_ExpirDate.GD.Value > Menalicence_ExpirDate.GD.MinDate) { Menalicence_ExpD = Menalicence_ExpirDate.GD.Value.Date; } else { Menalicence_ExpD = Menalicence_ExpirDate.GD.MinDate; }

                dal.Execute_1(@"update C_Drivers set Driver_code = '" + DriverID.Text+
"',Driver_name = '"+ DriverName.Text+
"',Acc_no = '"+ DriverAcc.ID.Text+
"',Car_no = '" + CarNo.ID.Text+
"',Nation = '" + Convert.ToString(DriverNationalty.SelectedValue)+
"',Cafala = '" + Convert.ToString(DriverSponser.SelectedValue)+
"',Avilable = '" + Convert.ToString(DriverAvilable.SelectedValue)+
"',User_id = '" + Txt_User.Text+
"',G_date = '" + S_Date.Value+
"',Notes = '" + TxtNotes.Text+
"',Mobile = '" + DriverMobile.Text+
"',eqama_no = '" + IqamaNo.Text+
"',eqama_issue_place = '" + Convert.ToString(IqamaDesc.SelectedValue)+
"',eqama_issue_date = '" + Iq_IssD+
"',eqama_issue_date_h = '" + Iq_IssueDate.HD.Text+
"',eqama_expire_date = '" + Iq_ExpD+
"',eqama_expire_date_h = '" + Iq_ExpirDate.HD.Text+
"',Roksa_no = '" + licenceNo.Text+
"',Roksa_issue_date = '" + licence_IssD+
"',Roksa_issue_date_h = '" + licence_IssueDate.HD.Text+
"',Roksa_Expire_date = '" + licence_ExpD+
"',Roksa_Expire_date_h = '" + licence_ExpirDate.HD.Text+
"',Roksa_type = '" + Convert.ToString(licenceDesc.SelectedValue)+
"',Track_Drive_licence_No = '" + AuthNo.Text+
"',Track_Drive_licence_Type = '" + Convert.ToString(AuthDesc.SelectedValue)+
"',Track_Drive_licence_Issue_date = '" + Auth_IssD+
"',Track_Drive_licence_Issue_date_h = '" + Auth_IssueDate.HD.Text+
"',Track_Drive_licence_expire_date = '" + Auth_ExpD+
"',Track_Drive_licence_expire_date_h = '" + Auth_ExpirDate.HD.Text+
"',Drive_mena_licence_No = '" + MenalicenceNo.Text+
"',Drive_mena_licence_Type = '" + Convert.ToString(MenalicenceDesc.SelectedValue)+
"',Drive_mena_licence_issue_date = '" + Menalicence_IssD+
"',Drive_mena_licence_issue_date_h = '" + Menalicence_IssueDate.HD.Text+
"',Drive_mena_licence_expire_date = '" + Menalicence_ExpD+
"',Drive_mena_licence_expire_date_h = '" + Menalicence_ExpirDate.HD.Text+
"' where Driver_code = '" + DriverID.Text +"'");



                //dal.Execute("EditDriver", DriverID.Text, DriverName.Text, DriverAcc.ID.Text, CarNo.ID.Text, Convert.ToString(DriverNationalty.SelectedValue),
                //    Convert.ToString(DriverSponser.SelectedValue), Convert.ToString(DriverAvilable.SelectedValue), Txt_User.Text,
                //    S_Date.Value, TxtNotes.Text, DriverMobile.Text, DBNull.Value, DBNull.Value, DBNull.Value, DBNull.Value,
                //    IqamaNo.Text, Convert.ToString(IqamaDesc.SelectedValue), Iq_IssD, Iq_IssueDate.HD.Text,
                //    Iq_ExpD, Iq_ExpirDate.HD.Text, licenceNo.Text, licence_IssD,
                //    licence_IssueDate.HD.Text, licence_ExpD, licence_ExpirDate.HD.Text,
                //    Convert.ToString(licenceDesc.SelectedValue), DBNull.Value, AuthNo.Text, Convert.ToString(AuthDesc.SelectedValue),
                //    Auth_IssD, Auth_IssueDate.HD.Text, Auth_ExpD,
                //    Auth_ExpirDate.HD.Text, MenalicenceNo.Text, Convert.ToString(MenalicenceDesc.SelectedValue),
                //    Menalicence_IssD, Menalicence_IssueDate.HD.Text, Menalicence_ExpD,
                //    Menalicence_ExpirDate.HD.Text, DBNull.Value, DBNull.Value, DBNull.Value);
                    MessageBox.Show("تم تعديل البيانات بنجاح", "تعديل", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("فضلا تاكد من البيانات الاساسية", "خطأ", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
           // MessageBox.Show(Iq_IssueDate.GD.Value.ToString());
        }

        private void DriverAcc_Load(object sender, EventArgs e)
        {

        }
    }
}
