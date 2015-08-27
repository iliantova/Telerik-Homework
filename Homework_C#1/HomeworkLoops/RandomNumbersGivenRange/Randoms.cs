
//Problem 11. Random Numbers in Given Range

//Write a program that enters 3 integers n, min and max (min != max) and prints n random numbers in the range [min...max].



using System;



    class Randoms
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int Min = int.Parse(Console.ReadLine());
            int Max = int.Parse(Console.ReadLine());
            Random Number = new Random();
           
            for (int i=0; i<N; i++)
            {
                Console.Write("{0} ", Number.Next(Min, Max +1));

            }
            
            Console.WriteLine();



        }
    }

