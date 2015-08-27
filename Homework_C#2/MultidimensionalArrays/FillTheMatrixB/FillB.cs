//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//B

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class FillB
{
    static void Main()
    {
        Console.WriteLine("Please, enter number to array:");
        int N = int.Parse(Console.ReadLine());
        int[,] ArrayN = new int[N, N];


        for (int col = 0; col < N; col++)
        {
            if (col % 2 == 0)
            {
                for (int row = 0; row < N; row++)
                {
                    ArrayN[row, col] = col* N + row + 1;
                    

                  }
            }
            else
            {
                for (int row = 0; row < N; row++)
                {

                    ArrayN[row, col] = (col + 1) * N - row;

                  }

            }

        }

        for (int i = 0; i < N; i++)
        {
            for (int j = 0; j < N; j++)
            {
                Console.Write("{0,5}", ArrayN[i, j]);
            }
            Console.WriteLine();
                        
        }
     }
}

