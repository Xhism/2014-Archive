using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01_Persons
{
    class Persons
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>(){
                new Person("Pesho", 20),
                new Person("Petko", 19, "petko@gmail.com"),
                new Person("Petur", 33, "petur@abv.bg"),
            };
            foreach(Person p in people)
            {
                Console.WriteLine(p.ToString());
            }
        }
    }
}
