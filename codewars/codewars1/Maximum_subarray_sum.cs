using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Maximum_subarray_sum
    {
        public static int MaxSequence(int[] arr)
        {
            int resSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int localSum = arr[i];

                if (i + 1 > arr.Length)
                {
                    break;
                }

                for (int j = (i + 1); j < arr.Length; j++)
                {
                    localSum += arr[j];
                    if (localSum > resSum)
                    {
                        resSum = localSum;
                    }
                }
            }

            return resSum;
        }
    }
}
