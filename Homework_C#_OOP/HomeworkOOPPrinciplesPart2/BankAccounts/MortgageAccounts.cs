namespace BankAccounts
{
    using System;
   public class MortgageAccounts : Accounts, IDeposit
    {

       public MortgageAccounts(Customers customer, decimal balance, decimal interestRate, int numberAccount)
            : base(customer, balance, interestRate, numberAccount)
        {

        }

       public override decimal InterestCalculations(int months)
       {
           if (this.Customer is IndividualsCustomers)
           {
               if (months <= 12)
               {
                   return base.InterestCalculations((int)(months * 0.5));
               }
               else
               {
                   decimal result = 0.5m * base.InterestCalculations(12);
                   result += base.InterestCalculations(months - 12);
                   return result;
               }
           }
           else
           {
               if (months <= 6)
               {
                   return 0m;
               }
               else
               {
                   months -= 6;
                   return base.InterestCalculations(months);
               }
           }
       }

       public void DepositMoney(decimal moneyAmount)
       {
           if (moneyAmount < 0)
           {
               throw new ArgumentException("You cannot deposit a negative value! Go home, you are drunk.");
           }

           this.Balance += moneyAmount;
       }


    }
}
