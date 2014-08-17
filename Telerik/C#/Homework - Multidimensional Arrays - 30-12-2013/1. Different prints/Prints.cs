using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DifferentPrints
{
    class Prints
    {
        // Write a program that fills and prints a matrix of size (n, n) as shown below: (examples for n = 4) {Presentation: Multidimensional arrays: Slide 38}

        static void Main(string[] args)
        {
            int n = 4;
            int[,] matrix = new int[n, n];

            int currentRow = 0;
            int currentCol = 0;
            int number = 0;
            string direction = "";


            // Print a)

            Console.WriteLine("a)");
            for (int col = 0; col < n; col++)
            {
                for (int row = 0; row < n; row++)
                {
                    number++;
                    matrix[row, col] = number;
                }
            }

            Print2dArray(matrix);

            // Print b)

            Console.WriteLine("\nb)");

            direction = "down";

            for (int i = 0; i < n * n; i++)
            {

                matrix[currentRow, currentCol] = i + 1;

                if (direction == "down")
                {
                    currentRow++;
                }

                if (direction == "up")
                {
                    currentRow--;
                }

                if (currentRow < 0)
                {
                    currentRow++;
                    currentCol++;
                    direction = "down";
                }

                if (currentRow >= n)
                {
                    currentRow--;
                    currentCol++;
                    direction = "up";
                }


            }

            Print2dArray(matrix);
            number = 0;

            // Print c)

            Console.WriteLine("\nc)");

            for (int row = n - 1; row >= 0; row--)
            {
                for (int col = 0; col < n - row; col++)
                {
                    number++;
                    matrix[(row + col), col] = number;
                }
            }

            for (int col = 1; col < n; col++)
            {
                for (int row = 0; row < n - col; row++)
                {
                    number++;
                    matrix[row, (row + col)] = number;
                }
            }

            Print2dArray(matrix);
            number = 0;


            // Print d)
            currentRow = 0;
            currentCol = 0;
            direction = "down";

            int leftLimit = 1;
            int rightLimit = n;
            int upLimit = 0;
            int downLimit = n;

            Console.WriteLine("\nd)");
            for (int i = 0; i < n * n; i++)
            {
                matrix[currentRow, currentCol] = i + 1;

                if (direction == "up")
                    currentRow--;
                if (direction == "down")
                    currentRow++;
                if (direction == "left")
                    currentCol--;
                if (direction == "right")
                    currentCol++;

                if (currentRow >= downLimit && direction == "down")
                {
                    currentRow--;
                    currentCol++;
                    direction = "right";
                    downLimit--;
                }
                if (currentRow < upLimit && direction == "up")
                {
                    currentRow++;
                    currentCol--;
                    direction = "left";
                    upLimit++;
                }
                if (currentCol >= rightLimit && direction == "right")
                {
                    currentCol--;
                    currentRow--;
                    direction = "up";
                    rightLimit--;
                }
                if (currentCol < leftLimit && direction == "left")
                {
                    currentCol++;
                    currentRow++;
                    direction = "down";
                    leftLimit++;
                }
            }
            Print2dArray(matrix);
        }

        static void Print2dArray(int[,] matrix)
        {
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + "  ");
                }
                Console.WriteLine();
            }
        }

    }
}
