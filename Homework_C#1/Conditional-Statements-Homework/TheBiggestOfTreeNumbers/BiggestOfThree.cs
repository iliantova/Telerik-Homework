
 //Problem 5. The Biggest of 3 Numbers
 //Write a program that finds the biggest of three numbers.
 
using System;
class BiggestOfThree
{
    static void Main()
    {
        Console.WriteLine("Enter 1st number:");
        double FirstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number:");
        double SecondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd number:");
        double ThirdNumber = double.Parse(Console.ReadLine());

        double Biggest = FirstNumber;
        if (Biggest > SecondNumber)
        {
            if (Biggest > ThirdNumber)
            {
                Console.WriteLine(Biggest);
            }
            else
            {
                Biggest = ThirdNumber;
                Console.WriteLine(Biggest);
            }
        }
        else
        {
            Biggest = SecondNumber;
            if (Biggest > ThirdNumber)
            {
                Console.WriteLine(Biggest);
            }
            else
            {
                Biggest = ThirdNumber;
                Console.WriteLine(Biggest);
            }
        }

    }
}

