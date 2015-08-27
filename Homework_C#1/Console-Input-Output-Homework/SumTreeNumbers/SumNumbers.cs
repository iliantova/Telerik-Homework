//Problem 1. Sum of 3 Numbers

//Write a program that reads 3 real numbers from the console and prints their sum.

using System;
using System.Threading;
using System.Globalization;


class SumNumbers
{
    static void Main()
    {

        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        Console.WriteLine("Write a firts number.");
        double NumberOne = double.Parse(Console.ReadLine());
        Console.WriteLine("Write a second number.");
        double NumberTwo = double.Parse(Console.ReadLine());
        Console.WriteLine("Write a third number.");
        double NumberTree = double.Parse(Console.ReadLine());

        double Sum = NumberOne + NumberTwo + NumberTree;

        Console.WriteLine("Sum of tree numbers is : {0}", Sum);


    }
}