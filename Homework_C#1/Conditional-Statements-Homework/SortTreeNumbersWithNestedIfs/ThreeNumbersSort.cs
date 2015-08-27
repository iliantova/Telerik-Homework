
 //Problem 7. Sort 3 Numbers with Nested Ifs
 //Write a program that enters 3 real numbers and prints them sorted in descending order.
 //Use nested if statements. 
 
using System;
class ThreeNumbersSort
{
    static void Main()
    {
        Console.WriteLine("Enter 1st number:");
        double FirstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number:");
        double SecondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd number:");
        double ThirdNumber = double.Parse(Console.ReadLine());

        if (FirstNumber > SecondNumber)
        {
            if (FirstNumber > ThirdNumber)
            {
                if (SecondNumber > ThirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", FirstNumber, SecondNumber, ThirdNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", FirstNumber, ThirdNumber, SecondNumber);
                }
            }
            else
            {
                Console.WriteLine("{0} {1} {2}", ThirdNumber, FirstNumber, SecondNumber);
            }
        }
        else
        {
            if (FirstNumber > ThirdNumber)
            {
                Console.WriteLine("{0} {1} {2}", SecondNumber, FirstNumber, ThirdNumber);
            }
            else
            {
                if (SecondNumber > ThirdNumber)
                {
                    Console.WriteLine("{0} {1} {2}", SecondNumber, ThirdNumber, FirstNumber);
                }
                else
                {
                    Console.WriteLine("{0} {1} {2}", ThirdNumber, SecondNumber, FirstNumber);
                }
            }
        }
    }
}

