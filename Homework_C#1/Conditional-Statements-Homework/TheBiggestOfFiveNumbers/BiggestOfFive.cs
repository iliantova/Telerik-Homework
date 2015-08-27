
 //Problem 6. The Biggest of Five Numbers
 //Write a program that finds the biggest of five numbers by using only five if statements. 
 
using System;
class BiggestOfFive
{
    static void Main()
    {
        Console.WriteLine("Enter 1st number:");
        double FirstNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd number:");
        double SecondNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd number:");
        double ThirdNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 4th number:");
        double FourthNumber = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 5th number:");
        double FifthNumber = double.Parse(Console.ReadLine());

        double Biggest = FirstNumber;

        if (Biggest < SecondNumber)
        {
            Biggest = SecondNumber;
        }
        if (Biggest < ThirdNumber)
        {
            Biggest = ThirdNumber;
        }
        if (Biggest < FourthNumber)
        {
            Biggest = FourthNumber;
        }
        if (Biggest < FifthNumber)
        {
            Biggest = FifthNumber;
        }

        Console.WriteLine("Biggest is: {0}", Biggest);
    }
}

