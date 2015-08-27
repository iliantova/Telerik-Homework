//Problem 13. Binary to Decimal Number

//Using loops write a program that converts a binary integer number to its decimal form.
//The input is entered as string. The output should be a variable of type long.
//Do not use the built-in .NET functionality.

using System;
using System.Numerics;


    class BinaryDecimal
    {
        static void Main()
        {
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
          
             Console.WriteLine(Rezult);


        }
    }

