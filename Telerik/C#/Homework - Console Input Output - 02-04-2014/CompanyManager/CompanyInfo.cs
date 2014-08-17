using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompanyManager
{
    class CompanyInfo
    {
        //A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number. 
        //Write a program that reads the information about a company and its manager and prints them on the console.
        static void Main(string[] args)
        {
            Console.Write("Input Company Name: ");
            string companyName = Console.ReadLine();
            Console.Write("Input Company Address: ");
            string address = Console.ReadLine();
            Console.Write("Input Company Phone number: ");
            string companyPhone = Console.ReadLine();
            Console.Write("Input Company Fax number: ");
            string companyFax = Console.ReadLine();
            Console.Write("Input Company Website: ");
            string website = Console.ReadLine();
            Console.Write("Input Manager First Name: ");
            string managerFirstName = Console.ReadLine();
            Console.Write("Input Manager Last Name: ");
            string managerLastName = Console.ReadLine();
            Console.Write("Input Manager Age: ");
            byte age = 0;
            byte.TryParse(Console.ReadLine(), out age); // Will default at 0 if parsing fails.
            Console.Write("Input Manager's Phone Number: ");
            string managerPhone = Console.ReadLine();
            if (companyFax.Length <= 1) companyFax = "(no fax)";
            Console.WriteLine("The Company {0}\nlocated at {1} or at the website {2}\n(Tel. {7}, Fax: {8}\nhas a manager by the name of {3} {4},\nwho is {5} years old\nand can be reached by calling {6}.", 
                companyName, address, website, managerFirstName, managerLastName, age, managerPhone, companyPhone, companyFax);
        }
    }
}
