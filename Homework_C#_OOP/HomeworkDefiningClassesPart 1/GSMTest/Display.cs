//Problem 7. GSM test

//Write a class GSMTest to test the GSM class:
//Create an array of few instances of the GSM class.
//Display the information about the GSMs in the array.
//Display the information about the static property IPhone4S.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GSMTest
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
                 "Display:\n Size:{0} \n Color:{1}",
                 this.SIZE, this.NUMBEROFCOLORS);
       }

    }
}
