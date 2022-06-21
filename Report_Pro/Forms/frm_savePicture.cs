using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.Forms
{
    public partial class frm_savePicture : Form
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_savePicture()
        {
            InitializeComponent();
        }

        private void pictureBox1_DoubleClick(object sender, EventArgs e)
        {
            try
            {
                OpenFileDialog f = new OpenFileDialog();
                f.InitialDirectory = "c:/pic/";
                f.Filter = "All Files|*.*|JPEGs|*.jpg|Bitmaps|*.bmp|GIFs|*.gif";
                f.FilterIndex = 2;
                if (f.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image = Image.FromFile(f.FileName);
                    pictureBox1.Text = f.FileName.ToString();
                    //pic_header. = PictureBoxSizeMode.StretchImage;
                    //pic_header.BorderStyle = BorderStyle.Fixed3D;

                }
            }
            catch
            {
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }
        //byte [] ConvertImageToBytes(Image img)
        //{
        //    using (MemoryStream ms = new MemoryStream())
        //    {
        //        img.Save(ms, ImageFormat.Jpeg);
        //        return ms.ToArray();

        //    }
        //}

        private void button1_Click(object sender, EventArgs e)
        {

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = dal.sqlconn_1;
            dal.open_1();
            cmd.CommandText = "UPDATE Wh_Oiner_Comp  SET f_pic =@img where Company_No = @id";

            cmd.Parameters.AddWithValue("@img", dal.ConvertImageToBytes(pictureBox1.Image));
            cmd.Parameters.AddWithValue("@id", "A");
            cmd.ExecuteNonQuery();
        }

    }
}
