using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    public static class CamellCase
    {
        public static string CamelCase(this string str)
        {
            var x = string.Join("", from i in str.Split(new char[] { ' ' })
                                    select i.Length < 2 ? i.ToUpper() : $"{i.Substring(0, 1).ToUpper()}{i.Substring(1)}");

            return x;
            //return string.Join("", (from i in str.Split(new char[] { ' ' }) select (i == str.Split(new char[] { ' ' })[0]) ? i : i[0].ToString().ToUpper() + i.Substring(1)));

        }


    }
}
