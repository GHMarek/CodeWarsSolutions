using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codewars1
{
    class SimplePigLatin
    {
        public static string PigIt(string str)
        {
            StringBuilder strB = new StringBuilder();

            foreach (var i in str.Split(' ').ToArray()) {

                List<char> strList = new List<char> { };
                StringBuilder strB2 = new StringBuilder();

                if (Regex.IsMatch(i, @"^[a-zA-Z]+$"))
                {


                    strList = i.Substring(1).ToList();
                    strList.Add(i.ToArray()[0]);

                    foreach (var j in strList)
                    {
                        strB2.Append(Convert.ToString(j));
                    }

                    strB.Append(strB2 + "ay ");

                }
                else
                {
                    strB.Append(i);
                }
                


            }
            return strB.ToString().Trim();
        }
    }
}
