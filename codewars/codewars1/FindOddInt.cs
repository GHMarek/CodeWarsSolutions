using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class FindOddInt
    {
        public static int find_it(int[] seq)
        {
            Dictionary<int, int> myDickt = new Dictionary<int, int>();
            foreach (var i in seq.Distinct().ToArray())
            {
                myDickt.Add(i, seq.Count(x => x == i));
            }

            return myDickt.FirstOrDefault(x => x.Value == myDickt.Values.Where(x => !(x % 2 == 0)).Max()).Key;
        }
    }
}
