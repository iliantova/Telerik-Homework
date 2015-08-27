//Problem 2. Print Company Information

//A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//Write a program that reads the information about a company and its manager and prints it back on the console.





using System;


    class CompanyData
    {
        static void Main()
        {

            System.Console.Write("Please, enter company name: ");
            string CompanyName = Console.ReadLine();

            System.Console.Write("Please, enter company address: ");
            string ComppanyAdress = Console.ReadLine();

            System.Console.Write("Please, enter phone number in format +359 XXXXXXXXX: ");
            string CompanyPhone = Console.ReadLine();

            System.Console.Write("Please, enter fax number: ");
            string CompanyFax = Console.ReadLine();

            System.Console.Write("Please, enter company Web site: ");
            string Website = Console.ReadLine();

            System.Console.Write("Please, enter manager first name: ");
            string ManagerName = Console.ReadLine();

            System.Console.Write("Please, enter manager's last name: ");
            string ManagerLastName = Console.ReadLine();

            System.Console.Write("Please, enter manager's age:: ");
            string ManagerAge = Console.ReadLine();

            System.Console.Write("Please, enter manager's phone: ");
            string ManagerPhone = Console.ReadLine();




            Console.WriteLine(CompanyName);
            Console.WriteLine("Address: {0}", ComppanyAdress);
            Console.WriteLine("Tel.: {0}", CompanyPhone);
            Console.WriteLine("Fax: {0}", CompanyFax);
            Console.WriteLine("Web site: {0}", Website);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3} )", ManagerName, ManagerLastName,ManagerAge, ManagerPhone);









        }
    }

