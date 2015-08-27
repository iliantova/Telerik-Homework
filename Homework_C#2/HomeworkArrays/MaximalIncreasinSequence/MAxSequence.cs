//Problem 5. Maximal increasing sequence

//Write a program that finds the maximal increasing sequence in an array.
//Example:

//input	                           result
//3, 2, 3, 4, 2, 2, 4	              2, 3, 4



using System;
using System.Linq;
using System.Collections.Generic;


class MAxSequence
{
    static void Main()
    {

        Console.Write("Please enter numbers separated by a space: ");


        char[] numbersInLine = Console.ReadLine()
                .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => char.Parse(x)).ToArray();

        string longestSequence = "" + numbersInLine[0];
        string tempSequence = "" + numbersInLine[0];
        for (int i = 0; i < numbersInLine.Length - 1; i++)
        {

            if (numbersInLine[i]  < numbersInLine[i + 1])
            {

                tempSequence = tempSequence + ", " + numbersInLine[i + 1];

            }
            else
            {
                if (longestSequence.Length < tempSequence.Length)
                {
                    longestSequence = tempSequence;
                }
                tempSequence = "" + numbersInLine[i + 1];
            }
        }
        Console.WriteLine(longestSequence);
    }

}