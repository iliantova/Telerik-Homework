
namespace BankAccounts
{
    using System;
    class TestBank
    {
        static void Main()
        {
           
            Bank myBank = new Bank("Birnici", "FBS004269");
            myBank.Accounts.Add(new DepositAccounts(new IndividualsCustomers("Ivan Ivanov", "Glavnata str", "893873", 7804659087), 5000m, 30m, 12345678));
            myBank.Accounts.Add(new MortgageAccounts(new CompaniesCustomers("TheBest OOD", "TheOnlyOne str", "+3592889765", 8653527848726), 100m, 40m, 58745698));
            myBank.Accounts.Add(new LoanAccounts(new IndividualsCustomers("Krasimir Krasimirov", "MiddleOfNowhere", "+122734471", 8809136173), 9999m, 100m, 5689474));
            myBank.Accounts.Add(new MortgageAccounts(new IndividualsCustomers("Elenko Elenkov", "File Elena", "+359889882345", 8903130490), 1020.345m, 4.5m, 46851245));

            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<<<<<<<<<<< {0} >>>>>>>>>>>>>>>>>>>>", myBank);
            Console.WriteLine();
            Console.WriteLine("<<<<<<<<<<< Accounts >>>>>>>>>>>>");
            foreach (var account in myBank.Accounts)
            {
                Console.WriteLine(account);
                
            }

            Console.WriteLine();
            Console.WriteLine("---------------------------------------------------------------------");
            Console.WriteLine("\nDisplaying the result from the interest calculations:");
            Console.WriteLine("---------------------------------------------------------------------");
            try
            {
            int month = 7;
            foreach (var account in myBank.Accounts)
            {
                Console.WriteLine("Name: {1} \n Account type: {3}  Period(months): {2} - Interest calc result: {0:c}", account.InterestCalculations(month), account.Customer.Name, month, account.GetType().Name);
                Console.WriteLine();
            }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            
         }
    }
}
