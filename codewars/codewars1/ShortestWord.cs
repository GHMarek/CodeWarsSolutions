using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class ShortestWord
    {
        public static int FindShort(string s)
        {
            Console.WriteLine((from w in s.Split(" ").ToArray() select w.Length).ToArray().Min().ToString());
            // dziala, ale powinno byc
            // return s.Split(' ').Min(x => x.Length);
            return 0;
        }
    }
}
