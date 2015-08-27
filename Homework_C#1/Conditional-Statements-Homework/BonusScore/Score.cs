
//Problem 2. Bonus Score

//Write a program that applies bonus score to given score in the range [1…9] by the following rules:
//If the score is between 1 and 3, the program multiplies it by 10.
//If the score is between 4 and 6, the program multiplies it by 100.
//If the score is between 7 and 9, the program multiplies it by 1000.
//If the score is 0 or more than 9, the program prints “invalid score”.

using System;


namespace BonusScore
{
    class Score
    {
        static void Main()
        {
            Console.WriteLine("Write a value for n between 1 and 9");
            int n = int.Parse(Console.ReadLine());
             if ( n >= 1 && n <= 3)
            {
                Console.WriteLine(n*10);
            }
             else if (n >= 4 && n <= 6)
             {
                 Console.WriteLine(n * 100);
             }
             else if (n >= 7 && n <= 9)
             {
                 Console.WriteLine(n * 1000);
             }
             else
             {
                 Console.WriteLine("invalid score");
             }

            }
    }
}
