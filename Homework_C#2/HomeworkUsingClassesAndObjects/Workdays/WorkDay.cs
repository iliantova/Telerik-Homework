//Problem 5. Workdays

//Write a method that calculates the number of workdays between today and given date, passed as parameter.
//Consider that workdays are all days from Monday to Friday except a fixed list of public holidays specified preliminary as array.



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class WorkDay
{
    public static bool IsHoliday(DateTime date)
    {
       
        DateTime[] holidays =
        new DateTime[] { 
      new DateTime(2015,01,01),
      new DateTime(2015,03,02),
      new DateTime(2015,03,03),
      new DateTime(2015,04,10),
      new DateTime(2015,04,11),
      new DateTime(2015,04,12),
      new DateTime(2015,04,13),
      new DateTime(2015,05,01),
      new DateTime(2015,05,06),
      new DateTime(2015,09,21 ),
      new DateTime(2015,09,22),
      new DateTime(2015,12,24),
      new DateTime(2015,12,25),
      new DateTime(2015,12,26),
      new DateTime(2015,12,31)
      };

        return holidays.Contains(date.Date);
    }

    public static int AddWorkDays(DateTime date)
    {

        var content = (date.Date - DateTime.Today).Days;
        DateTime newDate = DateTime.Today;
        int count = 0;
        while (content != 0)
        {
            newDate = newDate.AddDays(1);
            if (newDate.DayOfWeek != DayOfWeek.Saturday &&
                newDate.DayOfWeek != DayOfWeek.Sunday &&
                !IsHoliday(newDate))
            {
                count++;

            }

            content--;
        }
        return count;

    }

    static void Main()
    {
        Console.WriteLine("Please enter date in format yyyy.mm.dd:");
        DateTime WorkDay = DateTime.Parse(Console.ReadLine());
        int countDay = AddWorkDays(WorkDay);
        Console.WriteLine("Workdays are:");
        Console.WriteLine(countDay);

    }
}

