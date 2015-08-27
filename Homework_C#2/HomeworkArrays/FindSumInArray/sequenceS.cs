
//Problem 10. Find sum in array

//Write a program that finds in given array of integers a sequence of given sum S (if present).
//Example:

//array	                          S	                        result
//4, 3, 1, 4, 2, 5, 8	              11	                    4, 2, 5


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



    class sequenceS
    {
        static void Main()
        {
            Console.WriteLine("Please, enter array:");
            int[] numbersInLine = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();

            Console.WriteLine("Please, enter sum:");
            int SumN = int.Parse(Console.ReadLine());

       
            int startIndex = 0;
            int endIndex = 0;
            int curentSum = 0;
            int counter = 0;
            bool Sumtrue = false; 
       
            for (int i = 0; i < numbersInLine.Length -1; i++)
            {

                curentSum = curentSum + numbersInLine[i];
                
                if (curentSum<SumN)
                {
                    counter++;
                   
                }
                      

               else if (curentSum == SumN)
                {
                    startIndex = i- counter;
                    endIndex = i;
                    Sumtrue = true;
                    break;

                }

               else  if (curentSum > SumN)
                {
                    
                    
                    curentSum = 0;
                   i-=counter;
                   counter = 0;
                }

                
            }

            if (Sumtrue)
            {
                for (int j = startIndex; j <= endIndex; j++)
                {

                    Console.Write("{0}, ", numbersInLine[j]);

                }
            }
            else 
            {
                Console.WriteLine("The sum isn't present in the array.");
            }
        }
    }

