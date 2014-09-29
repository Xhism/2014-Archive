using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_04_GenericList
{
    class GenericMain
    {
        static void Main(string[] args)
        {
            GenericList<int> testList = new GenericList<int>(2);
            testList.Add(1);
            testList.Add(2);
            testList.Add(3);
            testList.Add(4);
            testList.Add(5);
            testList.Add(6);
            testList.Add(7);
            testList.Add(3);
            Console.WriteLine(testList);
            Console.WriteLine("Index of 5: " + testList.IndexOf(5));
            testList.RemoveAt(3);
            Console.WriteLine(testList);
            Console.WriteLine("Index of 5 after removing position 3: " + testList.IndexOf(5));
            testList.InsertAt(4, 6);
            Console.WriteLine(testList);
            Console.WriteLine();
            Console.WriteLine("Count: " + testList.Count);
            Console.WriteLine();
            Console.WriteLine("Max: " + testList.Max());
            Console.WriteLine("Min: " + testList.Min());
            Console.WriteLine();
            var allAttributes = typeof(GenericList<>).GetCustomAttributes(typeof(VersionAttribute), false);
            Console.WriteLine("Version: " + allAttributes[0]);
            Console.WriteLine();
        }
    }
}
