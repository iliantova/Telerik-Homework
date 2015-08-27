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

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    class Battery
    {
        
       string  model = null;
       double ?hoursIdle = null;
       double ?hoursTalk = null;
       BatteryType? type = null;

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
