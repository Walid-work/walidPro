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
            return "server=" + Properties.Settings.Default.Server + " ;database= " + Convert.ToString(Properties.Settings.Default.Database_1) + " ;integrated security=false; user id = " + Properties.Settings.Default.Id + "; password = " + Properties.Settings.Default.Password + ";timeout=60".ToString().Trim();
        }
    }
}
