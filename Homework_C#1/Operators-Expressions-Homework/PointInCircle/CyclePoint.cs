//Problem 7. Point in a Circle

//Write an expression that checks if given point (x, y) is inside a circle K({0, 0}, 2).


using System;


class CyclePoint
{
    static void Main()
    {
        Console.WriteLine("Write the value for X coordinate:");
        double pointX = double.Parse(Console.ReadLine());
        Console.WriteLine("Write the value for Y coordinate:");
        double pointY = double.Parse(Console.ReadLine());

        bool InsideCycle = Math.Pow((pointX - 0), 2) + Math.Pow((pointY - 0), 2) <= 4; //Formula for point in a cycle: (x1 - x0)^2 + (y1 - y0)^2 <= r^2

        Console.WriteLine("Is the point inside the cycle? -> " + InsideCycle);

    }
}

