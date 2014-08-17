using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumbers
{
    class PrimeNumbers
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please wait, this process takes a while...");
            List<int> primeNumbers = new List<int>();
            int max = 10000000;

            for (int i = 2; i < max + 1; i++)
            {
                primeNumbers.Add(i);
            }
            double stop = Math.Sqrt((double)max);

            for (int i = 2; i <= stop; i++)
            {
                if (!primeNumbers.Contains(i))
                {
                    continue;
                }
                for (int remove = 2 * i; remove <= max + 1; remove += i)
                {
                    primeNumbers.Remove(remove);
                }
            }

            foreach (int number in primeNumbers)
            {
                Console.Write(number + " ");
            }
        }
    }
}
