//Problem 4. Triangle surface

//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it;
//Three sides;
//Two sides and an angle between them;
//Use System.Math.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SurfaseTriangle
    {
        static void Main()
        {
            Console.WriteLine("Please choose one:");
            Console.WriteLine("1 -> for calculate the surface by side and altitude to it");
            Console.WriteLine("2 -> for calculate the surface by two sides and an angle between them");
            Console.WriteLine("3-> for calculate the surface by three sides");
            int Choos = int.Parse(Console.ReadLine());

            if (Choos==1)
            {
                Console.WriteLine("Please enter one side of a triangle:");
                double Side = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter altitude to side of a triangle:");
                double Altitude = double.Parse(Console.ReadLine());

                double S = (Side * Altitude) / 2;
                Console.WriteLine("Surface is : {0:0.00}",S);
            }
            if (Choos == 2)
            {
                Console.WriteLine("Please enter first side of a triangle:");
                double Side = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter second side of a triangle:");
                double Side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter angle to side of a triangle:");
                double Angle = double.Parse(Console.ReadLine());
                Angle = (Math.PI * Angle) / 180;
                //double Angle2 = Math.Sin()
                //Console.WriteLine(Angle);

                double S = (Side *Side2* Math.Sin(Angle)) / 2;
                Console.WriteLine("Surface is : {0:0.00}", S);
            
            }

            if (Choos == 3)
            {
                Console.WriteLine("Please enter first side of a triangle:");
                double Side = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter second side of a triangle:");
                double Side2 = double.Parse(Console.ReadLine());
                Console.WriteLine("Please enter third side of a triangle:");
                double Side3 = double.Parse(Console.ReadLine());

                double p = (Side + Side2 + Side3) / 2;
                double S = Math.Sqrt(p * (p - Side) * (p - Side2) * (p - Side3));
                Console.WriteLine("Surface is : {0:0.00}", S);

            }

            else 
            {
                Console.WriteLine("Invalid number. Please choose 1, 2 or 3.");
            }
        }
    }

