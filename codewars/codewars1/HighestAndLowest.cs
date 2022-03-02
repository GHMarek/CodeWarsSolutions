using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class HighestAndLowest
    {
        public static string HighAndLow(string numbers)
        {
            string y = Convert.ToString( ( from i in numbers.Split(' ') select Int32.Parse(i)).ToArray().Max());

            //( from i in numbers.Replace("", " ") select Int32.Parse(i.ToString()) ).ToArray();
            return Convert.ToString((from i in numbers.Split(' ') select Int32.Parse(i)).ToArray().Max()) + " " + Convert.ToString((from i in numbers.Split(' ') select Int32.Parse(i)).ToArray().Min());
        }
    }
}
