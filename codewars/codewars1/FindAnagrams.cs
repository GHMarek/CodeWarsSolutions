using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class FindAnagrams
    {
        public static List<string> Anagrams(string word, List<string> words)
        {

            List<string> answerList = new();
            Dictionary<char, int> wordDict = new Dictionary<char, int>();

            foreach (var i in word.ToArray().Distinct())
            {
                wordDict.Add(Convert.ToChar(i), word.ToArray().Count(x => x == i));
            }

            foreach (var j in words)
            {
                Dictionary<char, int> resDict = new Dictionary<char, int>();

                foreach (var k in j.ToArray().Distinct())
                {
                    resDict.Add(Convert.ToChar(k), word.ToArray().Count(x => x == k));
                }

                if(resDict.Values == wordDict.Values)
                {
                    answerList.Add(j);
                }

            }

            foreach (var item in answerList)
            {
                Console.WriteLine(item);
            }
            return answerList;
        }
    }
}
