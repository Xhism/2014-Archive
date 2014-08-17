using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingNumbers
{
    class Sorting
    {
        static void Main(string[] args)
        {
            Console.Write("Input amount of numbers: ");
            int n = int.Parse(Console.ReadLine());
            int[] numbers = new int[n];

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.Write("Input number " + (i+1) + ": ");
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Array.Sort(numbers);
            Console.WriteLine("Sorted:");

            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
    }
}
