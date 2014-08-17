using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    class Sort
    {
        static void Merge(int[] arr, int[] temp, int left, int middle, int right)
        {
            int i = left, j = middle + 1, k = left;

            // For both arrays
            while (i <= middle && j <= right)
            {
                if (arr[i] < arr[j]) 
                    temp[k++] = arr[i++];
                else 
                    temp[k++] = arr[j++];
            }

            while (i <= middle)
                temp[k++] = arr[i++]; // Copy items left from the first array
            while (j <= right)
                temp[k++] = arr[j++]; // Or from the second array

            for (i = left; i <= right; i++) arr[i] = temp[i]; // Save to the original array
        }

        static void MergeSort(int[] arr, int[] temp, int l, int r)
        {
            if (l >= r) return;

            int m = l + (r - l) / 2; // Split in two

            MergeSort(arr, temp, l, m);
            MergeSort(arr, temp, m + 1, r);

            Merge(arr, temp, l, m, r); // And merge the sorted halves
        }

        static void Main()
        {
            int[] arr = { -1, 2, -3, 4, -5, 6, -7 };

            int[] temp = new int[arr.Length];
            MergeSort(arr, temp, 0, arr.Length - 1);

            foreach (int item in arr) 
                Console.Write(item + ", ");

            Console.WriteLine();
        }
    }
}
