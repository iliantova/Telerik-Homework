//Problem 15. Prime numbers

//Write a program that finds all prime numbers in the range [1...10 000 000]. Use the Sieve of Eratosthenes algorithm.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;



class PrimeNumberAlgorithm
    {
        static void Main()
        {
            int squereLengt = (int) Math.Sqrt(10000000);
            bool[] primeArray = new bool[10000000];
           for (int i=0; i< primeArray.Length ;i++ )
           {
               primeArray[i] = true;
           }

           for (int i = 2; i < squereLengt; i++)
            {
                if (primeArray[i])
                {
                    for (int j = i * i; j < primeArray.Length; j += i)
                    {
                        primeArray[j] = false;

                    }
                }

            }
           for (int i = 0; i < primeArray.Length; i++)
           {
               if(primeArray[i])
                   Console.Write("{0} ",i);
           }

        }
    }

