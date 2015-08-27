
//Problem 1. Allocate array

//Write a program that allocates array of 20 integers and initializes each element by its index multiplied by 5.
//Print the obtained array on the console.


using System;



    class ArrayTwenty
    {
        static void Main()
        {

            int[] NewArray = new int[20];
            for (int i = 0; i < 20; i++)
            {

                NewArray[i] = i * 5;
                 
            
            }
            
                Console.Write(string.Join(",", NewArray));
                Console.WriteLine();
                    
            }
    }

