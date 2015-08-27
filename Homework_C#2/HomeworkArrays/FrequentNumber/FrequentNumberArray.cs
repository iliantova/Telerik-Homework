//Problem 9. Frequent number

//Write a program that finds the most frequent number in an array.
//Example:

//input	                                      result
//4, 1, 1, 4, 2, 3, 4, 4, 1, 2, 4, 9, 3    	4 (5 times)



using System;
using System.Collections.Generic;
using System.Linq;


    class FrequentNumberArray
    {
        static void Main()
        {

            Console.WriteLine("Please, enter array:");
            int[] numbersInLine = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();

            int maxValue = int.MinValue;
            int count = 0;
            int maxCount =0;
            int rezult = 0;

            for (int i = 0; i < numbersInLine.Length; i++)

                {
                maxValue = numbersInLine[i];
                count = 0;

                for (int j = 0; j < numbersInLine.Length; j++)
                {

                    if (maxValue == numbersInLine[j] )
                    {
                        count++;

                        if (count > maxCount)
                        {
                            maxCount = count;
                            rezult = numbersInLine[i];
                        }
                    }
                    
                                       
                }
            }
            Console.WriteLine("Number is {0} ({1} times)", rezult, maxCount);
        }
        
      
        }  

