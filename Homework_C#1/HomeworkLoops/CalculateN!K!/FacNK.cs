//Problem 6. Calculate N! / K!

//Write a program that calculates n! / k! for given n and k (1 < k < n < 100).
//Use only one loop.



using System;




    class FacNK
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            int K = int.Parse(Console.ReadLine());
            int rezult = 1;

            for (int i = 1; i <= N; i++)
            {

                if (K<i)
                {
                    rezult = rezult * i; 
                }
                
           }

            Console.WriteLine(rezult);


        }
    }

