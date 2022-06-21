using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing; using System.Linq;

using System.Text;
using System.Windows.Forms;
using System.Net.Mail;

namespace Report_Pro.PL
{
    public partial class frm_sendEmail : Form
    {
        public frm_sendEmail()
        {
            InitializeComponent();
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //try
            //{
                MailMessage mail = new MailMessage();
                mail.From = new MailAddress(from.Text);
                mail.To.Add(to.Text);
                mail.Subject = (subject.Text);
                //mail.Attachments.Add(new Attachment(@"c:\\pic/Heead-usaimi.png"));
              
                mail.Attachments.Add(new Attachment(@Attach.Text));
                mail.IsBodyHtml = true;
                SmtpClient client = new SmtpClient(smtp.Text);
                client.Port = 587;
                client.Credentials = new System.Net.NetworkCredential(userName.Text, password.Text);
                client.EnableSsl = true;
                client.Send(mail);
                MessageBox.Show("EMAIL SEND ", "", MessageBoxButtons.OK);
            //}
            //           catch (System.Exception ex)
            //{
            //    MessageBox.Show(ex.Message);
            //    return;
            //}
        }

        private void from_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            OpenFileDialog ofd = new OpenFileDialog();
            ofd.Filter = "PDF Files(*.pdf)|*.pdf|WORD Files(*.doc;*.docx)|*.doc;*.docx|EXCEL Files(*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt)|*.xlsx;*.xlsm;*.xlsb;*.xltx;*.xltm;*.xls;*.xlt|Image Files(*.jpg;*.gif;*.bmp;*.png;*.jpeg)|*.jpg;*.gif;*.bmp;*.png;*.jpeg|All Files|*.*";
            if (ofd.ShowDialog() == DialogResult.OK)
            {
                string path = ofd.FileName.ToString();
                Attach.Text = path;
            }
        }

        private void frm_sendEmail_Load(object sender, EventArgs e)
        {

        }
    }
}
