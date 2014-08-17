using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumOfFractions
{
    class SumOfFractions
    {
        static void Main(string[] args)
        {
            float sum = 1.0f;
            float tempSum = 1.0f;
            float denominator = 2.0f;
            while(tempSum >= 0.001f) 
            {
                tempSum = 1 / denominator;
                if(denominator % 2 == 0)
                    sum += tempSum;

                if (denominator % 2 == 1)
                    sum -= tempSum;
                denominator++;
            }
            Console.WriteLine("{0:0.000}",sum);
        }
    }
}
