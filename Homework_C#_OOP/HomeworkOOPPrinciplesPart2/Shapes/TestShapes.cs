namespace Shapes
{
    using System;
    using System.Collections.Generic;
    class TestShapes
    {
        static void Main()
        {
            List<Shape> shape = new List<Shape>();
            Square square = new Square(4);
            shape.Add(square);
            Triangle triangle = new Triangle(7.8, 4.8);
            shape.Add(triangle);
            Rectangle rectangle = new Rectangle(8, 5.7);
            shape.Add(rectangle);

            foreach (var item in shape)
            {
                Console.WriteLine(item.GetType().Name + " surfase is " + item.CalculateSurface());
            }

        }
    }
}
