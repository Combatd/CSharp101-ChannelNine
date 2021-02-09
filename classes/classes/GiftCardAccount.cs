using System;
namespace classes
{
    /*
     * A gift card account:
        Can be refilled with a specified amount once each month, on the last day of the month.
     */

    public class GiftCardAccount : BankAccount
    {
        private decimal _monthlyDeposit = 0m;

        public GiftCardAccount(string name, decimal initialBalance, decimal monthlyDeposit = 0) : base(name, initialBalance)
            => _monthlyDeposit = monthlyDeposit;


        /*
         * The constructor provides a default value for the monthlyDeposit value so callers can omit a 0 for no monthly deposit.
         */

        public override void PerformMonthEndTransactions()
        {
            if (_monthlyDeposit != 0)
            {
                MakeDeposit(_monthlyDeposit, DateTime.Now, "Add monthly deposit");
            }
        }
    }
}
