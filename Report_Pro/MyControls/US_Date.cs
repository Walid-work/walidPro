using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
//using HijriDate;
using System.Globalization;

namespace Report_Pro.MyControls
{
    public partial class US_Date : UserControl
    {
        DAL.DataAccesslayer1 dal = new DAL.DataAccesslayer1();
        public US_Date()
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
            if (e.KeyCode == Keys.Enter)
            {


                try
                {
                    HD.Text = convertToHijri(GD.Text);
                    //DataTable dtCurrntdate_ = dal.getDataTabl("convertToHijri", Convert.ToDateTime(GD.Text));
                    //HD.Text = dtCurrntdate_.Rows[0][0].ToString();
                    //HD.Mask = "00/00/0000";
                    HD.Focus();
                    
                }


                catch
            
                {
                                        
                }

               
            }
        }

      
     

        private void GD_Leave(object sender, EventArgs e)
        {
            try
            {
                HD.Text = convertToHijri(GD.Text);
        
            }
            catch
            {
            }
        }

 


        public object sender { get; set; }

    
        private void HD_ButtonCustomClick(object sender, EventArgs e)
        {
       //    HijriDatePicker  hijriDT = new HijriDatePicker();
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

                //DataTable dtCurrntdate_ = dal.getDataTabl("convertToGorgain", HD.Text);
                //GD.Text = dtCurrntdate_.Rows[0][0].ToString();

            }
            catch
            {
                GD.Text = string.Empty;
                HD.Text = "";
            }
        }





       
    }
}
