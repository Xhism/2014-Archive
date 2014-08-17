using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayCompare
{
    class ArrayCompare
    {
        static void Main(string[] args)
        {
            Console.Write("Input first array length: ");
            int n = int.Parse(Console.ReadLine());

            Console.Write("Input second array length: ");
            int m = int.Parse(Console.ReadLine());

            int[] inputArray1 = new int[n];
            int[] inputArray2 = new int[m];

            bool areEqual = true;

            if (m == n)
            {
                for (int i = 0; i < n; i++)
                {
                    Console.Write("Array1[{0}] = ", i);
                    inputArray1[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < m; i++)
                {
                    Console.Write("Array2[{0}] = ", i)
                    inputArray2[i] = int.Parse(Console.ReadLine());
                }

                for (int i = 0; i < n; i++)
                {
                    if (inputArray1[i] != inputArray2[i])
                    {
                        areEqual = false;
                        break;
                    }
                }
            }

            else
            {
                areEqual = false;
            }

            if(areEqual)
                Console.WriteLine("The arrays are equal.");
            else
                Console.WriteLine("The arrays are NOT equal.");
        }
    }
}
