//Problem 6. Quadratic Equation

//Write a program that reads the coefficients a, b and c of a quadratic equation ax2 + bx + c = 0 and solves it (prints its real roots).


using System;
using System.Threading;
using System.Globalization;


class Equation
{
    static void Main()
        {

            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;
            Console.WriteLine("Write a value for a");
            double a = double.Parse(Console.ReadLine());
           

            Console.WriteLine("Write a value for b");
            double b = double.Parse(Console.ReadLine());

            Console.WriteLine("Write a value for c");
            double c = double.Parse(Console.ReadLine());

           double dicriminantaD = ((Math.Pow(b,2)) - (4*a*c));

           if (dicriminantaD < 0)
           {
               Console.WriteLine("No real roots");
           
           }

           else if (dicriminantaD == 0)
           {
               Console.WriteLine("X1=X2= " + - b/(2*a));
           }

           else
           {
               double X1 = (-b - (Math.Sqrt(Math.Pow(b,2) - 4*a*c)))/(2*a);

               double X2 = (-b + (Math.Sqrt(Math.Pow(b,2) - 4*a*c)))/(2*a);

               Console.WriteLine("X1= {0} X2= {1}", X1, X2);


           }










        }
}

