﻿//Problem 5. Properties

//Use properties to encapsulate the data fields inside the GSM, Battery and Display classes.
//Ensure all fields hold correct data at any given time.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Properties
{
    class GSM
    {
       private string model = null;
       private string manufacturer = null;
       private double? price = null;
       private string owner = null;
       private Battery batteryCharacteristics = null;
       private Display displayCharacteristics = null;

       
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
                  "GSM information: Model: {0} /n Manufacturer: {1} /n Price: {2} /n Owner: {3} /n Battery: {4} /n Display: {5}",
                  this.MODEL, this.MANIFACTURER, this.PRICE, this.OWNER, this.BATTERYCHARACTERISTICS, this.DISPLAYCHARACTERISTICS);
        }
        
    }
}
