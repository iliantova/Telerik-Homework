namespace BankAccounts
{
    using System;
    class DepositAccounts : Accounts, IDeposit, IDraw
    {
        public DepositAccounts(Customers customer, decimal balance, decimal interestRate, int numberAccount)
            : base(customer, balance, interestRate, numberAccount)
        {

        }

       
        public override decimal InterestCalculations(int months)
        {
            if (this.Balance > 0 && this.Balance < 1000m)
            {
                return 0m;
            }

            return base.InterestCalculations(months);
        }

        public void DepositMoney(decimal moneyAmount)
        {
            TransactionCheck(moneyAmount);

            this.Balance += moneyAmount;
        }

        public void MoneyWithdraw(decimal moneyAmount)
        {
            TransactionCheck(moneyAmount);
            this.Balance -= moneyAmount;
        }

        private static void TransactionCheck(decimal moneyAmount)
        {
            if (moneyAmount < 0)
            {
                throw new ArgumentException("You cannot deposit/withdraw a negative value!");
            }
        }

    }
}
