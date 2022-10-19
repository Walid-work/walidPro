using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;
using System.Web.Script.Serialization;

namespace Report_Pro
{
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void Form3_Resize(object sender, EventArgs e)
        {
            Control control = (Control)sender;

            // Ensure the Form remains square (Height = Width).
            if (control.Size.Height != control.Size.Width)
            {
                control.Size = new Size(control.Size.Width, control.Size.Width);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            //string[] intArray = { txtDescr.Text.ToString(), "txtDescr_E.Text", "txtSpecialNo.Text" };
            //String seperator =" +"+'"'+"','"+'"'+"+ ";
            //string result = "'" + '"' + " + ";
            //result += String.Join(seperator , intArray);
            //result += " +" + '"' + "'";
            //txtDescr.Text = result;

            txtDescr_E.Text = TranslateText(txtDescr.Text,"ar","en");

        }

        private void Form3_Load(object sender, EventArgs e)
        {

        }



        public string TranslateText(string input,string inputLanguh, string outputLanguh)
        {
            // Set the language from/to in the url (or pass it into this function)
            string url = String.Format
            ("https://translate.googleapis.com/translate_a/single?client=gtx&sl={0}&tl={1}&dt=t&q={2}",
             inputLanguh,outputLanguh, Uri.EscapeUriString(input));
            HttpClient httpClient = new HttpClient();
            string result = httpClient.GetStringAsync(url).Result;

            // Get all json data
            var jsonData = new JavaScriptSerializer().Deserialize<List<dynamic>>(result);

            // Extract just the first array element (This is the only data we are interested in)
            var translationItems = jsonData[0];

            // Translation Data
            string translation = "";

            // Loop through the collection extracting the translated objects
            foreach (object item in translationItems)
            {
                // Convert the item array to IEnumerable
                IEnumerable translationLineObject = item as IEnumerable;

                // Convert the IEnumerable translationLineObject to a IEnumerator
                IEnumerator translationLineString = translationLineObject.GetEnumerator();

                // Get first object in IEnumerator
                translationLineString.MoveNext();

                // Save its value (translated text)
                translation += string.Format(" {0}", Convert.ToString(translationLineString.Current));
            }

            // Remove first blank character
            if (translation.Length > 1) { translation = translation.Substring(1); };

            // Return translation
            return translation;
        }

        private void txtDescr_KeyUp(object sender, KeyEventArgs e)
        {
            try
            {
                txtDescr_E.Text = TranslateText(txtDescr.Text, "ar", "en");

            }
            catch 
            {

               
            }
        }

        private void paied_amount_TextChanged(object sender, EventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
