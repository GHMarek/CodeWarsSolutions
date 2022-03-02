using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codewars1
{
    class TrailingZeros
    {
        public static int TrailingZeross(int n)
        {
            int res = 1;
            for (int i = 1; i <= n; i++)
            {
                res *= i;
            }

            string resString = res.ToString();

            Regex rgx = new Regex(@"[1-9]+");
            MatchCollection matches = rgx.Matches(resString);

            int u = matches.Last().Index;
            int y = matches.Last().Length-1;

            resString = resString.Substring(matches.Last().Index + matches.Last().Length);

            return resString.Length;

        }
    }
}
