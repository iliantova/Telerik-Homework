//Problem 11. Binary search

//Write a program that finds the index of given element in a sorted array of integers by using the Binary search algorithm.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class BinarySearchAlgorithm
    {
        static void Main()
        {
            Console.WriteLine("Please, enter array:");
            int[] binArray = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Please, enter number:");
            int K = int.Parse(Console.ReadLine());


            Array.Sort(binArray);

            int indMIddle =binArray.Length / 2;

            int imin = 0;
            int imax = binArray.Length;

            for (int i = imin; i < imax; i++)
            {
                if (binArray[indMIddle] < K)
                {
                    imin = indMIddle + 1;
                }

                else
                {
                    imax = indMIddle;
                }

                if (binArray[i] == K)
                {
                    Console.WriteLine("Index in array {0}",i);
                }
               
            }      

        }
    }

