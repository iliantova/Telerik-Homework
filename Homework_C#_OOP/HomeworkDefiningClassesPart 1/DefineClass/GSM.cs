﻿//Problem 1. Define class

//Define a class that holds information about a mobile phone device: model, manufacturer, price, owner,
//battery characteristics (model, hours idle and hours talk) and display characteristics (size and number of colors).
//Define 3 separate classes (class GSM holding instances of the classes Battery and Display).

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefineClass
{
    public class GSM
    {
       

            string model = null;
            string manufacturer = null;
            double ?price = null;
            string owner = null;
            Battery batteryCharacteristics = null;
            Display displayCharacteristics = null;


        
    }
}
