using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class ConsecutiveStrings
    {
        public static string LongestConsec(string[] strarr, int k)
        {
            if ((strarr.Count() == 0) || (k > strarr.Count())) { return ""; }

            Dictionary<string, int> resDict = new Dictionary<string, int>() { };

            for (int i = 0; i < strarr.Count(); i++)
            {
                if (strarr.Length - i >= k)
                {
                    if (resDict.ContainsKey(String.Join("", strarr.Skip(i).Take(k)))) { continue; }

                    resDict.Add(String.Join("",strarr.Skip(i).Take(k)), String.Join("", strarr.Skip(i).Take(k)).Length);
                }
                else
                {
                    break;
                }

            }

            return resDict.FirstOrDefault(x => x.Value == resDict.Values.Max()).Key;
        }
    }
}
