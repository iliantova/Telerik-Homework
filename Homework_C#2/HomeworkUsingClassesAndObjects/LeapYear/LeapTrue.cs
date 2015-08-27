//Problem 1. Leap year

//Write a program that reads a year from the console and checks whether it is a leap one.
//Use System.DateTime.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LeapTrue
    {
        static void Main()
        {
            Console.WriteLine("Please enter an year:");
            int year;
            if (int.TryParse(Console.ReadLine(), out year) && year <= 9999 && year >= 1)
            {
                Console.WriteLine("Is {0} leap year: {1}", year, DateTime.IsLeapYear(year));
            }
            else 
            {
                Console.WriteLine("Invalid year");
            }


        }
    }

