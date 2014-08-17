using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Palindromes
{
    class Palindromes
    {
        static void Main()
        {
            Console.Write("Input height: ");
            int height = int.Parse(Console.ReadLine());
            Console.Write("Input width: ");
            int width = int.Parse(Console.ReadLine());

            string[,] matrix = new string[height, width];

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    matrix[row, col] = "" + (char)('a' + row) + (char)('a' + col + row) + (char)('a' + row);
                }
            }

            for (int row = 0; row < height; row++)
            {
                for (int col = 0; col < width; col++)
                {
                    Console.Write(matrix[row, col] + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
