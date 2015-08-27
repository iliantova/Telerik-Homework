
//Problem 1. Say Hello

//Write a method that asks the user for his name and prints “Hello, <name>”
//Write a program to test this method.
//Example:

//input	output
//Peter	Hello, Peter!


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Hello
    {
        static void Nameconsol(string inputName)
        {
            Console.WriteLine("Hello, {0}", inputName);
        }

      
        static void Main()
        {

            Console.Write("Enter name: ");
            string inputName = (Console.ReadLine());
            Nameconsol(inputName);
           

        }
    }

