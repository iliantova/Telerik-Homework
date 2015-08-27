namespace BankAccounts
{
  public  class CompaniesCustomers : Customers
    {

      public CompaniesCustomers(string name, string address, string phone, ulong bulstat)
            : base(name, address, phone)
        {
            this.Bulstat = bulstat;
        }

        public ulong Bulstat { get; private set; }



    }
}
