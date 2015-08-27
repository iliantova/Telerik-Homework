//Problem 13. Check a Bit at Given Position
//Write a Boolean expression that returns if the bit at position p (counting from 0, 
//starting from the right) in given integer number n, has value of 1. 


using System;


    class BitGivenPosition
    {
        static void Main()
        {

            Console.WriteLine("Enter integer value:");
            int Value = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Enter Bit position:");
            int Pos = Int32.Parse(Console.ReadLine());

            int Mask = 1 << Pos;
            int ValueMask = Value & Mask;
            int Bit = ValueMask >> Pos;
            if (Convert.ToBoolean(Bit))
            {
                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }

        }
    }

