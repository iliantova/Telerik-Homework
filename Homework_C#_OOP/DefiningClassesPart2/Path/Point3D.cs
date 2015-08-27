//Problem 4. Path

//Create a class Path to hold a sequence of points in the 3D space.
//Create a static class PathStorage with static methods to save and load paths from a text file.
//Use a file format of your choice.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Path
{
      [Serializable()]
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

        public Point3D(int x, int y, int z)
            : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        public override string ToString()
        {
            return string.Format("[{0},{1},{2}]", X, Y, Z);
        }

       
    }
}
