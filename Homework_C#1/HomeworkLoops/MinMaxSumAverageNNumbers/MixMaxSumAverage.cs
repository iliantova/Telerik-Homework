//Problem 3. Min, Max, Sum and Average of N Numbers

//Write a program that reads from the console a sequence of n integer numbers and returns the minimal, the maximal number,
//the sum and the average of all numbers (displayed with 2 digits after the decimal point).
//The input starts by the number n (alone in a line) followed by n lines, each holding an integer number.
//The output is like in the examples below.

using System;

    class MixMaxSumAverage
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            double SumNumber = 0;
            double  MaxNumber = 0;
            double MinNumber = 0;

            MaxNumber = MinNumber = double.Parse(Console.ReadLine());
            SumNumber += MinNumber;
            for (int i=1; i<= N-1; i++)
            {
                                            
               double Number = double.Parse(Console.ReadLine());
               SumNumber = SumNumber + Number;

                if (MaxNumber < Number)
               {
                   MaxNumber = Number;
               }
               else
               {
                   if (MinNumber > Number)
                   {
                       MinNumber = Number;
                   }
               }
          
                              
            }
                       
                       Console.WriteLine("min = {0}",MinNumber);
                       Console.WriteLine("max = {0}", MaxNumber);
                       Console.WriteLine("sum = {0}", SumNumber);
                       Console.WriteLine("avg = {0:0.00}", SumNumber/N);
        }

        
    }

