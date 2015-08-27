//Problem 14. Quick sort

//Write a program that sorts an array of integers using the Quick sort algorithm.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class QuickSortAlgorithm
    {
        static void Main()
        {
            Console.WriteLine("Please, enter array:");
            int[] quckArray = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();

            Quicksort(quckArray, 0, quckArray.Length - 1);

            for (int i = 0; i < quckArray.Length; i++)
            {
                Console.Write(quckArray[i] + " ");
            }

            Console.WriteLine();

            }

        public static void Quicksort(int[] elements, int left, int right)
        {
            int i = left, j = right;
            int pivot = elements[(left + right) / 2];

            while (i <= j)
            {
                while (elements[i] < pivot)
                {
                    i++;
                }

                while (elements[j] > pivot)
                {
                    j--;
                }

                if (i <= j)
                {
                   
                    int tmp = elements[i];
                    elements[i] = elements[j];
                    elements[j] = tmp;

                    i++;
                    j--;
                }
            }

           
            if (left < j)
            {
                Quicksort(elements, left, j);
            }

            if (i < right)
            {
                Quicksort(elements, i, right);
            }
        }
    }

