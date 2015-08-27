﻿//Problem 6. Save sorted names

//Write a program that reads a text file containing a list of strings, sorts them and saves them to another text file.
//Example:

//input.txt	           output.txt
//Ivan                  George
//Peter                 Ivan 
//Maria                 Maria 
//George	            Peter 


using System;
using System.Linq;
using System.IO;
using System.Text;
using System.Collections.Generic;

class NameSort
{
    static void Main()
    {
        List<string> rezult = new List<string>();
        using (StreamReader reader = new StreamReader(@"..\..\input.txt"))
        {

           
            string line = reader.ReadLine();
            while (line != null)
            {
                rezult.Add(line);
                line = reader.ReadLine();

            }
        }
            rezult.Sort();
            using (StreamWriter writer = new StreamWriter(@"..\..\output.txt"))
            {
                foreach (var line in rezult)
                {
                    writer.WriteLine(line);
                }
                
            }
        
        Console.WriteLine("Done!");
    }
}
