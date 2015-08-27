//Problem 16. Date difference

//Write a program that reads two dates in the format: day.month.year and calculates the number of days between them.
//Example:

//Enter the first date: 27.02.2006
//Enter the second date: 3.03.2006
//Distance: 4 days



using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class DifDays
    {
        static void Main()
        {
            Console.WriteLine("Enter date in format: d.MM.yyyy");
            string Dataread1 = Console.ReadLine();
            DateTime dataformat1 = DateTime.ParseExact(Dataread1, "d.MM.yyyy", CultureInfo.InvariantCulture);
            Console.WriteLine("Enter date in format: d.MM.yyyy");
            string Dataread2 = Console.ReadLine();
            DateTime dataformat2 = DateTime.ParseExact(Dataread2, "d.MM.yyyy", CultureInfo.InvariantCulture);
            var result = (dataformat2 - dataformat1).Days;

            Console.WriteLine("Days between them");
            Console.WriteLine(result);

        }
    }

