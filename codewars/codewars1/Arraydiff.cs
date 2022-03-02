using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Arraydiff
    {
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            // Your brilliant solution goes here
            // It's possible to pass random tests in about a second ;)

            //Array.ForEach(b, b => Console.WriteLine(a.Contains(b).Equals(false)) );

            foreach (var i in b)
            {
                a = a.Where(x => x != i).ToArray();
            }

            return a;
        }
    }
}
