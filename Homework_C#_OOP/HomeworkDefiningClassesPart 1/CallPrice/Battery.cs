﻿//Problem 11. Call price

//Add a method that calculates the total price of the calls in the call history.
//Assume the price per minute is fixed and is provided as a parameter.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CallPrice
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

       public override string ToString()
       {
           return string.Format(
                 "Battery: \n Model: {0} \n Hours idle: {1} \n Hours talk: {2} \n Type: {3} ",
                 this.MODEL, this.HOURSIDLE, this.HOURSTALK, this.TYPE );
       }

    }
}
