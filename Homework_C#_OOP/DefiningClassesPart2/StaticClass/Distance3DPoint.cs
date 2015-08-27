//Problem 3. Static class

//Write a static class with a static method to calculate the distance between two points in the 3D space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
   public static class Distance3DPoint
    {

       public static double CalculateDistance(Point3D pointA, Point3D pointB)
       {
           double x = (pointB.X * pointB.X) - (2 * pointB.X * pointA.X) + (pointA.X * pointA.X);
           double y = (pointB.Y * pointB.Y) - (2 * pointB.Y * pointA.Y) + (pointA.Y * pointA.Y);
           double z = (pointB.Z * pointB.Z) - (2 * pointB.Z * pointA.Z) + (pointA.Z * pointA.Z);

           return Math.Sqrt(x + y + z);
       }

    }
}
