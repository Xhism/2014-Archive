using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SelectionSort
{
    class SelectionSort
    {
        static void Main(string[] args)
        {
            int[] array = { 4, 6, 2, 4, 3, 3, 7, 1, 8, 6, 2, 6, 342, -136 };

            int minValue;

            for (int i = 0; i < array.Length - 1; i++)
            {
                minValue = i;
                for (int j = i + 1; j < array.Length; j++)
                {
                    if (array[j] < array[minValue])
                    {
                        minValue = j;
                    }
                }

                if (minValue != i)
                {
                    int temp = array[minValue];
                    array[minValue] = array[i];
                    array[i] = temp;
                }
            }

            for (int i = 0; i < array.Length; i++)
            {
                Console.Write(array[i] + " ");
            }
            Console.WriteLine();
        }
    }
}
