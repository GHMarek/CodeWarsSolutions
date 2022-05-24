using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Count_characters_in_your_string
    {
        public static Dictionary<char, int> Count(string str)
        {
            Dictionary<char, int> myDict = new Dictionary<char, int>() { };

            str.ToCharArray().Distinct().Select(x => x.ToString()).ToList()
                .ForEach(x => myDict.Add(Convert.ToChar(x), str.Count(y => y.ToString() == x)));

            return myDict;
        }

        //public static Dictionary<char, int> Count(string str)
        //{
        //    return str.GroupBy(c => c).ToDictionary(g => g.Key, g => g.Count());
        //}

    }
}
