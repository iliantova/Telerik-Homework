
//Problem 6. Strings and Objects

//Declare two string variables and assign them with Hello and World.
//Declare an object variable and assign it with the concatenation of the first two variables (mind adding an interval between).
//Declare a third string variable and initialize it with the value of the object variable (you should perform type casting).



using System;



class StringValue
{
    static void Main()
    {

        string StringHello = "Hello";
        string StringWorld = "World";

        Object obj = new Object();
        obj = StringHello + " " + StringWorld;
        string StringHelloWorld = (string)obj;

        Console.WriteLine(StringHelloWorld);

    }
}

