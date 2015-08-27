//Problem 6. Four-Digit Number

//Write a program that takes as input a four-digit number in format abcd (e.g. 2011) and performs the following:
//Calculates the sum of the digits (in our example 2 + 0 + 1 + 1 = 4).
//Prints on the console the number in reversed order: dcba (in our example 1102).
//Puts the last digit in the first position: dabc (in our example 1201).
//Exchanges the second and the third digits: acbd (in our example 2101).
//The number has always exactly 4 digits and cannot start with 0.

using System;
class ArrayNumber
{
    static void Main()
    {

        char[] array = new char[4];

        for (int i = 0; i < 4; i++)
        {
            array[i] = (char)(Console.Read());
        }

        char[] reversed = new char[4];
        for (int i = 0; i < 4; i++)
        {
            reversed[4 - i - 1] = array[i];
        }

        Console.WriteLine(reversed);


        char[] FirstToLast = new char[4];

        FirstToLast[0] = array[3];
        FirstToLast[1] = array[0];
        FirstToLast[2] = array[1];
        FirstToLast[3] = array[2];
        Console.WriteLine(FirstToLast);

        char[] SecondThird = new char[4];
        SecondThird[0] = array[0];
        SecondThird[1] = array[2];
        SecondThird[2] = array[1];
        SecondThird[3] = array[3];
        Console.WriteLine(SecondThird);


        int Sumarray = new int();
        int val1 = (int)Char.GetNumericValue(array[0]);
        int val2 = (int)Char.GetNumericValue(array[1]);
        int val3 = (int)Char.GetNumericValue(array[2]);
        int val4 = (int)Char.GetNumericValue(array[3]);
        Sumarray = val1 + val2 + val3 + val4;
        Console.WriteLine(Sumarray);


    }
}
