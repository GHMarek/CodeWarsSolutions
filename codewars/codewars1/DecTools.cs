using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    public class DecTools
    {
        public static int Digits(ulong n)
        {
            return (from chars in n.ToString() select chars).ToList().Count();
        }
    }
}
