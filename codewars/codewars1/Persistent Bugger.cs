using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Persistent_Bugger
    {
        public static int computeNewLong (long n)
        {
            int valuesNew = Int32.Parse((from i in n.ToString() select i.ToString()).ToArray()[0]);

            try
            {
                foreach (var i in n.ToString().Skip(1).ToArray())
                {
                    valuesNew *= Int32.Parse(i.ToString());
                }
            }
            catch
            {
                valuesNew *= 1;
            }

            return valuesNew;
        }
        public static int Persistence(long n)
        {
            int persisteNce = 0;

            while (true)
            {

                if (n.ToString().Length == 1)
                {
                    break;
                }
                else
                {
                    persisteNce += 1;
                    n = computeNewLong(n);
                }
            }

            return persisteNce;

        }
    }
}
    