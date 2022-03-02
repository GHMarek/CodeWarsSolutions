using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class DivideStr
    {
        public static string[] DivS(string str)
        {
            string[] strList = Array.Empty<string>();
            int indexPairs = 0;

            if (str.Length % 2 != 0)
            {
                indexPairs = str.Length / 2 + 1;
                str = str + "_";
            }
            else
            {
                indexPairs = str.Length / 2;
            }

            int cnt = 0;
            string tempStr0 = str;
            while (cnt < indexPairs)
            {
                if (cnt == indexPairs-1)
                {
                    Array.Resize(ref strList, strList.Length + 1);
                    strList[strList.Length - 1] = tempStr0;
                }
                else
                {
                    Array.Resize(ref strList, strList.Length + 1);
                    strList[strList.Length - 1] = tempStr0.Substring(0, 2);
                    tempStr0 = tempStr0.Substring(2, tempStr0.Length - 2);
                }

                cnt++;

            }

            return strList;
        }
                      
    }
}
