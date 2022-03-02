using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class HumanTimeFormat
    {
        public static string formatDuration(int seconds)
        {
            TimeSpan tS = TimeSpan.FromSeconds(seconds);
            StringBuilder strB = new StringBuilder();
            List<string> strList = new List<string>() { };
            if (tS.Days >= 365)
            {
                int y = tS.Days / 365;

                if (y == 1)
                {
                    strList.Add(string.Format(@"{0} year", y));
                }
                else
                {
                    strList.Add(string.Format(@"{0} years", y));
                }
            }

            if (tS.Days > 0)
            {
                if (tS.Days == 1)
                {
                    strList.Add(string.Format(@"{0} day", tS.Days));
                }
                else if ((tS.Days / 365) >= 1)
                {
                    strList.Add(string.Format(@"{0} days", tS.Days - ((tS.Days / 365) * 365)));
                }
                else
                {
                    strList.Add(string.Format(@"{0} days", tS.Days));
                }
            }

            if (tS.Hours > 0)
            {
                if (tS.Hours == 1)
                {
                    strList.Add(string.Format(@"{0} hour", tS.Hours));
                }
                else
                {
                    strList.Add(string.Format(@"{0} hours", tS.Hours));
                }
            }

            if (tS.Minutes > 0)
            {
                if (tS.Minutes == 1)
                {
                    strList.Add(string.Format(@"{0} minute", tS.Minutes));
                }
                else
                {
                    strList.Add(string.Format(@"{0} minutes", tS.Minutes));
                }
            }

            if (tS.Seconds > 0)
            {
                if (tS.Seconds == 1)
                {
                    strList.Add(string.Format(@"{0} second", tS.Seconds));
                }
                else
                {
                    strList.Add(string.Format(@"{0} seconds", tS.Seconds));
                }
            }

            string answer = string.Join(", ", strList);
            if (strList.Count() == 0)
            {
                answer = "now";
            }
            else if (strList.Count() == 1)
            {
                return answer;
            }
            else
            {
                answer = answer.Substring(0, answer.LastIndexOf(',')) + " and" + answer.Substring(answer.LastIndexOf(',') + 1);
            }

            return answer;
        }
    }
}
