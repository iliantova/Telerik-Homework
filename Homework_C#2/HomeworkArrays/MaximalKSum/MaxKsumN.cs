//Problem 6. Maximal K sum

//Write a program that reads two integer numbers N and K and an array of N elements from the console.
//Find in the array those K elements that have maximal sum.

using System;
using System.Linq;
using System.Collections.Generic;


    class MaxKsumN
    {
        static void Main()
        {

            Console.WriteLine("Pleas, enter the number of elements in the array:");
            int N = int.Parse(Console.ReadLine());

            Console.WriteLine("Pleas, enter numbers:");
            int K = int.Parse(Console.ReadLine());

            
            int[] ArrayMAx = new int[N];

            if (K>N)
            {
                Console.WriteLine("Invalid value numer of array should be a large number of number for sum");
            }

            else {
                Console.WriteLine("Please enter an array:"); 
            for (int i = 0; i < N; i++)
            {
                ArrayMAx[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(ArrayMAx);

            Console.WriteLine("Numbers are:");
           
                for (int j = 0; j < K; j++)
                {

                  
                    Console.Write("{0}, ",  ArrayMAx[N - 1 - j]);

                }
                Console.WriteLine();
            }
            }
    }

