using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort
{
    class Sort
    {
        static void Main()
        {
            string[] stringArr = { "Word", "Not so Word", "Just as Word", "abc" };
            QuickSort(stringArr, 0, stringArr.Length - 1);

            for (int i = 0; i < stringArr.Length; i++)
            {
                Console.Write(stringArr[i] + ", ");
            }
            Console.WriteLine();
        }

        static int Partition(string[] stringArr, int p, int r)
        {
            string x = stringArr[r];
            int i = p - 1;
            string temp = "";

            for (int j = p; j < r; j++)
            {
                if (string.Compare(stringArr[j], x) < 0)
                {
                    i = i + 1;
                    temp = stringArr[i];
                    stringArr[i] = stringArr[j];
                    stringArr[j] = temp;
                }
            }

            temp = stringArr[i + 1];
            stringArr[i + 1] = stringArr[r];
            stringArr[r] = temp;

            return i + 1;
        }

        static void QuickSort(string[] stringArr, int p, int r)
        {
            if (p < r)
            {
                int q = Partition(stringArr, p, r);
                QuickSort(stringArr, p, q - 1);
                QuickSort(stringArr, q + 1, r);
            }
        }
    }
}
