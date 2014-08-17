using System;

class BankTest
{
    static void Main(string[] args)
    {

        /*A bank holds different types of accounts for its customers: deposit accounts, loan 
         * accounts and mortgage accounts. Customers could be individuals or companies.
         * 
         * All accounts have customer, balance and interest rate (monthly based). 
         * 
         * Deposit accounts are allowed to deposit and with draw money. 
         * 
         * Loan and mortgage accounts can only deposit money.
         * All accounts can calculate their interest amount for a given period (in months). In the 
         * common case its is calculated as follows: number_of_months * interest_rate.
         * 
         * Loan accounts have no interest for the first 3 months if are held by individuals and for the 
         * first 2 months if are held by a company.
         * 
         * Deposit accounts have no interest if their balance is positive and less than 1000.
         * 
         * Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the
         * first 6 months for individuals.
         * 
         * Your task is to write a program to model the bank system by classes and interfaces. You should
         * identify the classes, interfaces, base classes and abstract actions and implement the calculation
         * of the interest functionality through overridden methods.
         */


        Company RandomTelerik = new Company("RandomTelerik");
        Individual pesho = new Individual("Pesho Peshev");

        //Test deposit accounts for an individual and a company
        DepositAccount peshoDeposit = new DepositAccount(pesho, 500m, 0.05m);
        DepositAccount companyDeposit = new DepositAccount(RandomTelerik, 1500m, 0.05m);

        peshoDeposit.Draw(200m);
        Console.WriteLine(peshoDeposit.Balance);
        peshoDeposit.AddDeposit(200);
        Console.WriteLine(peshoDeposit.Balance);

        Console.WriteLine();

        Console.WriteLine("The {0} of the {1}-{2} \nhas an interest amount of {3} for the next six months. ", peshoDeposit.GetType(), peshoDeposit.Customer.GetType(), peshoDeposit.Customer.Name, peshoDeposit.InterestAmountForPeriod(6));
        Console.WriteLine("\nThe {0} of the {1}-{2} \nhas an interest amount of {3} for the next six months. ", companyDeposit.GetType(), companyDeposit.Customer.GetType(), companyDeposit.Customer.Name, companyDeposit.InterestAmountForPeriod(6));
        Console.WriteLine("\n");

        //Test loan accounts for an individual and a company
        LoanAccount peshoLoan = new LoanAccount(pesho, 500m, 0.05m);
        LoanAccount companyLoan = new LoanAccount(RandomTelerik, 500m, 0.05m);

        Console.WriteLine("The {0} of the {1}-{2} \nhas an interest amount of {3} for the next six months. ", peshoLoan.GetType(), peshoLoan.Customer.GetType(), peshoLoan.Customer.Name, peshoLoan.InterestAmountForPeriod(6));
        Console.WriteLine("\nThe {0} of the {1}-{2} \nhas an interest amount of {3} for the next six months. ", companyLoan.GetType(), companyLoan.Customer.GetType(), companyLoan.Customer.Name, companyLoan.InterestAmountForPeriod(6));
        Console.WriteLine("\n");

        //Test mortgage accounts for an individual and a company
        Mortgage peshoMortgage = new Mortgage(pesho, 500m, 0.05m);
        Mortgage companyMortgage = new Mortgage(RandomTelerik, 500m, 0.05m);

        Console.WriteLine("The {0} of the {1}-{2} \nhas an interest amount of {3} for the next six months. ", peshoMortgage.GetType(), peshoMortgage.Customer.GetType(), peshoMortgage.Customer.Name, peshoMortgage.InterestAmountForPeriod(24));
        Console.WriteLine("\nThe {0} of the {1}-{2} \nhas an interest amount of {3} for the next six months. ", companyMortgage.GetType(), companyMortgage.Customer.GetType(), companyMortgage.Customer.Name, companyMortgage.InterestAmountForPeriod(24));

    }
}

