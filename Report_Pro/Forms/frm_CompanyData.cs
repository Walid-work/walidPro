using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Forms
{
    public partial class frm_CompanyData : frm_Master
    {
        DAL.Wh_Oiner_Comp _comp;
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_CompanyData()
        {
            InitializeComponent();
            New();
            // var db = new DAL.dbDataContext();
        }

        private void frm_Users_Load(object sender, EventArgs e)
        { // New();

        }

        public override void New()
        {
            _comp = new DAL.Wh_Oiner_Comp();
            base.New();
        }

        public override void Save()
        {
            var db = new DAL.dbDataContext();

            if (txt_id.Text.Trim() == string.Empty)
            {
                txt_id.ErrorText = "برجاء ادخال اسم المستخدم";
                return;
            }
            if (txt_name.Text.Trim() == string.Empty)
            {
                txt_name.ErrorText = "برجاء ادخال الاسم ";
                return;
            }

        
            
            //if (_comp.Company_No == null)
            //{
            //    db.Wh_Oiner_Comps.InsertOnSubmit(_comp);
            //}
            //else
            //{
            //    db.Wh_Oiner_Comps.Attach(_comp);
            //}
            SetData();
            //db.SubmitChanges();


            base.Save();
        }
        public override void Delete()
        {
            base.Delete();
        }

        public override void SetData()
        {
            byte[] h_Logo = null;
            byte[] f_Logo = null;
            byte[] S_Logo = null;



            if (pic_header.Image == null)
            {

                h_Logo = null;
            }
            else
            {
                MemoryStream ms = new MemoryStream();
                pic_header.Image.Save(ms, System.Drawing.Imaging.ImageFormat.Jpeg);
                h_Logo = new byte[ms.Length];
              //  ms.Close();
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

            if (stamp_pic.Image == null)
            {

                S_Logo = null;
            }
            else
            {
                MemoryStream ms2 = new MemoryStream();
                stamp_pic.Image.Save(ms2, stamp_pic.Image.RawFormat);
                S_Logo = ms2.GetBuffer();
                ms2.Close();
            }
            
            DataTable  dt_check = dal.getDataTabl_1(@"select Company_No from Wh_Oiner_Comp where Company_No='" + txt_id.Text + "'");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dal.sqlconn_1;
            dal.open_1();
            if (dt_check.Rows.Count > 0)
            {
               
                cmd.CommandText  = @"UPDATE Wh_Oiner_Comp
                 SET Company_No      = @Company_No
                ,Company_a_name  = @Company_a_name
                ,Company_e_name  = @Company_e_name
                ,User_id         = @User_id
                ,G_date          = @G_date
                ,Comp_Vat_no     = @Comp_Vat_no
                ,Comp_AdressA    = @Comp_AdressA
                ,Comp_AdressE    = @Comp_AdressE
                ,Comp_Phone_no   = @Comp_Phone_no
                ,Comp_Fax        = @Comp_Fax
                ,Comp_Email      = @Comp_Email
                ,Comp_Web_Site   = @Comp_Web_Site
                ,Comp_Rc         = @Comp_Rc
                ,h_pic           = @h_pic
                ,f_pic           = @f_pic
                ,stamp_pic       = @stamp_pic
                where Company_No = @Company_No ";

               
            }
            else
            {
                //SqlCommand cmd = new SqlCommand();
                //cmd.Connection = dal.sqlconn_1;
                //dal.open_1();
                cmd.CommandText = @"INSERT INTO Wh_Oiner_Comp
                ( Company_No
                 ,Company_a_name 
                 ,Company_e_name 
                 ,User_id        
                 ,G_date         
                 ,Comp_Vat_no    
                 ,Comp_AdressA   
                 ,Comp_AdressE   
                 ,Comp_Phone_no  
                 ,Comp_Fax       
                 ,Comp_Email     
                 ,Comp_Web_Site  
                 ,Comp_Rc        
                 ,h_pic          
                 ,f_pic          
                 ,stamp_pic )    

                 VALUES
                 ( @Company_No
                 ,@Company_a_nam
                 ,@Company_e_nam
                 ,@User_id
                 ,@G_date
                 ,@Comp_Vat_no
                 ,@Comp_AdressA
                 ,@Comp_AdressE
                 ,@Comp_Phone_no
                 ,@Comp_Fax
                 ,@Comp_Email
                 ,@Comp_Web_Site
                 ,@Comp_Rc
                 ,@h_pic
                 ,@f_pic
                 ,@stamp_pic)";
                            }
            cmd.Parameters.AddWithValue("@Company_No", txt_id.Text);
            cmd.Parameters.AddWithValue("@Company_a_name", txt_name.Text);
            cmd.Parameters.AddWithValue("@Company_e_name", txt_name_e.Text);
            cmd.Parameters.AddWithValue("@User_id", Program.userID);
            cmd.Parameters.AddWithValue("@G_date", txt_date.DateTime);
            cmd.Parameters.AddWithValue("@Comp_Vat_no", txt_vat_no.Text);
            cmd.Parameters.AddWithValue("@Comp_AdressA", txt_address.Text);
            cmd.Parameters.AddWithValue("@Comp_AdressE", txt_address_e.Text);
            cmd.Parameters.AddWithValue("@Comp_Phone_no", txt_tel.Text);
            cmd.Parameters.AddWithValue("@Comp_Fax", txt_fax.Text);
            cmd.Parameters.AddWithValue("@Comp_Email", txt_email.Text);
            cmd.Parameters.AddWithValue("@Comp_Web_Site", txt_website.Text);
            cmd.Parameters.AddWithValue("@Comp_Rc", txt_cr.Text);
            cmd.Parameters.AddWithValue("@h_pic", dal.ConvertImageToBytes(pic_header.Image));
            cmd.Parameters.AddWithValue("@f_pic", dal.ConvertImageToBytes(pic_footer.Image));
            cmd.Parameters.AddWithValue("@stamp_pic", dal.ConvertImageToBytes(stamp_pic.Image));
            cmd.ExecuteNonQuery();


            base.SetData();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            var db = new DAL.dbDataContext();
            _comp = db.Wh_Oiner_Comps.Single(s => s.Company_No == txt_id.Text);
            GetData();
        }

        public override void GetData()
        {
            txt_id.Text = _comp.Company_No;
            txt_name.Text = _comp.Company_a_name;
            txt_name_e.Text = _comp.Company_e_name;
            txt_address.Text = _comp.Comp_AdressA;
            txt_address_e.Text = _comp.Comp_AdressE;
            txt_tel.Text = _comp.Comp_Phone_no;
            txt_fax.Text = _comp.Comp_Fax;
            txt_email.Text = _comp.Comp_Email;
            txt_website.Text = _comp.Comp_Web_Site;
            txt_vat_no.Text = _comp.Comp_Vat_no;
            txt_cr.Text = _comp.Comp_Rc;
            txt_date.Text = _comp.G_date.ToString();
            //txt_h_url.Text = _comp.h_pic;
            //txt_f_url.Text = _comp.f_pic;

            try
            {
                byte[] h_pic = _comp.h_pic.ToArray();
                MemoryStream ms = new MemoryStream(h_pic);
                pic_header.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

                pic_header.Image = null;
            }

           
            try
            {
                byte[] f_pic = _comp.f_pic.ToArray();
                MemoryStream ms = new MemoryStream(f_pic);
                pic_footer.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

                pic_footer.Image=null;
            }
               
            


            try
            {
                byte[] stamppic = _comp.stamp_pic.ToArray();
                MemoryStream ms = new MemoryStream(stamppic);
                stamp_pic.Image = Image.FromStream(ms);
            }
            catch (Exception)
            {

                stamp_pic.Image = null;
            }
               
       



            base.GetData();
        }

        private void pic_header_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void layoutControlItem15_Click(object sender, EventArgs e)
        {
                    }

        private void pic_footer_Click(object sender, EventArgs e)
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
                    txt_f_url.Text = f.FileName.ToString();
                    //pic_footer.SizeMode = PictureBoxSizeMode.StretchImage;
                    //pic_footer.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch
            {
            }

        }

        private void pic_header_Click(object sender, EventArgs e)
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
                    txt_h_url.Text = f.FileName.ToString();
                    //pic_header. = PictureBoxSizeMode.StretchImage;
                    //pic_header.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch
            {
            }

        }

        private void pic_footer_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void stamp_pic_EditValueChanged(object sender, EventArgs e)
        {
         


        }

        private void stamp_pic_Click(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "c:/pic/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    stamp_pic.Image = Image.FromFile(f.FileName);
                    //txt_h_url.Text = f.FileName.ToString();
                    //pic_header. = PictureBoxSizeMode.StretchImage;
                    //pic_header.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch
            {
            }
        }

  
    }
}
