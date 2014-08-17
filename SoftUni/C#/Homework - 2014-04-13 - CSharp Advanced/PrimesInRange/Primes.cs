using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimesInRange
{
    class Primes
    {
        static void Main(string[] args)
        {
            Console.Write("Input minimum number: ");
            int start = int.Parse(Console.ReadLine());
            Console.Write("Input maximum number: ");
            int end = int.Parse(Console.ReadLine());
            foreach (int prime in FindPrimesInRange(start, end))
            {
                Console.Write(prime + ", ");
            }
            Console.WriteLine();
        }
        static List<int> FindPrimesInRange(int startNum, int endNum)
        {
            List<int> primes = new List<int>();
            if ((startNum > 10000 || endNum > 10000) && endNum - startNum > 500)
                Console.WriteLine("Hold on, this process may take a while...");
            for (int i = startNum; i <= endNum; i++)
            {
                primes.Add(i);
                for (int j = 2; j <= i / 2; j++)
                {
                    if (i % j == 0)
                        primes.Remove(i);
                }
            }
            return primes;
        }
    }
}
