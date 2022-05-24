using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class JohnMeeting
    {
        public static string Meeting(string s)
        {
            
            string resStr = String.Empty;
            List<string> strList = new List<string>() { };
            
            foreach (var item in s.Split(';'))
            {

                resStr = $"({item.Split(':')[1].ToUpper()}, {item.Split(':')[0].ToUpper()})";

                strList.Add(resStr);

            }

            strList.Sort();

            return String.Join("", (from i in strList select i));
        }
    }
}
