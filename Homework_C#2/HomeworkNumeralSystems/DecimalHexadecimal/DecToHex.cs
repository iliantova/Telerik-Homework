//Problem 3. Decimal to hexadecimal

//Write a program to convert decimal numbers to their hexadecimal representation.


using System;
class DecToHex
{
    static void Main()
    {
        Console.WriteLine("Enter decimal value: ");
        long DecValue = Int64.Parse(Console.ReadLine());
        string HexValue = "";
        int Reminder = 0;
        Console.Write("The hex value of {0} is: ", DecValue);
        do
        {
            Reminder = (int)DecValue % 16;
            if ((int)DecValue % 16 <= 9)
            {
                DecValue /= 16;
                HexValue += Reminder;
            }
            else
            {
                switch (Reminder)
                {
                    case 10:
                        DecValue /= 16;
                        HexValue += "A";
                        break;
                    case 11:
                        DecValue /= 16;
                        HexValue += "B";
                        break;
                    case 12:
                        DecValue /= 16;
                        HexValue += "C";
                        break;
                    case 13:
                        DecValue /= 16;
                        HexValue += "D";
                        break;
                    case 14:
                        DecValue /= 16;
                        HexValue += "E";
                        break;
                    case 15:
                        DecValue /= 16;
                        HexValue += "F";
                        break;
                }
            }
        } while (DecValue > 0);
        for (int i = HexValue.Length - 1; i >= 0; i--)
        {
            Console.Write(HexValue[i]);
        }
        Console.WriteLine();
    }
}