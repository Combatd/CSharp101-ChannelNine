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

        /*
         * Let's start by adding a second constructor that includes an optional minimumBalance parameter. 
         * This new constructor does all the actions done by the existing constructor. 
         * Also, it sets the minimum balance property. 
         * You could copy the body of the existing constructor. but that means two locations to change in the future. 
         * Instead, you can use constructor chaining to have one constructor call another. 
         *
         */
        private readonly decimal minimumBalance;

        public BankAccount(string name, decimal initialBalance) : this(name, initialBalance, 0) { }

        public BankAccount(string name, decimal initialBalance, decimal minimumBalance)
        {
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;

            this.Owner = name;
            this.minimumBalance = minimumBalance;
            if (initialBalance > 0)
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
            if (Balance - amount < minimumBalance)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Transaction(-amount, date, note);
            allTransactions.Add(withdrawal);
        }

        /*
         * A virtual method is a method where any derived class may choose to reimplement. 
         * The derived classes use the override keyword to define the new implementation. 
         * Typically you refer to this as "overriding the base class implementation". 
         * The virtual keyword specifies that derived classes may override the behavior. 
         * 
         * You can also declare abstract methods where derived classes must override the behavior. 
         * The base class does not provide an implementation for an abstract method. 
         * Next, you need to define the implementation for two of the new classes you've created. 
         * Start with the InterestEarningAccount:
         */

        public virtual void PerformMonthEndTransactions() {

        }

    }
}