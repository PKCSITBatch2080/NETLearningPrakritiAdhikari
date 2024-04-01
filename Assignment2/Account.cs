// File: Account.cs

using System;

namespace BankingSystem
{
    // Abstract base class representing an account
    public abstract class Account
    {
        public abstract void Deposit(decimal amount);
        public abstract void Withdraw(decimal amount);
    }
}
