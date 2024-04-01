
// File: Program.cs

using System;

namespace BankingSystem
{
    // Main program
    class Program
    {
        static void Main(string[] args)
        {
            // Creating a Savings Account
            SavingsAccount savingsAccount = new SavingsAccount();
            savingsAccount.Deposit(1000);
            savingsAccount.Withdraw(200);

            // Creating an Investment Account
            InvestmentAccount investmentAccount = new InvestmentAccount();
            investmentAccount.Deposit(5000);
            investmentAccount.Transfer(savingsAccount, 1000);
        }
    }
}
