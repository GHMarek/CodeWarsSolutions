using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;


namespace codewars1
{
    class ValidPhoneNumber
    {
        public static bool ValiddPhoneNumber(string phoneNumber)
        {
            string pattern = @"([.(][\d][\d][\d][.)][ ][\d][\d][\d][.-][\d][\d][\d][\d])";
            return (Regex.Match(phoneNumber, pattern).Success) && (phoneNumber.Length == 14);

            //return Regex.IsMatch(phoneNumber, @"^\(\d{3}\) \d{3}-\d{4}\z");
        }
    }
}
