using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccount
{
    //A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, BIC code and 3 credit card numbers associated with the account. 
    //Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

    class BankAccount
    {
        static void Main(string[] args)
        {
            string firstName = "Pesho", middleName = "Peshev", familyName = "Petrov";
            double balance = 100.00;
            string bankName = "Thieves Bank";
            string IBAN = "GB 12 CPBK 0892 9965 0449 91";
            string BIC = "THBAGB2LXXX";
            ulong credit1 = 1234567890123456;
            ulong credit2 = 2345678901234567;
            ulong credit3 = 3456789012345678;
            Console.WriteLine("The bank account of {0} {1} {2}\n at {9} with IBAN {3} or BIC {4}\n uses credit numbers {5}, {6}, and {7}\n and has a balance of {8}", firstName, middleName, familyName, IBAN, BIC, credit1, credit2, credit3, balance, bankName);
        }
    }
}
