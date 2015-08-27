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
   public class PrintPointO
    {
        static void Main()
        {

            Console.WriteLine(Point3D.PointO);

        }
    }
}
