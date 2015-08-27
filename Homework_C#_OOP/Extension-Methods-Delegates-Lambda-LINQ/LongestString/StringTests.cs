

  //Problem 17. Longest string
  //Write a program to return the string with maximum length from an array of strings.
  //Use LINQ.
 


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LongestString
{
    class StringTests
    {
        static void Main()
        {
            
            string[] stringArray = new[] { "Small", "SomeWhatLong", "TheLongestOfThemAll", "lel" };

            var allStrings = from str in stringArray 
                                orderby str.Length descending
                                select str;
            var longestString = allStrings.FirstOrDefault();
            Console.WriteLine("Longest string: {0}", string.Join(", ", longestString));
        }
    }
}
