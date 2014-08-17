using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringArraySort
{
    class StringSort
    {
        // You are given an array of strings. Write a method that sorts the array 
        // by the length of its elements (the number of characters composing them).

        static void Main()
        {
            string[] stringArray = { "Word", "Not So Word", "Just As Word", "Very Word", "1234567890", "zxcvbnmasdfghjkl" };
            foreach (string element in stringArray.OrderBy(uStrings => uStrings.Length))
            {
                Console.WriteLine(element);
            }
        }
    }
}
