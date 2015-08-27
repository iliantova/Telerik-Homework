//Problem 12. Index of letters

//Write a program that creates an array containing all letters from the alphabet (A-Z).
//Read a word from the console and print the index of each of its letters in the array.

using System;


    class IndexLetterView
    {
        static void Main()
        {


            string word = Console.ReadLine();
            char[] charAZ = new char[26];

            for (int i = 0; i < 25; i++)
            {
               
               int unicode = 65 + i;
               char character = (char) unicode;
                charAZ[i] = character;

            }

            foreach (char symbol in word)

            {

                for (int i = 0; i < 25; i++)
                {
                    if (charAZ[i] == symbol)
                    {
                        Console.WriteLine("Symbol {0} is in array of index {1}", symbol,i);
                    }

                }
                   
            
            }

             }
    }

