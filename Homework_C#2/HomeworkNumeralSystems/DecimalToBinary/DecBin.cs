//Problem 1. Decimal to binary

//Write a program to convert decimal numbers to their binary representation.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class DecBin
{
    static long DecimalBin(long number)
    {
        int Reminder = 0;
        string result = "";
         long Binnumber = 0;
       do
        {
            Reminder = (int)number % 2;
            number /= 2;
            result += Reminder;
        }
        while (number> 0);
    
        char[] rezult2 = result.ToCharArray();
        Array.Reverse(rezult2);
        string BinRezult = new string(rezult2);
        Binnumber = long.Parse(BinRezult);
             
        return Binnumber;
    }


    static void Main()
    {
        long DecimalValue = Int64.Parse(Console.ReadLine());
       
        Console.Write("The binary value of {0} is: ", DecimalValue);
        Console.WriteLine(DecimalBin(DecimalValue));

    }
}

