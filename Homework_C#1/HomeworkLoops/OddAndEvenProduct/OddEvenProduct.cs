
 //Problem 10. Odd and Even Product
 //You are given n integers (given in a single line, separated by a space).
 //Write a program that checks whether the product of the odd elements is 
 //equal to the product of the even elements.
 //Elements are counted from 1 to n, so the first element is odd, the second is even, etc. 
 
using System;
class OddEvenProduct
{
    static void Main()
    {
        Console.WriteLine("Enter numbers:");
        string Input = Console.ReadLine();
        string[] Numbers = Input.Split(' ');
        int CurrentNum = 0;
        int Odd = 1;
        int Even = 1;
        for (int i = 0; i < Numbers.Length; i++)
        {
            if (Int32.TryParse(Numbers[i], out CurrentNum))
            {
                if (i % 2 == 0)
                {
                    Even *= CurrentNum;
                }
                else
                {
                    Odd *= CurrentNum;
                }
            }
        }
        Console.Write("Odd product= {0}, Even product= {1} | ", Odd, Even);
        if (Even == Odd)
        {
            Console.WriteLine("YES");
        }
        else
        {
            Console.WriteLine("NO");
        }
    }
}



