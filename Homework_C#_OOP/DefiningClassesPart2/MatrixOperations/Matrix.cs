//Problem 10. Matrix operations

//Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication.
//Throw an exception when the operation cannot be performed.
//Implement the true operator (check for non-zero elements).



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixOperations
{
    class Matrix<T> where T : IComparable<T>
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
       
        public static Matrix<T> operator +(Matrix<T> left, Matrix<T> right)
        {
            if (left.WIDTH == right.WIDTH && left.HEIGHT == right.HEIGHT)
            {
                Matrix<T> resultMatrix = new Matrix<T>(left.WIDTH, left.HEIGHT);
                dynamic leftMatrix = left;
                dynamic rightMatrix = right;

                for (int i = 0; i < left.WIDTH; i++)
                {
                    for (int j = 0; j < left.HEIGHT; j++)
                    {
                        resultMatrix[i, j] = leftMatrix[i, j] + rightMatrix[i, j];
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new Exception("Matrices differ in size!");
            }
        }
       
        public static Matrix<T> operator -(Matrix<T> left, Matrix<T> right)
        {
            if (left.WIDTH == right.WIDTH && left.HEIGHT == right.HEIGHT)
            {
                Matrix<T> resultMatrix = new Matrix<T>(left.WIDTH, left.HEIGHT);
                dynamic leftMatrix = left;
                dynamic rightMatrix = right;

                for (int i = 0; i < left.WIDTH; i++)
                {
                    for (int j = 0; j < left.HEIGHT; j++)
                    {
                        resultMatrix[i, j] = leftMatrix[i, j] - rightMatrix[i, j];
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new Exception("Matrices differ in size!");
            }
        }
        
        public static Matrix<T> operator *(Matrix<T> left, Matrix<T> right)
        {
            if (left.WIDTH == right.HEIGHT)
            {
                Matrix<T> resultMatrix = new Matrix<T>(left.WIDTH, right.HEIGHT);
                dynamic leftMatrix = left;
                dynamic rightMatrix = right;

                for (int i = 0; i < resultMatrix.WIDTH; i++)
                {
                    for (int j = 0; j < resultMatrix.HEIGHT; j++)
                    {
                        for (int z = 0; z < leftMatrix.HEIGHT; z++)
                        {
                            resultMatrix[i, j] += leftMatrix[i, z] * rightMatrix[z, j];
                        }
                    }
                }
                return resultMatrix;
            }
            else
            {
                throw new Exception("Matrices differ in size!");
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
