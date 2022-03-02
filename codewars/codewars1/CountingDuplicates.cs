using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codewars1
{
    class CountingDuplicates
    {
        public static int DuplicateCount(string str)
        {
            int cnter = 0;
            string str1 = str.ToLower();
            
            foreach (var item in str1.Distinct().ToArray())
            {

                if (str1.Count(x => x == item) > 1) 
                {
                    cnter += 1;
                }
                else
                {
                    continue;
                }
            }
            return cnter;
        }
    }
}
