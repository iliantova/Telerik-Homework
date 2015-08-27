//Problem 10. Employee Data

//A marketing company wants to keep record of its employees. Each record would have the following characteristics:

//First name
//Last name
//Age (0...100)
//Gender (m or f)
//Personal ID number (e.g. 8306112507)
//Unique employee number (27560000…27569999)
//Declare the variables needed to keep the
//information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

using System;

class DataEmployee
{
    class Employee
    {
        public string FirstName = "Kintun";
        public string LastName = "Matu";
        public byte Age = 30;
        public char Gender = 'f';
        public long IDNumber = 1234567890;
        public uint EmployeeNumber = 27548915;
        
    }
        static void Main()
        {
            Employee DataEmployee = new Employee();


            Console.WriteLine("Name: {0}", DataEmployee.FirstName);
            Console.WriteLine("Last name: {0}", DataEmployee.LastName );
            Console.WriteLine("Age: {0}", DataEmployee.Age);
            Console.WriteLine("Gender: {0}", DataEmployee.Gender);
            Console.WriteLine("ID: {0}", DataEmployee.IDNumber);
            Console.WriteLine("Unique Number: {0}", DataEmployee.EmployeeNumber);

        }
}