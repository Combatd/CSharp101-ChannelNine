using System;
using System.Collections.Generic;

namespace classes
{
    public class BankAccount
    {
        // hidden encapsulated data
        // private, which means it can only be accessed by code inside the BankAccount class
        // static, which means it is shared by all of the BankAccount objects
        private static int accountNumberSeed = 1234567890;

        public string Number { get; }
        public string Owner { get; set; }

        // computation enumerates all transactions, and provides the sum as the current balance.
        public decimal Balance {
            get
            {
                decimal balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
        }

        // constructor method
        // A constructor is a member that has the same name as the class. It is used to initialize objects of that class type.
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}