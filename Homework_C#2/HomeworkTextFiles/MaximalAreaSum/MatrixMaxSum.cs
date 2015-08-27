//Problem 5. Maximal area sum

//Write a program that reads a text file containing a square matrix of numbers.
//Find an area of size 2 x 2 in the matrix, with a maximal sum of its elements.
//The first line in the input file contains the size of matrix N.
//Each of the next N lines contain N numbers separated by space.
//The output should be a single number in a separate text file.
//Example:

//input	output
//4 
//2 3 3 4 
//0 2 3 4 
//3 7 1 2 
//4 3 3 2	17


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MaximalAreaSum
{
    class MatrixMaxSum
    {
        static int MaxSum (int size, int[,] matrix)
        {
            int maximalSum = 0;
            int sum = 0;

            for (int i = 0; i < size -1; i++)
            {
                for (int j = 0; j < size-1; j++)
                {
                    sum = matrix[i, j] + matrix[i, j + 1] + matrix[i + 1, j] + matrix[i + 1, j + 1];
                    if (sum > maximalSum)
                    {
                        maximalSum = sum;
                    }

                }
            }
            
            return maximalSum;
        }

        static void Main()
        {
            using (StreamReader reader = new StreamReader(@"..\..\text.txt"))
            {
                int size = Int32.Parse(reader.ReadLine());
                int[,] matrix = new int[size, size];
             
                
                for (int row = 0; row < size; row++)
                {
                    string[] inputNumber = reader.ReadLine()
        .Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries);

                    for (int column = 0; column < size; column++)
                    {
                       
                            matrix[row, column] = Int32.Parse(inputNumber[column]);
                       
                        
                    }
                }

                int rezult = MaxSum(size, matrix);
                Console.WriteLine(rezult);
            }

            
        }
    }
}
