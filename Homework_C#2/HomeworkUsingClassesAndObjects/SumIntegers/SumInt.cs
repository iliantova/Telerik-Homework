//Problem 6. Sum integers

//You are given a sequence of positive integer values written into a string, separated by spaces.
//Write a function that reads these values from given string and calculates their sum.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SumInt
    {

        static void Main()
        {

            int sum =0;
            string Inputsting = Console.ReadLine();
            int[] charInput = Inputsting.Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries).Select(x => int.Parse(x)).ToArray();
            for (int i = 0; i < charInput.Length; i++)
            {
                 sum += charInput[i];
            }

            Console.WriteLine( sum);

        }
    }

