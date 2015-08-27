//Problem 6. First larger than neighbours

//Write a method that returns the index of the first element in array that is larger than its neighbours, or -1, if there’s no such element.
//Use the method from the previous exercise.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class FirstMAx
    {
        static bool MAxneighbours(int[] array, int number)
        {
            bool ifMax = false;
            if (number != 0 && number != array.Length)
            {
                if (array[number] > array[number - 1] && array[number] > array[number + 1])
                {
                    ifMax = true;
                }
                else
                {
                    ifMax = false;
                }
            }
            else
            {
                ifMax = false;
            }
            return ifMax;
        }

        static void Main()
        {
            Console.WriteLine("Please, enter array:");
            int[] Neightbor = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();
            int rezult = 0;
            for (int i = 0; i < Neightbor.Length-1; i++)
            {
                if (MAxneighbours(Neightbor,i))
                {
                    rezult = i;
                    break;
                }
                else
                {
                    rezult = -1;
                }
            }
            Console.WriteLine(rezult);
        }
    }

