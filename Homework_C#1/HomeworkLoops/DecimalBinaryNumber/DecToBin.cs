
 //Problem 14. Decimal to Binary Number
 //   Using loops write a program that converts an integer number to its binary representation.
 //   The input is entered as long. The output should be a variable of type string.
 //   Do not use the built-in .NET functionality. 
 
using System;
class DecToBin
{
    static void Main()
    {
       
        long DecimalValue = Int64.Parse(Console.ReadLine());
        int Reminder = 0;
        string result = "";
        Console.Write("The binary value of {0} is: ", DecimalValue);
        do
        {
            Reminder = (int)DecimalValue % 2;
            DecimalValue /= 2;
            result += Reminder;
            } 
        while (DecimalValue > 0);
        for (int i = result.Length - 1; i >= 0; i--)
        {
            Console.Write(result[i]);
        }
        Console.WriteLine();
    }
}

