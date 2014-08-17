using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.CorrectBrackets
{
    class CorrectBrackets
    {
        static void Main(string[] args)
        {
            string correct = "((a+b) / 5 - d)";
            string incorrect = ")(a+b))";

            CheckBrackets(correct);
            CheckBrackets(incorrect);

        }
        static void CheckBrackets(string str)
        {
            int count = 0;
            for (int i = 0; i < str.Length && count >= 0; i++)
            {
                if (str[i] == '(') count++;
                if (str[i] == ')') count--;
            }
            if (count == 0) Console.WriteLine("All the brackets are placed correctly.");
            else Console.WriteLine("There are some incorrectly placed brackets.");
        }
    }
}
