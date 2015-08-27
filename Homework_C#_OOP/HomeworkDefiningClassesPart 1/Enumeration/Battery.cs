
//Problem 3. Enumeration

//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
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
