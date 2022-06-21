using QRCoder;
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
using System.Web;
using System.Windows.Forms;

namespace Report_Pro
{
    public partial class frm_QR_Code : Form
    {
        public frm_QR_Code()
        {
            InitializeComponent();
        }

        private void btnCreatQR_Click(object sender, EventArgs e)
        {
            string code = txtQr.Text.ToString() + System.Environment.NewLine + "invoice No :"+txtNo.Text.ToString()+ System.Environment.NewLine + "textt";


            QRCodeGenerator qRCodeGenerator = new QRCodeGenerator();
            QRCodeData qRCodeData = qRCodeGenerator.CreateQrCode(code, QRCodeGenerator.ECCLevel.Q);
            QRCode qRCode = new QRCode(qRCodeData);
            Bitmap bmp = qRCode.GetGraphic(7);
            using (MemoryStream ms = new MemoryStream())
            {
                bmp.Save(ms, ImageFormat.Bmp);

                byte[] byteImage = ms.ToArray();

                picQR.Image = bmp;

                RPT.QR_rpt rpt = new RPT.QR_rpt();
               
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
