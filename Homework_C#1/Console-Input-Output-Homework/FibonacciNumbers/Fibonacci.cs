//Problem 10. Fibonacci Numbers

//Write a program that reads a number n and prints on the console the first n members of the Fibonacci sequence (at a single line, separated by comma and space - ,) : 0, 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89, 144, 233, ….
//Note: You may need to learn how to use loops.


using System;


class Fibonacci
{
    static void Main()
    {

        Console.WriteLine("Write a value for n");
        int n = int.Parse(Console.ReadLine());
        int result = 0;
        int y = 0;
        int New = 1;
        int New2 = 1;
        if (n <= 3)
        {
            if (n == 1)
            {
                Console.WriteLine(0);
            }
            else if (n == 2)
            {
                Console.WriteLine("0 1");
            }
            else if (n == 3)
            {
                Console.WriteLine("0 1 1");
            }
        }
        else
        {
            Console.Write("0 1 1 ");
            do
            {

                result = New + New2;
                Console.Write("{0} ", result);
                New = New2;
                New2 = result;

                y++;
            } while (y < n - 3);
        }
    }
}

