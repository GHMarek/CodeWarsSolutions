using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class greedIsGood
    {
        public static int Score(int[] dice)
        {

            int score = 0;
            int[] intArr = new int[3];



            for (int i = 1; i <= dice.Length+1; i++)
            {
                System.Diagnostics.Debug.WriteLine(i);
                System.Diagnostics.Debug.WriteLine((dice.Count(i => i != 0) >= 3));

                if (dice.Count(e => e == i) >= 3)
                {
                    switch (i)
                    {
                        case 1:
                            score += 1000;
                            dice = removeDice(dice, i);
                            break;
                        case 2:
                            score += 200;
                            dice = removeDice(dice, i);
                            break;
                        case 3:
                            score += 300;
                            dice = removeDice(dice, i);
                            break;
                        case 4:
                            score += 400;
                            dice = removeDice(dice, i);
                            break;
                        case 5:
                            score += 500;
                            dice = removeDice(dice, i);
                            break;
                        case 6:
                            score += 600;
                            dice = removeDice(dice, i);
                            break;
                        default:
                            break;
                    }

                }
            }

            foreach (var item in dice)
            {
                if (item == 1)
                {
                    score += 100;
                }
                else if (item == 5)
                {
                    score += 50;
                }
                else
                {
                    continue;
                }
            }

            static int[] removeDice(int[] intL1, int intScored)
            {
                List<int> intList = new();
                int cntInt = 0;

                foreach (var item in intL1)
                {
                    if ((item == intScored) && (cntInt < 3))
                    {
                        cntInt++;
                    }
                    else if (item != intScored)
                    {
                        intList.Add(item);
                    }
                    else if ((item == intScored) && (cntInt == 3))
                    {
                        intList.Add(item);
                    }
                }

                foreach (var item in intList)
                {
                    Console.WriteLine("intList: ");
                    Console.WriteLine(item.ToString());
                }

                return intList.ToArray();


            }

            return score;
        }
    }
}
