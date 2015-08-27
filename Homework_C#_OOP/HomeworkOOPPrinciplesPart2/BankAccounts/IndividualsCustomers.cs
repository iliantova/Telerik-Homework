namespace BankAccounts
{
  public  class IndividualsCustomers : Customers
    {

      public IndividualsCustomers(string name, string address, string phone, ulong egn)
            : base(name, address, phone)
        {
            this.Egn = egn;
        }

        public ulong Egn { get; private set; }



    }
}
