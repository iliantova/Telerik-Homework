
 //Problem 9. Matrix indexer
 //Implement an indexer this[row, col] to access the inner matrix cells.
 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixIndexer
{
    class Matrix<T> where T : IEnumerable<T>, IComparable<T>
    {
        private int matrixWidth = 0;
        private int matrixHeight = 0;
        private T[,] matrix;

        public Matrix() { }

        public Matrix(int width, int height)
        {
            this.WIDTH = width;
            this.HEIGHT = height;
            this.matrix = new T[this.WIDTH, this.HEIGHT];
        }
        
        public static void PrintMatrix(Matrix<T> source)
        {
            for (int i = 0; i < source.WIDTH; i++)
            {
                for (int j = 0; j < source.HEIGHT; j++)
                {
                    Console.Write("{0} ", source.matrix[i, j]);
                }
                Console.WriteLine();
            }
        }

        public int WIDTH
        {
            get
            {
                return this.matrixWidth;
            }
            set
            {
                this.matrixWidth = value;
            }
        }

        public int HEIGHT
        {
            get
            {
                return this.matrixHeight;
            }
            set
            {
                this.matrixHeight = value;
            }
        }

        public T this[int row, int col]
        {
            get
            {
                return this.matrix[row, col];
            }
            set
            {
                this.matrix[row, col] = value;
            }
        }
    }
}
