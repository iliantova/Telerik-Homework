//Problem 9. Print a Sequence

//Write a program that prints 
//the first 10 members of the sequence: 2, -3, 4, -5, 6, -7, ...


using System;

class Sequence
{
    static void Main()
    {
        for (int sNumber = 2; sNumber <= 10; sNumber=sNumber+2)
        {
            Console.Write("{0}, {1}, ", sNumber, ~sNumber); //The ~ operator looks at the binary representation of the values of the expression and does a bitwise negation operation on it.
        }
        Console.ReadKey();
    }
}

