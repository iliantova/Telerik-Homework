//Problem 3. Enumeration

//Add an enumeration BatteryType (Li-Ion, NiMH, NiCd, …) and use it as a new field for the batteries.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumeration
{
    class GSM
    {
        string model = null;
        string manufacturer = null;
        double? price = null;
        string owner = null;
        Battery batteryCharacteristics = null;
        Display displayCharacteristics = null;
        

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
