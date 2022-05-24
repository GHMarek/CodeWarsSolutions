using System;
using System.Linq;
using System.Text;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace codewars1
{
    class breakCamel
    {
        public static string BreakCamelCase(string str)
        {

            StringBuilder strB = new StringBuilder();

            foreach (var x in str.ToCharArray().Select(x => x.ToString()).ToList())
            {
                if (Convert.ToChar(x) < 97) 
                { 
                    strB.Append($" {x}");
                }
                else 
                {
                    strB.Append(x);
                }
            }

            return strB.ToString();
        }
    }
}
