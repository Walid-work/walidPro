using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;
using System.IO;

using System.Net;
using System.Text;
using System.Windows.Forms;

namespace Report_Pro.PL
{
    public partial class frm_send_sms : Form
    {
        public frm_send_sms()
        {
            InitializeComponent();
        }

        private void groupPanel1_Click(object sender, EventArgs e)
        {

        }

        private void btn_Send_Click(object sender, EventArgs e)
        {
            //using (System.Net.WebClient client = new System.Net.WebClient())
            //{


            String result;
               string apiKey = txtUser.Text;
                string numbers = txtPhone.Text;
                string message = txtMessage.Text;
                string send = txtPass.Text;
                string url = "http://api.txtlocal.com/send/?apiKey=" + apiKey+" &number="+numbers+"&message=" + message + "&sender="+send;

                StreamWriter myWriter = null;
                HttpWebRequest opjRequest = (HttpWebRequest)WebRequest.Create(url);
                opjRequest.Method = "POST";
                opjRequest.ContentLength = Encoding.UTF8.GetByteCount(url);
                opjRequest.ContentType = "application/x-www-form-urlencoded";
            try
            {
                myWriter = new StreamWriter(opjRequest.GetRequestStream());
                myWriter.Write(url);

                //string result = client.DownloadString(url);
                //if (result.Contains("OK"))
                //    MessageBox.Show("Your message has been successfully sent.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //else
                //    MessageBox.Show("Message send failure.", "Message", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                myWriter.Close();

            }

            HttpWebResponse opjResponse = (HttpWebResponse)opjRequest.GetResponse();
            using (StreamReader sr = new StreamReader(opjResponse.GetResponseStream()))
            {
                result = sr.ReadToEnd();
                sr.Close();

            }
            //}
        }

        private void txtUser_TextChanged(object sender, EventArgs e)
        {

        }

        private void labelX2_Click(object sender, EventArgs e)
        {

        }
    }
}
