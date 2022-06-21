using Aspose.BarCode.Generation;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_pritBracode : Form
    {

        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public frm_pritBracode()
        {
            InitializeComponent();
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            DataSet ds = new DataSet();
            RPT.rpt_PrintBarcode rpt = new RPT.rpt_PrintBarcode();
            DataTable dtBarcode = dal.getDataTabl_1(@"select item_no,factory_no,descr from wh_main_master where item_no ='" + item_.ID.Text + "'");
            if (dtBarcode.Rows.Count > 0)
            {
                DataTable dQR = new DataTable();

                PictureBox img = new PictureBox();
                PictureBox img_f = new PictureBox();
                createbarcode(dtBarcode.Rows[0]["item_no"].ToString(), img);
                string facNo;
                if (dtBarcode.Rows[0]["factory_no"].ToString().Trim()!=string.Empty)
                {
                    facNo = dtBarcode.Rows[0]["factory_no"].ToString();
                }
                else
                {
                    facNo = "0";
                }

                createbarcode(facNo, img_f);
                byte[] byteImage;
                byte[] byteImage_f;

                using (MemoryStream ms = new MemoryStream())
                {
                    img.Image.Save(ms, ImageFormat.Bmp);
                    byteImage = ms.ToArray();
                }

                using (MemoryStream ms_f = new MemoryStream())
                {
                    img_f.Image.Save(ms_f, ImageFormat.Bmp);
                    byteImage_f = ms_f.ToArray();
                }

                dQR.Columns.Add(new DataColumn("Barcode", typeof(byte[])));
                dQR.Columns.Add(new DataColumn("Barcode_f", typeof(byte[])));
                dQR.Rows.Add(byteImage, byteImage_f);

                ds.Tables.Add(dtBarcode);
                ds.Tables.Add(dQR);
                //ds.WriteXmlSchema("schema_rpt.xml");
                rpt.SetDataSource(ds);
                for (int i = 1; i <= NoOfLabels.Value; i++)
                {
                    rpt.PrintOptions.PrinterName = Properties.Settings.Default.Barcode_P;
                    rpt.PrintToPrinter(1, false, 0, 15);
                }
            }
        }


        private void createbarcode(string barcode, PictureBox img)
        {
            if (barcode.Length >= 1)
            {

                BarcodeGenerator generator = new BarcodeGenerator(EncodeTypes.Code128, barcode);

                // set resolution
                generator.Parameters.Resolution = 400;

                // generate barcode
                generator.Save("generate-barcode.png");
                img.Image = generator.GenerateBarCodeImage();
                byte[] byteImage = imgToByteArray(img.Image);



            }
            else
            {
                img.Image = null;
            }
        }


        public byte[] imgToByteArray(Image img)
        {
            MemoryStream ms = new MemoryStream();
            img.Save(ms, System.Drawing.Imaging.ImageFormat.Gif);
            return ms.ToArray();
        }



    }
}
