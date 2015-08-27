//Problem 3. Correct brackets

//Write a program to check if in a given expression the brackets are put correctly.
//Example of correct expression: ((a+b)/5-d). Example of incorrect expression: )(a+b)).


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class BracketTrue
    {
        static void Main()
        {
            Console.WriteLine("Enter expression:");
            string newstr = Console.ReadLine();
           
            int count1 = 0;
            int count2 = 0;
            
            string index2 = "";
            string index = "";

            for (int i = 0; i < newstr.Length; i++ )
            {
                if (newstr[i] == '(')
                {
                    count1++;
                    index = index + i;
                }

                if (newstr[i] == ')')
                {
                    count2++;
                    index2 = index2 + i;
                }

            }

            if (count1 == count2 )
            {
                for (int i = 0; i < count1-1; i++)
                    
			{               
                if (index[i] < index2[i])
                {
                    continue;
                    
                }

                else
                {
                    Console.WriteLine("Incorrect expression");
                    break;
                }
                
			}

                Console.WriteLine("Correct expression");
            }
            else 
            {
                Console.WriteLine("Incorrect expression");
            }
        }
    }

