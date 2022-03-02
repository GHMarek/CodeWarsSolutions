using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class buildTower
    {
        public static string[] TowerBuilder(int nFloors)
        {    
            return (from ints in Enumerable.Range(1, nFloors) select String.Concat(Enumerable.Repeat(" ", ((nFloors * 2 - 1) - (ints * 2 - 1)) / 2)) + String.Concat(Enumerable.Repeat("*", (ints * 2 - 1))) + String.Concat(Enumerable.Repeat(" ", ((nFloors * 2 - 1) - (ints * 2 - 1)) / 2)) + "\n").ToArray();
        }
        
    }
}
