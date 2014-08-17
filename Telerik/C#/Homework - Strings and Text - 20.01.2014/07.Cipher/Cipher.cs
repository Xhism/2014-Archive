using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07.Cipher
{
    class Cipher
    {
        static void Main(string[] args)
        {
            string message = @"Write a program that encodes and decodes a string using given encryption key (cipher).
The key consists of a sequence of characters.
The encoding/decoding is done by performing XOR (exclusive or) operation over the first letter of the string with the first of the key, 
the second – with the second, etc. When the last key character is reached, the next is the first.";
            string key = "hello";
            Console.WriteLine(Encrypt(message,key));
        }
        static string Encrypt(string str, string key)
        {
            StringBuilder encrypted = new StringBuilder();
            for (int i = 0; i < str.Length; i++)
            {
                encrypted.Append((char)(str[i] ^ key[i % key.Length]));
            }

            return encrypted.ToString();
        }
    }
}
