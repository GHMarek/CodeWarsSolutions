using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class ReplaceWithAlph
    {
        public static string AlphabetPosition(string text)
        {


            return string.Join(" ", (from i in new string(text.ToLower().Where(x => Char.IsLetter(x)).ToArray()) select Convert.ToString((int)i - 96)).ToArray());
        }
    }
}
