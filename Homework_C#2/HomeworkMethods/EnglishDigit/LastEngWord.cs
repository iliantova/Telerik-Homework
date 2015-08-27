//Problem 3. English digit

//Write a method that returns the last digit of given integer as an English word.
//Examples:

//input	output
//512	     two
//1024	four
//12309	nine


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class LastEngWord
    {
        static string Englishdigits(int numberChek)
        {
            int lastDigits = numberChek % 10;
            string word = "";
            switch (lastDigits)
            {
                case 0:  word = "zero"; break;
                case 1:  word = "one";  break;
                case 2:  word = "two";  break;
                case 3:  word = "tree"; break;
                case 4:  word = "four"; break;
                case 5:  word = "five"; break;
                case 6:  word = "six";  break;
                case 7:  word = "seven"; break;
                case 8:  word = "eight"; break;
                case 9:  word = "nine"; break;
            }

            return word;
        }


        static void Main()
        {
            Console.Write("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine("Last digit is: {0}", Englishdigits(number));
                       
        }
    }

