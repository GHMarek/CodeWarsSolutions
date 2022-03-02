using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class FIrstNoRepeating
    {
        public static string FirstNonRepeatingLetter(string s)
        {

            return (from ch in s where s.ToLower()
                    .Count(x => x == Char.ToLower(ch)) == 1 select ch.ToString())
                    .DefaultIfEmpty(String.Empty).FirstOrDefault();
        }
    }
}
