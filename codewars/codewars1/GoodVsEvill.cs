using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class GoodVsEvill
    {
        public static string GoodVsEvil(string good, string evil)
        {

            List<int> gdList = new List<int>() { 1, 2, 3, 3, 4, 10};
            List<int> evList = new List<int>() { 1, 2, 2, 2, 3, 5, 10 };

            int gdScore = 0;
            int evScore = 0;

            for (int i = 0; i < evList.Count; i++)
            {
                if (i < gdList.Count)
                {
                    gdScore += gdList[i] * Convert.ToInt32(Convert.ToString(good.Split(" ").ToList()[i]));
                    evScore += evList[i] * Convert.ToInt32(Convert.ToString(evil.Split(" ").ToList()[i]));
                }
                else
                {
                    evScore += evList[i] * Convert.ToInt32(Convert.ToString(evil.Split(" ").ToList()[i]));
                }
            }


            if (gdScore == evScore)
            {
                return "Battle Result: No victor on this battle field";
            }
            else
            {
                if (gdScore > evScore)
                {
                    return "Battle Result: Good triumphs over Evil";
                }
                else
                {
                    return "Battle Result: Evil eradicates all trace of Good";
                }
            }

        }
    }
}
