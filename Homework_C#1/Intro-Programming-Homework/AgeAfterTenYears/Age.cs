
//Problem 15.* Age after 10 Years

//Write a program to read your birthday from the console and print how old you are now and how old you will be after 10 years.


using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



class Age
{
    static void Main()
    {
        Console.WriteLine("Enter ydour birthdate in formate \"dd.MM.yyyy\":");

        string BirthDayString = Console.ReadLine();
        DateTime BirthDay;

        while (!DateTime.TryParseExact(BirthDayString, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture, DateTimeStyles.None, out BirthDay))
        {
            Console.WriteLine("Date formate is incorrect!\nEnter date again in formate \"dd.MM.yyyy\":");
            BirthDayString = Console.ReadLine();
        }

        int age = DateTime.Now.Year - BirthDay.Year;
        if (BirthDay > DateTime.Now.AddYears(-age))
            age--;

        Console.WriteLine("Your age is {0}, after 10 years your age will be {1}", age, age + 10);


    }

    
}

