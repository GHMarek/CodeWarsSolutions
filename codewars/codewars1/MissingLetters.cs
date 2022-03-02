using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class MissingLetters
    {
        public static char FindMissingLetter(char[] array)
        {
            int prevItem = 0;
            int cnt = 0;
            foreach (var item in array)
            {
                if (cnt == 0)
                {
                    prevItem = (int)item;
                    cnt++;
                }
                else
                {
                    if (((int)item - (int)prevItem) == 1)
                    {
                        prevItem = (int)item;
                        cnt++;
                    }
                    else
                    {
                        return (char)((int)item-1);

                    }
                }

            }
            return ' ';
        }
    }
}
