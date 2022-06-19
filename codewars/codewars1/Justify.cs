using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class Justify
    {
        public static string JustifySln(string str, int len)
        {
            List<string> wordList = str.Split(" ").ToList();

            StringBuilder resStr = new StringBuilder();

            List<string> helpList = new List<string>();

            string lineStr = "";

            int lineLen = 0;

            if (wordList.Count() == 0)
            {
                return String.Empty;
            }

            for (int i = 0; i < wordList.Count(); i++)
            {

                if (lineStr.Length == 0)
                {
                    lineStr = $@"{lineStr}{wordList[i]}";

                    lineLen += lineStr.Length;

                    helpList.Add(wordList[i]);

                    if (i == wordList.Count - 1)
                    {
                        string lastLine = string.Join(" ", helpList);
                        resStr.Append(lastLine);

                        break;
                    }
                    else
                    {
                        continue;
                    }


                }


                if ((lineStr.Length + helpList.Count + wordList[i].Length + 1) <= len)
                {
                    lineStr = $@"{lineStr}{wordList[i]}";

                    lineLen += lineStr.Length;

                    helpList.Add(wordList[i]);
                }
                else
                {
                    i = i - 1;
                    int spacesCnt = 0;
                    spacesCnt = (len - lineStr.Length);

                    while (spacesCnt != 0)
                    {
                        for (int k = 0; k < helpList.Count - 1; k++)
                        {
                            helpList[k] = $@"{helpList[k]}{(char)32}";
                            if (spacesCnt - 1 >= 0)
                            {
                                spacesCnt--;
                            }
                            else
                            {
                                break;
                            }
                        }
                    }

                    helpList.ForEach(x => resStr.Append(x));
                    resStr.Append("\n");

                    lineStr = "";
                    lineLen = 0;
                    helpList.Clear();

                }

                if (i == wordList.Count - 1)
                {
                    //helpList.Add(wordList[i]);

                    string lastLine = string.Join(" ", helpList);
                    resStr.Append(lastLine);

                    break;
                }

            }


            return resStr.ToString();

        }
    }
}
