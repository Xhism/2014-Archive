using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsByGroup
{
    class StudentsByGroup
    {
        static void Main()
        {
            var students = new[] {
                new {Name = "Yancho", GroupName = "Mathematics"},
                new {Name = "Yana", GroupName = "Rocket biology"},
                new {Name = "Yuliya", GroupName = "Rocket biology"},
                new {Name = "Yuliyan", GroupName = "Physics"},
                new {Name = "Yavor", GroupName = "Science"},
                new {Name = "Yanush", GroupName = "Mathematics"},
                new {Name = "Yasen", GroupName = "Physics"},
                new {Name = "Yaroslav", GroupName = "Rocket biology"},
                new {Name = "Yani", GroupName = "Mathematics"},
                new {Name = "Yakov", GroupName = "Science"}
            };

            /* 18.
             * Create a program that extracts all students grouped by
             * GroupName and then prints them to the console. Use LINQ.
             */

            Console.WriteLine("Using LINQ: ");
            var selectStudents =
                from student in students
                orderby student.GroupName
                select student;

            foreach (var student in selectStudents)
            {
                Console.WriteLine(string.Join(" - ", student.Name, student.GroupName));
            }

            Console.WriteLine();

            /* 19.
             * Rewrite the previous using extension methods.
             */

            Console.WriteLine("Using extension methods: ");
            var selectStudentsExtension = students.OrderBy(student => student.GroupName);

            foreach (var student in selectStudentsExtension)
            {
                Console.WriteLine(string.Join(" - ", student.Name, student.GroupName));
            }
        }
    }
}
