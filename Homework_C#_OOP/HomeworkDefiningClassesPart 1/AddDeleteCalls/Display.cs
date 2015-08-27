//Problem 10. Add/Delete calls

//Add methods in the GSM class for adding and deleting calls from the calls history.
//Add a method to clear the call history.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AddDeleteCalls
{

    class Display
    {
       private double? size = null;
        private int? numberOfColors = null;

        public double? SIZE
        {
            get
            {
                return this.size;
            }
            set
            {
                this.size = value;
            }
        }

        public int? NUMBEROFCOLORS
        {
            get
            {
                return this.numberOfColors;
            }
            set
            {
                this.numberOfColors = value;
            }
        }

        public Display()
        {

        }


       public Display(double size)
       {
           this.SIZE = size;
       }

       public Display(double size, int colors)
       {
           this.SIZE = size;
           this.NUMBEROFCOLORS = colors;
       }

       public override string ToString()
       {
           return string.Format(
                 "Display: Size:{0} \n Color:{1}",
                 this.SIZE, this.NUMBEROFCOLORS);
       }

    }
}
