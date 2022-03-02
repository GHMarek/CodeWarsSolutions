using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class WeightForWeight
    {
        public static string orderWeight(string strng)
        {
            //"56 65 74 100 99 68 86 180 90"

            List<string> yList = strng.Split(" ").ToList();

            List<int> xList = new List<int>() { };

            foreach (var i in yList)
            {
                int sumDig = 0;
                foreach (var j in i.ToArray())
                {
                    sumDig += Convert.ToInt32(j.ToString());
                }

                xList.Add(sumDig);
            }

            List<KeyValuePair<string, int>> xyList = new List<KeyValuePair<string, int>>() { };

            for (int i = 0; i < yList.Count; i++)
            {
                xyList.Add(new KeyValuePair<string, int>(yList[i], xList[i]));
            }

            xyList = xyList.OrderBy(x => x.Key).OrderBy(x => x.Value).ToList();
            string res = String.Empty;

            foreach (var item in xyList)
            {
                res += $"{item.Key.ToString()} ";
            }

            return res.Remove(res.Length - 1, 1);

        }
    }
}
