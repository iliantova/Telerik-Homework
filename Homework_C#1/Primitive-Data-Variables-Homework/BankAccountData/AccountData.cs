//Problem 11. Bank Account Data

//A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN,
//3 credit card numbers associated with the account.
//Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.


using System;


class AccountData
{
    class Bank
    {

        public string ClientName = "Kintun Matu Degu";
        public decimal MoneyBalance = 1234567890;
        public string BankName = "Birnicy";
        public string IBAN = "123456WERT1235123545";
        public ulong CardNumber1 = 1234567895874;
        public ulong CardNumber2 = 7894561231211;
        public ulong CardNumber3 = 5478965123545;
    
    }
    static void Main()
    {
        Bank BankBirnicy= new Bank();
            Console.WriteLine("Name: {0}", BankBirnicy.ClientName);
            Console.WriteLine("Balance: {0}", BankBirnicy.MoneyBalance );
            Console.WriteLine("Bank: {0}", BankBirnicy.BankName);
            Console.WriteLine("IBAN: {0}", BankBirnicy.IBAN);
            Console.WriteLine("Card Number: {0}", BankBirnicy.CardNumber1);
            Console.WriteLine("Card Number: {0}", BankBirnicy.CardNumber2);
            Console.WriteLine("Card Number: {0}", BankBirnicy.CardNumber3);

    }
}
