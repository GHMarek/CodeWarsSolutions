using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace codewars1
{
    class SudokuValidation
    {
        public static bool ValidateSolution(int[][] board)
        {
                      
            int[] corrArr = new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            bool answer = false;

            foreach (var i in board)
            {
                if (i.Contains(0))
                {
                    return false;
                }

                foreach (var j in corrArr)
                {
                    if (i.Contains(j))
                    {
                        answer = true;
                    }
                    else
                    {
                        return false;
                    }
                }
                Console.WriteLine(i);
            }



            for (int k = 0; k < 9; k++)
            {
                List<int> tempList = new List<int> { };
                for (int l = 0; l < 9; l++)
                {
                    tempList.Add(board[l][k]);

                    if ((k + 3) % 3 == 0 && (l + 3) % 3 == 0)
                    {
                        bool[] sqr = new bool[10];
                        for (int m = k; m < k + 3; m++)
                        {
                            for (int n = l; n < l + 3; n++)
                            {
                                if (sqr[board[m][n]] & board[m][n] > 0)
                                {
                                    return false;
                                }
                                sqr[board[m][n]] = true;
                            }
                        }
                    }

                }

                tempList.Sort();
                if (tempList.SequenceEqual(corrArr))
                {
                    answer = true;
                }
                else
                {
                    return false;
                }

            }

            return answer;
        }
    }
}
