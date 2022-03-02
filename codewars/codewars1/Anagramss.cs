using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.RegularExpressions;

namespace codewars1
{
    class Anagramss
    {
        public static List<string> Anagrams(string word, List<string> words)
        {
            List<string> resultList = new List<string>();
            Dictionary<char, int> wordDict = new Dictionary<char, int>();

            foreach (var i in word.Distinct())
            {
                wordDict.Add(i, Regex.Matches(word, i.ToString()).Count);
            }

            foreach (var j in words)
            {
                Dictionary<char, int> tempDict = new Dictionary<char, int>();

                foreach (var k in j.Distinct())
                {
                    tempDict.Add(k, Regex.Matches(j, k.ToString()).Count);
                }


                //
                if (wordDict.Except(tempDict).Any() || tempDict.Except(wordDict).Any())
                {
                    continue;
                }
                else
                {
                    foreach (var y in wordDict.Keys.ToArray())
                    {
                        if (wordDict[y] == tempDict[y])
                        {
                            if (y == wordDict.Keys.ToArray().Last())
                            {
                                resultList.Add(j);
                            }

                            continue;
                        }
                    }
                }

                //
            }

            foreach (var x in resultList)
            {
                Console.WriteLine(x.ToString());
            }

            return resultList;
        }
    }
}
