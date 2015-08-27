﻿//Problem 4. Compare text files

//Write a program that compares two text files line by line and prints the number of lines that are 
//the same and the number of lines that are different.
//Assume the files have equal number of lines.

using System;
using System.IO;

class CompTextFiles
{
    static void Main()
    {
        int sameLines = 0;
        int differentLines = 0;

        using (StreamReader firstReader = new StreamReader(@"..\..\firstText.txt"))
        {
            string firstTextLine = firstReader.ReadLine();

            using (StreamReader secondReader = new StreamReader(@"..\..\secondText.txt"))
            {
                string secondTextLine = secondReader.ReadLine();


                while (firstTextLine != null && secondTextLine != null)
                {
                    if (firstTextLine == secondTextLine)
                    {
                        sameLines++;
                    }
                    else
                    {
                        differentLines++;
                    }

                    firstTextLine = firstReader.ReadLine();
                    secondTextLine = secondReader.ReadLine();
                }

                while (firstTextLine != null || secondTextLine != null)
                {
                    differentLines++;
                    firstTextLine = firstReader.ReadLine();
                    secondTextLine = secondReader.ReadLine();
                }

            }
        }

        Console.WriteLine("Same lines: {0}", sameLines);
        Console.WriteLine("Different lines: {0}", differentLines);
    }
}