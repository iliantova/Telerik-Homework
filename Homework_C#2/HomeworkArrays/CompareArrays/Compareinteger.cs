
//Problem 2. Compare arrays

//Write a program that reads two integer arrays from the console and compares them element by element.



using System;



    class Compareinteger
    {
        static void Main()
        {

            bool rezult = true;
            Console.WriteLine("The number of elements in the array");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("Array:");
            int[] arr1 = new int[n];
            for (int i = 0; i < n; i++)
            {
                arr1[i] = int.Parse(Console.ReadLine());
               
            }

            Console.WriteLine("The number of elements in the array");
            int n2 = int.Parse(Console.ReadLine());
            int[] arr2 = new int[n2];
            Console.WriteLine("Array:");
            for (int i = 0; i <n2; i++)
            {
                arr2[i] = int.Parse(Console.ReadLine());
          
            }
            
           if (n != n2)
           {
              rezult = false;
           }
           else
           {

               for (int i = 0; i < n; i++)
               {

                   if (arr2[i] == arr1[i])
                   {
                      rezult = true;

                   }

                   else
                   {

                      rezult = false;
                   
                   }

               }

           }
           Console.WriteLine("Are arrays equal:");
           Console.WriteLine(rezult);
        }
    }

