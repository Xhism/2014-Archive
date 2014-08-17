using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Employees
{
    // A marketing firm wants to keep record of its employees. 
    // Each record would have the following characteristics – first name, family name, age, gender (m or f), ID number, unique employee number (27560000 to 27569999).
    // Declare the variables needed to keep the information for a single employee using appropriate data types and descriptive names.

    class Employees
    {
        

        static void Main(string[] args)
        {
            string firstName = "Pesho", familyName = "Peshev";
            byte age = 40;
            char gender;
            bool gendercheck = true; //True = male, False = female
            if(gendercheck == true) gender='m';
            else gender='f';
            uint employeeNumber = 27560001;
            Console.WriteLine("Employee number {0}, {1} {2}, age {3}, {4}", employeeNumber, firstName, familyName, age, gender);
        }
    }
}
