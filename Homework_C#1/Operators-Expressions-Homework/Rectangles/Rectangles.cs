
//Problem 4. Rectangles

//Write an expression that calculates rectangle’s perimeter and area by given width and height.



using System;



    class Rectangles
    {
        static void Main()
        {
            Console.WriteLine("Write a rectangle’s width");
            float Width = float.Parse(Console.ReadLine());

            Console.WriteLine("Write a rectangle’s height");
            float Height = float.Parse(Console.ReadLine());


            float RecPerimeter = 2 * Width + 2 * Height;
            float RecArea = Width * Height;
            Console.WriteLine("Rectangle’s perimeter is: " + RecPerimeter);
            Console.WriteLine("Rectangle’s area is: " + RecArea);

        }
    }

