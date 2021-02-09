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
        // You use the : base() syntax to indicate a call to a base class constructor.
        // Some classes define multiple constructors, and this syntax enables you to pick which base class constructor you call.
        public InterestEarningAccount(string name, decimal initialBalance) : base(name, initialBalance)
        {

        }

        public override void PerformMonthEndTransactions()
        {
            if (Balance > 500m)
            {
                var interest = Balance * 0.05m;
                MakeDeposit(interest, DateTime.Now, "apply monthly interest");
            }
        }

    }
}
