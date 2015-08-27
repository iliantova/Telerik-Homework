//Problem 2. Static read-only field

//Add a private static read-only field to hold the start of the coordinate system – the point O{0, 0, 0}.
//Add a static property to return the point O.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticReadOnlyField
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
