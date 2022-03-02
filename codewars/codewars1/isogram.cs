using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class isogram
    {
        public static bool IsIsogram(string str)
        {
           return (str.ToLower().Distinct().ToArray().Length == str.Length) ? true : false;
        }
    }
}
