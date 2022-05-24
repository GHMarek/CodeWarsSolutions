using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Two_sum
    {
        public static int[] TwoSum(int[] numbers, int target)
        {
            List<int> resList = new List<int>() { };

            for (int i = 0; i < numbers.Length; i++)
            {
                for (int j = 0; j < numbers.Length; j++)
                {
                    if (i == j)
                    {
                        continue;
                    }

                    if (numbers[i] + numbers[j] == target)
                    {
                        resList.Add(i);
                        resList.Add(j);
                        return resList.ToArray();
                    }
                }
            }

            return new int[0];
        }
    }
}
