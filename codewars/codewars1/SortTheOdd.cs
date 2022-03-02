using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class SortTheOdd
    {
        public static int[] SortArray(int[] array)
        {

            int[] sortedArray = array.Where(x => x % 2 != 0).OrderBy(x => x).ToArray();
            int cnt = 0;
            int sortedCnt = 0;
            
            foreach (int i in array)
            {
                if (i % 2 != 0)
                {
                    array[cnt] = sortedArray[sortedCnt];
                    sortedCnt++;
                }

                cnt++;
            }

            return array;
        }
    }
}
