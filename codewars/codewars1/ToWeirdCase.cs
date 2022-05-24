using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class ToWeirdCase
    {
        public static string WeirdCase(string s)
        {
            StringBuilder resString = new StringBuilder();

            int j = 1;
            foreach (var k in s.ToCharArray())
            {
                if (j % 2 != 0)
                {
                    resString.Append(k.ToString().ToUpper());
                }
                else
                {
                    resString.Append(k.ToString().ToLower());
                }

                if (!String.IsNullOrWhiteSpace(k.ToString()))
                {
                    j += 1;
                }
                else
                {
                    j = 1;
                }
            }

            return resString.ToString();
        }
    }
}
