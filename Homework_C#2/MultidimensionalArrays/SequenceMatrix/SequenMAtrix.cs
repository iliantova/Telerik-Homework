//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbour 
//elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.
//Problem 3. Sequence n matrix

//We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets
//of several neighbour elements located on the same line, column or diagonal.
//Write a program that finds the longest sequence of equal strings in the matrix.


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class SequenMAtrix
    {
        static void Main()
        {





            Console.WriteLine("Please, enter number of row:");
            int N = int.Parse(Console.ReadLine());
            Console.WriteLine("Please, enter number of column:");
            int M = int.Parse(Console.ReadLine());
            string[,] MatrixMax = new string[N, M];
                     
                              
                    
            int Row = 0;
            int Col = 0;
            int counter = 1;
            int Maxcounter = 0;
            for (int row = 0; row < MatrixMax.GetLength(0); row++)
            {
                for (int column = 0; column < MatrixMax.GetLength(1); column++)
                {
                    Console.Write("matrix[{0},{1}] = ", row, column);
                    MatrixMax[row, column] = Console.ReadLine();
                }
            }


            for (int row = 0; row < MatrixMax.GetLength(0); row++)
            {
                for (int column = 0; column < MatrixMax.GetLength(1) -1 ; column++)
                {

                    if (MatrixMax[row, column] == MatrixMax[row, column + 1])
                    {
                        counter++;

                    }
                    else { counter = 1; }
                    if (counter > Maxcounter)
                    {

                        Maxcounter = counter;
                        Row = row;
                        Col = column;
                }
                                       
                }
                counter = 1;
            }
            for (int column = 0; column < MatrixMax.GetLength(1); column++)
            {
                for (int row = 0; row < MatrixMax.GetLength(0) - 1; row++)
                {

                    if (MatrixMax[row, column] == MatrixMax[row +1, column])
                    {
                        counter++;

                    }
                    else { counter = 1; }
                    if (counter > Maxcounter)
                    {

                        Maxcounter = counter;
                        Row = row;
                        Col = column;
                    }

                }
                counter = 1;
            }
            for (int row = 0, column = 0; row < MatrixMax.GetLength(0) - 1 && column < MatrixMax.GetLength(1) - 1; row++, column++)
                {

                    if (MatrixMax[row, column] == MatrixMax[row + 1, column + 1])
                    {
                        counter++;

                    }
                    else{ counter = 1; }
                    if (counter > Maxcounter)
                    {

                        Maxcounter = counter;
                        Row = row;
                        Col = column;
                    }

                }
                counter = 1;

                for (int row = 0, column = MatrixMax.GetLength(1)-1; row < MatrixMax.GetLength(0) - 1 && column > 0; row++, column--)
                {

                    if (MatrixMax[row, column] == MatrixMax[row +1, column -1])
                    {
                        counter++;

                    }
                    else { counter = 1; }
                    if (counter > Maxcounter)
                    {

                        Maxcounter = counter;
                        Row = row;
                        Col = column;
                    }

                }
                counter = 1;
            

            string[] result = new string[Maxcounter];
            if (Maxcounter > 1)
            {
                for (int i = 0; i < Maxcounter; i++)
                {
                    result[i] = MatrixMax[Row,Col];
                }
                Console.WriteLine(String.Join(", ", result));
            }
            else
            {
                Console.WriteLine("No repeating strings!");
            }
          
        }
    }

