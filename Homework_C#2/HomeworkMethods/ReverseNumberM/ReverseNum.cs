//Problem 7. Reverse number

//Write a method that reverses the digits of given decimal number.
//Example:

//input	output
//256	    652
//123.45	54.321



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ReverseNum
    {
        static decimal Reverse(decimal name)
        {
            string stringRev = name.ToString();
            string reverseStr = "";
            char[] array = stringRev.ToCharArray();
            for (int i = array.Length-1; i > - 1; i--)
            {
                reverseStr += array[i];

            }
            return decimal.Parse(reverseStr);
        }
        

        static void Main()
        {
            Console.Write("Please, enter a number(integer or decimal): ");
            decimal number = decimal.Parse(Console.ReadLine());
            decimal reversed = Reverse(number);
            Console.WriteLine("Reversed number is {0}", reversed);
            

        }
    }

