
//Problem 2. Reverse string

//Write a program that reads a string, reverses it and prints the result at the console.
//Example:

//input	output
//sample	elpmas


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ReverseStriing
    {
        static void Main()
        {
            string stringRead = Console.ReadLine();
            char [] array = stringRead.ToCharArray();
            Array.Reverse(array);
            string reverseStr = new string(array);
            Console.WriteLine(reverseStr);

        }
    }

