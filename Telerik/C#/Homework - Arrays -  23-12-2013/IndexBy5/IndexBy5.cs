using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndexBy5
{
    class IndexBy5
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[20];
            for (int cell = 0; cell < myArray.GetLength(0); cell++)
            {
                int cellValue = cell * 5;
                myArray[cell] = cellValue;
                Console.WriteLine("Array[{0}] = {1}", cell, cellValue);
            }
        }
    }
}
