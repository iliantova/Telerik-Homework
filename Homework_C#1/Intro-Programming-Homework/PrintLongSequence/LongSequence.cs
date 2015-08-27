
//Problem 16.* Print Long Sequence

//Write a program that prints the first 1000 members of the sequence: 2, -3, 4, -5, 6, -7, …
//You might need to learn how to use loops in C# (search in Internet).


using System;


    class LongSequence
    {
        static void Main()
        {
            for (int longSequence = 2; longSequence <= 1000; longSequence = longSequence + 2)
            {
                Console.Write("{0}, {1}, ", longSequence, ~longSequence); //The ~ operator looks at the binary representation of the values of the expression and does a bitwise negation operation on it.
            }
            Console.ReadKey();
        }
    }
