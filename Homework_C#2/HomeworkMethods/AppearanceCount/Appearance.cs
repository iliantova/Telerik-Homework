//Problem 4. Appearance count

//Write a method that counts how many times given number appears in given array.
//Write a test program to check if the method is workings correctly.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Appearance
    {
        static int CountMethod(int[] arrayCount, int numberCount)
        {
            int count = 0;
            for (int i = 0; i < arrayCount.Length; i++)
            {
                if (arrayCount[i] == numberCount)
                {
                    count++;
                }
            }

            return count;

        }
        static void Main()
        {
            Console.WriteLine("Please, enter array:");
            int[] countArray = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();

            Console.Write("Enter number: ");
            int numberLookfor = int.Parse(Console.ReadLine());

            Console.WriteLine("Given number appears in given array: {0}", CountMethod(countArray,numberLookfor));



        }
    }

