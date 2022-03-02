using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class MoveZeros
    {
        public static int[] MoveZeroes(int[] arr)
        {
            List<int> resArr = new List<int> ();
            List<int> zeroes = new List<int>();

            foreach (var i in arr)
            {
                if (i == 0)
                {
                    zeroes.Add(i);
                }
                else
                {
                    resArr.Add(i);
                }
            }

            return resArr.Concat(zeroes).ToArray();
        }


    }
}
