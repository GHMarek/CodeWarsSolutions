using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Next_bigger_number_with_the_same_digits
    {

        public static long NextBiggerNumber(long n)
        {

            List<string> newList = new List<string> { };
            List<long> resList = new List<long> { };
            var input = n.ToString();

            try
            {
                return Int64.Parse(FindPermutations(input).Where(x => Int64.Parse(x) > n).OrderBy(x => x).First());
            }
            catch
            {

                return -1;
            }

            static IEnumerable<string> FindPermutations(string set)
            {
                var output = new List<string>();

                switch (set.Length)
                {
                    case 1:
                        output.Add(set);
                        break;
                    default:
                        output.AddRange(from c in set let tail = set.Remove(set.IndexOf(c), 1) from tailPerms in FindPermutations(tail) select c + tailPerms);
                        break;
                }

                return output;
            }
        }
    }
}
