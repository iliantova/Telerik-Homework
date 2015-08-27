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
    class MatrixOperationMain
    {
        static void Main()
        {
            Matrix<int> m1 = new Matrix<int>(2, 2);
            Matrix<int> m2 = new Matrix<int>(2, 2);
            m1[0, 0] = 1;
            m1[0, 1] = 2;
            m1[1, 0] = 3;
            m1[1, 1] = 4;

            m2[0, 0] = 1;
            m2[0, 1] = 2;
            m2[1, 0] = 3;
            m2[1, 1] = 4;

            Matrix<int> m3 = new Matrix<int>();
            Console.WriteLine("First matrix:");
            Matrix<int>.PrintMatrix(m1);
            Console.WriteLine("Second matrix:");
            Matrix<int>.PrintMatrix(m2);
            Console.WriteLine("Multiplication result:");
            m3 = m1 * m2;
            Matrix<int>.PrintMatrix(m3);
            Console.WriteLine("Addition result:");
            m3 = m1 + m2;
            Matrix<int>.PrintMatrix(m3);
            Console.WriteLine("Substraction result:");
            m3 = m1 - m2;
            Matrix<int>.PrintMatrix(m3);
        }
    }
}
