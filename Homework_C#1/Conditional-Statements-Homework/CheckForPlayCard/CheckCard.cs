//Problem 3. Check for a Play Card

//Classical play cards use the following signs to designate the card face: `2, 3, 4, 5, 6, 7, 8, 9, 10, J, Q, K and A.
//Write a program that enters a string and prints “yes” if it is a valid card sign or “no” otherwise


using System;

class CheckCard
{
    static void Main()
    {
        Console.WriteLine("Write a value:");
        string input = Console.ReadLine();
        int d = 0;

        if (Int32.TryParse(input, out d))
        {
            if (d >= 2 && d <= 10)
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }
        else
        {
            if (input.Equals("J") || input.Equals("Q") || input.Equals("K") || input.Equals("A"))
            {
                Console.WriteLine("yes");
            }
            else Console.WriteLine("no");
        }

    }
}

