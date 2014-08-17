using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxSumAvg
{
    class MinMaxSumAvg
    {
        static void Main(string[] args)
        {
            Console.Write("Input the amount of numbers that you would like: ");
            int n = int.Parse(Console.ReadLine());
            int temp;
            int min = int.MaxValue, max = int.MinValue;
            double sum = 0, avg = 0;

            for (int i = 0; i < n; i++)
            {
                Console.Write("Input number no.{0}: ",  i+1);
                temp = int.Parse(Console.ReadLine());
                if (temp < min)
                    min = temp;
                if (temp > max)
                    max = temp;
                sum += temp;
            }
            avg = sum / n;

            Console.WriteLine("min = {0}\nmax = {1}\nsum = {2}\navg = {3:0.00}", min, max, sum, avg);
        }
    }
}
