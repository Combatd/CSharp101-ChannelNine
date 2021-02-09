using System;

namespace classes
{
    /*
     * An interest earning account:
        Will get a credit of 2% of the month-ending-balance.
     */

    // inherits from BankAccount
    public class InterestEarningAccount : BankAccount
    {
        // constructor
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

    }
}
