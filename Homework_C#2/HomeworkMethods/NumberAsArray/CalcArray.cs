//Problem 8. Number as array

//Write a method that adds two positive integer numbers represented as arrays of digits (each array element arr[i]
//contains a digit; the last digit is kept in arr[0]).
//Each of the numbers that will be added could have up to 10 000 digits.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class CalcArray
    {


        static int[] CalcSumInt(int Number1, int Number2)
        {
            if (Number1 < Number2)
            {
                return CalcSumInt(Number2, Number1);
            }

            int[] FirstArray = Number1.ToString().ToCharArray().Reverse().Select(x => (int)Char.GetNumericValue(x)).ToArray();
            int[] SecondArray = Number2.ToString().ToCharArray().Reverse().Select(x => (int)Char.GetNumericValue(x)).ToArray();

            int[] ResultArray = new int[FirstArray.Length+1];

            int addReminder = 0;
            int add = 0;
            for (int i = 0; i < FirstArray.Length; i++)
            {
                
                if (i < SecondArray.Length)
                {
                    add = FirstArray[i] + SecondArray[i];
                }
              
                else
                {
                    add = FirstArray[i];
                }
               
                if (add > 9 && (i + 1) < FirstArray.Length)
                {
                    addReminder = add % 10;
                    ResultArray[i] += addReminder;
                    ResultArray[i + 1] += 1;

                }
                else
                {
                    add = ResultArray[i] += add;
                    if (add > 9)
                    {
                        addReminder = add % 10;
                        ResultArray[i] = addReminder;
                        ResultArray[i + 1] += 1;
                    }
                }
            }
            if (ResultArray[FirstArray.Length] == 0)
            {
                int[] Result = new int[FirstArray.Length];
                for (int i = 0; i < FirstArray.Length; i++)
                {
                    Result[i] = ResultArray[i];
                }
                return Result;
            }
            else
            {
                return ResultArray;
            }


        }

        private static void Print(int[] Arr)
        {
            for (int i = Arr.Length - 1; i >= 0; i--)
            {
                Console.Write("{0}", Arr[i]);
            }
            Console.WriteLine();
        }

        static void Main()
        {
            Console.WriteLine("Enter first value: ");
            int Number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter second value: ");
            int Number2 = int.Parse(Console.ReadLine());
            Console.WriteLine("The result is: ");
            Print(CalcSumInt(Number1, Number2));
        }
    }

