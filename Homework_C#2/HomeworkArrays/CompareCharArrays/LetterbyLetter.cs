
//Problem 3. Compare char arrays

//Write a program that compares two char arrays lexicographically (letter by letter).


using System;



    class LetterbyLetter
    {
        static void Main()
        {
            Console.WriteLine("Please, enter first array:");
            string readstring = Console.ReadLine();
            char[] array1 = readstring.ToCharArray();

            Console.WriteLine("Please, enter second array:");
            string readstring2 = Console.ReadLine();
            char[] array2 = readstring2.ToCharArray();

            bool rezult = true;

            if (array1.Length != array2.Length)
            
            {
                rezult = false;
                Console.WriteLine(rezult);
              } 

               
            else 
            
            {
                for (int i = 0; i < array1.Length - 1; i++)
                {

                    if (array1[i] != array2[i])
                    {
                        rezult = false;
                    }

                    else
                    {
                        rezult = true;
                    }
                                        
                }
                Console.WriteLine("Are the arrays equal:");
                Console.WriteLine(rezult);


            }  
            
        }
    }

