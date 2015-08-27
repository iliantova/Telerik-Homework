//Problem 5. Properties

//Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
//Ensure all fields hold correct data at any given time.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
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
        

    }
}
