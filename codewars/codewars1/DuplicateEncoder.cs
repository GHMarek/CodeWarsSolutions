using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class DuplicateEncoder
    {
        public static string DuplicateEncode(string word)
        {
            string newStr = String.Empty;
            string str1 = word.ToLower();

            foreach (var item in str1.ToArray())
            {

                if (str1.Count(x => x == item) > 1)
                {
                    newStr += ")";
                }
                else
                {
                    newStr += "(";
                }
            }
            return newStr;
        }
    }
}
