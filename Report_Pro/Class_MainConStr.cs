using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Report_Pro
{
    class Class_MainConStr
    {
        public static String UDF_MainCnStr()
        {
            return Properties.Settings.Default.BahrainConnectionString.ToString().Trim();
        }
    }
}
