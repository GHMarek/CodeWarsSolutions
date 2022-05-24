using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Number_of_People_in_the_Bus
    {
        public static int Number(List<int[]> peopleListInOut)
        {
            int res = 0;

            foreach (var item in peopleListInOut)
            {
                res += item[0];
                res -= item[1];
            }

            return res;
        }
    }
}
