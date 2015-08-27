
//Problem 4. Print a Deck of 52 Cards

//Write a program that generates and prints all possible cards from a standard deck of 52 cards (without the jokers). The cards should
//be printed using the classical notation (like 5 of spades, A of hearts, 9 of clubs; and K of diamonds).
//The card faces should start from 2 to A.
//Print each card face in its four possible suits: clubs, diamonds, hearts and spades. Use 2 nested for-loops and a switch-case statement.


using System;
class PrintADeck
{
    static void Main()
    {
        for (int i = 2; i < 15; i++)
        {
           
            for (int j = 0; j < 4; j++)
            {
                
                switch (j)
                {
                    case 0:
                     if (i > 10)
                        {
                            if (i == 11)
                            {
                                Console.Write("J of spades, ");
                            }
                            if (i == 12)
                            {
                                Console.Write("Q of spades, ");
                            }
                            if (i == 13)
                            {
                                Console.Write("K of spades, ");
                            }
                            if (i == 14)
                            {
                                Console.Write("A of spades, ");
                            }
                        }
                        else
                        {
                            Console.Write("{0} of spades, ", i);
                        }
                        break;
                    case 1:
                        if (i > 10)
                        {
                            if (i == 11)
                            {
                                Console.Write("J of clubs, ");
                            }
                            if (i == 12)
                            {
                                Console.Write("Q of clubs, ");
                            }
                            if (i == 13)
                            {
                                Console.Write("K of clubs, ");
                            }
                            if (i == 14)
                            {
                                Console.Write("A of clubs, ");
                            }
                        }
                        else
                        {
                            Console.Write("{0} of clubs, ", i);
                        }
                        break;
                    case 2:
                        if (i > 10)
                        {
                            if (i == 11)
                            {
                                Console.Write("J of hearts, ");
                            }
                            if (i == 12)
                            {
                                Console.Write("Q of hearts, ");
                            }
                            if (i == 13)
                            {
                                Console.Write("K of hearts, ");
                            }
                            if (i == 14)
                            {
                                Console.Write("A of hearts, ");
                            }
                        }
                        else
                        {
                            Console.Write("{0} of hearts, ", i);
                        }
                        break;
                    case 3:
                        if (i > 10)
                        {
                            if (i == 11)
                            {
                                Console.Write("J of diamonds");
                            }
                            if (i == 12)
                            {
                                Console.Write("Q of diamonds");
                            }
                            if (i == 13)
                            {
                                Console.Write("K of diamonds");
                            }
                            if (i == 14)
                            {
                                Console.Write("A of diamonds");
                            }
                        }
                        else
                        {
                            Console.Write("{0} of diamonds", i);
                        }
                        break;
                }
            }
            Console.WriteLine();
        }
    }
}

