//Problem 2. Get largest number

//Write a method GetMax() with two parameters that returns the larger of two integers.
//Write a program that reads 3 integers from the console and prints the largest of them using the method GetMax().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MaxMethod
    {
        static int GetMax(int value1, int value2)
        {
            if (value1 > value2)
            {
                return value1;
            }
            else { return value2; }
            
    }


        static void Main()
        {
            Console.Write("Enter first number: ");
            int numberOne = int.Parse(Console.ReadLine());
            Console.Write("Enter second number: ");
            int numberTwo = int.Parse(Console.ReadLine());
            Console.Write("Enter tirth number: ");
            int numberTree = int.Parse(Console.ReadLine());

            int maxValue = GetMax(GetMax(numberOne, numberTwo), numberTree);
            
            Console.WriteLine("Max value is:");
            Console.WriteLine(maxValue);

        }
    }

