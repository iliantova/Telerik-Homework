//Problem 8. Prime Number Check

//Write an expression that checks if given positive integer number n (n <= 100) is prime (i.e. it is divisible without remainder only to itself and 1).
//Note: You should check if the number is positive

using System;


namespace PrimeNumberCheck
{
    class PrimeChekc
    {
        static void Main()
        {

            Console.WriteLine("Write a number: ");
            int PrimeCheck = int.Parse(Console.ReadLine());
            Console.WriteLine("Is the number a prime?");
                    

            if (PrimeCheck > 100)
            {
                Console.WriteLine("The number is great to 100. Pleas enter new number less to 100!");
            }
            else if (PrimeCheck <= 1 )
            {
                Console.WriteLine(false);

            }

            else if (PrimeCheck % 2 == 0 & PrimeCheck != 2)
            {
                Console.WriteLine(false);
            }
            else if (PrimeCheck % 3 == 0 & PrimeCheck != 3)
            {
                Console.WriteLine(false);
            }
            else if (PrimeCheck % 5 == 0 & PrimeCheck != 5)
            {
                Console.WriteLine(false);
            }
            else if (PrimeCheck % 7 == 0 & PrimeCheck != 7)
            {
                Console.WriteLine(false);
            }

            else
            { Console.WriteLine(true); }










        }
    }
}
