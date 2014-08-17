using System;
using System.IO;

namespace MaxSumMatrix
{
    class MaxSumMatrix
    {
        static void Main()
        {
            WriteResult(GetMax(ReadMatrix()));
        }
        static int[,] ReadMatrix()
        {
            using (StreamReader input = new StreamReader("../../input.txt"))
            {
                int n = int.Parse(input.ReadLine());
                int[,] matrix = new int[n, n];

                for (int i = 0; i < n; i++)
                {
                    string[] numbers = input.ReadLine().Split(' ');

                    for (int j = 0; j < n; j++)
                        matrix[i, j] = int.Parse(numbers[j]);
                }

                return matrix;
            }
        }

        static int GetMax(int[,] matrix)
        {
            int maxSum = int.MinValue;

            for (int row = 0; row < matrix.GetLength(0) - 1; row++)
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                    maxSum = Math.Max(maxSum, matrix[row, col] + matrix[row + 1, col] + matrix[row, col + 1] + matrix[row + 1, col + 1]);

            return maxSum;
        }

        static void WriteResult(int maxSum)
        {
            using (StreamWriter output = new StreamWriter("../../output.txt"))
                output.WriteLine(maxSum);
        }

        
    }
}
