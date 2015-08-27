//Problem 2. Random numbers

//Write a program that generates and prints to the console 10 random values in the range [100, 200].


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class RandomNum
    {
        static void Main()
        {

            Random rnd = new Random();
            int numberRan = 0;
            int[] NRan = new int[10];
            for (int i = 0; i < 10; i++)
            {
               numberRan = rnd.Next(100, 201);
               NRan[i] = numberRan;
            }


            Console.WriteLine(string.Join(",",NRan));
        }
    }

