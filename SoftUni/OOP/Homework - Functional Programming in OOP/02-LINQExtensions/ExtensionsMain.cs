using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_LINQExtensions
{
    class ExtensionsMain
    {
        static void Main(string[] args)
        {
            Queue<int> queue = new Queue<int>();
            queue.Enqueue(3);
            queue.Enqueue(4);
            queue.Enqueue(5);
            queue.Enqueue(6);
            queue.Enqueue(7);
            queue.Enqueue(8);
            queue.Enqueue(2);
            var result = queue.WhereNot(x => x % 4 == 0);
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            List<int> numbers = new List<int>();
            numbers.Add(123);
            numbers.Add(456);
            numbers.Add(789);
            var allNumbers = numbers.Repeat(2);
            Console.WriteLine();
            foreach (var number in allNumbers)
            {
                Console.WriteLine(number);
            }
            Console.WriteLine();
            List<string> words = new List<string>() { "Lorem", "Ipsum", "Dolor", "Sit", "Amet", "regione", "nonumes", "eu", "pro", "usu", "id", "everti", "recteque" };
            List<string> suffixes = new List<string>() { "m", "t", "e" };
            var filtredWords = words.WhereEndsWith(suffixes);
            foreach (var item in filtredWords)
            {
                Console.WriteLine(item);
            }
        }
    }
}
