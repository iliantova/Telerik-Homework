
 //Problem 13. Count words
 //   Write a program that reads a list of words from the file words.txt and finds how many times each of the words is contained in another file test.txt.
 //   The result should be written in the file result.txt and the words should be sorted by the number of their occurrences in descending order.
 //   Handle all possible exceptions in your methods. 
 
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
using System.Linq;

namespace CountWords
{
    class CountWords
    {
        static void Main()
        {
            try
            {
                StringBuilder ResultBuilder = new StringBuilder();
                StringBuilder builder = new StringBuilder();
                builder.Append(File.ReadAllText("..//..//test.txt"));

                
                string Text = builder.ToString();
                string[] TextSource = Text.Split(new char[] { '.', '?', '!', ' ', ';', ':', ',' }, StringSplitOptions.RemoveEmptyEntries);
                var ListOfWords = new List<WordCount>();

              
                using (StreamReader WordsReader = new StreamReader("..//..//words.txt"))
                {
                    while (!WordsReader.EndOfStream)
                    {
                       
                        ListOfWords.Add(new WordCount(0, WordsReader.ReadLine()));
                    }
                    for (int i = 0; i < ListOfWords.Count; i++)
                    {
                       
                        var matchQuery = from word in TextSource
                                         where word == ListOfWords[i].Word
                                         select word;
                        ListOfWords[i].Counter += matchQuery.Count();
                    }
                }

           
                ListOfWords = (from word in ListOfWords
                               orderby word.Counter descending
                               select word).ToList();

        
                foreach (var word in ListOfWords)
                {
                    ResultBuilder.AppendLine(word.Word + " - " + word.Counter + " times.");
                }
                using (StreamWriter OutputWriter = new StreamWriter("..//..//result.txt"))
                {
                    OutputWriter.WriteLine(ResultBuilder);
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (DirectoryNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (PathTooLongException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (FileNotFoundException ex)
            {
                Console.WriteLine(ex.Message);
            }
        }
    }

}