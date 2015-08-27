//Problem 17. Date in Bulgarian

//Write a program that reads a date and time given in the format: day.month.year hour:minute:second
//and prints the date and time after 6 hours and 30 minutes (in the same format) along with the day of week in Bulgarian.


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BGData
    {
        static void Main()
        {
            Console.WriteLine("Enter data and time in format: d.MM.yyyy H:mm:ss:");
            string Dataread = Console.ReadLine();
            DateTime dataformat = DateTime.ParseExact(Dataread, "d.MM.yyyy H:mm:ss", CultureInfo.GetCultureInfo("bg-BG"));
            DateTime dateplus = dataformat.AddHours(6).AddMinutes(30);

            Console.WriteLine(dateplus.ToString("d.MM.yyyy hh:mm:ss"));
            Console.WriteLine(dateplus.DayOfWeek);

        }
    }

