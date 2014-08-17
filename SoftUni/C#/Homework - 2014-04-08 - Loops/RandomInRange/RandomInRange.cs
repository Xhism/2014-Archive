using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RandomInRange
{
    class RandomInRange
    {
        static void Main(string[] args)
        {
            Console.Write("Input the amount of numbers printed: ");
            int n = int.Parse(Console.ReadLine());
            Console.Write("Input the minimum number for the random: ");
            int min = int.Parse(Console.ReadLine());
            Console.Write("Input the maximum number for the random: ");
            int max = int.Parse(Console.ReadLine());
            Random random = new Random();

            for (int i = 0; i < n; i++)
            {
                Console.Write(random.Next(min, max + 1) + " ");
            }
            Console.WriteLine();
        }
    }
}
