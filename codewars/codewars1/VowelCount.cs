using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class VowelCount
    {
        public static int GetVowelCount(string str)
        {
            

            return (from c in "aeiou" select str.Count(f => f == c)).ToArray().Sum();
        }

    }
}
