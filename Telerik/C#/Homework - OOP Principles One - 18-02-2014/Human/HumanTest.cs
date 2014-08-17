using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class HumanTest
    {
        private static List<Student> GetStudents()
        {
            List<Student> studentsList = new List<Student>();
            studentsList.Add(new Student("Random", "Name", 3.46));
            studentsList.Add(new Student("Name", "Random", 4.59));
            studentsList.Add(new Student("Pesho", "Goshev", 6.00));
            return studentsList;

        }
        private static List<Worker> GetWorkers()
        {
            List<Worker> workersList = new List<Worker>();
            workersList.Add(new Worker("Gosho", "Peshev", 1880, 10));
            workersList.Add(new Worker("Hristo", "Botev", 2200, 12));
            workersList.Add(new Worker("Botio", "Hristov", 1244, 7.5));
            return workersList;
        }
        static void Main()
        {
            List<Student> studentsList = GetStudents();
            List<Student> sortedStudents =
                (from student in studentsList
                orderby student.Grade
                select student).ToList();

            List<Worker> workersList = GetWorkers();
            List<Worker> sortedWorkers =
                (from worker in workersList
                 orderby worker.MoneyPerHour() descending
                 select worker).ToList();

            List<Human> allHumans = new List<Human>();
            foreach (var student in sortedStudents)
            {
                allHumans.Add(student);
            }
            foreach (var worker in sortedWorkers)
            {
                allHumans.Add(worker);
            }
            var sortedHumans =
                from human in allHumans
                orderby human.LastName
                orderby human.FirstName
                select human;
            foreach (var human in sortedHumans)
            {
                Console.WriteLine(human);
            }
        }

       
    }
}
