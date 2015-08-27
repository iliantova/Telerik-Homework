

//Problem 5. Calculate 1 + 1!/X + 2!/X^2 + … + N!/X^N

//Write a program that, for a given two integer numbers n and x, calculates the sum S = 1 + 1!/x + 2!/x2 + … + n!/x^n.
//Use only one loop. Print the result with 5 digits after the decimal point.

using System;



    class NXN
    {
        static void Main()
        {

            int N = int.Parse(Console.ReadLine());
            int X = int.Parse(Console.ReadLine());
            double  Sum = 1;
            int FacNumber = 1;

            for (int i = 1; i <= N; i++)

            {
            
            FacNumber = FacNumber*i;
              Sum = FacNumber/Math.Pow(X,i) + Sum;
                               
            }


             Console.WriteLine("Sum = {0:0.00000}", Sum);

        }
    }

