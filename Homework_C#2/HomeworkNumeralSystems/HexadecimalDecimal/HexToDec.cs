﻿//Problem 4. Hexadecimal to decimal

//Write a program to convert hexadecimal numbers to their decimal representation.


using System;
class HexToDec
{
    static void Main()
    {
        Console.WriteLine("Enter hex value (using capital letter only): ");
        string HexValue = Console.ReadLine();

        long DecValue = 0;
        string TempString = "";
        int TempNum = 0;
        int PositionFlag = 0;

        for (int i = HexValue.Length - 1; i >= 0; i--)
        {
            if (Int32.TryParse(HexValue[i].ToString(), out TempNum))
            {
                DecValue += TempNum * (1 << (4 * PositionFlag));
            }
            else
            {
                TempString = HexValue[i].ToString();
                switch (TempString)
                {
                    case "A":
                        DecValue += 10 * (1 << (4 * PositionFlag));
                        break;
                    case "B":
                        DecValue += 11 * (1 << (4 * PositionFlag));
                        break;
                    case "C":
                        DecValue += 12 * (1 << (4 * PositionFlag));
                        break;
                    case "D":
                        DecValue += 13 * (1 << (4 * PositionFlag));
                        break;
                    case "E":
                        DecValue += 14 * (1 << (4 * PositionFlag));
                        break;
                    case "F":
                        DecValue += 15 * (1 << (4 * PositionFlag));
                        break;
                }
            }
            PositionFlag++;
        }
        Console.WriteLine(DecValue);
    }
}