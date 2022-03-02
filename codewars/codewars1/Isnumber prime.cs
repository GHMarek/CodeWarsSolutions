using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Isnumber_prime
    {
        public static bool IsPrime(int n)
        {
            if ((n > 0) && ((n + 1 / 2) == (int)(n + 1 / 2)))
            {
                return MakeSieve(n);
            }
            else
            {
                return false;
            }

        }
        public static bool MakeSieve(int max)
        {
            bool[] is_prime = new bool[max + 1];
            for (int i = 2; i <= max; i++)
            {
                is_prime[i] = true;
            }

            for (int i = 2; i <= max; i++)
            {
                if (is_prime[i])
                {
                    for (int j = i * 2; j <= max; j += i)
                        is_prime[j] = false;
                }
            }

            return is_prime.Length > 0 ? is_prime[max] : false;
        }
    }
}
