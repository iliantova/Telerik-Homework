using System;




    class PoinInside
    {
        static void Main()
        {

            Console.WriteLine("Write the value for X coordinate:");
            double pointX = double.Parse(Console.ReadLine());
            Console.WriteLine("Write the value for Y coordinate:");
            double pointY = double.Parse(Console.ReadLine());

            bool InsideCycle = Math.Pow((pointX - 1), 2) + Math.Pow((pointY - 1), 2) <= 2.25; //Formula for point in a cycle: (x1 - x0)^2 + (y1 - y0)^2 <= r^2
            
            if (InsideCycle)
            {  if (pointX <= 1 && pointY >= 1)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }
        }
        else
        {
            Console.WriteLine("no");
        }

                   

        }
    }
