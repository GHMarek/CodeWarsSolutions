using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class PlayingWithDigits
    {
        public static long digPow(int n, int p)
        {
            double sum = 0;

            for (int i = 0; i < n.ToString().Length; i++)
            {
                sum += Math.Pow((int)Char.GetNumericValue(n.ToString()[i]), p + i);
            }

            if (sum % (double)n == 0)
            {
                return Convert.ToInt64(sum / (double)n);
            }
            else
            {
                return -1;
            }

        }
    }
}
