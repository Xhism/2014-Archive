using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04___HTML_Dispatcher
{
    class Dispatch
    {
        static void Main(string[] args)
        {
            ElementBuilder div = new ElementBuilder("div");
            div.AddAttribute("id", "page");
            div.AddAttribute("class", "big");
            div.AddContent("<p>Hello</p>");
            Console.WriteLine(div);
            Console.WriteLine(div * 2);
            string myImage = HTMLDispatcher.CreateImage("../img/asdf.jpg", "random image", "feel the randomness");
            Console.WriteLine(myImage);
            string myLink = HTMLDispatcher.CreateURL("http://softuni.bg/", "SoftUni", "Software Univeristy");
            Console.WriteLine(myLink);
            string myInput = HTMLDispatcher.CreateInput("button", "ok", "OK");
            Console.WriteLine(myInput);
        }
    }
}
