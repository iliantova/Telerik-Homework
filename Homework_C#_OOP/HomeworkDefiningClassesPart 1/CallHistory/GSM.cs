﻿
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
    class GSM
    {

        static GSM iPhone;
       private string model = null;
       private string manufacturer = null;
       private double? price = null;
       private string owner = null;
       private Battery batteryCharacteristics = null;
       private Display displayCharacteristics = null;

       private List<Calls> callHistory;
       
       static GSM()
       {
           iPhone = new GSM("iPhone 4S", "Apple", 1000, "Will Smith",
                new Battery("Apple", 12, 36, BatteryType.LiIon), new Display(7, 16000000));

       }

       public static string GetIPhone()
       {
           return iPhone.ToString();
       }
       

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

        public string MANIFACTURER
        {
            get
            {
                return this.manufacturer;
            }
            set
            {
                this.manufacturer = value;
            }
        }

        public double? PRICE
        {
            get
            {
                return this.price;
            }
            set
            {
                this.price = value;
            }
        }

        public string OWNER
        {
            get
            {
                return this.owner;
            }
            set
            {
                this.owner = value;
            }
        }

        public Battery BATTERYCHARACTERISTICS
        {
            get
            {
                return this.batteryCharacteristics;
            }
            set
            {
                this.batteryCharacteristics = value;
            }
        }

        public Display DISPLAYCHARACTERISTICS
        {
            get
            {
                return this.displayCharacteristics;
            }
            set
            {
                this.displayCharacteristics = value;
            }
        }

        public List<Calls> HISTORY
        {
            get { return this.callHistory; }
        }

        public GSM()
        {
            this.BATTERYCHARACTERISTICS = new Battery();
            this.DISPLAYCHARACTERISTICS = new Display();
        }

        public GSM(string model, string manufacturer)
        {
            this.MODEL = model;
            this.MANIFACTURER = manufacturer;
            this.BATTERYCHARACTERISTICS = new Battery();
            this.DISPLAYCHARACTERISTICS = new Display();
        }

        public GSM(string model, string manufacturer, double price)
        {
            this.MODEL = model;
            this.MANIFACTURER = manufacturer;
            this.PRICE = price;
            this.BATTERYCHARACTERISTICS = new Battery();
            this.DISPLAYCHARACTERISTICS = new Display();
        }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.MODEL = model;
            this.MANIFACTURER = manufacturer;
            this.PRICE = price;
            this.OWNER = owner;
            this.BATTERYCHARACTERISTICS = new Battery();
            this.DISPLAYCHARACTERISTICS = new Display();
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.MODEL = model;
            this.MANIFACTURER = manufacturer;
            this.PRICE = price;
            this.OWNER = owner;
            this.BATTERYCHARACTERISTICS = battery;
            this.DISPLAYCHARACTERISTICS = display;
           
        }

        public override string ToString()
        {
            return string.Format(
                  "GSM information for model: {0} \n Manufacturer: {1} \n Price: {2} \n Owner: {3} \n  {4} \n {5}",
                  this.MODEL, this.MANIFACTURER, this.PRICE, this.OWNER, this.BATTERYCHARACTERISTICS, this.DISPLAYCHARACTERISTICS);
        }
        
    }
}
