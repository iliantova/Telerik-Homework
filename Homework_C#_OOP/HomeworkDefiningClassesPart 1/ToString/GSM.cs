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
    class GSM
    {
        string model = null;
        string manufacturer = null;
        double? price = null;
        string owner = null;
        Battery batteryCharacteristics = null;
        Display displayCharacteristics = null;

        public override string ToString()
        {
            return string.Format(
                  "GSM information: Model: {0} /n Manufacturer: {1} /n Price: {2} /n Owner: {3} /n Battery: {4} /n Display: {5}",
                  this.model, this.manufacturer, this.price, this.owner, this.batteryCharacteristics, this.displayCharacteristics);
        }


        public GSM(string model, string manufacturer)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.batteryCharacteristics = new Battery();
            this.displayCharacteristics = new Display();
        }

        public GSM(string model, string manufacturer, double price)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.batteryCharacteristics = new Battery();
            this.displayCharacteristics = new Display();
        }

        public GSM(string model, string manufacturer, double price, string owner)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.batteryCharacteristics = new Battery();
            this.displayCharacteristics = new Display();
        }

        public GSM(string model, string manufacturer, double price, string owner, Battery battery, Display display)
        {
            this.model = model;
            this.manufacturer = manufacturer;
            this.price = price;
            this.owner = owner;
            this.batteryCharacteristics = battery;
            this.displayCharacteristics = display;
        }


        
    }
}
