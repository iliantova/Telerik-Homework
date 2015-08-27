
//Problem 14. Modify a Bit at Given Position
//We are given an integer number n, a bit value v (v=0 or 1) and a position p.
//Write a sequence of operators (a few lines of C# code) that modifies n to hold 
//the value v at the position p from the binary representation of n while preserving 
//all other bits in n.

using System;

    class ModifyBitPosition
    {
        static void Main()
        {

            Console.WriteLine("Enter integer value:");
            int Value = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bit position:");
            int Pos = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter bit value:");
            int Var = Int32.Parse(Console.ReadLine());

            if (Var == 1)
            {
                int Mask = 1 << Pos;
                int ValueMask = Value | Mask;
                Console.WriteLine(ValueMask);
            }
            else
            {
                int Mask = ~(1 << Pos);
                int ValueMask = Value & Mask;
                Console.WriteLine(ValueMask);
            }

        }
    }

