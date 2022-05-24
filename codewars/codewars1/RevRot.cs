using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class RevRott
    {
        public static string RevRot(string strng, int sz)
        {
            if(sz == 0) { return String.Empty; }
            if(sz > strng.Length) { return String.Empty; }

            strng = strng.Substring(0, strng.Length - (strng.Length % sz));

            StringBuilder resString = new StringBuilder();
            
            for (int c = 0; c < strng.Length; c += sz)
            {
                char[] sStr = new char[strng.Length];

                int sumOfsquares = 0;
                if (c == 0)
                {
                    sStr = strng.Substring(c, sz).ToCharArray();
                }
                else
                {
                    sStr = strng.Substring(c, sz).ToCharArray();
                }

                sStr.ToList().ForEach(x => sumOfsquares += Convert.ToInt32(Math.Pow(x, 2)));
                
                if (sumOfsquares % 2 == 0)
                {
                    Array.Reverse(sStr);
                    sStr.ToList().ForEach(x => resString.Append(x.ToString()));
                }
                else
                {
                    for (int i = 1; i < sStr.Length; i++)
                    {
                        resString.Append(sStr[i]);
                    }

                    resString.Append(sStr[0]);
                }

            }

            return resString.ToString();
        }
    }
}
