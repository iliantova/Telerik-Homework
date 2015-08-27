//Problem 4. Binary search

//Write a program, that reads from the console an array of N integers 
//and an integer K, sorts the array and using the method Array.BinSearch() finds the largest number in the array which is ≤ K.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Binary
{
    static void Main()
    {

        Console.WriteLine("Please, enter number:");
        int K = int.Parse(Console.ReadLine());
        Console.WriteLine("Please, enter number:");
        int N = int.Parse(Console.ReadLine());
        int[] numbersInLine = new int[N];
        for (int i = 0; i < N - 1; i++)
        {
            numbersInLine[i] = int.Parse(Console.ReadLine());
        }

        Array.Sort(numbersInLine);

        int Greater = Array.BinarySearch(numbersInLine, K);

        if (Greater > 0)
        {
            Console.WriteLine("Index is {0} and number is: {1}", Greater, numbersInLine[Greater]);
        }
        else if (Greater < 0)
        {
            Greater = ~Greater;
            if (Greater == 0)
            {
                Console.WriteLine("No number");
            }

            else
            {
                Console.WriteLine("Index is {0} and number is: {1}", Greater - 1, numbersInLine[Greater - 1]);

            }
        }
    }
}

