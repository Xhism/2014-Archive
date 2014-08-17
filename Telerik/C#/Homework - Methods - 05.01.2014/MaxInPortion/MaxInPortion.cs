using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Threading.Tasks;

namespace MaxInPortion
{
    class MaxInPortion
    {
        // Write a method that return the maximal element in a portion of array of integers starting at given index. Using it write another method that sorts an array in ascending / descending order.

        static void Main()
        {
            Console.Write("Input total desired amount of numbers in array: ");
            int n = int.Parse(Console.ReadLine());
            int[] arr = new int[n];
            for (int i = 0; i < n; i++)
            {
                Console.Write("Array[{0}] = ", i);
                arr[i] = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("Ascending:");
            SelectionSort(arr, descending: false);
            PrintArray(arr);

            Console.WriteLine("Descending:");
            SelectionSort(arr, descending: true);
            PrintArray(arr);
        }
        static void PrintArray(int[] arr)
        {
            for (int i = 0; i < arr.Length; i++) Console.Write(arr[i] + (i == arr.Length - 1 ? "\n" : ", "));
        }

        static void Swap(int[] arr, int i, int j)
        {
            int t = arr[i];
            arr[i] = arr[j];
            arr[j] = t;
        }

        // Returns the min/max element starting from position i to the end of the array
        static int GetMaxFromPosition(int[] arr, int i, bool descending)
        {
            int best = i;

            for (i++; i < arr.Length; i++)
                if (descending ? arr[best] < arr[i] : arr[i] < arr[best])
                    best = i;

            return best;
        }

        static void SelectionSort(int[] arr, bool descending = false)
        {
            for (int i = 0; i < arr.Length; i++)
                Swap(arr, i, GetMaxFromPosition(arr, i, descending));
        }
    }
}
