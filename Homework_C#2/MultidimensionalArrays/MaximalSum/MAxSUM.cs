//Problem 2. Maximal sum

//Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class MAxSUM
    {
        static void Main()
        {
            Console.WriteLine("Please, enter number to array:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter number to array:");
            int M = int.Parse(Console.ReadLine());
            int[,] ArrayN = new int[N, M];
            string inputNumber;

            if (N >= 3 && M >= 3)
            {


                for (int row = 0; row < N; row++)
                {
                    for (int column = 0; column < M; column++)
                    {
                        Console.Write("matrix[{0},{1}] = ", row, column);
                        inputNumber = Console.ReadLine();
                        ArrayN[row, column] = int.Parse(inputNumber);
                    }
                }


                int sum = 0;
                int maxSum = 0;
                int MaxIDRow = 0;
                int MaxIDCol = 0;

                for (int row = 0; row < ArrayN.GetLength(0) - 2; row++)
                {
                    for (int col = 0; col < ArrayN.GetLength(1) - 2; col++)
                    {
                        sum = ArrayN[row, col] + ArrayN[row, col + 1] + ArrayN[row, col + 2] +
                        ArrayN[row + 1, col] + ArrayN[row + 1, col + 1] + ArrayN[row + 1, col + 2] +
                        ArrayN[row + 2, col] + ArrayN[row + 2, col + 1] + ArrayN[row + 2, col + 2];

                        if (maxSum < sum)
                        {
                            maxSum = sum;
                            MaxIDRow = row;
                            MaxIDCol = col;
                        }

                    }


                }

                Console.WriteLine("{0} , {1}, {2},  {3}, {4}, {5} \n {6}, {7}, {8}", ArrayN[MaxIDRow, MaxIDCol], ArrayN[MaxIDRow, MaxIDCol + 1], ArrayN[MaxIDRow, MaxIDCol + 2],
                        ArrayN[MaxIDRow + 1, MaxIDCol], ArrayN[MaxIDRow + 1, MaxIDCol + 1], ArrayN[MaxIDRow + 1, MaxIDCol + 2],
                        ArrayN[MaxIDRow + 2, MaxIDCol], ArrayN[MaxIDRow + 2, MaxIDCol + 1], ArrayN[MaxIDRow + 2, MaxIDCol + 2]);


            }
        
        else
    {
    Console.WriteLine("Invalid value for matrix row and column");
    }
    }
}

