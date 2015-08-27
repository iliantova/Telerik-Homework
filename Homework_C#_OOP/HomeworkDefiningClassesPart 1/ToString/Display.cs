//Problem 4. ToString

//Add a method in the GSM class for displaying all information about it.
//Try to override ToString().

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToString
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
