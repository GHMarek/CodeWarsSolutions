﻿using System;
using System.Linq;
using System.Collections.Generic;

namespace codewars1
{
    class Program
    {
        static void Main(string[] args)
        {

            //Console.WriteLine(AreTheySame.comp(new int[] { 121, 16, 144, 19, 161, 19, 144, 19, 11, 16, 5 },
            //                                    new int[] { 121, 14641, 20736, 361, 25921, 361, 20736, 361, 16*16, 16*16, 36}));
            //Console.WriteLine(Math.Pow(2, 31));
            //Console.WriteLine(Isnumber_prime.IsPrime(5099));
            //Console.WriteLine(Multiples_of_3_or_5.Solution(10));
            //Console.WriteLine(ConsecutiveStrings.LongestConsec(new string[] { "zone", "abigail", "theta", "zone", "abigail", "theta" }, 2));
            //Console.WriteLine(HighestScoreWord.High("what time are are we climbing up to the volcano"));
            //Console.WriteLine(PlayingWithDigits.digPow(46288, 3));
            //Console.WriteLine(PhoneNumberStr.CreatePhoneNumber(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 0 }));
            //Console.WriteLine(TrailingZeros.TrailingZeross(531));
            //Console.WriteLine(WeightForWeight.orderWeight("11 11 2000 10003 22 123 1234000 44444444 9999"));
            //Console.WriteLine(FIrstNoRepeating.FirstNonRepeatingLetter("sTreSS"));
            //Anagramss.Anagrams("racer", new List<string> { "carer", "arcre", "racrs", "racers", "arceer", "raccer", "carrer", "cerarr", "carre" });
            //{"carer", "arcre", "carre"}
            //DirReduction.dirReduc(new string[] { "NORTH", "SOUTH", "SOUTH", "EAST", "WEST", "NORTH", "WEST" });
            //Console.WriteLine(FindAnagrams.Anagrams("racer", new List<string> {"crazer", "carer", "racar", "caers", "racer"}));
            //Console.WriteLine(MoveZeros.MoveZeroes(new int[] { 1, 2, 0, 1, 0, 1, 0, 3, 0, 1 }));
            //var puzzle = new ((int, int), (int, int), int)[]{
            //                                    ((-1,5),(-1,-1),3),
            //                                    ((17,-1),(-1,-1),9),
            //                                    ((-1,4),(-1,5),8),
            //                                    ((4,11),(5,17),5),
            //                                    ((11,-1),(17,-1),2),
            //                                    ((-1,-1),(-1,4),7),
            //                                    ((5,17),(-1,-1),1),
            //                                    ((-1,-1),(11,-1),4),
            //                                    ((-1,-1),(4,11),6),
            //                                };
            //Console.WriteLine(nieskończoneSolvingPuzzle.PuzzleSolver(puzzle, 3, 3));
            //Console.WriteLine(Next_bigger_number_with_the_same_digits.NextBiggerNumber(17823642196));
            //Console.WriteLine(SudokuValidation.ValidateSolution(new int[][] {new int[] {1, 2, 3, 4, 5, 6, 7, 8, 9},
            //                                                                new int[] {2, 3, 1, 5, 6, 4, 8, 9, 7},
            //                                                                new int[] {3, 1, 2, 6, 4, 5, 9, 7, 8},
            //                                                                new int[] {4, 5, 6, 7, 8, 9, 1, 2, 3},
            //                                                                new int[] {5, 6, 4, 8, 9, 7, 2, 3, 1},
            //                                                                new int[] {6, 4, 5, 9, 7, 8, 3, 1, 2},
            //                                                                new int[] {7, 8, 9, 1, 2, 3, 4, 5, 6},
            //                                                                new int[] {8, 9, 7, 2, 3, 1, 5, 6, 4},
            //                                                                new int[] {9, 7, 8, 3, 1, 2, 6, 4, 5},
            //                                                            }));
            //Console.WriteLine(HumanTimeFormat.formatDuration(33243586));
            //// snail
            //int[][] array =
            //{
            //   new []{1, 2, 3},
            //   new []{4, 5, 6},
            //   new []{7, 8, 9}
            //};

            //Console.WriteLine(SnailClass.Snail(array));
            //Console.WriteLine(SimplePigLatin.PigIt("Pig latin is cool"));
            //Console.WriteLine(SortTheOdd.SortArray(new int[] { 9, 8, 7, 6, 5, 4, 3, 2, 1, 0 }));
            //Console.WriteLine(FindTheUniqueInt.GetUnique(new int[] { 1, 1, 1, 2, 1, 1 }));
            //Console.WriteLine(CountTheSmileyFaces.CountSmileys(new string[] { ";]", ":[", ";*", ":)", ";-D" }));
            //Console.WriteLine(DeleteNoccurrences.DeleteNth(new int[] { 1, 1, 3, 3, 7, 2, 2, 2, 2 }, 3));
            //Console.WriteLine(MissingLetters.FindMissingLetter(new char[] { "a", "b", "c", "d", "f" }));
            //Console.WriteLine(Pangram.IsPangram("The quick brown fox jumps over the lazy dog.")) ;
            //Console.WriteLine(ConvertStringtocamel.ToCamelCase("wvjftjuqre_icbmpddfnn-lkumqkdcgy"));
            //IEnumerable<int> newIter = new int[] { 1, 2, 3, 2, 2, 3, 3 }
            //Console.WriteLine(UniqueinOrder.UniqueInOrder(new string[] { "AAAABBBCCDAABBB" }));
            //Console.WriteLine(DecodetheMorsecode.Decode(".... . -.--   .--- ..- -.. ."));
            //Console.WriteLine(YourOrderPlease.Order(""));
            //Console.WriteLine(ReplaceWithAlph.AlphabetPosition("The sunset sets at twelve o" clock."));
            //Console.WriteLine(Persistent_Bugger.Persistence(999));
            //Console.WriteLine(DuplicateEncoder.DuplicateEncode("aabBcde"));

            //Console.WriteLine(CountingDuplicates.DuplicateCount("aabBcde"));
            //Console.WriteLine(FindParity.Find(new int[] {2, 4, 0, 100, 4, 11, 2602, 36}));

            //Console.WriteLine(WhoLikes.Likes(new string[] { "Alex", "Jacob", "Mark", "Max" }));

            //Console.WriteLine(BitCounting.CountBits(1234));
            //int[] valArr = new int[] { 1, 2, 2, 2, 3 };

            //foreach (var item in Arraydiff.ArrayDiff(valArr, new int[] { 1, 3 }).ToArray())
            //{
            //    Console.WriteLine(item);

            //}

            //int[] valArr = new int[] { 1, 1, 2 };
            //Console.WriteLine(FindOddInt.find_it(valArr));
            //Console.WriteLine(HighestAndLowest.HighAndLow("1 9 3 4 -5"));
            //Console.WriteLine(SquareEveryDigit.SquareDigits(999));
            //Console.WriteLine(VowelCount.GetVowelCount("dfdfjnhukshyfeybfyebc ef e few fsdfsdgi ooijmda"));
            //Console.WriteLine(maxMultiply.MaxMultiply(10, 50));

            //Console.WriteLine(DecTools.Digits(6667).ToString());

            // kata 9
            // shortest words

            //string str = "bitcoin take over the world maybe who knows perhaps";
            //ShortestWord.FindShort(str);
            //Console.WriteLine(ShortestWord.FindShort(str));

            // kata 8
            // binary translator

            //int[] ints = {0, 0, 0, 1};

            //Ones_and_Zeros.binaryArrayToNumber(ints);
            // kata 7
            // gra w kosci
            //Random rnd = new Random();
            ////int[] dice = (from i in Enumerable.Range(0,5) select rnd.Next(1,6)).ToArray();
            //int[] dice = new int[] { 5, 5, 5, 5, 1};
            //foreach (var item in dice)
            //{
            //    Console.WriteLine(item.ToString());
            //}
            //Console.WriteLine(dice);
            //Console.WriteLine(greedIsGood.Score(dice)); 

            // kata 6
            // build tower n^floors

            //foreach (var item in buildTower.TowerBuilder(5))
            //{
            //    Console.WriteLine(item);
            //}


            // kata 5
            // usuwa najmniejsza liczbe z listy i zwraca taka sama liste

            //List<int> intList = new List<int> { 3, 4, 1, 5, 7, 8, 1, 1};
            //List<int> newList2 = museumDullThings.RemoveSmallest(intList);
            //foreach (var myInt in newList2) 
            //{
            //    Console.WriteLine(myInt);
            //}

            //foreach (var myInt in intList)
            //{
            //    Console.WriteLine(myInt);
            //}

            //kata 4, 10 min walk
            //sprawdza, czy spacer wedlug podanych wskazowek trwa 10 min (10 krokow)
            //string[] str = { "n", "s", "n", "s", "n", "s", "n", "s", "n", "s" };

            //Console.WriteLine(_10minWalk.IsValidWalk(str) ? "true" : "false");


            // kata 3, isogram
            // sprawdz, czy wyraz ma jedynie unikalne litery

            //if (isogram.IsIsogram("moOse") == true) 
            //{
            //    Console.WriteLine("true");
            //}
            //else
            //{
            //    Console.WriteLine("false");
            //}


            // kata 2, logical calculator

            //bool[] array = { true, true, true, false };
            //string op = "XOR";

            //foreach (bool b in array)
            //{
            //    Console.WriteLine(b);
            //}

            //Console.WriteLine(op);

            //Console.WriteLine(logicalCalc.LogicalCalc(array, op));

            // kata 1, divstr
            //Console.WriteLine("Hello World!");
            //string[] temp = DivideStr.DivS("wozu");

            //foreach (var i in temp)
            //{
            //    Console.WriteLine(i);
            //}

            //Console.WriteLine(temp.Length);

        }
    }
}
