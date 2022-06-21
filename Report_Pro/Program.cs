using System;
using System.Collections.Generic;

using System.Windows.Forms;

namespace Report_Pro
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        /// 


            public static decimal ToDecimal(this string strValue)
        {
            decimal d;
            if (decimal.TryParse(strValue, out d))
                return d;
            return 0;
        }

        public static int ParseInt(this string value, int defaultIntValue)
        {
            int parsedInt;
            if (int.TryParse(value, out parsedInt))
            {
                return parsedInt;
            }

            return defaultIntValue;
        }

        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
           // Application.Run(new Forms.frm_Main());
            //Application.Run(new Reports.Form1());
            Application.Run(new RPT.login_frm());

        }


        public static int R = 255;
        public static int G = 255;
        public static int B = 255;
        public static int FS = 8;

        public static int R1 = 240;
        public static int G1 = 255;
        public static int B1 = 255;
        public static int FS1 = 8;


        public static string salesman;
        public static string userID;
        public static string userCostCode;

       

        public static string _Languhe="0";
        public static string _Server =".";
        public static string _Database="acc";

    }
}
