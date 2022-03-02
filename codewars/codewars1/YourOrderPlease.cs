using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class YourOrderPlease
    {
        public static string Order(string words)
        {
            if (words.Length == 0)
            {
                return "";
            }
            else
            {
                Dictionary<int, string> wordsDict = new Dictionary<int, string>();

                foreach (string i in words.Split(" "))
                {
                    wordsDict.Add(i.Where(Char.IsDigit).ToArray()[0], i);
                }

                return string.Join(" ", wordsDict.OrderBy(x => x.Key).Select(x => x.Value).ToArray());
            }

        }
    }
}
