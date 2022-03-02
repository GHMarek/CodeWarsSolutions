using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class DeleteNoccurrences
    {
        public static int[] DeleteNth(int[] arr, int x)
        {
            List<int> newArr = new List<int> { };
            Dictionary<int, int> myDict = new Dictionary<int, int> { };
            

            foreach (var item in arr.Distinct())
            {
                myDict.Add(item, 0);
            }

            

            foreach (var item in arr)
            {
                int u = myDict[item];

                if (myDict[item] < x )
                {
                    myDict[item] += 1;
                    newArr.Add(item);

                }
                else
                {
                    continue;
                }
            }

            return newArr.ToArray();
        }
    }
}
