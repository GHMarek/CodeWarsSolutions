using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Pangram
    {
        public static bool IsPangram(string str)
        {
            

            //Console.WriteLine(((char)97).ToString());

            //int y = 126 - 97;
            //Console.WriteLine(y.ToString());
            return str.ToLower().Where(x => (Char.IsLetter(x))).GroupBy(x => x).ToArray().Count() == 26;
        }
    }
}
