using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Report_Pro.Classes
{
    public static class Master
    {
        public static string _Languh= Properties.Settings.Default.lungh;
     
        public class ValueAndID
        {
            public string ID { get; set; }
            public string Name { get; set; }
            public string EName { get; set; }
        }
        public enum Actions
        {
            Show=1,
            Open,
            Add,
            Edit,
            Delete,
            Print,
        }

        public enum UserType
        {
            Admin = 1,
            User,
        }

        public static void IntializeGlkpData(this GridLookUpEdit lkp, object dataSource, string displayMember, string valueMember)
        {
            lkp.Properties.DataSource = dataSource;
            lkp.Properties.DisplayMember = displayMember;
            lkp.Properties.ValueMember = valueMember;

        }


        //public static void IntializeData(this LookUpEdit lkp, object dataSource)
        //{
        //    lkp.IntializeData(dataSource, "Name", "ID");
        //}
        public static void IntializeData(this SearchLookUpEdit lkp, object dataSource, string displayMember, string valueMember)
        {
            lkp.Properties.DataSource = dataSource;
            lkp.Properties.DisplayMember = displayMember;
            lkp.Properties.ValueMember = valueMember;

        }


        public static T FromByteArray<T>(byte[] data)
        {
            if (data == null)
                return default(T);
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream(data))
            {
                object obj = formatter.Deserialize(stream);
                return (T)obj;
                //return  (T)formatter.Deserialize(stream);
            };
        }
        public static byte[] ToByteArray<T>(T obj)
        {
            if (obj == null)
                return null;
            BinaryFormatter formatter = new BinaryFormatter();
            using (MemoryStream stream = new MemoryStream())
            {
                formatter.Serialize(stream, obj);
                return stream.ToArray();
            };
        }

        public static byte[] GetPropertyValue(string propertyName, int profileID)
        {
            using (var db = new DAL.dbDataContext())
            {
                var prop = db.UserSettingsProfileProperties.SingleOrDefault(x => x.ProfileID == profileID &&
               x.PropertyName == propertyName);
                if (prop == null)
                    return null;
                return prop.PropertyValue.ToArray();
            }
        }
        public static string GetCallerName([CallerMemberName] string callerName = "")
        {
            return callerName;
        }

        public static List<ValueAndID> LanguhList = new List<ValueAndID>() {
                new ValueAndID() { ID = "A", Name  = "عربي",EName = "Arabic" },
                new ValueAndID() { ID = "E", Name  = "انجليزي",EName = "English" },

        };

    }

}
