//Problem 2. Constructors

//Define several constructors for the defined classes that take different sets of arguments (the full information for the class or part of it).
//Assume that model and manufacturer are mandatory (the others are optional). All unknown data fill with null.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Constructors
{
    class Display
    {
        double? size = null;
        int? numberOfColors = null;

        public Display()
        {

        }


       public Display(double size)
       {
           this.size = size;
       }

       public Display(double size, int colors)
       {
           this.size = size;
           this.numberOfColors = colors;
       }
        

    }
}
