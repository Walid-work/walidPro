using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing; using System.Linq;
using System.Data;
//using HijriDate;
using System.Text;
using System.Windows.Forms;

using System.Globalization;

namespace Report_Pro.MyControls
{
    public partial class UC_Date : UserControl
    {
        Dates date_ = new Dates();
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public UC_Date()
        {
            InitializeComponent();
            
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


        public string convertoAD(string hijri)
        {




            HijriCalendar h = new HijriCalendar();

            GregorianCalendar g = new GregorianCalendar(GregorianCalendarTypes.USEnglish);

            DateTime tempDate = Convert.ToDateTime(hijri);

            DateTime date3 = new DateTime(tempDate.Year, tempDate.Month, tempDate.Day, h);

            string ad = g.GetYear(date3).ToString() + "/" + g.GetMonth(date3).ToString() + "/" + g.GetDayOfMonth(date3).ToString();

            DateTime tempDate2 = Convert.ToDateTime(ad);

            ad = tempDate2.ToString("yyyy/MM/dd");

            return ad;

        }






        private void GD_KeyDown(object sender, KeyEventArgs e)
        {
           


           
                try
                {
                if (e.KeyCode == Keys.Enter)
                {
                    HD.Text = date_.GregToHijri(GD.Text);
                    HD.Focus();
                }


            }


                catch
            
                {
                                        
                }

               
            
        }

      
     

        private void GD_Leave(object sender, EventArgs e)
        {
            try
            {
                HD.Text = date_.GregToHijri(GD.Text);

            }
            catch
            {
            }
        }

 


        public object sender { get; set; }

    
        private void HD_ButtonCustomClick(object sender, EventArgs e)
        {
           //HijriDatePicker  hijriDT = new HijriDatePicker();
           //hijriDT.Show();
           //hijriDT.BringToFront();
        }

        private void HD_KeyDown_1(object sender, KeyEventArgs e)
        {

            if (e.KeyCode == Keys.Enter)
            {

                try
                {
                    GD.Text = convertoAD(HD.Text);
                   
                }
                catch
                {
                    GD.Text = string.Empty;
                    HD.Text = "";
                }
            }
        }

        private void HD_Leave_1(object sender, EventArgs e)
        {
            try
            {
                GD.Text = convertoAD(HD.Text);

            }
            catch
            {
                GD.Text = string.Empty;
                HD.Text = "";
            }
        }

        private void GD_Click(object sender, EventArgs e)
        {

        }

        private void GD_TextChanged(object sender, EventArgs e)
        {
            OnLoad(e);
        }

        private void GD_KeyUp(object sender, KeyEventArgs e)
        {
            OnLeave(e);
        }

        private void GD_ValueChanged(object sender, EventArgs e)
        {
            HD.Text = date_.GregToHijri(GD.Text);
        }

        private void HD_Click(object sender, EventArgs e)
        {
            HD.Focus();
        }

        private void UC_Date_Load(object sender, EventArgs e)
        {
            HD.Text = date_.GregToHijri(GD.Text);

        }
    }
}
