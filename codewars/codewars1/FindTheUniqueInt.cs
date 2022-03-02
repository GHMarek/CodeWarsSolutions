using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class FindTheUniqueInt
    {
        public static int GetUnique(IEnumerable<int> numbers)
        {
            foreach (var item in numbers.Distinct().ToArray())
            {
                if (numbers.Count(x => x == item) == 1)
                {
                    return item;
                }
            }
            return 0;
        }
    }
}
