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

    class Battery
    {
        
       string  model = null;
       double ?hoursIdle = null;
       double ?hoursTalk = null;

       public Battery()
       {

       }

       public Battery(string model, double hoursIdle, double hoursTalk)
       {
           this.model = model;
           this.hoursIdle = hoursIdle;
           this.hoursTalk = hoursTalk;

       }


    }
}
