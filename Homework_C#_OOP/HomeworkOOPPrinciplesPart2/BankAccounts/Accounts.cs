namespace BankAccounts
{
    using System;
  public abstract class Accounts
    {

       private Customers customer;
        private decimal balance;
        private decimal interestRate;
        private int numberAccount;

       

        public Accounts(Customers customer, decimal balance, decimal interestRate, int numberAccount)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
            this.NumberAccount = numberAccount;
        }

      public Customers Customer
       {
           get { return this.customer; }
           set
           {
               if (value == null)
               {
                   throw new ArgumentNullException("Bank account with no Customer defined is a no-go");
               }
               this.customer = value;
           }
       }
       public decimal Balance
       {
           get { return this.balance; }
           set { this.balance = value; }
       }
       public decimal InterestRate
       {
           get { return this.interestRate; }
           set
           {
               if (value < 0)
               {
                   throw new ArgumentException("Interest rate cannot be a negative number!");
               }
               this.interestRate = value;
           }
       }
       public int NumberAccount
       {
           get { return this.numberAccount; }
           set
           {
               if (value == 0)
               {
                   throw new ArgumentNullException("Enter number of bank account!");
               }
               this.numberAccount = value;
           }
       }

       public virtual decimal InterestCalculations(int months)
       {
           if (months < 0)
           {
               throw new ArgumentException("Number of months cannot be a negative amount");
           }

           return months * (this.InterestRate / 100m * this.Balance);
       }

       public override string ToString()
       {
           
               return string.Format("Number account: {3} \n Name customer: {0}  Balance: {1:c}  iRate: {2}", this.Customer.Name, this.Balance, this.InterestRate, this.NumberAccount);
          
           
       }

    }
}
