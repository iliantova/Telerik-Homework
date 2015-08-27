
 //Problem 14. Integer calculations
 //Write methods to calculate minimum, maximum, average, sum and product of given set of integer numbers.
 //Use variable number of arguments. 
 
using System;
using System.Linq;


class IntegerCalculations
{
    public static double[] Calc(params int[] Arr)
    {
        double[] Result = new double[5];
        int MinValue = Arr[0];
        int MaxValue = Arr[0];
        int ArrSum = 0;
        int ArrProd = 1;
        double ArrAverage = 0.00;
        for (int i = 0; i < Arr.Length; i++)
        {
            ArrProd *= Arr[i];
            ArrSum += Arr[i];
            if (MinValue > Arr[i])
            {
                MinValue = Arr[i];
            }
            if (MaxValue < Arr[i])
            {
                MaxValue = Arr[i];
            }
        }
        ArrAverage = (double)ArrSum / Arr.Length;
        Result[0] = ArrSum;
        Result[1] = ArrProd;
        Result[2] = ArrAverage;
        Result[3] = MaxValue;
        Result[4] = MinValue;

        return Result;
    }
    static void Main()
    {
        Console.WriteLine("Enter array values in one single row, seperated by , or space:");
        int[] NumberArray = Console.ReadLine().
            Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
            .Select(x => int.Parse(x)).ToArray();
        double[] Result = Calc(NumberArray);
        Console.WriteLine("Sum: {0}\nProd: {1}\nAvg: {2}\nMax: {3}\nMin: {4}\n", Result[0], Result[1], Result[2], Result[3], Result[4]);
    }
}

