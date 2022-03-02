using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class museumDullThings
    {
        public static List<int> RemoveSmallest(List<int> numbers)
        {
            List<int> newList = new List<int> ();
            int cnt = 0;

            foreach (var e in numbers)
            {
                if (e != numbers.Min())
                {
                    newList.Add(e);
                }
                else if (e == numbers.Min() && (cnt == 0))
                {
                    cnt += 1;
                }
                else if ((e == numbers.Min()) && (cnt != 0))
                {
                    newList.Add(e);
                }

            }

            return newList;
        }
    }
}
