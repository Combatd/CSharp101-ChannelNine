﻿using System;

namespace classes
{
    public class BankAccount
    {
        // hidden encapsulated data
        private static int accountNumberSeed = 1234567890;

        public string Number { get; }
        public string Owner { get; set; }
        public decimal Balance { get; }

        // constructor method
        // A constructor is a member that has the same name as the class. It is used to initialize objects of that class type.
        public BankAccount(string name, decimal initialBalance)
        {
            this.Owner = name;
            this.Balance = initialBalance;
            this.Number = accountNumberSeed.ToString();
            accountNumberSeed++;
        }

        public void MakeDeposit(decimal amount, DateTime date, string note)
        {
        }

        public void MakeWithdrawal(decimal amount, DateTime date, string note)
        {
        }
    }
}