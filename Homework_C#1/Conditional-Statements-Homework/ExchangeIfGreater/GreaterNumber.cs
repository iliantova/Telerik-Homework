//Problem 1. Exchange If Greater

//Write an if-statement that takes two double variables a and b 
//and exchanges their values if the first one is greater than the second one. As a result print the values a and b, separated by a space.

using System;
using System.Threading;
using System.Globalization;

   class GreaterNumber
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Write a value for a");
            double a = double.Parse(Console.ReadLine());

            Console.WriteLine("Write a value for b");
            double b = double.Parse(Console.ReadLine());

            if (a>b)
            {
               
                double change = a;
                     a = b;
                     b = change;
            }

            Console.WriteLine("{0} {1}", a, b);


        }
    }

