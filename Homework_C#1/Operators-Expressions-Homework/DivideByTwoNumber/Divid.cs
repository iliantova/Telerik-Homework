
//Problem 3. Divide by 7 and 5

//Write a Boolean expression that checks for given integer if it can be divided (without remainder) by 7 and 5 at the same time.

using System;


    class Divid
    {
        static void Main()
        {

            Console.WriteLine("Write a number:");
            int Number = int.Parse(Console.ReadLine());

            if (Number % 5 == 0 && Number % 7 == 0)

            Console.WriteLine("The Number can be divided (without remainder) by 7 and 5 at the same time.");

            else

            Console.WriteLine("The Number can't be divided (without remainder) by 7 and 5 at the same time.");


        }
    }

