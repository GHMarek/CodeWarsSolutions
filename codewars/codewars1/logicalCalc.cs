using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class logicalCalc
    {
        public static bool LogicalCalc(bool[] array, string op)
        {
            bool test = array[0];
            foreach (var e in array.Skip(1).Take(array.Length-1).ToArray())
            {
                if (op == "AND")
                {
                    test = test & e;
                }
                else if (op == "OR")
                {
                    test = test | e;
                }
                else if (op == "XOR")
                {
                    test = test ^ e;
                }
            }

            return test;
        }
    }
}
