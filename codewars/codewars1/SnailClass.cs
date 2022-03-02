using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class SnailClass
    {
        public static int[] Snail(int[][] array)
        {

            if (array.Count() == 1) { return array[0]; }
            if (array.Count() == 0) { return new int[] { }; }

            List<int> resList = new List<int> { };

            int lastRow = array.Count()-1;
            int lastColumn = array.Length-1;

            int i, k = 0, l = 0;

            while (k <= lastRow && l <= lastColumn)
            {
                for(i = l; i <= lastColumn; i++)
                {
                    resList.Add(array[k][i]);
                }

                k++;

                for (i = k; i <= lastRow; i++)
                {
                    resList.Add(array[i][lastColumn]);
                }

                lastColumn--;

                if (k <= lastRow)
                {
                    for (i = lastColumn; i >= l; i--)
                    {
                        resList.Add(array[lastRow][i]);
                    }
                    lastRow--;
                }

                if (l <= lastColumn)
                {
                    for (i = lastRow; i >= k; i--)
                    {
                        resList.Add(array[i][l]);
                    }
                    l++;
                }

            }

            return resList.ToArray();
        }
    }
}
