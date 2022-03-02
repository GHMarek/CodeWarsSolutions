using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace codewars1
{
    class CountTheSmileyFaces
    {
        public static int CountSmileys(string[] smileys)
        {
            
            return (from i in smileys select Regex.Match(i, @"^[:;]{1}[~-]{0,1}[\)D]{1}$").Success).ToArray().Count(x => x == true);
        }
    }
}
