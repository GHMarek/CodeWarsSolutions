using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class PhoneNumberStr
    {
        public static string CreatePhoneNumber(int[] numbers)
        {         

            return String.Join("", numbers)
                .Insert(0, "(")
                .Insert(4, ")")
                .Insert(5, " ")
                .Insert(9, "-");
        }
    }
}
