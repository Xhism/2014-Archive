using System;

class StudentTest
{
    static void Main(string[] args)
    {

        /* 01.
         * Define a class Student, which contains data about a student – first, middle and last name,
         * SSN, permanent address, mobile phone e-mail, course, specialty, university, faculty. 
         * Use an enumeration for the specialties, universities and faculties. Override the standard methods,
         * inherited by  System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.
        */

        /* 02.
         * Add implementations of the ICloneable interface. The Clone() method should deeply copy all
         * object's fields into a new object of type Student.
        */

        /* 03.
         * Implement the  IComparable<Student> interface to compare students by names (as first criteria,
         * in lexicographic order) and by social security number (as second criteria, in increasing order).
        */

        Student pesho = new Student("Pesho", "Petkov", "Peshev", 12764397, "Al. Malinov 3 street", 0888123456, "email@address.com", 2, Universities.SofiaUniversity, Faculties.MathematicsAndInformaticsFaculty, Specialties.Informatics);

        Console.WriteLine("Original student ID:");
        Console.WriteLine(pesho);
        Console.WriteLine();

        Student gencho = pesho.Clone();
        Console.WriteLine("Clone student ID:");
        Console.WriteLine(gencho);

        Console.WriteLine();

        Console.WriteLine("Compared with clone: " + pesho.CompareTo(gencho));
        gencho.FirstName = "Gencho";
        Console.WriteLine("Compared with different name: " + pesho.CompareTo(gencho));
    }
}

