//Problem 9. Sum of n Numbers

//Write a program that enters a number n and after that enters more n numbers and calculates and prints their sum. Note: You may need to use a for-loop.


using System;
using System.Threading;
using System.Globalization;

namespace SumOfNNumbers
{
    class Program
    {
        static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
                       
            Console.WriteLine("Write a value for n");
           int n = int.Parse(Console.ReadLine());
           double result = 0;

           for (int i = 1; i <= n; i++)
           {

               double Number = double.Parse(Console.ReadLine());
               result = result + Number;   
           }
           Console.WriteLine("Sum is: {0}", result);
      
            }
    }
}
