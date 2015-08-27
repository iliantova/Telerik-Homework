
//Problem 9. Trapezoids

//Write an expression that calculates trapezoid's area by given sides a and b and height h.

using System;


    class AreaTrapez
    {
        static void Main()
        {
            Console.WriteLine( "Write value for one side:");
            double a = double.Parse(Console.ReadLine());
            Console.WriteLine("Write value for onather side:");
            double b = double.Parse(Console.ReadLine());
            Console.WriteLine("Write value for hight:");
            double h = double.Parse(Console.ReadLine());

            double AreaTrapezoids = ((a + b) / 2) * h;
            Console.WriteLine("Trapezoid's area = " + AreaTrapezoids);

        }
    }

