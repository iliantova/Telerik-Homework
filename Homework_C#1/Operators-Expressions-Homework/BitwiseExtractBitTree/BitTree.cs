//Problem 11. Bitwise: Extract Bit #3

//    Using bitwise operators, write an expression for finding the value of the bit #3 of a given unsigned integer.
//    The bits are counted from right to left, starting from bit #0.
//    The result of the expression should be either 1 or 0.


using System;



    class BitTree
    {
        static void Main()
        {

            Console.WriteLine("Enter integer value:");
            int Number = Int32.Parse(Console.ReadLine());

            int MaskNumber = 1 << 3;
            int ValueMask = Number & MaskNumber;
            int BitTree = ValueMask >> 3;
            Console.WriteLine("Bit#3 is: {0}", BitTree);
        }
    }

