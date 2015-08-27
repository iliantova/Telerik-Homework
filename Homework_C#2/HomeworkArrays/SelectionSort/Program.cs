//Problem 7. Selection sort

//Sorting an array means to arrange its elements in increasing order. Write a program to sort an array.
//Use the Selection sort algorithm: Find the smallest element, move it at the first position, find the smallest from the rest, move it at the second position, etc.



using System;
using System.Collections.Generic;
using System.Linq;




    class Program
    {
        static void Main()
        {



            int[] numbersInLine = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries)
        .Select(x => int.Parse(x)).ToArray();

            int i, j;
            int iMin;

          
            for (j = 0; j < numbersInLine.Length - 1; j++)
            {
               
                iMin = j;
              
                for (i = j + 1; i < numbersInLine.Length; i++)
                {
                 
                    if (numbersInLine[i] < numbersInLine[iMin])
                    {
                       
                        iMin = i;
                    }
                }

                if (iMin != j)
                {
                    
                    
                   
	                int temp = numbersInLine[j];
	                numbersInLine[j] = numbersInLine[iMin];
                    numbersInLine[iMin] = temp;

                    }

            }


            string New = "";

            for (int index = 0; index < numbersInLine.Length; index++)
            {

            New = string.Join(", ", numbersInLine);
           
            }

            Console.WriteLine(New);

            }
        
         
        
    }

