using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Students
{
    /* 03.
     * Write a method that from a given array of students finds all students whose
     * first name is before its last name alphabetically. Use LINQ query operators.
     */

    /* 04.
     * Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.
     */

    /* 05.
     * Using the extension methods OrderBy() and ThenBy() with lambda expressions sort
     * the students by first name and last name in descending order. Rewrite the same with LINQ.
     */

    public class Student
    {
        public string firstName { get; set; }
        public string lastName { get; set; }

        public int age { get; set; }
    }


    class StudentsTest
    {
        static void Main(string[] args)
        {


            Student[] studentsArr = new Student[]
            {
                new Student {firstName = "Georgi", lastName="Serev", age = 20},
                new Student {firstName = "Yana", lastName="Yankova", age = 22},
                new Student {firstName = "Svetozar", lastName="Vulchev", age = 26},
                new Student {firstName ="Miroslava", lastName="Ivanova", age = 34},
                new Student {firstName= "Krasimir", lastName="Mladenov", age = 19},
                new Student {firstName= "Yordan", lastName = "Poydovski", age = 29}
            };


            OrderByFirstName(studentsArr);
            CheckAge(studentsArr);
            OrderByNames(studentsArr);
        }

        private static void OrderByFirstName(Student[] studentsArr)
        {
            Console.WriteLine("\nStudents whose first name comes alphabetically before their last name:");
            var queryResult =
                from student in studentsArr
                where (student.firstName.CompareTo(student.lastName) < 0)
                select student;

            foreach (Student student in queryResult)
                Console.WriteLine(student.firstName + " " + student.lastName);
        }

        private static void CheckAge(Student[] studentsArr)
        {
            Console.WriteLine("\nStudents between the age of 18 and 24:");
            var queryResult =
                from student in studentsArr
                where(student.age<=24 && student.age>=18)
                select student;

            foreach(Student student in queryResult)
                    Console.WriteLine(student.firstName + " " + student.lastName + " at age " + student.age);
        }
        public static void OrderByNames(Student[] studentsArr)
        {
            //LINQ
            Console.WriteLine("\nIn descending alphabetic order using LINQ:");
            var LINQResult =
                from student in studentsArr
                orderby student.firstName descending, student.lastName descending
                select student;

            foreach (var student in LINQResult)
                Console.WriteLine(student.firstName + " " + student.lastName);

            //Lambda
            Console.WriteLine("\nIn descending alphabetic order using Lambda:");
            var queryLambda = studentsArr.OrderByDescending(student => student.firstName).ThenByDescending(student => student.lastName);

            foreach (var student in queryLambda)
                Console.WriteLine(student.firstName + " " + student.lastName);
        }
    }
}
