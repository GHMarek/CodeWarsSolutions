using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class AreTheySame
    {
        public static bool comp(int[] a, int[] b)
        {
            if (a.Length == 0 || b.Length == 0) { return false; }

            var x = a.Distinct();
            var y = b.Distinct();

            x = x.Select(x => (int)Math.Pow(x, 2)).ToList();
            y = y.Select(x => x).ToList();

            foreach (var item in y)
            {
                if (x.Contains(item))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }

            foreach (var item in x)
            {
                if (y.Contains(item))
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }
    }
}
//Dictionary<int, int> xDict = new Dictionary<int, int>() { };
//Dictionary<int, int> yDict = new Dictionary<int, int>() { };

//a.Distinct().ToList().ForEach(x => xDict.Add((int)Math.Pow(x, 2), a.Count(y => y == x)));
//b.Distinct().ToList().ForEach(x => yDict.Add(x, b.Count(y => y == x)));
