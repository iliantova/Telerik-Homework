
 //Problem 4. Multiplication Sign
 //Write a program that shows the sign (+, - or 0) 
 //of the product of three real numbers, without calculating it.
 //Use a sequence of if operators. 
 
using System;
class MultiplicationSign
{
    static void Main()
    {
        Console.WriteLine("Enter 1st value:");
        double FirstValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 2nd value:");
        double SecondValue = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter 3rd value:");
        double ThirdValue = double.Parse(Console.ReadLine());

        if (FirstValue > 0 && SecondValue > 0 && ThirdValue > 0)
        {
            Console.WriteLine("+");
        }
        else if (FirstValue == 0 || SecondValue == 0 || ThirdValue == 0)
        {
            Console.WriteLine("0");
        }
        else if (FirstValue < 0 && SecondValue < 0 && ThirdValue < 0)
        {
            Console.WriteLine("-");
        }
        else if (FirstValue < 0 && SecondValue < 0 && ThirdValue > 0)
        {
            Console.WriteLine("+");
        }
        else if (FirstValue < 0 && ThirdValue < 0 && SecondValue > 0)
        {
            Console.WriteLine("+");
        }
        else if (SecondValue < 0 && ThirdValue < 0 && FirstValue > 0)
        {
            Console.WriteLine("+");
        }
        else if (FirstValue < 0 && SecondValue > 0 && ThirdValue > 0)
        {
            Console.WriteLine("-");
        }
        else if (FirstValue > 0 && ThirdValue > 0 && SecondValue < 0)
        {
            Console.WriteLine("-");
        }
        else if (SecondValue > 0 && ThirdValue < 0 && FirstValue > 0)
        {
            Console.WriteLine("-");
        }

    }
}

