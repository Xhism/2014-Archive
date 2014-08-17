using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MatrixSequences
{
    class Sequence
    {
        // We are given a matrix of strings of size N x M. Sequences in the matrix we define as sets of several neighbor elements located on the same line, column or diagonal.
        // Write a program that finds the longest sequence of equal strings in the matrix. 
        static void Main()
        {
            string[,] matrix = {
            {"ha", "fifi", "ho", "hi"},
            {"fo", "ha", "hi", "xx"},
            {"xxx", "ho", "ha", "xx"},
        };

            // Print matrix
            
            int horizontal = 1;
            int vertical = 1;
            int diagonalR = 1;
            int diagonalL = 1;

            int horizontalMax = 1;
            int verticalMax = 1;
            int diagonalRMax = 1;
            int diagonalLMax = 1;

            string elementH = "";
            string elementV = "";
            string elementDR = "";
            string elementDL = "";

            int row = 0;

            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col] + " / ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            ////Check Horizontals
            for (row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1) - 1; col++)
                {
                    if (matrix[row, col] == matrix[row, col + 1])
                    {
                        horizontal++;
                        if (horizontal >= horizontalMax)
                        {
                            elementH = matrix[row, col];
                            horizontalMax = horizontal;
                        }
                    }
                    else
                    {
                        horizontal = 1;
                    }
                }
            }

            //Check Verticals
            for (int col = 0; col < matrix.GetLength(1); col++)
            {
                for (row = 0; row < matrix.GetLength(0) - 1; row++)
                {
                    if (matrix[row, col] == matrix[row + 1, col])
                    {
                        vertical++;
                        if (vertical >= verticalMax)
                        {
                            elementV = matrix[row, col];
                            verticalMax = vertical;
                        }
                    }
                    else
                    {
                        vertical = 1;
                    }
                }
            }

            //Check Right Diagonal
            for (int i = 0; i <= matrix.GetLength(0); i++)
            {
                for (int j = 0; j <= matrix.GetLength(1); j++)
                {
                    int col = j;
                    row = i;

                    if (col >= matrix.GetLength(1) - 1 || row >= matrix.GetLength(0) - 1)
                    {
                        break;
                    }
                    else
                    {
                        while (col < matrix.GetLength(1) - 1 && row < matrix.GetLength(0) - 1) 
                        {
                            if (matrix[row, col] == matrix[row + 1, col + 1]) 
                            {
                                diagonalR++;
                                if (diagonalR >= diagonalRMax)
                                {
                                    elementDR = matrix[row, col];
                                    diagonalRMax = diagonalR;
                                }
                                row++;
                                col++;
                            }
                            else 
                            {
                                diagonalR = 1;
                                break;
                            }
                        }
                        diagonalR = 1;
                    }
                }
            }

            //Check Left Diagonal
            for (int i = 0; i <= matrix.GetLength(0); i++)
            {
                for (int j = matrix.GetLength(1) - 1; j >= 0; j--)
                {
                    int col = j;
                    row = i;

                    if (col <= 1 || row >= matrix.GetLength(0) - 1)
                    {
                        break;
                    }
                    else
                    {
                        while (col > 0 && row < matrix.GetLength(0) - 1) 
                        {
                            if (matrix[row, col] == matrix[row + 1, col - 1]) 
                            {
                                diagonalL++;
                                if (diagonalL >= diagonalLMax)
                                {
                                    elementDL = matrix[row, col];
                                    diagonalLMax = diagonalL;
                                }
                                row++;
                                col--;
                            }
                            else 
                            {
                                diagonalL = 1;
                                break;
                            }
                        }
                        diagonalL = 1;
                    }
                }
            }
            
            //Fill MaxLength of SameElements
            int[] maxLength = new int[4];
            maxLength[0] = horizontalMax;
            maxLength[1] = verticalMax;
            maxLength[2] = diagonalRMax;
            maxLength[3] = diagonalLMax;

            //Fill Elements with maxLength Element
            string[] elements = new string[4];
            elements[0] = elementH;
            elements[1] = elementV;
            elements[2] = elementDR;
            elements[3] = elementDL;

            //Print Exit
            Console.WriteLine("Maximal found sequence:");
            for (int i = 0; i < 4; i++)
            {
                if (maxLength.Max() == maxLength[i])
                {
                    for (int j = 0; j < maxLength.Max(); j++)
                    {
                        if (j < maxLength.Max() - 1)
                        {
                            Console.Write(elements[i] + ",");
                        }
                        else
                        {
                            Console.Write(elements[i]);
                        }
                    }
                    Console.WriteLine();
                    break;
                }
            }
        }
    }
}
