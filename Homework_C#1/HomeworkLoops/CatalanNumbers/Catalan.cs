
 //Problem 8. Catalan Numbers
 //Write a program to calculate the nth Catalan number by given n (1 <= n <= 100). 
 
using System;
using System.Numerics;
class Catalan
{
    static void Main()
    {
        Console.Write("Enter value for N(between 1 and 100): ");
        byte Value = Byte.Parse(Console.ReadLine());
        BigInteger a = 1;
        BigInteger b = 1;
        BigInteger result = 1;
        if (Value >= 1 && Value <= 100)
        {
            for (int i = 2; i <= Value; i++)
            {
                a *= Value + i;
                b *= i;
            }
            result = a / b;
            Console.WriteLine("Catalan number {0} is:", Value);
            Console.WriteLine(result);
        }
        else
        {
            Console.WriteLine("Value for N is out of range!");
        }
    }
}

