//Odd or Even Integers

//Write an expression that checks if given integer is odd or even.




using System;

namespace OddEvenIntegers
{
    class OddEven
    {
        static void Main()
        {

            Console.WriteLine("Write a number:");
            int Number = int.Parse(Console.ReadLine());
            bool OddOrEven = (Number % 2) == 0;
            Console.WriteLine("Is number odd ? " + OddOrEven);

        }
    }
}
