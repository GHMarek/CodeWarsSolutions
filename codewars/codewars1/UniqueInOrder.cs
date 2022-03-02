using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class UniqueinOrder
    {
        public static IEnumerable<T> UniqueInOrder<T>(IEnumerable<T> iterable)
        {

            List<T> newList = new List<T> { };

            if (iterable.ToArray().Length < 2)
            {
                return newList;
            }

            var prevVal = iterable.First();
            int cnt = 0;

            foreach (var i in iterable)
            {
                if (cnt == 0)
                {
                    prevVal = i;
                    cnt++;
                    newList.Add((T)i);
                }
                else
                {
                    if (i.ToString() != prevVal.ToString())
                    {
                        prevVal = i;
                        cnt++;
                        newList.Add((T)i);
                    }
                    else
                    {
                        continue;
                    }

                }

            }

            return newList;
        }
    }
}
