using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexOfFirst
{
    class IndexOfFirst
    {
        // Write a method that returns the index of the first element in array that is bigger than its neighbors, or -1, if there’s no such element.

        static void Main(string[] args)
        {
            Console.Write("Input total desired amount of numbers in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            if(FirstBigger(arr) == -1)
                Console.WriteLine("No element found to be bigger than its neigbours.");
            else
                Console.WriteLine("The first found element was at position " + FirstBigger(arr));
        }
        static int FirstBigger(int[] Array)
        {
            for (int i = 1; i < Array.Length - 1; i++)
            {
                if (Array[i] > Array[i - 1] && Array[i] > Array[i + 1])
                    return i;
                
            }
            return -1;
        }
    }
}
