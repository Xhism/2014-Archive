using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IsBigger
{
    class BiggerThanNeigbours
    {
        // Write a method that checks if the element at given position in given array of integers is bigger than its two neighbors (when such exist).
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
            Console.Write("Input desired index of element: ");
            int index = int.Parse(Console.ReadLine());
            IsBigger(arr, index);
        }
        static void IsBigger(int[] Array, int index)
        {
            if(index > 0 && index < (Array.Length - 1))
            {
                if(Array[index] > Array[index-1] && Array[index] > Array[index + 1])
                    Console.WriteLine("The number at the given index is bigger than its neighbours.");
                else
                    Console.WriteLine("The number at the given index is NOT bigger than its neighbours.");
            }
            else
                Console.WriteLine("The number at that index does not have 2 neighbours.");
        }
    }
}
