using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearch
{
    class BinarySearch
    {
        static void Main(string[] args)
        {
            int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15, 16, 17, 18, 19, 20 };
            Console.Write("Input the number you are looking for: ");
            int searchedNumber = int.Parse(Console.ReadLine());
            int start = 0;
            int end = array.Length - 1;
            int middle;
            while (start <= end)
            {
                middle = (start + end) / 2;

                if (array[middle] == searchedNumber)
                {
                    Console.WriteLine("Index is: {0}.", middle);
                    break;
                }

                if (array[middle] < searchedNumber)
                {
                    start = middle + 1;
                }

                if (array[middle] > searchedNumber)
                {
                    end = middle - 1;
                }
            }
        }
    }
}
