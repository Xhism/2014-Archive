using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_12_Students
{
    class StudentsMain
    {
        static void Main(string[] args)
        {
            //03 - Class-Student
            Student pesho = new Student("Pesho", "Peshev", 20, 10110000, "+3592 22 22 222",
            "pesho_peshev@abv.bg", new List<int>() { 2, 5, 5, 6, 6, 6, 6 }, 2, "Excellent");
            Student gosho = new Student("Georgi", "Goshev", 21, 10110001, "+359 889 999 999",
            "gosho.goshev@gmail.com", new List<int>() { 2, 2, 2, 2, 2, 3, 4 }, 1, "Weak");
            Student svetlio =  new Student("Svetlio", "Svetlev", 56, 10111234, "+359 881 111 111",
            "stoqncho@abv.bg", new List<int>() { 6, 6, 6, 6, 6, 6, 6 }, 3, "Excellent");
            Student asya = new Student("Asya", "Aseva", 22, 10110002, "+359 2 77 77 777",
            "asya.aseva@dir.bg", new List<int>() { 6, 6, 4, 6, 4, 2, 3 }, 2, "Medium");
            Student anita = new Student("Anita", "Aneva", 22, 10110044, "0884 444 444",
            "anita.aneva@yahoo.com", new List<int>() { 5, 2, 4, 6, 4, 2, 3 }, 1, "Medium");
            List<Student> students = new List<Student>();
            students.Add(pesho);
            students.Add(svetlio);
            students.Add(gosho);
            students.Add(asya);
            students.Add(anita);
            // 04 - Student-by-Group
            var studentsFrom2Group =
            from student in students
            where student.GroupNumber == 2
            orderby student.FirstName
            select student;
            Console.WriteLine("Problem 04 - Students by Group:\n");
            foreach (var item in studentsFrom2Group)
            {
                Console.WriteLine(item);
            }
            // 05 - Students-by-First-and-Last-Name
            var studentsByNameAndLastName =
            from student in students
            orderby student.FirstName, student.Lastname
            select student;
            Console.WriteLine("\n--\nProblem 05 - Students by First and Last Name:\n");
            foreach (var item in studentsByNameAndLastName)
            {
                Console.WriteLine(item);
            }
            // 06 - Students-by-Age
            var studentsByAge =
            from student in students
            where student.Age <= 24 && student.Age >= 18
            select new { FirstName = student.FirstName, LastName = student.Lastname };
            Console.WriteLine("\n--\nProblem 06 - Students by Age:\n");
            foreach (var item in studentsByAge)
            {
                Console.WriteLine("Student: ({0} {1})", item.FirstName, item.LastName);
            }
            // 07 - Sort-Students
            Console.WriteLine("\n--\nProblem 07 - Sort Students with LAMBDA:\n");
            students.OrderByDescending(s => s.FirstName).ThenByDescending(s => s.Lastname).ToList().ForEach(s => Console.WriteLine(s.ToString()));
            var studentsInDescendingOrder =
            from student in students
            orderby student.FirstName descending, student.Lastname descending
            select student;
            Console.WriteLine("\n--\nProblem 07-2 - Sort Students with LINQ:\n");
            foreach (var item in studentsInDescendingOrder)
            {
                Console.WriteLine(item);
            }
            // 08 - Filter-Students-by-Email-Domain
            Console.WriteLine("\n--\nProblem 08 - Students by Email Domain:\n");
            var studentsByEmail =
            from student in students
            where student.Email.Contains("@abv.bg")
            select student;
            foreach (var item in studentsByEmail)
            {
                Console.WriteLine(item);
            }
            // 09 - Filter-Students-by-Phone
            Console.WriteLine("\n--\nProblem 09 - Students by Phone:\n");
            var studentsByPhone =
            from student in students
            where student.Phone.StartsWith("02") || student.Phone.StartsWith("+3592") || student.Phone.StartsWith("+359 2")
            select student;
            foreach (var item in studentsByPhone)
            {
                Console.WriteLine(item);
            }
            // 10 - Excellent-Students
            Console.WriteLine("\n--\nProblem 10 - Excellent Students:\n");
            var studentExcellent =
            from student in students
            where student.Marks.Contains(6)
            select new { FirstName = student.FirstName, Marks = student.Marks };
            foreach (var item in studentExcellent)
            {
                string marks = string.Join(", ", item.Marks);
                Console.WriteLine("{0}: ({1})", item.FirstName, marks);
            }
            // 11 - Weak-Students
            Console.WriteLine("\n--\nProblem 11 - Weak Stuents:\n");
            var weakStudents =
            from student in students
            where student.Marks.Where(s => s == 2).Count() == 2
            select student;
            foreach (var item in weakStudents)
            {
                Console.WriteLine(item);
            }
            // 12 - Students-Enrolled-in-2014
            Console.WriteLine("\n--\nProblem 12 - Students Enrolled in 2014:\n");
            students.Where(s => s.FacultyNumber.ToString().Trim().StartsWith("14"))
            .ToList().ForEach(s => Console.WriteLine(s.ToString()));
        }
    }
}
