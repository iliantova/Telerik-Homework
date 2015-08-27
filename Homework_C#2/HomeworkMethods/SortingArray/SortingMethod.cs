//Problem 9. Sorting array
// Write a method that return the maximal element in a portion of array of integers 
// starting at given index.
// Using it write another method that sorts an array in ascending / descending order. 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SortingMethod
    {
        public static int MaxInSubArray(int[] Arr, int StartIndex, int NumberOfElements)
        {

            int MaxResult = Arr[StartIndex];
            if (StartIndex + NumberOfElements < Arr.Length && StartIndex >= 0)
            {
                for (int i = StartIndex; i < NumberOfElements; i++)
                {
                    if (Arr[i] > MaxResult)
                    {
                        MaxResult = Arr[i];
                    }
                }
            }
            return MaxResult;
        }

        public static void SortArray(int[] Arr)
        {
            for (int j = 0; j < Arr.Length; j++)
            {
                for (int i = 0; i < Arr.Length - 1; i++)
                {
                    int Current = MaxInSubArray(Arr, i + 1, Arr.Length - i);
                    if (Arr[i] > Current)
                    {
                        int temp = Arr[i];
                        Arr[i] = Current;
                        Arr[i + 1] = temp;
                    }
                }
            }
        }
        static void Main()
        {
            Console.WriteLine("Enter array values in one single row, seperated by , or space:");
            int[] NumberArray = Console.ReadLine().
                Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(x => int.Parse(x)).ToArray();

            SortArray(NumberArray);

            Console.WriteLine("Array after sorting:");
            for (int i = 0; i < NumberArray.Length; i++)
            {
                Console.Write("{0}, ", NumberArray[i]);
            }
            Console.WriteLine();
        }
    }

