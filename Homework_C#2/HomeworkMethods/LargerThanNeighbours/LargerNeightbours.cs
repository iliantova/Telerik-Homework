//Problem 5. Larger than neighbours

//Write a method that checks if the element at given position in given array of integers
//is larger than its two neighbours (when such exist).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class LargerNeightbours
{

    static bool MAxneighbours(int[] array, int number)
    {
        bool ifMax = false;
        if (array[number] != 0 && array[number] != array.Length)
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
            Console.WriteLine("Invalid number");
        }
        return ifMax;
    }

    static void Main()
    {



    }
}

