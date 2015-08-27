
 //Problem 9. Play with Int, Double and String
 //   Write a program that, depending on the user’s choice, inputs an int, double or string variable.
 //       If the variable is int or double, the program increases it by one.
 //       If the variable is a string, the program appends * at the end.
 //   Print the result at the console. Use switch statement.
 
using System;
class PlayIntDoubleString
{
    static void Main()
    {
        Console.WriteLine("Please choose a type:\n1--> int\n2--> double\n3--> string");
        int Choice = Int32.Parse(Console.ReadLine());
        switch (Choice)
        {
            case 1:
                Console.WriteLine("Please enter an integer:");
                int Value = Int32.Parse(Console.ReadLine());
                Console.WriteLine(Value + 1);
                break;
            case 2:
                Console.WriteLine("Please enter a double:");
                double DValue = double.Parse(Console.ReadLine());
                Console.WriteLine(DValue + 1);
                break;
            case 3:
                Console.WriteLine("Please enter a string:");
                string Str = Console.ReadLine();
                Console.WriteLine(Str + "*");
                break;
        }
    }
}

