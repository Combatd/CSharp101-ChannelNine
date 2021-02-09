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

        public string GetAccountHistory()
        {
            var report = new System.Text.StringBuilder();

            decimal balance = 0;
            report.AppendLine("Date\t\tAmount\tBalance\tNote");
            foreach (var item in allTransactions)
            {
                balance += item.Amount;
                report.AppendLine($"{item.Date.ToShortDateString()}\t{item.Amount}\t{balance}\t{item.Notes}");
            }

            return report.ToString();
        }

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
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            MakeDeposit(initialBalance, DateTime.Now, "Initial balance");
        }

        private List<Transaction> allTransactions = new List<Transaction>();

        /*
         * The standard way of indicating that a method cannot complete its work successfully is to throw an exception. 
         * The type of exception and the message associated with it describe the error. Here, the MakeDeposit method throws an exception if the amount of the deposit is negative. 
         * The MakeWithdrawal method throws an exception if the withdrawal amount is negative, 
         * or if applying the withdrawal results in a negative balance.
         */

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Transaction(amount, date, note);
            allTransactions.Add(deposit);
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

    }
}