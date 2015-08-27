//Problem 3. Circle Perimeter and Area

//Write a program that reads the radius r of a circle and prints its perimeter and area formatted with 2 digits after the decimal point.



using System;
using System.Threading;
using System.Globalization;


    class PerimAreaCycle
    {
        static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Console.WriteLine("Write a radius r of a circle:");
            double Radius = double.Parse(Console.ReadLine());

            double Perimeter = 2 * Math.PI * Radius;
            double Area = Math.PI * Math.Pow(Radius, 2);

            Console.WriteLine("Perimeter = {0:0.00}", Perimeter);
            Console.WriteLine("Perimeter = {0:0.00}", Area);
          

        }
    }

