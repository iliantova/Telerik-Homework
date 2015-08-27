//Problem 4. Number Comparer

//Write a program that gets two numbers from the console and prints the greater of them.
//Try to implement this without if statements.


using System;
using System.Threading;
using System.Globalization;


    class GreaterNumber
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Write the first number:");
            double FirstNumber = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the second number:");
            double SecondNumber = double.Parse(Console.ReadLine());



            Console.WriteLine( "Greater of numbers is:");
            Console.WriteLine(FirstNumber>SecondNumber? FirstNumber:SecondNumber);


        }
    }

