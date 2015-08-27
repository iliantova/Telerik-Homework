//Problem 12. Null Values Arithmetic

//Create a program that assigns null values to an integer and to a double variable.
//Try to print these variables at the console.
//Try to add some number or the null literal to these variables and print the result.


using System;



class NullValue
{
    static void Main()
    {
        int? intNullValue = null;
        Console.WriteLine("This is integer with Null value:" + intNullValue);

        intNullValue = 9;
        Console.WriteLine("This is integer with value 9 : " + intNullValue);


        double? doubleNullValue = null;
        Console.WriteLine("This is double with Null value:" + doubleNullValue);

        doubleNullValue = 1.2222;
        Console.WriteLine("This is double with value 1.2222:  " + doubleNullValue);

    }
}
