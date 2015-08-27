//Problem 1. Fill the matrix

//Write a program that fills and prints a matrix of size (n, n) as shown below:
//Example for n=4:
//C

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FillTheMatrixC
{
    class FillC
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Please, enter number to array:");
            int n = int.Parse(Console.ReadLine());
            int[,] matrix = new int[n, n];


            int i = 1;
            for (int row = n - 1; i <= n * n; row--) //up-right
            {
                if (row >= 0)
                {
                    for (int col = 0, nextRow = row; col < n - row; col++, nextRow++) //right-down
                    {
                        matrix[nextRow, col] = i++;
                    }
                }
                else
                {
                    for (int col = -row, nextRow = 0; col < n; col++, nextRow++) //second half right-down
                    {
                        matrix[nextRow, col] = i++;
                    }

                }
            }


            for (int k = 0; k < n; k++)
            {
                for (int j = 0; j < n; j++)
                {
                    Console.Write("{0,5}", matrix[k, j]);
                }
                Console.WriteLine();
            }

        }
    }
}
