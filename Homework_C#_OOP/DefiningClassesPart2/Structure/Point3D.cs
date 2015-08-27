//Problem 1. Structure

//Create a structure Point3D to hold a 3D-coordinate {X, Y, Z} in the Euclidian 3D space.
//Implement the ToString() to enable printing a 3D point.


namespace Structure
{
    using System;
    

   public struct Point3D
    {
       private double x, y, z;

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

        static void Main()
        {
        }
    }
}
