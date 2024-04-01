// File: SavingsAccount.cs

using System;

namespace BankingSystem
{
    // Concrete class representing a savings account
    public class SavingsAccount : Account, ITransferable
    {
        private decimal balance;

        public override void Deposit(decimal amount)
        {
            balance += amount;
            Console.WriteLine($"{amount} deposited into Savings Account.");
        }

        public override void Withdraw(decimal amount)
        {
            if (balance >= amount)
            {
                balance -= amount;
                Console.WriteLine($"{amount} withdrawn from Savings Account.");
            }
            else
            {
                Console.WriteLine("Insufficient funds.");
            }
        }

        public void Transfer(Account destination, decimal amount)
        {
            Withdraw(amount);
            destination.Deposit(amount);
            Console.WriteLine($"{amount} transferred from Savings Account.");
        }
    }
}
