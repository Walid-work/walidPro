using System;
using System.Collections.Generic;

using System.Text;
//
using System.Data.SqlClient;
using System.Data;
using System.Reflection;
using System.Resources;
using System.Windows.Forms;
using System.Globalization;
using System.Drawing;
using ZXing;
using ZXing.QrCode;
using System.IO;
using System.Drawing.Imaging;

namespace Report_Pro.DAL
{
    class DataAccesslayer1
    {
        SqlConnection sqlconn1;
       public SqlConnection sqlconn_1;
        SqlDataAdapter da = new SqlDataAdapter();
        DataTable dt = new DataTable();

        public string db1 = Properties.Settings.Default.Database_1;
        public string db = Properties.Settings.Default.Database;



        public DataAccesslayer1()
        {

            string mode = Properties.Settings.Default.Mode;

            if (mode == "sql")
            {
                sqlconn_1 = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Convert.ToString(Properties.Settings.Default.Database_1) + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + ";timeout=60");
                sqlconn1 = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Convert.ToString(Properties.Settings.Default.Database) + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + "");
                
            }
            else
            {
                sqlconn_1 = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database_1 + " ;integrated security=true");
                sqlconn1 = new SqlConnection(@"server=" + Properties.Settings.Default.Server + " ;database= " + Properties.Settings.Default.Database + " ;integrated security=true");
            }
        }



        public void open()
        {
            if (sqlconn1.State != ConnectionState.Open)
            {
                sqlconn1.Open();
            }
        }


        public void open_1()
        {
            if (sqlconn_1.State != ConnectionState.Open)
            {

                sqlconn_1.Open();
            }
        }





        public void close()
        {
            if (sqlconn1.State == ConnectionState.Open)
            {
                sqlconn1.Close();
            }
        }


        public void close_1()
        {
            if (sqlconn_1.State == ConnectionState.Open)
            {
                sqlconn_1.Close();
            }
        }



        public  DataTable getDataTabl(string stored_procedure, params object[] param)
        {
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.StoredProcedure;
            sqlcmd1.CommandText = stored_procedure;
            sqlcmd1.Connection = sqlconn1;
            sqlcmd1.CommandTimeout = 100;
            if (param != null)
            {
                for (int i = 0; i <= param.Length - 1; i++)
                {
                    sqlcmd1.Parameters.AddWithValue("@" + i, param[i]);
                }
            }
            SqlDataAdapter da1 = new SqlDataAdapter(sqlcmd1);
            DataTable dt1 = new DataTable();
                da1.Fill(dt1);
            return dt1;
        }


        public  DataTable getDataTabl_1(string sp)
        {

       
            close_1();
            SqlCommand cmd = new SqlCommand();
            open_1();
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1000;
            cmd.Connection = sqlconn_1;
            SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);
            return dt1;

            //sqlconn1.Close();
        }


        public int effectRows(string sp)
        {


            close_1();
            SqlCommand cmd = new SqlCommand();
            open_1();
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.Text;
            cmd.CommandTimeout = 1000;
            cmd.Connection = sqlconn_1;
            int rows_count = Convert.ToInt32(cmd.ExecuteNonQuery());
            //SqlDataAdapter da1 = new SqlDataAdapter(cmd);
            //DataTable dt1 = new DataTable();
            //da1.Fill(dt1);
            //return dt1;
            return rows_count;

            //sqlconn1.Close();
        }


        public object GetCell_1(string sp)
        {

            try
            {
                close_1();
                SqlCommand cmd = new SqlCommand();
                open_1();
                cmd.CommandText = sp;
                cmd.CommandType = CommandType.Text;
                cmd.Connection = sqlconn_1;
                
                return cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }



        public object GetCell(string stored_procedure, params object[] param)
        {

            try
            {
                SqlCommand sqlcmd1 = new SqlCommand();
                sqlcmd1.CommandType = CommandType.StoredProcedure;
                sqlcmd1.CommandText = stored_procedure;
                sqlcmd1.Connection = sqlconn1;
                if (param != null)
                {
                    for (int i = 0; i <= param.Length - 1; i++)
                    {
                        sqlcmd1.Parameters.AddWithValue("@" + i, param[i]);
                    }
                }

                return sqlcmd1.ExecuteScalar();
            }
            catch (Exception ex)
            {
                return ex.Message.ToString();
            }

        }


       
        public DataRow getDataRow(string stored_procedure, params object[] param)
        {
           
            SqlCommand sqlcmd1 = new SqlCommand();
            sqlcmd1.CommandType = CommandType.StoredProcedure;
            sqlcmd1.CommandText = stored_procedure;
            sqlcmd1.Connection = sqlconn1;
            if (param != null)
            {
                for (int i = 0; i <= param.Length - 1; i++)
                {
                    sqlcmd1.Parameters.AddWithValue("@" + i, param[i]);
                }
            }
            SqlDataAdapter da1 = new SqlDataAdapter(sqlcmd1);
            DataTable dt1 = new DataTable();
            da1.Fill(dt1);

            DataRow dr = dt1.Rows[0];
            return dr;
           
        }









        public void Execute(string sp, params object[] obj)
        {
            if (sqlconn1.State == ConnectionState.Open)
            {
                sqlconn1.Close();
            }
            SqlCommand cmd = new SqlCommand();
            
            sqlconn1.Open();
            cmd = new SqlCommand(sp, sqlconn1);
            cmd.CommandType = CommandType.StoredProcedure;
            int i = 0;
            for (i = 0; i <= obj.Length - 1; i++)
            {
                cmd.Parameters.AddWithValue("@" + i, obj[i]);
            }

            cmd.ExecuteNonQuery();
           

        }

        public void Execute_1(string sp)
        {


            open_1();
            SqlCommand cmd = new SqlCommand();
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.Text;
            cmd.Connection = sqlconn_1;
            cmd.ExecuteNonQuery();
            sqlconn_1.Close();
            
        }


        public void Execute_1_test(string sp)
        {
           
            close_1();

            SqlCommand cmd = new SqlCommand();
            open_1();
            cmd.CommandText = sp;
            cmd.CommandType = CommandType.Text;
           
        }


            public void Execute_test(string sp, params object[] obj)
        {
            if (sqlconn1.State == ConnectionState.Open)
            {
                sqlconn1.Close();
            }
            SqlCommand cmd = new SqlCommand();

            sqlconn1.Open();
            cmd = new SqlCommand(sp, sqlconn1);
            cmd.CommandType = CommandType.StoredProcedure;
            int i = 0;
            for (i = 0; i <= obj.Length - 1; i++)
            {
                cmd.Parameters.AddWithValue("@" + i, obj[i]);
            }
        }

        public bool IsDateTime(string text)
        {
            DateTime dateTime;
            bool isDateTime = false;

            // Check for empty string.
            if (string.IsNullOrEmpty(text))
            {
                return false;
            }

            isDateTime = DateTime.TryParse(text, out dateTime);

            return isDateTime;
        }


        internal object selectdata(string p1, string p2)
        {
            throw new NotImplementedException();
        }



        public  int digits_ = Properties.Settings.Default.digitNo_;
     
        public int dicimalRate()
        {
            switch (digits_)
            {
                case 1:
                    return 10;
                case 2:
                    return 100;
                    ;
                case 3:
                    return 1000;
                default:
                    return 0;
                   
            }
        }

       
    public string languh_ = Properties.Settings.Default.lungh ;

        //public  int R = 255;
        //public  int G = 255;
        //public  int B = 255;
        //public  int FS = 10;

        private object Image;
        //  private object options;
        //QrCodeEncodingOptions options;

        public PictureBox pic1;
        QrCodeEncodingOptions options = new QrCodeEncodingOptions()
        {
            DisableECI = true,
            CharacterSet = "UTF-8",
            Width = 250,
            Height = 250,
        };
        //        var writer = new BarcodeWriter();
        //        writer.Format = BarcodeFormat.QR_CODE;
        //writer.Options = options; 

        //update : Feb 3,2018

        // Methods
        public Image GetImsge(string s, string str2, string str3, string str4, string str5)
        {
            Image image = null;
            //string s = Seller_name;     
            //string str2 = VAT_Number;
            //string str3 = Time_Stamp;
            //string str4 = Invoice_Total;
            //string str5 = VAT_Total;
            //string str6 = puyer_Name;
            List<byte> list = new List<byte>
            {
            BitConverter.GetBytes((short) 1)[0],
            BitConverter.GetBytes((short) s.Length)[0] };
            list.AddRange(Encoding.UTF8.GetBytes(s));

            list.Add(BitConverter.GetBytes((short)2)[0]);
            list.Add(BitConverter.GetBytes((short)str2.Length)[0]);
            list.AddRange(Encoding.UTF8.GetBytes(str2));

            list.Add(BitConverter.GetBytes((short)3)[0]);
            list.Add(BitConverter.GetBytes((short)str3.Length)[0]);
            list.AddRange(Encoding.UTF8.GetBytes(str3));

            list.Add(BitConverter.GetBytes((short)4)[0]);
            list.Add(BitConverter.GetBytes((short)str4.Length)[0]);
            list.AddRange(Encoding.UTF8.GetBytes(str4));

            list.Add(BitConverter.GetBytes((short)5)[0]);
            list.Add(BitConverter.GetBytes((short)str5.Length)[0]);
            list.AddRange(Encoding.UTF8.GetBytes(str5));


            BarcodeWriter writer = new BarcodeWriter();
            writer.Format = BarcodeFormat.QR_CODE;
            writer.Options = options;
            //BarcodeWriter writer = new BarcodeWriter
            //{
            //    Options = this.options,

            //    Format = BarcodeFormat.QR_CODE


            //};
            Bitmap bitmap = new Bitmap(writer.Write(Convert.ToBase64String(list.ToArray())));
            pic1.Image = bitmap;
            Image = bitmap;
            return image;
        }









        public CultureInfo cul;
        // Assembly a = Assembly.Load("Report_Pro");
       public ResourceManager rm = new ResourceManager("Report_Pro.Lang.Langres", Assembly.Load("Report_Pro"));


        public void ClearTextBoxes(Form frm)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Text = "";
                    else if (control is DataGridView)
                        (control as DataGridView).DataSource = null;



                    else
                        func(control.Controls);
            };

            func(frm.Controls);
        }



        public void ClearTextBoxes_uc(UserControl uc)
        {
            Action<Control.ControlCollection> func = null;

            func = (controls) =>
            {
                foreach (Control control in controls)
                    if (control is TextBox)
                        (control as TextBox).Clear();
                    else if (control is ComboBox)
                        (control as ComboBox).SelectedIndex = -1;
                    else if (control is DateTimePicker)
                        (control as DateTimePicker).Value = DateTime.Now;
                    else if (control is DevComponents.Editors.DoubleInput)
                        (control as DevComponents.Editors.DoubleInput).Value = 0;
                    else if (control is DevComponents.Editors.DateTimeAdv.DateTimeInput)
                        (control as DevComponents.Editors.DateTimeAdv.DateTimeInput).Text = "";
                    else if (control is DataGridView)
                    {
                        (control as DataGridView).DataSource = null;
                        (control as DataGridView).Rows.Clear();
                    }



                    else
                        func(control.Controls);
            };

            func(uc.Controls);
        }


        public string convertToHijri(string greg)
        {

            HijriCalendar h = new HijriCalendar();

            GregorianCalendar g = new GregorianCalendar(GregorianCalendarTypes.USEnglish);

            DateTime tempDate = Convert.ToDateTime(greg);

            DateTime date3 = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, g);

            string hijri = h.GetYear(date3).ToString() + "/" + h.GetMonth(date3).ToString() + "/" + h.GetDayOfMonth(date3).ToString();

            DateTime tempDate2 = Convert.ToDateTime(hijri);

            hijri = tempDate2.ToString("dd/MM/yyyy");

            return hijri;


        }



        public byte[] ReadFile(string sPath)
        {
            byte[] data = null;
            FileInfo fInfo = new FileInfo(sPath);
            long numBytes = fInfo.Length;
            FileStream fStream = new FileStream(sPath, FileMode.Open, FileAccess.Read);
            BinaryReader br = new BinaryReader(fStream);
            data = br.ReadBytes((int)numBytes);
            br.Close();
            fStream.Close();
            return data;
        }


       public byte[] ConvertImageToBytes(Image img)
        {
           
            using (MemoryStream ms = new MemoryStream())
            {
                if (img == null)
                {
                    return null;
                }
                else
                {
                    img.Save(ms, ImageFormat.Jpeg);
                    return ms.ToArray();
                    
                }
              

            }
        }



    }




}
