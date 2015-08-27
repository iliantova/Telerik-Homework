//Problem 5. Third Digit is 7?

//Write an expression that checks for given integer if its third digit from right-to-left is 7.

using System;


class ThirdDigit
{
    static void Main()
    {

        Console.WriteLine("Write a number:");
        string CheckNumber = Console.ReadLine();

        if (CheckNumber.Length >= 3)
        {
            bool Digit = (CheckNumber[CheckNumber.Length - 3] == '7');
            Console.WriteLine(Digit);
        }

        else
        {
            bool Digit = false;
            Console.WriteLine(Digit);
        }

    }
}

