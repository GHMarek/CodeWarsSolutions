using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class maxMultiply
    {
        public static int MaxMultiply(int divisor, int bound)
        {

            return Enumerable.Range(1, bound).Where(x => x % divisor == 0).Max();
        }
    }
}
