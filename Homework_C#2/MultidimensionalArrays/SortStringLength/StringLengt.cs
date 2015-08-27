//Problem 5. Sort by string length

//You are given an array of strings. Write a method that sorts the array by the length of its elements (the number of characters composing them).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class StringLengt

      {
        static void Main(string[] args)
        {

            Console.WriteLine("Please, enter array:");
            string[] StringLeng = Console.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

            var Sortedstring = StringLeng.OrderBy(sort => sort.Length);

            foreach (var sort in Sortedstring)
                Console.WriteLine(sort);
            Console.WriteLine();

         }
    }

