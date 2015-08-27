//Problem 3. Static class

//Write a static class with a static method to calculate the distance between two points in the 3D space.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticClass
{
   public struct Point3D
    {
       private double x, y, z;

        private static readonly Point3D center = new Point3D() { X = 0, Y = 0, Z = 0 };


        public static Point3D PointO
        {
            get
            {
                return Point3D.center;
            }
        }

         public double X
        {
            get
            {
                return x;
            }
            set
            {
                x = value;
            }
        }
        public double Y
        {
            get
            {
                return y;
            }
            set
            {
                y = value;
            }
        }
        public double Z
        {
            get
            {
                return z;
            }
            set
            {
                z = value;
            }
        }

        public override string ToString()
        {
            return string.Format("[{0},{1},{2}]", X, Y, Z);
        }

       
    }
}
