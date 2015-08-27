//Problem 2. Float or Double?

//Which of the following values can be assigned to a variable of type float and which to a variable of
//type double: 34.567839023, 12.345, 8923.1234857, 3456.091?
//Write a program to assign the numbers in variables and print them to ensure no precision is lost.



using System;


class DobleFloatNumber
{
    static void Main()
    {
        double DobleFloatNumber1 = 34.567839023;
        float DobleFloatNumber2 = 12.345f;
        double DobleFloatNumber3 = 8923.1234857;
        double DobleFloatNumber4 = 3456.091;    //Although float type has a 7 digit precision its safer to use double when working with 7 digit numbers.

        Console.WriteLine("Float number is: {1} \nDouble numbers are: {0}, {2}, {3}", DobleFloatNumber1, DobleFloatNumber2, DobleFloatNumber3, DobleFloatNumber4);

    }
}
