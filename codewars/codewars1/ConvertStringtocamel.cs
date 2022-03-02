using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class ConvertStringtocamel
    {
        public static string ToCamelCase(string str)
        {

            return string.Join("", (from i in str.Split(new char[] { '_', '-' }) select (i == str.Split(new char[] { '_', '-' })[0]) ? i : i[0].ToString().ToUpper() + i.Substring(1)));
        }
    }
}
