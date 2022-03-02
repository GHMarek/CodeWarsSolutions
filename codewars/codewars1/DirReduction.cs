using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class DirReduction
    {
        public static string[] dirReduc(String[] arr)
        {

            List<string> lArr = arr.ToList();
            Dictionary<string, string> oppositesDict = new Dictionary<string, string> { { "NORTH", "SOUTH" }, { "SOUTH", "NORTH"}, {"EAST", "WEST"}, {"WEST", "EAST"} };

            for (int i = 0; i < lArr.Count(); i++)
            {
                if (i == lArr.Count()-1)
                {
                    continue;
                }


                if (lArr[i + 1] == oppositesDict[lArr[i]])
                {

                    lArr.RemoveAt(i + 1);
                    lArr.RemoveAt(i);
                    return dirReduc(lArr.ToArray());
                }

            }

            return lArr.ToArray();

        }

    }
}
