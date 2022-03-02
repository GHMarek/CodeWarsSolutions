using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Multiples_of_3_or_5
    {
        public static int Solution(int value)
        {
            switch (value < 0)
            {
                case false:
                    return Enumerable.Range(1, value-1).Where(x => x % 5 == 0 || x % 3 == 0).ToArray().Sum();
                case true:
                    return 0;
            }

        }
    }
}
