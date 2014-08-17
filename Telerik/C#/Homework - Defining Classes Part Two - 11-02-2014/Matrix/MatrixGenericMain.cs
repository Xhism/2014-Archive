using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    /* 08:
     * Define a class Matrix<T> to hold a matrix of numbers (e.g. integers, floats, decimals). 
     */

    /* 09:
     * Implement an indexer this[row, col] to access the inner matrix cells.
     */

    /* 10:
     * Implement the operators + and - (addition and subtraction of matrices of the same size) and * for matrix multiplication. 
     * Throw an exception when the operation cannot be performed. Implement the true operator (check for non-zero elements).
     */
    class MatrixGenericMain
    {
        public static void Main()
        {
            Random rnd = new Random();

            Matrix<double> matr1 = new Matrix<double>(4, 4);
            Matrix<double> matr2 = new Matrix<double>(4, 4);

            for (int row = 0; row < matr1.Rows; row++)
            {
                for (int col = 0; col < matr1.Cols; col++)
                {
                    matr1[row, col] = rnd.Next(0, 10);
                    matr2[row, col] = rnd.Next(0, 10);
                }
            }

            Matrix<double> resAddition = matr1 + matr2;
            Matrix<double> resSubtr = matr1 - matr2;

            if (resAddition)
            {
                Console.WriteLine("Contains non-zero elements.");
            }
            else
            {
                Console.WriteLine("Contains only zeros.");
            }
        }
    }
}
