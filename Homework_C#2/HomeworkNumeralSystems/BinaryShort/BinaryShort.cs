
 //Problem 8. Binary short
 //Write a program that shows the binary 
 //of given 16-bit signed integer number (the C# type short). 
 
using System;
class BinaryShort
{
    public static string ShortToBin(short Value)
    {
        
        short Reminder = 0;
        
        string result = "";
        do
        {
            
            Reminder = (short)(Value % 2);
           
            Value /= 2;
            
            result += Reminder;
           
        } while (Value > 0.5M);

        char[] Arr = result.ToCharArray();
        Array.Reverse(Arr);
        return new string(Arr);
    }
    static void Main()
    {
        Console.WriteLine("Enter a signed short:");
        short ShortValue = short.Parse(Console.ReadLine());
        string result = "";
        if (ShortValue < 0)
            result = "1" + ShortToBin((short)(32768 + ShortValue)).PadLeft(15, '0');
        else
            result = ShortToBin(ShortValue).PadLeft(16, '0');
        Console.WriteLine(result);
    }
}