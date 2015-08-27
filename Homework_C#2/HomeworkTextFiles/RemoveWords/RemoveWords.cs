
 //Problem 12. Remove words
 //   Write a program that removes from a text file all words listed in given another text file.
 //   Handle all possible exceptions in your methods. 

using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;
class RemoveWords
{
    static void Main()
    {
        try
        {
            StringBuilder ResultBuilder = new StringBuilder();

            using (StreamReader InputReader = new StreamReader(@"../../InputFile.txt"))
            {
                using (StreamReader WordsReader = new StreamReader(@"../../WordsList.txt"))
                {
                    List<string> ListOfWords = new List<string>();
                    while (!WordsReader.EndOfStream)
                    {
                        ListOfWords.Add(WordsReader.ReadLine());
                    }
                    string CurrentMatch = "";
                    string CurrentLine = "";
                    
                    while (!InputReader.EndOfStream)
                    {
                        CurrentLine = InputReader.ReadLine();
                        foreach (var Word in ListOfWords)
                        {
                            CurrentMatch = Regex.Replace(CurrentLine, @"\b"+Word+@"\b ", string.Empty);
                            CurrentLine = CurrentMatch;
                        }
                        ResultBuilder.AppendLine(CurrentMatch);
                    }
                }
            }
            using (StreamWriter OutputWriter = new StreamWriter(@"../../Result.txt"))
            {
                OutputWriter.WriteLine(ResultBuilder);
            }
        } 
       
        catch (FileNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentOutOfRangeException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (FieldAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (DirectoryNotFoundException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (IOException ex)
        {
            Console.WriteLine(ex.Message);
        }
        catch (UnauthorizedAccessException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}