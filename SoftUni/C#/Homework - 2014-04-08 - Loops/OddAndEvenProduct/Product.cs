using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddAndEvenProduct
{
    class Product
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Input a line of numbers separated by space:");
            string input = Console.ReadLine();
            string[] inputArr = input.Split(' ');
            int productOdds = 1;
            int productEvens = 1;
            for (int i = 0; i < inputArr.Length; i++)
            {
                if (i % 2 == 0)
                    productOdds *= int.Parse(inputArr[i]);
                else
                    productEvens *= int.Parse(inputArr[i]);
            }
            if (productOdds == productEvens)
            {
                Console.WriteLine("yes");
                Console.WriteLine("product = " + productEvens);
            }
            else
            {
                Console.WriteLine("no");
                Console.WriteLine("odd_product = " + productOdds);
                Console.WriteLine("even_product = " + productEvens);
            }
        }
    }
}
