
 //Problem 13. Solve tasks

 //   Write a program that can solve these tasks:
 //       Reverses the digits of a number
 //       Calculates the average of a sequence of integers
 //       Solves a linear equation a * x + b = 0
 //   Create appropriate methods.
 //   Provide a simple text-based menu for the user to choose which task to solve.
 //   Validate the input data:
 //       The decimal number should be non-negative
 //       The sequence should not be empty
 //       a should not be equal to 0 

using System;
using System.Linq;

class SolveTasks
{
    public static double LinearEquation(double a, double b)
    {
        if (a == 0)
        {
            return -1;
        }
        else
        {
            double Result = (-b / a);
            return Result;
        }
    }

    public static double CalcAverage(params int[] Arr)
    {
        if (Arr.Length == 0)
        {
            return -1;
        }
        else
        {
            int ArrSum = 0;
            double ArrAverage = 0.00;
            for (int i = 0; i < Arr.Length; i++)
            {
                ArrSum += Arr[i];
            }
            ArrAverage = (double)ArrSum / Arr.Length;
            return ArrAverage;
        }
    }

    public static decimal RevNumber(decimal Value)
    {
        if (Value < 0)
        {
            return -1;
        }
        else
        {
            string RevNum = Value.ToString();
            string ReverseString = "";
            char[] Arr = RevNum.ToCharArray();
            for (int i = Arr.Length - 1; i > -1; i--)
            {
                ReverseString += Arr[i];
            }
            return Decimal.Parse(ReverseString);
        }
    }

    public static void Menu()
    {
        Console.WriteLine("Please choose an option:");
        Console.WriteLine("1 --> Reverse digits of a number.");
        Console.WriteLine("2 --> Calculate the average of an array of integers.");
        Console.WriteLine("3 --> Calculate a linear equation a*x + b = 0.");
        Console.WriteLine("Use CTRL + C to stop the program!");
        int Choice = 0;
        if (Int32.TryParse(Console.ReadLine(), out Choice) && Choice > 0 && Choice < 4)
        {
            switch (Choice)
            {
                case 1: Console.WriteLine("Please enter a value to reverse:");
                    decimal ValueToReverse = 0;
                    if (Decimal.TryParse(Console.ReadLine(), out ValueToReverse) && ValueToReverse >= 0)
                    {
                        ValueToReverse = RevNumber(ValueToReverse);
                        Console.WriteLine(ValueToReverse);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value!");
                    }
                    break;
                case 2: Console.WriteLine("Enter array values in one single row, seperated by , or space:");
                    int[] NumberArray = Console.ReadLine().
                        Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => int.Parse(x)).ToArray();
                    if (NumberArray.Length > 0)
                    {
                        double Result = CalcAverage(NumberArray);
                    }
                    else
                    {
                        Console.WriteLine("Incorrect input!");
                    }
                    break;
                case 3: Console.WriteLine("Please enter a for A:");
                    double a = double.Parse(Console.ReadLine());
                    Console.WriteLine("Please enter a for B:");
                    double b = double.Parse(Console.ReadLine());
                    if (a != 0)
                    {
                        Console.WriteLine(LinearEquation(a, b));
                    }
                    else
                    {
                        Console.WriteLine("Incorrect value!");
                    }
                    break;
            }
        }
        else
        {
            Console.WriteLine("Incorrect choice!");
        }
    }
    static void Main()
    {
        while (true)
        {
            Menu();
        }
    }
}

