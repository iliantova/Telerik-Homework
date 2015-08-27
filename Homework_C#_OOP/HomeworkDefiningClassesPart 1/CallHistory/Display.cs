//Problem 9. Call history

//Add a property CallHistory in the GSM class to hold a list of the performed calls.
//Try to use the system class List<Call>.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallHistory
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
