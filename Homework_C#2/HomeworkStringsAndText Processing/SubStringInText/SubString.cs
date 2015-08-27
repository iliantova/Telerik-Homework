//Problem 4. Sub-string in text

//Write a program that finds how many times a sub-string is contained in a given text (perform case insensitive search).
//Example:

//The target sub-string is in

//The text is as follows: We are living in an yellow submarine. We don't have anything else. inside the submarine is very tight. So we are drinking all the day. We will move out of it in 5 days.

//The result is: 9




using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SubString
    {
        public static void test(string string1, string toFind1, ref int index)
        {
            if (string1.Length > 0)
            {
                if (string1.Contains(toFind1))
                {
                    int start = string1.IndexOf(toFind1) + toFind1.Length;
                    string1 = string1.Substring(start);
                    index++;
                    test(string1, toFind1, ref index);
                }
            }
        }

        static void Main()
        {
            Console.WriteLine("Please enter a string:");
            string string1 = Console.ReadLine();
            Console.WriteLine("Please enter a target sub-string");
            string toFind1 = Console.ReadLine(); 
            int count = 0;
            test(string1, toFind1, ref count);
            Console.WriteLine("Times a sub-string is contained in a given text:");
            Console.WriteLine(count);

        }

        
    }

