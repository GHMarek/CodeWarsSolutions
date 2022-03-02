using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class DecodetheMorsecode
    {
        public static string Decode(string morseCode)
        {
            StringBuilder returnStr = new StringBuilder();

            foreach (var i in (from i in morseCode.Split("   ") select i).ToArray())
            {
                foreach (var j in i.Split(" "))
                {
                    returnStr.Append(j);
                }

                returnStr.Append(" ");
            }
            
            string decodedStr = string.Join(" ", from i in morseCode.Split(" ") select i);

            return decodedStr;
        }
    }
}
