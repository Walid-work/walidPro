using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frmCompanyData :frm_Master
    {
        DAL.Wh_Oiner_Comp Oner_Comp;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        
        public frmCompanyData()
        {
            InitializeComponent();
            New();
        }

        public override void New()
        {
            Oner_Comp = new DAL.Wh_Oiner_Comp();
            
            base.New();
        }

        public override void Save()
        {
            var db = new DAL.dbDataContext();

            if (Oner_Comp.Company_No == null)
            {
              db.Wh_Oiner_Comps.InsertOnSubmit(Oner_Comp);
            }
            else
            {
               db.Wh_Oiner_Comps.Attach(Oner_Comp);
            }
            SetData();
            db.SubmitChanges();


            base.Save();
        }

        public override void SetData()
        {
            //byte[] h_Logo = null;
            //byte[] f_Logo = null;


            //if (pictureBox1.Image == null)
            //{

            //    h_Logo = null;
            //}
            //else
            //{
            //    MemoryStream ms = new MemoryStream();
            //    pictureBox1.Image.Save(ms, pictureBox1.Image.RawFormat);
            //    h_Logo = ms.GetBuffer();
            //    ms.Close();
            //}

            //if (pictureBox2.Image == null)
            //{
            //    f_Logo = null;
            //}
            //else
            //{


            //    MemoryStream ms1 = new MemoryStream();
            //    pictureBox2.Image.Save(ms1, pictureBox2.Image.RawFormat);
            //    f_Logo = ms1.GetBuffer();
            //    ms1.Close();
            //}


            Oner_Comp.Company_No       = txt_id.Text;
            Oner_Comp.Company_a_name   = txt_name.Text;
            Oner_Comp.Company_e_name   = txt_name_e.Text;
            Oner_Comp.User_id          = txt_User.Text;
            Oner_Comp.G_date           = txt_date.Value.Date;
            Oner_Comp.Comp_Vat_no      = txt_vat_no.Text;
            Oner_Comp.Comp_AdressA     = txt_address.Text;
            Oner_Comp.Comp_AdressE     = txt_address_e.Text;
            Oner_Comp.Comp_Phone_no    = txt_tel.Text;
            Oner_Comp.Comp_Fax         = txt_fax.Text;
            Oner_Comp.Comp_Email       = txt_email.Text;
            Oner_Comp.Comp_Web_Site    = txt_website.Text;
            Oner_Comp.Comp_Rc          = txt_cr.Text;
            //Oner_Comp.Comp_hP          = h_Logo;
            //Oner_Comp.Comp_fp          = f_Logo;


            base.SetData();
        }

        private void txt_Vat_No__TextChanged(object sender, EventArgs e)
        {

        }

        private void frmCompanyData_Load(object sender, EventArgs e)
        {
            New();
           // txt_User.Text = Program.userID;
        }

        private void labelX7_Click(object sender, EventArgs e)
        {

        }

        private void labelX8_Click(object sender, EventArgs e)
        {

        }

        private void labelX9_Click(object sender, EventArgs e)
        {

        }

        private void labelX10_Click(object sender, EventArgs e)
        {

        }

        private void labelX11_Click(object sender, EventArgs e)
        {

        }

        private void labelX12_Click(object sender, EventArgs e)
        {

        }

        private void labelX6_Click(object sender, EventArgs e)
        {

        }

        private void labelX5_Click(object sender, EventArgs e)
        {

        }

        private void labelX4_Click(object sender, EventArgs e)
        {

        }

        private void labelX3_Click(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }

        private void labelX1_Click(object sender, EventArgs e)
        {

        }

        private void BSave_Click(object sender, EventArgs e)
        {
            byte[] h_Logo = null;
            byte[] f_Logo = null;


            if (pic_header.Image == null)
            {

                h_Logo = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pic_header.Image.Save(ms, pic_header.Image.RawFormat);
                h_Logo = ms.GetBuffer();
                ms.Close();
            }

            if (pic_footer.Image == null)
            {
                f_Logo = null;
            }
            else
            {


                MemoryStream ms1 = new MemoryStream();
                pic_footer.Image.Save(ms1, pic_footer.Image.RawFormat);
                f_Logo = ms1.GetBuffer();
                ms1.Close();
            }


            if (txt_id.Text != "" || txt_name.Text != "")
            {
                //if (dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No = '"+txt_ID.Text+"'").Rows.Count>0)

                //{
                //    dal.Execute_1(@"Update Wh_Oiner_Comp set 
                //       Company_No       ='" + txt_ID.Text + 
                //    "',Company_a_name   ='" + txt_Name.Text + 
                //    "',Company_e_name   ='" + txt_Name_E.Text + 
                //    "',User_id          ='" + txt_User.Text + 
                //    "',G_date           ='" + txt_Date.Value.ToString("yyyy-MM-dd hh:mm:ss") +
                //    "',Comp_Vat_no      ='" + txt_Vat_No.Text + 
                //    "',Comp_AdressA     ='" + txt_Address.Text +
                //    "',Comp_AdressE     ='" + txt_Address_E.Text +
                //    "',Comp_Phone_no    ='" + txt_Tel_No.Text +
                //    "',Comp_Fax         ='" + txt_Fax_No.Text +
                //    "',Comp_Email       ='" + txt_Email_No.Text +
                //    "',Comp_Web_Site    ='" + txt_Web_Site.Text +
                //    "',Comp_Rc          ='" + txt_Rc.Text +
                //    "',Comp_hP          ='" + h_Logo +
                //     "',Comp_fP          ='" +  f_Logo +
                //    "' where Company_No ='" + txt_ID.Text + "'");


                //}
                //else
                //{
                //    dal.Execute_1(@"INSERT INTO Wh_Oiner_Comp(Company_No,Company_a_name
                //    ,Company_e_name,User_id,G_date,Comp_Vat_no,Comp_AdressA,Comp_AdressE
                //    ,Comp_Phone_no,Comp_Fax,Comp_Email,Comp_Web_Site,Comp_Rc)
                //    ValueS ('" + txt_ID.Text + "','" + txt_Name.Text + "','" + txt_Name_E.Text + "','" +
                //    txt_User.Text + "','" + txt_Date.Text + "','" + txt_Vat_No.Text + "','" +
                //    txt_Address.Text + "','" + txt_Address_E.Text + "','" + txt_Tel_No.Text + "','" +
                //    txt_Fax_No.Text + "','" + txt_Email_No.Text + "','" + txt_Web_Site.Text + "','" +
                //    txt_Rc.Text + "')");
                //}

                //dal.Execute("Update_Company_Data",
                //    txt_id.Text,
                //    txt_name.Text,
                //    txt_name_e.Text,
                //    txt_User.Text,
                //    txt_date.Value.ToString("yyyy-MM-dd hh:mm:ss"),
                //    txt_vat_no.Text,
                //    txt_address.Text,
                //    txt_address_e.Text,
                //    txt_tel.Text,
                //    txt_fax.Text,
                //    txt_email.Text,
                //    txt_website.Text,
                //    txt_cr.Text,
                //    h_Logo,
                //    f_Logo,
                //    dal.db1);

            }
        }

        private void getCompanyData(string _id)
        {
            DataTable dt_ = dal.getDataTabl_1(@"select * from Wh_Oiner_Comp where Company_No = '" + _id + "'");
            if (dt_.Rows.Count > 0)
            {
                txt_id.Text = dt_.Rows[0]["Company_No"].ToString();
                txt_name.Text = dt_.Rows[0]["Company_a_name"].ToString();
                txt_name_e.Text = dt_.Rows[0]["Company_e_name"].ToString();
                txt_User.Text = dt_.Rows[0]["User_id"].ToString();
                txt_date.Value = Convert.ToDateTime(dt_.Rows[0]["G_date"].ToString());
                txt_vat_no.Text = dt_.Rows[0]["Comp_Vat_no"].ToString();
                txt_address.Text = dt_.Rows[0]["Comp_AdressA"].ToString();
                txt_address_e.Text = dt_.Rows[0]["Comp_AdressE"].ToString();
                txt_tel.Text = dt_.Rows[0]["Comp_Phone_no"].ToString();
                txt_fax.Text = dt_.Rows[0]["Comp_Fax"].ToString();
                txt_email.Text = dt_.Rows[0]["Comp_Email"].ToString();
                txt_website.Text = dt_.Rows[0]["Comp_Web_Site"].ToString();
                txt_cr.Text = dt_.Rows[0]["Comp_Rc"].ToString();

                if (dt_.Rows[0]["comp_hp"] != DBNull.Value)
                {
                    byte[] h_pic = (byte[])(dt_.Rows[0]["comp_hp"]);
                    MemoryStream ms = new MemoryStream(h_pic);
                    pic_header.Image = Image.FromStream(ms);
                    pic_header.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic_header.BorderStyle = BorderStyle.Fixed3D;
                    // ms.Close();
                }
                else
                {
                    pic_header.Image = null;
                }
                if (dt_.Rows[0]["comp_fp"] != DBNull.Value)
                {
                    byte[] f_pic = (byte[])dt_.Rows[0]["comp_fp"];
                    MemoryStream ms1 = new MemoryStream(f_pic);
                    pic_footer.Image = Image.FromStream(ms1);
                    pic_footer.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic_footer.BorderStyle = BorderStyle.Fixed3D;
                    //ms1.Close();
                }
                else
                {
                    pic_footer.Image = null;
                }
            }
        }

        private void txt_ID_TextChanged(object sender, EventArgs e)
        {
            getCompanyData(txt_id.Text);
        }

        private void BExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "c:/pic/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pic_header.Image = Image.FromFile(f.FileName);
                    pic_header.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic_header.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch
            {
            }
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "c:/pic/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pic_footer.Image = Image.FromFile(f.FileName);
                    pic_footer.SizeMode = PictureBoxSizeMode.StretchImage;
                    pic_footer.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch
            {
            }
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new DAL.dbDataContext();
            Oner_Comp = db.Wh_Oiner_Comps.Where(s => s.Company_No == txt_id.Text).First();
            GetData();
        }

        public override void GetData()
        {
            txt_id.Text = Oner_Comp.Company_No;
            txt_name.Text = Oner_Comp.Company_a_name; 
            txt_name_e.Text = Oner_Comp.Company_e_name;
            txt_User.Text = Oner_Comp.User_id;
            txt_date.Text = Oner_Comp.G_date.ToString();
            txt_vat_no.Text = Oner_Comp.Comp_Vat_no;
            txt_address.Text = Oner_Comp.Comp_AdressA;
            txt_address_e.Text = Oner_Comp.Comp_AdressE;
            txt_tel.Text = Oner_Comp.Comp_Phone_no;
            txt_fax.Text = Oner_Comp.Comp_Fax;
            txt_email.Text = Oner_Comp.Comp_Email;
            txt_website.Text = Oner_Comp.Comp_Web_Site;
            txt_cr.Text = Oner_Comp.Comp_Rc;
            //h_Logo = Oner_Comp.Comp_hP;
            //f_Logo = Oner_Comp.Comp_fp;

            base.GetData();
        }
    }
}
