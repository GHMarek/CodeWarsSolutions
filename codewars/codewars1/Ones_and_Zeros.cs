using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Ones_and_Zeros
    {
        public static int binaryArrayToNumber(int[] BinaryArray)
        {
            return Convert.ToInt32(string.Join("", BinaryArray));
        }
    }
}
