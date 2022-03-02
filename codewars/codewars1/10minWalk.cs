using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class _10minWalk
    {
        public static bool IsValidWalk(string[] walk)
        {
            return (walk.Count() == 10) && (walk.Count(x => x == "n") == walk.Count(x => x == "s")) && (walk.Count(x => x == "w") == walk.Count(x => x == "e"));
        }
    }
}
