﻿//Problem 14.* Print the ASCII Table

//Find online more information about ASCII (American Standard Code for Information Interchange) and write a program
//that prints the entire ASCII table of characters on the console (characters from 0 to 255).
//Note: Some characters have a special purpose and will not be displayed as expected. You may skip them or display them differently.

//Note: You may need to use for-loops (learn in Internet how).

using System;



    class ASCII
    {
        static void Main()
        {


            for (int  Number= 0; Number <= 255; Number++)
            {
                char SymbolASCII = (char) Number;
                Console.WriteLine("For number {0} symbol is {1}", Number, SymbolASCII);
            }

        }
    }

