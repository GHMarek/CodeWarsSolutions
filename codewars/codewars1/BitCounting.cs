using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class BitCounting
    {
        public static int CountBits(int n)
        {
            int[] t = Array.ConvertAll(Convert.ToString(n, 2).ToArray(), x => Convert.ToInt32(Convert.ToString(x)));
            
            foreach (var item in t)
            {
                Console.WriteLine(item);
            }
            

            return Array.ConvertAll(Convert.ToString(n, 2).ToArray(), x => Convert.ToInt32(Convert.ToString(x))).Sum();
        }
    }
}
