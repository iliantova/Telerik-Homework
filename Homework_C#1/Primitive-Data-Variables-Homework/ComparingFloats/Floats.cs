//Problem 13.* Comparing Floats

//Write a program that safely compares floating-point numbers (double) with precision eps = 0.000001.
//Note: Two floating-point numbers a and b cannot be compared directly by a == b because of the nature of the floating-point arithmetic.
//Therefore, we assume two numbers are equal if they are more closely to each other than a fixed constant eps.


using System;


class Floats
{
    static void Main()
    {
        Console.WriteLine("First Number:");                      //When entering values, keep in mind the delimiter your system is using.
        double FirstNumber = Double.Parse(Console.ReadLine());
        Console.WriteLine("Second Number:");
        double SecondNumber = Double.Parse(Console.ReadLine());

        if (Math.Abs(FirstNumber - SecondNumber) <= 0.000001)
            Console.WriteLine("The two numbers are equal.");
        else
            Console.WriteLine("The two numbers are unequal.");


    }
}

