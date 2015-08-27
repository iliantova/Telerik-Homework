//Problem 8. Calls

//Create a class Call to hold a call performed through a GSM.
//It should contain date, time, dialled phone number and duration (in seconds).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CaLL
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
