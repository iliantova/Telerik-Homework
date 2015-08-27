//Problem 3. Day of week

//Write a program that prints to the console which day of the week is today.
//Use System.DateTime.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class WeekDay
    {
        static void Main()
        {
           var toDay = DateTime.Today.DayOfWeek;
            Console.WriteLine("Today is {0}.", toDay);


        }
    }

