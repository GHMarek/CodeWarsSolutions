using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Backspacee
    {
        public static string CleanString(string s)
        {
            if (s.Replace("#", "").Length == 0)
            {
                return String.Empty;
            }

            if (s.Contains('#'))
            {
                if (s.IndexOf('#') != 0)
                {
                    s = s.Remove(s.IndexOf('#') - 1, 1);
                    s = s.Remove(s.IndexOf('#'), 1);
                }
                else
                {
                    s = s.Remove(s.IndexOf('#'), 1);
                }

                return CleanString(s);
            }
            else
            {
                return s;
            }

        }
    }
}
