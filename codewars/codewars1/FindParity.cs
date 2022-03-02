using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class FindParity
    {
        public static int Find(int[] integers)
        {
            bool oddXeven = (integers.Count(x => x % 2 == 0) > integers.Count(x => x % 2 != 0));

            switch (oddXeven)
            {
                case true:
                    return integers.Where(x => x % 2 != 0).ToArray()[0];
                case false:
                    return integers.Where(x => x % 2 == 0).ToArray()[0];
            }

        }
    }
}
