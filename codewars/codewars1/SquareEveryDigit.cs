using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class SquareEveryDigit
    {
        public static int SquareDigits(int n)
        {
            //string x = n.ToString();
            //double y = Math.Pow(9, 2);
            //int[] zz = (from i in n.ToString() select Convert.ToInt32(i)).ToArray();

            //string z = string.Join("", (from i in n.ToString() select Convert.ToInt32(Math.Pow(Convert.ToInt32(i.ToString()), 2))).ToArray());


            return Convert.ToInt32(string.Join("", (from i in n.ToString() select Convert.ToInt32(Math.Pow(Convert.ToInt32(i.ToString()), 2))).ToArray())); 
        }
    }
}

