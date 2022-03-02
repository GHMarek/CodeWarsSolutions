using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class HighestScoreWord
    {
        public static string High(string s)
        {
            Dictionary<string, int> resDict = new Dictionary<string, int>() { };

            foreach (var i in s.Split(" ").Distinct().ToArray())
            {
                resDict.Add(i, i.ToArray().Select(x => (int)x % 32).Sum());

            }

            return resDict.FirstOrDefault(x => x.Value == resDict.Values.Max()).Key;
        }
    }
}
