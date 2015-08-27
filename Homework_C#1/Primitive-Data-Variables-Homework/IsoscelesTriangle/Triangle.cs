//Problem 8. Isosceles Triangle

//Write a program that prints an isosceles triangle of 9 copyright symbols ©, something like this:
//   ©

//  © ©

// ©   ©

//© © © ©

using System;


    class Triangle
    {
        static void Main()
        {
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            // The font of the console needs to be chaged to Lucida Console
            char StrangeSymbol = '\u00A9';

            Console.WriteLine("   {0}\n", StrangeSymbol);
            Console.WriteLine("  {0} {0}\n", StrangeSymbol);
            Console.WriteLine(" {0}   {0}\n", StrangeSymbol);
            Console.WriteLine("{0} {0} {0} {0}\n", StrangeSymbol);

        }
    }

