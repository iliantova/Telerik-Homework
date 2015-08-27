//Problem 7. Sum of 5 Numbers

//Write a program that enters 5 numbers (given in a single line, separated by a space), calculates and prints their sum.


using System;
using System.Threading;
using System.Globalization;


class FiveSum
{
    static void Main()
    {
        Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

        double Number1 = double.Parse(ReadToNextSpace());
        double Number2 = double.Parse(ReadToNextSpace());
        double Number3 = double.Parse(ReadToNextSpace());
        double Number4 = double.Parse(ReadToNextSpace());
        double Number5 = double.Parse(ReadToNextSpace());

        Double SumNumber = Number1 + Number2 + Number3 + Number4 + Number5;
        Console.WriteLine("The sum = " + SumNumber);


    }
    private static string ReadToNextSpace()
    {
        string result = "";
        char elem = (char)Console.Read();

        while (elem != '\r' && elem != ' ')
        {
            result = result + elem;
            elem = (char)Console.Read();
        }
        return result;
    }

}


