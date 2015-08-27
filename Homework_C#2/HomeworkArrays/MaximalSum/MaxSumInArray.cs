//Problem 8. Maximal sum

//Write a program that finds the sequence of maximal sum in given array.
//Example:

//input	result
//2, 3, -6, -1, 2, -1, 6, 4, -8, 8	2, -1, 6, 4
//Can you do it with only one loop (with single scan through the elements of the array)?

using System;
using System.Collections.Generic;
using System.Linq;


    class MaxSumInArray
    {
        static void Main()
        {
            Console.WriteLine("Please, enter array:");
            int[] numbersInLine = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();

            int currentSum = numbersInLine[0];
            int bestSum = numbersInLine[0];
           
           int startIndex = 0;
           int endIndex = 0;
           int CurrentStartIndex = 0;

            for (int j = 0; j < numbersInLine.Length-1; j++)
            {

                currentSum += numbersInLine[j];

               if (currentSum > bestSum)
                {
                    bestSum = currentSum;
                    startIndex = CurrentStartIndex;
                    endIndex = j;

                
                }

                if (currentSum <= 0)
                {
                    currentSum = 0;
                    CurrentStartIndex = j + 1;

                }

                

            }


            for (int i = startIndex; i <= endIndex; i++)
            {
                Console.WriteLine("The sequence of maximal sum:");
                Console.Write("{0}, ", numbersInLine[i]);

            }

            Console.WriteLine();
        }
    }

