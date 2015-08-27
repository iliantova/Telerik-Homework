//Problem 13. Reverse sentence

//Write a program that reverses the words in given sentence.
//Example:

//input	output
//C# is not C++, not PHP and not Delphi!


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReverseSentence
{
    class ReverseString
    {
        static void Main()
        {

            Console.WriteLine("Please enter a text:");
            string InputText = Console.ReadLine();
            char End = InputText[InputText.Length - 1];
            string Str = InputText.Substring(0, InputText.Length - 1);
            List<string> InputList = Str.Split(new char[] { ' ' }).ToList();
            InputList.Reverse();
            foreach (var Word in InputList)
            {
                Console.Write("{0} ", Word);
            }
            Console.Write(End);
            Console.WriteLine();


        }
    }
}
