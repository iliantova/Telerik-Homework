
 //Problem 7. Calculate N! / (K! * (N-K)!)
 //In combinatorics, the number of ways to choose k different members out of a 
 //group of n different elements (also known as the number of combinations) is 
 //calculated by the following formula: formula For example, there are 2598960 ways 
 //to withdraw 5 cards out of a standard deck of 52 cards.
 //Your task is to write a program that calculates n! / (k! * (n-k)!) for 
 //given n and k (1 < k < n < 100). Try to use only two loops. 
 
using System;
class CalculateNumbersNK2
{
    static void Main()
    {
        Console.Write("Value for N: ");
        int NValue = Int32.Parse(Console.ReadLine());
        Console.Write("Value for K: ");
        int KValue = Int32.Parse(Console.ReadLine());

        double NFact = 1;
        double KFact = 1;
        double Temp = 1;
        double Result = 0;

            for (int i = 1; i <= NValue; i++)
            {
                NFact *= i;
                if (i <= KValue)
                {
                    KFact *= i;
                }
            }
           for (int i = 1; i <= NValue - KValue; i++)
            {
                Temp *= i;
            }

           Result = NFact / (KFact * Temp);
            Console.WriteLine("{0}", Result);
        }
       
    }


