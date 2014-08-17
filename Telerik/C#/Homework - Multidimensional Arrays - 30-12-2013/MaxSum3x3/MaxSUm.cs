using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxSum3x3
{
    class MaxSum
    {
        // Write a program that reads a rectangular matrix of size N x M and finds in it the square 3 x 3 that has maximal sum of its elements.
        static void Main(string[] args)
        {
            int n = 4;
            int m = 5;
            int[,] matrix = new int[n, m];
            Console.WriteLine("Please input the desired matrix:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write("Matrix[{0},{1}] = ", row, col);
                    matrix[row, col] = int.Parse(Console.ReadLine());
                }
            }
            Console.WriteLine("Given matrix:");
            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < m; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
            int currentSum = 0;
            int maxSum = 0;
            int bestStartRow = 0;
            int bestStartCol = 0;

            for (int row = 0; row < n - 2; row++)
            {
                for (int col = 0; col < m - 2; col++)
                {
                    currentSum = matrix[row, col] + matrix[row + 1, col] + matrix[row + 2, col] + matrix[row, col + 1] + matrix[row + 1, col + 1] + matrix[row + 2, col + 1] + matrix[row, col + 2] + matrix[row + 1, col + 2] + matrix[row + 2, col + 2];
                    if (maxSum < currentSum)
                    {
                        maxSum = currentSum;
                        bestStartCol = col;
                        bestStartRow = row;
                    }
                }
            }
            Console.WriteLine("Maximal sum found = " + maxSum + " at");
            for (int row = bestStartRow; row < bestStartRow + 3; row++)
            {
                for (int col = bestStartCol; col < bestStartCol + 3; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
