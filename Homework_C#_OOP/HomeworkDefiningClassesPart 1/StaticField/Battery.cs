//Problem 6. Static field

//Add a static field and a property IPhone4S in the GSM class to hold the information about iPhone 4S.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticField
{

    public enum BatteryType
    {
        LiIon,
        NiMH,
        NiCd
    }

    class Battery
    {
        
      private string  model = null;
      private double ?hoursIdle = null;
      private double ?hoursTalk = null;
      private BatteryType? type = null;


       public string MODEL
       {
           get
           {
               return this.model;
           }
           set
           {
               this.model = value;
           }
       }

       public double? HOURSIDLE
       {
           get
           {
               return this.hoursIdle;
           }
           set
           {
               this.hoursIdle = value;
           }
       }

       public double? HOURSTALK
       {
           get
           {
               return this.hoursTalk;
           }
           set
           {
               this.hoursTalk = value;
           }
       }

       public BatteryType? TYPE
       {
           get
           {
               return this.type;
           }
           set
           {
               this.type = value;
           }
       }

       public Battery()
       {

       }

       public Battery(string model, double hoursIdle, double hoursTalk, BatteryType type)
       {
           this.MODEL = model;
           this.HOURSIDLE = hoursIdle;
           this.HOURSTALK = hoursTalk;
           this.TYPE = type;
       }


    }
}
