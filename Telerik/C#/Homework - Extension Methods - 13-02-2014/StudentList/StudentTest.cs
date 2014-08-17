using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentList
{
    class StudentTest
    {
        static void Print(IEnumerable<Student> students)
        {
            foreach (var student in students)
            {
                Console.WriteLine(student);
                Console.WriteLine();
            }
        }

        /* 09.
         * Select only the students that are from group number 2.
         * Use LINQ query. Order the students by FirstName.
         */

        static void FindStudentsFromSecondGroupWithLinq()
        {
            var studentsFromSecondGroupWithLinq =
                from student in students
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            Print(studentsFromSecondGroupWithLinq);
        }

        /* 10.
         * Implement the previous using the same query expressed with extension methods.
         */

        static void FindStudentsFromSecondGroupWithLambda()
        {
            var studentsFromSecondGroupWithLambda = students.Where(x => x.GroupNumber == 2).OrderBy(x => x.FirstName);

            Print(studentsFromSecondGroupWithLambda);
        }

        /* 11.
         * Extract all students that have email in abv.bg. Use string methods and LINQ.
         */

        static void FindStudentsWithEmailInAbv()
        {
            // with LINQ:
            var studentWithEmailInAbv =
                from student in students
                where student.Email.EndsWith("abv.bg")
                select student;

            //// with Lambda:
            // var studentsWithEmailInAbvLambda = students.Where(st => st.Email.EndsWith("abv.bg"));
            // Print(studentsWithEmailInAbvLambda);

            Print(studentWithEmailInAbv);
        }

        /* 12.
         * Extract all students with phones in Sofia. Use LINQ.
         */

        static void FindStudentsWithSofiaPhoneNumber()
        {
            // with LINQ:
            var studentsWithSofiaPhoneNumbers =
                from student in students
                where student.Tel.StartsWith("02")
                select student;

            //// with Lambda:
            // studentsWithSofiaPhoneNumbersLambda = students.Where(st => st.Tel.StartsWith("02"));
            // Print(studentsWithSofiaPhoneNumbersLambda);

            Print(studentsWithSofiaPhoneNumbers);
        }

        /* 13.Select all students that have at least one mark Excellent (6)
         * into a new anonymous class that has properties – FullName and Marks. Use LINQ.
         */

        static void FindStudentsWithAtLeastOneExcellentMark()
        {
            // with LINQ:
            var studentsWithExcellentMark =
                from student in students
                where student.ContainMark(6)
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };

            //// with Lambda:
            //var studentsWithExcellentMarkLambda = students.Where(st => st.ContainMark(6)).Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.GetMarks() });

            //foreach (var student in studentsWithExcellentMarkLambda)
            //{
            // Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            //}

            foreach (var student in studentsWithExcellentMark)
            {
                Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            }
        }

        /* 14.
         * Write down a similar program that extracts the students with exactly two marks "2".
         * Use extension methods.
         */

        static void FindStudentsWithExactlyTwoMarks2()
        {
            const int markToFind = 2;
            const int markAppearences = 2;

            // with LINQ:
            var studentsWithExactlyTwoMarks2 =
                from student in students
                where student.Marks.Count(x => x == markToFind) == markAppearences
                select new { FullName = student.FirstName + " " + student.LastName, Marks = student.GetMarks() };

            //// with Lambda:
            //var studentsWithExactlyTwoMarks2Lambda = students.Where(st => st.Marks.Count(m => m == markToFind) == markAppearences).Select(st => new { FullName = st.FirstName + " " + st.LastName, Marks = st.GetMarks() });

            //foreach (var student in studentsWithExactlyTwoMarks2Lambda)
            //{
            // Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            //}

            foreach (var student in studentsWithExactlyTwoMarks2)
            {
                Console.WriteLine("{0} -> {1}", student.FullName, student.Marks);
            }

            Console.WriteLine();
        }

        /* 15.Extract all Marks of the students that enrolled in 2006. 
         * (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).
         * substring from element on position 4 (not position 5) because the indeces start from 0
         */

        static void FindStudentMarksEnrolledIn2006()
        {
            // with LINQ:
            var studentsEnrolledIn2006 =
                from student in students
                where student.FN.Substring(4, 2) == "06"
                select new { FullName = student.FirstName + " " + student.LastName, FN = student.FN, Marks = student.GetMarks() };

            //// with Lambda:
            //var studentsEnrolledIn2006Lambda = students.Where(st => st.FN.Substring(4, 2) == "06").Select(st => new { FullName = st.FirstName + " " + st.LastName, FN = st.FN, Marks = st.GetMarks() });

            //foreach (var student in studentsEnrolledIn2006Lambda)
            //{
            // Console.WriteLine("{0} - FN: {1} -> {2}", student.FullName, student.FN, student.Marks);
            //}
            //Console.WriteLine();

            foreach (var student in studentsEnrolledIn2006)
            {
                Console.WriteLine("{0} - FN: {1} -> {2}", student.FullName, student.FN, student.Marks);
            }
            Console.WriteLine();
        }


        static List<Student> students;
        static void Main()
        {
            students = new List<Student>()
            {
                new Student("Ivan", "Slivkov", "361059", "0883533225", "islivkov@abv.bg", new List<int> {6, 5, 6 ,6}, 2),
                new Student("Lyubima", "Dasheva", "361061", "0889893412", "ldasheva@gmail.com", new List<int> {2, 3, 4}, 2),
                new Student("Stefan", "Dobrev", "361062", "0881234567", "sdobrev@abv.bg", new List<int> {6, 5, 6}, 4),
                new Student("Aleksandur", "Sotirov", "361099", "911", "asotirov@gmail.com", new List<int> {6, 6}, 2),
                new Student("Kristina", "Hristova", "361084", "166", "khristova@abv.bg", new List<int>{2, 2, 3, 3}, 5),
                new Student("Sanya", "Spasova", "361103", "0888320888", "sspasova@gmail.com", new List<int> {2, 2, 3, 3, 4}, 1)

            };

            FindStudentsFromSecondGroupWithLinq();

            FindStudentsFromSecondGroupWithLambda();

            FindStudentsWithEmailInAbv();

            FindStudentsWithSofiaPhoneNumber();

            FindStudentsWithAtLeastOneExcellentMark();

            FindStudentsWithExactlyTwoMarks2();

            FindStudentMarksEnrolledIn2006();
        }
    }
}
