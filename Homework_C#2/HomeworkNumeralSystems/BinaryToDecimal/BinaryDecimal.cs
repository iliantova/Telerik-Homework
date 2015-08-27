//Problem 2. Binary to decimal

//Write a program to convert binary numbers to their decimal representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;

class BinaryDecimal
{
    static void Main()
    {
        Console.WriteLine("Please enter bin number:");
        string N = Console.ReadLine();
        BigInteger Number = BigInteger.Parse(N);
        BigInteger Rezult = 0;
        int i;
        BigInteger Ostatak = 0;
        for (i = 0; i < N.Length; i++)
        {
            Ostatak = Number % 10;
            Rezult += Ostatak * (BigInteger)Math.Pow(2, i);


            Number = Number / 10;
        }

        Console.WriteLine("Decimal number:");
        Console.WriteLine(Rezult);


    }
}


