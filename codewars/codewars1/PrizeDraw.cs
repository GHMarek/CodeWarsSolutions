using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class PrizeDraw
    {
        public static string NthRank(string st, int[] we, int n)
        {
            if (st.Length == 0)
            {
                return "No participants";
            }
            if (n > st.Split(",").ToArray().Count())
            {
                return "Not enough participants";
            }

            List<KeyValuePair<string, int>> participantsList = new List<KeyValuePair<string, int>>();

            foreach (var i in st.Split(","))
            {

                int participantScore = 0;
                participantScore += i.Length;

                for (int j = 0; j < i.Length; j++)
                {
                    participantScore += i.ToUpper()[j]-64;

                }

                participantScore = participantScore * we[st.Split(",").ToList().IndexOf(i)];

                participantsList.Add(new KeyValuePair<string, int>(i.ToString(), participantScore));

            }

            participantsList = participantsList.OrderBy(x => x.Key).ThenByDescending(x => x.Value).ToList();

            participantsList = participantsList.OrderBy(x => x.Key).ToList();
            participantsList = participantsList.OrderByDescending(x => x.Value).ToList();


            return participantsList[n-1].Key.ToString();
        }
    }
}
