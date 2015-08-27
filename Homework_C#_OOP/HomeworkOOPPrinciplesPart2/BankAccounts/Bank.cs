namespace BankAccounts
{
    using System.Collections.Generic;
    class Bank 
    {

        public List<Accounts> Accounts { get; private set; }
        private string bankName;
        private string bankId;

        public Bank()
        {
            this.Accounts = new List<Accounts>();
        }
        public Bank(string name, string id)
            : this()
        {
            this.Name = name;
            this.ID = id;
        }
        public string Name
        {
            get
            {
                return this.bankName;
            }
            set
            {
                this.bankName = value;
            }
        }
        public string ID
        {
            get
            {
                return this.bankId;
            }
            set
            {
                this.bankId = value;
            }
        }

         public override string ToString()
        {
            return string.Format("Bank : {0} ID: {1}", this.Name, this.ID);
        }
        
       
    }
}
