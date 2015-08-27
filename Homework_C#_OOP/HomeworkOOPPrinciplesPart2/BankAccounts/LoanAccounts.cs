
namespace BankAccounts
{
    using System;
   public class LoanAccounts : Accounts, IDeposit
    {

       public LoanAccounts(Customers customer, decimal balance, decimal interestRate, int numberAccount)
            : base(customer, balance, interestRate, numberAccount)
        {

        }

      
       public override decimal InterestCalculations(int months)
       {
           if (this.Customer is IndividualsCustomers)
           {
               months -= 3;
           }
           else if (this.Customer is CompaniesCustomers)
           {
               months -= 2;
           }

           if (months < 0)
           {
               return 0;
           }

           return base.InterestCalculations(months);
       }

       public void DepositMoney(decimal moneyAmount)
       {
           if (moneyAmount < 0)
           {
               throw new ArgumentException("You cannot deposit a negative value!");
           }

           this.Balance += moneyAmount;
       }


    }
}
