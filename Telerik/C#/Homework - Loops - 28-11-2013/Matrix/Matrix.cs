using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Matrix
{
    class Matrix
    {
        // Write a program that reads from the console a positive integer number N (N < 20) and outputs a matrix like the following: Check Presentation - Loops - Slide 60: Exercises (4)
        static void Main(string[] args)
        {
            int n = 0;
            Console.WriteLine("Input N:");
            bool nCheck = int.TryParse(Console.ReadLine(), out n);
            if(nCheck)
            {
                for (int i = 1; i <= n; i++)
                {
                    for (int j = i; j <= n + i - 1; j++)
                    {
                        Console.Write(j+" ");
                    }
                    Console.WriteLine();
                }
            }
            else Console.WriteLine("Error: N needs to be between 0 and 20");
        }
    }
}
