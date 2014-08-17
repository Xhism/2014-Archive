using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CardCheck
{
    class CardCheck
    {
        static void Main(string[] args)
        {
            Console.Write("Input card face: ");
            string face = Console.ReadLine();
            if (face == "2"
                || face == "3" 
                || face == "4" 
                || face == "5" 
                || face == "6" 
                || face == "7" 
                || face == "8" 
                || face == "9" 
                || face == "10"
                || face == "J" 
                || face == "Q" 
                || face == "K"
                || face == "A" ) 
            {
                Console.WriteLine("Card face is valid.");
            }
            else
                Console.WriteLine("Invalid card face.");
        }
    }
}
