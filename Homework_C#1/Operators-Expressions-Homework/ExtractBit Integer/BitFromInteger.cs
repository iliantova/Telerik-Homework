 //Problem 12. Extract Bit from Integer
 //Write an expression that extracts from given integer n the value of given bit at index p. 


using System;


    class BitFromInteger
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Enter integer value:");
            int Value = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bit position:");
            int Pos = Int32.Parse(Console.ReadLine());

            int Mask = 1 << Pos;
            int ValueMask = Value & Mask;
            int Bit = ValueMask >> Pos;
            Console.WriteLine("Bit#{0} is: {1}", Pos, Bit);

        }
    }

