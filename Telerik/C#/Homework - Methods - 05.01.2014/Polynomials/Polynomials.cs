using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Polynomials
{
    class Polynomials
    {
        //Write a method that adds two polynomials. Represent them as arrays of their coefficients as in the example below:
		//x2 + 5 = 1x2 + 0x + 5 -> 5 / 0 / 1
        //Extend the program to support also subtraction and multiplication of polynomials.

        static void Main()
        {
            Console.Write("Input first polynomial's parameter a: ");
            int a1 = int.Parse(Console.ReadLine());
            Console.Write("Input first polynomial's parameter b: ");
            int b1 = int.Parse(Console.ReadLine());
            Console.Write("Input first polynomial's parameter c: ");
            int c1 = int.Parse(Console.ReadLine());

            decimal[] firstPolynomial = { c1, b1, a1 };
            Console.Write("Input second polynomial's parameter a: ");
            int a2 = int.Parse(Console.ReadLine());
            Console.Write("Input second polynomial's parameter b: ");
            int b2 = int.Parse(Console.ReadLine());
            Console.Write("Input second polynomial's parameter c: ");
            int c2 = int.Parse(Console.ReadLine());

            decimal[] secondPolynomial = { c2, b2, a2 };
            
            Console.Write("First polynomial:  ");
            PrintPolynomial(firstPolynomial);

            Console.Write("Second polynomial:  ");
            PrintPolynomial(secondPolynomial);

            int maxLength = 0;
            if (firstPolynomial.Length > secondPolynomial.Length)
            {
                maxLength = firstPolynomial.Length;
            }
            else
            {
                maxLength = secondPolynomial.Length;
            }

            decimal[] result = new decimal[maxLength];
            Console.WriteLine();

            PolynomialAdd(firstPolynomial, secondPolynomial, result);
            Console.Write("Sum:  ");
            PrintPolynomial(result);

            PolynomialSubtract(firstPolynomial, secondPolynomial, result);
            Console.Write("Difference:  ");
            PrintPolynomial(result);

            decimal[] product = new decimal[firstPolynomial.Length + secondPolynomial.Length];

            PolynomialMultiply(firstPolynomial, secondPolynomial, product);
            Console.Write("Product:  ");
            PrintPolynomial(product);
        }

        static void PolynomialAdd(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
        {
            int minLength = 0;
            int smallerPolynomial = 0;

            if (firstPolynomial.Length > secondPolynomial.Length)
            {
                minLength = secondPolynomial.Length;
                smallerPolynomial = 2;
            }
            else
            {
                minLength = firstPolynomial.Length;
                smallerPolynomial = 1;
            }

            for (int i = 0; i < minLength; i++)
            {
                result[i] = firstPolynomial[i] + secondPolynomial[i];
            }

            for (int i = minLength; i < result.Length; i++)
            {
                if (smallerPolynomial == 1)
                {
                    result[i] = secondPolynomial[i];
                }
                else
                {
                    result[i] = firstPolynomial[i];
                }
            }
        }
        static void PolynomialSubtract(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
        {
            int minLength = 0;
            int smallerPolynomial = 0;

            if (firstPolynomial.Length > secondPolynomial.Length)
            {
                minLength = secondPolynomial.Length;
                smallerPolynomial = 2;
            }
            else
            {
                minLength = firstPolynomial.Length;
                smallerPolynomial = 1;
            }

            for (int i = 0; i < minLength; i++)
            {
                result[i] = firstPolynomial[i] - secondPolynomial[i];
            }

            for (int i = minLength; i < result.Length; i++)
            {
                if (smallerPolynomial == 1)
                {
                    result[i] = secondPolynomial[i];
                }
                else
                {
                    result[i] = firstPolynomial[i];
                }
            }
        }
        static void PolynomialMultiply(decimal[] firstPolynomial, decimal[] secondPolynomial, decimal[] result)
        {
            //declare zeros at result polinom
            for (int i = 0; i < result.Length; i++)
            {
                result[i] = 0;
            }

            for (int i = 0; i < firstPolynomial.Length; i++)
            {
                for (int j = 0; j < secondPolynomial.Length; j++)
                {
                    int position = i + j;
                    result[position] += (firstPolynomial[i] * secondPolynomial[j]);
                }
            }
        }

        static void PrintPolynomial(decimal[] polynomial)
        {
            for (int i = polynomial.Length - 1; i >= 0; i--)
            {
                if (polynomial[i] != 0 && i != 0)
                {
                    if (polynomial[i - 1] >= 0)
                    {
                        Console.Write("{1}x^{0} +", i, polynomial[i]);
                    }
                    else
                    {
                        Console.Write("{1}x^{0} ", i, polynomial[i]);
                    }
                }
                else if (i == 0)
                {
                    Console.Write("{0}", polynomial[i]);
                }
            }

            Console.WriteLine();
        }

        
    }
}
